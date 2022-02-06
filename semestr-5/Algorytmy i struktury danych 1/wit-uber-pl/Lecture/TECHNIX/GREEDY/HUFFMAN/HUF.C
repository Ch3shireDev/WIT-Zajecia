/*******************************************************************************
*                                                                              *
* HUF.C   by Shaun Case   April 1991                                           *
*                                                                              *
* Written in Borland C++ 2.0 under MS-DOS 3.3                                  *
*                                                                              *
* Uses Huffman encoding to compress a single file.                             *
* This program is in the public domain.                                        *
*                                                                              *
* atman%ecst.csuchico.edu@RELAY.CS.NET                                         *
*                                                                              *
*                                                                              *
*******************************************************************************/

#include <stdio.h>
#include <math.h>
#include <dir.h>                        /* for storing filename in output file      */

#define FALSE 0                         /* i'm still deciding on a style...         */
#define TRUE !FALSE

/*
 * for lots of interesting (?) diagnostics, uncomment the following:
#define VERBOSE
 *
 */


typedef struct chardata {               /* template for leaves and nodes in tree    */
    short charnum;                      /* which character to be encoded            */
                                        /* don't want it lost in the sort           */
    unsigned long total;                /* total occurances in the file             */
    short seq_length;                   /* length of this char's huffman code (bits)*/
    short bit_sequence;                 /* the huffman code sequence for this char  */
    double frequency;                   /* frequency of occurance, < 1.0            */
    struct chardata *up, *left, *right; /* pointers to rest of tree                 */
};

typedef struct decode_table_element {   /* template for decode table element (wow)  */
    unsigned char letter;               /* which character to decode to             */
    char spare;                         /* force 16-bit word alignment              */
    short left;                         /* index of lower left element from tree    */
    short right;                        /* index of lower right element from tree   */
};


int compare(const void*, const void*);  /* prototype for compare() for qsort()      */

struct chardata *huftable[256];         /* array that points to leaves in tree      */
struct chardata *root=NULL;             /* future root of tree                      */
struct decode_table_element *decode_table;  /* pointer to decode table              */
short array_max_index=0;                /* max number of elements in array (to be   */
                                        /* determined in create_decode_table()      */

long real_bit_total=0L;
double avg_bits_per_symbol=0;           /* averages num of bits needed to represent */
unsigned long  total;                   /* total number of unencoded bytes          */
long real_bits_total = 0L;
FILE *infile;                           /* file ptr to original file (uncompressed) */
FILE *outfile;                          /* file ptr to output fiel   (compressed)   */
char *infile_name;                      /* ptr to name of input file                */
char *outfile_name;                     /* ptr to name of output file               */


