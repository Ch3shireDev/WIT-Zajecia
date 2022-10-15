;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Tue May 17 12:43:17 2011

;--------------------------------------------------------
	.module zad1
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _main
	.globl _wyswietl_iloczyn
	.globl _gotoXY
	.globl _init
	.globl _czekaj
	.globl _wyslij_dane
	.globl _wyslij_polecenie4
	.globl _wyslij_polecenie8
	.globl _wyswietl_iloczyn_PARM_2
	.globl _cyfry
	.globl _j
	.globl _i
	.globl _gotoXY_PARM_2
	.globl _produkt
	.globl _RS
	.globl _E
;--------------------------------------------------------
; special function registers
;--------------------------------------------------------
_P1	=	0x0090
;--------------------------------------------------------
; special function bits 
;--------------------------------------------------------
;--------------------------------------------------------
; overlayable register banks 
;--------------------------------------------------------
	.area REG_BANK_0	(REL,OVR,DATA)
	.ds 8
;--------------------------------------------------------
; internal ram data
;--------------------------------------------------------
	.area DSEG    (DATA)
_E::
	.ds 1
_RS::
	.ds 1
_produkt::
	.ds 6
_gotoXY_PARM_2::
	.ds 1
_i::
	.ds 2
_j::
	.ds 2
_cyfry::
	.ds 2
_wyswietl_iloczyn_PARM_2::
	.ds 2
_wyswietl_iloczyn_iloczyn_1_1::
	.ds 2
;--------------------------------------------------------
; overlayable items in internal ram 
;--------------------------------------------------------
	.area	OSEG    (OVR,DATA)
	.area	OSEG    (OVR,DATA)
	.area	OSEG    (OVR,DATA)
	.area	OSEG    (OVR,DATA)
;--------------------------------------------------------
; Stack segment in internal ram 
;--------------------------------------------------------
	.area	SSEG	(DATA)
__start__stack:
	.ds	1

;--------------------------------------------------------
; indirectly addressable internal ram data
;--------------------------------------------------------
	.area ISEG    (DATA)
;--------------------------------------------------------
; bit data
;--------------------------------------------------------
	.area BSEG    (BIT)
;--------------------------------------------------------
; external ram data
;--------------------------------------------------------
	.area XSEG    (XDATA)
;--------------------------------------------------------
; external initialized ram data
;--------------------------------------------------------
	.area XISEG   (XDATA)
;--------------------------------------------------------
; interrupt vector 
;--------------------------------------------------------
	.area CSEG    (CODE)
__interrupt_vect:
	ljmp	__sdcc_gsinit_startup
	reti
	.ds	7
	reti
	.ds	7
	reti
	.ds	7
	reti
	.ds	7
	reti
	.ds	7
	reti
	.ds	7
;--------------------------------------------------------
; global & static initialisations
;--------------------------------------------------------
	.area GSINIT  (CODE)
	.area GSFINAL (CODE)
	.area GSINIT  (CODE)
__sdcc_gsinit_startup:
	mov	sp,#__start__stack - 1
	lcall	__sdcc_external_startup
	mov	a,dpl
	jz	__sdcc_init_data
	ljmp	__sdcc_program_startup
__sdcc_init_data:
;	_mcs51_genXINIT() start
	mov	a,#l_XINIT
	orl	a,#l_XINIT>>8
	jz	00003$
	mov	a,#s_XINIT
	add	a,#l_XINIT
	mov	r1,a
	mov	a,#s_XINIT>>8
	addc	a,#l_XINIT>>8
	mov	r2,a
	mov	dptr,#s_XINIT
	mov	r0,#s_XISEG
	mov	p2,#(s_XISEG >> 8)
00001$:	clr	a
	movc	a,@a+dptr
	movx	@r0,a
	inc	dptr
	inc	r0
	cjne	r0,#0,00002$
	inc	p2
00002$:	mov	a,dpl
	cjne	a,ar1,00001$
	mov	a,dph
	cjne	a,ar2,00001$
	mov	p2,#0xFF
