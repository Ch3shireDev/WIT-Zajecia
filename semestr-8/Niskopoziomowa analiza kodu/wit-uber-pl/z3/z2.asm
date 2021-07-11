;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Tue Mar 29 12:58:28 2011

;--------------------------------------------------------
	.module z2
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _wybor_wysw
	.globl _w4
	.globl _w3
	.globl _w2
	.globl _w1
	.globl _main
	.globl _init
	.globl _func_isr
	.globl _czekaj
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
;Z:\pn\z3\z2.c:77: int t= 0;
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
;Allocation info for local variables in function 'czekaj'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z3\z2.c:67: void czekaj()
;	-----------------------------------------
;	 function czekaj
;	-----------------------------------------
_czekaj:
	ar2 = 0x02
	ar3 = 0x03
	ar4 = 0x04
	ar5 = 0x05
	ar6 = 0x06
	ar7 = 0x07
	ar0 = 0x00
	ar1 = 0x01
;Z:\pn\z3\z2.c:70: for( i= 0; i< 30000; i++);
;     genAssign
	mov	r2,#0x30
	mov	r3,#0x75
00103$:
;     genDjnz
;     genMinus
;     genMinusDec
	dec	r2
	cjne	r2,#0xff,00108$
	dec	r3
00108$:
;     genIfx
	mov	a,r2
	orl	a,r3
;     genIfxJump
;       Peephole 109   removed ljmp by inverse jump logic
	jnz  00103$
00109$:
00104$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'func_isr'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z3\z2.c:80: void func_isr (void) interrupt 3
;	-----------------------------------------
;	 function func_isr
;	-----------------------------------------
_func_isr:
	push	acc
	push	b
	push	dpl
	push	dph
	push	ar2
	push	ar0
	push	psw
	mov	psw,#0x00
;Z:\pn\z3\z2.c:82: if (t > 3) t = 0;
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
;Z:\pn\z3\z2.c:84: U15 = wybor_wysw[t];
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
;Z:\pn\z3\z2.c:85: U10 = cyfra_n;
;     genAssign
	mov	dptr,#_U10
;       Peephole 180   changed mov to clr
	clr  a
	movx	@dptr,a
;Z:\pn\z3\z2.c:86: U10 = zawart_wysw[t];
;     genPlus
	mov	a,_t
	add	a,#_zawart_wysw
	mov	r0,a
;     genPointerGet
;     genNearPointerGet
	mov	dptr,#_U10
	mov	a,@r0
	movx	@dptr,a
;Z:\pn\z3\z2.c:88: t++;
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
;Z:\pn\z3\z2.c:93: void init(void)
;	-----------------------------------------
;	 function init
;	-----------------------------------------
_init:
;Z:\pn\z3\z2.c:95: IE =	0x88;
;     genAssign
	mov	_IE,#0x88
;Z:\pn\z3\z2.c:96: TMOD =	0x20;  	    //tryb, nr licznika, czy z samoprzeladowaniem
;     genAssign
	mov	_TMOD,#0x20
;Z:\pn\z3\z2.c:98: TH1 = TL1 = 0;     //Wartosc startowa
;     genAssign
	mov	_TL1,#0x00
;     genAssign
	mov	_TH1,#0x00
