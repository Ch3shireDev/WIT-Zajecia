                              1 ;--------------------------------------------------------
                              2 ; File Created by SDCC : FreeWare ANSI-C Compiler
                              3 ; Version 2.3.3 Tue May 17 10:50:19 2011
                              4 
                              5 ;--------------------------------------------------------
                              6 	.module zad1
                              7 	
                              8 ;--------------------------------------------------------
                              9 ; Public variables in this module
                             10 ;--------------------------------------------------------
                             11 	.globl _kolumna
                             12 	.globl _klawiszZKolumny
                             13 	.globl _main
                             14 	.globl _putchar
                             15 	.globl _init
                             16 	.globl _func_isr
                             17 	.globl _sleep
                             18 	.globl _U10
                             19 	.globl _U12
                             20 	.globl _U15
                             21 	.globl _key_set
                             22 	.globl _t
                             23 	.globl _key
                             24 ;--------------------------------------------------------
                             25 ; special function registers
                             26 ;--------------------------------------------------------
                    00A8     27 _IE	=	0x00a8
                    0089     28 _TMOD	=	0x0089
                    008D     29 _TH1	=	0x008d
                    008B     30 _TL1	=	0x008b
                    0088     31 _TCON	=	0x0088
                    0099     32 _SBUF	=	0x0099
                    0098     33 _SCON	=	0x0098
                    0087     34 _PCON	=	0x0087
                             35 ;--------------------------------------------------------
                             36 ; special function bits 
                             37 ;--------------------------------------------------------
                    0098     38 _RI	=	0x0098
                    0099     39 _TI	=	0x0099
                             40 ;--------------------------------------------------------
                             41 ; overlayable register banks 
                             42 ;--------------------------------------------------------
                             43 	.area REG_BANK_0	(REL,OVR,DATA)
   0000                      44 	.ds 8
                             45 ;--------------------------------------------------------
                             46 ; internal ram data
                             47 ;--------------------------------------------------------
                             48 	.area DSEG    (DATA)
   0008                      49 _key::
   0008                      50 	.ds 2
   000A                      51 _t::
   000A                      52 	.ds 2
   000C                      53 _key_set::
   000C                      54 	.ds 2
                             55 ;--------------------------------------------------------
                             56 ; overlayable items in internal ram 
                             57 ;--------------------------------------------------------
                             58 	.area	OSEG    (OVR,DATA)
                             59 	.area	OSEG    (OVR,DATA)
                             60 ;--------------------------------------------------------
                             61 ; Stack segment in internal ram 
                             62 ;--------------------------------------------------------
                             63 	.area	SSEG	(DATA)
   0010                      64 __start__stack:
   0010                      65 	.ds	1
                             66 
                             67 ;--------------------------------------------------------
                             68 ; indirectly addressable internal ram data
                             69 ;--------------------------------------------------------
                             70 	.area ISEG    (DATA)
                             71 ;--------------------------------------------------------
                             72 ; bit data
                             73 ;--------------------------------------------------------
                             74 	.area BSEG    (BIT)
                             75 ;--------------------------------------------------------
                             76 ; external ram data
                             77 ;--------------------------------------------------------
                             78 	.area XSEG    (XDATA)
                    8000     79 _U15	=	0x8000
                    8000     80 _U12	=	0x8000
                    FFFF     81 _U10	=	0xffff
                             82 ;--------------------------------------------------------
                             83 ; external initialized ram data
                             84 ;--------------------------------------------------------
                             85 	.area XISEG   (XDATA)
                             86 ;--------------------------------------------------------
                             87 ; interrupt vector 
                             88 ;--------------------------------------------------------
                             89 	.area CSEG    (CODE)
   4000                      90 __interrupt_vect:
   4000 02 42 D4             91 	ljmp	__sdcc_gsinit_startup
   4003 32                   92 	reti
   4004                      93 	.ds	7
   400B 32                   94 	reti
   400C                      95 	.ds	7
   4013 32                   96 	reti
   4014                      97 	.ds	7
   401B 02 40 57             98 	ljmp	_func_isr
   401E                      99 	.ds	5
   4023 32                  100 	reti
   4024                     101 	.ds	7
   402B 32                  102 	reti
   402C                     103 	.ds	7
                            104 ;--------------------------------------------------------
                            105 ; global & static initialisations
                            106 ;--------------------------------------------------------
                            107 	.area GSINIT  (CODE)
                            108 	.area GSFINAL (CODE)
                            109 	.area GSINIT  (CODE)
   42D4                     110 __sdcc_gsinit_startup:
   42D4 75 81 0F            111 	mov	sp,#__start__stack - 1
   42D7 12 42 4B            112 	lcall	__sdcc_external_startup
   42DA E5 82               113 	mov	a,dpl
   42DC 60 03               114 	jz	__sdcc_init_data
   42DE 02 40 33            115 	ljmp	__sdcc_program_startup
   42E1                     116 __sdcc_init_data:
                            117 ;	_mcs51_genXINIT() start
   42E1 74 00               118 	mov	a,#l_XINIT
   42E3 44 00               119 	orl	a,#l_XINIT>>8
   42E5 60 29               120 	jz	00003$
   42E7 74 23               121 	mov	a,#s_XINIT
   42E9 24 00               122 	add	a,#l_XINIT
   42EB F9                  123 	mov	r1,a
   42EC 74 43               124 	mov	a,#s_XINIT>>8
   42EE 34 00               125 	addc	a,#l_XINIT>>8
   42F0 FA                  126 	mov	r2,a
   42F1 90 43 23            127 	mov	dptr,#s_XINIT
   42F4 78 00               128 	mov	r0,#s_XISEG
   42F6 75 A0 00            129 	mov	p2,#(s_XISEG >> 8)
   42F9 E4                  130 00001$:	clr	a
   42FA 93                  131 	movc	a,@a+dptr
   42FB F2                  132 	movx	@r0,a
   42FC A3                  133 	inc	dptr
   42FD 08                  134 	inc	r0
   42FE B8 00 02            135 	cjne	r0,#0,00002$
   4301 05 A0               136 	inc	p2
   4303 E5 82               137 00002$:	mov	a,dpl
   4305 B5 01 F1            138 	cjne	a,ar1,00001$
   4308 E5 83               139 	mov	a,dph
   430A B5 02 EC            140 	cjne	a,ar2,00001$
   430D 75 A0 FF            141 	mov	p2,#0xFF
   4310                     142 00003$:
                            143 ;	_mcs51_genXINIT() end
                            144 ;Z:\pn\z4\zad1.c:18: int key =-1;		//zmienna do przekazywania, ktory guzik zostal wcisniety
                            145 ;     genAssign
   4310 75 08 FF            146 	mov	_key,#0xFF
   4313 75 09 FF            147 	mov	(_key + 1),#0xFF
                            148 ;Z:\pn\z4\zad1.c:19: int t = 0;			//zmienna do iterowania kolumn
                            149 ;     genAssign
   4316 E4                  150 	clr	a
   4317 F5 0B               151 	mov	(_t + 1),a
   4319 F5 0A               152 	mov	_t,a
                            153 ;Z:\pn\z4\zad1.c:20: int key_set = 0;	//zmienna informujaca, o tym, ze wcisniety klawisz zostal przetworzony
                            154 ;     genAssign
   431B E4                  155 	clr	a
   431C F5 0D               156 	mov	(_key_set + 1),a
   431E F5 0C               157 	mov	_key_set,a
                            158 	.area GSFINAL (CODE)
   4320 02 40 33            159 	ljmp	__sdcc_program_startup
                            160 ;--------------------------------------------------------
                            161 ; Home
                            162 ;--------------------------------------------------------
                            163 	.area HOME    (CODE)
                            164 	.area CSEG    (CODE)
                            165 ;--------------------------------------------------------
                            166 ; code
                            167 ;--------------------------------------------------------
                            168 	.area CSEG    (CODE)
   4033                     169 __sdcc_program_startup:
   4033 12 41 94            170 	lcall	_main
                            171 ;	return from main will lock up
   4036 80 FE               172 	sjmp .
                            173 ;------------------------------------------------------------
                            174 ;Allocation info for local variables in function 'sleep'
                            175 ;------------------------------------------------------------
                            176 ;------------------------------------------------------------
                            177 ;Z:\pn\z4\zad1.c:23: void sleep(int d){
                            178 ;	-----------------------------------------
                            179 ;	 function sleep
                            180 ;	-----------------------------------------
   4038                     181 _sleep:
                    0002    182 	ar2 = 0x02
                    0003    183 	ar3 = 0x03
                    0004    184 	ar4 = 0x04
                    0005    185 	ar5 = 0x05
                    0006    186 	ar6 = 0x06
                    0007    187 	ar7 = 0x07
                    0000    188 	ar0 = 0x00
                    0001    189 	ar1 = 0x01
                            190 ;     genReceive
   4038 AA 82               191 	mov	r2,dpl
   403A AB 83               192 	mov	r3,dph
                            193 ;Z:\pn\z4\zad1.c:25: for(i=0; i<d; i++);
                            194 ;     genAssign
   403C 7C 00               195 	mov	r4,#0x00
   403E 7D 00               196 	mov	r5,#0x00
   4040                     197 00101$:
                            198 ;     genCmpLt
                            199 ;     genCmp
   4040 C3                  200 	clr	c
   4041 EC                  201 	mov	a,r4
   4042 9A                  202 	subb	a,r2
   4043 ED                  203 	mov	a,r5
   4044 64 80               204 	xrl	a,#0x80
   4046 8B F0               205 	mov	b,r3
   4048 63 F0 80            206 	xrl	b,#0x80
   404B 95 F0               207 	subb	a,b
                            208 ;     genIfxJump
                            209 ;       Peephole 108   removed ljmp by inverse jump logic
   404D 50 07               210 	jnc  00105$
   404F                     211 00109$:
                            212 ;     genPlus
                            213 ;     genPlusIncr
                            214 ;	tail increment optimized
   404F 0C                  215 	inc	r4
   4050 BC 00 ED            216 	cjne	r4,#0x00,00101$
   4053 0D                  217 	inc	r5
                            218 ;       Peephole 132   changed ljmp to sjmp
   4054 80 EA               219 	sjmp 00101$
   4056                     220 00105$:
   4056 22                  221 	ret
                            222 ;------------------------------------------------------------
                            223 ;Allocation info for local variables in function 'func_isr'
                            224 ;------------------------------------------------------------
                            225 ;------------------------------------------------------------
                            226 ;Z:\pn\z4\zad1.c:28: void func_isr (void) interrupt 3
                            227 ;	-----------------------------------------
                            228 ;	 function func_isr
                            229 ;	-----------------------------------------
   4057                     230 _func_isr:
   4057 C0 E0               231 	push	acc
   4059 C0 F0               232 	push	b
   405B C0 82               233 	push	dpl
   405D C0 83               234 	push	dph
   405F C0 02               235 	push	ar2
   4061 C0 03               236 	push	ar3
   4063 C0 04               237 	push	ar4
   4065 C0 D0               238 	push	psw
   4067 75 D0 00            239 	mov	psw,#0x00
                            240 ;Z:\pn\z4\zad1.c:33: U15 = kolumna[t];
                            241 ;     genPlus
   406A E5 0A               242 	mov	a,_t
   406C 24 47               243 	add	a,#_kolumna
   406E F5 82               244 	mov	dpl,a
   4070 E5 0B               245 	mov	a,(_t + 1)
   4072 34 42               246 	addc	a,#(_kolumna >> 8)
   4074 F5 83               247 	mov	dph,a
                            248 ;     genPointerGet
                            249 ;     genCodePointerGet
   4076 E4                  250 	clr	a
   4077 93                  251 	movc	a,@a+dptr
                            252 ;     genAssign
                            253 ;       Peephole 100   removed redundant mov
   4078 FA                  254 	mov  r2,a
   4079 90 80 00            255 	mov  dptr,#_U15
   407C F0                  256 	movx @dptr,a
                            257 ;Z:\pn\z4\zad1.c:35: if (((U12 & 0xf0) == klawiszZKolumny[2])&& key_set == 0 && t == 2) 
                            258 ;     genAssign
   407D 90 80 00            259 	mov	dptr,#_U12
   4080 E0                  260 	movx	a,@dptr
   4081 FA                  261 	mov	r2,a
                            262 ;     genAnd
   4082 53 02 F0            263 	anl	ar2,#0xF0
                            264 ;     genPointerGet
                            265 ;     genCodePointerGet
   4085 90 42 45            266 	mov	dptr,#(_klawiszZKolumny + 0x0002)
   4088 E4                  267 	clr	a
   4089 93                  268 	movc	a,@a+dptr
   408A FB                  269 	mov	r3,a
                            270 ;     genCmpEq
   408B EA                  271 	mov	a,r2
                            272 ;       Peephole 132   changed ljmp to sjmp
                            273 ;       Peephole 199   optimized misc jump sequence
   408C B5 03 21            274 	cjne a,ar3,00102$
                            275 ;00131$:
                            276 ;       Peephole 200   removed redundant sjmp
   408F                     277 00132$:
                            278 ;     genCmpEq
   408F E5 0C               279 	mov	a,_key_set
   4091 70 04               280 	jnz	00133$
   4093 E5 0D               281 	mov	a,(_key_set + 1)
                            282 ;       Peephole 162   removed sjmp by inverse jump logic
   4095 60 02               283 	jz   00134$
   4097                     284 00133$:
                            285 ;       Peephole 132   changed ljmp to sjmp
   4097 80 17               286 	sjmp 00102$
   4099                     287 00134$:
                            288 ;     genCmpEq
   4099 E5 0A               289 	mov	a,_t
   409B B4 02 04            290 	cjne	a,#0x02,00135$
   409E E5 0B               291 	mov	a,(_t + 1)
                            292 ;       Peephole 162   removed sjmp by inverse jump logic
   40A0 60 02               293 	jz   00136$
   40A2                     294 00135$:
                            295 ;       Peephole 132   changed ljmp to sjmp
   40A2 80 0C               296 	sjmp 00102$
   40A4                     297 00136$:
                            298 ;Z:\pn\z4\zad1.c:37: key =3;
                            299 ;     genAssign
   40A4 E4                  300 	clr	a
   40A5 F5 09               301 	mov	(_key + 1),a
   40A7 75 08 03            302 	mov	_key,#0x03
                            303 ;Z:\pn\z4\zad1.c:38: key_set = 1;
                            304 ;     genAssign
   40AA E4                  305 	clr	a
   40AB F5 0D               306 	mov	(_key_set + 1),a
   40AD 75 0C 01            307 	mov	_key_set,#0x01
   40B0                     308 00102$:
                            309 ;Z:\pn\z4\zad1.c:41: if (((U12 & 0xf0) == klawiszZKolumny[3]) && key_set == 0 && t == 2) 
                            310 ;     genAssign
   40B0 90 80 00            311 	mov	dptr,#_U12
   40B3 E0                  312 	movx	a,@dptr
   40B4 FA                  313 	mov	r2,a
                            314 ;     genAnd
   40B5 53 02 F0            315 	anl	ar2,#0xF0
                            316 ;     genPointerGet
                            317 ;     genCodePointerGet
   40B8 90 42 46            318 	mov	dptr,#(_klawiszZKolumny + 0x0003)
   40BB E4                  319 	clr	a
   40BC 93                  320 	movc	a,@a+dptr
   40BD FC                  321 	mov	r4,a
                            322 ;     genCmpEq
   40BE EA                  323 	mov	a,r2
                            324 ;       Peephole 132   changed ljmp to sjmp
                            325 ;       Peephole 199   optimized misc jump sequence
   40BF B5 04 21            326 	cjne a,ar4,00106$
                            327 ;00137$:
                            328 ;       Peephole 200   removed redundant sjmp
   40C2                     329 00138$:
                            330 ;     genCmpEq
   40C2 E5 0C               331 	mov	a,_key_set
   40C4 70 04               332 	jnz	00139$
   40C6 E5 0D               333 	mov	a,(_key_set + 1)
                            334 ;       Peephole 162   removed sjmp by inverse jump logic
   40C8 60 02               335 	jz   00140$
   40CA                     336 00139$:
                            337 ;       Peephole 132   changed ljmp to sjmp
   40CA 80 17               338 	sjmp 00106$
   40CC                     339 00140$:
                            340 ;     genCmpEq
   40CC E5 0A               341 	mov	a,_t
   40CE B4 02 04            342 	cjne	a,#0x02,00141$
   40D1 E5 0B               343 	mov	a,(_t + 1)
                            344 ;       Peephole 162   removed sjmp by inverse jump logic
   40D3 60 02               345 	jz   00142$
   40D5                     346 00141$:
                            347 ;       Peephole 132   changed ljmp to sjmp
   40D5 80 0C               348 	sjmp 00106$
   40D7                     349 00142$:
                            350 ;Z:\pn\z4\zad1.c:43: key =1;
                            351 ;     genAssign
   40D7 E4                  352 	clr	a
   40D8 F5 09               353 	mov	(_key + 1),a
   40DA 75 08 01            354 	mov	_key,#0x01
                            355 ;Z:\pn\z4\zad1.c:44: key_set = 1;
                            356 ;     genAssign
   40DD E4                  357 	clr	a
   40DE F5 0D               358 	mov	(_key_set + 1),a
   40E0 75 0C 01            359 	mov	_key_set,#0x01
   40E3                     360 00106$:
                            361 ;Z:\pn\z4\zad1.c:46: if (((U12 & 0xf0) == klawiszZKolumny[2])&& key_set == 0 && t == 3) 
                            362 ;     genAssign
   40E3 90 80 00            363 	mov	dptr,#_U12
   40E6 E0                  364 	movx	a,@dptr
                            365 ;     genAnd
                            366 ;     genCmpEq
                            367 ;       Peephole 139   removed redundant mov
   40E7 54 F0               368 	anl  a,#0xF0
   40E9 FA                  369 	mov  r2,a
                            370 ;       Peephole 132   changed ljmp to sjmp
                            371 ;       Peephole 199   optimized misc jump sequence
   40EA B5 03 21            372 	cjne a,ar3,00110$
                            373 ;00143$:
                            374 ;       Peephole 200   removed redundant sjmp
   40ED                     375 00144$:
                            376 ;     genCmpEq
   40ED E5 0C               377 	mov	a,_key_set
   40EF 70 04               378 	jnz	00145$
   40F1 E5 0D               379 	mov	a,(_key_set + 1)
                            380 ;       Peephole 162   removed sjmp by inverse jump logic
   40F3 60 02               381 	jz   00146$
   40F5                     382 00145$:
                            383 ;       Peephole 132   changed ljmp to sjmp
   40F5 80 17               384 	sjmp 00110$
   40F7                     385 00146$:
                            386 ;     genCmpEq
   40F7 E5 0A               387 	mov	a,_t
   40F9 B4 03 04            388 	cjne	a,#0x03,00147$
   40FC E5 0B               389 	mov	a,(_t + 1)
                            390 ;       Peephole 162   removed sjmp by inverse jump logic
   40FE 60 02               391 	jz   00148$
   4100                     392 00147$:
                            393 ;       Peephole 132   changed ljmp to sjmp
   4100 80 0C               394 	sjmp 00110$
   4102                     395 00148$:
                            396 ;Z:\pn\z4\zad1.c:48: key =2;
                            397 ;     genAssign
   4102 E4                  398 	clr	a
   4103 F5 09               399 	mov	(_key + 1),a
   4105 75 08 02            400 	mov	_key,#0x02
                            401 ;Z:\pn\z4\zad1.c:49: key_set = 1;
                            402 ;     genAssign
   4108 E4                  403 	clr	a
   4109 F5 0D               404 	mov	(_key_set + 1),a
   410B 75 0C 01            405 	mov	_key_set,#0x01
   410E                     406 00110$:
                            407 ;Z:\pn\z4\zad1.c:52: if (((U12 & 0xf0) == klawiszZKolumny[3])&& key_set == 0 && t == 3)  
                            408 ;     genAssign
   410E 90 80 00            409 	mov	dptr,#_U12
   4111 E0                  410 	movx	a,@dptr
                            411 ;     genAnd
                            412 ;     genCmpEq
                            413 ;       Peephole 139   removed redundant mov
   4112 54 F0               414 	anl  a,#0xF0
   4114 FA                  415 	mov  r2,a
                            416 ;       Peephole 132   changed ljmp to sjmp
                            417 ;       Peephole 199   optimized misc jump sequence
   4115 B5 04 20            418 	cjne a,ar4,00114$
                            419 ;00149$:
                            420 ;       Peephole 200   removed redundant sjmp
   4118                     421 00150$:
                            422 ;     genCmpEq
   4118 E5 0C               423 	mov	a,_key_set
   411A 70 04               424 	jnz	00151$
   411C E5 0D               425 	mov	a,(_key_set + 1)
                            426 ;       Peephole 162   removed sjmp by inverse jump logic
   411E 60 02               427 	jz   00152$
   4120                     428 00151$:
                            429 ;       Peephole 132   changed ljmp to sjmp
   4120 80 16               430 	sjmp 00114$
   4122                     431 00152$:
                            432 ;     genCmpEq
   4122 E5 0A               433 	mov	a,_t
   4124 B4 03 04            434 	cjne	a,#0x03,00153$
   4127 E5 0B               435 	mov	a,(_t + 1)
                            436 ;       Peephole 162   removed sjmp by inverse jump logic
   4129 60 02               437 	jz   00154$
   412B                     438 00153$:
                            439 ;       Peephole 132   changed ljmp to sjmp
   412B 80 0B               440 	sjmp 00114$
   412D                     441 00154$:
                            442 ;Z:\pn\z4\zad1.c:54: key =0;
                            443 ;     genAssign
   412D E4                  444 	clr	a
   412E F5 09               445 	mov	(_key + 1),a
   4130 F5 08               446 	mov	_key,a
                            447 ;Z:\pn\z4\zad1.c:55: key_set = 1;
                            448 ;     genAssign
   4132 E4                  449 	clr	a
   4133 F5 0D               450 	mov	(_key_set + 1),a
   4135 75 0C 01            451 	mov	_key_set,#0x01
   4138                     452 00114$:
                            453 ;Z:\pn\z4\zad1.c:58: t++;
                            454 ;     genPlus
                            455 ;     genPlusIncr
   4138 74 01               456 	mov	a,#0x01
   413A 25 0A               457 	add	a,_t
   413C F5 0A               458 	mov	_t,a
                            459 ;       Peephole 180   changed mov to clr
   413E E4                  460 	clr  a
   413F 35 0B               461 	addc	a,(_t + 1)
   4141 F5 0B               462 	mov	(_t + 1),a
                            463 ;Z:\pn\z4\zad1.c:60: t=t%4;
                            464 ;     genAssign
   4143 E4                  465 	clr	a
   4144 F5 0F               466 	mov	(__modsint_PARM_2 + 1),a
   4146 75 0E 04            467 	mov	__modsint_PARM_2,#0x04
                            468 ;     genCall
   4149 85 0A 82            469 	mov	dpl,_t
   414C 85 0B 83            470 	mov	dph,(_t + 1)
   414F 12 42 9C            471 	lcall	__modsint
   4152 E5 82               472 	mov	a,dpl
   4154 85 83 F0            473 	mov	b,dph
                            474 ;     genAssign
   4157 F5 0A               475 	mov	_t,a
   4159 85 F0 0B            476 	mov	(_t + 1),b
   415C                     477 00117$:
   415C D0 D0               478 	pop	psw
   415E D0 04               479 	pop	ar4
   4160 D0 03               480 	pop	ar3
   4162 D0 02               481 	pop	ar2
   4164 D0 83               482 	pop	dph
   4166 D0 82               483 	pop	dpl
   4168 D0 F0               484 	pop	b
   416A D0 E0               485 	pop	acc
   416C 32                  486 	reti
                            487 ;------------------------------------------------------------
                            488 ;Allocation info for local variables in function 'init'
                            489 ;------------------------------------------------------------
                            490 ;------------------------------------------------------------
                            491 ;Z:\pn\z4\zad1.c:67: void init(void)
                            492 ;	-----------------------------------------
                            493 ;	 function init
                            494 ;	-----------------------------------------
   416D                     495 _init:
                            496 ;Z:\pn\z4\zad1.c:70: SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
                            497 ;     genAssign
   416D 75 98 50            498 	mov	_SCON,#0x50
                            499 ;Z:\pn\z4\zad1.c:72: TMOD &=	0x0F;	//konfiguracja licznika
                            500 ;     genAnd
   4170 53 89 0F            501 	anl	_TMOD,#0x0F
                            502 ;Z:\pn\z4\zad1.c:73: TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
                            503 ;     genOr
   4173 43 89 20            504 	orl	_TMOD,#0x20
                            505 ;Z:\pn\z4\zad1.c:75: TH1 = TL1 =253;     //Wartosc startowa
                            506 ;     genAssign
   4176 75 8B FD            507 	mov	_TL1,#0xFD
                            508 ;     genAssign
   4179 75 8D FD            509 	mov	_TH1,#0xFD
                            510 ;Z:\pn\z4\zad1.c:76: TCON = 0x40;
                            511 ;     genAssign
   417C 75 88 40            512 	mov	_TCON,#0x40
                            513 ;Z:\pn\z4\zad1.c:77: PCON = 0x80;
                            514 ;     genAssign
   417F 75 87 80            515 	mov	_PCON,#0x80
                            516 ;Z:\pn\z4\zad1.c:78: IE =	0x88;
                            517 ;     genAssign
   4182 75 A8 88            518 	mov	_IE,#0x88
   4185                     519 00101$:
   4185 22                  520 	ret
                            521 ;------------------------------------------------------------
                            522 ;Allocation info for local variables in function 'putchar'
                            523 ;------------------------------------------------------------
                            524 ;------------------------------------------------------------
                            525 ;Z:\pn\z4\zad1.c:84: void putchar(char znak)
                            526 ;	-----------------------------------------
                            527 ;	 function putchar
                            528 ;	-----------------------------------------
   4186                     529 _putchar:
                            530 ;     genReceive
   4186 85 82 99            531 	mov	_SBUF,dpl
                            532 ;Z:\pn\z4\zad1.c:87: while(TI==0);
   4189                     533 00101$:
                            534 ;     genNot
   4189 A2 99               535 	mov	c,_TI
   418B B3                  536 	cpl	c
   418C E4                  537 	clr	a
   418D 33                  538 	rlc	a
                            539 ;     genIfx
                            540 ;       Peephole 105   removed redundant mov
   418E FA                  541 	mov  r2,a
                            542 ;     genIfxJump
                            543 ;       Peephole 109   removed ljmp by inverse jump logic
   418F 70 F8               544 	jnz  00101$
   4191                     545 00108$:
                            546 ;Z:\pn\z4\zad1.c:88: TI=0;
                            547 ;     genAssign
   4191 C2 99               548 	clr	_TI
   4193                     549 00104$:
   4193 22                  550 	ret
                            551 ;------------------------------------------------------------
                            552 ;Allocation info for local variables in function 'main'
                            553 ;------------------------------------------------------------
                            554 ;------------------------------------------------------------
                            555 ;Z:\pn\z4\zad1.c:91: main (void){
                            556 ;	-----------------------------------------
                            557 ;	 function main
                            558 ;	-----------------------------------------
   4194                     559 _main:
                            560 ;Z:\pn\z4\zad1.c:92: init();
                            561 ;     genCall
   4194 12 41 6D            562 	lcall	_init
   4197                     563 00108$:
                            564 ;Z:\pn\z4\zad1.c:96: switch(key){
                            565 ;     genCmpLt
                            566 ;     genCmp
   4197 E5 09               567 	mov	a,(_key + 1)
                            568 ;     genIfxJump
                            569 ;       Peephole 112   removed ljmp by inverse jump logic
   4199 20 E7 FB            570 	jb   acc.7,00108$
   419C                     571 00115$:
                            572 ;     genCmpGt
                            573 ;     genCmp
   419C C3                  574 	clr	c
   419D 74 03               575 	mov	a,#0x03
   419F 95 08               576 	subb	a,_key
                            577 ;       Peephole 159   avoided xrl during execution
   41A1 74 80               578 	mov  a,#(0x00 ^ 0x80)
   41A3 85 09 F0            579 	mov	b,(_key + 1)
   41A6 63 F0 80            580 	xrl	b,#0x80
   41A9 95 F0               581 	subb	a,b
                            582 ;     genIfxJump
                            583 ;       Peephole 132   changed ljmp to sjmp
                            584 ;       Peephole 160   removed sjmp by inverse jump logic
   41AB 40 EA               585 	jc   00108$
   41AD                     586 00116$:
                            587 ;     genJumpTab
   41AD E5 08               588 	mov	a,_key
   41AF 25 E0               589 	add	a,acc
   41B1 25 08               590 	add	a,_key
   41B3 90 41 B7            591 	mov	dptr,#00117$
   41B6 73                  592 	jmp	@a+dptr
   41B7                     593 00117$:
   41B7 02 41 C3            594 	ljmp	00101$
   41BA 02 41 E2            595 	ljmp	00102$
   41BD 02 42 02            596 	ljmp	00103$
   41C0 02 42 22            597 	ljmp	00104$
                            598 ;Z:\pn\z4\zad1.c:99: putchar('A');
   41C3                     599 00101$:
                            600 ;     genCall
   41C3 75 82 41            601 	mov	dpl,#0x41
   41C6 12 41 86            602 	lcall	_putchar
                            603 ;Z:\pn\z4\zad1.c:100: putchar(' ');
                            604 ;     genCall
   41C9 75 82 20            605 	mov	dpl,#0x20
   41CC 12 41 86            606 	lcall	_putchar
                            607 ;Z:\pn\z4\zad1.c:101: key = -1;
                            608 ;     genAssign
   41CF 75 08 FF            609 	mov	_key,#0xFF
   41D2 75 09 FF            610 	mov	(_key + 1),#0xFF
                            611 ;Z:\pn\z4\zad1.c:102: sleep(40);
                            612 ;     genCall
                            613 ;       Peephole 182   used 16 bit load of dptr
   41D5 90 00 28            614 	mov  dptr,#(((0x00)<<8) + 0x28)
   41D8 12 40 38            615 	lcall	_sleep
                            616 ;Z:\pn\z4\zad1.c:103: key_set = 0;
                            617 ;     genAssign
   41DB E4                  618 	clr	a
   41DC F5 0D               619 	mov	(_key_set + 1),a
   41DE F5 0C               620 	mov	_key_set,a
                            621 ;Z:\pn\z4\zad1.c:104: break;
                            622 ;Z:\pn\z4\zad1.c:108: putchar('B');
                            623 ;       Peephole 132   changed ljmp to sjmp
   41E0 80 B5               624 	sjmp 00108$
   41E2                     625 00102$:
                            626 ;     genCall
   41E2 75 82 42            627 	mov	dpl,#0x42
   41E5 12 41 86            628 	lcall	_putchar
                            629 ;Z:\pn\z4\zad1.c:109: putchar(' ');
                            630 ;     genCall
   41E8 75 82 20            631 	mov	dpl,#0x20
   41EB 12 41 86            632 	lcall	_putchar
                            633 ;Z:\pn\z4\zad1.c:110: key = -1;
                            634 ;     genAssign
   41EE 75 08 FF            635 	mov	_key,#0xFF
   41F1 75 09 FF            636 	mov	(_key + 1),#0xFF
                            637 ;Z:\pn\z4\zad1.c:111: sleep(40);
                            638 ;     genCall
                            639 ;       Peephole 182   used 16 bit load of dptr
   41F4 90 00 28            640 	mov  dptr,#(((0x00)<<8) + 0x28)
   41F7 12 40 38            641 	lcall	_sleep
                            642 ;Z:\pn\z4\zad1.c:112: key_set = 0;
                            643 ;     genAssign
   41FA E4                  644 	clr	a
   41FB F5 0D               645 	mov	(_key_set + 1),a
   41FD F5 0C               646 	mov	_key_set,a
                            647 ;Z:\pn\z4\zad1.c:113: break;
   41FF 02 41 97            648 	ljmp	00108$
                            649 ;Z:\pn\z4\zad1.c:116: putchar('C');
   4202                     650 00103$:
                            651 ;     genCall
   4202 75 82 43            652 	mov	dpl,#0x43
   4205 12 41 86            653 	lcall	_putchar
                            654 ;Z:\pn\z4\zad1.c:117: putchar(' ');
                            655 ;     genCall
   4208 75 82 20            656 	mov	dpl,#0x20
   420B 12 41 86            657 	lcall	_putchar
                            658 ;Z:\pn\z4\zad1.c:118: key = -1;
                            659 ;     genAssign
   420E 75 08 FF            660 	mov	_key,#0xFF
   4211 75 09 FF            661 	mov	(_key + 1),#0xFF
                            662 ;Z:\pn\z4\zad1.c:119: sleep(40);
                            663 ;     genCall
                            664 ;       Peephole 182   used 16 bit load of dptr
   4214 90 00 28            665 	mov  dptr,#(((0x00)<<8) + 0x28)
   4217 12 40 38            666 	lcall	_sleep
                            667 ;Z:\pn\z4\zad1.c:120: key_set = 0;
                            668 ;     genAssign
   421A E4                  669 	clr	a
   421B F5 0D               670 	mov	(_key_set + 1),a
   421D F5 0C               671 	mov	_key_set,a
                            672 ;Z:\pn\z4\zad1.c:122: break;
   421F 02 41 97            673 	ljmp	00108$
                            674 ;Z:\pn\z4\zad1.c:125: putchar('D');
   4222                     675 00104$:
                            676 ;     genCall
   4222 75 82 44            677 	mov	dpl,#0x44
   4225 12 41 86            678 	lcall	_putchar
                            679 ;Z:\pn\z4\zad1.c:126: putchar(' ');
                            680 ;     genCall
   4228 75 82 20            681 	mov	dpl,#0x20
   422B 12 41 86            682 	lcall	_putchar
                            683 ;Z:\pn\z4\zad1.c:127: key = -1;
                            684 ;     genAssign
   422E 75 08 FF            685 	mov	_key,#0xFF
   4231 75 09 FF            686 	mov	(_key + 1),#0xFF
                            687 ;Z:\pn\z4\zad1.c:128: sleep(40);
                            688 ;     genCall
                            689 ;       Peephole 182   used 16 bit load of dptr
   4234 90 00 28            690 	mov  dptr,#(((0x00)<<8) + 0x28)
   4237 12 40 38            691 	lcall	_sleep
                            692 ;Z:\pn\z4\zad1.c:129: key_set = 0;
                            693 ;     genAssign
   423A E4                  694 	clr	a
   423B F5 0D               695 	mov	(_key_set + 1),a
   423D F5 0C               696 	mov	_key_set,a
                            697 ;Z:\pn\z4\zad1.c:130: break;
   423F 02 41 97            698 	ljmp	00108$
                            699 ;Z:\pn\z4\zad1.c:134: }
   4242                     700 00110$:
   4242 22                  701 	ret
                            702 	.area CSEG    (CODE)
   4243                     703 _klawiszZKolumny:
   4243 D0                  704 	.db #0xD0
   4244 E0                  705 	.db #0xE0
   4245 70                  706 	.db #0x70
   4246 B0                  707 	.db #0xB0
   4247                     708 _kolumna:
   4247 FD                  709 	.db #0xFD
   4248 FE                  710 	.db #0xFE
   4249 F7                  711 	.db #0xF7
   424A FB                  712 	.db #0xFB
                            713 	.area XINIT   (CODE)