00003$:
;	_mcs51_genXINIT() end
;Z:\pn\z5\zad1.c:2: char E = 0x08;
;     genAssign
	mov	_E,#0x08
;Z:\pn\z5\zad1.c:3: char RS = 0x04;
;     genAssign
	mov	_RS,#0x04
;Z:\pn\z5\zad1.c:84: int j = 0;
;     genAssign
	clr	a
	mov	(_j + 1),a
	mov	_j,a
;Z:\pn\z5\zad1.c:85: int cyfry=1;
;     genAssign
	clr	a
	mov	(_cyfry + 1),a
	mov	_cyfry,#0x01
	.area GSFINAL (CODE)
	ljmp	__sdcc_program_startup
;--------------------------------------------------------
; Home
;--------------------------------------------------------
	.area HOME    (CODE)
	.area CSEG    (CODE)
;--------------------------------------------------------
; code
;--------------------------------------------------------
	.area CSEG    (CODE)
__sdcc_program_startup:
	lcall	_main
;	return from main will lock up
	sjmp .
;------------------------------------------------------------
;Allocation info for local variables in function 'wyslij_polecenie8'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:7: void wyslij_polecenie8(unsigned char polecenie)
;	-----------------------------------------
;	 function wyslij_polecenie8
;	-----------------------------------------
_wyslij_polecenie8:
	ar2 = 0x02
	ar3 = 0x03
	ar4 = 0x04
	ar5 = 0x05
	ar6 = 0x06
	ar7 = 0x07
	ar0 = 0x00
	ar1 = 0x01
;     genReceive
	mov	r2,dpl
;Z:\pn\z5\zad1.c:9: P1=polecenie;
;     genAssign
	mov	_P1,r2
;Z:\pn\z5\zad1.c:10: P1=polecenie | E; //gdzie E – jest mask¹ bitow¹ "ustawiaj¹c¹" liniê E – nale¿y j¹
;     genAssign
	mov	r3,_E
;     genOr
	mov	a,r3
	orl	a,r2
	mov	_P1,a
;Z:\pn\z5\zad1.c:15: P1=polecenie & !E; //gdzie !E – jest zanegowana maska bitowa, zeruj¹c¹ linie E –
;     genNot
	mov	a,_E
	cjne	a,#0x01,00103$
00103$:
	clr	a
	rlc	a
;     genAnd
;       Peephole 105   removed redundant mov
	mov  r3,a
	anl	a,r2
	mov	_P1,a
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'wyslij_polecenie4'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:19: void wyslij_polecenie4(unsigned char polecenie)
;	-----------------------------------------
;	 function wyslij_polecenie4
;	-----------------------------------------
_wyslij_polecenie4:
;     genReceive
	mov	r2,dpl
;Z:\pn\z5\zad1.c:21: P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
;     genAnd
	mov	a,#0xF0
	anl	a,r2
	mov	r3,a
;     genAssign
	mov	_P1,r3
;Z:\pn\z5\zad1.c:22: P1=(polecenie & 0xf0) | E; //sygna³ „strob”
;     genAssign
	mov	r4,_E
;     genOr
	mov	a,r4
	orl	a,r3
	mov	_P1,a
;Z:\pn\z5\zad1.c:23: P1=(polecenie & 0xf0) & !E;
;     genNot
	mov	a,_E
	cjne	a,#0x01,00103$
00103$:
	clr	a
	rlc	a
;     genAnd
;       Peephole 105   removed redundant mov
	mov  r4,a
	anl	a,r3
	mov	_P1,a
;Z:\pn\z5\zad1.c:24: P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
;    genLeftShift
;     genLeftShiftLiteral
;     genlshOne
	mov	a,r2
	swap	a
	anl	a,#0xf0
	mov	r2,a
;     genAnd
	anl	ar2,#0xF0
;     genAssign
	mov	_P1,r2
;Z:\pn\z5\zad1.c:25: P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
;     genAssign
	mov	r3,_E
;     genOr
	mov	a,r3
	orl	a,r2
	mov	_P1,a
