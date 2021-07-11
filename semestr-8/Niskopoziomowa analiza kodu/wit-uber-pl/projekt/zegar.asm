;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Wed May 25 11:33:19 2011

;--------------------------------------------------------
	.module zegar
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _main
	.globl _wyswietl_alarm
	.globl _alarm
	.globl _wyswietl_godz
	.globl _czas
	.globl _gotoXY
	.globl _init
	.globl _func_isr
	.globl _czekaj
	.globl _wyslij_dane
	.globl _wyslij_polecenie4
	.globl _wyslij_polecenie8
	.globl _U12
	.globl _gotoXY_PARM_2
	.globl _t
	.globl _key_set
	.globl _dlugosc_sekundy
	.globl _stop
	.globl _alarm_on
	.globl _alarm_min
	.globl _alarm_godz
	.globl _sek
	.globl _min
	.globl _godz
	.globl _produkt
	.globl _RS
	.globl _E
;--------------------------------------------------------
; special function registers
;--------------------------------------------------------
_P1	=	0x0090
_IE	=	0x00a8
_TMOD	=	0x0089
_TH1	=	0x008d
_TL1	=	0x008b
_TCON	=	0x0088
_SBUF	=	0x0099
_SCON	=	0x0098
_PCON	=	0x0087
;--------------------------------------------------------
; special function bits 
;--------------------------------------------------------
_T1	=	0x00b4
_RI	=	0x0098
_TI	=	0x0099
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
_godz::
	.ds 2
_min::
	.ds 2
_sek::
	.ds 2
_alarm_godz::
	.ds 2
_alarm_min::
	.ds 2
_alarm_on::
	.ds 2
_stop::
	.ds 2
_dlugosc_sekundy::
	.ds 2
_key_set::
	.ds 2
_t::
	.ds 2
_gotoXY_PARM_2::
	.ds 1
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
_U12	=	0x8000
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
	ljmp	_func_isr
	.ds	5
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
;Z:\pn\projekt\zegar.c:5: char E = 0x08;
;     genAssign
	mov	_E,#0x08
;Z:\pn\projekt\zegar.c:6: char RS = 0x04;
;     genAssign
	mov	_RS,#0x04
;Z:\pn\projekt\zegar.c:25: int alarm_godz = 0;
;     genAssign
	clr	a
	mov	(_alarm_godz + 1),a
	mov	_alarm_godz,a
;Z:\pn\projekt\zegar.c:26: int alarm_min = 0;
;     genAssign
	clr	a
	mov	(_alarm_min + 1),a
	mov	_alarm_min,a
;Z:\pn\projekt\zegar.c:27: int alarm_on =0;
;     genAssign
	clr	a
	mov	(_alarm_on + 1),a
	mov	_alarm_on,a
;Z:\pn\projekt\zegar.c:28: int stop = 0;
;     genAssign
	clr	a
	mov	(_stop + 1),a
	mov	_stop,a
;Z:\pn\projekt\zegar.c:30: int dlugosc_sekundy = 23500;
;     genAssign
	mov	_dlugosc_sekundy,#0xCC
	mov	(_dlugosc_sekundy + 1),#0x5B
;Z:\pn\projekt\zegar.c:76: int key_set = 0;	//zmienna informujaca, o tym, ze wcisniety klawisz zostal przetworzony
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,a
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
;Z:\pn\projekt\zegar.c:33: void wyslij_polecenie8(unsigned char polecenie)
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
;Z:\pn\projekt\zegar.c:35: P1=polecenie;
;     genAssign
	mov	_P1,r2
;Z:\pn\projekt\zegar.c:36: P1=polecenie | E; //gdzie E – jest mask¹ bitow¹ "ustawiaj¹c¹" liniê E – nale¿y j¹
;     genAssign
	mov	r3,_E
;     genOr
	mov	a,r3
	orl	a,r2
	mov	_P1,a
;Z:\pn\projekt\zegar.c:41: P1=polecenie & !E; //gdzie !E – jest zanegowana maska bitowa, zeruj¹c¹ linie E –
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
;Z:\pn\projekt\zegar.c:45: void wyslij_polecenie4(unsigned char polecenie)
;	-----------------------------------------
;	 function wyslij_polecenie4
;	-----------------------------------------
_wyslij_polecenie4:
;     genReceive
	mov	r2,dpl