int main(int argc, char **argv)
{

#ifdef VERBOSE
    void show_encode_info(void);                    /* prototype   */
    void show_encoded_file_size(void);              /* prototype   */
    void show_decode_table(void);                   /* prototype   */
#endif

    void dumptable(void);                           /* prototype   */
    short create_tree(void);                        /* prototype   */
    void gen_bit_sequences(struct chardata *node);  /* prototype   */
    short create_decode_table(void);                /* prototype   */
    short compress(void);                           /* prototype   */

    register short c;                               /* a character */
	
    if (argc != 3) {                                /* check command line arguments */
        puts("'huf file1 file2' encodes file1 into file2.");
        return 1;
	}
    puts("Huf by Shaun Case, 1991, Public Domain");
    infile_name = argv[1];
    outfile_name = argv[2];

    puts("Analyzing data.");

    for (c=0; c < 256; c++)                         /* initialize decode table      */
    {
        if ((huftable[c] = (struct chardata *)malloc(sizeof (struct chardata)))== NULL)
        {
            printf("Unable to allocate space for %dth huftable node.",c);
            return 1;
        }
        huftable[c]->charnum   = c;                 /* need to know who we are after qsort() gets done with us */
        huftable[c]->total     = 0L;
        huftable[c]->frequency = 0;
        huftable[c]->up        = NULL;
        huftable[c]->left      = NULL;
        huftable[c]->right     = NULL;
    }


    if ((infile=fopen(infile_name, "rb")) == NULL)  /* open the input file              */
    {
        printf("Unable to open %s.\n", infile_name);
        return 1;
    }

    while (!feof(infile))                           /* get character distribution data  */
    {
        c = fgetc(infile);

        if (feof(infile))
            continue;

        ++total;
        ++huftable[c]->total;                       /* increment total for char c       */
    }

    if (total == 0L)                                /* handle empty file                */
    {
        puts("Input file is empty, aborting.");
        return 0;
    }

    fclose(infile);
                                                    /* sort according to frequency of occurance */

    qsort((void *)huftable, (size_t)256, (size_t)sizeof(struct chardata *),
        compare);

    dumptable();                                    /* fill huftable with distribution freqs    */

    if (create_tree() != TRUE)                      /* make the huffman tree (bit sequences)    */
        return 1;

#ifdef VERBOSE
    printf("\nFreq of root is %f.\n",root->frequency);  /* this should be 1.0 if all went well  */

    puts("\nBit sequences:\n\n");
#endif

    avg_bits_per_symbol = 0;
    gen_bit_sequences(root);                        /* build bit sequences, stuff seqs &        */
                                                    /* lengths into associated leaves           */

#ifdef VERBOSE
    printf("\n\nActual bits per symbol = %f", avg_bits_per_symbol);
    printf("\nActual final data size w/o table should be %f\n",
        avg_bits_per_symbol * (double)total / ((double) 8));

    show_encoded_file_size();
#endif

    puts("Building decode table...");
    if (create_decode_table() != TRUE)              /* create decode array from tree            */
    {
        puts("Unable to allocate space for decode table, exiting.");
        return 1;
    }

    printf("Decode table built, contains %d elements.\n",array_max_index + 1);

#ifdef VERBOSE
    show_decode_table();
    show_encode_info();
#endif

    if (compress() != 0)                            /* now that we have all necessary info,     */
        return 1;                                   /* perform the compression.                 */

    puts("Done.");
    return 0;

}

/*****************************************************************************
 * this code is going to be a little strange -- we have an array of items    *
 * that are going to be the leaves of the tree, and we have to go upward     *
 * linking them together to make the root.  For algorithm, see my notebook,  *
 * or look up huffman compression in a good algorithms book, or see          *
 * huffman's paper -- "A Method for the Construction of Minimum-Redundancy   *
 * Codes" David A. Huffman, Proceedings of the IRE 40, 1098-- 1101           *
 *                                                                           *
 * after the tree is built, the root of the tree is assigned to the global   *
 * variable root.                                                            *
 *                                                                           *
 * -- Shaun Case                                                             *
 *****************************************************************************/

struct chardata *ptr1, *ptr2;          /* 1 = smallest freq, 2 = 2nd smallest */

short create_tree()
{
    void find_lowest_freqs(void);      /* prototype */
    short only_one_up_ptr_left(void);  /* prototype */


    double maxfreq = 0 ;               /* max combined freqency in the tree   */
    struct chardata *new_node = NULL;  /* ptr to new node to be created       */

    puts("Creating tree from frequencies...");

    while (maxfreq < 0.99999 )         /* while we haven't made the root yet  */
    {
        find_lowest_freqs();           /* find the two lowest combined or     */
                                       /*   unused single frequencies         */

        if (                           /* create a new node                   */
            (new_node = (struct chardata *)malloc(sizeof (struct chardata)) )
            == NULL
           )
        {
            puts("Insufficient memory, malloc() failed in create_tree().");
            return FALSE;
        }
                                        /* initialize the new node            */
        new_node->up    = NULL;
        new_node->left  = ptr2;
        new_node->right = ptr1;
        new_node->charnum = -1; /* if you get a lot of -1s when traversing the tree, */
                                /* you aren't looking at the leaves.                 */
        ptr1->up = new_node;
        ptr2->up = new_node;

        new_node->frequency = ptr1->frequency + ptr2->frequency; /* combine 2 old freqs */

        maxfreq = new_node->frequency;  /* clever optimization */
#ifdef VERBOSE
        printf("Newly created freq == %f\n", maxfreq);
#endif
    }

    root = new_node;                    /* update global variable   */

    if (only_one_up_ptr_left())         /* verify tree is correct   */
    {                                   /* algorirthm seems to work */
        puts("Done creating tree.");    /*  fine, this is a saftey  */
#ifdef verbose                          /*  check.                  */
        puts("Win: apparently only one remaining up-pointer.");
#endif
    }
    else
    {
        puts("Lose: apparently more than one remaining up-pointer.");
        return FALSE;
    }

    return TRUE;                        /* everything is fine.      */
}