;Z:\pn\z5\zad1.c:26: P1=((polecenie << 4) & 0xf0) & !E;
;     genAnd
	mov	a,r4
	anl	a,r2
	mov	_P1,a
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'wyslij_dane'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:29: void wyslij_dane(unsigned char dana)
;	-----------------------------------------
;	 function wyslij_dane
;	-----------------------------------------
_wyslij_dane:
;     genReceive
	mov	r2,dpl
;Z:\pn\z5\zad1.c:31: P1=(dana & 0xf0) | RS;
;     genAnd
	mov	a,#0xF0
	anl	a,r2
	mov	r3,a
;     genAssign
	mov	r4,_RS
;     genOr
	mov	a,r4
	orl	a,r3
	mov	_P1,a
;Z:\pn\z5\zad1.c:32: P1=((dana & 0xf0) | E) | RS;
;     genAssign
	mov	r4,_E
;     genOr
	mov	a,r3
	orl	ar4,a
;     genAssign
	mov	r5,_RS
;     genOr
	mov	a,r5
	orl	a,r4
	mov	_P1,a
;Z:\pn\z5\zad1.c:33: P1=((dana & 0xf0) & !E) | RS;
;     genNot
	mov	a,_E
	cjne	a,#0x01,00103$
00103$:
	clr	a
	rlc	a
;     genAnd
;       Peephole 105   removed redundant mov
	mov  r4,a
	anl	ar3,a
;     genAssign
	mov	r5,_RS
;     genOr
	mov	a,r5
	orl	a,r3
	mov	_P1,a
;Z:\pn\z5\zad1.c:34: P1=((dana << 4) & 0xf0) | RS;
;    genLeftShift
;     genLeftShiftLiteral
;     genlshOne
	mov	a,r2
	swap	a
	anl	a,#0xf0
	mov	r2,a
;     genAnd
	anl	ar2,#0xF0
;     genAssign
	mov	r3,_RS
;     genOr
	mov	a,r3
	orl	a,r2
	mov	_P1,a
;Z:\pn\z5\zad1.c:35: P1=(((dana << 4) & 0xf0) | E) | RS;
;     genAssign
	mov	r3,_E
;     genOr
	mov	a,r2
	orl	ar3,a
;     genAssign
	mov	r5,_RS
;     genOr
	mov	a,r5
	orl	a,r3
	mov	_P1,a
;Z:\pn\z5\zad1.c:36: P1=(((dana << 4) & 0xf0) & !E) | RS;
;     genAnd
	mov	a,r2
	anl	ar4,a
;     genAssign
	mov	r2,_RS
