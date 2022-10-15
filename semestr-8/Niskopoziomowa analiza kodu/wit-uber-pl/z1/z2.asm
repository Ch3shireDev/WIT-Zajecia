;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Wed May 18 15:32:00 2011

;--------------------------------------------------------
	.module z2
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _main
	.globl _U12
;--------------------------------------------------------
; special function registers
;--------------------------------------------------------
;--------------------------------------------------------
; special function bits 
;--------------------------------------------------------
_T1	=	0x00b4
;--------------------------------------------------------
; overlayable register banks 
;--------------------------------------------------------
	.area REG_BANK_0	(REL,OVR,DATA)
	.ds 8
;--------------------------------------------------------
; internal ram data
;--------------------------------------------------------
	.area DSEG    (DATA)
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
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\z1\z2.c:8: void main (void) {
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
	ar2 = 0x02
	ar3 = 0x03
	ar4 = 0x04
	ar5 = 0x05
	ar6 = 0x06
	ar7 = 0x07
	ar0 = 0x00
	ar1 = 0x01
;Z:\pn\z1\z2.c:9: unsigned char r=0;
;     genAssign
	mov	r2,#0x00
;Z:\pn\z1\z2.c:11: unsigned char on=0;
;     genAssign
	mov	r3,#0x00
;Z:\pn\z1\z2.c:12: unsigned char hz=50;
;     genAssign
	mov	r4,#0x32
00120$:
;Z:\pn\z1\z2.c:16: if (( U12 & 0x01 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r5,a
;     genAnd
	anl	ar5,#0x01
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r5,#0x00,00132$
;00134$:
;       Peephole 200   removed redundant sjmp
00135$:
;Z:\pn\z1\z2.c:18: on =1;
;     genAssign
	mov	r3,#0x01
;Z:\pn\z1\z2.c:21: while(on)
00132$:
;     genAssign
	mov	ar5,r2
00112$:
;     genAssign
	mov	ar2,r5
;     genIfx
	mov	a,r3
;     genIfxJump
;       Peephole 110   removed ljmp by inverse jump logic
	jz  00120$
00136$:
;Z:\pn\z1\z2.c:24: if (( r & 0x01) == 0) // maskowanie
;     genAnd
	mov	a,#0x01
	anl	a,r5
	mov	r6,a
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r6,#0x00,00104$
;00137$:
;       Peephole 200   removed redundant sjmp
00138$:
;Z:\pn\z1\z2.c:25: T1 = 1;
;     genAssign
	setb	_T1
;       Peephole 132   changed ljmp to sjmp
	sjmp 00105$
00104$:
;Z:\pn\z1\z2.c:27: T1 = 0;
;     genAssign
	clr	_T1
00105$:
;Z:\pn\z1\z2.c:28: r++;
;     genPlus
;     genPlusIncr
	inc	r5
;Z:\pn\z1\z2.c:29: for(i=0;i<hz;i++);
;     genAssign
	mov	r6,#0x00
00115$:
;     genCmpLt
;     genCmp
	clr	c
	mov	a,r6
	subb	a,r4
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00118$
00139$:
;     genPlus
;     genPlusIncr
	inc	r6
;       Peephole 132   changed ljmp to sjmp
	sjmp 00115$
00118$:
;Z:\pn\z1\z2.c:31: if (( U12 & 0x02 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r6,a
;     genAnd
	anl	ar6,#0x02
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r6,#0x00,00107$
;00140$:
;       Peephole 200   removed redundant sjmp
00141$:
;Z:\pn\z1\z2.c:33: on =0;
;     genAssign
	mov	r3,#0x00
00107$:
;Z:\pn\z1\z2.c:36: if (( U12 & 0x04 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r6,a
;     genAnd
	anl	ar6,#0x04
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r6,#0x00,00109$
;00142$:
;       Peephole 200   removed redundant sjmp
00143$:
;Z:\pn\z1\z2.c:39: hz++;
;     genPlus
;     genPlusIncr
	inc	r4
00109$:
;Z:\pn\z1\z2.c:42: if (( U12 & 0x08 )== 0 )
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r6,a
;     genAnd
	anl	ar6,#0x08
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r6,#0x00,00112$
;00144$:
;       Peephole 200   removed redundant sjmp
00145$:
;Z:\pn\z1\z2.c:44: hz--;
;     genMinus
;     genMinusDec
	dec	r4
	ljmp	00112$
00122$:
	ret
	.area CSEG    (CODE)
	.area XINIT   (CODE)
