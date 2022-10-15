/*******************************************************************************
*                                                                              *
* UNHUF.C   by Shaun Case   April 1991                                         *
*                                                                              *
* Written in Borland C++ 2.0 under MS-DOS 3.3                                  *
*                                                                              *
* Decompresses a single file encoded with companion program HUF,               *
* which uses Huffman encoding.                                                 *
*                                                                              *
* This program is in the public domain.                                        *
*                                                                              *
* atman%ecst.csuchico.edu@RELAY.CS.NET                                         *
*                                                                              *
*                                                                              *
*******************************************************************************/

#include <stdio.h>
#include <math.h>

#define FALSE 0
#define TRUE !FALSE
#define MAX_DECODE_TABLE_SIZE 520       /* 512 should be enough           */


/* uncomment the next line to see the decode table at runtime. */

/*
#define DEBUG
*/


/* uncomment the next line to only uncompress the exact number of bytes   */
/* that were originally encoded.  If it is not defined, the routine will  */
/* faster, but will generate up to 8 extra bytes at the end of the        */
/* decompressed data.                                                     */

#define EXACT


typedef struct decode_table_element {   /* template for decode table element (wow)  */
    unsigned char letter;               /* which character to decode to             */
    char spare;                         /* force 16-bit word alignment              */
    short left;                         /* index of lower left element from tree    */
    short right;                        /* index of lower right element from tree   */
}decode_table_element;


short array_max_index;                  /* max number of elements in array (to be   */
                                        /* determined in create_decode_table() )    */

unsigned long  total;                   /* total number of unencoded bytes          */
FILE *infile;                           /* file ptr to SYSTEM.HUF (compressed)      */
FILE *outfile;                          /* file ptr to SYSTEM.UNH (decompressed)    */
char *infilename;                       /* name of the input file                   */
char origfilename[13];                  /* name of the original file                */

struct decode_table_element             /* array implementation of huffman tree     */
    decode_table[MAX_DECODE_TABLE_SIZE];

/******
 *
 * Datafile:  All 16/32 bit quantities in Intel byte ordering
 *
 *  13 bytes    : original filename (8.3 + '\0')
 *  16 bits     : number of array elements needed, N (N == 511 means 512 array
 *                elements -> 0..511)
 *  32 bits     : size of uncompressed original data in bytes
 *  N * 6 bytes : Array elements in order 0 .. N
 *                struct decode_table_element {
 *                     char letter;      8 bits
 *                     char spare;       8 bits
 *                     short left;      16 bits
 *                     short right;     16 bits
 *                 }
 *  <?>          : compressed data, effectively a bit stream
 *
 ******/


int main(int argc, char **argv)
{
    short read_header(void);                /* prototype */
    void show_bit_sequences(short index);   /* prototype */
    short uncompress(void);                 /* prototype */

    if (argc != 2) {                        /* check command line argument validity  */
        puts("'unhuf file' decodes file.");
        return 1;
	}
    puts("Unhuf by Shaun Case, 1991, public domain");

    infilename=argv[1];


    if (read_header() != 0)                 /* read in file name, size, decode table */
        return 1;

#ifdef DEBUG
    show_bit_sequences(0);
#endif

    if (uncompress() != 0)                  /* uncompress the data & write to file   */
        return 1;

    fclose(infile);

    return 0;

}

/*
 * read in the original filename, size, and decode table
 *
 */

short read_header(void)
{
    if ((infile=fopen(infilename, "rb")) == NULL)        /* open file           */
    {
        printf("Unable to open %s\n", infilename);
        return 1;
    }


    if (                                                 /* get original name   */
          fread((void *)origfilename, 1, 13, infile)
          < 13
       )
    {
        printf("Unable to read original filename from %s\n", infilename);
        fclose(infile);
        return 1;
    }

                                                         /* get length of decode table */
    if (
          fread((void *)&array_max_index, sizeof(short), 1, infile)
          < 1
       )
    {
        printf("Unable to read number of array elements from %s\n", infilename);
        fclose(infile);
        return 1;
    }

        if (                                             /* get filesize in bytes */
              fread((void *)&total, sizeof(unsigned long), 1, infile)
            < 1
       )
    {
        printf("Unable to read original byte count from %s\n", infilename);
        fclose(infile);
        return 1;
    }

    printf("Decoding %ld bytes to %s.\n", total, origfilename);
    printf("Decode table contains %d elements.\n",array_max_index + 1);

    if (                                                /* get decode table        */
          fread((void *)decode_table, sizeof(decode_table_element), array_max_index + 1, infile)
          < (array_max_index + 1)
       )
    {
        printf("Unable to read decode table from %s\n", infilename);
        fclose(infile);
        return 1;
    }

    return 0;
}

