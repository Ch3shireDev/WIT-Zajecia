;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Tue Mar 29 12:06:18 2011

;--------------------------------------------------------
	.module z1
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _wybor_wysw
	.globl _main
	.globl _init
	.globl _func_isr
	.globl _U10
	.globl _U15
	.globl _t
	.globl _zawart_wysw
;--------------------------------------------------------
; special function registers
;--------------------------------------------------------
_IE	=	0x00a8
_TMOD	=	0x0089
_TH1	=	0x008d
_TL1	=	0x008b
_TCON	=	0x0088
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
_zawart_wysw::
	.ds 4
_t::
	.ds 2
;--------------------------------------------------------
; overlayable items in internal ram 
;--------------------------------------------------------
	.area OSEG    (OVR,DATA)
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
;N:\pn\z3\z1.c:44: int t= 0;
;     genAssign
	clr	a
	mov	(_t + 1),a
	mov	_t,a
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
;Allocation info for local variables in function 'func_isr'
;------------------------------------------------------------
;------------------------------------------------------------
;N:\pn\z3\z1.c:47: void func_isr (void) interrupt 3
;	-----------------------------------------
;	 function func_isr
;	-----------------------------------------
_func_isr:
	ar2 = 0x02
	ar3 = 0x03
	ar4 = 0x04
	ar5 = 0x05
	ar6 = 0x06
	ar7 = 0x07
	ar0 = 0x00
	ar1 = 0x01
	push	acc
	push	b
	push	dpl
	push	dph
	push	ar2
	push	ar0
	push	psw
	mov	psw,#0x00
;N:\pn\z3\z1.c:49: if (t > 3) t = 0;
;     genCmpGt
;     genCmp
	clr	c
	mov	a,#0x03
	subb	a,_t
;       Peephole 159   avoided xrl during execution
	mov  a,#(0x00 ^ 0x80)
	mov	b,(_t + 1)
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00102$
00106$:
;     genAssign
	clr	a
	mov	(_t + 1),a
	mov	_t,a
00102$:
;N:\pn\z3\z1.c:52: U15 = wybor_wysw[t];
;     genPlus
	mov	a,_t
	add	a,#_wybor_wysw
	mov	dpl,a
	mov	a,(_t + 1)
	addc	a,#(_wybor_wysw >> 8)
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
;N:\pn\z3\z1.c:53: U10 = cyfra_n;
;     genAssign
	mov	dptr,#_U10
;       Peephole 180   changed mov to clr
	clr  a
	movx	@dptr,a
;N:\pn\z3\z1.c:54: U10 = zawart_wysw[t];
;     genPlus
	mov	a,_t
	add	a,#_zawart_wysw
	mov	r0,a
;     genPointerGet
;     genNearPointerGet
	mov	dptr,#_U10
	mov	a,@r0
	movx	@dptr,a
;N:\pn\z3\z1.c:56: t++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,_t
	mov	_t,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(_t + 1)
	mov	(_t + 1),a
00103$:
	pop	psw
	pop	ar0
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
;N:\pn\z3\z1.c:60: void init(void)
;	-----------------------------------------
;	 function init
;	-----------------------------------------
_init:
;N:\pn\z3\z1.c:62: IE =	0x88;
;     genAssign
	mov	_IE,#0x88
;N:\pn\z3\z1.c:63: TMOD =	0x20;  	    //tryb, nr licznika, czy z samoprzeladowaniem
;     genAssign
	mov	_TMOD,#0x20
;N:\pn\z3\z1.c:65: TH1 = TL1 = 0;     //Wartosc startowa
;     genAssign
	mov	_TL1,#0x00
;     genAssign
	mov	_TH1,#0x00
;N:\pn\z3\z1.c:67: TCON = 0x40;
;     genAssign
	mov	_TCON,#0x40
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;------------------------------------------------------------
;N:\pn\z3\z1.c:72: main (void){
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
;N:\pn\z3\z1.c:73: init();
;     genCall
	lcall	_init
;N:\pn\z3\z1.c:75: zawart_wysw[3] = cyfra_5;
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_zawart_wysw + 0x0003),#0x73
;N:\pn\z3\z1.c:76: zawart_wysw[2] = cyfra_6;
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_zawart_wysw + 0x0002),#0x7B
;N:\pn\z3\z1.c:77: zawart_wysw[1] = cyfra_4;
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_zawart_wysw + 0x0001),#0x65
;N:\pn\z3\z1.c:78: zawart_wysw[0] = cyfra_9;
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	_zawart_wysw,#0x77
00102$:
;       Peephole 132   changed ljmp to sjmp
	sjmp 00102$
00104$:
	ret
	.area CSEG    (CODE)
_wybor_wysw:
	.db #0xDF
	.db #0xEF
	.db #0x7F
	.db #0xBF
	.area XINIT   (CODE)