;     genOr
	mov	a,r2
	orl	a,r4
	mov	_P1,a
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'czekaj'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:39: void czekaj(int d){
;	-----------------------------------------
;	 function czekaj
;	-----------------------------------------
_czekaj:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
;Z:\pn\z5\zad1.c:41: for(i=0; i<d; i++){
;     genAssign
	mov	r4,#0x00
	mov	r5,#0x00
00101$:
;     genCmpLt
;     genCmp
	clr	c
	mov	a,r4
	subb	a,r2
	mov	a,r5
	xrl	a,#0x80
	mov	b,r3
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00105$
00109$:
;Z:\pn\z5\zad1.c:44: _endasm;
;     genInline
	                nop
;Z:\pn\z5\zad1.c:41: for(i=0; i<d; i++){
;     genPlus
;     genPlusIncr
;	tail increment optimized
	inc	r4
	cjne	r4,#0x00,00101$
	inc	r5
;       Peephole 132   changed ljmp to sjmp
	sjmp 00101$
00105$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'init'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:48: void init()
;	-----------------------------------------
;	 function init
;	-----------------------------------------
_init:
;Z:\pn\z5\zad1.c:50: wyslij_polecenie8(0x30); //3
;     genCall
	mov	dpl,#0x30
	lcall	_wyslij_polecenie8
;Z:\pn\z5\zad1.c:51: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:52: wyslij_polecenie8(0x30); //5
;     genCall
	mov	dpl,#0x30
	lcall	_wyslij_polecenie8
;Z:\pn\z5\zad1.c:53: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:54: wyslij_polecenie8(0x30); //7
;     genCall
	mov	dpl,#0x30
	lcall	_wyslij_polecenie8
;Z:\pn\z5\zad1.c:55: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:56: wyslij_polecenie8(0x20); //9
;     genCall
	mov	dpl,#0x20
	lcall	_wyslij_polecenie8
;Z:\pn\z5\zad1.c:57: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:58: wyslij_polecenie4(0x2F); //11
;     genCall
	mov	dpl,#0x2F
	lcall	_wyslij_polecenie4
;Z:\pn\z5\zad1.c:59: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:60: wyslij_polecenie4(0x08); //13
;     genCall
	mov	dpl,#0x08
	lcall	_wyslij_polecenie4
;Z:\pn\z5\zad1.c:61: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:62: wyslij_polecenie4(0x0E); //15
;     genCall
	mov	dpl,#0x0E
	lcall	_wyslij_polecenie4
;Z:\pn\z5\zad1.c:63: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:64: wyslij_polecenie4(0x06); //17
;     genCall
	mov	dpl,#0x06
	lcall	_wyslij_polecenie4
;Z:\pn\z5\zad1.c:65: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'gotoXY'
;------------------------------------------------------------
;y                         Allocated to in memory with name '_gotoXY_PARM_2'
;x                         Allocated to registers r2 
;i                         Allocated to registers r3 
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:68: void gotoXY(unsigned char x, unsigned char y)
;	-----------------------------------------
;	 function gotoXY
;	-----------------------------------------
_gotoXY:
;     genReceive
	mov	r2,dpl
;Z:\pn\z5\zad1.c:71: if(y==0)
;     genCmpEq
	mov	a,_gotoXY_PARM_2
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00108$
00107$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00102$
00108$:
;Z:\pn\z5\zad1.c:73: i = 128;
;     genAssign
	mov	r3,#0x80
;       Peephole 132   changed ljmp to sjmp
	sjmp 00103$
00102$:
;Z:\pn\z5\zad1.c:77: i = 192;
;     genAssign
	mov	r3,#0xC0
00103$:
;Z:\pn\z5\zad1.c:79: i |= x;
;     genOr
	mov	a,r2
	orl	ar3,a
;Z:\pn\z5\zad1.c:80: wyslij_polecenie4(i);
;     genCall
	mov	dpl,r3
	lcall	_wyslij_polecenie4
00104$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'wyswietl_iloczyn'
;------------------------------------------------------------
;y                         Allocated to in memory with name '_wyswietl_iloczyn_PARM_2'
;x                         Allocated to registers r2 r3 
;iloczyn                   Allocated to in memory with name '_wyswietl_iloczyn_iloczyn_1_1'
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:87: void wyswietl_iloczyn(int x, int y)
;	-----------------------------------------
;	 function wyswietl_iloczyn
;	-----------------------------------------
_wyswietl_iloczyn:
;     genReceive
;Z:\pn\z5\zad1.c:89: int iloczyn = x * y;
;     genAssign
;     genCall
	mov     r2,dpl
	mov     r3,dph
	mov     __mulsint_PARM_2,_wyswietl_iloczyn_PARM_2
	mov     (__mulsint_PARM_2 + 1),(_wyswietl_iloczyn_PARM_2 + 1)
;       Peephole 238c  removed 2 redundant moves
	lcall	__mulsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_wyswietl_iloczyn_iloczyn_1_1,a
	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
;Z:\pn\z5\zad1.c:91: for (i = 0; i<6; i++)
;     genAssign
	clr	a
	mov	(_i + 1),a
	mov	_i,a
00103$:
;     genCmpLt
;     genCmp
	clr	c
	mov	a,_i
	subb	a,#0x06
	mov	a,(_i + 1)
	xrl	a,#0x80
	subb	a,#0x80
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00106$
00123$:
;Z:\pn\z5\zad1.c:92: produkt[i] = 0;
;     genPlus
	mov	a,_i
	add	a,#_produkt
;     genPointerSet
;     genNearPointerSet
	mov	r0,acc
	mov	@r0,#0x00
;Z:\pn\z5\zad1.c:91: for (i = 0; i<6; i++)
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_i
	mov	_i,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_i + 1)
	mov	(_i + 1),a
;       Peephole 132   changed ljmp to sjmp
	sjmp 00103$
00106$:
;Z:\pn\z5\zad1.c:95: for (i = 0; i<6; i++)
;     genAssign
	clr	a
	mov	(_i + 1),a
	mov	_i,#0x06
00109$:
;Z:\pn\z5\zad1.c:97: if ( iloczyn > cyfry)
;     genCmpGt
;     genCmp
	clr	c
	mov	a,_cyfry
	subb	a,_wyswietl_iloczyn_iloczyn_1_1
	mov	a,(_cyfry + 1)
	xrl	a,#0x80
	mov	b,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00102$
00124$:
;Z:\pn\z5\zad1.c:99: j++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_j
	mov	_j,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_j + 1)
	mov	(_j + 1),a
;Z:\pn\z5\zad1.c:100: cyfry = cyfry * 10;
;     genAssign
	clr	a
	mov	(__mulsint_PARM_2 + 1),a
	mov	__mulsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_cyfry
	mov	dph,(_cyfry + 1)
	lcall	__mulsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_cyfry,a
	mov	(_cyfry + 1),b
00102$:
;     genMinus
;     genMinusDec
	mov	a,_i
	add	a,#0xff
	mov	_i,a
	mov	a,(_i + 1)
	addc	a,#0xff
	mov	(_i + 1),a
;Z:\pn\z5\zad1.c:95: for (i = 0; i<6; i++)
;     genIfx
	mov	a,_i
	orl	a,(_i + 1)
;     genIfxJump
;       Peephole 109   removed ljmp by inverse jump logic
	jnz  00109$
00125$:
;Z:\pn\z5\zad1.c:111: produkt[5] = '0' + (iloczyn / 100000);
;     genCast
	mov	r4,_wyswietl_iloczyn_iloczyn_1_1
	mov	r5,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	mov	a,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	rlc	a
	subb	a,acc
	mov	r6,a
	mov	r7,a
;     genAssign
	mov	__divslong_PARM_2,#0xA0
	mov	(__divslong_PARM_2 + 1),#0x86
	mov	(__divslong_PARM_2 + 2),#0x01
	mov	(__divslong_PARM_2 + 3),#0x00
;     genCall
	mov	dpl,r4
	mov	dph,r5
	mov	b,r6
	mov	a,r7
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	__divslong
	mov	r0,dpl
	mov	r1,dph
	mov	r2,b
	mov	r3,a
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
;     genPlus
	mov	a,#0x30
;       Peephole 236a
	add  a,r0
	mov	r0,a
;       Peephole 180   changed mov to clr
	clr  a
;       Peephole 236b
	addc  a,r1
	mov	r1,a
;       Peephole 180   changed mov to clr
	clr  a
;       Peephole 236b
	addc  a,r2
	mov	r2,a
;       Peephole 180   changed mov to clr
	clr  a
;       Peephole 236b
	addc  a,r3
	mov	r3,a
;     genCast
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_produkt + 0x0005),r0
;Z:\pn\z5\zad1.c:113: iloczyn = iloczyn %100000;
;     genAssign
	mov	__modslong_PARM_2,#0xA0
	mov	(__modslong_PARM_2 + 1),#0x86
	mov	(__modslong_PARM_2 + 2),#0x01
	mov	(__modslong_PARM_2 + 3),#0x00
