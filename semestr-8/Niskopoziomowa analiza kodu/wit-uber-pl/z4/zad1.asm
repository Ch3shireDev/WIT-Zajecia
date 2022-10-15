;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Tue May 17 10:50:19 2011

;--------------------------------------------------------
	.module zad1
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _kolumna
	.globl _klawiszZKolumny
	.globl _main
	.globl _putchar
	.globl _init
	.globl _func_isr
	.globl _sleep
	.globl _U10
	.globl _U12
	.globl _U15
	.globl _key_set
	.globl _t
	.globl _key
;--------------------------------------------------------
; special function registers
;--------------------------------------------------------
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
_key::
	.ds 2
_t::
	.ds 2
_key_set::
	.ds 2
;--------------------------------------------------------
; overlayable items in internal ram 
;--------------------------------------------------------
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
_U15	=	0x8000
_U12	=	0x8000
_U10	=	0xffff
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
;Z:\pn\z4\zad1.c:18: int key =-1;		//zmienna do przekazywania, ktory guzik zostal wcisniety
;     genAssign
	mov	_key,#0xFF
	mov	(_key + 1),#0xFF
;Z:\pn\z4\zad1.c:19: int t = 0;			//zmienna do iterowania kolumn
;     genAssign
	clr	a
	mov	(_t + 1),a
	mov	_t,a