/************************************************************
 * verify there is only one root after the tree is created  *
 * by making sure only one node has an up pointer that has  *
 * the value NULL.                                          *
 *                                                          *
 * Just a double-check.                                     *
 *                                                          *
 ************************************************************/

short only_one_up_ptr_left(void)
{
    short bottom=255;
    register struct chardata *tptr;
    register struct chardata *first_null_up_ptr=NULL;

    tptr=huftable[bottom];

    while (bottom != -1)
    {
        while (tptr->up != NULL)            /* find root for this leaf       */
            tptr = tptr->up;

        if (first_null_up_ptr == NULL)      /* assign uptr to root, 1st time */
            first_null_up_ptr = tptr;
        else
            if (first_null_up_ptr != tptr)  /* uh oh, found another root..   */
                return FALSE;

        --bottom;
    }

    return TRUE;
}

/****************************************************************
 *                                                              *
 * Find the two smallest combined or unused single frequencies  *
 * in the partially-constructed tree.                           *
 *                                                              *
 ****************************************************************/

void find_lowest_freqs(void)
{
    register struct chardata *tptr;

    /* the following are local for speed (I think double indirection is slow */

    register struct chardata *local_minptr;         /* ptr to smallest unused freq     */
    register struct chardata *local_second_minptr;  /* ptr to 2nd smallest unused freq */

    struct chardata dummy;
    short bottom = 255;

    dummy.frequency = 2.0;          /* initialize to bigger than 1.000         */
    local_minptr=&dummy;            /* initialize to bigger than 1.000         */

    while(bottom != -1)             /* find smallest "unused" frequency of all */
    {
        tptr = huftable[bottom];

        if (tptr->total == 0L)      /* skip unused byte values (not all files  */
        {                           /* contain all 256 chars)                  */
            --bottom;
            continue;
        }

        while (tptr->up != NULL)    /* find top of tree ending in current leaf */
            tptr = tptr->up;

        if (tptr->frequency < local_minptr->frequency)  /* if current < min    */
            local_minptr = tptr;                        /* then min = current  */

        --bottom;                   /* keep going... */
    }

    /* now find second smallest "unused" frequency   */


    bottom = 255;                   /* start at the bottom again */
    local_second_minptr=&dummy;     /* initialize to bigger than 1.000         */

    while(bottom != -1)
    {
        tptr = huftable[bottom];

        if (tptr->total == 0L)      /* skip unused byte values                 */
        {
            --bottom;
            continue;
        }

        while (tptr->up != NULL)    /* find top of tree ending in current leaf */
            tptr = tptr->up;

        if (
             (tptr->frequency < local_second_minptr->frequency)  /* if current < min2    */
             && (tptr != local_minptr)                           /* and curr <> min1     */
           )
           local_second_minptr = tptr;                           /* then min2 = current  */

        --bottom;                   /* keep going... */
    }

    ptr1 = local_minptr;
    ptr2 = local_second_minptr;

}


/*******************************************************
 *                                                     *
 * Dump the contents of the huffman table.             *
 * also fills huftable with distribution frequencies   *
 *                                                     *
 *******************************************************/