;Z:\pn\z3\z2.c:100: TCON = 0x40;
;     genAssign
	mov	_TCON,#0x40
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;a                         Allocated to registers 
;------------------------------------------------------------
;Z:\pn\z3\z2.c:107: main (void){
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
;Z:\pn\z3\z2.c:108: init();
;     genCall
	lcall	_init
;Z:\pn\z3\z2.c:113: for (a=0;a<12;a++)
00112$:
;     genAssign
	mov	r2,#0x00
	mov	r3,#0x00
00104$:
;     genCmpLt
;     genCmp
	clr	c
	mov	a,r2
	subb	a,#0x0C
	mov	a,r3
	xrl	a,#0x80
	subb	a,#0x80
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00112$
00113$:
;Z:\pn\z3\z2.c:116: zawart_wysw[0] = w1[a];
;     genPlus
;       Peephole 236g
	mov  a,r2
	add	a,#_w1
	mov	dpl,a
;       Peephole 236g
	mov  a,r3
	addc	a,#(_w1 >> 8)
	mov	dph,a
;     genPointerGet
;     genCodePointerGet
	clr	a
	movc	a,@a+dptr
	mov	r4,a
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	_zawart_wysw,r4
;Z:\pn\z3\z2.c:118: zawart_wysw[1] = w2[a];
;     genPlus
;       Peephole 236g
	mov  a,r2
	add	a,#_w2
	mov	dpl,a
;       Peephole 236g
	mov  a,r3
	addc	a,#(_w2 >> 8)
	mov	dph,a
;     genPointerGet
;     genCodePointerGet
	clr	a
	movc	a,@a+dptr
	mov	r4,a
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_zawart_wysw + 0x0001),r4
;Z:\pn\z3\z2.c:120: zawart_wysw[2] = w3[a];
;     genPlus
;       Peephole 236g
	mov  a,r2
	add	a,#_w3
	mov	dpl,a
;       Peephole 236g
	mov  a,r3
	addc	a,#(_w3 >> 8)
	mov	dph,a
;     genPointerGet
;     genCodePointerGet
	clr	a
	movc	a,@a+dptr
	mov	r4,a
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_zawart_wysw + 0x0002),r4
;Z:\pn\z3\z2.c:122: zawart_wysw[3] = w4[a];
;     genPlus
;       Peephole 236g
	mov  a,r2
	add	a,#_w4
	mov	dpl,a
;       Peephole 236g
	mov  a,r3
	addc	a,#(_w4 >> 8)
	mov	dph,a
;     genPointerGet
;     genCodePointerGet
	clr	a
	movc	a,@a+dptr
	mov	r4,a
;     genPointerSet
;     genNearPointerSet
;     genDataPointerSet
	mov	(_zawart_wysw + 0x0003),r4
;Z:\pn\z3\z2.c:124: czekaj();
;     genCall
	push	ar2
	push	ar3
	lcall	_czekaj
	pop	ar3
	pop	ar2
;Z:\pn\z3\z2.c:125: czekaj();
;     genCall
	push	ar2
	push	ar3
	lcall	_czekaj
	pop	ar3
	pop	ar2
;Z:\pn\z3\z2.c:126: czekaj();
;     genCall
	push	ar2
	push	ar3
	lcall	_czekaj
	pop	ar3
	pop	ar2
;Z:\pn\z3\z2.c:127: czekaj();
;     genCall
	push	ar2
	push	ar3
	lcall	_czekaj
	pop	ar3
	pop	ar2
;Z:\pn\z3\z2.c:113: for (a=0;a<12;a++)
;     genPlus
;     genPlusIncr
	inc	r2
	cjne	r2,#0x00,00114$
	inc	r3
00114$:
	ljmp	00104$
00108$:
	ret
	.area CSEG    (CODE)
_w1:
	.db #0x0B
	.db #0x03
	.db #0x02
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x10
	.db #0x18
	.db #0x19
_w2:
	.db #0x00
	.db #0x02
	.db #0x02
	.db #0x02
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x10
	.db #0x10
	.db #0x10
	.db #0x00
_w3:
	.db #0x00
	.db #0x00
	.db #0x02
	.db #0x02
	.db #0x02
	.db #0x00
	.db #0x00
	.db #0x10
	.db #0x10
	.db #0x10
	.db #0x00
	.db #0x00
_w4:
	.db #0x00
	.db #0x00
	.db #0x00
	.db #0x02
	.db #0x06
	.db #0x46
	.db #0x54
	.db #0x50
	.db #0x10
	.db #0x00
	.db #0x00
	.db #0x00
_wybor_wysw:
	.db #0xDF
	.db #0xEF
	.db #0x7F
	.db #0xBF
	.area XINIT   (CODE)