;     genCall
	mov	dpl,r4
	mov	dph,r5
	mov	b,r6
	mov	a,r7
	lcall	__modslong
	mov	r2,dpl
	mov	r3,dph
	mov	r4,b
	mov	r5,a
;     genCast
	mov	_wyswietl_iloczyn_iloczyn_1_1,r2
	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),r3
;Z:\pn\z5\zad1.c:115: produkt[4] = '0' + (iloczyn / 10000);
;     genAssign
	mov	__divsint_PARM_2,#0x10
	mov	(__divsint_PARM_2 + 1),#0x27
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__divsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_produkt + 0x0004),r2
;Z:\pn\z5\zad1.c:117: iloczyn = iloczyn %10000;
;     genAssign
	mov	__modsint_PARM_2,#0x10
	mov	(__modsint_PARM_2 + 1),#0x27
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_wyswietl_iloczyn_iloczyn_1_1,a
	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
;Z:\pn\z5\zad1.c:119: produkt[3] = '0' + (iloczyn / 1000); 
;     genAssign
	mov	__divsint_PARM_2,#0xE8
	mov	(__divsint_PARM_2 + 1),#0x03
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__divsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_produkt + 0x0003),r2
;Z:\pn\z5\zad1.c:121: iloczyn = iloczyn %1000;
;     genAssign
	mov	__modsint_PARM_2,#0xE8
	mov	(__modsint_PARM_2 + 1),#0x03
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_wyswietl_iloczyn_iloczyn_1_1,a
	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