void dumptable(void)
{
    register short i;
    int bits_per_char;
    double check_total = 0;
    double percent     = 0;
    double frac;

#ifdef VERBOSE
    puts("Totals:\n");
#endif

#ifdef VERBOSE
    printf("\n\ntotal chars = %ld.\n", total );
#endif

    if (total==0)   /* otherwise get divide by zero error */
        return;

    avg_bits_per_symbol=0;
    for (i=0; i< (256); i++)
    {
        huftable[i]->frequency = frac = (((double)huftable[i]->total))/(double)total;
        percent= (double)(100)*frac;
        if (frac >0)
            bits_per_char = (int)ceil( -log10(frac)/log10((double)2));

#ifdef VERBOSE
        printf("\n%3d = %6ld = %%%6.3f => %d bits",huftable[i]->charnum,
            huftable[i]->total, percent,
            bits_per_char );
#endif

        check_total += percent;
        avg_bits_per_symbol += ((double)bits_per_char) * frac;

    }
#ifdef VERBOSE
    printf("\n\nTotal........ %%%6.3f\n", check_total);
    printf("Average bits per symbol = %6.3f\n",avg_bits_per_symbol);
    printf("Total compressed file length w/o decode table = %f\n",
        avg_bits_per_symbol * (double)total / ((double) 8)
    );
#endif

}

/*********************
 * called by qsort() *
 *********************/

int compare(const void *arg1, const void *arg2)
{

    long result = (
                    (
                       *(struct chardata **)arg1

                    )->total
                  )

                  -

                  (
                    (
                        *(struct chardata **)arg2
                    )->total
                  );

    /* return codes reveresed from normal for descending order */

    if (result > 0L) return -1;  /* first > second */
    if (result < 0L) return +1;  /* first < second */
    return 0;                    /* first = second */
}


/***************************************************************************
 * floating point, backwards trees, dynamic memory allocation,             *
 * and now recursion -- this program has it all!                           *
 *                                                                         *
 * func builds bit sequences at stuffs associated sequence and length into *
 * corresponding leaf node                                                 *
 *                                                                         *
 * Pretty obvious code, if you know recursion.                             *
 *                                                                         *
 ***************************************************************************/


short seq_len=0;


void gen_bit_sequences(struct chardata *node)
{
    unsigned short asctobin(char *bit_seq);

    static char bit_sequence[16];    /* where to build the huffman bit sequence */
    double frac;

    if (node->left != NULL)
    {
        bit_sequence[seq_len++]='1';
        gen_bit_sequences(node->left);
        seq_len--;
    }

    if (node->right != NULL)
    {
        bit_sequence[seq_len++]='0';
        gen_bit_sequences(node->right);
        seq_len--;
    }

    if (node->right != NULL)    /* we are at an interior node going back up */
        return;

    bit_sequence[seq_len] = 0;

    node->seq_length = (long)seq_len;
    node->bit_sequence = asctobin(bit_sequence);

#ifdef VERBOSE
    printf("%3d == %16s == %4x %3d\n", node->charnum, bit_sequence, node->bit_sequence, seq_len);
#endif

    frac = (((double)huftable[node->charnum]->total))/(double)total;
    avg_bits_per_symbol += ((double)seq_len) * frac;
    real_bits_total += (long)seq_len;

    
}

/*********************************************
 * turn an ASCII representation of a binary  *
 * number into an unsigned short.            *
 *********************************************/

unsigned short asctobin(char *bit_seq)
{
    register short i;
    register unsigned short binary_value=0;

    for (i = 0; (i < 16) && (bit_seq[i]); i++)
    {
        binary_value <<= 1;
        binary_value |= (bit_seq[i]=='1') ? 1 : 0;
    }

    return binary_value;
}

/************************************************************
 * build a decode table (an array) from the big fat hairy   *
 * tree structure we created earlier.  the decode table is  *
 * parsed just like the tree, only instead of pointers to   *
 * other nodes, there are left and right array indecies.    *
 * This was done because the destination system for my      *
 * application had no dynamic memory allocation.  Also      *
 * I didn't want to try writing a tree to disk, ick.        *
 ************************************************************/