;Z:\pn\z4\zad1.c:20: int key_set = 0;	//zmienna informujaca, o tym, ze wcisniety klawisz zostal przetworzony
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
;Allocation info for local variables in function 'sleep'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z4\zad1.c:23: void sleep(int d){
;	-----------------------------------------
;	 function sleep
;	-----------------------------------------
_sleep:
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
	mov	r3,dph
;Z:\pn\z4\zad1.c:25: for(i=0; i<d; i++);
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
;Z:\pn\z4\zad1.c:28: void func_isr (void) interrupt 3
;	-----------------------------------------
;	 function func_isr
;	-----------------------------------------
_func_isr:
	push	acc
	push	b
	push	dpl
	push	dph
	push	ar2
	push	ar3
	push	ar4
	push	psw
	mov	psw,#0x00
;Z:\pn\z4\zad1.c:33: U15 = kolumna[t];
;     genPlus
	mov	a,_t
	add	a,#_kolumna
	mov	dpl,a
	mov	a,(_t + 1)
	addc	a,#(_kolumna >> 8)
	mov	dph,a
;     genPointerGet
;     genCodePointerGet
	clr	a
	movc	a,@a+dptr
;     genAssign
;       Peephole 100   removed redundant mov
	mov  r2,a
	mov  dptr,#_U15
	movx @dptr,a
;Z:\pn\z4\zad1.c:35: if (((U12 & 0xf0) == klawiszZKolumny[2])&& key_set == 0 && t == 2) 
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0xF0
;     genPointerGet
;     genCodePointerGet
	mov	dptr,#(_klawiszZKolumny + 0x0002)
	clr	a
	movc	a,@a+dptr
	mov	r3,a
;     genCmpEq
	mov	a,r2
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne a,ar3,00102$
;00131$:
;       Peephole 200   removed redundant sjmp
00132$:
;     genCmpEq
	mov	a,_key_set
	jnz	00133$
	mov	a,(_key_set + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00134$
00133$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00102$
00134$:
;     genCmpEq
	mov	a,_t
	cjne	a,#0x02,00135$
	mov	a,(_t + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00136$
00135$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00102$
00136$:
;Z:\pn\z4\zad1.c:37: key =3;
;     genAssign
	clr	a
	mov	(_key + 1),a
	mov	_key,#0x03
;Z:\pn\z4\zad1.c:38: key_set = 1;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,#0x01
00102$:
;Z:\pn\z4\zad1.c:41: if (((U12 & 0xf0) == klawiszZKolumny[3]) && key_set == 0 && t == 2) 
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r2,a
;     genAnd
	anl	ar2,#0xF0
;     genPointerGet
;     genCodePointerGet
	mov	dptr,#(_klawiszZKolumny + 0x0003)
	clr	a
	movc	a,@a+dptr
	mov	r4,a
;     genCmpEq
	mov	a,r2
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne a,ar4,00106$
;00137$:
;       Peephole 200   removed redundant sjmp
00138$:
;     genCmpEq
	mov	a,_key_set
	jnz	00139$
	mov	a,(_key_set + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00140$
00139$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00106$
00140$:
;     genCmpEq
	mov	a,_t
	cjne	a,#0x02,00141$
	mov	a,(_t + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00142$
00141$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00106$
00142$:
;Z:\pn\z4\zad1.c:43: key =1;
;     genAssign
	clr	a
	mov	(_key + 1),a
	mov	_key,#0x01
;Z:\pn\z4\zad1.c:44: key_set = 1;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,#0x01
00106$:
;Z:\pn\z4\zad1.c:46: if (((U12 & 0xf0) == klawiszZKolumny[2])&& key_set == 0 && t == 3) 
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
;     genAnd
;     genCmpEq
;       Peephole 139   removed redundant mov
	anl  a,#0xF0
	mov  r2,a
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne a,ar3,00110$
;00143$:
;       Peephole 200   removed redundant sjmp
00144$:
;     genCmpEq
	mov	a,_key_set
	jnz	00145$
	mov	a,(_key_set + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00146$
00145$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00110$
00146$:
;     genCmpEq
	mov	a,_t
	cjne	a,#0x03,00147$
	mov	a,(_t + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00148$
00147$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00110$
00148$:
;Z:\pn\z4\zad1.c:48: key =2;
;     genAssign
	clr	a
	mov	(_key + 1),a
	mov	_key,#0x02
;Z:\pn\z4\zad1.c:49: key_set = 1;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,#0x01
00110$:
;Z:\pn\z4\zad1.c:52: if (((U12 & 0xf0) == klawiszZKolumny[3])&& key_set == 0 && t == 3)  
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
;     genAnd
;     genCmpEq
;       Peephole 139   removed redundant mov
	anl  a,#0xF0
	mov  r2,a
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne a,ar4,00114$
;00149$:
;       Peephole 200   removed redundant sjmp
00150$:
;     genCmpEq
	mov	a,_key_set
	jnz	00151$
	mov	a,(_key_set + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00152$
00151$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00114$
00152$:
;     genCmpEq
	mov	a,_t
	cjne	a,#0x03,00153$
	mov	a,(_t + 1)
;       Peephole 162   removed sjmp by inverse jump logic
	jz   00154$
00153$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00114$
00154$:
;Z:\pn\z4\zad1.c:54: key =0;
;     genAssign
	clr	a
	mov	(_key + 1),a
	mov	_key,a
;Z:\pn\z4\zad1.c:55: key_set = 1;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,#0x01
00114$:
;Z:\pn\z4\zad1.c:58: t++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_t
	mov	_t,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_t + 1)
	mov	(_t + 1),a
;Z:\pn\z4\zad1.c:60: t=t%4;
;     genAssign
	clr	a
	mov	(__modsint_PARM_2 + 1),a
	mov	__modsint_PARM_2,#0x04
;     genCall
	mov	dpl,_t
	mov	dph,(_t + 1)
	lcall	__modsint
	mov	a,dpl
	mov	b,dph
;     genAssign
	mov	_t,a
	mov	(_t + 1),b
00117$:
	pop	psw
	pop	ar4
	pop	ar3
	pop	ar2
	pop	dph
	pop	dpl
	pop	b
	pop	acc
	reti
;------------------------------------------------------------
;Allocation info for local variables in function 'init'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z4\zad1.c:67: void init(void)
;	-----------------------------------------
;	 function init
;	-----------------------------------------
_init:
;Z:\pn\z4\zad1.c:70: SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
;     genAssign
	mov	_SCON,#0x50
;Z:\pn\z4\zad1.c:72: TMOD &=	0x0F;	//konfiguracja licznika
;     genAnd
	anl	_TMOD,#0x0F
;Z:\pn\z4\zad1.c:73: TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
;     genOr
	orl	_TMOD,#0x20
;Z:\pn\z4\zad1.c:75: TH1 = TL1 =253;     //Wartosc startowa
;     genAssign
	mov	_TL1,#0xFD
;     genAssign
	mov	_TH1,#0xFD
;Z:\pn\z4\zad1.c:76: TCON = 0x40;
;     genAssign
	mov	_TCON,#0x40
;Z:\pn\z4\zad1.c:77: PCON = 0x80;
;     genAssign
	mov	_PCON,#0x80
;Z:\pn\z4\zad1.c:78: IE =	0x88;
;     genAssign
	mov	_IE,#0x88
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'putchar'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z4\zad1.c:84: void putchar(char znak)
;	-----------------------------------------
;	 function putchar
;	-----------------------------------------
_putchar:
;     genReceive
	mov	_SBUF,dpl
;Z:\pn\z4\zad1.c:87: while(TI==0);
00101$:
;     genNot
	mov	c,_TI
	cpl	c
	clr	a
	rlc	a
;     genIfx
;       Peephole 105   removed redundant mov
	mov  r2,a
;     genIfxJump
;       Peephole 109   removed ljmp by inverse jump logic
	jnz  00101$
00108$:
;Z:\pn\z4\zad1.c:88: TI=0;
;     genAssign
	clr	_TI
00104$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z4\zad1.c:91: main (void){
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
;Z:\pn\z4\zad1.c:92: init();
;     genCall
	lcall	_init
00108$:
;Z:\pn\z4\zad1.c:96: switch(key){
;     genCmpLt
;     genCmp
	mov	a,(_key + 1)
;     genIfxJump
;       Peephole 112   removed ljmp by inverse jump logic
	jb   acc.7,00108$
00115$:
;     genCmpGt
;     genCmp
	clr	c
	mov	a,#0x03
	subb	a,_key
;       Peephole 159   avoided xrl during execution
	mov  a,#(0x00 ^ 0x80)
	mov	b,(_key + 1)
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 132   changed ljmp to sjmp
;       Peephole 160   removed sjmp by inverse jump logic
	jc   00108$
00116$:
;     genJumpTab
	mov	a,_key
	add	a,acc
	add	a,_key
	mov	dptr,#00117$
	jmp	@a+dptr
00117$:
	ljmp	00101$
	ljmp	00102$
	ljmp	00103$
	ljmp	00104$
;Z:\pn\z4\zad1.c:99: putchar('A');
00101$:
;     genCall
	mov	dpl,#0x41
	lcall	_putchar
;Z:\pn\z4\zad1.c:100: putchar(' ');
;     genCall
	mov	dpl,#0x20
	lcall	_putchar
;Z:\pn\z4\zad1.c:101: key = -1;
;     genAssign
	mov	_key,#0xFF
	mov	(_key + 1),#0xFF
;Z:\pn\z4\zad1.c:102: sleep(40);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x28)
	lcall	_sleep
;Z:\pn\z4\zad1.c:103: key_set = 0;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,a
;Z:\pn\z4\zad1.c:104: break;
;Z:\pn\z4\zad1.c:108: putchar('B');
;       Peephole 132   changed ljmp to sjmp
	sjmp 00108$
00102$:
;     genCall
	mov	dpl,#0x42
	lcall	_putchar
;Z:\pn\z4\zad1.c:109: putchar(' ');
;     genCall
	mov	dpl,#0x20
	lcall	_putchar
;Z:\pn\z4\zad1.c:110: key = -1;
;     genAssign
	mov	_key,#0xFF
	mov	(_key + 1),#0xFF
;Z:\pn\z4\zad1.c:111: sleep(40);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x28)
	lcall	_sleep
;Z:\pn\z4\zad1.c:112: key_set = 0;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,a
;Z:\pn\z4\zad1.c:113: break;
	ljmp	00108$
;Z:\pn\z4\zad1.c:116: putchar('C');
00103$:
;     genCall
	mov	dpl,#0x43
	lcall	_putchar
;Z:\pn\z4\zad1.c:117: putchar(' ');
;     genCall
	mov	dpl,#0x20
	lcall	_putchar
;Z:\pn\z4\zad1.c:118: key = -1;
;     genAssign
	mov	_key,#0xFF
	mov	(_key + 1),#0xFF
;Z:\pn\z4\zad1.c:119: sleep(40);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x28)
	lcall	_sleep
;Z:\pn\z4\zad1.c:120: key_set = 0;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,a
;Z:\pn\z4\zad1.c:122: break;
	ljmp	00108$
;Z:\pn\z4\zad1.c:125: putchar('D');
00104$:
;     genCall
	mov	dpl,#0x44
	lcall	_putchar
;Z:\pn\z4\zad1.c:126: putchar(' ');
;     genCall
	mov	dpl,#0x20
	lcall	_putchar
;Z:\pn\z4\zad1.c:127: key = -1;
;     genAssign
	mov	_key,#0xFF
	mov	(_key + 1),#0xFF
;Z:\pn\z4\zad1.c:128: sleep(40);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x28)
	lcall	_sleep
;Z:\pn\z4\zad1.c:129: key_set = 0;
;     genAssign
	clr	a
	mov	(_key_set + 1),a
	mov	_key_set,a
;Z:\pn\z4\zad1.c:130: break;
	ljmp	00108$
;Z:\pn\z4\zad1.c:134: }
00110$:
	ret
	.area CSEG    (CODE)
_klawiszZKolumny:
	.db #0xD0
	.db #0xE0
	.db #0x70
	.db #0xB0
_kolumna:
	.db #0xFD
	.db #0xFE
	.db #0xF7
	.db #0xFB
	.area XINIT   (CODE)
