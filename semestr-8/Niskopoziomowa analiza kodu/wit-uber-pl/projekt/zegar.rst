                              1 ;--------------------------------------------------------
                              2 ; File Created by SDCC : FreeWare ANSI-C Compiler
                              3 ; Version 2.3.3 Wed May 25 11:33:19 2011
                              4 
                              5 ;--------------------------------------------------------
                              6 	.module zegar
                              7 	
                              8 ;--------------------------------------------------------
                              9 ; Public variables in this module
                             10 ;--------------------------------------------------------
                             11 	.globl _main
                             12 	.globl _wyswietl_alarm
                             13 	.globl _alarm
                             14 	.globl _wyswietl_godz
                             15 	.globl _czas
                             16 	.globl _gotoXY
                             17 	.globl _init
                             18 	.globl _func_isr
                             19 	.globl _czekaj
                             20 	.globl _wyslij_dane
                             21 	.globl _wyslij_polecenie4
                             22 	.globl _wyslij_polecenie8
                             23 	.globl _U12
                             24 	.globl _gotoXY_PARM_2
                             25 	.globl _t
                             26 	.globl _key_set
                             27 	.globl _dlugosc_sekundy
                             28 	.globl _stop
                             29 	.globl _alarm_on
                             30 	.globl _alarm_min
                             31 	.globl _alarm_godz
                             32 	.globl _sek
                             33 	.globl _min
                             34 	.globl _godz
                             35 	.globl _produkt
                             36 	.globl _RS
                             37 	.globl _E
                             38 ;--------------------------------------------------------
                             39 ; special function registers
                             40 ;--------------------------------------------------------
                    0090     41 _P1	=	0x0090
                    00A8     42 _IE	=	0x00a8
                    0089     43 _TMOD	=	0x0089
                    008D     44 _TH1	=	0x008d
                    008B     45 _TL1	=	0x008b
                    0088     46 _TCON	=	0x0088
                    0099     47 _SBUF	=	0x0099
                    0098     48 _SCON	=	0x0098
                    0087     49 _PCON	=	0x0087
                             50 ;--------------------------------------------------------
                             51 ; special function bits 
                             52 ;--------------------------------------------------------
                    00B4     53 _T1	=	0x00b4
                    0098     54 _RI	=	0x0098
                    0099     55 _TI	=	0x0099
                             56 ;--------------------------------------------------------
                             57 ; overlayable register banks 
                             58 ;--------------------------------------------------------
                             59 	.area REG_BANK_0	(REL,OVR,DATA)
   0000                      60 	.ds 8
                             61 ;--------------------------------------------------------
                             62 ; internal ram data
                             63 ;--------------------------------------------------------
                             64 	.area DSEG    (DATA)
   0008                      65 _E::
   0008                      66 	.ds 1
   0009                      67 _RS::
   0009                      68 	.ds 1
   000A                      69 _produkt::
   000A                      70 	.ds 6
   0010                      71 _godz::
   0010                      72 	.ds 2
   0012                      73 _min::
   0012                      74 	.ds 2
   0014                      75 _sek::
   0014                      76 	.ds 2
   0016                      77 _alarm_godz::
   0016                      78 	.ds 2
   0018                      79 _alarm_min::
   0018                      80 	.ds 2
   001A                      81 _alarm_on::
   001A                      82 	.ds 2
   001C                      83 _stop::
   001C                      84 	.ds 2
   001E                      85 _dlugosc_sekundy::
   001E                      86 	.ds 2
   0020                      87 _key_set::
   0020                      88 	.ds 2
   0022                      89 _t::
   0022                      90 	.ds 2
   0024                      91 _gotoXY_PARM_2::
   0024                      92 	.ds 1
                             93 ;--------------------------------------------------------
                             94 ; overlayable items in internal ram 
                             95 ;--------------------------------------------------------
                             96 	.area	OSEG    (OVR,DATA)
                             97 	.area	OSEG    (OVR,DATA)
                             98 	.area	OSEG    (OVR,DATA)
                             99 	.area	OSEG    (OVR,DATA)
                            100 ;--------------------------------------------------------
                            101 ; Stack segment in internal ram 
                            102 ;--------------------------------------------------------
                            103 	.area	SSEG	(DATA)
   0027                     104 __start__stack:
   0027                     105 	.ds	1
                            106 
                            107 ;--------------------------------------------------------
                            108 ; indirectly addressable internal ram data
                            109 ;--------------------------------------------------------
                            110 	.area ISEG    (DATA)
                            111 ;--------------------------------------------------------
                            112 ; bit data
                            113 ;--------------------------------------------------------
                            114 	.area BSEG    (BIT)
                            115 ;--------------------------------------------------------
                            116 ; external ram data
                            117 ;--------------------------------------------------------
                            118 	.area XSEG    (XDATA)
                    8000    119 _U12	=	0x8000
                            120 ;--------------------------------------------------------
                            121 ; external initialized ram data
                            122 ;--------------------------------------------------------
                            123 	.area XISEG   (XDATA)
                            124 ;--------------------------------------------------------
                            125 ; interrupt vector 
                            126 ;--------------------------------------------------------
                            127 	.area CSEG    (CODE)
   4000                     128 __interrupt_vect:
   4000 02 47 32            129 	ljmp	__sdcc_gsinit_startup
   4003 32                  130 	reti
   4004                     131 	.ds	7
   400B 32                  132 	reti
   400C                     133 	.ds	7
   4013 32                  134 	reti
   4014                     135 	.ds	7
   401B 02 40 E6            136 	ljmp	_func_isr
   401E                     137 	.ds	5
   4023 32                  138 	reti
   4024                     139 	.ds	7
   402B 32                  140 	reti
   402C                     141 	.ds	7
                            142 ;--------------------------------------------------------
                            143 ; global & static initialisations
                            144 ;--------------------------------------------------------
                            145 	.area GSINIT  (CODE)
                            146 	.area GSFINAL (CODE)
                            147 	.area GSINIT  (CODE)
   4732                     148 __sdcc_gsinit_startup:
   4732 75 81 26            149 	mov	sp,#__start__stack - 1
   4735 12 46 48            150 	lcall	__sdcc_external_startup
   4738 E5 82               151 	mov	a,dpl
   473A 60 03               152 	jz	__sdcc_init_data
   473C 02 40 33            153 	ljmp	__sdcc_program_startup
   473F                     154 __sdcc_init_data:
                            155 ;	_mcs51_genXINIT() start
   473F 74 00               156 	mov	a,#l_XINIT
   4741 44 00               157 	orl	a,#l_XINIT>>8
   4743 60 29               158 	jz	00003$
   4745 74 96               159 	mov	a,#s_XINIT
   4747 24 00               160 	add	a,#l_XINIT
   4749 F9                  161 	mov	r1,a
   474A 74 47               162 	mov	a,#s_XINIT>>8
   474C 34 00               163 	addc	a,#l_XINIT>>8
   474E FA                  164 	mov	r2,a
   474F 90 47 96            165 	mov	dptr,#s_XINIT
   4752 78 00               166 	mov	r0,#s_XISEG
   4754 75 A0 00            167 	mov	p2,#(s_XISEG >> 8)
   4757 E4                  168 00001$:	clr	a
   4758 93                  169 	movc	a,@a+dptr
   4759 F2                  170 	movx	@r0,a
   475A A3                  171 	inc	dptr
   475B 08                  172 	inc	r0
   475C B8 00 02            173 	cjne	r0,#0,00002$
   475F 05 A0               174 	inc	p2
   4761 E5 82               175 00002$:	mov	a,dpl
   4763 B5 01 F1            176 	cjne	a,ar1,00001$
   4766 E5 83               177 	mov	a,dph
   4768 B5 02 EC            178 	cjne	a,ar2,00001$
   476B 75 A0 FF            179 	mov	p2,#0xFF
   476E                     180 00003$:
                            181 ;	_mcs51_genXINIT() end
                            182 ;Z:\pn\projekt\zegar.c:5: char E = 0x08;
                            183 ;     genAssign
   476E 75 08 08            184 	mov	_E,#0x08
                            185 ;Z:\pn\projekt\zegar.c:6: char RS = 0x04;
                            186 ;     genAssign
   4771 75 09 04            187 	mov	_RS,#0x04
                            188 ;Z:\pn\projekt\zegar.c:25: int alarm_godz = 0;
                            189 ;     genAssign
   4774 E4                  190 	clr	a
   4775 F5 17               191 	mov	(_alarm_godz + 1),a
   4777 F5 16               192 	mov	_alarm_godz,a
                            193 ;Z:\pn\projekt\zegar.c:26: int alarm_min = 0;
                            194 ;     genAssign
   4779 E4                  195 	clr	a
   477A F5 19               196 	mov	(_alarm_min + 1),a
   477C F5 18               197 	mov	_alarm_min,a
                            198 ;Z:\pn\projekt\zegar.c:27: int alarm_on =0;
                            199 ;     genAssign
   477E E4                  200 	clr	a
   477F F5 1B               201 	mov	(_alarm_on + 1),a
   4781 F5 1A               202 	mov	_alarm_on,a
                            203 ;Z:\pn\projekt\zegar.c:28: int stop = 0;
                            204 ;     genAssign
   4783 E4                  205 	clr	a
   4784 F5 1D               206 	mov	(_stop + 1),a
   4786 F5 1C               207 	mov	_stop,a
                            208 ;Z:\pn\projekt\zegar.c:30: int dlugosc_sekundy = 23500;
                            209 ;     genAssign
   4788 75 1E CC            210 	mov	_dlugosc_sekundy,#0xCC
   478B 75 1F 5B            211 	mov	(_dlugosc_sekundy + 1),#0x5B
                            212 ;Z:\pn\projekt\zegar.c:76: int key_set = 0;	//zmienna informujaca, o tym, ze wcisniety klawisz zostal przetworzony
                            213 ;     genAssign
   478E E4                  214 	clr	a
   478F F5 21               215 	mov	(_key_set + 1),a
   4791 F5 20               216 	mov	_key_set,a
                            217 	.area GSFINAL (CODE)
   4793 02 40 33            218 	ljmp	__sdcc_program_startup
                            219 ;--------------------------------------------------------
                            220 ; Home
                            221 ;--------------------------------------------------------
                            222 	.area HOME    (CODE)
                            223 	.area CSEG    (CODE)
                            224 ;--------------------------------------------------------
                            225 ; code
                            226 ;--------------------------------------------------------
                            227 	.area CSEG    (CODE)
   4033                     228 __sdcc_program_startup:
   4033 12 44 F9            229 	lcall	_main
                            230 ;	return from main will lock up
   4036 80 FE               231 	sjmp .
                            232 ;------------------------------------------------------------
                            233 ;Allocation info for local variables in function 'wyslij_polecenie8'
                            234 ;------------------------------------------------------------
                            235 ;------------------------------------------------------------
                            236 ;Z:\pn\projekt\zegar.c:33: void wyslij_polecenie8(unsigned char polecenie)
                            237 ;	-----------------------------------------
                            238 ;	 function wyslij_polecenie8
                            239 ;	-----------------------------------------
   4038                     240 _wyslij_polecenie8:
                    0002    241 	ar2 = 0x02
                    0003    242 	ar3 = 0x03
                    0004    243 	ar4 = 0x04
                    0005    244 	ar5 = 0x05
                    0006    245 	ar6 = 0x06
                    0007    246 	ar7 = 0x07
                    0000    247 	ar0 = 0x00
                    0001    248 	ar1 = 0x01
                            249 ;     genReceive
   4038 AA 82               250 	mov	r2,dpl
                            251 ;Z:\pn\projekt\zegar.c:35: P1=polecenie;
                            252 ;     genAssign
   403A 8A 90               253 	mov	_P1,r2
                            254 ;Z:\pn\projekt\zegar.c:36: P1=polecenie | E; //gdzie E – jest mask¹ bitow¹ "ustawiaj¹c¹" liniê E – nale¿y j¹
                            255 ;     genAssign
   403C AB 08               256 	mov	r3,_E
                            257 ;     genOr
   403E EB                  258 	mov	a,r3
   403F 4A                  259 	orl	a,r2
   4040 F5 90               260 	mov	_P1,a
                            261 ;Z:\pn\projekt\zegar.c:41: P1=polecenie & !E; //gdzie !E – jest zanegowana maska bitowa, zeruj¹c¹ linie E –
                            262 ;     genNot
   4042 E5 08               263 	mov	a,_E
   4044 B4 01 00            264 	cjne	a,#0x01,00103$
   4047                     265 00103$:
   4047 E4                  266 	clr	a
   4048 33                  267 	rlc	a
                            268 ;     genAnd
                            269 ;       Peephole 105   removed redundant mov
   4049 FB                  270 	mov  r3,a
   404A 5A                  271 	anl	a,r2
   404B F5 90               272 	mov	_P1,a
   404D                     273 00101$:
   404D 22                  274 	ret
                            275 ;------------------------------------------------------------
                            276 ;Allocation info for local variables in function 'wyslij_polecenie4'
                            277 ;------------------------------------------------------------
                            278 ;------------------------------------------------------------
                            279 ;Z:\pn\projekt\zegar.c:45: void wyslij_polecenie4(unsigned char polecenie)
                            280 ;	-----------------------------------------
                            281 ;	 function wyslij_polecenie4
                            282 ;	-----------------------------------------
   404E                     283 _wyslij_polecenie4:
                            284 ;     genReceive
   404E AA 82               285 	mov	r2,dpl
                            286 ;Z:\pn\projekt\zegar.c:47: P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
                            287 ;     genAnd
   4050 74 F0               288 	mov	a,#0xF0
   4052 5A                  289 	anl	a,r2
   4053 FB                  290 	mov	r3,a
                            291 ;     genAssign
   4054 8B 90               292 	mov	_P1,r3
                            293 ;Z:\pn\projekt\zegar.c:48: P1=(polecenie & 0xf0) | E; //sygna³ „strob”
                            294 ;     genAssign
   4056 AC 08               295 	mov	r4,_E
                            296 ;     genOr
   4058 EC                  297 	mov	a,r4
   4059 4B                  298 	orl	a,r3
   405A F5 90               299 	mov	_P1,a
                            300 ;Z:\pn\projekt\zegar.c:49: P1=(polecenie & 0xf0) & !E;
                            301 ;     genNot
   405C E5 08               302 	mov	a,_E
   405E B4 01 00            303 	cjne	a,#0x01,00103$
   4061                     304 00103$:
   4061 E4                  305 	clr	a
   4062 33                  306 	rlc	a
                            307 ;     genAnd
                            308 ;       Peephole 105   removed redundant mov
   4063 FC                  309 	mov  r4,a
   4064 5B                  310 	anl	a,r3
   4065 F5 90               311 	mov	_P1,a
                            312 ;Z:\pn\projekt\zegar.c:50: P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
                            313 ;    genLeftShift
                            314 ;     genLeftShiftLiteral
                            315 ;     genlshOne
   4067 EA                  316 	mov	a,r2
   4068 C4                  317 	swap	a
   4069 54 F0               318 	anl	a,#0xf0
   406B FA                  319 	mov	r2,a
                            320 ;     genAnd
   406C 53 02 F0            321 	anl	ar2,#0xF0
                            322 ;     genAssign
   406F 8A 90               323 	mov	_P1,r2
                            324 ;Z:\pn\projekt\zegar.c:51: P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
                            325 ;     genAssign
   4071 AB 08               326 	mov	r3,_E
                            327 ;     genOr
   4073 EB                  328 	mov	a,r3
   4074 4A                  329 	orl	a,r2
   4075 F5 90               330 	mov	_P1,a
                            331 ;Z:\pn\projekt\zegar.c:52: P1=((polecenie << 4) & 0xf0) & !E;
                            332 ;     genAnd
   4077 EC                  333 	mov	a,r4
   4078 5A                  334 	anl	a,r2
   4079 F5 90               335 	mov	_P1,a
   407B                     336 00101$:
   407B 22                  337 	ret
                            338 ;------------------------------------------------------------
                            339 ;Allocation info for local variables in function 'wyslij_dane'
                            340 ;------------------------------------------------------------
                            341 ;------------------------------------------------------------
                            342 ;Z:\pn\projekt\zegar.c:55: void wyslij_dane(unsigned char dana)
                            343 ;	-----------------------------------------
                            344 ;	 function wyslij_dane
                            345 ;	-----------------------------------------
   407C                     346 _wyslij_dane:
                            347 ;     genReceive
   407C AA 82               348 	mov	r2,dpl
                            349 ;Z:\pn\projekt\zegar.c:57: P1=(dana & 0xf0) | RS;
                            350 ;     genAnd
   407E 74 F0               351 	mov	a,#0xF0
   4080 5A                  352 	anl	a,r2
   4081 FB                  353 	mov	r3,a
                            354 ;     genAssign
   4082 AC 09               355 	mov	r4,_RS
                            356 ;     genOr
   4084 EC                  357 	mov	a,r4
   4085 4B                  358 	orl	a,r3
   4086 F5 90               359 	mov	_P1,a
                            360 ;Z:\pn\projekt\zegar.c:58: P1=((dana & 0xf0) | E) | RS;
                            361 ;     genAssign
   4088 AC 08               362 	mov	r4,_E
                            363 ;     genOr
   408A EB                  364 	mov	a,r3
   408B 42 04               365 	orl	ar4,a
                            366 ;     genAssign
   408D AD 09               367 	mov	r5,_RS
                            368 ;     genOr
   408F ED                  369 	mov	a,r5
   4090 4C                  370 	orl	a,r4
   4091 F5 90               371 	mov	_P1,a
                            372 ;Z:\pn\projekt\zegar.c:59: P1=((dana & 0xf0) & !E) | RS;
                            373 ;     genNot
   4093 E5 08               374 	mov	a,_E
   4095 B4 01 00            375 	cjne	a,#0x01,00103$
   4098                     376 00103$:
   4098 E4                  377 	clr	a
   4099 33                  378 	rlc	a
                            379 ;     genAnd
                            380 ;       Peephole 105   removed redundant mov
   409A FC                  381 	mov  r4,a
   409B 52 03               382 	anl	ar3,a
                            383 ;     genAssign
   409D AD 09               384 	mov	r5,_RS
                            385 ;     genOr
   409F ED                  386 	mov	a,r5
   40A0 4B                  387 	orl	a,r3
   40A1 F5 90               388 	mov	_P1,a
                            389 ;Z:\pn\projekt\zegar.c:60: P1=((dana << 4) & 0xf0) | RS;
                            390 ;    genLeftShift
                            391 ;     genLeftShiftLiteral
                            392 ;     genlshOne
   40A3 EA                  393 	mov	a,r2
   40A4 C4                  394 	swap	a
   40A5 54 F0               395 	anl	a,#0xf0
   40A7 FA                  396 	mov	r2,a
                            397 ;     genAnd
   40A8 53 02 F0            398 	anl	ar2,#0xF0
                            399 ;     genAssign
   40AB AB 09               400 	mov	r3,_RS
                            401 ;     genOr
   40AD EB                  402 	mov	a,r3
   40AE 4A                  403 	orl	a,r2
   40AF F5 90               404 	mov	_P1,a
                            405 ;Z:\pn\projekt\zegar.c:61: P1=(((dana << 4) & 0xf0) | E) | RS;
                            406 ;     genAssign
   40B1 AB 08               407 	mov	r3,_E
                            408 ;     genOr
   40B3 EA                  409 	mov	a,r2
   40B4 42 03               410 	orl	ar3,a
                            411 ;     genAssign
   40B6 AD 09               412 	mov	r5,_RS
                            413 ;     genOr
   40B8 ED                  414 	mov	a,r5
   40B9 4B                  415 	orl	a,r3
   40BA F5 90               416 	mov	_P1,a
                            417 ;Z:\pn\projekt\zegar.c:62: P1=(((dana << 4) & 0xf0) & !E) | RS;
                            418 ;     genAnd
   40BC EA                  419 	mov	a,r2
   40BD 52 04               420 	anl	ar4,a
                            421 ;     genAssign
   40BF AA 09               422 	mov	r2,_RS
                            423 ;     genOr
   40C1 EA                  424 	mov	a,r2
   40C2 4C                  425 	orl	a,r4
   40C3 F5 90               426 	mov	_P1,a
   40C5                     427 00101$:
   40C5 22                  428 	ret
                            429 ;------------------------------------------------------------
                            430 ;Allocation info for local variables in function 'czekaj'
                            431 ;------------------------------------------------------------
                            432 ;------------------------------------------------------------
                            433 ;Z:\pn\projekt\zegar.c:65: void czekaj(int d){
                            434 ;	-----------------------------------------
                            435 ;	 function czekaj
                            436 ;	-----------------------------------------
   40C6                     437 _czekaj:
                            438 ;     genReceive
   40C6 AA 82               439 	mov	r2,dpl
   40C8 AB 83               440 	mov	r3,dph
                            441 ;Z:\pn\projekt\zegar.c:67: for(i=0; i<d; i++){
                            442 ;     genAssign
   40CA 7C 00               443 	mov	r4,#0x00
   40CC 7D 00               444 	mov	r5,#0x00
   40CE                     445 00101$:
                            446 ;     genCmpLt
                            447 ;     genCmp
   40CE C3                  448 	clr	c
   40CF EC                  449 	mov	a,r4
   40D0 9A                  450 	subb	a,r2
   40D1 ED                  451 	mov	a,r5
   40D2 64 80               452 	xrl	a,#0x80
   40D4 8B F0               453 	mov	b,r3
   40D6 63 F0 80            454 	xrl	b,#0x80
   40D9 95 F0               455 	subb	a,b
                            456 ;     genIfxJump
                            457 ;       Peephole 108   removed ljmp by inverse jump logic
   40DB 50 08               458 	jnc  00105$
   40DD                     459 00109$:
                            460 ;Z:\pn\projekt\zegar.c:70: _endasm;
                            461 ;     genInline
   40DD 00                  462 	                nop
                            463 ;Z:\pn\projekt\zegar.c:67: for(i=0; i<d; i++){
                            464 ;     genPlus
                            465 ;     genPlusIncr
                            466 ;	tail increment optimized
   40DE 0C                  467 	inc	r4
   40DF BC 00 EC            468 	cjne	r4,#0x00,00101$
   40E2 0D                  469 	inc	r5
                            470 ;       Peephole 132   changed ljmp to sjmp
   40E3 80 E9               471 	sjmp 00101$
   40E5                     472 00105$:
   40E5 22                  473 	ret
                            474 ;------------------------------------------------------------
                            475 ;Allocation info for local variables in function 'func_isr'
                            476 ;------------------------------------------------------------
                            477 ;------------------------------------------------------------
                            478 ;Z:\pn\projekt\zegar.c:82: void func_isr (void) interrupt 3
                            479 ;	-----------------------------------------
                            480 ;	 function func_isr
                            481 ;	-----------------------------------------
   40E6                     482 _func_isr:
   40E6 C0 E0               483 	push	acc
   40E8 C0 F0               484 	push	b
   40EA C0 82               485 	push	dpl
   40EC C0 83               486 	push	dph
   40EE C0 D0               487 	push	psw
   40F0 75 D0 00            488 	mov	psw,#0x00
                            489 ;Z:\pn\projekt\zegar.c:85: t++;
                            490 ;     genPlus
                            491 ;     genPlusIncr
   40F3 74 01               492 	mov	a,#0x01
   40F5 25 22               493 	add	a,_t
   40F7 F5 22               494 	mov	_t,a
                            495 ;       Peephole 180   changed mov to clr
   40F9 E4                  496 	clr  a
   40FA 35 23               497 	addc	a,(_t + 1)
   40FC F5 23               498 	mov	(_t + 1),a
                            499 ;Z:\pn\projekt\zegar.c:86: if(t==dlugosc_sekundy){
                            500 ;     genCmpEq
   40FE E5 22               501 	mov	a,_t
                            502 ;       Peephole 132   changed ljmp to sjmp
                            503 ;       Peephole 197   optimized misc jump sequence
   4100 B5 1E 15            504 	cjne a,_dlugosc_sekundy,00103$
   4103 E5 23               505 	mov  a,(_t + 1)
   4105 B5 1F 10            506 	cjne a,(_dlugosc_sekundy + 1),00103$
                            507 ;00106$:
                            508 ;       Peephole 200   removed redundant sjmp
   4108                     509 00107$:
                            510 ;Z:\pn\projekt\zegar.c:87: t=0;
                            511 ;     genAssign
   4108 E4                  512 	clr	a
   4109 F5 23               513 	mov	(_t + 1),a
   410B F5 22               514 	mov	_t,a
                            515 ;Z:\pn\projekt\zegar.c:88: sek++;
                            516 ;     genPlus
                            517 ;     genPlusIncr
   410D 74 01               518 	mov	a,#0x01
   410F 25 14               519 	add	a,_sek
   4111 F5 14               520 	mov	_sek,a
                            521 ;       Peephole 180   changed mov to clr
   4113 E4                  522 	clr  a
   4114 35 15               523 	addc	a,(_sek + 1)
   4116 F5 15               524 	mov	(_sek + 1),a
   4118                     525 00103$:
   4118 D0 D0               526 	pop	psw
   411A D0 83               527 	pop	dph
   411C D0 82               528 	pop	dpl
   411E D0 F0               529 	pop	b
   4120 D0 E0               530 	pop	acc
   4122 32                  531 	reti
                            532 ;------------------------------------------------------------
                            533 ;Allocation info for local variables in function 'init'
                            534 ;------------------------------------------------------------
                            535 ;------------------------------------------------------------
                            536 ;Z:\pn\projekt\zegar.c:96: void init()
                            537 ;	-----------------------------------------
                            538 ;	 function init
                            539 ;	-----------------------------------------
   4123                     540 _init:
                            541 ;Z:\pn\projekt\zegar.c:98: SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
                            542 ;     genAssign
   4123 75 98 50            543 	mov	_SCON,#0x50
                            544 ;Z:\pn\projekt\zegar.c:100: TMOD &=	0x0F;	//konfiguracja licznika
                            545 ;     genAnd
   4126 53 89 0F            546 	anl	_TMOD,#0x0F
                            547 ;Z:\pn\projekt\zegar.c:101: TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
                            548 ;     genOr
   4129 43 89 20            549 	orl	_TMOD,#0x20
                            550 ;Z:\pn\projekt\zegar.c:103: TH1 = TL1 = 253;     //Wartosc startowa
                            551 ;     genAssign
   412C 75 8B FD            552 	mov	_TL1,#0xFD
                            553 ;     genAssign
   412F 75 8D FD            554 	mov	_TH1,#0xFD
                            555 ;Z:\pn\projekt\zegar.c:104: TCON = 0x40;
                            556 ;     genAssign
   4132 75 88 40            557 	mov	_TCON,#0x40
                            558 ;Z:\pn\projekt\zegar.c:105: PCON = 0x80;
                            559 ;     genAssign
   4135 75 87 80            560 	mov	_PCON,#0x80
                            561 ;Z:\pn\projekt\zegar.c:106: IE =	0x88;
                            562 ;     genAssign
   4138 75 A8 88            563 	mov	_IE,#0x88
                            564 ;Z:\pn\projekt\zegar.c:109: wyslij_polecenie8(0x30); //3
                            565 ;     genCall
   413B 75 82 30            566 	mov	dpl,#0x30
   413E 12 40 38            567 	lcall	_wyslij_polecenie8
                            568 ;Z:\pn\projekt\zegar.c:110: czekaj(100);
                            569 ;     genCall
                            570 ;       Peephole 182   used 16 bit load of dptr
   4141 90 00 64            571 	mov  dptr,#(((0x00)<<8) + 0x64)
   4144 12 40 C6            572 	lcall	_czekaj
                            573 ;Z:\pn\projekt\zegar.c:111: wyslij_polecenie8(0x30); //5
                            574 ;     genCall
   4147 75 82 30            575 	mov	dpl,#0x30
   414A 12 40 38            576 	lcall	_wyslij_polecenie8
                            577 ;Z:\pn\projekt\zegar.c:112: czekaj(100);
                            578 ;     genCall
                            579 ;       Peephole 182   used 16 bit load of dptr
   414D 90 00 64            580 	mov  dptr,#(((0x00)<<8) + 0x64)
   4150 12 40 C6            581 	lcall	_czekaj
                            582 ;Z:\pn\projekt\zegar.c:113: wyslij_polecenie8(0x30); //7
                            583 ;     genCall
   4153 75 82 30            584 	mov	dpl,#0x30
   4156 12 40 38            585 	lcall	_wyslij_polecenie8
                            586 ;Z:\pn\projekt\zegar.c:114: czekaj(100);
                            587 ;     genCall
                            588 ;       Peephole 182   used 16 bit load of dptr
   4159 90 00 64            589 	mov  dptr,#(((0x00)<<8) + 0x64)
   415C 12 40 C6            590 	lcall	_czekaj
                            591 ;Z:\pn\projekt\zegar.c:115: wyslij_polecenie8(0x20); //9
                            592 ;     genCall
   415F 75 82 20            593 	mov	dpl,#0x20
   4162 12 40 38            594 	lcall	_wyslij_polecenie8
                            595 ;Z:\pn\projekt\zegar.c:116: czekaj(100);
                            596 ;     genCall
                            597 ;       Peephole 182   used 16 bit load of dptr
   4165 90 00 64            598 	mov  dptr,#(((0x00)<<8) + 0x64)
   4168 12 40 C6            599 	lcall	_czekaj
                            600 ;Z:\pn\projekt\zegar.c:117: wyslij_polecenie4(0x2F); //11
                            601 ;     genCall
   416B 75 82 2F            602 	mov	dpl,#0x2F
   416E 12 40 4E            603 	lcall	_wyslij_polecenie4
                            604 ;Z:\pn\projekt\zegar.c:118: czekaj(100);
                            605 ;     genCall
                            606 ;       Peephole 182   used 16 bit load of dptr
   4171 90 00 64            607 	mov  dptr,#(((0x00)<<8) + 0x64)
   4174 12 40 C6            608 	lcall	_czekaj
                            609 ;Z:\pn\projekt\zegar.c:119: wyslij_polecenie4(0x08); //13
                            610 ;     genCall
   4177 75 82 08            611 	mov	dpl,#0x08
   417A 12 40 4E            612 	lcall	_wyslij_polecenie4
                            613 ;Z:\pn\projekt\zegar.c:120: czekaj(100);
                            614 ;     genCall
                            615 ;       Peephole 182   used 16 bit load of dptr
   417D 90 00 64            616 	mov  dptr,#(((0x00)<<8) + 0x64)
   4180 12 40 C6            617 	lcall	_czekaj
                            618 ;Z:\pn\projekt\zegar.c:122: wyslij_polecenie4(0x0C); //15 -- mod na wylaczenie kursora
                            619 ;     genCall
   4183 75 82 0C            620 	mov	dpl,#0x0C
   4186 12 40 4E            621 	lcall	_wyslij_polecenie4
                            622 ;Z:\pn\projekt\zegar.c:124: czekaj(100);
                            623 ;     genCall
                            624 ;       Peephole 182   used 16 bit load of dptr
   4189 90 00 64            625 	mov  dptr,#(((0x00)<<8) + 0x64)
   418C 12 40 C6            626 	lcall	_czekaj
                            627 ;Z:\pn\projekt\zegar.c:125: wyslij_polecenie4(0x06); //17
                            628 ;     genCall
   418F 75 82 06            629 	mov	dpl,#0x06
   4192 12 40 4E            630 	lcall	_wyslij_polecenie4
                            631 ;Z:\pn\projekt\zegar.c:126: czekaj(100);
                            632 ;     genCall
                            633 ;       Peephole 182   used 16 bit load of dptr
   4195 90 00 64            634 	mov  dptr,#(((0x00)<<8) + 0x64)
   4198 12 40 C6            635 	lcall	_czekaj
   419B                     636 00101$:
   419B 22                  637 	ret
                            638 ;------------------------------------------------------------
                            639 ;Allocation info for local variables in function 'gotoXY'
                            640 ;------------------------------------------------------------
                            641 ;y                         Allocated to in memory with name '_gotoXY_PARM_2'
                            642 ;x                         Allocated to registers r2 
                            643 ;i                         Allocated to registers r3 
                            644 ;------------------------------------------------------------
                            645 ;Z:\pn\projekt\zegar.c:129: void gotoXY(unsigned char x, unsigned char y)
                            646 ;	-----------------------------------------
                            647 ;	 function gotoXY
                            648 ;	-----------------------------------------
   419C                     649 _gotoXY:
                            650 ;     genReceive
   419C AA 82               651 	mov	r2,dpl
                            652 ;Z:\pn\projekt\zegar.c:132: if(y==0)
                            653 ;     genCmpEq
   419E E5 24               654 	mov	a,_gotoXY_PARM_2
                            655 ;       Peephole 162   removed sjmp by inverse jump logic
   41A0 60 02               656 	jz   00108$
   41A2                     657 00107$:
                            658 ;       Peephole 132   changed ljmp to sjmp
   41A2 80 04               659 	sjmp 00102$
   41A4                     660 00108$:
                            661 ;Z:\pn\projekt\zegar.c:134: i = 128;
                            662 ;     genAssign
   41A4 7B 80               663 	mov	r3,#0x80
                            664 ;       Peephole 132   changed ljmp to sjmp
   41A6 80 02               665 	sjmp 00103$
   41A8                     666 00102$:
                            667 ;Z:\pn\projekt\zegar.c:138: i = 192;
                            668 ;     genAssign
   41A8 7B C0               669 	mov	r3,#0xC0
   41AA                     670 00103$:
                            671 ;Z:\pn\projekt\zegar.c:140: i |= x;
                            672 ;     genOr
   41AA EA                  673 	mov	a,r2
   41AB 42 03               674 	orl	ar3,a
                            675 ;Z:\pn\projekt\zegar.c:141: wyslij_polecenie4(i);
                            676 ;     genCall
   41AD 8B 82               677 	mov	dpl,r3
   41AF 12 40 4E            678 	lcall	_wyslij_polecenie4
   41B2                     679 00104$:
   41B2 22                  680 	ret
                            681 ;------------------------------------------------------------
                            682 ;Allocation info for local variables in function 'czas'
                            683 ;------------------------------------------------------------
                            684 ;------------------------------------------------------------
                            685 ;Z:\pn\projekt\zegar.c:144: void czas(){
                            686 ;	-----------------------------------------
                            687 ;	 function czas
                            688 ;	-----------------------------------------
   41B3                     689 _czas:
                            690 ;Z:\pn\projekt\zegar.c:146: if (sek==59)
                            691 ;     genCmpEq
   41B3 E5 14               692 	mov	a,_sek
   41B5 B4 3B 04            693 	cjne	a,#0x3B,00113$
   41B8 E5 15               694 	mov	a,(_sek + 1)
                            695 ;       Peephole 162   removed sjmp by inverse jump logic
   41BA 60 02               696 	jz   00114$
   41BC                     697 00113$:
                            698 ;       Peephole 132   changed ljmp to sjmp
   41BC 80 3D               699 	sjmp 00106$
   41BE                     700 00114$:
                            701 ;Z:\pn\projekt\zegar.c:148: min++;
                            702 ;     genPlus
                            703 ;     genPlusIncr
   41BE 74 01               704 	mov	a,#0x01
   41C0 25 12               705 	add	a,_min
   41C2 F5 12               706 	mov	_min,a
                            707 ;       Peephole 180   changed mov to clr
   41C4 E4                  708 	clr  a
   41C5 35 13               709 	addc	a,(_min + 1)
   41C7 F5 13               710 	mov	(_min + 1),a
                            711 ;Z:\pn\projekt\zegar.c:149: sek = 0;
                            712 ;     genAssign
   41C9 E4                  713 	clr	a
   41CA F5 15               714 	mov	(_sek + 1),a
   41CC F5 14               715 	mov	_sek,a
                            716 ;Z:\pn\projekt\zegar.c:151: if (min == 60) 
                            717 ;     genCmpEq
   41CE E5 12               718 	mov	a,_min
   41D0 B4 3C 04            719 	cjne	a,#0x3C,00115$
   41D3 E5 13               720 	mov	a,(_min + 1)
                            721 ;       Peephole 162   removed sjmp by inverse jump logic
   41D5 60 02               722 	jz   00116$
   41D7                     723 00115$:
                            724 ;       Peephole 132   changed ljmp to sjmp
   41D7 80 3B               725 	sjmp 00108$
   41D9                     726 00116$:
                            727 ;Z:\pn\projekt\zegar.c:153: godz++;
                            728 ;     genPlus
                            729 ;     genPlusIncr
   41D9 74 01               730 	mov	a,#0x01
   41DB 25 10               731 	add	a,_godz
   41DD F5 10               732 	mov	_godz,a
                            733 ;       Peephole 180   changed mov to clr
   41DF E4                  734 	clr  a
   41E0 35 11               735 	addc	a,(_godz + 1)
   41E2 F5 11               736 	mov	(_godz + 1),a
                            737 ;Z:\pn\projekt\zegar.c:154: min = 0;
                            738 ;     genAssign
   41E4 E4                  739 	clr	a
   41E5 F5 13               740 	mov	(_min + 1),a
   41E7 F5 12               741 	mov	_min,a
                            742 ;Z:\pn\projekt\zegar.c:155: if(godz == 24)
                            743 ;     genCmpEq
   41E9 E5 10               744 	mov	a,_godz
   41EB B4 18 04            745 	cjne	a,#0x18,00117$
   41EE E5 11               746 	mov	a,(_godz + 1)
                            747 ;       Peephole 162   removed sjmp by inverse jump logic
   41F0 60 02               748 	jz   00118$
   41F2                     749 00117$:
                            750 ;       Peephole 132   changed ljmp to sjmp
   41F2 80 20               751 	sjmp 00108$
   41F4                     752 00118$:
                            753 ;Z:\pn\projekt\zegar.c:156: godz = 0;
                            754 ;     genAssign
   41F4 E4                  755 	clr	a
   41F5 F5 11               756 	mov	(_godz + 1),a
   41F7 F5 10               757 	mov	_godz,a
                            758 ;       Peephole 132   changed ljmp to sjmp
   41F9 80 19               759 	sjmp 00108$
   41FB                     760 00106$:
                            761 ;Z:\pn\projekt\zegar.c:163: sek = sek%59;
                            762 ;     genAssign
   41FB E4                  763 	clr	a
   41FC F5 26               764 	mov	(__modsint_PARM_2 + 1),a
   41FE 75 25 3B            765 	mov	__modsint_PARM_2,#0x3B
                            766 ;     genCall
   4201 85 14 82            767 	mov	dpl,_sek
   4204 85 15 83            768 	mov	dph,(_sek + 1)
   4207 12 46 C2            769 	lcall	__modsint
   420A E5 82               770 	mov	a,dpl
   420C 85 83 F0            771 	mov	b,dph
                            772 ;     genAssign
   420F F5 14               773 	mov	_sek,a
   4211 85 F0 15            774 	mov	(_sek + 1),b
   4214                     775 00108$:
   4214 22                  776 	ret
                            777 ;------------------------------------------------------------
                            778 ;Allocation info for local variables in function 'wyswietl_godz'
                            779 ;------------------------------------------------------------
                            780 ;------------------------------------------------------------
                            781 ;Z:\pn\projekt\zegar.c:167: void wyswietl_godz()
                            782 ;	-----------------------------------------
                            783 ;	 function wyswietl_godz
                            784 ;	-----------------------------------------
   4215                     785 _wyswietl_godz:
                            786 ;Z:\pn\projekt\zegar.c:169: czas();
                            787 ;     genCall
   4215 12 41 B3            788 	lcall	_czas
                            789 ;Z:\pn\projekt\zegar.c:171: wyslij_dane('0' + godz / 10 );
                            790 ;     genAssign
   4218 E4                  791 	clr	a
   4219 F5 26               792 	mov	(__divsint_PARM_2 + 1),a
   421B 75 25 0A            793 	mov	__divsint_PARM_2,#0x0A
                            794 ;     genCall
   421E 85 10 82            795 	mov	dpl,_godz
   4221 85 11 83            796 	mov	dph,(_godz + 1)
   4224 12 46 FA            797 	lcall	__divsint
   4227 E5 82               798 	mov	a,dpl
   4229 85 83 F0            799 	mov	b,dph
                            800 ;     genPlus
   422C 24 30               801 	add	a,#0x30
   422E FA                  802 	mov	r2,a
   422F E5 F0               803 	mov	a,b
   4231 34 00               804 	addc	a,#0x00
   4233 FB                  805 	mov	r3,a
                            806 ;     genCast
   4234 8A 82               807 	mov	dpl,r2
                            808 ;     genCall
   4236 12 40 7C            809 	lcall	_wyslij_dane
                            810 ;Z:\pn\projekt\zegar.c:172: czekaj(100);
                            811 ;     genCall
                            812 ;       Peephole 182   used 16 bit load of dptr
   4239 90 00 64            813 	mov  dptr,#(((0x00)<<8) + 0x64)
   423C 12 40 C6            814 	lcall	_czekaj
                            815 ;Z:\pn\projekt\zegar.c:173: wyslij_dane('0' + godz % 10 );
                            816 ;     genAssign
   423F E4                  817 	clr	a
   4240 F5 26               818 	mov	(__modsint_PARM_2 + 1),a
   4242 75 25 0A            819 	mov	__modsint_PARM_2,#0x0A
                            820 ;     genCall
   4245 85 10 82            821 	mov	dpl,_godz
   4248 85 11 83            822 	mov	dph,(_godz + 1)
   424B 12 46 C2            823 	lcall	__modsint
   424E E5 82               824 	mov	a,dpl
   4250 85 83 F0            825 	mov	b,dph
                            826 ;     genPlus
   4253 24 30               827 	add	a,#0x30
   4255 FA                  828 	mov	r2,a
   4256 E5 F0               829 	mov	a,b
   4258 34 00               830 	addc	a,#0x00
   425A FB                  831 	mov	r3,a
                            832 ;     genCast
   425B 8A 82               833 	mov	dpl,r2
                            834 ;     genCall
   425D 12 40 7C            835 	lcall	_wyslij_dane
                            836 ;Z:\pn\projekt\zegar.c:174: czekaj(100);
                            837 ;     genCall
                            838 ;       Peephole 182   used 16 bit load of dptr
   4260 90 00 64            839 	mov  dptr,#(((0x00)<<8) + 0x64)
   4263 12 40 C6            840 	lcall	_czekaj
                            841 ;Z:\pn\projekt\zegar.c:175: wyslij_dane(':');
                            842 ;     genCall
   4266 75 82 3A            843 	mov	dpl,#0x3A
   4269 12 40 7C            844 	lcall	_wyslij_dane
                            845 ;Z:\pn\projekt\zegar.c:176: czekaj(100);
                            846 ;     genCall
                            847 ;       Peephole 182   used 16 bit load of dptr
   426C 90 00 64            848 	mov  dptr,#(((0x00)<<8) + 0x64)
   426F 12 40 C6            849 	lcall	_czekaj
                            850 ;Z:\pn\projekt\zegar.c:177: wyslij_dane('0' + min / 10 );
                            851 ;     genAssign
   4272 E4                  852 	clr	a
   4273 F5 26               853 	mov	(__divsint_PARM_2 + 1),a
   4275 75 25 0A            854 	mov	__divsint_PARM_2,#0x0A
                            855 ;     genCall
   4278 85 12 82            856 	mov	dpl,_min
   427B 85 13 83            857 	mov	dph,(_min + 1)
   427E 12 46 FA            858 	lcall	__divsint
   4281 E5 82               859 	mov	a,dpl
   4283 85 83 F0            860 	mov	b,dph
                            861 ;     genPlus
   4286 24 30               862 	add	a,#0x30
   4288 FA                  863 	mov	r2,a
   4289 E5 F0               864 	mov	a,b
   428B 34 00               865 	addc	a,#0x00
   428D FB                  866 	mov	r3,a
                            867 ;     genCast
   428E 8A 82               868 	mov	dpl,r2
                            869 ;     genCall
   4290 12 40 7C            870 	lcall	_wyslij_dane
                            871 ;Z:\pn\projekt\zegar.c:178: czekaj(100);
                            872 ;     genCall
                            873 ;       Peephole 182   used 16 bit load of dptr
   4293 90 00 64            874 	mov  dptr,#(((0x00)<<8) + 0x64)
   4296 12 40 C6            875 	lcall	_czekaj
                            876 ;Z:\pn\projekt\zegar.c:179: wyslij_dane('0' + min % 10 );
                            877 ;     genAssign
   4299 E4                  878 	clr	a
   429A F5 26               879 	mov	(__modsint_PARM_2 + 1),a
   429C 75 25 0A            880 	mov	__modsint_PARM_2,#0x0A
                            881 ;     genCall
   429F 85 12 82            882 	mov	dpl,_min
   42A2 85 13 83            883 	mov	dph,(_min + 1)
   42A5 12 46 C2            884 	lcall	__modsint
   42A8 E5 82               885 	mov	a,dpl
   42AA 85 83 F0            886 	mov	b,dph
                            887 ;     genPlus
   42AD 24 30               888 	add	a,#0x30
   42AF FA                  889 	mov	r2,a
   42B0 E5 F0               890 	mov	a,b
   42B2 34 00               891 	addc	a,#0x00
   42B4 FB                  892 	mov	r3,a
                            893 ;     genCast
   42B5 8A 82               894 	mov	dpl,r2
                            895 ;     genCall
   42B7 12 40 7C            896 	lcall	_wyslij_dane
                            897 ;Z:\pn\projekt\zegar.c:180: czekaj(100);
                            898 ;     genCall
                            899 ;       Peephole 182   used 16 bit load of dptr
   42BA 90 00 64            900 	mov  dptr,#(((0x00)<<8) + 0x64)
   42BD 12 40 C6            901 	lcall	_czekaj
                            902 ;Z:\pn\projekt\zegar.c:181: wyslij_dane(':');
                            903 ;     genCall
   42C0 75 82 3A            904 	mov	dpl,#0x3A
   42C3 12 40 7C            905 	lcall	_wyslij_dane
                            906 ;Z:\pn\projekt\zegar.c:182: czekaj(100);
                            907 ;     genCall
                            908 ;       Peephole 182   used 16 bit load of dptr
   42C6 90 00 64            909 	mov  dptr,#(((0x00)<<8) + 0x64)
   42C9 12 40 C6            910 	lcall	_czekaj
                            911 ;Z:\pn\projekt\zegar.c:183: wyslij_dane('0' + sek / 10 );
                            912 ;     genAssign
   42CC E4                  913 	clr	a
   42CD F5 26               914 	mov	(__divsint_PARM_2 + 1),a
   42CF 75 25 0A            915 	mov	__divsint_PARM_2,#0x0A
                            916 ;     genCall
   42D2 85 14 82            917 	mov	dpl,_sek
   42D5 85 15 83            918 	mov	dph,(_sek + 1)
   42D8 12 46 FA            919 	lcall	__divsint
   42DB E5 82               920 	mov	a,dpl
   42DD 85 83 F0            921 	mov	b,dph
                            922 ;     genPlus
   42E0 24 30               923 	add	a,#0x30
   42E2 FA                  924 	mov	r2,a
   42E3 E5 F0               925 	mov	a,b
   42E5 34 00               926 	addc	a,#0x00
   42E7 FB                  927 	mov	r3,a
                            928 ;     genCast
   42E8 8A 82               929 	mov	dpl,r2
                            930 ;     genCall
   42EA 12 40 7C            931 	lcall	_wyslij_dane
                            932 ;Z:\pn\projekt\zegar.c:184: czekaj(100);
                            933 ;     genCall
                            934 ;       Peephole 182   used 16 bit load of dptr
   42ED 90 00 64            935 	mov  dptr,#(((0x00)<<8) + 0x64)
   42F0 12 40 C6            936 	lcall	_czekaj
                            937 ;Z:\pn\projekt\zegar.c:185: wyslij_dane('0' + sek % 10 );
                            938 ;     genAssign
   42F3 E4                  939 	clr	a
   42F4 F5 26               940 	mov	(__modsint_PARM_2 + 1),a
   42F6 75 25 0A            941 	mov	__modsint_PARM_2,#0x0A
                            942 ;     genCall
   42F9 85 14 82            943 	mov	dpl,_sek
   42FC 85 15 83            944 	mov	dph,(_sek + 1)
   42FF 12 46 C2            945 	lcall	__modsint
   4302 E5 82               946 	mov	a,dpl
   4304 85 83 F0            947 	mov	b,dph
                            948 ;     genPlus
   4307 24 30               949 	add	a,#0x30
   4309 FA                  950 	mov	r2,a
   430A E5 F0               951 	mov	a,b
   430C 34 00               952 	addc	a,#0x00
   430E FB                  953 	mov	r3,a
                            954 ;     genCast
   430F 8A 82               955 	mov	dpl,r2
                            956 ;     genCall
   4311 12 40 7C            957 	lcall	_wyslij_dane
                            958 ;Z:\pn\projekt\zegar.c:186: czekaj(100);
                            959 ;     genCall
                            960 ;       Peephole 182   used 16 bit load of dptr
   4314 90 00 64            961 	mov  dptr,#(((0x00)<<8) + 0x64)
   4317 12 40 C6            962 	lcall	_czekaj
                            963 ;Z:\pn\projekt\zegar.c:187: gotoXY(0,0);     
                            964 ;     genAssign
   431A 75 24 00            965 	mov	_gotoXY_PARM_2,#0x00
                            966 ;     genCall
   431D 75 82 00            967 	mov	dpl,#0x00
   4320 12 41 9C            968 	lcall	_gotoXY
                            969 ;Z:\pn\projekt\zegar.c:188: czekaj(100);
                            970 ;     genCall
                            971 ;       Peephole 182   used 16 bit load of dptr
   4323 90 00 64            972 	mov  dptr,#(((0x00)<<8) + 0x64)
   4326 12 40 C6            973 	lcall	_czekaj
                            974 ;Z:\pn\projekt\zegar.c:189: czekaj(100);
                            975 ;     genCall
                            976 ;       Peephole 182   used 16 bit load of dptr
   4329 90 00 64            977 	mov  dptr,#(((0x00)<<8) + 0x64)
   432C 12 40 C6            978 	lcall	_czekaj
   432F                     979 00101$:
   432F 22                  980 	ret
                            981 ;------------------------------------------------------------
                            982 ;Allocation info for local variables in function 'alarm'
                            983 ;------------------------------------------------------------
                            984 ;r                         Allocated to registers r2 
                            985 ;hz                        Allocated to registers 
                            986 ;i                         Allocated to registers 
                            987 ;j                         Allocated to registers 
                            988 ;------------------------------------------------------------
                            989 ;Z:\pn\projekt\zegar.c:192: void alarm(){
                            990 ;	-----------------------------------------
                            991 ;	 function alarm
                            992 ;	-----------------------------------------
   4330                     993 _alarm:
                            994 ;Z:\pn\projekt\zegar.c:194: unsigned char r=0;
                            995 ;     genAssign
   4330 7A 00               996 	mov	r2,#0x00
                            997 ;Z:\pn\projekt\zegar.c:199: while (alarm_godz == godz && alarm_min == min && alarm_on == 1 && stop == 0)
   4332                     998 00113$:
                            999 ;     genCmpEq
   4332 E5 16              1000 	mov	a,_alarm_godz
   4334 B5 10 07           1001 	cjne	a,_godz,00139$
   4337 E5 17              1002 	mov	a,(_alarm_godz + 1)
   4339 B5 11 02           1003 	cjne	a,(_godz + 1),00139$
   433C 80 03              1004 	sjmp	00140$
   433E                    1005 00139$:
   433E 02 44 25           1006 	ljmp	00124$
   4341                    1007 00140$:
                           1008 ;     genCmpEq
   4341 E5 18              1009 	mov	a,_alarm_min
   4343 B5 12 07           1010 	cjne	a,_min,00141$
   4346 E5 19              1011 	mov	a,(_alarm_min + 1)
   4348 B5 13 02           1012 	cjne	a,(_min + 1),00141$
   434B 80 03              1013 	sjmp	00142$
   434D                    1014 00141$:
   434D 02 44 25           1015 	ljmp	00124$
   4350                    1016 00142$:
                           1017 ;     genCmpEq
   4350 E5 1A              1018 	mov	a,_alarm_on
   4352 B4 01 04           1019 	cjne	a,#0x01,00143$
   4355 E5 1B              1020 	mov	a,(_alarm_on + 1)
                           1021 ;       Peephole 162   removed sjmp by inverse jump logic
   4357 60 03              1022 	jz   00144$
   4359                    1023 00143$:
   4359 02 44 25           1024 	ljmp	00124$
   435C                    1025 00144$:
                           1026 ;     genCmpEq
   435C E5 1C              1027 	mov	a,_stop
   435E 70 04              1028 	jnz	00145$
   4360 E5 1D              1029 	mov	a,(_stop + 1)
                           1030 ;       Peephole 162   removed sjmp by inverse jump logic
   4362 60 03              1031 	jz   00146$
   4364                    1032 00145$:
   4364 02 44 25           1033 	ljmp	00124$
   4367                    1034 00146$:
                           1035 ;Z:\pn\projekt\zegar.c:206: for(j=0;j<100;j++){
                           1036 ;     genAssign
   4367 8A 03              1037 	mov	ar3,r2
                           1038 ;     genAssign
   4369 7C 00              1039 	mov	r4,#0x00
   436B 7D 00              1040 	mov	r5,#0x00
   436D                    1041 00120$:
                           1042 ;     genCmpLt
                           1043 ;     genCmp
   436D C3                 1044 	clr	c
   436E EC                 1045 	mov	a,r4
   436F 94 64              1046 	subb	a,#0x64
   4371 ED                 1047 	mov	a,r5
   4372 64 80              1048 	xrl	a,#0x80
   4374 94 80              1049 	subb	a,#0x80
   4376 E4                 1050 	clr	a
   4377 33                 1051 	rlc	a
   4378 FE                 1052 	mov	r6,a
                           1053 ;     genAssign
   4379 8B 02              1054 	mov	ar2,r3
                           1055 ;     genIfx
   437B EE                 1056 	mov	a,r6
                           1057 ;     genIfxJump
                           1058 ;       Peephole 110   removed ljmp by inverse jump logic
   437C 60 1F              1059 	jz  00123$
   437E                    1060 00147$:
                           1061 ;Z:\pn\projekt\zegar.c:207: if (( r & 0x01) == 0) // maskowanie
                           1062 ;     genAnd
   437E 74 01              1063 	mov	a,#0x01
   4380 5B                 1064 	anl	a,r3
   4381 FF                 1065 	mov	r7,a
                           1066 ;     genCmpEq
                           1067 ;       Peephole 132   changed ljmp to sjmp
                           1068 ;       Peephole 199   optimized misc jump sequence
   4382 BF 00 04           1069 	cjne r7,#0x00,00102$
                           1070 ;00148$:
                           1071 ;       Peephole 200   removed redundant sjmp
   4385                    1072 00149$:
                           1073 ;Z:\pn\projekt\zegar.c:208: T1 = 1;
                           1074 ;     genAssign
   4385 D2 B4              1075 	setb	_T1
                           1076 ;       Peephole 132   changed ljmp to sjmp
   4387 80 02              1077 	sjmp 00103$
   4389                    1078 00102$:
                           1079 ;Z:\pn\projekt\zegar.c:210: T1 = 0;
                           1080 ;     genAssign
   4389 C2 B4              1081 	clr	_T1
   438B                    1082 00103$:
                           1083 ;Z:\pn\projekt\zegar.c:211: r++;
                           1084 ;     genPlus
                           1085 ;     genPlusIncr
   438B 0B                 1086 	inc	r3
                           1087 ;Z:\pn\projekt\zegar.c:212: for(i=0;i<hz;i++);
                           1088 ;     genAssign
   438C 7F 00              1089 	mov	r7,#0x00
   438E                    1090 00116$:
                           1091 ;     genCmpLt
                           1092 ;     genCmp
   438E BF 0A 00           1093 	cjne	r7,#0x0A,00150$
   4391                    1094 00150$:
                           1095 ;     genIfxJump
                           1096 ;       Peephole 108   removed ljmp by inverse jump logic
   4391 50 03              1097 	jnc  00122$
   4393                    1098 00151$:
                           1099 ;     genPlus
                           1100 ;     genPlusIncr
   4393 0F                 1101 	inc	r7
                           1102 ;       Peephole 132   changed ljmp to sjmp
   4394 80 F8              1103 	sjmp 00116$
   4396                    1104 00122$:
                           1105 ;Z:\pn\projekt\zegar.c:206: for(j=0;j<100;j++){
                           1106 ;     genPlus
                           1107 ;     genPlusIncr
   4396 0C                 1108 	inc	r4
   4397 BC 00 01           1109 	cjne	r4,#0x00,00152$
   439A 0D                 1110 	inc	r5
   439B                    1111 00152$:
                           1112 ;       Peephole 132   changed ljmp to sjmp
   439B 80 D0              1113 	sjmp 00120$
   439D                    1114 00123$:
                           1115 ;Z:\pn\projekt\zegar.c:217: if (( U12 & 0x08 )== 0 )
                           1116 ;     genAssign
   439D 90 80 00           1117 	mov	dptr,#_U12
   43A0 E0                 1118 	movx	a,@dptr
   43A1 FB                 1119 	mov	r3,a
                           1120 ;     genAnd
   43A2 53 03 08           1121 	anl	ar3,#0x08
                           1122 ;     genCmpEq
                           1123 ;       Peephole 132   changed ljmp to sjmp
                           1124 ;       Peephole 199   optimized misc jump sequence
   43A5 BB 00 15           1125 	cjne r3,#0x00,00105$
                           1126 ;00153$:
                           1127 ;       Peephole 200   removed redundant sjmp
   43A8                    1128 00154$:
                           1129 ;Z:\pn\projekt\zegar.c:219: stop=1;
                           1130 ;     genAssign
   43A8 E4                 1131 	clr	a
   43A9 F5 1D              1132 	mov	(_stop + 1),a
   43AB 75 1C 01           1133 	mov	_stop,#0x01
                           1134 ;Z:\pn\projekt\zegar.c:220: alarm_on=0;
                           1135 ;     genAssign
   43AE E4                 1136 	clr	a
   43AF F5 1B              1137 	mov	(_alarm_on + 1),a
   43B1 F5 1A              1138 	mov	_alarm_on,a
                           1139 ;Z:\pn\projekt\zegar.c:221: wyslij_polecenie4(0x01);
                           1140 ;     genCall
   43B3 75 82 01           1141 	mov	dpl,#0x01
   43B6 C0 02              1142 	push	ar2
   43B8 12 40 4E           1143 	lcall	_wyslij_polecenie4
   43BB D0 02              1144 	pop	ar2
   43BD                    1145 00105$:
                           1146 ;Z:\pn\projekt\zegar.c:224: if (( U12 & 0x01 )== 0 )
                           1147 ;     genAssign
   43BD 90 80 00           1148 	mov	dptr,#_U12
   43C0 E0                 1149 	movx	a,@dptr
   43C1 FB                 1150 	mov	r3,a
                           1151 ;     genAnd
   43C2 53 03 01           1152 	anl	ar3,#0x01
                           1153 ;     genCmpEq
                           1154 ;       Peephole 132   changed ljmp to sjmp
                           1155 ;       Peephole 199   optimized misc jump sequence
   43C5 BB 00 24           1156 	cjne r3,#0x00,00107$
                           1157 ;00155$:
                           1158 ;       Peephole 200   removed redundant sjmp
   43C8                    1159 00156$:
                           1160 ;Z:\pn\projekt\zegar.c:226: alarm_godz =(alarm_godz +1)%24;
                           1161 ;     genPlus
                           1162 ;     genPlusIncr
   43C8 74 01              1163 	mov	a,#0x01
   43CA 25 16              1164 	add	a,_alarm_godz
   43CC FB                 1165 	mov	r3,a
                           1166 ;       Peephole 180   changed mov to clr
   43CD E4                 1167 	clr  a
   43CE 35 17              1168 	addc	a,(_alarm_godz + 1)
   43D0 FC                 1169 	mov	r4,a
                           1170 ;     genAssign
   43D1 E4                 1171 	clr	a
   43D2 F5 26              1172 	mov	(__modsint_PARM_2 + 1),a
   43D4 75 25 18           1173 	mov	__modsint_PARM_2,#0x18
                           1174 ;     genCall
   43D7 8B 82              1175 	mov	dpl,r3
   43D9 8C 83              1176 	mov	dph,r4
   43DB C0 02              1177 	push	ar2
   43DD 12 46 C2           1178 	lcall	__modsint
   43E0 E5 82              1179 	mov	a,dpl
   43E2 85 83 F0           1180 	mov	b,dph
   43E5 D0 02              1181 	pop	ar2
                           1182 ;     genAssign
   43E7 F5 16              1183 	mov	_alarm_godz,a
   43E9 85 F0 17           1184 	mov	(_alarm_godz + 1),b
   43EC                    1185 00107$:
                           1186 ;Z:\pn\projekt\zegar.c:230: if (( U12 & 0x02 )== 0 )
                           1187 ;     genAssign
   43EC 90 80 00           1188 	mov	dptr,#_U12
   43EF E0                 1189 	movx	a,@dptr
   43F0 FB                 1190 	mov	r3,a
                           1191 ;     genAnd
   43F1 53 03 02           1192 	anl	ar3,#0x02
                           1193 ;     genCmpEq
                           1194 ;       Peephole 132   changed ljmp to sjmp
                           1195 ;       Peephole 199   optimized misc jump sequence
   43F4 BB 00 24           1196 	cjne r3,#0x00,00109$
                           1197 ;00157$:
                           1198 ;       Peephole 200   removed redundant sjmp
   43F7                    1199 00158$:
                           1200 ;Z:\pn\projekt\zegar.c:232: alarm_min = (alarm_min +1)%60;
                           1201 ;     genPlus
                           1202 ;     genPlusIncr
   43F7 74 01              1203 	mov	a,#0x01
   43F9 25 18              1204 	add	a,_alarm_min
   43FB FB                 1205 	mov	r3,a
                           1206 ;       Peephole 180   changed mov to clr
   43FC E4                 1207 	clr  a
   43FD 35 19              1208 	addc	a,(_alarm_min + 1)
   43FF FC                 1209 	mov	r4,a
                           1210 ;     genAssign
   4400 E4                 1211 	clr	a
   4401 F5 26              1212 	mov	(__modsint_PARM_2 + 1),a
   4403 75 25 3C           1213 	mov	__modsint_PARM_2,#0x3C
                           1214 ;     genCall
   4406 8B 82              1215 	mov	dpl,r3
   4408 8C 83              1216 	mov	dph,r4
   440A C0 02              1217 	push	ar2
   440C 12 46 C2           1218 	lcall	__modsint
   440F E5 82              1219 	mov	a,dpl
   4411 85 83 F0           1220 	mov	b,dph
   4414 D0 02              1221 	pop	ar2
                           1222 ;     genAssign
   4416 F5 18              1223 	mov	_alarm_min,a
   4418 85 F0 19           1224 	mov	(_alarm_min + 1),b
   441B                    1225 00109$:
                           1226 ;Z:\pn\projekt\zegar.c:236: wyswietl_godz();
                           1227 ;     genCall
   441B C0 02              1228 	push	ar2
   441D 12 42 15           1229 	lcall	_wyswietl_godz
   4420 D0 02              1230 	pop	ar2
   4422 02 43 32           1231 	ljmp	00113$
   4425                    1232 00124$:
   4425 22                 1233 	ret
                           1234 ;------------------------------------------------------------
                           1235 ;Allocation info for local variables in function 'wyswietl_alarm'
                           1236 ;------------------------------------------------------------
                           1237 ;------------------------------------------------------------
                           1238 ;Z:\pn\projekt\zegar.c:248: void wyswietl_alarm()
                           1239 ;	-----------------------------------------
                           1240 ;	 function wyswietl_alarm
                           1241 ;	-----------------------------------------
   4426                    1242 _wyswietl_alarm:
                           1243 ;Z:\pn\projekt\zegar.c:250: if(alarm_on == 1)
                           1244 ;     genCmpEq
   4426 E5 1A              1245 	mov	a,_alarm_on
   4428 B4 01 04           1246 	cjne	a,#0x01,00106$
   442B E5 1B              1247 	mov	a,(_alarm_on + 1)
                           1248 ;       Peephole 162   removed sjmp by inverse jump logic
   442D 60 03              1249 	jz   00107$
   442F                    1250 00106$:
   442F 02 44 F8           1251 	ljmp	00103$
   4432                    1252 00107$:
                           1253 ;Z:\pn\projekt\zegar.c:252: gotoXY(0,1); 
                           1254 ;     genAssign
   4432 75 24 01           1255 	mov	_gotoXY_PARM_2,#0x01
                           1256 ;     genCall
   4435 75 82 00           1257 	mov	dpl,#0x00
   4438 12 41 9C           1258 	lcall	_gotoXY
                           1259 ;Z:\pn\projekt\zegar.c:253: wyslij_dane('0' + alarm_godz / 10 );
                           1260 ;     genAssign
   443B E4                 1261 	clr	a
   443C F5 26              1262 	mov	(__divsint_PARM_2 + 1),a
   443E 75 25 0A           1263 	mov	__divsint_PARM_2,#0x0A
                           1264 ;     genCall
   4441 85 16 82           1265 	mov	dpl,_alarm_godz
   4444 85 17 83           1266 	mov	dph,(_alarm_godz + 1)
   4447 12 46 FA           1267 	lcall	__divsint
   444A E5 82              1268 	mov	a,dpl
   444C 85 83 F0           1269 	mov	b,dph
                           1270 ;     genPlus
   444F 24 30              1271 	add	a,#0x30
   4451 FA                 1272 	mov	r2,a
   4452 E5 F0              1273 	mov	a,b
   4454 34 00              1274 	addc	a,#0x00
   4456 FB                 1275 	mov	r3,a
                           1276 ;     genCast
   4457 8A 82              1277 	mov	dpl,r2
                           1278 ;     genCall
   4459 12 40 7C           1279 	lcall	_wyslij_dane
                           1280 ;Z:\pn\projekt\zegar.c:254: czekaj(100);
                           1281 ;     genCall
                           1282 ;       Peephole 182   used 16 bit load of dptr
   445C 90 00 64           1283 	mov  dptr,#(((0x00)<<8) + 0x64)
   445F 12 40 C6           1284 	lcall	_czekaj
                           1285 ;Z:\pn\projekt\zegar.c:255: wyslij_dane('0' + alarm_godz % 10 );
                           1286 ;     genAssign
   4462 E4                 1287 	clr	a
   4463 F5 26              1288 	mov	(__modsint_PARM_2 + 1),a
   4465 75 25 0A           1289 	mov	__modsint_PARM_2,#0x0A
                           1290 ;     genCall
   4468 85 16 82           1291 	mov	dpl,_alarm_godz
   446B 85 17 83           1292 	mov	dph,(_alarm_godz + 1)
   446E 12 46 C2           1293 	lcall	__modsint
   4471 E5 82              1294 	mov	a,dpl
   4473 85 83 F0           1295 	mov	b,dph
                           1296 ;     genPlus
   4476 24 30              1297 	add	a,#0x30
   4478 FA                 1298 	mov	r2,a
   4479 E5 F0              1299 	mov	a,b
   447B 34 00              1300 	addc	a,#0x00
   447D FB                 1301 	mov	r3,a
                           1302 ;     genCast
   447E 8A 82              1303 	mov	dpl,r2
                           1304 ;     genCall
   4480 12 40 7C           1305 	lcall	_wyslij_dane
                           1306 ;Z:\pn\projekt\zegar.c:256: czekaj(100);
                           1307 ;     genCall
                           1308 ;       Peephole 182   used 16 bit load of dptr
   4483 90 00 64           1309 	mov  dptr,#(((0x00)<<8) + 0x64)
   4486 12 40 C6           1310 	lcall	_czekaj
                           1311 ;Z:\pn\projekt\zegar.c:257: wyslij_dane(':');
                           1312 ;     genCall
   4489 75 82 3A           1313 	mov	dpl,#0x3A
   448C 12 40 7C           1314 	lcall	_wyslij_dane
                           1315 ;Z:\pn\projekt\zegar.c:258: czekaj(100);
                           1316 ;     genCall
                           1317 ;       Peephole 182   used 16 bit load of dptr
   448F 90 00 64           1318 	mov  dptr,#(((0x00)<<8) + 0x64)
   4492 12 40 C6           1319 	lcall	_czekaj
                           1320 ;Z:\pn\projekt\zegar.c:259: wyslij_dane('0' + alarm_min / 10 );
                           1321 ;     genAssign
   4495 E4                 1322 	clr	a
   4496 F5 26              1323 	mov	(__divsint_PARM_2 + 1),a
   4498 75 25 0A           1324 	mov	__divsint_PARM_2,#0x0A
                           1325 ;     genCall
   449B 85 18 82           1326 	mov	dpl,_alarm_min
   449E 85 19 83           1327 	mov	dph,(_alarm_min + 1)
   44A1 12 46 FA           1328 	lcall	__divsint
   44A4 E5 82              1329 	mov	a,dpl
   44A6 85 83 F0           1330 	mov	b,dph
                           1331 ;     genPlus
   44A9 24 30              1332 	add	a,#0x30
   44AB FA                 1333 	mov	r2,a
   44AC E5 F0              1334 	mov	a,b
   44AE 34 00              1335 	addc	a,#0x00
   44B0 FB                 1336 	mov	r3,a
                           1337 ;     genCast
   44B1 8A 82              1338 	mov	dpl,r2
                           1339 ;     genCall
   44B3 12 40 7C           1340 	lcall	_wyslij_dane
                           1341 ;Z:\pn\projekt\zegar.c:260: czekaj(100);
                           1342 ;     genCall
                           1343 ;       Peephole 182   used 16 bit load of dptr
   44B6 90 00 64           1344 	mov  dptr,#(((0x00)<<8) + 0x64)
   44B9 12 40 C6           1345 	lcall	_czekaj
                           1346 ;Z:\pn\projekt\zegar.c:261: wyslij_dane('0' + alarm_min % 10 );
                           1347 ;     genAssign
   44BC E4                 1348 	clr	a
   44BD F5 26              1349 	mov	(__modsint_PARM_2 + 1),a
   44BF 75 25 0A           1350 	mov	__modsint_PARM_2,#0x0A
                           1351 ;     genCall
   44C2 85 18 82           1352 	mov	dpl,_alarm_min
   44C5 85 19 83           1353 	mov	dph,(_alarm_min + 1)
   44C8 12 46 C2           1354 	lcall	__modsint
   44CB E5 82              1355 	mov	a,dpl
   44CD 85 83 F0           1356 	mov	b,dph
                           1357 ;     genPlus
   44D0 24 30              1358 	add	a,#0x30
   44D2 FA                 1359 	mov	r2,a
   44D3 E5 F0              1360 	mov	a,b
   44D5 34 00              1361 	addc	a,#0x00
   44D7 FB                 1362 	mov	r3,a
                           1363 ;     genCast
   44D8 8A 82              1364 	mov	dpl,r2
                           1365 ;     genCall
   44DA 12 40 7C           1366 	lcall	_wyslij_dane
                           1367 ;Z:\pn\projekt\zegar.c:262: czekaj(100);
                           1368 ;     genCall
                           1369 ;       Peephole 182   used 16 bit load of dptr
   44DD 90 00 64           1370 	mov  dptr,#(((0x00)<<8) + 0x64)
   44E0 12 40 C6           1371 	lcall	_czekaj
                           1372 ;Z:\pn\projekt\zegar.c:263: gotoXY(0,0);     
                           1373 ;     genAssign
   44E3 75 24 00           1374 	mov	_gotoXY_PARM_2,#0x00
                           1375 ;     genCall
   44E6 75 82 00           1376 	mov	dpl,#0x00
   44E9 12 41 9C           1377 	lcall	_gotoXY
                           1378 ;Z:\pn\projekt\zegar.c:264: czekaj(100);
                           1379 ;     genCall
                           1380 ;       Peephole 182   used 16 bit load of dptr
   44EC 90 00 64           1381 	mov  dptr,#(((0x00)<<8) + 0x64)
   44EF 12 40 C6           1382 	lcall	_czekaj
                           1383 ;Z:\pn\projekt\zegar.c:265: czekaj(100);
                           1384 ;     genCall
                           1385 ;       Peephole 182   used 16 bit load of dptr
   44F2 90 00 64           1386 	mov  dptr,#(((0x00)<<8) + 0x64)
   44F5 12 40 C6           1387 	lcall	_czekaj
   44F8                    1388 00103$:
   44F8 22                 1389 	ret
                           1390 ;------------------------------------------------------------
                           1391 ;Allocation info for local variables in function 'main'
                           1392 ;------------------------------------------------------------
                           1393 ;------------------------------------------------------------
                           1394 ;Z:\pn\projekt\zegar.c:275: void main(void)
                           1395 ;	-----------------------------------------
                           1396 ;	 function main
                           1397 ;	-----------------------------------------
   44F9                    1398 _main:
                           1399 ;Z:\pn\projekt\zegar.c:277: init();
                           1400 ;     genCall
   44F9 12 41 23           1401 	lcall	_init
                           1402 ;Z:\pn\projekt\zegar.c:279: t=0;
                           1403 ;     genAssign
   44FC E4                 1404 	clr	a
   44FD F5 23              1405 	mov	(_t + 1),a
   44FF F5 22              1406 	mov	_t,a
                           1407 ;Z:\pn\projekt\zegar.c:280: czekaj(100);
                           1408 ;     genCall
                           1409 ;       Peephole 182   used 16 bit load of dptr
   4501 90 00 64           1410 	mov  dptr,#(((0x00)<<8) + 0x64)
   4504 12 40 C6           1411 	lcall	_czekaj
                           1412 ;Z:\pn\projekt\zegar.c:281: wyslij_polecenie4(0x01);
                           1413 ;     genCall
   4507 75 82 01           1414 	mov	dpl,#0x01
   450A 12 40 4E           1415 	lcall	_wyslij_polecenie4
                           1416 ;Z:\pn\projekt\zegar.c:282: czekaj(100);
                           1417 ;     genCall
                           1418 ;       Peephole 182   used 16 bit load of dptr
   450D 90 00 64           1419 	mov  dptr,#(((0x00)<<8) + 0x64)
   4510 12 40 C6           1420 	lcall	_czekaj
                           1421 ;Z:\pn\projekt\zegar.c:283: czekaj(100);
                           1422 ;     genCall
                           1423 ;       Peephole 182   used 16 bit load of dptr
   4513 90 00 64           1424 	mov  dptr,#(((0x00)<<8) + 0x64)
   4516 12 40 C6           1425 	lcall	_czekaj
                           1426 ;Z:\pn\projekt\zegar.c:284: czekaj(100);
                           1427 ;     genCall
                           1428 ;       Peephole 182   used 16 bit load of dptr
   4519 90 00 64           1429 	mov  dptr,#(((0x00)<<8) + 0x64)
   451C 12 40 C6           1430 	lcall	_czekaj
                           1431 ;Z:\pn\projekt\zegar.c:286: godz =11;
                           1432 ;     genAssign
   451F E4                 1433 	clr	a
   4520 F5 11              1434 	mov	(_godz + 1),a
   4522 75 10 0B           1435 	mov	_godz,#0x0B
                           1436 ;Z:\pn\projekt\zegar.c:287: min = 30;
                           1437 ;     genAssign
   4525 E4                 1438 	clr	a
   4526 F5 13              1439 	mov	(_min + 1),a
   4528 75 12 1E           1440 	mov	_min,#0x1E
                           1441 ;Z:\pn\projekt\zegar.c:288: sek= 55;
                           1442 ;     genAssign
   452B E4                 1443 	clr	a
   452C F5 15              1444 	mov	(_sek + 1),a
   452E 75 14 37           1445 	mov	_sek,#0x37
                           1446 ;Z:\pn\projekt\zegar.c:290: wyswietl_godz();
                           1447 ;     genCall
   4531 12 42 15           1448 	lcall	_wyswietl_godz
   4534                    1449 00121$:
                           1450 ;Z:\pn\projekt\zegar.c:295: if (alarm_on == 0)
                           1451 ;     genCmpEq
   4534 E5 1A              1452 	mov	a,_alarm_on
   4536 70 04              1453 	jnz	00135$
   4538 E5 1B              1454 	mov	a,(_alarm_on + 1)
                           1455 ;       Peephole 162   removed sjmp by inverse jump logic
   453A 60 03              1456 	jz   00136$
   453C                    1457 00135$:
   453C 02 45 C3           1458 	ljmp	00118$
   453F                    1459 00136$:
                           1460 ;Z:\pn\projekt\zegar.c:298: if (( U12 & 0x01 )== 0 )
                           1461 ;     genAssign
   453F 90 80 00           1462 	mov	dptr,#_U12
   4542 E0                 1463 	movx	a,@dptr
   4543 FA                 1464 	mov	r2,a
                           1465 ;     genAnd
   4544 53 02 01           1466 	anl	ar2,#0x01
                           1467 ;     genCmpEq
                           1468 ;       Peephole 132   changed ljmp to sjmp
                           1469 ;       Peephole 199   optimized misc jump sequence
   4547 BA 00 20           1470 	cjne r2,#0x00,00102$
                           1471 ;00137$:
                           1472 ;       Peephole 200   removed redundant sjmp
   454A                    1473 00138$:
                           1474 ;Z:\pn\projekt\zegar.c:300: godz =(godz +1)%24;
                           1475 ;     genPlus
                           1476 ;     genPlusIncr
   454A 74 01              1477 	mov	a,#0x01
   454C 25 10              1478 	add	a,_godz
   454E FA                 1479 	mov	r2,a
                           1480 ;       Peephole 180   changed mov to clr
   454F E4                 1481 	clr  a
   4550 35 11              1482 	addc	a,(_godz + 1)
   4552 FB                 1483 	mov	r3,a
                           1484 ;     genAssign
   4553 E4                 1485 	clr	a
   4554 F5 26              1486 	mov	(__modsint_PARM_2 + 1),a
   4556 75 25 18           1487 	mov	__modsint_PARM_2,#0x18
                           1488 ;     genCall
   4559 8A 82              1489 	mov	dpl,r2
   455B 8B 83              1490 	mov	dph,r3
   455D 12 46 C2           1491 	lcall	__modsint
   4560 E5 82              1492 	mov	a,dpl
   4562 85 83 F0           1493 	mov	b,dph
                           1494 ;     genAssign
   4565 F5 10              1495 	mov	_godz,a
   4567 85 F0 11           1496 	mov	(_godz + 1),b
   456A                    1497 00102$:
                           1498 ;Z:\pn\projekt\zegar.c:304: if (( U12 & 0x02 )== 0 )
                           1499 ;     genAssign
   456A 90 80 00           1500 	mov	dptr,#_U12
   456D E0                 1501 	movx	a,@dptr
   456E FA                 1502 	mov	r2,a
                           1503 ;     genAnd
   456F 53 02 02           1504 	anl	ar2,#0x02
                           1505 ;     genCmpEq
                           1506 ;       Peephole 132   changed ljmp to sjmp
                           1507 ;       Peephole 199   optimized misc jump sequence
   4572 BA 00 20           1508 	cjne r2,#0x00,00104$
                           1509 ;00139$:
                           1510 ;       Peephole 200   removed redundant sjmp
   4575                    1511 00140$:
                           1512 ;Z:\pn\projekt\zegar.c:306: min = (min +1)%60;
                           1513 ;     genPlus
                           1514 ;     genPlusIncr
   4575 74 01              1515 	mov	a,#0x01
   4577 25 12              1516 	add	a,_min
   4579 FA                 1517 	mov	r2,a
                           1518 ;       Peephole 180   changed mov to clr
   457A E4                 1519 	clr  a
   457B 35 13              1520 	addc	a,(_min + 1)
   457D FB                 1521 	mov	r3,a
                           1522 ;     genAssign
   457E E4                 1523 	clr	a
   457F F5 26              1524 	mov	(__modsint_PARM_2 + 1),a
   4581 75 25 3C           1525 	mov	__modsint_PARM_2,#0x3C
                           1526 ;     genCall
   4584 8A 82              1527 	mov	dpl,r2
   4586 8B 83              1528 	mov	dph,r3
   4588 12 46 C2           1529 	lcall	__modsint
   458B E5 82              1530 	mov	a,dpl
   458D 85 83 F0           1531 	mov	b,dph
                           1532 ;     genAssign
   4590 F5 12              1533 	mov	_min,a
   4592 85 F0 13           1534 	mov	(_min + 1),b
   4595                    1535 00104$:
                           1536 ;Z:\pn\projekt\zegar.c:309: if (( U12 & 0x04 )== 0 )
                           1537 ;     genAssign
   4595 90 80 00           1538 	mov	dptr,#_U12
   4598 E0                 1539 	movx	a,@dptr
   4599 FA                 1540 	mov	r2,a
                           1541 ;     genAnd
   459A 53 02 04           1542 	anl	ar2,#0x04
                           1543 ;     genCmpEq
                           1544 ;       Peephole 132   changed ljmp to sjmp
                           1545 ;       Peephole 199   optimized misc jump sequence
   459D BA 00 05           1546 	cjne r2,#0x00,00106$
                           1547 ;00141$:
                           1548 ;       Peephole 200   removed redundant sjmp
   45A0                    1549 00142$:
                           1550 ;Z:\pn\projekt\zegar.c:312: sek=0;
                           1551 ;     genAssign
   45A0 E4                 1552 	clr	a
   45A1 F5 15              1553 	mov	(_sek + 1),a
   45A3 F5 14              1554 	mov	_sek,a
   45A5                    1555 00106$:
                           1556 ;Z:\pn\projekt\zegar.c:315: if (( U12 & 0x08 )== 0 )
                           1557 ;     genAssign
   45A5 90 80 00           1558 	mov	dptr,#_U12
   45A8 E0                 1559 	movx	a,@dptr
   45A9 FA                 1560 	mov	r2,a
                           1561 ;     genAnd
   45AA 53 02 08           1562 	anl	ar2,#0x08
                           1563 ;     genCmpEq
   45AD BA 00 02           1564 	cjne	r2,#0x00,00143$
   45B0 80 03              1565 	sjmp	00144$
   45B2                    1566 00143$:
   45B2 02 46 3B           1567 	ljmp	00119$
   45B5                    1568 00144$:
                           1569 ;Z:\pn\projekt\zegar.c:317: alarm_on=1;
                           1570 ;     genAssign
   45B5 E4                 1571 	clr	a
   45B6 F5 1B              1572 	mov	(_alarm_on + 1),a
   45B8 75 1A 01           1573 	mov	_alarm_on,#0x01
                           1574 ;Z:\pn\projekt\zegar.c:318: stop = 0;
                           1575 ;     genAssign
   45BB E4                 1576 	clr	a
   45BC F5 1D              1577 	mov	(_stop + 1),a
   45BE F5 1C              1578 	mov	_stop,a
   45C0 02 46 3B           1579 	ljmp	00119$
   45C3                    1580 00118$:
                           1581 ;Z:\pn\projekt\zegar.c:321: else if(alarm_on == 1)
                           1582 ;     genCmpEq
   45C3 E5 1A              1583 	mov	a,_alarm_on
   45C5 B4 01 04           1584 	cjne	a,#0x01,00145$
   45C8 E5 1B              1585 	mov	a,(_alarm_on + 1)
                           1586 ;       Peephole 162   removed sjmp by inverse jump logic
   45CA 60 03              1587 	jz   00146$
   45CC                    1588 00145$:
   45CC 02 46 3B           1589 	ljmp	00119$
   45CF                    1590 00146$:
                           1591 ;Z:\pn\projekt\zegar.c:323: if (( U12 & 0x01 )== 0 )
                           1592 ;     genAssign
   45CF 90 80 00           1593 	mov	dptr,#_U12
   45D2 E0                 1594 	movx	a,@dptr
   45D3 FA                 1595 	mov	r2,a
                           1596 ;     genAnd
   45D4 53 02 01           1597 	anl	ar2,#0x01
                           1598 ;     genCmpEq
                           1599 ;       Peephole 132   changed ljmp to sjmp
                           1600 ;       Peephole 199   optimized misc jump sequence
   45D7 BA 00 20           1601 	cjne r2,#0x00,00110$
                           1602 ;00147$:
                           1603 ;       Peephole 200   removed redundant sjmp
   45DA                    1604 00148$:
                           1605 ;Z:\pn\projekt\zegar.c:325: alarm_godz =(alarm_godz +1)%24;
                           1606 ;     genPlus
                           1607 ;     genPlusIncr
   45DA 74 01              1608 	mov	a,#0x01
   45DC 25 16              1609 	add	a,_alarm_godz
   45DE FA                 1610 	mov	r2,a
                           1611 ;       Peephole 180   changed mov to clr
   45DF E4                 1612 	clr  a
   45E0 35 17              1613 	addc	a,(_alarm_godz + 1)
   45E2 FB                 1614 	mov	r3,a
                           1615 ;     genAssign
   45E3 E4                 1616 	clr	a
   45E4 F5 26              1617 	mov	(__modsint_PARM_2 + 1),a
   45E6 75 25 18           1618 	mov	__modsint_PARM_2,#0x18
                           1619 ;     genCall
   45E9 8A 82              1620 	mov	dpl,r2
   45EB 8B 83              1621 	mov	dph,r3
   45ED 12 46 C2           1622 	lcall	__modsint
   45F0 E5 82              1623 	mov	a,dpl
   45F2 85 83 F0           1624 	mov	b,dph
                           1625 ;     genAssign
   45F5 F5 16              1626 	mov	_alarm_godz,a
   45F7 85 F0 17           1627 	mov	(_alarm_godz + 1),b
   45FA                    1628 00110$:
                           1629 ;Z:\pn\projekt\zegar.c:329: if (( U12 & 0x02 )== 0 )
                           1630 ;     genAssign
   45FA 90 80 00           1631 	mov	dptr,#_U12
   45FD E0                 1632 	movx	a,@dptr
   45FE FA                 1633 	mov	r2,a
                           1634 ;     genAnd
   45FF 53 02 02           1635 	anl	ar2,#0x02
                           1636 ;     genCmpEq
                           1637 ;       Peephole 132   changed ljmp to sjmp
                           1638 ;       Peephole 199   optimized misc jump sequence
   4602 BA 00 20           1639 	cjne r2,#0x00,00112$
                           1640 ;00149$:
                           1641 ;       Peephole 200   removed redundant sjmp
   4605                    1642 00150$:
                           1643 ;Z:\pn\projekt\zegar.c:331: alarm_min = (alarm_min +1)%60;
                           1644 ;     genPlus
                           1645 ;     genPlusIncr
   4605 74 01              1646 	mov	a,#0x01
   4607 25 18              1647 	add	a,_alarm_min
   4609 FA                 1648 	mov	r2,a
                           1649 ;       Peephole 180   changed mov to clr
   460A E4                 1650 	clr  a
   460B 35 19              1651 	addc	a,(_alarm_min + 1)
   460D FB                 1652 	mov	r3,a
                           1653 ;     genAssign
   460E E4                 1654 	clr	a
   460F F5 26              1655 	mov	(__modsint_PARM_2 + 1),a
   4611 75 25 3C           1656 	mov	__modsint_PARM_2,#0x3C
                           1657 ;     genCall
   4614 8A 82              1658 	mov	dpl,r2
   4616 8B 83              1659 	mov	dph,r3
   4618 12 46 C2           1660 	lcall	__modsint
   461B E5 82              1661 	mov	a,dpl
   461D 85 83 F0           1662 	mov	b,dph
                           1663 ;     genAssign
   4620 F5 18              1664 	mov	_alarm_min,a
   4622 85 F0 19           1665 	mov	(_alarm_min + 1),b
   4625                    1666 00112$:
                           1667 ;Z:\pn\projekt\zegar.c:340: if (( U12 & 0x08 )== 0 )
                           1668 ;     genAssign
   4625 90 80 00           1669 	mov	dptr,#_U12
   4628 E0                 1670 	movx	a,@dptr
   4629 FA                 1671 	mov	r2,a
                           1672 ;     genAnd
   462A 53 02 08           1673 	anl	ar2,#0x08
                           1674 ;     genCmpEq
                           1675 ;       Peephole 132   changed ljmp to sjmp
                           1676 ;       Peephole 199   optimized misc jump sequence
   462D BA 00 0B           1677 	cjne r2,#0x00,00119$
                           1678 ;00151$:
                           1679 ;       Peephole 200   removed redundant sjmp
   4630                    1680 00152$:
                           1681 ;Z:\pn\projekt\zegar.c:342: alarm_on=0;
                           1682 ;     genAssign
   4630 E4                 1683 	clr	a
   4631 F5 1B              1684 	mov	(_alarm_on + 1),a
   4633 F5 1A              1685 	mov	_alarm_on,a
                           1686 ;Z:\pn\projekt\zegar.c:343: wyslij_polecenie4(0x01);
                           1687 ;     genCall
   4635 75 82 01           1688 	mov	dpl,#0x01
   4638 12 40 4E           1689 	lcall	_wyslij_polecenie4
   463B                    1690 00119$:
                           1691 ;Z:\pn\projekt\zegar.c:352: wyswietl_godz();
                           1692 ;     genCall
   463B 12 42 15           1693 	lcall	_wyswietl_godz
                           1694 ;Z:\pn\projekt\zegar.c:353: wyswietl_alarm();
                           1695 ;     genCall
   463E 12 44 26           1696 	lcall	_wyswietl_alarm
                           1697 ;Z:\pn\projekt\zegar.c:354: alarm();
                           1698 ;     genCall
   4641 12 43 30           1699 	lcall	_alarm
   4644 02 45 34           1700 	ljmp	00121$
   4647                    1701 00123$:
   4647 22                 1702 	ret
                           1703 	.area CSEG    (CODE)
                           1704 	.area XINIT   (CODE)