short create_decode_table(void)
{
    void assign_index(struct chardata *node);
    void fill_array(struct chardata *node);

    assign_index(root);     /* assign index nums to each node in tree -- use member 'total' for */
                            /* this purpose, since it isn't needed anymore.                     */

    /* allocate space for array dynamically, since we don't know */
    /* how big it is going to be.  (will be small if there are   */
    /* only a few different characters that are used repeatedly  */
    /* in the file to be encoded.                                */

    decode_table = (struct decode_table_element *) calloc(array_max_index + 1,
        sizeof(struct decode_table_element));

    if (decode_table == NULL)
        return FALSE;

    fill_array(root);   /* fill up the table */
    return TRUE;
}

/***************************************************************************
 * assign all nodes index numbers.  uses preorder traversal to ensure that *
 * the root is assigned 0, which will be the 'root' of the array --        *
 * where the searching starts when decoding.                               *
 * sets value of global, "array_max_index"                                 *
 ***************************************************************************/

void assign_index(struct chardata *node)
{
    if (node != NULL)
    {
         node->total = (long)array_max_index++;
         assign_index(node->left);
         assign_index(node->right);
    }
}


/*************************************************
 * fill up the decode table                      *
 * use preorder traversal (see above for reason) *
 *************************************************/

short temp_index = 0;

void fill_array(struct chardata *node)
{
    if (node != NULL)
    {
        if (node->left == NULL)     /* we found a leaf */
        {
            decode_table[temp_index].letter = node->charnum;
            decode_table[temp_index].left   = 0;
            decode_table[temp_index].right  = 0;
        }
        else    /* we are at an interior node */
        {
            decode_table[temp_index].letter = '@';  /* if you get a lot of '@' in your decoded */
                                                    /* file you are looking at interior nodes, */
                                                    /* not leaves.                             */

            decode_table[temp_index].left   = (short) node->left->total;
            decode_table[temp_index].right  = (short) node->right->total;
        }

        temp_index++;

        fill_array(node->left);
        fill_array(node->right);
    }
}

/***********************
 * perform compression *
 ***********************/

short compress(void)
{
    short output_bits(short bit_seq, short seq_len); /* prototype */
    short find_match(int c);                         /* prototype */

    register unsigned long i;        /* index variable         */
    register short array_index;      /* index to info for char */
    int c;                           /* a character            */

    char orig_name[MAXFILE+MAXEXT],  /* original filename      */
         drive[MAXDRIVE],            /* needed for fnsplit()   */
         dir[MAXDIR],                /* needed for fnsplit()   */
         filename[MAXFILE],          /* 8 chars, orig name     */
         ext[MAXEXT];                /* 3 chars, orig ext      */

    if ((infile=fopen(infile_name, "rb")) == NULL)
    {
        printf("Unable to open %s\n", infile_name);
        return 1;
    }

    if ((outfile=fopen(outfile_name, "wb")) == NULL)
    {
        printf("Unable to open %s\n", outfile_name);
        return 1;
    }

    fnsplit(infile_name, drive, dir, filename, ext);    /* get filename               */
    strcpy(orig_name, filename);
    strcat(orig_name, ext);
    for (i=0; i<13; i++)                                /* write orig filename        */
        fputc(orig_name[i], outfile);                   /* to file one char at a time */

                                                        /* write # of array elems     */
    if (
         fwrite((void*)&array_max_index, sizeof(short), 1, outfile)
         < 1
       )
    {
        printf("Unable to write to %s -- out of disk space?", outfile_name);
        fclose(outfile);
        return 1;
    }
                                                        /* write original length      */
    if (
         fwrite((void*)&total, sizeof(unsigned long), 1, outfile)
         < 1
       )
    {
        printf("Unable to write to %s -- out of disk space?", outfile_name);
        fclose(outfile);
        return 1;
    }
                                                        /* write decode table         */
    if (
         fwrite((void*)decode_table, sizeof(struct decode_table_element), array_max_index + 1, outfile)
         < array_max_index
       )
    {
        printf("Unable to write to %s -- out of disk space?", outfile_name);
        fclose(outfile);
        return 1;
    }


    printf("Encoding %ld bytes.\n",total);

    for (i=0; i< total; i++)            /* for all bytes                       */
    {
        c = fgetc(infile);              /* get a new byte                      */
        if (c == EOF)
        {
            printf("\nReached unexpected end of input file at position %ld.\n",i);
            return 1;
        }
        array_index = find_match(c);    /* find it in the decode table         */

        if (                            /* write out the bit sequence          */
             output_bits(huftable[array_index]->bit_sequence, (short)huftable[array_index]->seq_length)
             != 0
           )
        {
            printf("Unable to write to %s -- out of disk space?", outfile_name);
            return 1;
        }
    }

    output_bits(255,7);                 /* flush last partial char from buffer */

    printf("%ld bytes encoded.\n", i);

    fclose(outfile);


    return 0;
}