#ifdef DEBUG
short seq_len=0;  /* routine is recursive, needs global storage  */
                  /* length of current bit sequence              */
                  /* this should probably be static inside sbs() */


/*
 * display the bit sequences that represent each character.
 * useful for debugging.
 *
 */

void show_bit_sequences(short index)
{

    static short temp_index=0;
    static char bit_sequence[16];       /* where to build the huffman bit sequence  */

    if (decode_table[index].left != 0)  /* if we are not at a leaf, go left         */
    {
        bit_sequence[seq_len++]='1';
        show_bit_sequences(decode_table[index].left);
        seq_len--;
    }
                                        /* returned from going left, now try right  */
    if (decode_table[index].right != 0)
    {
        bit_sequence[seq_len++]='0';    /* if we are not at a leaf, go right        */
        show_bit_sequences(decode_table[index].right);
        seq_len--;
    }

    if (decode_table[index].left != NULL)    /* we are at an interior node going back up */
        return;

    /* we are at a leaf, therefore we have a complete bit sequence built            */

    bit_sequence[seq_len] = 0;          /* append teriminating NULL to string       */

    printf("[%3d] %3d == %16s == %3d\n", temp_index, decode_table[index].letter, bit_sequence, seq_len);
    temp_index++;
}

#endif

/*
 * all the fputc() calls are unrolled for speed.
 *
 */

short uncompress(void)
{

    /* tcc68 can assign 7 register variables */

    register short index         = 0;               /* "ptr" to "node" in "tree"        */
                                                    /* actually an array index          */
    register unsigned unsigned int buffer = 0;      /* 8 bit buffer                     */
    register unsigned short fastleft;               /* fast ptr to next left  element   */
    register unsigned short  fastleft0;             /* fast ptr to left of root         */
    register long running_total = 0L;

    if ((outfile=fopen(origfilename, "wb")) == NULL)    /* open file                        */
    {
        printf("Unable to open %s\n", origfilename);
        return 1;
    }

    fastleft0 = decode_table[0].left;                   /* setup frequently used vars       */
    fastleft = fastleft0;

    while (1)
    {
        buffer=fgetc(infile);                           /* get 8 bits                       */


        /* branch left if current bit == 1, else branch right                               */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;                                   /* rotate next bit to test postion  */

        fastleft = decode_table[index].left;            /* set up frequently used var       */

        if (fastleft == 0)                              /* if we have decoded a char        */
        {
            if (
                fputc((int)decode_table[index].letter, outfile)    /* write it to output    */
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }
            index = 0;                                  /* set "ptr" to top of "tree"       */
            fastleft = fastleft0;                       /* set up freq. used variable       */
#ifdef EXACT
            if (++running_total == total) goto finished;  /* if we are done, quit.          */
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }


        /* and do it again for 2nd bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }
            
            index = 0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }
 
        /* and 3rd bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }
            
            index = 0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }

        /* and 4th bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }
            
            index=0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }

        /* and 5th bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }
            index = 0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }

        /* and 6th bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }

            index = 0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }

        /* and 7th bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }

            index = 0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
        ++running_total;
#endif EXACT
        }

        /* and finally, the 8th bit. */

        index = ( (buffer & 0x0080) ? fastleft : decode_table[index].right);

        buffer <<= 1;

        fastleft = decode_table[index].left;

        if (fastleft == 0)
        {
            if (
                fputc((int)decode_table[index].letter, outfile)
                == EOF
               )
            {
                puts("Error writing to output file, out of disk space?");
                return 1;
            }

            index = 0;
            fastleft = fastleft0;
#ifdef EXACT
            if (++running_total == total) goto finished;
#endif EXACT
#ifndef EXACT
            ++running_total;
#endif EXACT
        }
#ifndef EXACT
        if (running_total >= total)
            goto finished;
#endif EXACT

    }

finished:

    fclose(outfile);
    printf("Decoded %ld bytes.", running_total);
    return 0;
}