;Z:\pn\projekt\zegar.c:47: P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
;     genAnd
	mov	a,#0xF0
	anl	a,r2
	mov	r3,a
;     genAssign
	mov	_P1,r3
;Z:\pn\projekt\zegar.c:48: P1=(polecenie & 0xf0) | E; //sygna³ „strob”
;     genAssign
	mov	r4,_E
;     genOr
	mov	a,r4
	orl	a,r3
	mov	_P1,a
;Z:\pn\projekt\zegar.c:49: P1=(polecenie & 0xf0) & !E;
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
;Z:\pn\projekt\zegar.c:50: P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
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
;Z:\pn\projekt\zegar.c:51: P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
;     genAssign
	mov	r3,_E
;     genOr
	mov	a,r3
	orl	a,r2
	mov	_P1,a
;Z:\pn\projekt\zegar.c:52: P1=((polecenie << 4) & 0xf0) & !E;
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
;Z:\pn\projekt\zegar.c:55: void wyslij_dane(unsigned char dana)
;	-----------------------------------------
;	 function wyslij_dane
;	-----------------------------------------
_wyslij_dane:
;     genReceive
	mov	r2,dpl
;Z:\pn\projekt\zegar.c:57: P1=(dana & 0xf0) | RS;
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
;Z:\pn\projekt\zegar.c:58: P1=((dana & 0xf0) | E) | RS;
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
;Z:\pn\projekt\zegar.c:59: P1=((dana & 0xf0) & !E) | RS;
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
;Z:\pn\projekt\zegar.c:60: P1=((dana << 4) & 0xf0) | RS;
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
;Z:\pn\projekt\zegar.c:61: P1=(((dana << 4) & 0xf0) | E) | RS;
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
;Z:\pn\projekt\zegar.c:62: P1=(((dana << 4) & 0xf0) & !E) | RS;
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
;Z:\pn\projekt\zegar.c:65: void czekaj(int d){
;	-----------------------------------------
;	 function czekaj
;	-----------------------------------------
_czekaj:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
;Z:\pn\projekt\zegar.c:67: for(i=0; i<d; i++){
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
;Z:\pn\projekt\zegar.c:70: _endasm;
;     genInline
	                nop
;Z:\pn\projekt\zegar.c:67: for(i=0; i<d; i++){
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
;Allocation info for local variables in function 'func_isr'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:82: void func_isr (void) interrupt 3
;	-----------------------------------------
;	 function func_isr
;	-----------------------------------------
_func_isr:
	push	acc
	push	b
	push	dpl
	push	dph
	push	psw
	mov	psw,#0x00
;Z:\pn\projekt\zegar.c:85: t++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_t
	mov	_t,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_t + 1)
	mov	(_t + 1),a
;Z:\pn\projekt\zegar.c:86: if(t==dlugosc_sekundy){
;     genCmpEq
	mov	a,_t
;       Peephole 132   changed ljmp to sjmp
;       Peephole 197   optimized misc jump sequence
	cjne a,_dlugosc_sekundy,00103$
	mov  a,(_t + 1)
	cjne a,(_dlugosc_sekundy + 1),00103$
;00106$:
;       Peephole 200   removed redundant sjmp
00107$:
;Z:\pn\projekt\zegar.c:87: t=0;
;     genAssign
	clr	a
	mov	(_t + 1),a
	mov	_t,a
;Z:\pn\projekt\zegar.c:88: sek++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_sek
	mov	_sek,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_sek + 1)
	mov	(_sek + 1),a
00103$:
	pop	psw
	pop	dph
	pop	dpl
	pop	b
	pop	acc
	reti
;------------------------------------------------------------
;Allocation info for local variables in function 'init'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:96: void init()
;	-----------------------------------------
;	 function init
;	-----------------------------------------
_init:
;Z:\pn\projekt\zegar.c:98: SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
;     genAssign
	mov	_SCON,#0x50
;Z:\pn\projekt\zegar.c:100: TMOD &=	0x0F;	//konfiguracja licznika
;     genAnd
	anl	_TMOD,#0x0F
;Z:\pn\projekt\zegar.c:101: TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
;     genOr
	orl	_TMOD,#0x20
;Z:\pn\projekt\zegar.c:103: TH1 = TL1 = 253;     //Wartosc startowa
;     genAssign
	mov	_TL1,#0xFD
;     genAssign
	mov	_TH1,#0xFD
;Z:\pn\projekt\zegar.c:104: TCON = 0x40;
;     genAssign
	mov	_TCON,#0x40
;Z:\pn\projekt\zegar.c:105: PCON = 0x80;
;     genAssign
	mov	_PCON,#0x80
;Z:\pn\projekt\zegar.c:106: IE =	0x88;
;     genAssign
	mov	_IE,#0x88
;Z:\pn\projekt\zegar.c:109: wyslij_polecenie8(0x30); //3
;     genCall
	mov	dpl,#0x30
	lcall	_wyslij_polecenie8
;Z:\pn\projekt\zegar.c:110: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:111: wyslij_polecenie8(0x30); //5
;     genCall
	mov	dpl,#0x30
	lcall	_wyslij_polecenie8
;Z:\pn\projekt\zegar.c:112: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:113: wyslij_polecenie8(0x30); //7
;     genCall
	mov	dpl,#0x30
	lcall	_wyslij_polecenie8
;Z:\pn\projekt\zegar.c:114: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:115: wyslij_polecenie8(0x20); //9
;     genCall
	mov	dpl,#0x20
	lcall	_wyslij_polecenie8
;Z:\pn\projekt\zegar.c:116: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:117: wyslij_polecenie4(0x2F); //11
;     genCall
	mov	dpl,#0x2F
	lcall	_wyslij_polecenie4
;Z:\pn\projekt\zegar.c:118: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:119: wyslij_polecenie4(0x08); //13
;     genCall
	mov	dpl,#0x08
	lcall	_wyslij_polecenie4
;Z:\pn\projekt\zegar.c:120: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:122: wyslij_polecenie4(0x0C); //15 -- mod na wylaczenie kursora
;     genCall
	mov	dpl,#0x0C
	lcall	_wyslij_polecenie4
;Z:\pn\projekt\zegar.c:124: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:125: wyslij_polecenie4(0x06); //17
;     genCall
	mov	dpl,#0x06
	lcall	_wyslij_polecenie4
;Z:\pn\projekt\zegar.c:126: czekaj(100);
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
;Z:\pn\projekt\zegar.c:129: void gotoXY(unsigned char x, unsigned char y)
;	-----------------------------------------
;	 function gotoXY
;	-----------------------------------------
_gotoXY:
;     genReceive
	mov	r2,dpl
;Z:\pn\projekt\zegar.c:132: if(y==0)
;     genCmpEq
	mov	a,_gotoXY_PARM_2
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00108$
00107$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00102$
00108$:
;Z:\pn\projekt\zegar.c:134: i = 128;
;     genAssign
	mov	r3,#0x80
;       Peephole 132   changed ljmp to sjmp
	sjmp 00103$
00102$:
;Z:\pn\projekt\zegar.c:138: i = 192;
;     genAssign
	mov	r3,#0xC0
00103$:
;Z:\pn\projekt\zegar.c:140: i |= x;
;     genOr
	mov	a,r2
	orl	ar3,a
;Z:\pn\projekt\zegar.c:141: wyslij_polecenie4(i);
;     genCall
	mov	dpl,r3
	lcall	_wyslij_polecenie4
00104$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'czas'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:144: void czas(){
;	-----------------------------------------
;	 function czas
;	-----------------------------------------
_czas:
;Z:\pn\projekt\zegar.c:146: if (sek==59)
;     genCmpEq
	mov	a,_sek
	cjne	a,#0x3B,00113$
	mov	a,(_sek + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00114$
00113$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00106$
00114$:
;Z:\pn\projekt\zegar.c:148: min++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_min
	mov	_min,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_min + 1)
	mov	(_min + 1),a
;Z:\pn\projekt\zegar.c:149: sek = 0;
;     genAssign
	clr	a
	mov	(_sek + 1),a
	mov	_sek,a
;Z:\pn\projekt\zegar.c:151: if (min == 60) 
;     genCmpEq
	mov	a,_min
	cjne	a,#0x3C,00115$
	mov	a,(_min + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00116$
00115$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00108$
00116$:
;Z:\pn\projekt\zegar.c:153: godz++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_godz
	mov	_godz,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_godz + 1)
	mov	(_godz + 1),a
;Z:\pn\projekt\zegar.c:154: min = 0;
;     genAssign
	clr	a
	mov	(_min + 1),a
	mov	_min,a
;Z:\pn\projekt\zegar.c:155: if(godz == 24)
;     genCmpEq
	mov	a,_godz
	cjne	a,#0x18,00117$
	mov	a,(_godz + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00118$
00117$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00108$
00118$:
;Z:\pn\projekt\zegar.c:156: godz = 0;
;     genAssign
	clr	a
	mov	(_godz + 1),a
	mov	_godz,a
;       Peephole 132   changed ljmp to sjmp
	sjmp 00108$
00106$:
;Z:\pn\projekt\zegar.c:163: sek = sek%59;
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x3B
;     genCall
	mov	dpl,_sek
	mov	dph,(_sek + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_sek,a
	mov	(_sek + 1),b
00108$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'wyswietl_godz'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:167: void wyswietl_godz()
;	-----------------------------------------
;	 function wyswietl_godz
;	-----------------------------------------
_wyswietl_godz:
;Z:\pn\projekt\zegar.c:169: czas();
;     genCall
	lcall	_czas
;Z:\pn\projekt\zegar.c:171: wyslij_dane('0' + godz / 10 );
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_godz
	mov	dph,(_godz + 1)
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
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:172: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:173: wyslij_dane('0' + godz % 10 );
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_godz
	mov	dph,(_godz + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:174: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:175: wyslij_dane(':');
;     genCall
	mov	dpl,#0x3A
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:176: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:177: wyslij_dane('0' + min / 10 );
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_min
	mov	dph,(_min + 1)
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
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:178: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:179: wyslij_dane('0' + min % 10 );
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_min
	mov	dph,(_min + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:180: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:181: wyslij_dane(':');
;     genCall
	mov	dpl,#0x3A
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:182: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:183: wyslij_dane('0' + sek / 10 );
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_sek
	mov	dph,(_sek + 1)
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
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:184: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:185: wyslij_dane('0' + sek % 10 );
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_sek
	mov	dph,(_sek + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:186: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:187: gotoXY(0,0);     
;     genAssign
	mov	_gotoXY_PARM_2,#0x00
;     genCall
	mov	dpl,#0x00
	lcall	_gotoXY
;Z:\pn\projekt\zegar.c:188: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:189: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'alarm'
;------------------------------------------------------------
;r                         Allocated to registers r2 
;hz                        Allocated to registers 
;i                         Allocated to registers 
;j                         Allocated to registers 
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:192: void alarm(){
;	-----------------------------------------
;	 function alarm
;	-----------------------------------------
_alarm:
;Z:\pn\projekt\zegar.c:194: unsigned char r=0;
;     genAssign
	mov	r2,#0x00
;Z:\pn\projekt\zegar.c:199: while (alarm_godz == godz && alarm_min == min && alarm_on == 1 && stop == 0)
00113$:
;     genCmpEq
	mov	a,_alarm_godz
	cjne	a,_godz,00139$
	mov	a,(_alarm_godz + 1)
	cjne	a,(_godz + 1),00139$
	sjmp	00140$
00139$:
	ljmp	00124$
00140$:
;     genCmpEq
	mov	a,_alarm_min
	cjne	a,_min,00141$
	mov	a,(_alarm_min + 1)
	cjne	a,(_min + 1),00141$
	sjmp	00142$
00141$:
	ljmp	00124$
00142$:
;     genCmpEq
	mov	a,_alarm_on
	cjne	a,#0x01,00143$
	mov	a,(_alarm_on + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00144$
00143$:
	ljmp	00124$
00144$:
;     genCmpEq
	mov	a,_stop
	jnz	00145$
	mov	a,(_stop + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00146$
00145$:
	ljmp	00124$
00146$:
;Z:\pn\projekt\zegar.c:206: for(j=0;j<100;j++){
;     genAssign
	mov	ar3,r2
;     genAssign
	mov	r4,#0x00
	mov	r5,#0x00
00120$:
;     genCmpLt
;     genCmp
	clr	c
	mov	a,r4
	subb	a,#0x64
	mov	a,r5
	xrl	a,#0x80
	subb	a,#0x80
	clr	a
	rlc	a
	mov	r6,a
;     genAssign
	mov	ar2,r3
;     genIfx
	mov	a,r6
;     genIfxJump
;       Peephole 110   removed ljmp by inverse jump logic
	jz  00123$
00147$:
;Z:\pn\projekt\zegar.c:207: if (( r & 0x01) == 0) // maskowanie
;     genAnd
	mov	a,#0x01
	anl	a,r3
	mov	r7,a
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r7,#0x00,00102$
;00148$:
;       Peephole 200   removed redundant sjmp
00149$:
;Z:\pn\projekt\zegar.c:208: T1 = 1;
;     genAssign
	setb	_T1
;       Peephole 132   changed ljmp to sjmp
	sjmp 00103$
00102$:
;Z:\pn\projekt\zegar.c:210: T1 = 0;
;     genAssign
	clr	_T1
00103$:
;Z:\pn\projekt\zegar.c:211: r++;
;     genPlus
;     genPlusIncr
	inc	r3
;Z:\pn\projekt\zegar.c:212: for(i=0;i<hz;i++);
;     genAssign
	mov	r7,#0x00
00116$:
;     genCmpLt
;     genCmp
	cjne	r7,#0x0A,00150$
00150$:
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00122$
00151$:
;     genPlus
;     genPlusIncr
	inc	r7
;       Peephole 132   changed ljmp to sjmp
	sjmp 00116$
00122$:
;Z:\pn\projekt\zegar.c:206: for(j=0;j<100;j++){
;     genPlus
;     genPlusIncr
	inc	r4
	cjne	r4,#0x00,00152$
	inc	r5
00152$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00120$
00123$:
;Z:\pn\projekt\zegar.c:217: if (( U12 & 0x08 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r3,a
;     genAnd
	anl	ar3,#0x08
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r3,#0x00,00105$
;00153$:
;       Peephole 200   removed redundant sjmp
00154$:
;Z:\pn\projekt\zegar.c:219: stop=1;
;     genAssign
	clr	a
	mov	(_stop + 1),a
	mov	_stop,#0x01
;Z:\pn\projekt\zegar.c:220: alarm_on=0;
;     genAssign
	clr	a
	mov	(_alarm_on + 1),a
	mov	_alarm_on,a
;Z:\pn\projekt\zegar.c:221: wyslij_polecenie4(0x01);
;     genCall
	mov	dpl,#0x01
	push	ar2
	lcall	_wyslij_polecenie4
	pop	ar2
00105$:
;Z:\pn\projekt\zegar.c:224: if (( U12 & 0x01 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r3,a
;     genAnd
	anl	ar3,#0x01
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r3,#0x00,00107$
;00155$:
;       Peephole 200   removed redundant sjmp
00156$:
;Z:\pn\projekt\zegar.c:226: alarm_godz =(alarm_godz +1)%24;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_alarm_godz
	mov	r3,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_alarm_godz + 1)
	mov	r4,a
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x18
;     genCall
	mov	dpl,r3
	mov	dph,r4
	push	ar2
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
	pop	ar2
;     genAssign
	mov	_alarm_godz,a
	mov	(_alarm_godz + 1),b
00107$:
;Z:\pn\projekt\zegar.c:230: if (( U12 & 0x02 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r3,a
;     genAnd
	anl	ar3,#0x02
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r3,#0x00,00109$
;00157$:
;       Peephole 200   removed redundant sjmp
00158$:
;Z:\pn\projekt\zegar.c:232: alarm_min = (alarm_min +1)%60;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_alarm_min
	mov	r3,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_alarm_min + 1)
	mov	r4,a
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x3C
;     genCall
	mov	dpl,r3
	mov	dph,r4
	push	ar2
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
	pop	ar2
;     genAssign
	mov	_alarm_min,a
	mov	(_alarm_min + 1),b
00109$:
;Z:\pn\projekt\zegar.c:236: wyswietl_godz();
;     genCall
	push	ar2
	lcall	_wyswietl_godz
	pop	ar2
	ljmp	00113$
00124$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'wyswietl_alarm'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:248: void wyswietl_alarm()
;	-----------------------------------------
;	 function wyswietl_alarm
;	-----------------------------------------
_wyswietl_alarm:
;Z:\pn\projekt\zegar.c:250: if(alarm_on == 1)
;     genCmpEq
	mov	a,_alarm_on
	cjne	a,#0x01,00106$
	mov	a,(_alarm_on + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00107$
00106$:
	ljmp	00103$
00107$:
;Z:\pn\projekt\zegar.c:252: gotoXY(0,1); 
;     genAssign
	mov	_gotoXY_PARM_2,#0x01
;     genCall
	mov	dpl,#0x00
	lcall	_gotoXY
;Z:\pn\projekt\zegar.c:253: wyslij_dane('0' + alarm_godz / 10 );
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_alarm_godz
	mov	dph,(_alarm_godz + 1)
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
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:254: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:255: wyslij_dane('0' + alarm_godz % 10 );
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_alarm_godz
	mov	dph,(_alarm_godz + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:256: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:257: wyslij_dane(':');
;     genCall
	mov	dpl,#0x3A
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:258: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:259: wyslij_dane('0' + alarm_min / 10 );
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_alarm_min
	mov	dph,(_alarm_min + 1)
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
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:260: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:261: wyslij_dane('0' + alarm_min % 10 );
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x0A
;     genCall
	mov	dpl,_alarm_min
	mov	dph,(_alarm_min + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genPlus
	add	a,#0x30
	mov	r2,a
	mov	a,b
	addc	a,#0x00
	mov	r3,a
;     genCast
	mov	dpl,r2
;     genCall
	lcall	_wyslij_dane
;Z:\pn\projekt\zegar.c:262: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:263: gotoXY(0,0);     
;     genAssign
	mov	_gotoXY_PARM_2,#0x00
;     genCall
	mov	dpl,#0x00
	lcall	_gotoXY
;Z:\pn\projekt\zegar.c:264: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:265: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
00103$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\zegar.c:275: void main(void)
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
;Z:\pn\projekt\zegar.c:277: init();
;     genCall
	lcall	_init
;Z:\pn\projekt\zegar.c:279: t=0;
;     genAssign
	clr	a
	mov	(_t + 1),a
	mov	_t,a
;Z:\pn\projekt\zegar.c:280: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:281: wyslij_polecenie4(0x01);
;     genCall
	mov	dpl,#0x01
	lcall	_wyslij_polecenie4
;Z:\pn\projekt\zegar.c:282: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:283: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:284: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\zegar.c:286: godz =11;
;     genAssign
	clr	a
	mov	(_godz + 1),a
	mov	_godz,#0x0B
;Z:\pn\projekt\zegar.c:287: min = 30;
;     genAssign
	clr	a
	mov	(_min + 1),a
	mov	_min,#0x1E
;Z:\pn\projekt\zegar.c:288: sek= 55;
;     genAssign
	clr	a
	mov	(_sek + 1),a
	mov	_sek,#0x37
;Z:\pn\projekt\zegar.c:290: wyswietl_godz();
;     genCall
	lcall	_wyswietl_godz
00121$:
;Z:\pn\projekt\zegar.c:295: if (alarm_on == 0)
;     genCmpEq
	mov	a,_alarm_on
	jnz	00135$
	mov	a,(_alarm_on + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00136$
00135$:
	ljmp	00118$
00136$:
;Z:\pn\projekt\zegar.c:298: if (( U12 & 0x01 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x01
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r2,#0x00,00102$
;00137$:
;       Peephole 200   removed redundant sjmp
00138$:
;Z:\pn\projekt\zegar.c:300: godz =(godz +1)%24;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_godz
	mov	r2,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_godz + 1)
	mov	r3,a
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x18
;     genCall
	mov	dpl,r2
	mov	dph,r3
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_godz,a
	mov	(_godz + 1),b
00102$:
;Z:\pn\projekt\zegar.c:304: if (( U12 & 0x02 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x02
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r2,#0x00,00104$
;00139$:
;       Peephole 200   removed redundant sjmp
00140$:
;Z:\pn\projekt\zegar.c:306: min = (min +1)%60;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_min
	mov	r2,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_min + 1)
	mov	r3,a
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x3C
;     genCall
	mov	dpl,r2
	mov	dph,r3
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_min,a
	mov	(_min + 1),b
00104$:
;Z:\pn\projekt\zegar.c:309: if (( U12 & 0x04 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x04
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r2,#0x00,00106$
;00141$:
;       Peephole 200   removed redundant sjmp
00142$:
;Z:\pn\projekt\zegar.c:312: sek=0;
;     genAssign
	clr	a
	mov	(_sek + 1),a
	mov	_sek,a
00106$:
;Z:\pn\projekt\zegar.c:315: if (( U12 & 0x08 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x08
;     genCmpEq
	cjne	r2,#0x00,00143$
	sjmp	00144$
00143$:
	ljmp	00119$
00144$:
;Z:\pn\projekt\zegar.c:317: alarm_on=1;
;     genAssign
	clr	a
	mov	(_alarm_on + 1),a
	mov	_alarm_on,#0x01
;Z:\pn\projekt\zegar.c:318: stop = 0;
;     genAssign
	clr	a
	mov	(_stop + 1),a
	mov	_stop,a
	ljmp	00119$
00118$:
;Z:\pn\projekt\zegar.c:321: else if(alarm_on == 1)
;     genCmpEq
	mov	a,_alarm_on
	cjne	a,#0x01,00145$
	mov	a,(_alarm_on + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00146$
00145$:
	ljmp	00119$
00146$:
;Z:\pn\projekt\zegar.c:323: if (( U12 & 0x01 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x01
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r2,#0x00,00110$
;00147$:
;       Peephole 200   removed redundant sjmp
00148$:
;Z:\pn\projekt\zegar.c:325: alarm_godz =(alarm_godz +1)%24;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_alarm_godz
	mov	r2,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_alarm_godz + 1)
	mov	r3,a
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x18
;     genCall
	mov	dpl,r2
	mov	dph,r3
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_alarm_godz,a
	mov	(_alarm_godz + 1),b
00110$:
;Z:\pn\projekt\zegar.c:329: if (( U12 & 0x02 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x02
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r2,#0x00,00112$
;00149$:
;       Peephole 200   removed redundant sjmp
00150$:
;Z:\pn\projekt\zegar.c:331: alarm_min = (alarm_min +1)%60;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_alarm_min
	mov	r2,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_alarm_min + 1)
	mov	r3,a
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x3C
;     genCall
	mov	dpl,r2
	mov	dph,r3
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_alarm_min,a
	mov	(_alarm_min + 1),b
00112$:
;Z:\pn\projekt\zegar.c:340: if (( U12 & 0x08 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0x08
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r2,#0x00,00119$
;00151$:
;       Peephole 200   removed redundant sjmp
00152$:
;Z:\pn\projekt\zegar.c:342: alarm_on=0;
;     genAssign
	clr	a
	mov	(_alarm_on + 1),a
	mov	_alarm_on,a
;Z:\pn\projekt\zegar.c:343: wyslij_polecenie4(0x01);
;     genCall
	mov	dpl,#0x01
	lcall	_wyslij_polecenie4
00119$:
;Z:\pn\projekt\zegar.c:352: wyswietl_godz();
;     genCall
	lcall	_wyswietl_godz
;Z:\pn\projekt\zegar.c:353: wyswietl_alarm();
;     genCall
	lcall	_wyswietl_alarm
;Z:\pn\projekt\zegar.c:354: alarm();
;     genCall
	lcall	_alarm
	ljmp	00121$
00123$:
	ret
	.area CSEG    (CODE)
	.area XINIT   (CODE)
