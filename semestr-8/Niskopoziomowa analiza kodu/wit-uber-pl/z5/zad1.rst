                              1 ;--------------------------------------------------------
                              2 ; File Created by SDCC : FreeWare ANSI-C Compiler
                              3 ; Version 2.3.3 Tue May 17 12:43:17 2011
                              4 
                              5 ;--------------------------------------------------------
                              6 	.module zad1
                              7 	
                              8 ;--------------------------------------------------------
                              9 ; Public variables in this module
                             10 ;--------------------------------------------------------
                             11 	.globl _main
                             12 	.globl _wyswietl_iloczyn
                             13 	.globl _gotoXY
                             14 	.globl _init
                             15 	.globl _czekaj
                             16 	.globl _wyslij_dane
                             17 	.globl _wyslij_polecenie4
                             18 	.globl _wyslij_polecenie8
                             19 	.globl _wyswietl_iloczyn_PARM_2
                             20 	.globl _cyfry
                             21 	.globl _j
                             22 	.globl _i
                             23 	.globl _gotoXY_PARM_2
                             24 	.globl _produkt
                             25 	.globl _RS
                             26 	.globl _E
                             27 ;--------------------------------------------------------
                             28 ; special function registers
                             29 ;--------------------------------------------------------
                    0090     30 _P1	=	0x0090
                             31 ;--------------------------------------------------------
                             32 ; special function bits 
                             33 ;--------------------------------------------------------
                             34 ;--------------------------------------------------------
                             35 ; overlayable register banks 
                             36 ;--------------------------------------------------------
                             37 	.area REG_BANK_0	(REL,OVR,DATA)
   0000                      38 	.ds 8
                             39 ;--------------------------------------------------------
                             40 ; internal ram data
                             41 ;--------------------------------------------------------
                             42 	.area DSEG    (DATA)
   0008                      43 _E::
   0008                      44 	.ds 1
   0009                      45 _RS::
   0009                      46 	.ds 1
   000A                      47 _produkt::
   000A                      48 	.ds 6
   0010                      49 _gotoXY_PARM_2::
   0010                      50 	.ds 1
   0011                      51 _i::
   0011                      52 	.ds 2
   0013                      53 _j::
   0013                      54 	.ds 2
   0015                      55 _cyfry::
   0015                      56 	.ds 2
   0017                      57 _wyswietl_iloczyn_PARM_2::
   0017                      58 	.ds 2
   0019                      59 _wyswietl_iloczyn_iloczyn_1_1::
   0019                      60 	.ds 2
                             61 ;--------------------------------------------------------
                             62 ; overlayable items in internal ram 
                             63 ;--------------------------------------------------------
                             64 	.area	OSEG    (OVR,DATA)
                             65 	.area	OSEG    (OVR,DATA)
                             66 	.area	OSEG    (OVR,DATA)
                             67 	.area	OSEG    (OVR,DATA)
                             68 ;--------------------------------------------------------
                             69 ; Stack segment in internal ram 
                             70 ;--------------------------------------------------------
                             71 	.area	SSEG	(DATA)
   001F                      72 __start__stack:
   001F                      73 	.ds	1
                             74 
                             75 ;--------------------------------------------------------
                             76 ; indirectly addressable internal ram data
                             77 ;--------------------------------------------------------
                             78 	.area ISEG    (DATA)
                             79 ;--------------------------------------------------------
                             80 ; bit data
                             81 ;--------------------------------------------------------
                             82 	.area BSEG    (BIT)
                             83 ;--------------------------------------------------------
                             84 ; external ram data
                             85 ;--------------------------------------------------------
                             86 	.area XSEG    (XDATA)
                             87 ;--------------------------------------------------------
                             88 ; external initialized ram data
                             89 ;--------------------------------------------------------
                             90 	.area XISEG   (XDATA)
                             91 ;--------------------------------------------------------
                             92 ; interrupt vector 
                             93 ;--------------------------------------------------------
                             94 	.area CSEG    (CODE)
   4000                      95 __interrupt_vect:
   4000 02 46 34             96 	ljmp	__sdcc_gsinit_startup
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
   4634                     115 __sdcc_gsinit_startup:
   4634 75 81 1E            116 	mov	sp,#__start__stack - 1
   4637 12 44 A6            117 	lcall	__sdcc_external_startup
   463A E5 82               118 	mov	a,dpl
   463C 60 03               119 	jz	__sdcc_init_data
   463E 02 40 33            120 	ljmp	__sdcc_program_startup
   4641                     121 __sdcc_init_data:
                            122 ;	_mcs51_genXINIT() start
   4641 74 00               123 	mov	a,#l_XINIT
   4643 44 00               124 	orl	a,#l_XINIT>>8
   4645 60 29               125 	jz	00003$
   4647 74 84               126 	mov	a,#s_XINIT
   4649 24 00               127 	add	a,#l_XINIT
   464B F9                  128 	mov	r1,a
   464C 74 46               129 	mov	a,#s_XINIT>>8
   464E 34 00               130 	addc	a,#l_XINIT>>8
   4650 FA                  131 	mov	r2,a
   4651 90 46 84            132 	mov	dptr,#s_XINIT
   4654 78 00               133 	mov	r0,#s_XISEG
   4656 75 A0 00            134 	mov	p2,#(s_XISEG >> 8)
   4659 E4                  135 00001$:	clr	a
   465A 93                  136 	movc	a,@a+dptr
   465B F2                  137 	movx	@r0,a
   465C A3                  138 	inc	dptr
   465D 08                  139 	inc	r0
   465E B8 00 02            140 	cjne	r0,#0,00002$
   4661 05 A0               141 	inc	p2
   4663 E5 82               142 00002$:	mov	a,dpl
   4665 B5 01 F1            143 	cjne	a,ar1,00001$
   4668 E5 83               144 	mov	a,dph
   466A B5 02 EC            145 	cjne	a,ar2,00001$
   466D 75 A0 FF            146 	mov	p2,#0xFF
   4670                     147 00003$:
                            148 ;	_mcs51_genXINIT() end
                            149 ;Z:\pn\z5\zad1.c:2: char E = 0x08;
                            150 ;     genAssign
   4670 75 08 08            151 	mov	_E,#0x08
                            152 ;Z:\pn\z5\zad1.c:3: char RS = 0x04;
                            153 ;     genAssign
   4673 75 09 04            154 	mov	_RS,#0x04
                            155 ;Z:\pn\z5\zad1.c:84: int j = 0;
                            156 ;     genAssign
   4676 E4                  157 	clr	a
   4677 F5 14               158 	mov	(_j + 1),a
   4679 F5 13               159 	mov	_j,a
                            160 ;Z:\pn\z5\zad1.c:85: int cyfry=1;
                            161 ;     genAssign
   467B E4                  162 	clr	a
   467C F5 16               163 	mov	(_cyfry + 1),a
   467E 75 15 01            164 	mov	_cyfry,#0x01
                            165 	.area GSFINAL (CODE)
   4681 02 40 33            166 	ljmp	__sdcc_program_startup
                            167 ;--------------------------------------------------------
                            168 ; Home
                            169 ;--------------------------------------------------------
                            170 	.area HOME    (CODE)
                            171 	.area CSEG    (CODE)
                            172 ;--------------------------------------------------------
                            173 ; code
                            174 ;--------------------------------------------------------
                            175 	.area CSEG    (CODE)
   4033                     176 __sdcc_program_startup:
   4033 12 43 64            177 	lcall	_main
                            178 ;	return from main will lock up
   4036 80 FE               179 	sjmp .
                            180 ;------------------------------------------------------------
                            181 ;Allocation info for local variables in function 'wyslij_polecenie8'
                            182 ;------------------------------------------------------------
                            183 ;------------------------------------------------------------
                            184 ;Z:\pn\z5\zad1.c:7: void wyslij_polecenie8(unsigned char polecenie)
                            185 ;	-----------------------------------------
                            186 ;	 function wyslij_polecenie8
                            187 ;	-----------------------------------------
   4038                     188 _wyslij_polecenie8:
                    0002    189 	ar2 = 0x02
                    0003    190 	ar3 = 0x03
                    0004    191 	ar4 = 0x04
                    0005    192 	ar5 = 0x05
                    0006    193 	ar6 = 0x06
                    0007    194 	ar7 = 0x07
                    0000    195 	ar0 = 0x00
                    0001    196 	ar1 = 0x01
                            197 ;     genReceive
   4038 AA 82               198 	mov	r2,dpl
                            199 ;Z:\pn\z5\zad1.c:9: P1=polecenie;
                            200 ;     genAssign
   403A 8A 90               201 	mov	_P1,r2
                            202 ;Z:\pn\z5\zad1.c:10: P1=polecenie | E; //gdzie E – jest mask¹ bitow¹ "ustawiaj¹c¹" liniê E – nale¿y j¹
                            203 ;     genAssign
   403C AB 08               204 	mov	r3,_E
                            205 ;     genOr
   403E EB                  206 	mov	a,r3
   403F 4A                  207 	orl	a,r2
   4040 F5 90               208 	mov	_P1,a
                            209 ;Z:\pn\z5\zad1.c:15: P1=polecenie & !E; //gdzie !E – jest zanegowana maska bitowa, zeruj¹c¹ linie E –
                            210 ;     genNot
   4042 E5 08               211 	mov	a,_E
   4044 B4 01 00            212 	cjne	a,#0x01,00103$
   4047                     213 00103$:
   4047 E4                  214 	clr	a
   4048 33                  215 	rlc	a
                            216 ;     genAnd
                            217 ;       Peephole 105   removed redundant mov
   4049 FB                  218 	mov  r3,a
   404A 5A                  219 	anl	a,r2
   404B F5 90               220 	mov	_P1,a
   404D                     221 00101$:
   404D 22                  222 	ret
                            223 ;------------------------------------------------------------
                            224 ;Allocation info for local variables in function 'wyslij_polecenie4'
                            225 ;------------------------------------------------------------
                            226 ;------------------------------------------------------------
                            227 ;Z:\pn\z5\zad1.c:19: void wyslij_polecenie4(unsigned char polecenie)
                            228 ;	-----------------------------------------
                            229 ;	 function wyslij_polecenie4
                            230 ;	-----------------------------------------
   404E                     231 _wyslij_polecenie4:
                            232 ;     genReceive
   404E AA 82               233 	mov	r2,dpl
                            234 ;Z:\pn\z5\zad1.c:21: P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
                            235 ;     genAnd
   4050 74 F0               236 	mov	a,#0xF0
   4052 5A                  237 	anl	a,r2
   4053 FB                  238 	mov	r3,a
                            239 ;     genAssign
   4054 8B 90               240 	mov	_P1,r3
                            241 ;Z:\pn\z5\zad1.c:22: P1=(polecenie & 0xf0) | E; //sygna³ „strob”
                            242 ;     genAssign
   4056 AC 08               243 	mov	r4,_E
                            244 ;     genOr
   4058 EC                  245 	mov	a,r4
   4059 4B                  246 	orl	a,r3
   405A F5 90               247 	mov	_P1,a
                            248 ;Z:\pn\z5\zad1.c:23: P1=(polecenie & 0xf0) & !E;
                            249 ;     genNot
   405C E5 08               250 	mov	a,_E
   405E B4 01 00            251 	cjne	a,#0x01,00103$
   4061                     252 00103$:
   4061 E4                  253 	clr	a
   4062 33                  254 	rlc	a
                            255 ;     genAnd
                            256 ;       Peephole 105   removed redundant mov
   4063 FC                  257 	mov  r4,a
   4064 5B                  258 	anl	a,r3
   4065 F5 90               259 	mov	_P1,a
                            260 ;Z:\pn\z5\zad1.c:24: P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
                            261 ;    genLeftShift
                            262 ;     genLeftShiftLiteral
                            263 ;     genlshOne
   4067 EA                  264 	mov	a,r2
   4068 C4                  265 	swap	a
   4069 54 F0               266 	anl	a,#0xf0
   406B FA                  267 	mov	r2,a
                            268 ;     genAnd
   406C 53 02 F0            269 	anl	ar2,#0xF0
                            270 ;     genAssign
   406F 8A 90               271 	mov	_P1,r2
                            272 ;Z:\pn\z5\zad1.c:25: P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
                            273 ;     genAssign
   4071 AB 08               274 	mov	r3,_E
                            275 ;     genOr
   4073 EB                  276 	mov	a,r3
   4074 4A                  277 	orl	a,r2
   4075 F5 90               278 	mov	_P1,a
                            279 ;Z:\pn\z5\zad1.c:26: P1=((polecenie << 4) & 0xf0) & !E;
                            280 ;     genAnd
   4077 EC                  281 	mov	a,r4
   4078 5A                  282 	anl	a,r2
   4079 F5 90               283 	mov	_P1,a
   407B                     284 00101$:
   407B 22                  285 	ret
                            286 ;------------------------------------------------------------
                            287 ;Allocation info for local variables in function 'wyslij_dane'
                            288 ;------------------------------------------------------------
                            289 ;------------------------------------------------------------
                            290 ;Z:\pn\z5\zad1.c:29: void wyslij_dane(unsigned char dana)
                            291 ;	-----------------------------------------
                            292 ;	 function wyslij_dane
                            293 ;	-----------------------------------------
   407C                     294 _wyslij_dane:
                            295 ;     genReceive
   407C AA 82               296 	mov	r2,dpl
                            297 ;Z:\pn\z5\zad1.c:31: P1=(dana & 0xf0) | RS;
                            298 ;     genAnd
   407E 74 F0               299 	mov	a,#0xF0
   4080 5A                  300 	anl	a,r2
   4081 FB                  301 	mov	r3,a
                            302 ;     genAssign
   4082 AC 09               303 	mov	r4,_RS
                            304 ;     genOr
   4084 EC                  305 	mov	a,r4
   4085 4B                  306 	orl	a,r3
   4086 F5 90               307 	mov	_P1,a
                            308 ;Z:\pn\z5\zad1.c:32: P1=((dana & 0xf0) | E) | RS;
                            309 ;     genAssign
   4088 AC 08               310 	mov	r4,_E
                            311 ;     genOr
   408A EB                  312 	mov	a,r3
   408B 42 04               313 	orl	ar4,a
                            314 ;     genAssign
   408D AD 09               315 	mov	r5,_RS
                            316 ;     genOr
   408F ED                  317 	mov	a,r5
   4090 4C                  318 	orl	a,r4
   4091 F5 90               319 	mov	_P1,a
                            320 ;Z:\pn\z5\zad1.c:33: P1=((dana & 0xf0) & !E) | RS;
                            321 ;     genNot
   4093 E5 08               322 	mov	a,_E
   4095 B4 01 00            323 	cjne	a,#0x01,00103$
   4098                     324 00103$:
   4098 E4                  325 	clr	a
   4099 33                  326 	rlc	a
                            327 ;     genAnd
                            328 ;       Peephole 105   removed redundant mov
   409A FC                  329 	mov  r4,a
   409B 52 03               330 	anl	ar3,a
                            331 ;     genAssign
   409D AD 09               332 	mov	r5,_RS
                            333 ;     genOr
   409F ED                  334 	mov	a,r5
   40A0 4B                  335 	orl	a,r3
   40A1 F5 90               336 	mov	_P1,a
                            337 ;Z:\pn\z5\zad1.c:34: P1=((dana << 4) & 0xf0) | RS;
                            338 ;    genLeftShift
                            339 ;     genLeftShiftLiteral
                            340 ;     genlshOne
   40A3 EA                  341 	mov	a,r2
   40A4 C4                  342 	swap	a
   40A5 54 F0               343 	anl	a,#0xf0
   40A7 FA                  344 	mov	r2,a
                            345 ;     genAnd
   40A8 53 02 F0            346 	anl	ar2,#0xF0
                            347 ;     genAssign
   40AB AB 09               348 	mov	r3,_RS
                            349 ;     genOr
   40AD EB                  350 	mov	a,r3
   40AE 4A                  351 	orl	a,r2
   40AF F5 90               352 	mov	_P1,a
                            353 ;Z:\pn\z5\zad1.c:35: P1=(((dana << 4) & 0xf0) | E) | RS;
                            354 ;     genAssign
   40B1 AB 08               355 	mov	r3,_E
                            356 ;     genOr
   40B3 EA                  357 	mov	a,r2
   40B4 42 03               358 	orl	ar3,a
                            359 ;     genAssign
   40B6 AD 09               360 	mov	r5,_RS
                            361 ;     genOr
   40B8 ED                  362 	mov	a,r5
   40B9 4B                  363 	orl	a,r3
   40BA F5 90               364 	mov	_P1,a
                            365 ;Z:\pn\z5\zad1.c:36: P1=(((dana << 4) & 0xf0) & !E) | RS;
                            366 ;     genAnd
   40BC EA                  367 	mov	a,r2
   40BD 52 04               368 	anl	ar4,a
                            369 ;     genAssign
   40BF AA 09               370 	mov	r2,_RS
                            371 ;     genOr
   40C1 EA                  372 	mov	a,r2
   40C2 4C                  373 	orl	a,r4
   40C3 F5 90               374 	mov	_P1,a
   40C5                     375 00101$:
   40C5 22                  376 	ret
                            377 ;------------------------------------------------------------
                            378 ;Allocation info for local variables in function 'czekaj'
                            379 ;------------------------------------------------------------
                            380 ;------------------------------------------------------------
                            381 ;Z:\pn\z5\zad1.c:39: void czekaj(int d){
                            382 ;	-----------------------------------------
                            383 ;	 function czekaj
                            384 ;	-----------------------------------------
   40C6                     385 _czekaj:
                            386 ;     genReceive
   40C6 AA 82               387 	mov	r2,dpl
   40C8 AB 83               388 	mov	r3,dph
                            389 ;Z:\pn\z5\zad1.c:41: for(i=0; i<d; i++){
                            390 ;     genAssign
   40CA 7C 00               391 	mov	r4,#0x00
   40CC 7D 00               392 	mov	r5,#0x00
   40CE                     393 00101$:
                            394 ;     genCmpLt
                            395 ;     genCmp
   40CE C3                  396 	clr	c
   40CF EC                  397 	mov	a,r4
   40D0 9A                  398 	subb	a,r2
   40D1 ED                  399 	mov	a,r5
   40D2 64 80               400 	xrl	a,#0x80
   40D4 8B F0               401 	mov	b,r3
   40D6 63 F0 80            402 	xrl	b,#0x80
   40D9 95 F0               403 	subb	a,b
                            404 ;     genIfxJump
                            405 ;       Peephole 108   removed ljmp by inverse jump logic
   40DB 50 08               406 	jnc  00105$
   40DD                     407 00109$:
                            408 ;Z:\pn\z5\zad1.c:44: _endasm;
                            409 ;     genInline
   40DD 00                  410 	                nop
                            411 ;Z:\pn\z5\zad1.c:41: for(i=0; i<d; i++){
                            412 ;     genPlus
                            413 ;     genPlusIncr
                            414 ;	tail increment optimized
   40DE 0C                  415 	inc	r4
   40DF BC 00 EC            416 	cjne	r4,#0x00,00101$
   40E2 0D                  417 	inc	r5
                            418 ;       Peephole 132   changed ljmp to sjmp
   40E3 80 E9               419 	sjmp 00101$
   40E5                     420 00105$:
   40E5 22                  421 	ret
                            422 ;------------------------------------------------------------
                            423 ;Allocation info for local variables in function 'init'
                            424 ;------------------------------------------------------------
                            425 ;------------------------------------------------------------
                            426 ;Z:\pn\z5\zad1.c:48: void init()
                            427 ;	-----------------------------------------
                            428 ;	 function init
                            429 ;	-----------------------------------------
   40E6                     430 _init:
                            431 ;Z:\pn\z5\zad1.c:50: wyslij_polecenie8(0x30); //3
                            432 ;     genCall
   40E6 75 82 30            433 	mov	dpl,#0x30
   40E9 12 40 38            434 	lcall	_wyslij_polecenie8
                            435 ;Z:\pn\z5\zad1.c:51: czekaj(100);
                            436 ;     genCall
                            437 ;       Peephole 182   used 16 bit load of dptr
   40EC 90 00 64            438 	mov  dptr,#(((0x00)<<8) + 0x64)
   40EF 12 40 C6            439 	lcall	_czekaj
                            440 ;Z:\pn\z5\zad1.c:52: wyslij_polecenie8(0x30); //5
                            441 ;     genCall
   40F2 75 82 30            442 	mov	dpl,#0x30
   40F5 12 40 38            443 	lcall	_wyslij_polecenie8
                            444 ;Z:\pn\z5\zad1.c:53: czekaj(100);
                            445 ;     genCall
                            446 ;       Peephole 182   used 16 bit load of dptr
   40F8 90 00 64            447 	mov  dptr,#(((0x00)<<8) + 0x64)
   40FB 12 40 C6            448 	lcall	_czekaj
                            449 ;Z:\pn\z5\zad1.c:54: wyslij_polecenie8(0x30); //7
                            450 ;     genCall
   40FE 75 82 30            451 	mov	dpl,#0x30
   4101 12 40 38            452 	lcall	_wyslij_polecenie8
                            453 ;Z:\pn\z5\zad1.c:55: czekaj(100);
                            454 ;     genCall
                            455 ;       Peephole 182   used 16 bit load of dptr
   4104 90 00 64            456 	mov  dptr,#(((0x00)<<8) + 0x64)
   4107 12 40 C6            457 	lcall	_czekaj
                            458 ;Z:\pn\z5\zad1.c:56: wyslij_polecenie8(0x20); //9
                            459 ;     genCall
   410A 75 82 20            460 	mov	dpl,#0x20
   410D 12 40 38            461 	lcall	_wyslij_polecenie8
                            462 ;Z:\pn\z5\zad1.c:57: czekaj(100);
                            463 ;     genCall
                            464 ;       Peephole 182   used 16 bit load of dptr
   4110 90 00 64            465 	mov  dptr,#(((0x00)<<8) + 0x64)
   4113 12 40 C6            466 	lcall	_czekaj
                            467 ;Z:\pn\z5\zad1.c:58: wyslij_polecenie4(0x2F); //11
                            468 ;     genCall
   4116 75 82 2F            469 	mov	dpl,#0x2F
   4119 12 40 4E            470 	lcall	_wyslij_polecenie4
                            471 ;Z:\pn\z5\zad1.c:59: czekaj(100);
                            472 ;     genCall
                            473 ;       Peephole 182   used 16 bit load of dptr
   411C 90 00 64            474 	mov  dptr,#(((0x00)<<8) + 0x64)
   411F 12 40 C6            475 	lcall	_czekaj
                            476 ;Z:\pn\z5\zad1.c:60: wyslij_polecenie4(0x08); //13
                            477 ;     genCall
   4122 75 82 08            478 	mov	dpl,#0x08
   4125 12 40 4E            479 	lcall	_wyslij_polecenie4
                            480 ;Z:\pn\z5\zad1.c:61: czekaj(100);
                            481 ;     genCall
                            482 ;       Peephole 182   used 16 bit load of dptr
   4128 90 00 64            483 	mov  dptr,#(((0x00)<<8) + 0x64)
   412B 12 40 C6            484 	lcall	_czekaj
                            485 ;Z:\pn\z5\zad1.c:62: wyslij_polecenie4(0x0E); //15
                            486 ;     genCall
   412E 75 82 0E            487 	mov	dpl,#0x0E
   4131 12 40 4E            488 	lcall	_wyslij_polecenie4
                            489 ;Z:\pn\z5\zad1.c:63: czekaj(100);
                            490 ;     genCall
                            491 ;       Peephole 182   used 16 bit load of dptr
   4134 90 00 64            492 	mov  dptr,#(((0x00)<<8) + 0x64)
   4137 12 40 C6            493 	lcall	_czekaj
                            494 ;Z:\pn\z5\zad1.c:64: wyslij_polecenie4(0x06); //17
                            495 ;     genCall
   413A 75 82 06            496 	mov	dpl,#0x06
   413D 12 40 4E            497 	lcall	_wyslij_polecenie4
                            498 ;Z:\pn\z5\zad1.c:65: czekaj(100);
                            499 ;     genCall
                            500 ;       Peephole 182   used 16 bit load of dptr
   4140 90 00 64            501 	mov  dptr,#(((0x00)<<8) + 0x64)
   4143 12 40 C6            502 	lcall	_czekaj
   4146                     503 00101$:
   4146 22                  504 	ret
                            505 ;------------------------------------------------------------
                            506 ;Allocation info for local variables in function 'gotoXY'
                            507 ;------------------------------------------------------------
                            508 ;y                         Allocated to in memory with name '_gotoXY_PARM_2'
                            509 ;x                         Allocated to registers r2 
                            510 ;i                         Allocated to registers r3 
                            511 ;------------------------------------------------------------
                            512 ;Z:\pn\z5\zad1.c:68: void gotoXY(unsigned char x, unsigned char y)
                            513 ;	-----------------------------------------
                            514 ;	 function gotoXY
                            515 ;	-----------------------------------------
   4147                     516 _gotoXY:
                            517 ;     genReceive
   4147 AA 82               518 	mov	r2,dpl
                            519 ;Z:\pn\z5\zad1.c:71: if(y==0)
                            520 ;     genCmpEq
   4149 E5 10               521 	mov	a,_gotoXY_PARM_2
                            522 ;       Peephole 162   removed sjmp by inverse jump logic
   414B 60 02               523 	jz   00108$
   414D                     524 00107$:
                            525 ;       Peephole 132   changed ljmp to sjmp
   414D 80 04               526 	sjmp 00102$
   414F                     527 00108$:
                            528 ;Z:\pn\z5\zad1.c:73: i = 128;
                            529 ;     genAssign
   414F 7B 80               530 	mov	r3,#0x80
                            531 ;       Peephole 132   changed ljmp to sjmp
   4151 80 02               532 	sjmp 00103$
   4153                     533 00102$:
                            534 ;Z:\pn\z5\zad1.c:77: i = 192;
                            535 ;     genAssign
   4153 7B C0               536 	mov	r3,#0xC0
   4155                     537 00103$:
                            538 ;Z:\pn\z5\zad1.c:79: i |= x;
                            539 ;     genOr
   4155 EA                  540 	mov	a,r2
   4156 42 03               541 	orl	ar3,a
                            542 ;Z:\pn\z5\zad1.c:80: wyslij_polecenie4(i);
                            543 ;     genCall
   4158 8B 82               544 	mov	dpl,r3
   415A 12 40 4E            545 	lcall	_wyslij_polecenie4
   415D                     546 00104$:
   415D 22                  547 	ret
                            548 ;------------------------------------------------------------
                            549 ;Allocation info for local variables in function 'wyswietl_iloczyn'
                            550 ;------------------------------------------------------------
                            551 ;y                         Allocated to in memory with name '_wyswietl_iloczyn_PARM_2'
                            552 ;x                         Allocated to registers r2 r3 
                            553 ;iloczyn                   Allocated to in memory with name '_wyswietl_iloczyn_iloczyn_1_1'
                            554 ;------------------------------------------------------------
                            555 ;Z:\pn\z5\zad1.c:87: void wyswietl_iloczyn(int x, int y)
                            556 ;	-----------------------------------------
                            557 ;	 function wyswietl_iloczyn
                            558 ;	-----------------------------------------
   415E                     559 _wyswietl_iloczyn:
                            560 ;     genReceive
                            561 ;Z:\pn\z5\zad1.c:89: int iloczyn = x * y;
                            562 ;     genAssign
                            563 ;     genCall
   415E AA 82               564 	mov     r2,dpl
   4160 AB 83               565 	mov     r3,dph
   4162 85 17 1B            566 	mov     __mulsint_PARM_2,_wyswietl_iloczyn_PARM_2
   4165 85 18 1C            567 	mov     (__mulsint_PARM_2 + 1),(_wyswietl_iloczyn_PARM_2 + 1)
                            568 ;       Peephole 238c  removed 2 redundant moves
   4168 12 44 89            569 	lcall	__mulsint
   416B E5 82               570 	mov	a,dpl
   416D 85 83 F0            571 	mov	b,dph
                            572 ;     genAssign
   4170 F5 19               573 	mov	_wyswietl_iloczyn_iloczyn_1_1,a
   4172 85 F0 1A            574 	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
                            575 ;Z:\pn\z5\zad1.c:91: for (i = 0; i<6; i++)
                            576 ;     genAssign
   4175 E4                  577 	clr	a
   4176 F5 12               578 	mov	(_i + 1),a
   4178 F5 11               579 	mov	_i,a
   417A                     580 00103$:
                            581 ;     genCmpLt
                            582 ;     genCmp
   417A C3                  583 	clr	c
   417B E5 11               584 	mov	a,_i
   417D 94 06               585 	subb	a,#0x06
   417F E5 12               586 	mov	a,(_i + 1)
   4181 64 80               587 	xrl	a,#0x80
   4183 94 80               588 	subb	a,#0x80
                            589 ;     genIfxJump
                            590 ;       Peephole 108   removed ljmp by inverse jump logic
   4185 50 15               591 	jnc  00106$
   4187                     592 00123$:
                            593 ;Z:\pn\z5\zad1.c:92: produkt[i] = 0;
                            594 ;     genPlus
   4187 E5 11               595 	mov	a,_i
   4189 24 0A               596 	add	a,#_produkt
                            597 ;     genPointerSet
                            598 ;     genNearPointerSet
   418B A8 E0               599 	mov	r0,acc
   418D 76 00               600 	mov	@r0,#0x00
                            601 ;Z:\pn\z5\zad1.c:91: for (i = 0; i<6; i++)
                            602 ;     genPlus
                            603 ;     genPlusIncr
   418F 74 01               604 	mov	a,#0x01
   4191 25 11               605 	add	a,_i
   4193 F5 11               606 	mov	_i,a
                            607 ;       Peephole 180   changed mov to clr
   4195 E4                  608 	clr  a
   4196 35 12               609 	addc	a,(_i + 1)
   4198 F5 12               610 	mov	(_i + 1),a
                            611 ;       Peephole 132   changed ljmp to sjmp
   419A 80 DE               612 	sjmp 00103$
   419C                     613 00106$:
                            614 ;Z:\pn\z5\zad1.c:95: for (i = 0; i<6; i++)
                            615 ;     genAssign
   419C E4                  616 	clr	a
   419D F5 12               617 	mov	(_i + 1),a
   419F 75 11 06            618 	mov	_i,#0x06
   41A2                     619 00109$:
                            620 ;Z:\pn\z5\zad1.c:97: if ( iloczyn > cyfry)
                            621 ;     genCmpGt
                            622 ;     genCmp
   41A2 C3                  623 	clr	c
   41A3 E5 15               624 	mov	a,_cyfry
   41A5 95 19               625 	subb	a,_wyswietl_iloczyn_iloczyn_1_1
   41A7 E5 16               626 	mov	a,(_cyfry + 1)
   41A9 64 80               627 	xrl	a,#0x80
   41AB 85 1A F0            628 	mov	b,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   41AE 63 F0 80            629 	xrl	b,#0x80
   41B1 95 F0               630 	subb	a,b
                            631 ;     genIfxJump
                            632 ;       Peephole 108   removed ljmp by inverse jump logic
   41B3 50 24               633 	jnc  00102$
   41B5                     634 00124$:
                            635 ;Z:\pn\z5\zad1.c:99: j++;
                            636 ;     genPlus
                            637 ;     genPlusIncr
   41B5 74 01               638 	mov	a,#0x01
   41B7 25 13               639 	add	a,_j
   41B9 F5 13               640 	mov	_j,a
                            641 ;       Peephole 180   changed mov to clr
   41BB E4                  642 	clr  a
   41BC 35 14               643 	addc	a,(_j + 1)
   41BE F5 14               644 	mov	(_j + 1),a
                            645 ;Z:\pn\z5\zad1.c:100: cyfry = cyfry * 10;
                            646 ;     genAssign
   41C0 E4                  647 	clr	a
   41C1 F5 1C               648 	mov	(__mulsint_PARM_2 + 1),a
   41C3 75 1B 0A            649 	mov	__mulsint_PARM_2,#0x0A
                            650 ;     genCall
   41C6 85 15 82            651 	mov	dpl,_cyfry
   41C9 85 16 83            652 	mov	dph,(_cyfry + 1)
   41CC 12 44 89            653 	lcall	__mulsint
   41CF E5 82               654 	mov	a,dpl
   41D1 85 83 F0            655 	mov	b,dph
                            656 ;     genAssign
   41D4 F5 15               657 	mov	_cyfry,a
   41D6 85 F0 16            658 	mov	(_cyfry + 1),b
   41D9                     659 00102$:
                            660 ;     genMinus
                            661 ;     genMinusDec
   41D9 E5 11               662 	mov	a,_i
   41DB 24 FF               663 	add	a,#0xff
   41DD F5 11               664 	mov	_i,a
   41DF E5 12               665 	mov	a,(_i + 1)
   41E1 34 FF               666 	addc	a,#0xff
   41E3 F5 12               667 	mov	(_i + 1),a
                            668 ;Z:\pn\z5\zad1.c:95: for (i = 0; i<6; i++)
                            669 ;     genIfx
   41E5 E5 11               670 	mov	a,_i
   41E7 45 12               671 	orl	a,(_i + 1)
                            672 ;     genIfxJump
                            673 ;       Peephole 109   removed ljmp by inverse jump logic
   41E9 70 B7               674 	jnz  00109$
   41EB                     675 00125$:
                            676 ;Z:\pn\z5\zad1.c:111: produkt[5] = '0' + (iloczyn / 100000);
                            677 ;     genCast
   41EB AC 19               678 	mov	r4,_wyswietl_iloczyn_iloczyn_1_1
   41ED AD 1A               679 	mov	r5,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   41EF E5 1A               680 	mov	a,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   41F1 33                  681 	rlc	a
   41F2 95 E0               682 	subb	a,acc
   41F4 FE                  683 	mov	r6,a
   41F5 FF                  684 	mov	r7,a
                            685 ;     genAssign
   41F6 75 1B A0            686 	mov	__divslong_PARM_2,#0xA0
   41F9 75 1C 86            687 	mov	(__divslong_PARM_2 + 1),#0x86
   41FC 75 1D 01            688 	mov	(__divslong_PARM_2 + 2),#0x01
   41FF 75 1E 00            689 	mov	(__divslong_PARM_2 + 3),#0x00
                            690 ;     genCall
   4202 8C 82               691 	mov	dpl,r4
   4204 8D 83               692 	mov	dph,r5
   4206 8E F0               693 	mov	b,r6
   4208 EF                  694 	mov	a,r7
   4209 C0 04               695 	push	ar4
   420B C0 05               696 	push	ar5
   420D C0 06               697 	push	ar6
   420F C0 07               698 	push	ar7
   4211 12 45 71            699 	lcall	__divslong
   4214 A8 82               700 	mov	r0,dpl
   4216 A9 83               701 	mov	r1,dph
   4218 AA F0               702 	mov	r2,b
   421A FB                  703 	mov	r3,a
   421B D0 07               704 	pop	ar7
   421D D0 06               705 	pop	ar6
   421F D0 05               706 	pop	ar5
   4221 D0 04               707 	pop	ar4
                            708 ;     genPlus
   4223 74 30               709 	mov	a,#0x30
                            710 ;       Peephole 236a
   4225 28                  711 	add  a,r0
   4226 F8                  712 	mov	r0,a
                            713 ;       Peephole 180   changed mov to clr
   4227 E4                  714 	clr  a
                            715 ;       Peephole 236b
   4228 39                  716 	addc  a,r1
   4229 F9                  717 	mov	r1,a
                            718 ;       Peephole 180   changed mov to clr
   422A E4                  719 	clr  a
                            720 ;       Peephole 236b
   422B 3A                  721 	addc  a,r2
   422C FA                  722 	mov	r2,a
                            723 ;       Peephole 180   changed mov to clr
   422D E4                  724 	clr  a
                            725 ;       Peephole 236b
   422E 3B                  726 	addc  a,r3
   422F FB                  727 	mov	r3,a
                            728 ;     genCast
                            729 ;     genPointerSet
                            730 ;     genNearPointerSet
                            731 ;     genDataPointerSet
   4230 88 0F               732 	mov	(_produkt + 0x0005),r0
                            733 ;Z:\pn\z5\zad1.c:113: iloczyn = iloczyn %100000;
                            734 ;     genAssign
   4232 75 1B A0            735 	mov	__modslong_PARM_2,#0xA0
   4235 75 1C 86            736 	mov	(__modslong_PARM_2 + 1),#0x86
   4238 75 1D 01            737 	mov	(__modslong_PARM_2 + 2),#0x01
   423B 75 1E 00            738 	mov	(__modslong_PARM_2 + 3),#0x00
                            739 ;     genCall
   423E 8C 82               740 	mov	dpl,r4
   4240 8D 83               741 	mov	dph,r5
   4242 8E F0               742 	mov	b,r6
   4244 EF                  743 	mov	a,r7
   4245 12 45 20            744 	lcall	__modslong
   4248 AA 82               745 	mov	r2,dpl
   424A AB 83               746 	mov	r3,dph
   424C AC F0               747 	mov	r4,b
   424E FD                  748 	mov	r5,a
                            749 ;     genCast
   424F 8A 19               750 	mov	_wyswietl_iloczyn_iloczyn_1_1,r2
   4251 8B 1A               751 	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),r3
                            752 ;Z:\pn\z5\zad1.c:115: produkt[4] = '0' + (iloczyn / 10000);
                            753 ;     genAssign
   4253 75 1B 10            754 	mov	__divsint_PARM_2,#0x10
   4256 75 1C 27            755 	mov	(__divsint_PARM_2 + 1),#0x27
                            756 ;     genCall
   4259 85 19 82            757 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   425C 85 1A 83            758 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   425F 12 45 FC            759 	lcall	__divsint
   4262 E5 82               760 	mov	a,dpl
   4264 85 83 F0            761 	mov	b,dph
                            762 ;     genPlus
   4267 24 30               763 	add	a,#0x30
   4269 FA                  764 	mov	r2,a
   426A E5 F0               765 	mov	a,b
   426C 34 00               766 	addc	a,#0x00
   426E FB                  767 	mov	r3,a
                            768 ;     genCast
                            769 ;     genPointerSet
                            770 ;     genNearPointerSet
                            771 ;     genDataPointerSet
   426F 8A 0E               772 	mov	(_produkt + 0x0004),r2
                            773 ;Z:\pn\z5\zad1.c:117: iloczyn = iloczyn %10000;
                            774 ;     genAssign
   4271 75 1B 10            775 	mov	__modsint_PARM_2,#0x10
   4274 75 1C 27            776 	mov	(__modsint_PARM_2 + 1),#0x27
                            777 ;     genCall
   4277 85 19 82            778 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   427A 85 1A 83            779 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   427D 12 45 C4            780 	lcall	__modsint
   4280 E5 82               781 	mov	a,dpl
   4282 85 83 F0            782 	mov	b,dph
                            783 ;     genAssign
   4285 F5 19               784 	mov	_wyswietl_iloczyn_iloczyn_1_1,a
   4287 85 F0 1A            785 	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
                            786 ;Z:\pn\z5\zad1.c:119: produkt[3] = '0' + (iloczyn / 1000); 
                            787 ;     genAssign
   428A 75 1B E8            788 	mov	__divsint_PARM_2,#0xE8
   428D 75 1C 03            789 	mov	(__divsint_PARM_2 + 1),#0x03
                            790 ;     genCall
   4290 85 19 82            791 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   4293 85 1A 83            792 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   4296 12 45 FC            793 	lcall	__divsint
   4299 E5 82               794 	mov	a,dpl
   429B 85 83 F0            795 	mov	b,dph
                            796 ;     genPlus
   429E 24 30               797 	add	a,#0x30
   42A0 FA                  798 	mov	r2,a
   42A1 E5 F0               799 	mov	a,b
   42A3 34 00               800 	addc	a,#0x00
   42A5 FB                  801 	mov	r3,a
                            802 ;     genCast
                            803 ;     genPointerSet
                            804 ;     genNearPointerSet
                            805 ;     genDataPointerSet
   42A6 8A 0D               806 	mov	(_produkt + 0x0003),r2
                            807 ;Z:\pn\z5\zad1.c:121: iloczyn = iloczyn %1000;
                            808 ;     genAssign
   42A8 75 1B E8            809 	mov	__modsint_PARM_2,#0xE8
   42AB 75 1C 03            810 	mov	(__modsint_PARM_2 + 1),#0x03
                            811 ;     genCall
   42AE 85 19 82            812 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   42B1 85 1A 83            813 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   42B4 12 45 C4            814 	lcall	__modsint
   42B7 E5 82               815 	mov	a,dpl
   42B9 85 83 F0            816 	mov	b,dph
                            817 ;     genAssign
   42BC F5 19               818 	mov	_wyswietl_iloczyn_iloczyn_1_1,a
   42BE 85 F0 1A            819 	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
                            820 ;Z:\pn\z5\zad1.c:123: produkt[2] = '0' + (iloczyn / 100); 
                            821 ;     genAssign
   42C1 E4                  822 	clr	a
   42C2 F5 1C               823 	mov	(__divsint_PARM_2 + 1),a
   42C4 75 1B 64            824 	mov	__divsint_PARM_2,#0x64
                            825 ;     genCall
   42C7 85 19 82            826 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   42CA 85 1A 83            827 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   42CD 12 45 FC            828 	lcall	__divsint
   42D0 E5 82               829 	mov	a,dpl
   42D2 85 83 F0            830 	mov	b,dph
                            831 ;     genPlus
   42D5 24 30               832 	add	a,#0x30
   42D7 FA                  833 	mov	r2,a
   42D8 E5 F0               834 	mov	a,b
   42DA 34 00               835 	addc	a,#0x00
   42DC FB                  836 	mov	r3,a
                            837 ;     genCast
                            838 ;     genPointerSet
                            839 ;     genNearPointerSet
                            840 ;     genDataPointerSet
   42DD 8A 0C               841 	mov	(_produkt + 0x0002),r2
                            842 ;Z:\pn\z5\zad1.c:125: iloczyn = iloczyn %100;
                            843 ;     genAssign
   42DF E4                  844 	clr	a
   42E0 F5 1C               845 	mov	(__modsint_PARM_2 + 1),a
   42E2 75 1B 64            846 	mov	__modsint_PARM_2,#0x64
                            847 ;     genCall
   42E5 85 19 82            848 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   42E8 85 1A 83            849 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   42EB 12 45 C4            850 	lcall	__modsint
   42EE E5 82               851 	mov	a,dpl
   42F0 85 83 F0            852 	mov	b,dph
                            853 ;     genAssign
   42F3 F5 19               854 	mov	_wyswietl_iloczyn_iloczyn_1_1,a
   42F5 85 F0 1A            855 	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
                            856 ;Z:\pn\z5\zad1.c:127: produkt[1] = '0' + (iloczyn / 10); 
                            857 ;     genAssign
   42F8 E4                  858 	clr	a
   42F9 F5 1C               859 	mov	(__divsint_PARM_2 + 1),a
   42FB 75 1B 0A            860 	mov	__divsint_PARM_2,#0x0A
                            861 ;     genCall
   42FE 85 19 82            862 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   4301 85 1A 83            863 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   4304 12 45 FC            864 	lcall	__divsint
   4307 E5 82               865 	mov	a,dpl
   4309 85 83 F0            866 	mov	b,dph
                            867 ;     genPlus
   430C 24 30               868 	add	a,#0x30
   430E FA                  869 	mov	r2,a
   430F E5 F0               870 	mov	a,b
   4311 34 00               871 	addc	a,#0x00
   4313 FB                  872 	mov	r3,a
                            873 ;     genCast
                            874 ;     genPointerSet
                            875 ;     genNearPointerSet
                            876 ;     genDataPointerSet
   4314 8A 0B               877 	mov	(_produkt + 0x0001),r2
                            878 ;Z:\pn\z5\zad1.c:129: iloczyn = iloczyn %10;
                            879 ;     genAssign
   4316 E4                  880 	clr	a
   4317 F5 1C               881 	mov	(__modsint_PARM_2 + 1),a
   4319 75 1B 0A            882 	mov	__modsint_PARM_2,#0x0A
                            883 ;     genCall
   431C 85 19 82            884 	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
   431F 85 1A 83            885 	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
   4322 12 45 C4            886 	lcall	__modsint
   4325 E5 82               887 	mov	a,dpl
   4327 85 83 F0            888 	mov	b,dph
                            889 ;Z:\pn\z5\zad1.c:131: produkt[0] = '0' + (iloczyn / 1); 
                            890 ;     genPlus
   432A 24 30               891 	add	a,#0x30
   432C FA                  892 	mov	r2,a
   432D E5 F0               893 	mov	a,b
   432F 34 00               894 	addc	a,#0x00
   4331 FB                  895 	mov	r3,a
                            896 ;     genCast
                            897 ;     genPointerSet
                            898 ;     genNearPointerSet
                            899 ;     genDataPointerSet
   4332 8A 0A               900 	mov	_produkt,r2
                            901 ;Z:\pn\z5\zad1.c:134: for (i = j-1; i>=0; i--)
                            902 ;     genMinus
                            903 ;     genMinusDec
   4334 E5 13               904 	mov	a,_j
   4336 24 FF               905 	add	a,#0xff
   4338 F5 11               906 	mov	_i,a
   433A E5 14               907 	mov	a,(_j + 1)
   433C 34 FF               908 	addc	a,#0xff
   433E F5 12               909 	mov	(_i + 1),a
   4340                     910 00110$:
                            911 ;     genCmpLt
                            912 ;     genCmp
   4340 E5 12               913 	mov	a,(_i + 1)
                            914 ;     genIfxJump
                            915 ;       Peephole 112   removed ljmp by inverse jump logic
   4342 20 E7 1E            916 	jb   acc.7,00114$
   4345                     917 00126$:
                            918 ;Z:\pn\z5\zad1.c:136: wyslij_dane(produkt[i]);	
                            919 ;     genPlus
   4345 E5 11               920 	mov	a,_i
   4347 24 0A               921 	add	a,#_produkt
   4349 F8                  922 	mov	r0,a
                            923 ;     genPointerGet
                            924 ;     genNearPointerGet
   434A 86 82               925 	mov	dpl,@r0
                            926 ;     genCall
   434C 12 40 7C            927 	lcall	_wyslij_dane
                            928 ;Z:\pn\z5\zad1.c:137: czekaj(100);
                            929 ;     genCall
                            930 ;       Peephole 182   used 16 bit load of dptr
   434F 90 00 64            931 	mov  dptr,#(((0x00)<<8) + 0x64)
   4352 12 40 C6            932 	lcall	_czekaj
                            933 ;Z:\pn\z5\zad1.c:134: for (i = j-1; i>=0; i--)
                            934 ;     genMinus
                            935 ;     genMinusDec
   4355 E5 11               936 	mov	a,_i
   4357 24 FF               937 	add	a,#0xff
   4359 F5 11               938 	mov	_i,a
   435B E5 12               939 	mov	a,(_i + 1)
   435D 34 FF               940 	addc	a,#0xff
   435F F5 12               941 	mov	(_i + 1),a
                            942 ;       Peephole 132   changed ljmp to sjmp
   4361 80 DD               943 	sjmp 00110$
   4363                     944 00114$:
   4363 22                  945 	ret
                            946 ;------------------------------------------------------------
                            947 ;Allocation info for local variables in function 'main'
                            948 ;------------------------------------------------------------
                            949 ;------------------------------------------------------------
                            950 ;Z:\pn\z5\zad1.c:143: void main(void)
                            951 ;	-----------------------------------------
                            952 ;	 function main
                            953 ;	-----------------------------------------
   4364                     954 _main:
                            955 ;Z:\pn\z5\zad1.c:145: init();
                            956 ;     genCall
   4364 12 40 E6            957 	lcall	_init
                            958 ;Z:\pn\z5\zad1.c:146: czekaj(100);
                            959 ;     genCall
                            960 ;       Peephole 182   used 16 bit load of dptr
   4367 90 00 64            961 	mov  dptr,#(((0x00)<<8) + 0x64)
   436A 12 40 C6            962 	lcall	_czekaj
                            963 ;Z:\pn\z5\zad1.c:147: wyslij_polecenie4(0x01);
                            964 ;     genCall
   436D 75 82 01            965 	mov	dpl,#0x01
   4370 12 40 4E            966 	lcall	_wyslij_polecenie4
                            967 ;Z:\pn\z5\zad1.c:148: czekaj(100);
                            968 ;     genCall
                            969 ;       Peephole 182   used 16 bit load of dptr
   4373 90 00 64            970 	mov  dptr,#(((0x00)<<8) + 0x64)
   4376 12 40 C6            971 	lcall	_czekaj
                            972 ;Z:\pn\z5\zad1.c:149: czekaj(100);
                            973 ;     genCall
                            974 ;       Peephole 182   used 16 bit load of dptr
   4379 90 00 64            975 	mov  dptr,#(((0x00)<<8) + 0x64)
   437C 12 40 C6            976 	lcall	_czekaj
                            977 ;Z:\pn\z5\zad1.c:150: czekaj(100);
                            978 ;     genCall
                            979 ;       Peephole 182   used 16 bit load of dptr
   437F 90 00 64            980 	mov  dptr,#(((0x00)<<8) + 0x64)
   4382 12 40 C6            981 	lcall	_czekaj
                            982 ;Z:\pn\z5\zad1.c:155: gotoXY(5,1);
                            983 ;     genAssign
   4385 75 10 01            984 	mov	_gotoXY_PARM_2,#0x01
                            985 ;     genCall
   4388 75 82 05            986 	mov	dpl,#0x05
   438B 12 41 47            987 	lcall	_gotoXY
                            988 ;Z:\pn\z5\zad1.c:156: czekaj(100);
                            989 ;     genCall
                            990 ;       Peephole 182   used 16 bit load of dptr
   438E 90 00 64            991 	mov  dptr,#(((0x00)<<8) + 0x64)
   4391 12 40 C6            992 	lcall	_czekaj
                            993 ;Z:\pn\z5\zad1.c:158: wyswietl_iloczyn(10,12);
                            994 ;     genAssign
   4394 E4                  995 	clr	a
   4395 F5 18               996 	mov	(_wyswietl_iloczyn_PARM_2 + 1),a
   4397 75 17 0C            997 	mov	_wyswietl_iloczyn_PARM_2,#0x0C
                            998 ;     genCall
                            999 ;       Peephole 182   used 16 bit load of dptr
   439A 90 00 0A           1000 	mov  dptr,#(((0x00)<<8) + 0x0A)
   439D 12 41 5E           1001 	lcall	_wyswietl_iloczyn
   43A0                    1002 00101$:
   43A0 22                 1003 	ret
                           1004 	.area CSEG    (CODE)
                           1005 	.area XINIT   (CODE)
