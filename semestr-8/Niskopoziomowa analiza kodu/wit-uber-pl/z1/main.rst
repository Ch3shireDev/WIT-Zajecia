                              1 ;--------------------------------------------------------
                              2 ; File Created by SDCC : FreeWare ANSI-C Compiler
                              3 ; Version 2.3.3 Tue Mar 01 12:20:03 2011
                              4 
                              5 ;--------------------------------------------------------
                              6 	.module main
                              7 	
                              8 ;--------------------------------------------------------
                              9 ; Public variables in this module
                             10 ;--------------------------------------------------------
                             11 	.globl _main
                             12 ;--------------------------------------------------------
                             13 ; special function registers
                             14 ;--------------------------------------------------------
                             15 ;--------------------------------------------------------
                             16 ; special function bits 
                             17 ;--------------------------------------------------------
                    00B4     18 _T1	=	0x00b4
                             19 ;--------------------------------------------------------
                             20 ; overlayable register banks 
                             21 ;--------------------------------------------------------
                             22 	.area REG_BANK_0	(REL,OVR,DATA)
   0000                      23 	.ds 8
                             24 ;--------------------------------------------------------
                             25 ; internal ram data
                             26 ;--------------------------------------------------------
                             27 	.area DSEG    (DATA)
                             28 ;--------------------------------------------------------
                             29 ; overlayable items in internal ram 
                             30 ;--------------------------------------------------------
                             31 	.area	OSEG    (OVR,DATA)
                             32 ;--------------------------------------------------------
                             33 ; Stack segment in internal ram 
                             34 ;--------------------------------------------------------
                             35 	.area	SSEG	(DATA)
   0008                      36 __start__stack:
   0008                      37 	.ds	1
                             38 
                             39 ;--------------------------------------------------------
                             40 ; indirectly addressable internal ram data
                             41 ;--------------------------------------------------------
                             42 	.area ISEG    (DATA)
                             43 ;--------------------------------------------------------
                             44 ; bit data
                             45 ;--------------------------------------------------------
                             46 	.area BSEG    (BIT)
                             47 ;--------------------------------------------------------
                             48 ; external ram data
                             49 ;--------------------------------------------------------
                             50 	.area XSEG    (XDATA)
                             51 ;--------------------------------------------------------
                             52 ; external initialized ram data
                             53 ;--------------------------------------------------------
                             54 	.area XISEG   (XDATA)
                             55 ;--------------------------------------------------------
                             56 ; interrupt vector 
                             57 ;--------------------------------------------------------
                             58 	.area CSEG    (CODE)
   4000                      59 __interrupt_vect:
   4000 02 40 53             60 	ljmp	__sdcc_gsinit_startup
   4003 32                   61 	reti
   4004                      62 	.ds	7
   400B 32                   63 	reti
   400C                      64 	.ds	7
   4013 32                   65 	reti
   4014                      66 	.ds	7
   401B 32                   67 	reti
   401C                      68 	.ds	7
   4023 32                   69 	reti
   4024                      70 	.ds	7
   402B 32                   71 	reti
   402C                      72 	.ds	7
                             73 ;--------------------------------------------------------
                             74 ; global & static initialisations
                             75 ;--------------------------------------------------------
                             76 	.area GSINIT  (CODE)
                             77 	.area GSFINAL (CODE)
                             78 	.area GSINIT  (CODE)
   4053                      79 __sdcc_gsinit_startup:
   4053 75 81 07             80 	mov	sp,#__start__stack - 1
   4056 12 40 4F             81 	lcall	__sdcc_external_startup
   4059 E5 82                82 	mov	a,dpl
   405B 60 03                83 	jz	__sdcc_init_data
   405D 02 40 33             84 	ljmp	__sdcc_program_startup
   4060                      85 __sdcc_init_data:
                             86 ;	_mcs51_genXINIT() start
   4060 74 00                87 	mov	a,#l_XINIT
   4062 44 00                88 	orl	a,#l_XINIT>>8
   4064 60 29                89 	jz	00003$
   4066 74 92                90 	mov	a,#s_XINIT
   4068 24 00                91 	add	a,#l_XINIT
   406A F9                   92 	mov	r1,a
   406B 74 40                93 	mov	a,#s_XINIT>>8
   406D 34 00                94 	addc	a,#l_XINIT>>8
   406F FA                   95 	mov	r2,a
   4070 90 40 92             96 	mov	dptr,#s_XINIT
   4073 78 00                97 	mov	r0,#s_XISEG
   4075 75 A0 00             98 	mov	p2,#(s_XISEG >> 8)
   4078 E4                   99 00001$:	clr	a
   4079 93                  100 	movc	a,@a+dptr
   407A F2                  101 	movx	@r0,a
   407B A3                  102 	inc	dptr
   407C 08                  103 	inc	r0
   407D B8 00 02            104 	cjne	r0,#0,00002$
   4080 05 A0               105 	inc	p2
   4082 E5 82               106 00002$:	mov	a,dpl
   4084 B5 01 F1            107 	cjne	a,ar1,00001$
   4087 E5 83               108 	mov	a,dph
   4089 B5 02 EC            109 	cjne	a,ar2,00001$
   408C 75 A0 FF            110 	mov	p2,#0xFF
   408F                     111 00003$:
                            112 ;	_mcs51_genXINIT() end
                            113 	.area GSFINAL (CODE)
   408F 02 40 33            114 	ljmp	__sdcc_program_startup
                            115 ;--------------------------------------------------------
                            116 ; Home
                            117 ;--------------------------------------------------------
                            118 	.area HOME    (CODE)
                            119 	.area CSEG    (CODE)
                            120 ;--------------------------------------------------------
                            121 ; code
                            122 ;--------------------------------------------------------
                            123 	.area CSEG    (CODE)
   4033                     124 __sdcc_program_startup:
   4033 12 40 38            125 	lcall	_main
                            126 ;	return from main will lock up
   4036 80 FE               127 	sjmp .
                            128 ;------------------------------------------------------------
                            129 ;Allocation info for local variables in function 'main'
                            130 ;------------------------------------------------------------
                            131 ;------------------------------------------------------------
                            132 ;N:\pn\z1\main.c:2: void main (void) {
                            133 ;	-----------------------------------------
                            134 ;	 function main
                            135 ;	-----------------------------------------
   4038                     136 _main:
                    0002    137 	ar2 = 0x02
                    0003    138 	ar3 = 0x03
                    0004    139 	ar4 = 0x04
                    0005    140 	ar5 = 0x05
                    0006    141 	ar6 = 0x06
                    0007    142 	ar7 = 0x07
                    0000    143 	ar0 = 0x00
                    0001    144 	ar1 = 0x01
                            145 ;N:\pn\z1\main.c:4: unsigned char i=0;
                            146 ;     genAssign
   4038 7A 00               147 	mov	r2,#0x00
   403A                     148 00108$:
                            149 ;N:\pn\z1\main.c:8: if (( r & 0x01) == 0)
                            150 ;     genAnd
   403A 74 01               151 	mov	a,#0x01
   403C 5A                  152 	anl	a,r2
   403D FB                  153 	mov	r3,a
                            154 ;     genCmpEq
                            155 ;       Peephole 132   changed ljmp to sjmp
                            156 ;       Peephole 199   optimized misc jump sequence
   403E BB 00 04            157 	cjne r3,#0x00,00102$
                            158 ;00116$:
                            159 ;       Peephole 200   removed redundant sjmp
   4041                     160 00117$:
                            161 ;N:\pn\z1\main.c:9: T1 = 1;
                            162 ;     genAssign
   4041 D2 B4               163 	setb	_T1
                            164 ;       Peephole 132   changed ljmp to sjmp
   4043 80 02               165 	sjmp 00103$
   4045                     166 00102$:
                            167 ;N:\pn\z1\main.c:11: T1 = 0;
                            168 ;     genAssign
   4045 C2 B4               169 	clr	_T1
   4047                     170 00103$:
                            171 ;N:\pn\z1\main.c:12: r++;
                            172 ;     genPlus
                            173 ;     genPlusIncr
   4047 0A                  174 	inc	r2
                            175 ;N:\pn\z1\main.c:13: for(i=0;i<50;i++);
                            176 ;     genAssign
   4048 7B 32               177 	mov	r3,#0x32
   404A                     178 00106$:
                            179 ;     genDjnz
                            180 ;       Peephole 132   changed ljmp to sjmp
                            181 ;       Peephole 205   optimized misc jump sequence
   404A DB FE               182 	djnz r3,00106$
   404C                     183 00118$:
   404C                     184 00119$:
                            185 ;       Peephole 132   changed ljmp to sjmp
   404C 80 EC               186 	sjmp 00108$
   404E                     187 00110$:
   404E 22                  188 	ret
                            189 	.area CSEG    (CODE)
                            190 	.area XINIT   (CODE)