;Z:\pn\z5\zad1.c:123: produkt[2] = '0' + (iloczyn / 100); 
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x64
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__divsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_produkt + 0x0002),r2
;Z:\pn\z5\zad1.c:125: iloczyn = iloczyn %100;
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x64
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_wyswietl_iloczyn_iloczyn_1_1,a
	mov	(_wyswietl_iloczyn_iloczyn_1_1 + 1),b
;Z:\pn\z5\zad1.c:127: produkt[1] = '0' + (iloczyn / 10); 
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__divsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_produkt + 0x0001),r2
;Z:\pn\z5\zad1.c:129: iloczyn = iloczyn %10;
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_wyswietl_iloczyn_iloczyn_1_1
	mov	dph,(_wyswietl_iloczyn_iloczyn_1_1 + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;Z:\pn\z5\zad1.c:131: produkt[0] = '0' + (iloczyn / 1); 
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	_produkt,r2
;Z:\pn\z5\zad1.c:134: for (i = j-1; i>=0; i--)
;     genMinus
;     genMinusDec
	mov	a,_j
	add	a,#0xff
	mov	_i,a
	mov	a,(_j + 1)
	addc	a,#0xff
	mov	(_i + 1),a
00110$:
;     genCmpLt
;     genCmp
	mov	a,(_i + 1)
;     genIfxJump
;       Peephole 112   removed ljmp by inverse jump logic
	jb   acc.7,00114$
00126$:
;Z:\pn\z5\zad1.c:136: wyslij_dane(produkt[i]);	
;     genPlus
	mov	a,_i
	add	a,#_produkt
	mov	r0,a
;     genPointerGet
;     genNearPointerGet
	mov	dpl,@r0
;     genCall
	lcall	_wyslij_dane
;Z:\pn\z5\zad1.c:137: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:134: for (i = j-1; i>=0; i--)
;     genMinus
;     genMinusDec
	mov	a,_i
	add	a,#0xff
	mov	_i,a
	mov	a,(_i + 1)
	addc	a,#0xff
	mov	(_i + 1),a
;       Peephole 132   changed ljmp to sjmp
	sjmp 00110$
00114$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z5\zad1.c:143: void main(void)
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
;Z:\pn\z5\zad1.c:145: init();
;     genCall
	lcall	_init
;Z:\pn\z5\zad1.c:146: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:147: wyslij_polecenie4(0x01);
;     genCall
	mov	dpl,#0x01
	lcall	_wyslij_polecenie4
;Z:\pn\z5\zad1.c:148: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:149: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:150: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:155: gotoXY(5,1);
;     genAssign
	mov	_gotoXY_PARM_2,#0x01
;     genCall
	mov	dpl,#0x05
	lcall	_gotoXY
;Z:\pn\z5\zad1.c:156: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\z5\zad1.c:158: wyswietl_iloczyn(10,12);
;     genAssign
	clr	a
	mov	(_wyswietl_iloczyn_PARM_2 + 1),a
	mov	_wyswietl_iloczyn_PARM_2,#0x0C
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x0A)
	lcall	_wyswietl_iloczyn
00101$:
	ret
	.area CSEG    (CODE)
	.area XINIT   (CODE)
