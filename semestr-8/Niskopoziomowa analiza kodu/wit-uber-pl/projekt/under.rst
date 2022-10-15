                              1 ;--------------------------------------------------------
                              2 ; File Created by SDCC : FreeWare ANSI-C Compiler
                              3 ; Version 2.3.3 Wed May 18 13:08:19 2011
                              4 
                              5 ;--------------------------------------------------------
                              6 	.module under
                              7 	
                              8 ;--------------------------------------------------------
                              9 ; Public variables in this module
                             10 ;--------------------------------------------------------
                             11 	.globl _klaw
                             12 	.globl _main
                             13 	.globl _czas
                             14 	.globl _strefa
                             15 	.globl _zmien_czas
                             16 	.globl _znak
                             17 	.globl _lcd_xy
                             18 	.globl _lcd_clear
                             19 	.globl _lcd_czas
                             20 	.globl _lcd_write
                             21 	.globl _lcd_init
                             22 	.globl _czekaj
                             23 	.globl _send_Date
                             24 	.globl _send_Command_4_bit
                             25 	.globl _send_Command_8_bit
                             26 	.globl _U10
                             27 	.globl _U12
                             28 	.globl _U15
                             29 	.globl _lcd_xy_PARM_2
                             30 	.globl __czas
                             31 	.globl __minuta
                             32 	.globl __godzina
                             33 ;--------------------------------------------------------
                             34 ; special function registers
                             35 ;--------------------------------------------------------
                    0090     36 _P1	=	0x0090
                             37 ;--------------------------------------------------------
                             38 ; special function bits 
                             39 ;--------------------------------------------------------
                             40 ;--------------------------------------------------------
                             41 ; overlayable register banks 
                             42 ;--------------------------------------------------------
                             43 	.area REG_BANK_0	(REL,OVR,DATA)
   0000                      44 	.ds 8
                             45 ;--------------------------------------------------------
                             46 ; internal ram data
                             47 ;--------------------------------------------------------
                             48 	.area DSEG    (DATA)
   0008                      49 __godzina::
   0008                      50 	.ds 2
   000A                      51 __minuta::
   000A                      52 	.ds 2
   000C                      53 __czas::
   000C                      54 	.ds 2
   000E                      55 _lcd_xy_PARM_2::
   000E                      56 	.ds 1
                             57 ;--------------------------------------------------------
                             58 ; overlayable items in internal ram 
                             59 ;--------------------------------------------------------
                             60 	.area	OSEG    (OVR,DATA)
                             61 	.area	OSEG    (OVR,DATA)
                             62 	.area	OSEG    (OVR,DATA)
                             63 	.area	OSEG    (OVR,DATA)
                             64 	.area	OSEG    (OVR,DATA)
                             65 ;--------------------------------------------------------
                             66 ; Stack segment in internal ram 
                             67 ;--------------------------------------------------------
                             68 	.area	SSEG	(DATA)
   0011                      69 __start__stack:
   0011                      70 	.ds	1
                             71 
                             72 ;--------------------------------------------------------
                             73 ; indirectly addressable internal ram data
                             74 ;--------------------------------------------------------
                             75 	.area ISEG    (DATA)
                             76 ;--------------------------------------------------------
                             77 ; bit data
                             78 ;--------------------------------------------------------
                             79 	.area BSEG    (BIT)
                             80 ;--------------------------------------------------------
                             81 ; external ram data
                             82 ;--------------------------------------------------------
                             83 	.area XSEG    (XDATA)
                    8000     84 _U15	=	0x8000
                    8000     85 _U12	=	0x8000
                    FFFF     86 _U10	=	0xffff
                             87 ;--------------------------------------------------------
                             88 ; external initialized ram data
                             89 ;--------------------------------------------------------
                             90 	.area XISEG   (XDATA)
                             91 ;--------------------------------------------------------
                             92 ; interrupt vector 
                             93 ;--------------------------------------------------------
                             94 	.area CSEG    (CODE)
   4000                      95 __interrupt_vect:
   4000 02 47 2C             96 	ljmp	__sdcc_gsinit_startup
   4003 32                   97 	reti
   4004                      98 	.ds	7
   400B 32                   99 	reti
   400C                     100 	.ds	7
   4013 32                  101 	reti
   4014                     102 	.ds	7
   401B 32                  103 	reti
   401C                     104 	.ds	7
   4023 32                  105 	reti
   4024                     106 	.ds	7
   402B 32                  107 	reti
   402C                     108 	.ds	7
                            109 ;--------------------------------------------------------
                            110 ; global & static initialisations
                            111 ;--------------------------------------------------------
                            112 	.area GSINIT  (CODE)
                            113 	.area GSFINAL (CODE)
                            114 	.area GSINIT  (CODE)
   472C                     115 __sdcc_gsinit_startup:
   472C 75 81 10            116 	mov	sp,#__start__stack - 1
   472F 12 46 9C            117 	lcall	__sdcc_external_startup
   4732 E5 82               118 	mov	a,dpl
   4734 60 03               119 	jz	__sdcc_init_data
   4736 02 40 33            120 	ljmp	__sdcc_program_startup
   4739                     121 __sdcc_init_data:
                            122 ;	_mcs51_genXINIT() start
   4739 74 00               123 	mov	a,#l_XINIT
   473B 44 00               124 	orl	a,#l_XINIT>>8
   473D 60 29               125 	jz	00003$
   473F 74 70               126 	mov	a,#s_XINIT
   4741 24 00               127 	add	a,#l_XINIT
   4743 F9                  128 	mov	r1,a
   4744 74 47               129 	mov	a,#s_XINIT>>8
   4746 34 00               130 	addc	a,#l_XINIT>>8
   4748 FA                  131 	mov	r2,a
   4749 90 47 70            132 	mov	dptr,#s_XINIT
   474C 78 00               133 	mov	r0,#s_XISEG
   474E 75 A0 00            134 	mov	p2,#(s_XISEG >> 8)
   4751 E4                  135 00001$:	clr	a
   4752 93                  136 	movc	a,@a+dptr
   4753 F2                  137 	movx	@r0,a
   4754 A3                  138 	inc	dptr
   4755 08                  139 	inc	r0
   4756 B8 00 02            140 	cjne	r0,#0,00002$
   4759 05 A0               141 	inc	p2
   475B E5 82               142 00002$:	mov	a,dpl
   475D B5 01 F1            143 	cjne	a,ar1,00001$
   4760 E5 83               144 	mov	a,dph
   4762 B5 02 EC            145 	cjne	a,ar2,00001$
   4765 75 A0 FF            146 	mov	p2,#0xFF
   4768                     147 00003$:
                            148 ;	_mcs51_genXINIT() end
                            149 ;Z:\pn\projekt\under.c:19: int _czas = 0;
                            150 ;     genAssign
   4768 E4                  151 	clr	a
   4769 F5 0D               152 	mov	(__czas + 1),a
   476B F5 0C               153 	mov	__czas,a
                            154 	.area GSFINAL (CODE)
   476D 02 40 33            155 	ljmp	__sdcc_program_startup
                            156 ;--------------------------------------------------------
                            157 ; Home
                            158 ;--------------------------------------------------------
                            159 	.area HOME    (CODE)
                            160 	.area CSEG    (CODE)
                            161 ;--------------------------------------------------------
                            162 ; code
                            163 ;--------------------------------------------------------
                            164 	.area CSEG    (CODE)
   4033                     165 __sdcc_program_startup:
   4033 12 45 95            166 	lcall	_main
                            167 ;	return from main will lock up
   4036 80 FE               168 	sjmp .
                            169 ;------------------------------------------------------------
                            170 ;Allocation info for local variables in function 'send_Command_8_bit'
                            171 ;------------------------------------------------------------
                            172 ;------------------------------------------------------------
                            173 ;Z:\pn\projekt\under.c:21: void send_Command_8_bit(unsigned char polecenie)
                            174 ;	-----------------------------------------
                            175 ;	 function send_Command_8_bit
                            176 ;	-----------------------------------------
   4038                     177 _send_Command_8_bit:
                    0002    178 	ar2 = 0x02
                    0003    179 	ar3 = 0x03
                    0004    180 	ar4 = 0x04
                    0005    181 	ar5 = 0x05
                    0006    182 	ar6 = 0x06
                    0007    183 	ar7 = 0x07
                    0000    184 	ar0 = 0x00
                    0001    185 	ar1 = 0x01
                            186 ;     genReceive
   4038 AA 82               187 	mov	r2,dpl
                            188 ;Z:\pn\projekt\under.c:23: P1=polecenie;
                            189 ;     genAssign
   403A 8A 90               190 	mov	_P1,r2
                            191 ;Z:\pn\projekt\under.c:24: P1=polecenie | E;
                            192 ;     genOr
   403C 74 08               193 	mov	a,#0x08
   403E 4A                  194 	orl	a,r2
   403F F5 90               195 	mov	_P1,a
                            196 ;Z:\pn\projekt\under.c:25: P1=polecenie & !E;
                            197 ;     genAnd
   4041 75 90 00            198 	mov	_P1,#0x00
   4044                     199 00101$:
   4044 22                  200 	ret
                            201 ;------------------------------------------------------------
                            202 ;Allocation info for local variables in function 'send_Command_4_bit'
                            203 ;------------------------------------------------------------
                            204 ;------------------------------------------------------------
                            205 ;Z:\pn\projekt\under.c:28: void send_Command_4_bit(unsigned char polecenie)
                            206 ;	-----------------------------------------
                            207 ;	 function send_Command_4_bit
                            208 ;	-----------------------------------------
   4045                     209 _send_Command_4_bit:
                            210 ;     genReceive
   4045 AA 82               211 	mov	r2,dpl
                            212 ;Z:\pn\projekt\under.c:30: P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
                            213 ;     genAnd
   4047 74 F0               214 	mov	a,#0xF0
   4049 5A                  215 	anl	a,r2
   404A FB                  216 	mov	r3,a
                            217 ;     genAssign
   404B 8B 90               218 	mov	_P1,r3
                            219 ;Z:\pn\projekt\under.c:31: P1=(polecenie & 0xf0) | E; //sygna³ „strob”
                            220 ;     genOr
   404D 74 08               221 	mov	a,#0x08
   404F 4B                  222 	orl	a,r3
   4050 F5 90               223 	mov	_P1,a
                            224 ;Z:\pn\projekt\under.c:32: P1=(polecenie & 0xf0) & !E;
                            225 ;     genAnd
   4052 75 90 00            226 	mov	_P1,#0x00
                            227 ;Z:\pn\projekt\under.c:33: P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
                            228 ;    genLeftShift
                            229 ;     genLeftShiftLiteral
                            230 ;     genlshOne
   4055 EA                  231 	mov	a,r2
   4056 C4                  232 	swap	a
   4057 54 F0               233 	anl	a,#0xf0
   4059 FA                  234 	mov	r2,a
                            235 ;     genAnd
   405A 53 02 F0            236 	anl	ar2,#0xF0
                            237 ;     genAssign
   405D 8A 90               238 	mov	_P1,r2
                            239 ;Z:\pn\projekt\under.c:34: P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
                            240 ;     genOr
   405F 74 08               241 	mov	a,#0x08
   4061 4A                  242 	orl	a,r2
   4062 F5 90               243 	mov	_P1,a
                            244 ;Z:\pn\projekt\under.c:35: P1=((polecenie << 4) & 0xf0) & !E;
                            245 ;     genAnd
   4064 75 90 00            246 	mov	_P1,#0x00
   4067                     247 00101$:
   4067 22                  248 	ret
                            249 ;------------------------------------------------------------
                            250 ;Allocation info for local variables in function 'send_Date'
                            251 ;------------------------------------------------------------
                            252 ;------------------------------------------------------------
                            253 ;Z:\pn\projekt\under.c:38: void send_Date(unsigned char dana)
                            254 ;	-----------------------------------------
                            255 ;	 function send_Date
                            256 ;	-----------------------------------------
   4068                     257 _send_Date:
                            258 ;     genReceive
   4068 AA 82               259 	mov	r2,dpl
                            260 ;Z:\pn\projekt\under.c:40: P1=(dana & 0xf0) | RS;
                            261 ;     genAnd
   406A 74 F0               262 	mov	a,#0xF0
   406C 5A                  263 	anl	a,r2
   406D FB                  264 	mov	r3,a
                            265 ;     genOr
   406E 74 04               266 	mov	a,#0x04
   4070 4B                  267 	orl	a,r3
   4071 F5 90               268 	mov	_P1,a
                            269 ;Z:\pn\projekt\under.c:41: P1=((dana & 0xf0) | E) | RS;
                            270 ;     genOr
   4073 74 08               271 	mov	a,#0x08
   4075 4B                  272 	orl	a,r3
                            273 ;     genOr
   4076 44 04               274 	orl	a,#0x04
   4078 F5 90               275 	mov	_P1,a
                            276 ;Z:\pn\projekt\under.c:42: P1=((dana & 0xf0) & !E) | RS;
                            277 ;     genAnd
                            278 ;       Peephole 180   changed mov to clr
   407A E4                  279 	clr  a
                            280 ;     genOr
   407B 44 04               281 	orl	a,#0x04
   407D F5 90               282 	mov	_P1,a
                            283 ;Z:\pn\projekt\under.c:43: P1=((dana << 4) & 0xf0) | RS;
                            284 ;    genLeftShift
                            285 ;     genLeftShiftLiteral
                            286 ;     genlshOne
   407F EA                  287 	mov	a,r2
   4080 C4                  288 	swap	a
   4081 54 F0               289 	anl	a,#0xf0
   4083 FA                  290 	mov	r2,a
                            291 ;     genAnd
   4084 53 02 F0            292 	anl	ar2,#0xF0
                            293 ;     genOr
   4087 74 04               294 	mov	a,#0x04
   4089 4A                  295 	orl	a,r2
   408A F5 90               296 	mov	_P1,a
                            297 ;Z:\pn\projekt\under.c:44: P1=(((dana << 4) & 0xf0) | E) | RS;
                            298 ;     genOr
   408C 74 08               299 	mov	a,#0x08
   408E 4A                  300 	orl	a,r2
                            301 ;     genOr
   408F 44 04               302 	orl	a,#0x04
   4091 F5 90               303 	mov	_P1,a
                            304 ;Z:\pn\projekt\under.c:45: P1=(((dana << 4) & 0xf0) & !E) | RS;
                            305 ;     genAnd
                            306 ;       Peephole 180   changed mov to clr
   4093 E4                  307 	clr  a
                            308 ;     genOr
   4094 44 04               309 	orl	a,#0x04
   4096 F5 90               310 	mov	_P1,a
   4098                     311 00101$:
   4098 22                  312 	ret
                            313 ;------------------------------------------------------------
                            314 ;Allocation info for local variables in function 'czekaj'
                            315 ;------------------------------------------------------------
                            316 ;------------------------------------------------------------
                            317 ;Z:\pn\projekt\under.c:48: void czekaj(int d){
                            318 ;	-----------------------------------------
                            319 ;	 function czekaj
                            320 ;	-----------------------------------------
   4099                     321 _czekaj:
                            322 ;     genReceive
   4099 AA 82               323 	mov	r2,dpl
   409B AB 83               324 	mov	r3,dph
                            325 ;Z:\pn\projekt\under.c:50: for(i = 0; i<d; i++) {
                            326 ;     genAssign
   409D 7C 00               327 	mov	r4,#0x00
   409F 7D 00               328 	mov	r5,#0x00
   40A1                     329 00104$:
                            330 ;     genCmpLt
                            331 ;     genCmp
   40A1 C3                  332 	clr	c
   40A2 EC                  333 	mov	a,r4
   40A3 9A                  334 	subb	a,r2
   40A4 ED                  335 	mov	a,r5
   40A5 64 80               336 	xrl	a,#0x80
   40A7 8B F0               337 	mov	b,r3
   40A9 63 F0 80            338 	xrl	b,#0x80
   40AC 95 F0               339 	subb	a,b
                            340 ;     genIfxJump
                            341 ;       Peephole 108   removed ljmp by inverse jump logic
   40AE 50 14               342 	jnc  00108$
   40B0                     343 00114$:
                            344 ;Z:\pn\projekt\under.c:51: for(j = 0; j < 256; j++) {
                            345 ;     genAssign
   40B0 7E 00               346 	mov	r6,#0x00
   40B2 7F 01               347 	mov	r7,#0x01
   40B4                     348 00103$:
                            349 ;     genDjnz
                            350 ;     genMinus
                            351 ;     genMinusDec
   40B4 1E                  352 	dec	r6
   40B5 BE FF 01            353 	cjne	r6,#0xff,00115$
   40B8 1F                  354 	dec	r7
   40B9                     355 00115$:
                            356 ;     genIfx
   40B9 EE                  357 	mov	a,r6
   40BA 4F                  358 	orl	a,r7
                            359 ;     genIfxJump
                            360 ;       Peephole 109   removed ljmp by inverse jump logic
   40BB 70 F7               361 	jnz  00103$
   40BD                     362 00116$:
                            363 ;Z:\pn\projekt\under.c:50: for(i = 0; i<d; i++) {
                            364 ;     genPlus
                            365 ;     genPlusIncr
                            366 ;	tail increment optimized
   40BD 0C                  367 	inc	r4
   40BE BC 00 E0            368 	cjne	r4,#0x00,00104$
   40C1 0D                  369 	inc	r5
                            370 ;       Peephole 132   changed ljmp to sjmp
   40C2 80 DD               371 	sjmp 00104$
   40C4                     372 00108$:
   40C4 22                  373 	ret
                            374 ;------------------------------------------------------------
                            375 ;Allocation info for local variables in function 'lcd_init'
                            376 ;------------------------------------------------------------
                            377 ;------------------------------------------------------------
                            378 ;Z:\pn\projekt\under.c:57: void lcd_init()
                            379 ;	-----------------------------------------
                            380 ;	 function lcd_init
                            381 ;	-----------------------------------------
   40C5                     382 _lcd_init:
                            383 ;Z:\pn\projekt\under.c:59: send_Command_8_bit(0x30);
                            384 ;     genCall
   40C5 75 82 30            385 	mov	dpl,#0x30
   40C8 12 40 38            386 	lcall	_send_Command_8_bit
                            387 ;Z:\pn\projekt\under.c:60: czekaj(50);
                            388 ;     genCall
                            389 ;       Peephole 182   used 16 bit load of dptr
   40CB 90 00 32            390 	mov  dptr,#(((0x00)<<8) + 0x32)
   40CE 12 40 99            391 	lcall	_czekaj
                            392 ;Z:\pn\projekt\under.c:61: send_Command_8_bit(0x30);
                            393 ;     genCall
   40D1 75 82 30            394 	mov	dpl,#0x30
   40D4 12 40 38            395 	lcall	_send_Command_8_bit
                            396 ;Z:\pn\projekt\under.c:62: czekaj(50);
                            397 ;     genCall
                            398 ;       Peephole 182   used 16 bit load of dptr
   40D7 90 00 32            399 	mov  dptr,#(((0x00)<<8) + 0x32)
   40DA 12 40 99            400 	lcall	_czekaj
                            401 ;Z:\pn\projekt\under.c:63: send_Command_8_bit(0x30);
                            402 ;     genCall
   40DD 75 82 30            403 	mov	dpl,#0x30
   40E0 12 40 38            404 	lcall	_send_Command_8_bit
                            405 ;Z:\pn\projekt\under.c:64: czekaj(50);
                            406 ;     genCall
                            407 ;       Peephole 182   used 16 bit load of dptr
   40E3 90 00 32            408 	mov  dptr,#(((0x00)<<8) + 0x32)
   40E6 12 40 99            409 	lcall	_czekaj
                            410 ;Z:\pn\projekt\under.c:65: send_Command_8_bit(0x20);
                            411 ;     genCall
   40E9 75 82 20            412 	mov	dpl,#0x20
   40EC 12 40 38            413 	lcall	_send_Command_8_bit
                            414 ;Z:\pn\projekt\under.c:66: czekaj(50);
                            415 ;     genCall
                            416 ;       Peephole 182   used 16 bit load of dptr
   40EF 90 00 32            417 	mov  dptr,#(((0x00)<<8) + 0x32)
   40F2 12 40 99            418 	lcall	_czekaj
                            419 ;Z:\pn\projekt\under.c:67: send_Command_4_bit(0x28);
                            420 ;     genCall
   40F5 75 82 28            421 	mov	dpl,#0x28
   40F8 12 40 45            422 	lcall	_send_Command_4_bit
                            423 ;Z:\pn\projekt\under.c:68: czekaj(50);
                            424 ;     genCall
                            425 ;       Peephole 182   used 16 bit load of dptr
   40FB 90 00 32            426 	mov  dptr,#(((0x00)<<8) + 0x32)
   40FE 12 40 99            427 	lcall	_czekaj
                            428 ;Z:\pn\projekt\under.c:69: send_Command_4_bit(0x08);
                            429 ;     genCall
   4101 75 82 08            430 	mov	dpl,#0x08
   4104 12 40 45            431 	lcall	_send_Command_4_bit
                            432 ;Z:\pn\projekt\under.c:71: czekaj(50);
                            433 ;     genCall
                            434 ;       Peephole 182   used 16 bit load of dptr
   4107 90 00 32            435 	mov  dptr,#(((0x00)<<8) + 0x32)
   410A 12 40 99            436 	lcall	_czekaj
                            437 ;Z:\pn\projekt\under.c:72: send_Command_4_bit(0x0E);
                            438 ;     genCall
   410D 75 82 0E            439 	mov	dpl,#0x0E
   4110 12 40 45            440 	lcall	_send_Command_4_bit
                            441 ;Z:\pn\projekt\under.c:73: czekaj(50);
                            442 ;     genCall
                            443 ;       Peephole 182   used 16 bit load of dptr
   4113 90 00 32            444 	mov  dptr,#(((0x00)<<8) + 0x32)
   4116 12 40 99            445 	lcall	_czekaj
                            446 ;Z:\pn\projekt\under.c:74: send_Command_4_bit(0x0E);
                            447 ;     genCall
   4119 75 82 0E            448 	mov	dpl,#0x0E
   411C 12 40 45            449 	lcall	_send_Command_4_bit
   411F                     450 00101$:
   411F 22                  451 	ret
                            452 ;------------------------------------------------------------
                            453 ;Allocation info for local variables in function 'lcd_write'
                            454 ;------------------------------------------------------------
                            455 ;text                      Allocated to registers r2 r3 r4 
                            456 ;------------------------------------------------------------
                            457 ;Z:\pn\projekt\under.c:78: void lcd_write(char *text) {
                            458 ;	-----------------------------------------
                            459 ;	 function lcd_write
                            460 ;	-----------------------------------------
   4120                     461 _lcd_write:
                            462 ;     genReceive
   4120 AA 82               463 	mov	r2,dpl
   4122 AB 83               464 	mov	r3,dph
   4124 AC F0               465 	mov	r4,b
                            466 ;Z:\pn\projekt\under.c:79: while(*text) {
                            467 ;     genAssign
   4126                     468 00101$:
                            469 ;     genPointerGet
                            470 ;     genGenPointerGet
   4126 8A 82               471 	mov	dpl,r2
   4128 8B 83               472 	mov	dph,r3
   412A 8C F0               473 	mov	b,r4
   412C 12 46 C9            474 	lcall	__gptrget
                            475 ;     genIfx
                            476 ;       Peephole 105   removed redundant mov
   412F FD                  477 	mov  r5,a
                            478 ;     genIfxJump
                            479 ;       Peephole 110   removed ljmp by inverse jump logic
   4130 60 2A               480 	jz  00104$
   4132                     481 00108$:
                            482 ;Z:\pn\projekt\under.c:80: send_Date(*text);
                            483 ;     genCall
   4132 8D 82               484 	mov	dpl,r5
   4134 C0 02               485 	push	ar2
   4136 C0 03               486 	push	ar3
   4138 C0 04               487 	push	ar4
   413A 12 40 68            488 	lcall	_send_Date
   413D D0 04               489 	pop	ar4
   413F D0 03               490 	pop	ar3
   4141 D0 02               491 	pop	ar2
                            492 ;Z:\pn\projekt\under.c:81: czekaj(100);
                            493 ;     genCall
                            494 ;       Peephole 182   used 16 bit load of dptr
   4143 90 00 64            495 	mov  dptr,#(((0x00)<<8) + 0x64)
   4146 C0 02               496 	push	ar2
   4148 C0 03               497 	push	ar3
   414A C0 04               498 	push	ar4
   414C 12 40 99            499 	lcall	_czekaj
   414F D0 04               500 	pop	ar4
   4151 D0 03               501 	pop	ar3
   4153 D0 02               502 	pop	ar2
                            503 ;Z:\pn\projekt\under.c:82: *text++;
                            504 ;     genPlus
                            505 ;     genPlusIncr
                            506 ;	tail increment optimized
   4155 0A                  507 	inc	r2
   4156 BA 00 CD            508 	cjne	r2,#0x00,00101$
   4159 0B                  509 	inc	r3
                            510 ;       Peephole 132   changed ljmp to sjmp
   415A 80 CA               511 	sjmp 00101$
   415C                     512 00104$:
   415C 22                  513 	ret
                            514 ;------------------------------------------------------------
                            515 ;Allocation info for local variables in function 'lcd_czas'
                            516 ;------------------------------------------------------------
                            517 ;text                      Allocated to registers r2 r3 r4 
                            518 ;------------------------------------------------------------
                            519 ;Z:\pn\projekt\under.c:86: void lcd_czas(char *text) {
                            520 ;	-----------------------------------------
                            521 ;	 function lcd_czas
                            522 ;	-----------------------------------------
   415D                     523 _lcd_czas:
                            524 ;     genReceive
                            525 ;Z:\pn\projekt\under.c:87: send_Date(*text);
                            526 ;     genPointerGet
                            527 ;     genGenPointerGet
   415D AA 82               528 	mov     r2,dpl
   415F AB 83               529 	mov     r3,dph
   4161 AC F0               530 	mov     r4,b
                            531 ;       Peephole 238d  removed 3 redundant moves
   4163 12 46 C9            532 	lcall	__gptrget
   4166 FD                  533 	mov	r5,a
   4167 A3                  534 	inc	dptr
   4168 AA 82               535 	mov	r2,dpl
   416A AB 83               536 	mov	r3,dph
   416C AC F0               537 	mov	r4,b
                            538 ;     genCall
   416E 8D 82               539 	mov	dpl,r5
   4170 C0 02               540 	push	ar2
   4172 C0 03               541 	push	ar3
   4174 C0 04               542 	push	ar4
   4176 12 40 68            543 	lcall	_send_Date
   4179 D0 04               544 	pop	ar4
   417B D0 03               545 	pop	ar3
   417D D0 02               546 	pop	ar2
                            547 ;Z:\pn\projekt\under.c:88: *text++;
                            548 ;Z:\pn\projekt\under.c:89: send_Date(*text);
                            549 ;     genPointerGet
                            550 ;     genGenPointerGet
   417F 8A 82               551 	mov	dpl,r2
   4181 8B 83               552 	mov	dph,r3
   4183 8C F0               553 	mov	b,r4
   4185 12 46 C9            554 	lcall	__gptrget
   4188 FA                  555 	mov	r2,a
                            556 ;     genCall
   4189 8A 82               557 	mov	dpl,r2
   418B 12 40 68            558 	lcall	_send_Date
   418E                     559 00101$:
   418E 22                  560 	ret
                            561 ;------------------------------------------------------------
                            562 ;Allocation info for local variables in function 'lcd_clear'
                            563 ;------------------------------------------------------------
                            564 ;------------------------------------------------------------
                            565 ;Z:\pn\projekt\under.c:92: void lcd_clear(void) {
                            566 ;	-----------------------------------------
                            567 ;	 function lcd_clear
                            568 ;	-----------------------------------------
   418F                     569 _lcd_clear:
                            570 ;Z:\pn\projekt\under.c:93: send_Command_4_bit(0x01);
                            571 ;     genCall
   418F 75 82 01            572 	mov	dpl,#0x01
   4192 12 40 45            573 	lcall	_send_Command_4_bit
                            574 ;Z:\pn\projekt\under.c:94: czekaj(20);
                            575 ;     genCall
                            576 ;       Peephole 182   used 16 bit load of dptr
   4195 90 00 14            577 	mov  dptr,#(((0x00)<<8) + 0x14)
   4198 12 40 99            578 	lcall	_czekaj
                            579 ;Z:\pn\projekt\under.c:95: send_Command_4_bit(0x02);
                            580 ;     genCall
   419B 75 82 02            581 	mov	dpl,#0x02
   419E 12 40 45            582 	lcall	_send_Command_4_bit
                            583 ;Z:\pn\projekt\under.c:96: czekaj(20);
                            584 ;     genCall
                            585 ;       Peephole 182   used 16 bit load of dptr
   41A1 90 00 14            586 	mov  dptr,#(((0x00)<<8) + 0x14)
   41A4 12 40 99            587 	lcall	_czekaj
                            588 ;Z:\pn\projekt\under.c:97: send_Command_4_bit(0x0D);
                            589 ;     genCall
   41A7 75 82 0D            590 	mov	dpl,#0x0D
   41AA 12 40 45            591 	lcall	_send_Command_4_bit
                            592 ;Z:\pn\projekt\under.c:98: czekaj(20);
                            593 ;     genCall
                            594 ;       Peephole 182   used 16 bit load of dptr
   41AD 90 00 14            595 	mov  dptr,#(((0x00)<<8) + 0x14)
   41B0 12 40 99            596 	lcall	_czekaj
                            597 ;Z:\pn\projekt\under.c:100: send_Command_4_bit(0x80);   
                            598 ;     genCall
   41B3 75 82 80            599 	mov	dpl,#0x80
   41B6 12 40 45            600 	lcall	_send_Command_4_bit
                            601 ;Z:\pn\projekt\under.c:101: czekaj(50);
                            602 ;     genCall
                            603 ;       Peephole 182   used 16 bit load of dptr
   41B9 90 00 32            604 	mov  dptr,#(((0x00)<<8) + 0x32)
   41BC 12 40 99            605 	lcall	_czekaj
   41BF                     606 00101$:
   41BF 22                  607 	ret
                            608 ;------------------------------------------------------------
                            609 ;Allocation info for local variables in function 'lcd_xy'
                            610 ;------------------------------------------------------------
                            611 ;k                         Allocated to in memory with name '_lcd_xy_PARM_2'
                            612 ;w                         Allocated to registers r2 
                            613 ;------------------------------------------------------------
                            614 ;Z:\pn\projekt\under.c:104: void lcd_xy(unsigned char w, unsigned char k)
                            615 ;	-----------------------------------------
                            616 ;	 function lcd_xy
                            617 ;	-----------------------------------------
   41C0                     618 _lcd_xy:
                            619 ;     genReceive
   41C0 AA 82               620 	mov	r2,dpl
                            621 ;Z:\pn\projekt\under.c:106: send_Command_4_bit((w*0x40+k) | 0x80);
                            622 ;     genMult
                            623 ;     genMultOneByte
   41C2 75 F0 40            624 	mov	b,#0x40
   41C5 EA                  625 	mov	a,r2
   41C6 A4                  626 	mul	ab
   41C7 FA                  627 	mov	r2,a
   41C8 AB F0               628 	mov	r3,b
                            629 ;     genCast
   41CA AC 0E               630 	mov	r4,_lcd_xy_PARM_2
   41CC 7D 00               631 	mov	r5,#0x00
                            632 ;     genPlus
                            633 ;       Peephole 236g
   41CE EC                  634 	mov  a,r4
                            635 ;       Peephole 236a
   41CF 2A                  636 	add  a,r2
   41D0 FA                  637 	mov	r2,a
                            638 ;       Peephole 236g
   41D1 ED                  639 	mov  a,r5
                            640 ;       Peephole 236b
   41D2 3B                  641 	addc  a,r3
   41D3 FB                  642 	mov	r3,a
                            643 ;     genOr
   41D4 43 02 80            644 	orl	ar2,#0x80
                            645 ;     genCast
   41D7 8A 82               646 	mov	dpl,r2
                            647 ;     genCall
   41D9 12 40 45            648 	lcall	_send_Command_4_bit
                            649 ;Z:\pn\projekt\under.c:107: czekaj(20);
                            650 ;     genCall
                            651 ;       Peephole 182   used 16 bit load of dptr
   41DC 90 00 14            652 	mov  dptr,#(((0x00)<<8) + 0x14)
   41DF 12 40 99            653 	lcall	_czekaj
   41E2                     654 00101$:
   41E2 22                  655 	ret
                            656 ;------------------------------------------------------------
                            657 ;Allocation info for local variables in function 'znak'
                            658 ;------------------------------------------------------------
                            659 ;------------------------------------------------------------
                            660 ;Z:\pn\projekt\under.c:110: char znak(int x) {
                            661 ;	-----------------------------------------
                            662 ;	 function znak
                            663 ;	-----------------------------------------
   41E3                     664 _znak:
                            665 ;     genReceive
   41E3 AA 82               666 	mov	r2,dpl
   41E5 AB 83               667 	mov	r3,dph
                            668 ;Z:\pn\projekt\under.c:111: switch(x) {
                            669 ;     genCmpLt
                            670 ;     genCmp
   41E7 EB                  671 	mov	a,r3
                            672 ;     genIfxJump
   41E8 30 E7 03            673 	jnb	acc.7,00116$
   41EB 02 42 52            674 	ljmp	00112$
   41EE                     675 00116$:
                            676 ;     genCmpGt
                            677 ;     genCmp
   41EE C3                  678 	clr	c
   41EF 74 09               679 	mov	a,#0x09
   41F1 9A                  680 	subb	a,r2
                            681 ;       Peephole 159   avoided xrl during execution
   41F2 74 80               682 	mov  a,#(0x00 ^ 0x80)
   41F4 8B F0               683 	mov	b,r3
   41F6 63 F0 80            684 	xrl	b,#0x80
   41F9 95 F0               685 	subb	a,b
                            686 ;     genIfxJump
                            687 ;       Peephole 132   changed ljmp to sjmp
                            688 ;       Peephole 160   removed sjmp by inverse jump logic
   41FB 40 55               689 	jc   00112$
   41FD                     690 00117$:
                            691 ;     genJumpTab
   41FD EA                  692 	mov	a,r2
   41FE 25 E0               693 	add	a,acc
   4200 2A                  694 	add	a,r2
   4201 90 42 05            695 	mov	dptr,#00118$
   4204 73                  696 	jmp	@a+dptr
   4205                     697 00118$:
   4205 02 42 23            698 	ljmp	00101$
   4208 02 42 28            699 	ljmp	00102$
   420B 02 42 2D            700 	ljmp	00103$
   420E 02 42 32            701 	ljmp	00104$
   4211 02 42 37            702 	ljmp	00105$
   4214 02 42 3C            703 	ljmp	00106$
   4217 02 42 41            704 	ljmp	00107$
   421A 02 42 46            705 	ljmp	00108$
   421D 02 42 4B            706 	ljmp	00109$
   4220 02 42 4F            707 	ljmp	00110$
                            708 ;Z:\pn\projekt\under.c:113: return '0';
   4223                     709 00101$:
                            710 ;     genRet
   4223 75 82 30            711 	mov	dpl,#0x30
                            712 ;Z:\pn\projekt\under.c:115: return '1';
                            713 ;       Peephole 132   changed ljmp to sjmp
   4226 80 2A               714 	sjmp 00112$
   4228                     715 00102$:
                            716 ;     genRet
   4228 75 82 31            717 	mov	dpl,#0x31
                            718 ;Z:\pn\projekt\under.c:117: return '2';
                            719 ;       Peephole 132   changed ljmp to sjmp
   422B 80 25               720 	sjmp 00112$
   422D                     721 00103$:
                            722 ;     genRet
   422D 75 82 32            723 	mov	dpl,#0x32
                            724 ;Z:\pn\projekt\under.c:119: return '3';
                            725 ;       Peephole 132   changed ljmp to sjmp
   4230 80 20               726 	sjmp 00112$
   4232                     727 00104$:
                            728 ;     genRet
   4232 75 82 33            729 	mov	dpl,#0x33
                            730 ;Z:\pn\projekt\under.c:121: return '4';
                            731 ;       Peephole 132   changed ljmp to sjmp
   4235 80 1B               732 	sjmp 00112$
   4237                     733 00105$:
                            734 ;     genRet
   4237 75 82 34            735 	mov	dpl,#0x34
                            736 ;Z:\pn\projekt\under.c:123: return '5';
                            737 ;       Peephole 132   changed ljmp to sjmp
   423A 80 16               738 	sjmp 00112$
   423C                     739 00106$:
                            740 ;     genRet
   423C 75 82 35            741 	mov	dpl,#0x35
                            742 ;Z:\pn\projekt\under.c:125: return '6';
                            743 ;       Peephole 132   changed ljmp to sjmp
   423F 80 11               744 	sjmp 00112$
   4241                     745 00107$:
                            746 ;     genRet
   4241 75 82 36            747 	mov	dpl,#0x36
                            748 ;Z:\pn\projekt\under.c:127: return '7';
                            749 ;       Peephole 132   changed ljmp to sjmp
   4244 80 0C               750 	sjmp 00112$
   4246                     751 00108$:
                            752 ;     genRet
   4246 75 82 37            753 	mov	dpl,#0x37
                            754 ;Z:\pn\projekt\under.c:129: return '8';
                            755 ;       Peephole 132   changed ljmp to sjmp
   4249 80 07               756 	sjmp 00112$
   424B                     757 00109$:
                            758 ;     genRet
   424B 75 82 38            759 	mov	dpl,#0x38
                            760 ;Z:\pn\projekt\under.c:131: return '9';
                            761 ;       Peephole 132   changed ljmp to sjmp
                            762 ;     genRet
                            763 ;Z:\pn\projekt\under.c:132: }
                            764 ;       Peephole 237a  removed sjmp to ret
   424E 22                  765 	ret
   424F                     766 00110$:
   424F 75 82 39            767 	mov     dpl,#0x39
   4252                     768 00112$:
   4252 22                  769 	ret
                            770 ;------------------------------------------------------------
                            771 ;Allocation info for local variables in function 'zmien_czas'
                            772 ;------------------------------------------------------------
                            773 ;czas                      Allocated to registers r2 r3 
                            774 ;t2                        Allocated to registers r4 r5 
                            775 ;t1                        Allocated to registers r6 r7 
                            776 ;t                         Allocated to registers r2 r3 
                            777 ;------------------------------------------------------------
                            778 ;Z:\pn\projekt\under.c:135: void zmien_czas(int czas)
                            779 ;	-----------------------------------------
                            780 ;	 function zmien_czas
                            781 ;	-----------------------------------------
   4253                     782 _zmien_czas:
                            783 ;     genReceive
   4253 AA 82               784 	mov	r2,dpl
   4255 AB 83               785 	mov	r3,dph
                            786 ;Z:\pn\projekt\under.c:139: int t = _godzina + czas;
                            787 ;     genPlus
                            788 ;       Peephole 236g
   4257 EA                  789 	mov  a,r2
   4258 25 08               790 	add	a,__godzina
   425A FA                  791 	mov	r2,a
                            792 ;       Peephole 236g
   425B EB                  793 	mov  a,r3
   425C 35 09               794 	addc	a,(__godzina + 1)
   425E FB                  795 	mov	r3,a
                            796 ;Z:\pn\projekt\under.c:141: if(t >= 24)
                            797 ;     genCmpLt
                            798 ;     genCmp
   425F C3                  799 	clr	c
   4260 EA                  800 	mov	a,r2
   4261 94 18               801 	subb	a,#0x18
   4263 EB                  802 	mov	a,r3
   4264 64 80               803 	xrl	a,#0x80
   4266 94 80               804 	subb	a,#0x80
                            805 ;     genIfxJump
                            806 ;       Peephole 132   changed ljmp to sjmp
                            807 ;       Peephole 160   removed sjmp by inverse jump logic
   4268 40 08               808 	jc   00102$
   426A                     809 00106$:
                            810 ;Z:\pn\projekt\under.c:142: t = t - 24;
                            811 ;     genMinus
   426A EA                  812 	mov	a,r2
   426B 24 E8               813 	add	a,#0xe8
   426D FA                  814 	mov	r2,a
   426E EB                  815 	mov	a,r3
   426F 34 FF               816 	addc	a,#0xff
   4271 FB                  817 	mov	r3,a
   4272                     818 00102$:
                            819 ;Z:\pn\projekt\under.c:144: t2 = t / 10;
                            820 ;     genAssign
   4272 E4                  821 	clr	a
   4273 F5 10               822 	mov	(__divsint_PARM_2 + 1),a
   4275 75 0F 0A            823 	mov	__divsint_PARM_2,#0x0A
                            824 ;     genCall
   4278 8A 82               825 	mov	dpl,r2
   427A 8B 83               826 	mov	dph,r3
   427C C0 02               827 	push	ar2
   427E C0 03               828 	push	ar3
   4280 12 46 F4            829 	lcall	__divsint
   4283 E5 82               830 	mov	a,dpl
   4285 85 83 F0            831 	mov	b,dph
   4288 D0 03               832 	pop	ar3
   428A D0 02               833 	pop	ar2
                            834 ;     genAssign
   428C FC                  835 	mov	r4,a
   428D AD F0               836 	mov	r5,b
                            837 ;Z:\pn\projekt\under.c:146: t1 = t - t2*10;
                            838 ;     genAssign
   428F E4                  839 	clr	a
   4290 F5 10               840 	mov	(__mulsint_PARM_2 + 1),a
   4292 75 0F 0A            841 	mov	__mulsint_PARM_2,#0x0A
                            842 ;     genCall
   4295 8C 82               843 	mov	dpl,r4
   4297 8D 83               844 	mov	dph,r5
   4299 C0 02               845 	push	ar2
   429B C0 03               846 	push	ar3
   429D C0 04               847 	push	ar4
   429F C0 05               848 	push	ar5
   42A1 12 46 7F            849 	lcall	__mulsint
   42A4 AE 82               850 	mov	r6,dpl
   42A6 AF 83               851 	mov	r7,dph
   42A8 D0 05               852 	pop	ar5
   42AA D0 04               853 	pop	ar4
   42AC D0 03               854 	pop	ar3
   42AE D0 02               855 	pop	ar2
                            856 ;     genMinus
   42B0 EA                  857 	mov	a,r2
   42B1 C3                  858 	clr	c
                            859 ;       Peephole 236l
   42B2 9E                  860 	subb  a,r6
   42B3 FE                  861 	mov	r6,a
   42B4 EB                  862 	mov	a,r3
                            863 ;       Peephole 236l
   42B5 9F                  864 	subb  a,r7
   42B6 FF                  865 	mov	r7,a
                            866 ;Z:\pn\projekt\under.c:148: lcd_xy(1, 0);
                            867 ;     genAssign
   42B7 75 0E 00            868 	mov	_lcd_xy_PARM_2,#0x00
                            869 ;     genCall
   42BA 75 82 01            870 	mov	dpl,#0x01
   42BD C0 02               871 	push	ar2
   42BF C0 03               872 	push	ar3
   42C1 C0 04               873 	push	ar4
   42C3 C0 05               874 	push	ar5
   42C5 C0 06               875 	push	ar6
   42C7 C0 07               876 	push	ar7
   42C9 12 41 C0            877 	lcall	_lcd_xy
   42CC D0 07               878 	pop	ar7
   42CE D0 06               879 	pop	ar6
   42D0 D0 05               880 	pop	ar5
   42D2 D0 04               881 	pop	ar4
   42D4 D0 03               882 	pop	ar3
   42D6 D0 02               883 	pop	ar2
                            884 ;Z:\pn\projekt\under.c:150: send_Date(znak(t2));
                            885 ;     genCall
   42D8 8C 82               886 	mov	dpl,r4
   42DA 8D 83               887 	mov	dph,r5
   42DC C0 02               888 	push	ar2
   42DE C0 03               889 	push	ar3
   42E0 C0 04               890 	push	ar4
   42E2 C0 05               891 	push	ar5
   42E4 C0 06               892 	push	ar6
   42E6 C0 07               893 	push	ar7
   42E8 12 41 E3            894 	lcall	_znak
   42EB D0 07               895 	pop	ar7
   42ED D0 06               896 	pop	ar6
   42EF D0 05               897 	pop	ar5
   42F1 D0 04               898 	pop	ar4
   42F3 D0 03               899 	pop	ar3
   42F5 D0 02               900 	pop	ar2
                            901 ;     genCall
   42F7 C0 02               902 	push	ar2
   42F9 C0 03               903 	push	ar3
   42FB C0 04               904 	push	ar4
   42FD C0 05               905 	push	ar5
   42FF C0 06               906 	push	ar6
   4301 C0 07               907 	push	ar7
   4303 12 40 68            908 	lcall	_send_Date
   4306 D0 07               909 	pop	ar7
   4308 D0 06               910 	pop	ar6
   430A D0 05               911 	pop	ar5
   430C D0 04               912 	pop	ar4
   430E D0 03               913 	pop	ar3
   4310 D0 02               914 	pop	ar2
                            915 ;Z:\pn\projekt\under.c:151: send_Date(znak(t1));
                            916 ;     genCall
   4312 8E 82               917 	mov	dpl,r6
   4314 8F 83               918 	mov	dph,r7
   4316 C0 02               919 	push	ar2
   4318 C0 03               920 	push	ar3
   431A C0 04               921 	push	ar4
   431C C0 05               922 	push	ar5
   431E C0 06               923 	push	ar6
   4320 C0 07               924 	push	ar7
   4322 12 41 E3            925 	lcall	_znak
   4325 D0 07               926 	pop	ar7
   4327 D0 06               927 	pop	ar6
   4329 D0 05               928 	pop	ar5
   432B D0 04               929 	pop	ar4
   432D D0 03               930 	pop	ar3
   432F D0 02               931 	pop	ar2
                            932 ;     genCall
   4331 C0 02               933 	push	ar2
   4333 C0 03               934 	push	ar3
   4335 C0 04               935 	push	ar4
   4337 C0 05               936 	push	ar5
   4339 C0 06               937 	push	ar6
   433B C0 07               938 	push	ar7
   433D 12 40 68            939 	lcall	_send_Date
   4340 D0 07               940 	pop	ar7
   4342 D0 06               941 	pop	ar6
   4344 D0 05               942 	pop	ar5
   4346 D0 04               943 	pop	ar4
   4348 D0 03               944 	pop	ar3
   434A D0 02               945 	pop	ar2
                            946 ;Z:\pn\projekt\under.c:152: lcd_write(" : ");
                            947 ;     genCall
                            948 ;       Peephole 182a use 16 bit load of DPTR
   434C 90 46 43            949 	mov dptr,#__str_0
   434F 75 F0 02            950 	mov	b,#0x02
   4352 C0 02               951 	push	ar2
   4354 C0 03               952 	push	ar3
   4356 C0 04               953 	push	ar4
   4358 C0 05               954 	push	ar5
   435A C0 06               955 	push	ar6
   435C C0 07               956 	push	ar7
   435E 12 41 20            957 	lcall	_lcd_write
   4361 D0 07               958 	pop	ar7
   4363 D0 06               959 	pop	ar6
   4365 D0 05               960 	pop	ar5
   4367 D0 04               961 	pop	ar4
   4369 D0 03               962 	pop	ar3
   436B D0 02               963 	pop	ar2
                            964 ;Z:\pn\projekt\under.c:154: t = _minuta;
                            965 ;     genAssign
   436D AA 0A               966 	mov	r2,__minuta
   436F AB 0B               967 	mov	r3,(__minuta + 1)
                            968 ;Z:\pn\projekt\under.c:155: t2 = t / 10;
                            969 ;     genAssign
   4371 E4                  970 	clr	a
   4372 F5 10               971 	mov	(__divsint_PARM_2 + 1),a
   4374 75 0F 0A            972 	mov	__divsint_PARM_2,#0x0A
                            973 ;     genCall
   4377 8A 82               974 	mov	dpl,r2
   4379 8B 83               975 	mov	dph,r3
   437B C0 02               976 	push	ar2
   437D C0 03               977 	push	ar3
   437F C0 04               978 	push	ar4
   4381 C0 05               979 	push	ar5
   4383 C0 06               980 	push	ar6
   4385 C0 07               981 	push	ar7
   4387 12 46 F4            982 	lcall	__divsint
   438A E5 82               983 	mov	a,dpl
   438C 85 83 F0            984 	mov	b,dph
   438F D0 07               985 	pop	ar7
   4391 D0 06               986 	pop	ar6
   4393 D0 05               987 	pop	ar5
   4395 D0 04               988 	pop	ar4
   4397 D0 03               989 	pop	ar3
   4399 D0 02               990 	pop	ar2
                            991 ;     genAssign
   439B FC                  992 	mov	r4,a
   439C AD F0               993 	mov	r5,b
                            994 ;Z:\pn\projekt\under.c:156: t1 = t - t2*10;
                            995 ;     genAssign
   439E E4                  996 	clr	a
   439F F5 10               997 	mov	(__mulsint_PARM_2 + 1),a
   43A1 75 0F 0A            998 	mov	__mulsint_PARM_2,#0x0A
                            999 ;     genCall
   43A4 8C 82              1000 	mov	dpl,r4
   43A6 8D 83              1001 	mov	dph,r5
   43A8 C0 02              1002 	push	ar2
   43AA C0 03              1003 	push	ar3
   43AC C0 04              1004 	push	ar4
   43AE C0 05              1005 	push	ar5
   43B0 C0 06              1006 	push	ar6
   43B2 C0 07              1007 	push	ar7
   43B4 12 46 7F           1008 	lcall	__mulsint
   43B7 A8 82              1009 	mov	r0,dpl
   43B9 A9 83              1010 	mov	r1,dph
   43BB D0 07              1011 	pop	ar7
   43BD D0 06              1012 	pop	ar6
   43BF D0 05              1013 	pop	ar5
   43C1 D0 04              1014 	pop	ar4
   43C3 D0 03              1015 	pop	ar3
   43C5 D0 02              1016 	pop	ar2
                           1017 ;     genMinus
   43C7 EA                 1018 	mov	a,r2
   43C8 C3                 1019 	clr	c
                           1020 ;       Peephole 236l
   43C9 98                 1021 	subb  a,r0
   43CA FE                 1022 	mov	r6,a
   43CB EB                 1023 	mov	a,r3
                           1024 ;       Peephole 236l
   43CC 99                 1025 	subb  a,r1
   43CD FF                 1026 	mov	r7,a
                           1027 ;Z:\pn\projekt\under.c:158: send_Date(znak(t2));
                           1028 ;     genCall
   43CE 8C 82              1029 	mov	dpl,r4
   43D0 8D 83              1030 	mov	dph,r5
   43D2 C0 06              1031 	push	ar6
   43D4 C0 07              1032 	push	ar7
   43D6 12 41 E3           1033 	lcall	_znak
   43D9 D0 07              1034 	pop	ar7
   43DB D0 06              1035 	pop	ar6
                           1036 ;     genCall
   43DD C0 06              1037 	push	ar6
   43DF C0 07              1038 	push	ar7
   43E1 12 40 68           1039 	lcall	_send_Date
   43E4 D0 07              1040 	pop	ar7
   43E6 D0 06              1041 	pop	ar6
                           1042 ;Z:\pn\projekt\under.c:159: send_Date(znak(t1));
                           1043 ;     genCall
   43E8 8E 82              1044 	mov	dpl,r6
   43EA 8F 83              1045 	mov	dph,r7
   43EC 12 41 E3           1046 	lcall	_znak
                           1047 ;     genCall
   43EF 12 40 68           1048 	lcall	_send_Date
   43F2                    1049 00103$:
   43F2 22                 1050 	ret
                           1051 ;------------------------------------------------------------
                           1052 ;Allocation info for local variables in function 'strefa'
                           1053 ;------------------------------------------------------------
                           1054 ;s                         Allocated to registers r2 r3 
                           1055 ;------------------------------------------------------------
                           1056 ;Z:\pn\projekt\under.c:162: void strefa(int s) {
                           1057 ;	-----------------------------------------
                           1058 ;	 function strefa
                           1059 ;	-----------------------------------------
   43F3                    1060 _strefa:
                           1061 ;     genReceive
   43F3 AA 82              1062 	mov	r2,dpl
   43F5 AB 83              1063 	mov	r3,dph
                           1064 ;Z:\pn\projekt\under.c:163: lcd_clear();
                           1065 ;     genCall
   43F7 C0 02              1066 	push	ar2
   43F9 C0 03              1067 	push	ar3
   43FB 12 41 8F           1068 	lcall	_lcd_clear
   43FE D0 03              1069 	pop	ar3
   4400 D0 02              1070 	pop	ar2
                           1071 ;Z:\pn\projekt\under.c:164: lcd_xy(0, 0);
                           1072 ;     genAssign
   4402 75 0E 00           1073 	mov	_lcd_xy_PARM_2,#0x00
                           1074 ;     genCall
   4405 75 82 00           1075 	mov	dpl,#0x00
   4408 C0 02              1076 	push	ar2
   440A C0 03              1077 	push	ar3
   440C 12 41 C0           1078 	lcall	_lcd_xy
   440F D0 03              1079 	pop	ar3
   4411 D0 02              1080 	pop	ar2
                           1081 ;Z:\pn\projekt\under.c:166: if(s == 0) {
                           1082 ;     genCmpEq
                           1083 ;       Peephole 132   changed ljmp to sjmp
                           1084 ;       Peephole 198   optimized misc jump sequence
   4413 BA 00 22           1085 	cjne r2,#0x00,00102$
   4416 BB 00 1F           1086 	cjne r3,#0x00,00102$
                           1087 ;00127$:
                           1088 ;       Peephole 200   removed redundant sjmp
   4419                    1089 00128$:
                           1090 ;Z:\pn\projekt\under.c:167: lcd_write("Warszawa");
                           1091 ;     genCall
                           1092 ;       Peephole 182a use 16 bit load of DPTR
   4419 90 46 47           1093 	mov dptr,#__str_1
   441C 75 F0 02           1094 	mov	b,#0x02
   441F C0 02              1095 	push	ar2
   4421 C0 03              1096 	push	ar3
   4423 12 41 20           1097 	lcall	_lcd_write
   4426 D0 03              1098 	pop	ar3
   4428 D0 02              1099 	pop	ar2
                           1100 ;Z:\pn\projekt\under.c:168: zmien_czas(0);
                           1101 ;     genCall
                           1102 ;       Peephole 181   used 16 bit load of dptr
   442A 90 00 00           1103 	mov  dptr,#0x0000
   442D C0 02              1104 	push	ar2
   442F C0 03              1105 	push	ar3
   4431 12 42 53           1106 	lcall	_zmien_czas
   4434 D0 03              1107 	pop	ar3
   4436 D0 02              1108 	pop	ar2
   4438                    1109 00102$:
                           1110 ;Z:\pn\projekt\under.c:170: if(s == 1) {
                           1111 ;     genCmpEq
                           1112 ;       Peephole 132   changed ljmp to sjmp
                           1113 ;       Peephole 198   optimized misc jump sequence
   4438 BA 01 22           1114 	cjne r2,#0x01,00104$
   443B BB 00 1F           1115 	cjne r3,#0x00,00104$
                           1116 ;00129$:
                           1117 ;       Peephole 200   removed redundant sjmp
   443E                    1118 00130$:
                           1119 ;Z:\pn\projekt\under.c:171: lcd_write("Moskwa");
                           1120 ;     genCall
                           1121 ;       Peephole 182a use 16 bit load of DPTR
   443E 90 46 50           1122 	mov dptr,#__str_2
   4441 75 F0 02           1123 	mov	b,#0x02
   4444 C0 02              1124 	push	ar2
   4446 C0 03              1125 	push	ar3
   4448 12 41 20           1126 	lcall	_lcd_write
   444B D0 03              1127 	pop	ar3
   444D D0 02              1128 	pop	ar2
                           1129 ;Z:\pn\projekt\under.c:172: zmien_czas(2);     
                           1130 ;     genCall
                           1131 ;       Peephole 182   used 16 bit load of dptr
   444F 90 00 02           1132 	mov  dptr,#(((0x00)<<8) + 0x02)
   4452 C0 02              1133 	push	ar2
   4454 C0 03              1134 	push	ar3
   4456 12 42 53           1135 	lcall	_zmien_czas
   4459 D0 03              1136 	pop	ar3
   445B D0 02              1137 	pop	ar2
   445D                    1138 00104$:
                           1139 ;Z:\pn\projekt\under.c:174: if(s == 2) {
                           1140 ;     genCmpEq
                           1141 ;       Peephole 132   changed ljmp to sjmp
                           1142 ;       Peephole 198   optimized misc jump sequence
   445D BA 02 22           1143 	cjne r2,#0x02,00106$
   4460 BB 00 1F           1144 	cjne r3,#0x00,00106$
                           1145 ;00131$:
                           1146 ;       Peephole 200   removed redundant sjmp
   4463                    1147 00132$:
                           1148 ;Z:\pn\projekt\under.c:175: lcd_write("Tokio");
                           1149 ;     genCall
                           1150 ;       Peephole 182a use 16 bit load of DPTR
   4463 90 46 57           1151 	mov dptr,#__str_3
   4466 75 F0 02           1152 	mov	b,#0x02
   4469 C0 02              1153 	push	ar2
   446B C0 03              1154 	push	ar3
   446D 12 41 20           1155 	lcall	_lcd_write
   4470 D0 03              1156 	pop	ar3
   4472 D0 02              1157 	pop	ar2
                           1158 ;Z:\pn\projekt\under.c:176: zmien_czas(7);
                           1159 ;     genCall
                           1160 ;       Peephole 182   used 16 bit load of dptr
   4474 90 00 07           1161 	mov  dptr,#(((0x00)<<8) + 0x07)
   4477 C0 02              1162 	push	ar2
   4479 C0 03              1163 	push	ar3
   447B 12 42 53           1164 	lcall	_zmien_czas
   447E D0 03              1165 	pop	ar3
   4480 D0 02              1166 	pop	ar2
   4482                    1167 00106$:
                           1168 ;Z:\pn\projekt\under.c:178: if(s == 3) {
                           1169 ;     genCmpEq
                           1170 ;       Peephole 132   changed ljmp to sjmp
                           1171 ;       Peephole 198   optimized misc jump sequence
   4482 BA 03 22           1172 	cjne r2,#0x03,00108$
   4485 BB 00 1F           1173 	cjne r3,#0x00,00108$
                           1174 ;00133$:
                           1175 ;       Peephole 200   removed redundant sjmp
   4488                    1176 00134$:
                           1177 ;Z:\pn\projekt\under.c:179: lcd_write("Londyn");
                           1178 ;     genCall
                           1179 ;       Peephole 182a use 16 bit load of DPTR
   4488 90 46 5D           1180 	mov dptr,#__str_4
   448B 75 F0 02           1181 	mov	b,#0x02
   448E C0 02              1182 	push	ar2
   4490 C0 03              1183 	push	ar3
   4492 12 41 20           1184 	lcall	_lcd_write
   4495 D0 03              1185 	pop	ar3
   4497 D0 02              1186 	pop	ar2
                           1187 ;Z:\pn\projekt\under.c:180: zmien_czas(-1);
                           1188 ;     genCall
                           1189 ;       Peephole 182   used 16 bit load of dptr
   4499 90 FF FF           1190 	mov  dptr,#(((0xFF)<<8) + 0xFF)
   449C C0 02              1191 	push	ar2
   449E C0 03              1192 	push	ar3
   44A0 12 42 53           1193 	lcall	_zmien_czas
   44A3 D0 03              1194 	pop	ar3
   44A5 D0 02              1195 	pop	ar2
   44A7                    1196 00108$:
                           1197 ;Z:\pn\projekt\under.c:182: if(s == 4) {
                           1198 ;     genCmpEq
                           1199 ;       Peephole 132   changed ljmp to sjmp
                           1200 ;       Peephole 198   optimized misc jump sequence
   44A7 BA 04 22           1201 	cjne r2,#0x04,00110$
   44AA BB 00 1F           1202 	cjne r3,#0x00,00110$
                           1203 ;00135$:
                           1204 ;       Peephole 200   removed redundant sjmp
   44AD                    1205 00136$:
                           1206 ;Z:\pn\projekt\under.c:183: lcd_write("Chicago");
                           1207 ;     genCall
                           1208 ;       Peephole 182a use 16 bit load of DPTR
   44AD 90 46 64           1209 	mov dptr,#__str_5
   44B0 75 F0 02           1210 	mov	b,#0x02
   44B3 C0 02              1211 	push	ar2
   44B5 C0 03              1212 	push	ar3
   44B7 12 41 20           1213 	lcall	_lcd_write
   44BA D0 03              1214 	pop	ar3
   44BC D0 02              1215 	pop	ar2
                           1216 ;Z:\pn\projekt\under.c:184: zmien_czas(-5);
                           1217 ;     genCall
                           1218 ;       Peephole 182   used 16 bit load of dptr
   44BE 90 FF FB           1219 	mov  dptr,#(((0xFF)<<8) + 0xFB)
   44C1 C0 02              1220 	push	ar2
   44C3 C0 03              1221 	push	ar3
   44C5 12 42 53           1222 	lcall	_zmien_czas
   44C8 D0 03              1223 	pop	ar3
   44CA D0 02              1224 	pop	ar2
   44CC                    1225 00110$:
                           1226 ;Z:\pn\projekt\under.c:186: if(s == 5) {
                           1227 ;     genCmpEq
                           1228 ;       Peephole 132   changed ljmp to sjmp
                           1229 ;       Peephole 198   optimized misc jump sequence
   44CC BA 05 22           1230 	cjne r2,#0x05,00112$
   44CF BB 00 1F           1231 	cjne r3,#0x00,00112$
                           1232 ;00137$:
                           1233 ;       Peephole 200   removed redundant sjmp
   44D2                    1234 00138$:
                           1235 ;Z:\pn\projekt\under.c:187: lcd_write("Kijow");
                           1236 ;     genCall
                           1237 ;       Peephole 182a use 16 bit load of DPTR
   44D2 90 46 6C           1238 	mov dptr,#__str_6
   44D5 75 F0 02           1239 	mov	b,#0x02
   44D8 C0 02              1240 	push	ar2
   44DA C0 03              1241 	push	ar3
   44DC 12 41 20           1242 	lcall	_lcd_write
   44DF D0 03              1243 	pop	ar3
   44E1 D0 02              1244 	pop	ar2
                           1245 ;Z:\pn\projekt\under.c:188: zmien_czas(1);
                           1246 ;     genCall
                           1247 ;       Peephole 182   used 16 bit load of dptr
   44E3 90 00 01           1248 	mov  dptr,#(((0x00)<<8) + 0x01)
   44E6 C0 02              1249 	push	ar2
   44E8 C0 03              1250 	push	ar3
   44EA 12 42 53           1251 	lcall	_zmien_czas
   44ED D0 03              1252 	pop	ar3
   44EF D0 02              1253 	pop	ar2
   44F1                    1254 00112$:
                           1255 ;Z:\pn\projekt\under.c:190: if(s == 6) {
                           1256 ;     genCmpEq
                           1257 ;       Peephole 132   changed ljmp to sjmp
                           1258 ;       Peephole 198   optimized misc jump sequence
   44F1 BA 06 22           1259 	cjne r2,#0x06,00114$
   44F4 BB 00 1F           1260 	cjne r3,#0x00,00114$
                           1261 ;00139$:
                           1262 ;       Peephole 200   removed redundant sjmp
   44F7                    1263 00140$:
                           1264 ;Z:\pn\projekt\under.c:191: lcd_write("Pekin");
                           1265 ;     genCall
                           1266 ;       Peephole 182a use 16 bit load of DPTR
   44F7 90 46 72           1267 	mov dptr,#__str_7
   44FA 75 F0 02           1268 	mov	b,#0x02
   44FD C0 02              1269 	push	ar2
   44FF C0 03              1270 	push	ar3
   4501 12 41 20           1271 	lcall	_lcd_write
   4504 D0 03              1272 	pop	ar3
   4506 D0 02              1273 	pop	ar2
                           1274 ;Z:\pn\projekt\under.c:192: zmien_czas(5);
                           1275 ;     genCall
                           1276 ;       Peephole 182   used 16 bit load of dptr
   4508 90 00 05           1277 	mov  dptr,#(((0x00)<<8) + 0x05)
   450B C0 02              1278 	push	ar2
   450D C0 03              1279 	push	ar3
   450F 12 42 53           1280 	lcall	_zmien_czas
   4512 D0 03              1281 	pop	ar3
   4514 D0 02              1282 	pop	ar2
   4516                    1283 00114$:
                           1284 ;Z:\pn\projekt\under.c:194: if(s == 7) {
                           1285 ;     genCmpEq
                           1286 ;       Peephole 132   changed ljmp to sjmp
                           1287 ;       Peephole 198   optimized misc jump sequence
   4516 BA 07 12           1288 	cjne r2,#0x07,00116$
   4519 BB 00 0F           1289 	cjne r3,#0x00,00116$
                           1290 ;00141$:
                           1291 ;       Peephole 200   removed redundant sjmp
   451C                    1292 00142$:
                           1293 ;Z:\pn\projekt\under.c:195: lcd_write("Bagdad");
                           1294 ;     genCall
                           1295 ;       Peephole 182a use 16 bit load of DPTR
   451C 90 46 78           1296 	mov dptr,#__str_8
   451F 75 F0 02           1297 	mov	b,#0x02
   4522 12 41 20           1298 	lcall	_lcd_write
                           1299 ;Z:\pn\projekt\under.c:196: zmien_czas(4);
                           1300 ;     genCall
                           1301 ;       Peephole 182   used 16 bit load of dptr
   4525 90 00 04           1302 	mov  dptr,#(((0x00)<<8) + 0x04)
   4528 12 42 53           1303 	lcall	_zmien_czas
   452B                    1304 00116$:
                           1305 ;Z:\pn\projekt\under.c:198: czekaj(100);
                           1306 ;     genCall
                           1307 ;       Peephole 182   used 16 bit load of dptr
   452B 90 00 64           1308 	mov  dptr,#(((0x00)<<8) + 0x64)
   452E 12 40 99           1309 	lcall	_czekaj
   4531                    1310 00117$:
   4531 22                 1311 	ret
                           1312 ;------------------------------------------------------------
                           1313 ;Allocation info for local variables in function 'czas'
                           1314 ;------------------------------------------------------------
                           1315 ;------------------------------------------------------------
                           1316 ;Z:\pn\projekt\under.c:201: void czas(void) {
                           1317 ;	-----------------------------------------
                           1318 ;	 function czas
                           1319 ;	-----------------------------------------
   4532                    1320 _czas:
                           1321 ;Z:\pn\projekt\under.c:202: if(_czas == 500) {
                           1322 ;     genCmpEq
   4532 E5 0C              1323 	mov	a,__czas
                           1324 ;       Peephole 132   changed ljmp to sjmp
                           1325 ;       Peephole 197   optimized misc jump sequence
   4534 B4 F4 52           1326 	cjne a,#0xF4,00106$
   4537 E5 0D              1327 	mov  a,(__czas + 1)
   4539 B4 01 4D           1328 	cjne a,#0x01,00106$
                           1329 ;00112$:
                           1330 ;       Peephole 200   removed redundant sjmp
   453C                    1331 00113$:
                           1332 ;Z:\pn\projekt\under.c:203: _minuta++;
                           1333 ;     genPlus
                           1334 ;     genPlusIncr
   453C 74 01              1335 	mov	a,#0x01
   453E 25 0A              1336 	add	a,__minuta
   4540 F5 0A              1337 	mov	__minuta,a
                           1338 ;       Peephole 180   changed mov to clr
   4542 E4                 1339 	clr  a
   4543 35 0B              1340 	addc	a,(__minuta + 1)
   4545 F5 0B              1341 	mov	(__minuta + 1),a
                           1342 ;Z:\pn\projekt\under.c:204: _czas = 0;
                           1343 ;     genAssign
   4547 E4                 1344 	clr	a
   4548 F5 0D              1345 	mov	(__czas + 1),a
   454A F5 0C              1346 	mov	__czas,a
                           1347 ;Z:\pn\projekt\under.c:206: if (_minuta>59){
                           1348 ;     genCmpGt
                           1349 ;     genCmp
   454C C3                 1350 	clr	c
   454D 74 3B              1351 	mov	a,#0x3B
   454F 95 0A              1352 	subb	a,__minuta
                           1353 ;       Peephole 159   avoided xrl during execution
   4551 74 80              1354 	mov  a,#(0x00 ^ 0x80)
   4553 85 0B F0           1355 	mov	b,(__minuta + 1)
   4556 63 F0 80           1356 	xrl	b,#0x80
   4559 95 F0              1357 	subb	a,b
                           1358 ;     genIfxJump
                           1359 ;       Peephole 108   removed ljmp by inverse jump logic
   455B 50 10              1360 	jnc  00102$
   455D                    1361 00114$:
                           1362 ;Z:\pn\projekt\under.c:207: _minuta = 0;
                           1363 ;     genAssign
   455D E4                 1364 	clr	a
   455E F5 0B              1365 	mov	(__minuta + 1),a
   4560 F5 0A              1366 	mov	__minuta,a
                           1367 ;Z:\pn\projekt\under.c:208: _godzina++;
                           1368 ;     genPlus
                           1369 ;     genPlusIncr
   4562 74 01              1370 	mov	a,#0x01
   4564 25 08              1371 	add	a,__godzina
   4566 F5 08              1372 	mov	__godzina,a
                           1373 ;       Peephole 180   changed mov to clr
   4568 E4                 1374 	clr  a
   4569 35 09              1375 	addc	a,(__godzina + 1)
   456B F5 09              1376 	mov	(__godzina + 1),a
   456D                    1377 00102$:
                           1378 ;Z:\pn\projekt\under.c:211: if (_godzina>23){
                           1379 ;     genCmpGt
                           1380 ;     genCmp
   456D C3                 1381 	clr	c
   456E 74 17              1382 	mov	a,#0x17
   4570 95 08              1383 	subb	a,__godzina
                           1384 ;       Peephole 159   avoided xrl during execution
   4572 74 80              1385 	mov  a,#(0x00 ^ 0x80)
   4574 85 09 F0           1386 	mov	b,(__godzina + 1)
   4577 63 F0 80           1387 	xrl	b,#0x80
   457A 95 F0              1388 	subb	a,b
                           1389 ;     genIfxJump
                           1390 ;       Peephole 108   removed ljmp by inverse jump logic
   457C 50 0B              1391 	jnc  00106$
   457E                    1392 00115$:
                           1393 ;Z:\pn\projekt\under.c:212: _godzina++;
                           1394 ;     genPlus
                           1395 ;     genPlusIncr
   457E 74 01              1396 	mov	a,#0x01
   4580 25 08              1397 	add	a,__godzina
   4582 F5 08              1398 	mov	__godzina,a
                           1399 ;       Peephole 180   changed mov to clr
   4584 E4                 1400 	clr  a
   4585 35 09              1401 	addc	a,(__godzina + 1)
   4587 F5 09              1402 	mov	(__godzina + 1),a
   4589                    1403 00106$:
                           1404 ;Z:\pn\projekt\under.c:215: _czas++;
                           1405 ;     genPlus
                           1406 ;     genPlusIncr
   4589 74 01              1407 	mov	a,#0x01
   458B 25 0C              1408 	add	a,__czas
   458D F5 0C              1409 	mov	__czas,a
                           1410 ;       Peephole 180   changed mov to clr
   458F E4                 1411 	clr  a
   4590 35 0D              1412 	addc	a,(__czas + 1)
   4592 F5 0D              1413 	mov	(__czas + 1),a
   4594                    1414 00107$:
   4594 22                 1415 	ret
                           1416 ;------------------------------------------------------------
                           1417 ;Allocation info for local variables in function 'main'
                           1418 ;------------------------------------------------------------
                           1419 ;c                         Allocated to registers 
                           1420 ;------------------------------------------------------------
                           1421 ;Z:\pn\projekt\under.c:218: void main(void) {
                           1422 ;	-----------------------------------------
                           1423 ;	 function main
                           1424 ;	-----------------------------------------
   4595                    1425 _main:
                           1426 ;Z:\pn\projekt\under.c:220: lcd_init();
                           1427 ;     genCall
   4595 12 40 C5           1428 	lcall	_lcd_init
                           1429 ;Z:\pn\projekt\under.c:221: czekaj(100);
                           1430 ;     genCall
                           1431 ;       Peephole 182   used 16 bit load of dptr
   4598 90 00 64           1432 	mov  dptr,#(((0x00)<<8) + 0x64)
   459B 12 40 99           1433 	lcall	_czekaj
                           1434 ;Z:\pn\projekt\under.c:222: lcd_clear();
                           1435 ;     genCall
   459E 12 41 8F           1436 	lcall	_lcd_clear
                           1437 ;Z:\pn\projekt\under.c:224: czekaj(100);
                           1438 ;     genCall
                           1439 ;       Peephole 182   used 16 bit load of dptr
   45A1 90 00 64           1440 	mov  dptr,#(((0x00)<<8) + 0x64)
   45A4 12 40 99           1441 	lcall	_czekaj
                           1442 ;Z:\pn\projekt\under.c:225: lcd_clear();
                           1443 ;     genCall
   45A7 12 41 8F           1444 	lcall	_lcd_clear
                           1445 ;Z:\pn\projekt\under.c:226: czekaj(500);
                           1446 ;     genCall
                           1447 ;       Peephole 182   used 16 bit load of dptr
   45AA 90 01 F4           1448 	mov  dptr,#(((0x01)<<8) + 0xF4)
   45AD 12 40 99           1449 	lcall	_czekaj
                           1450 ;Z:\pn\projekt\under.c:227: _godzina = 14;
                           1451 ;     genAssign
   45B0 E4                 1452 	clr	a
   45B1 F5 09              1453 	mov	(__godzina + 1),a
   45B3 75 08 0E           1454 	mov	__godzina,#0x0E
                           1455 ;Z:\pn\projekt\under.c:228: _minuta = 50;
                           1456 ;     genAssign
   45B6 E4                 1457 	clr	a
   45B7 F5 0B              1458 	mov	(__minuta + 1),a
   45B9 75 0A 32           1459 	mov	__minuta,#0x32
                           1460 ;Z:\pn\projekt\under.c:231: for(c = 0; c < 4; c++) {
   45BC                    1461 00117$:
                           1462 ;     genAssign
   45BC 7A 00              1463 	mov	r2,#0x00
   45BE 7B 00              1464 	mov	r3,#0x00
   45C0                    1465 00108$:
                           1466 ;     genCmpLt
                           1467 ;     genCmp
   45C0 C3                 1468 	clr	c
   45C1 EA                 1469 	mov	a,r2
   45C2 94 04              1470 	subb	a,#0x04
   45C4 EB                 1471 	mov	a,r3
   45C5 64 80              1472 	xrl	a,#0x80
   45C7 94 80              1473 	subb	a,#0x80
                           1474 ;     genIfx
                           1475 ;     genIfxJump
                           1476 ;       Peephole 129   jump optimization
   45C9 40 03              1477 	jc   00119$
   45CB 02 46 2E           1478 	ljmp	00111$
   45CE                    1479 00119$:
                           1480 ;Z:\pn\projekt\under.c:232: U15 = klaw[c];
                           1481 ;    genLeftShift
                           1482 ;     genLeftShiftLiteral
                           1483 ;     genlshTwo
   45CE 8A 04              1484 	mov	ar4,r2
   45D0 EB                 1485 	mov	a,r3
   45D1 CC                 1486 	xch	a,r4
   45D2 25 E0              1487 	add	a,acc
   45D4 CC                 1488 	xch	a,r4
   45D5 33                 1489 	rlc	a
   45D6 FD                 1490 	mov	r5,a
                           1491 ;     genPlus
                           1492 ;       Peephole 236g
   45D7 EC                 1493 	mov  a,r4
   45D8 24 3B              1494 	add	a,#_klaw
   45DA F5 82              1495 	mov	dpl,a
                           1496 ;       Peephole 236g
   45DC ED                 1497 	mov  a,r5
   45DD 34 46              1498 	addc	a,#(_klaw >> 8)
   45DF F5 83              1499 	mov	dph,a
                           1500 ;     genPointerGet
                           1501 ;     genCodePointerGet
   45E1 E4                 1502 	clr	a
   45E2 93                 1503 	movc	a,@a+dptr
   45E3 FC                 1504 	mov	r4,a
   45E4 A3                 1505 	inc	dptr
   45E5 E4                 1506 	clr	a
   45E6 93                 1507 	movc	a,@a+dptr
   45E7 FD                 1508 	mov	r5,a
                           1509 ;     genCast
   45E8 90 80 00           1510 	mov	dptr,#_U15
   45EB EC                 1511 	mov	a,r4
   45EC F0                 1512 	movx	@dptr,a
                           1513 ;Z:\pn\projekt\under.c:234: if((U12 & 0x10) == 0)
                           1514 ;     genAssign
   45ED 90 80 00           1515 	mov	dptr,#_U12
   45F0 E0                 1516 	movx	a,@dptr
   45F1 FC                 1517 	mov	r4,a
                           1518 ;     genAnd
   45F2 53 04 10           1519 	anl	ar4,#0x10
                           1520 ;     genCmpEq
                           1521 ;       Peephole 132   changed ljmp to sjmp
                           1522 ;       Peephole 199   optimized misc jump sequence
   45F5 BC 00 0F           1523 	cjne r4,#0x00,00102$
                           1524 ;00120$:
                           1525 ;       Peephole 200   removed redundant sjmp
   45F8                    1526 00121$:
                           1527 ;Z:\pn\projekt\under.c:235: strefa(c);
                           1528 ;     genCall
   45F8 8A 82              1529 	mov	dpl,r2
   45FA 8B 83              1530 	mov	dph,r3
   45FC C0 02              1531 	push	ar2
   45FE C0 03              1532 	push	ar3
   4600 12 43 F3           1533 	lcall	_strefa
   4603 D0 03              1534 	pop	ar3
   4605 D0 02              1535 	pop	ar2
   4607                    1536 00102$:
                           1537 ;Z:\pn\projekt\under.c:236: if((U12 & 0x20) == 0)
                           1538 ;     genAssign
   4607 90 80 00           1539 	mov	dptr,#_U12
   460A E0                 1540 	movx	a,@dptr
   460B FC                 1541 	mov	r4,a
                           1542 ;     genAnd
   460C 53 04 20           1543 	anl	ar4,#0x20
                           1544 ;     genCmpEq
                           1545 ;       Peephole 132   changed ljmp to sjmp
                           1546 ;       Peephole 199   optimized misc jump sequence
   460F BC 00 14           1547 	cjne r4,#0x00,00110$
                           1548 ;00122$:
                           1549 ;       Peephole 200   removed redundant sjmp
   4612                    1550 00123$:
                           1551 ;Z:\pn\projekt\under.c:237: strefa(c+4);
                           1552 ;     genPlus
                           1553 ;     genPlusIncr
   4612 74 04              1554 	mov	a,#0x04
                           1555 ;       Peephole 236a
   4614 2A                 1556 	add  a,r2
   4615 F5 82              1557 	mov	dpl,a
                           1558 ;       Peephole 180   changed mov to clr
   4617 E4                 1559 	clr  a
                           1560 ;       Peephole 236b
   4618 3B                 1561 	addc  a,r3
   4619 F5 83              1562 	mov	dph,a
                           1563 ;     genCall
   461B C0 02              1564 	push	ar2
   461D C0 03              1565 	push	ar3
   461F 12 43 F3           1566 	lcall	_strefa
   4622 D0 03              1567 	pop	ar3
   4624 D0 02              1568 	pop	ar2
   4626                    1569 00110$:
                           1570 ;Z:\pn\projekt\under.c:231: for(c = 0; c < 4; c++) {
                           1571 ;     genPlus
                           1572 ;     genPlusIncr
   4626 0A                 1573 	inc	r2
   4627 BA 00 01           1574 	cjne	r2,#0x00,00124$
   462A 0B                 1575 	inc	r3
   462B                    1576 00124$:
   462B 02 45 C0           1577 	ljmp	00108$
   462E                    1578 00111$:
                           1579 ;Z:\pn\projekt\under.c:239: czekaj(10);
                           1580 ;     genCall
                           1581 ;       Peephole 182   used 16 bit load of dptr
   462E 90 00 0A           1582 	mov  dptr,#(((0x00)<<8) + 0x0A)
   4631 12 40 99           1583 	lcall	_czekaj
                           1584 ;Z:\pn\projekt\under.c:240: czas();
                           1585 ;     genCall
   4634 12 45 32           1586 	lcall	_czas
   4637 02 45 BC           1587 	ljmp	00117$
   463A                    1588 00112$:
   463A 22                 1589 	ret
                           1590 	.area CSEG    (CODE)
   463B                    1591 _klaw:
   463B FE 00              1592 	.byte #0xFE,#0x00
   463D FD 00              1593 	.byte #0xFD,#0x00
   463F FB 00              1594 	.byte #0xFB,#0x00
   4641 F7 00              1595 	.byte #0xF7,#0x00
   4643                    1596 __str_0:
   4643 20 3A 20           1597 	.ascii " : "
   4646 00                 1598 	.db 0x00
   4647                    1599 __str_1:
   4647 57 61 72 73 7A 61  1600 	.ascii "Warszawa"
        77 61
   464F 00                 1601 	.db 0x00
   4650                    1602 __str_2:
   4650 4D 6F 73 6B 77 61  1603 	.ascii "Moskwa"
   4656 00                 1604 	.db 0x00
   4657                    1605 __str_3:
   4657 54 6F 6B 69 6F     1606 	.ascii "Tokio"
   465C 00                 1607 	.db 0x00
   465D                    1608 __str_4:
   465D 4C 6F 6E 64 79 6E  1609 	.ascii "Londyn"
   4663 00                 1610 	.db 0x00
   4664                    1611 __str_5:
   4664 43 68 69 63 61 67  1612 	.ascii "Chicago"
        6F
   466B 00                 1613 	.db 0x00
   466C                    1614 __str_6:
   466C 4B 69 6A 6F 77     1615 	.ascii "Kijow"
   4671 00                 1616 	.db 0x00
   4672                    1617 __str_7:
   4672 50 65 6B 69 6E     1618 	.ascii "Pekin"
   4677 00                 1619 	.db 0x00
   4678                    1620 __str_8:
   4678 42 61 67 64 61 64  1621 	.ascii "Bagdad"
   467E 00                 1622 	.db 0x00
                           1623 	.area XINIT   (CODE)