/***************************************
 * return array index that corresponds *
 * to a particular character           *
 ***************************************/

short find_match(int c)
{
    register short i=0;

    while (c != huftable[i]->charnum)
        ++i;

    return i;
}

/************************************
 * write out a bit sequence to disk *
 ************************************/

short output_bits(short bit_seq, short seq_len)
{
    static unsigned char buffer = 0;
    static unsigned short bits_used   = 0;
    short i;

    bit_seq <<= (16 - seq_len);         /* bring 1st real bit to leftmost position */

    for (i = 0; i < seq_len; i++)
    {
        buffer <<= 1;                        /* make space for next bit in buffer                      */
        buffer |= ((bit_seq & 0x8000) != 0); /* set rightmost bit of buffer to lefmost bit in sequence */
        bit_seq <<= 1;                       /* throw away used bit from sequence                      */
        bits_used++;                         /* increment bit count                                    */
        if (bits_used == 8)                  /* if we have a whole byte, write it.                     */
        {
            if (fputc((int)buffer, outfile)==EOF)
            {
                fclose(outfile);
                return 1;
            }

            bits_used = 0;  /* start fresh for new byte                       */
            buffer    = 0;  /* may not be necessary except on final bits/byte */
        }
    }

    return 0;
}


#ifdef VERBOSE

void show_encode_info(void)
{
    register short i;

    for (i=0; i<256; i++)
        printf("%3d.  charnum =%3d  index == %ld  seq_len =%d, bit_seq = %x\n", i, huftable[i]->charnum,
            huftable[i]->total, huftable[i]->seq_length, huftable[i]->bit_sequence);
}

/******

 Datafile:  All 16/32 bit quantities in Intel format


 13 bytes    : original filename (8.3 + "\0")
 16 bits     : number of array elements needed, N (N == 511 means 512 array
               elements -> 0..511)
 32 bits     : size of uncompressed original data in bytes
 N * 6 bytes : Array elements in order 0 .. N
               struct decode_table_element {
                    char letter;      8 bits
                    char spare;       8 bits
                    short left;      16 bits
                    short right;     16 bits
                }
<?>           : compressed data, effectively a bit stream

 ******/

void show_encoded_file_size(void)
{
    register unsigned short i;
    double bit_total=0;

    for (i = 0; i < 256; i++)
        bit_total += (double)huftable[i]->total
                    *(double)huftable[i]->seq_length;

    printf("Best guess at encoded file size is %f bytes.\n", bit_total / (double) 8);


}

void show_decode_table(void)
{
    register unsigned short i;

    for (i=0; i<array_max_index+1; i++)
        printf("[%3d]  %3x  L: %3d  R: %3d\n", i, (int)decode_table[i].letter,
            decode_table[i].left, decode_table[i].right);
}
#endif
