readme.txt                                              April 25, 1991


Huffman compression code compressor and decompressor in Borland C++ 2.0
by Shaun Case, April 1991

Enclosed in this archive are two C programs that implement Huffman code
compression.

huf.c   <--- compress a file using huffman compression
unhuf.c <--- decompress a file compressed with huf.c

Both programs, their source code and executable code, are in the public
domain.  You may use either in any way you want.  You can sell them, use
them in your own pd, freeware, shareware, or commercial application,
without fee, licsence, or royalty of any kind.  You don't even have to
put my name on it, if you don't want to, although that would be a nice
touch.

You should know two things before using these programs:

1)  I am completely unresponsible for any liability arising from use of
these programs, either in executable or source form.  They are for use
as-is, without any kind of waranty or guarantee, including but not
limited to FITNESS FOR A PARTICULAR PURPOSE, or merchantability, or
whatever the hell it is.  If you use these program, you assume all
liability.  Use of these programs is acceptance of assumption of
any and all liability, and of the complete freedom of legal
responsibility for damages of any nature, including a large malevolent,
rabid fruit bat flying into your hair in the night and chewing a hole in
your neck, of the author.

2)  There are much better compression schemes available, notably LZW,
and possibly RLE, depending on your data.  LZW, RLE, and this Huffman
implementation are lossless, and are typically not suitable for
compressing digital video in real time.

That aside, I'd like to say a few things about the source code:

1)  The compressor is non-optimal in several ways:
    -- the compressed filesize estimation is broken
    -- it uses floating point
    -- it is full of unnecessary code
    -- there are a couple of easy optimizations that could be made
    -- it uses global variables
    -- there is a function call for every character processed.

    One of the reasons it is in this condition is that, for my
    application, the data was only going to be compressed once, but
    uncompressed repeatedly.  So, if the compressor was a little
    un-optimal, that was fine.

2)  It works, as far as I can tell, perfectly.  It's bound to have a few
    bugs in it somewhere, but it seems to work with:
    -- pretty large files (~600k)
    -- files that contain no characters
    -- files that contain less than all 256 characters.

3) The original filename is stored in the *.huf file, and is used when
   recreating the original file.

4) It was written in Borland C++.  If you want to compile using another
   compiler, especially one that isn't native to MS-DOS, have fun.  The
   huf program writes out some shorts and a long or two binarily,
   whatever byte ordering your machine normally uses, so data is
   typically not interchangable.  If you are running on a Motorola
   processor, or on a Vax, you will need to fix the byte ordering if you
   want files to be interchangeable with files created under MS-DOS.

5) It was written in a 132 X 43 column SVGA mode, so it may look funny
   if you try to edit it on your 80X25 setup, or try to print it on an
   80 column printer.

6) Datafile format:


 All 16/32 bit quantities in Intel format

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


I will not be supporting this software, but if you wish to contact me, you
may reach me by email at one of the following addresses:

Internet : atman%ecst.csuchico.edu@RELAY.CS.NET
Fidonet  : Shaun Case of 1:119/666.0
WWIVnet  : 1@9651

I hope you find this code useful or informative, or maybe both.


-- Shaun


