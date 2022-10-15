;--------------------------------------------------------
; File Created by SDCC : FreeWare ANSI-C Compiler
; Version 2.3.3 Wed May 18 13:08:19 2011

;--------------------------------------------------------
	.module under
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _klaw
	.globl _main
	.globl _czas
	.globl _strefa
	.globl _zmien_czas
	.globl _znak
	.globl _lcd_xy
	.globl _lcd_clear
	.globl _lcd_czas
	.globl _lcd_write
	.globl _lcd_init
	.globl _czekaj
	.globl _send_Date
	.globl _send_Command_4_bit
	.globl _send_Command_8_bit
	.globl _U10
	.globl _U12
	.globl _U15
	.globl _lcd_xy_PARM_2
	.globl __czas
	.globl __minuta
	.globl __godzina
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
__godzina::
	.ds 2
__minuta::
	.ds 2
__czas::
	.ds 2
_lcd_xy_PARM_2::
	.ds 1
;--------------------------------------------------------
; overlayable items in internal ram 
;--------------------------------------------------------
	.area	OSEG    (OVR,DATA)
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
;Z:\pn\projekt\under.c:19: int _czas = 0;
;     genAssign
	clr	a
	mov	(__czas + 1),a
	mov	__czas,a
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
;Allocation info for local variables in function 'send_Command_8_bit'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:21: void send_Command_8_bit(unsigned char polecenie)
;	-----------------------------------------
;	 function send_Command_8_bit
;	-----------------------------------------
_send_Command_8_bit:
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
;Z:\pn\projekt\under.c:23: P1=polecenie;
;     genAssign
	mov	_P1,r2
;Z:\pn\projekt\under.c:24: P1=polecenie | E;
;     genOr
	mov	a,#0x08
	orl	a,r2
	mov	_P1,a
;Z:\pn\projekt\under.c:25: P1=polecenie & !E;
;     genAnd
	mov	_P1,#0x00
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'send_Command_4_bit'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:28: void send_Command_4_bit(unsigned char polecenie)
;	-----------------------------------------
;	 function send_Command_4_bit
;	-----------------------------------------
_send_Command_4_bit:
;     genReceive
	mov	r2,dpl
;Z:\pn\projekt\under.c:30: P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
;     genAnd
	mov	a,#0xF0
	anl	a,r2
	mov	r3,a
;     genAssign
	mov	_P1,r3
;Z:\pn\projekt\under.c:31: P1=(polecenie & 0xf0) | E; //sygna³ „strob”
;     genOr
	mov	a,#0x08
	orl	a,r3
	mov	_P1,a
;Z:\pn\projekt\under.c:32: P1=(polecenie & 0xf0) & !E;
;     genAnd
	mov	_P1,#0x00
;Z:\pn\projekt\under.c:33: P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
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
;Z:\pn\projekt\under.c:34: P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
;     genOr
	mov	a,#0x08
	orl	a,r2
	mov	_P1,a
;Z:\pn\projekt\under.c:35: P1=((polecenie << 4) & 0xf0) & !E;
;     genAnd
	mov	_P1,#0x00
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'send_Date'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:38: void send_Date(unsigned char dana)
;	-----------------------------------------
;	 function send_Date
;	-----------------------------------------
_send_Date:
;     genReceive
	mov	r2,dpl
;Z:\pn\projekt\under.c:40: P1=(dana & 0xf0) | RS;
;     genAnd
	mov	a,#0xF0
	anl	a,r2
	mov	r3,a
;     genOr
	mov	a,#0x04
	orl	a,r3
	mov	_P1,a
;Z:\pn\projekt\under.c:41: P1=((dana & 0xf0) | E) | RS;
;     genOr
	mov	a,#0x08
	orl	a,r3
;     genOr
	orl	a,#0x04
	mov	_P1,a
;Z:\pn\projekt\under.c:42: P1=((dana & 0xf0) & !E) | RS;
;     genAnd
;       Peephole 180   changed mov to clr
	clr  a
;     genOr
	orl	a,#0x04
	mov	_P1,a
;Z:\pn\projekt\under.c:43: P1=((dana << 4) & 0xf0) | RS;
;    genLeftShift
;     genLeftShiftLiteral
;     genlshOne
	mov	a,r2
	swap	a
	anl	a,#0xf0
	mov	r2,a
;     genAnd
	anl	ar2,#0xF0
;     genOr
	mov	a,#0x04
	orl	a,r2
	mov	_P1,a
;Z:\pn\projekt\under.c:44: P1=(((dana << 4) & 0xf0) | E) | RS;
;     genOr
	mov	a,#0x08
	orl	a,r2
;     genOr
	orl	a,#0x04
	mov	_P1,a
;Z:\pn\projekt\under.c:45: P1=(((dana << 4) & 0xf0) & !E) | RS;
;     genAnd
;       Peephole 180   changed mov to clr
	clr  a
;     genOr
	orl	a,#0x04
	mov	_P1,a
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'czekaj'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:48: void czekaj(int d){
;	-----------------------------------------
;	 function czekaj
;	-----------------------------------------
_czekaj:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
;Z:\pn\projekt\under.c:50: for(i = 0; i<d; i++) {
;     genAssign
	mov	r4,#0x00
	mov	r5,#0x00
00104$:
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
	jnc  00108$
00114$:
;Z:\pn\projekt\under.c:51: for(j = 0; j < 256; j++) {
;     genAssign
	mov	r6,#0x00
	mov	r7,#0x01
00103$:
;     genDjnz
;     genMinus
;     genMinusDec
	dec	r6
	cjne	r6,#0xff,00115$
	dec	r7
00115$:
;     genIfx
	mov	a,r6
	orl	a,r7
;     genIfxJump
;       Peephole 109   removed ljmp by inverse jump logic
	jnz  00103$
00116$:
;Z:\pn\projekt\under.c:50: for(i = 0; i<d; i++) {
;     genPlus
;     genPlusIncr
;	tail increment optimized
	inc	r4
	cjne	r4,#0x00,00104$
	inc	r5
;       Peephole 132   changed ljmp to sjmp
	sjmp 00104$
00108$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'lcd_init'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:57: void lcd_init()
;	-----------------------------------------
;	 function lcd_init
;	-----------------------------------------
_lcd_init:
;Z:\pn\projekt\under.c:59: send_Command_8_bit(0x30);
;     genCall
	mov	dpl,#0x30
	lcall	_send_Command_8_bit
;Z:\pn\projekt\under.c:60: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:61: send_Command_8_bit(0x30);
;     genCall
	mov	dpl,#0x30
	lcall	_send_Command_8_bit
;Z:\pn\projekt\under.c:62: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:63: send_Command_8_bit(0x30);
;     genCall
	mov	dpl,#0x30
	lcall	_send_Command_8_bit
;Z:\pn\projekt\under.c:64: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:65: send_Command_8_bit(0x20);
;     genCall
	mov	dpl,#0x20
	lcall	_send_Command_8_bit
;Z:\pn\projekt\under.c:66: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:67: send_Command_4_bit(0x28);
;     genCall
	mov	dpl,#0x28
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:68: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:69: send_Command_4_bit(0x08);
;     genCall
	mov	dpl,#0x08
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:71: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:72: send_Command_4_bit(0x0E);
;     genCall
	mov	dpl,#0x0E
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:73: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
;Z:\pn\projekt\under.c:74: send_Command_4_bit(0x0E);
;     genCall
	mov	dpl,#0x0E
	lcall	_send_Command_4_bit
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'lcd_write'
;------------------------------------------------------------
;text                      Allocated to registers r2 r3 r4 
;------------------------------------------------------------
;Z:\pn\projekt\under.c:78: void lcd_write(char *text) {
;	-----------------------------------------
;	 function lcd_write
;	-----------------------------------------
_lcd_write:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
	mov	r4,b
;Z:\pn\projekt\under.c:79: while(*text) {
;     genAssign
00101$:
;     genPointerGet
;     genGenPointerGet
	mov	dpl,r2
	mov	dph,r3
	mov	b,r4
	lcall	__gptrget
;     genIfx
;       Peephole 105   removed redundant mov
	mov  r5,a
;     genIfxJump
;       Peephole 110   removed ljmp by inverse jump logic
	jz  00104$
00108$:
;Z:\pn\projekt\under.c:80: send_Date(*text);
;     genCall
	mov	dpl,r5
	push	ar2
	push	ar3
	push	ar4
	lcall	_send_Date
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:81: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	push	ar2
	push	ar3
	push	ar4
	lcall	_czekaj
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:82: *text++;
;     genPlus
;     genPlusIncr
;	tail increment optimized
	inc	r2
	cjne	r2,#0x00,00101$
	inc	r3
;       Peephole 132   changed ljmp to sjmp
	sjmp 00101$
00104$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'lcd_czas'
;------------------------------------------------------------
;text                      Allocated to registers r2 r3 r4 
;------------------------------------------------------------
;Z:\pn\projekt\under.c:86: void lcd_czas(char *text) {
;	-----------------------------------------
;	 function lcd_czas
;	-----------------------------------------
_lcd_czas:
;     genReceive
;Z:\pn\projekt\under.c:87: send_Date(*text);
;     genPointerGet
;     genGenPointerGet
	mov     r2,dpl
	mov     r3,dph
	mov     r4,b
;       Peephole 238d  removed 3 redundant moves
	lcall	__gptrget
	mov	r5,a
	inc	dptr
	mov	r2,dpl
	mov	r3,dph
	mov	r4,b
;     genCall
	mov	dpl,r5
	push	ar2
	push	ar3
	push	ar4
	lcall	_send_Date
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:88: *text++;
;Z:\pn\projekt\under.c:89: send_Date(*text);
;     genPointerGet
;     genGenPointerGet
	mov	dpl,r2
	mov	dph,r3
	mov	b,r4
	lcall	__gptrget
	mov	r2,a
;     genCall
	mov	dpl,r2
	lcall	_send_Date
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'lcd_clear'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:92: void lcd_clear(void) {
;	-----------------------------------------
;	 function lcd_clear
;	-----------------------------------------
_lcd_clear:
;Z:\pn\projekt\under.c:93: send_Command_4_bit(0x01);
;     genCall
	mov	dpl,#0x01
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:94: czekaj(20);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x14)
	lcall	_czekaj
;Z:\pn\projekt\under.c:95: send_Command_4_bit(0x02);
;     genCall
	mov	dpl,#0x02
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:96: czekaj(20);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x14)
	lcall	_czekaj
;Z:\pn\projekt\under.c:97: send_Command_4_bit(0x0D);
;     genCall
	mov	dpl,#0x0D
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:98: czekaj(20);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x14)
	lcall	_czekaj
;Z:\pn\projekt\under.c:100: send_Command_4_bit(0x80);   
;     genCall
	mov	dpl,#0x80
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:101: czekaj(50);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x32)
	lcall	_czekaj
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'lcd_xy'
;------------------------------------------------------------
;k                         Allocated to in memory with name '_lcd_xy_PARM_2'
;w                         Allocated to registers r2 
;------------------------------------------------------------
;Z:\pn\projekt\under.c:104: void lcd_xy(unsigned char w, unsigned char k)
;	-----------------------------------------
;	 function lcd_xy
;	-----------------------------------------
_lcd_xy:
;     genReceive
	mov	r2,dpl
;Z:\pn\projekt\under.c:106: send_Command_4_bit((w*0x40+k) | 0x80);
;     genMult
;     genMultOneByte
	mov	b,#0x40
	mov	a,r2
	mul	ab
	mov	r2,a
	mov	r3,b
;     genCast
	mov	r4,_lcd_xy_PARM_2
	mov	r5,#0x00
;     genPlus
;       Peephole 236g
	mov  a,r4
;       Peephole 236a
	add  a,r2
	mov	r2,a
;       Peephole 236g
	mov  a,r5
;       Peephole 236b
	addc  a,r3
	mov	r3,a
;     genOr
	orl	ar2,#0x80
;     genCast
	mov	dpl,r2
;     genCall
	lcall	_send_Command_4_bit
;Z:\pn\projekt\under.c:107: czekaj(20);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x14)
	lcall	_czekaj
00101$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'znak'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:110: char znak(int x) {
;	-----------------------------------------
;	 function znak
;	-----------------------------------------
_znak:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
;Z:\pn\projekt\under.c:111: switch(x) {
;     genCmpLt
;     genCmp
	mov	a,r3
;     genIfxJump
	jnb	acc.7,00116$
	ljmp	00112$
00116$:
;     genCmpGt
;     genCmp
	clr	c
	mov	a,#0x09
	subb	a,r2
;       Peephole 159   avoided xrl during execution
	mov  a,#(0x00 ^ 0x80)
	mov	b,r3
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 132   changed ljmp to sjmp
;       Peephole 160   removed sjmp by inverse jump logic
	jc   00112$
00117$:
;     genJumpTab
	mov	a,r2
	add	a,acc
	add	a,r2
	mov	dptr,#00118$
	jmp	@a+dptr
00118$:
	ljmp	00101$
	ljmp	00102$
	ljmp	00103$
	ljmp	00104$
	ljmp	00105$
	ljmp	00106$
	ljmp	00107$
	ljmp	00108$
	ljmp	00109$
	ljmp	00110$
;Z:\pn\projekt\under.c:113: return '0';
00101$:
;     genRet
	mov	dpl,#0x30
;Z:\pn\projekt\under.c:115: return '1';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00102$:
;     genRet
	mov	dpl,#0x31
;Z:\pn\projekt\under.c:117: return '2';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00103$:
;     genRet
	mov	dpl,#0x32
;Z:\pn\projekt\under.c:119: return '3';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00104$:
;     genRet
	mov	dpl,#0x33
;Z:\pn\projekt\under.c:121: return '4';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00105$:
;     genRet
	mov	dpl,#0x34
;Z:\pn\projekt\under.c:123: return '5';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00106$:
;     genRet
	mov	dpl,#0x35
;Z:\pn\projekt\under.c:125: return '6';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00107$:
;     genRet
	mov	dpl,#0x36
;Z:\pn\projekt\under.c:127: return '7';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00108$:
;     genRet
	mov	dpl,#0x37
;Z:\pn\projekt\under.c:129: return '8';
;       Peephole 132   changed ljmp to sjmp
	sjmp 00112$
00109$:
;     genRet
	mov	dpl,#0x38
;Z:\pn\projekt\under.c:131: return '9';
;       Peephole 132   changed ljmp to sjmp
;     genRet
;Z:\pn\projekt\under.c:132: }
;       Peephole 237a  removed sjmp to ret
	ret
00110$:
	mov     dpl,#0x39
00112$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'zmien_czas'
;------------------------------------------------------------
;czas                      Allocated to registers r2 r3 
;t2                        Allocated to registers r4 r5 
;t1                        Allocated to registers r6 r7 
;t                         Allocated to registers r2 r3 
;------------------------------------------------------------
;Z:\pn\projekt\under.c:135: void zmien_czas(int czas)
;	-----------------------------------------
;	 function zmien_czas
;	-----------------------------------------
_zmien_czas:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
;Z:\pn\projekt\under.c:139: int t = _godzina + czas;
;     genPlus
;       Peephole 236g
	mov  a,r2
	add	a,__godzina
	mov	r2,a
;       Peephole 236g
	mov  a,r3
	addc	a,(__godzina + 1)
	mov	r3,a
;Z:\pn\projekt\under.c:141: if(t >= 24)
;     genCmpLt
;     genCmp
	clr	c
	mov	a,r2
	subb	a,#0x18
	mov	a,r3
	xrl	a,#0x80
	subb	a,#0x80
;     genIfxJump
;       Peephole 132   changed ljmp to sjmp
;       Peephole 160   removed sjmp by inverse jump logic
	jc   00102$
00106$:
;Z:\pn\projekt\under.c:142: t = t - 24;
;     genMinus
	mov	a,r2
	add	a,#0xe8
	mov	r2,a
	mov	a,r3
	addc	a,#0xff
	mov	r3,a
00102$:
;Z:\pn\projekt\under.c:144: t2 = t / 10;
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,r2
	mov	dph,r3
	push	ar2
	push	ar3
	lcall	__divsint
	mov	a,dpl
	mov	b,dph
	pop	ar3
	pop	ar2
;     genAssign
	mov	r4,a
	mov	r5,b
;Z:\pn\projekt\under.c:146: t1 = t - t2*10;
;     genAssign
	clr	a
	mov	(__mulsint_PARM_2 + 1),a
	mov	__mulsint_PARM_2,#0x0A
;     genCall
	mov	dpl,r4
	mov	dph,r5
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	lcall	__mulsint
	mov	r6,dpl
	mov	r7,dph
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;     genMinus
	mov	a,r2
	clr	c
;       Peephole 236l
	subb  a,r6
	mov	r6,a
	mov	a,r3
;       Peephole 236l
	subb  a,r7
	mov	r7,a
;Z:\pn\projekt\under.c:148: lcd_xy(1, 0);
;     genAssign
	mov	_lcd_xy_PARM_2,#0x00
;     genCall
	mov	dpl,#0x01
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	_lcd_xy
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:150: send_Date(znak(t2));
;     genCall
	mov	dpl,r4
	mov	dph,r5
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	_znak
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;     genCall
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	_send_Date
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:151: send_Date(znak(t1));
;     genCall
	mov	dpl,r6
	mov	dph,r7
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	_znak
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;     genCall
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	_send_Date
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:152: lcd_write(" : ");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_0
	mov	b,#0x02
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	_lcd_write
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:154: t = _minuta;
;     genAssign
	mov	r2,__minuta
	mov	r3,(__minuta + 1)
;Z:\pn\projekt\under.c:155: t2 = t / 10;
;     genAssign
	clr	a
	mov	(__divsint_PARM_2 + 1),a
	mov	__divsint_PARM_2,#0x0A
;     genCall
	mov	dpl,r2
	mov	dph,r3
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	__divsint
	mov	a,dpl
	mov	b,dph
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;     genAssign
	mov	r4,a
	mov	r5,b
;Z:\pn\projekt\under.c:156: t1 = t - t2*10;
;     genAssign
	clr	a
	mov	(__mulsint_PARM_2 + 1),a
	mov	__mulsint_PARM_2,#0x0A
;     genCall
	mov	dpl,r4
	mov	dph,r5
	push	ar2
	push	ar3
	push	ar4
	push	ar5
	push	ar6
	push	ar7
	lcall	__mulsint
	mov	r0,dpl
	mov	r1,dph
	pop	ar7
	pop	ar6
	pop	ar5
	pop	ar4
	pop	ar3
	pop	ar2
;     genMinus
	mov	a,r2
	clr	c
;       Peephole 236l
	subb  a,r0
	mov	r6,a
	mov	a,r3
;       Peephole 236l
	subb  a,r1
	mov	r7,a
;Z:\pn\projekt\under.c:158: send_Date(znak(t2));
;     genCall
	mov	dpl,r4
	mov	dph,r5
	push	ar6
	push	ar7
	lcall	_znak
	pop	ar7
	pop	ar6
;     genCall
	push	ar6
	push	ar7
	lcall	_send_Date
	pop	ar7
	pop	ar6
;Z:\pn\projekt\under.c:159: send_Date(znak(t1));
;     genCall
	mov	dpl,r6
	mov	dph,r7
	lcall	_znak
;     genCall
	lcall	_send_Date
00103$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'strefa'
;------------------------------------------------------------
;s                         Allocated to registers r2 r3 
;------------------------------------------------------------
;Z:\pn\projekt\under.c:162: void strefa(int s) {
;	-----------------------------------------
;	 function strefa
;	-----------------------------------------
_strefa:
;     genReceive
	mov	r2,dpl
	mov	r3,dph
;Z:\pn\projekt\under.c:163: lcd_clear();
;     genCall
	push	ar2
	push	ar3
	lcall	_lcd_clear
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:164: lcd_xy(0, 0);
;     genAssign
	mov	_lcd_xy_PARM_2,#0x00
;     genCall
	mov	dpl,#0x00
	push	ar2
	push	ar3
	lcall	_lcd_xy
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:166: if(s == 0) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x00,00102$
	cjne r3,#0x00,00102$
;00127$:
;       Peephole 200   removed redundant sjmp
00128$:
;Z:\pn\projekt\under.c:167: lcd_write("Warszawa");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_1
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:168: zmien_czas(0);
;     genCall
;       Peephole 181   used 16 bit load of dptr
	mov  dptr,#0x0000
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00102$:
;Z:\pn\projekt\under.c:170: if(s == 1) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x01,00104$
	cjne r3,#0x00,00104$
;00129$:
;       Peephole 200   removed redundant sjmp
00130$:
;Z:\pn\projekt\under.c:171: lcd_write("Moskwa");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_2
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:172: zmien_czas(2);     
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x02)
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00104$:
;Z:\pn\projekt\under.c:174: if(s == 2) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x02,00106$
	cjne r3,#0x00,00106$
;00131$:
;       Peephole 200   removed redundant sjmp
00132$:
;Z:\pn\projekt\under.c:175: lcd_write("Tokio");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_3
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:176: zmien_czas(7);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x07)
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00106$:
;Z:\pn\projekt\under.c:178: if(s == 3) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x03,00108$
	cjne r3,#0x00,00108$
;00133$:
;       Peephole 200   removed redundant sjmp
00134$:
;Z:\pn\projekt\under.c:179: lcd_write("Londyn");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_4
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:180: zmien_czas(-1);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0xFF)<<8) + 0xFF)
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00108$:
;Z:\pn\projekt\under.c:182: if(s == 4) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x04,00110$
	cjne r3,#0x00,00110$
;00135$:
;       Peephole 200   removed redundant sjmp
00136$:
;Z:\pn\projekt\under.c:183: lcd_write("Chicago");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_5
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:184: zmien_czas(-5);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0xFF)<<8) + 0xFB)
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00110$:
;Z:\pn\projekt\under.c:186: if(s == 5) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x05,00112$
	cjne r3,#0x00,00112$
;00137$:
;       Peephole 200   removed redundant sjmp
00138$:
;Z:\pn\projekt\under.c:187: lcd_write("Kijow");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_6
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:188: zmien_czas(1);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x01)
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00112$:
;Z:\pn\projekt\under.c:190: if(s == 6) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x06,00114$
	cjne r3,#0x00,00114$
;00139$:
;       Peephole 200   removed redundant sjmp
00140$:
;Z:\pn\projekt\under.c:191: lcd_write("Pekin");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_7
	mov	b,#0x02
	push	ar2
	push	ar3
	lcall	_lcd_write
	pop	ar3
	pop	ar2
;Z:\pn\projekt\under.c:192: zmien_czas(5);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x05)
	push	ar2
	push	ar3
	lcall	_zmien_czas
	pop	ar3
	pop	ar2
00114$:
;Z:\pn\projekt\under.c:194: if(s == 7) {
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 198   optimized misc jump sequence
	cjne r2,#0x07,00116$
	cjne r3,#0x00,00116$
;00141$:
;       Peephole 200   removed redundant sjmp
00142$:
;Z:\pn\projekt\under.c:195: lcd_write("Bagdad");
;     genCall
;       Peephole 182a use 16 bit load of DPTR
	mov dptr,#__str_8
	mov	b,#0x02
	lcall	_lcd_write
;Z:\pn\projekt\under.c:196: zmien_czas(4);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x04)
	lcall	_zmien_czas
00116$:
;Z:\pn\projekt\under.c:198: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
00117$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'czas'
;------------------------------------------------------------
;------------------------------------------------------------
;Z:\pn\projekt\under.c:201: void czas(void) {
;	-----------------------------------------
;	 function czas
;	-----------------------------------------
_czas:
;Z:\pn\projekt\under.c:202: if(_czas == 500) {
;     genCmpEq
	mov	a,__czas
;       Peephole 132   changed ljmp to sjmp
;       Peephole 197   optimized misc jump sequence
	cjne a,#0xF4,00106$
	mov  a,(__czas + 1)
	cjne a,#0x01,00106$
;00112$:
;       Peephole 200   removed redundant sjmp
00113$:
;Z:\pn\projekt\under.c:203: _minuta++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,__minuta
	mov	__minuta,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(__minuta + 1)
	mov	(__minuta + 1),a
;Z:\pn\projekt\under.c:204: _czas = 0;
;     genAssign
	clr	a
	mov	(__czas + 1),a
	mov	__czas,a
;Z:\pn\projekt\under.c:206: if (_minuta>59){
;     genCmpGt
;     genCmp
	clr	c
	mov	a,#0x3B
	subb	a,__minuta
;       Peephole 159   avoided xrl during execution
	mov  a,#(0x00 ^ 0x80)
	mov	b,(__minuta + 1)
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00102$
00114$:
;Z:\pn\projekt\under.c:207: _minuta = 0;
;     genAssign
	clr	a
	mov	(__minuta + 1),a
	mov	__minuta,a
;Z:\pn\projekt\under.c:208: _godzina++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,__godzina
	mov	__godzina,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(__godzina + 1)
	mov	(__godzina + 1),a
00102$:
;Z:\pn\projekt\under.c:211: if (_godzina>23){
;     genCmpGt
;     genCmp
	clr	c
	mov	a,#0x17
	subb	a,__godzina
;       Peephole 159   avoided xrl during execution
	mov  a,#(0x00 ^ 0x80)
	mov	b,(__godzina + 1)
	xrl	b,#0x80
	subb	a,b
;     genIfxJump
;       Peephole 108   removed ljmp by inverse jump logic
	jnc  00106$
00115$:
;Z:\pn\projekt\under.c:212: _godzina++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,__godzina
	mov	__godzina,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(__godzina + 1)
	mov	(__godzina + 1),a
00106$:
;Z:\pn\projekt\under.c:215: _czas++;
;     genPlus
;     genPlusIncr
	mov	a,#0x01
	add	a,__czas
	mov	__czas,a
;       Peephole 180   changed mov to clr
	clr  a
	addc	a,(__czas + 1)
	mov	(__czas + 1),a
00107$:
	ret
;------------------------------------------------------------
;Allocation info for local variables in function 'main'
;------------------------------------------------------------
;c                         Allocated to registers 
;------------------------------------------------------------
;Z:\pn\projekt\under.c:218: void main(void) {
;	-----------------------------------------
;	 function main
;	-----------------------------------------
_main:
;Z:\pn\projekt\under.c:220: lcd_init();
;     genCall
	lcall	_lcd_init
;Z:\pn\projekt\under.c:221: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\under.c:222: lcd_clear();
;     genCall
	lcall	_lcd_clear
;Z:\pn\projekt\under.c:224: czekaj(100);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x64)
	lcall	_czekaj
;Z:\pn\projekt\under.c:225: lcd_clear();
;     genCall
	lcall	_lcd_clear
;Z:\pn\projekt\under.c:226: czekaj(500);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x01)<<8) + 0xF4)
	lcall	_czekaj
;Z:\pn\projekt\under.c:227: _godzina = 14;
;     genAssign
	clr	a
	mov	(__godzina + 1),a
	mov	__godzina,#0x0E
;Z:\pn\projekt\under.c:228: _minuta = 50;
;     genAssign
	clr	a
	mov	(__minuta + 1),a
	mov	__minuta,#0x32
;Z:\pn\projekt\under.c:231: for(c = 0; c < 4; c++) {
00117$:
;     genAssign
	mov	r2,#0x00
	mov	r3,#0x00
00108$:
;     genCmpLt
;     genCmp
	clr	c
	mov	a,r2
	subb	a,#0x04
	mov	a,r3
	xrl	a,#0x80
	subb	a,#0x80
;     genIfx
;     genIfxJump
;       Peephole 129   jump optimization
	jc   00119$
	ljmp	00111$
00119$:
;Z:\pn\projekt\under.c:232: U15 = klaw[c];
;    genLeftShift
;     genLeftShiftLiteral
;     genlshTwo
	mov	ar4,r2
	mov	a,r3
	xch	a,r4
	add	a,acc
	xch	a,r4
	rlc	a
	mov	r5,a
;     genPlus
;       Peephole 236g
	mov  a,r4
	add	a,#_klaw
	mov	dpl,a
;       Peephole 236g
	mov  a,r5
	addc	a,#(_klaw >> 8)
	mov	dph,a
;     genPointerGet
;     genCodePointerGet
	clr	a
	movc	a,@a+dptr
	mov	r4,a
	inc	dptr
	clr	a
	movc	a,@a+dptr
	mov	r5,a
;     genCast
	mov	dptr,#_U15
	mov	a,r4
	movx	@dptr,a
;Z:\pn\projekt\under.c:234: if((U12 & 0x10) == 0)
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r4,a
;     genAnd
	anl	ar4,#0x10
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r4,#0x00,00102$
;00120$:
;       Peephole 200   removed redundant sjmp
00121$:
;Z:\pn\projekt\under.c:235: strefa(c);
;     genCall
	mov	dpl,r2
	mov	dph,r3
	push	ar2
	push	ar3
	lcall	_strefa
	pop	ar3
	pop	ar2
00102$:
;Z:\pn\projekt\under.c:236: if((U12 & 0x20) == 0)
;     genAssign
	mov	dptr,#_U12
	movx	a,@dptr
	mov	r4,a
;     genAnd
	anl	ar4,#0x20
;     genCmpEq
;       Peephole 132   changed ljmp to sjmp
;       Peephole 199   optimized misc jump sequence
	cjne r4,#0x00,00110$
;00122$:
;       Peephole 200   removed redundant sjmp
00123$:
;Z:\pn\projekt\under.c:237: strefa(c+4);
;     genPlus
;     genPlusIncr
	mov	a,#0x04
;       Peephole 236a
	add  a,r2
	mov	dpl,a
;       Peephole 180   changed mov to clr
	clr  a
;       Peephole 236b
	addc  a,r3
	mov	dph,a
;     genCall
	push	ar2
	push	ar3
	lcall	_strefa
	pop	ar3
	pop	ar2
00110$:
;Z:\pn\projekt\under.c:231: for(c = 0; c < 4; c++) {
;     genPlus
;     genPlusIncr
	inc	r2
	cjne	r2,#0x00,00124$
	inc	r3
00124$:
	ljmp	00108$
00111$:
;Z:\pn\projekt\under.c:239: czekaj(10);
;     genCall
;       Peephole 182   used 16 bit load of dptr
	mov  dptr,#(((0x00)<<8) + 0x0A)
	lcall	_czekaj
;Z:\pn\projekt\under.c:240: czas();
;     genCall
	lcall	_czas
	ljmp	00117$
00112$:
	ret
	.area CSEG    (CODE)
_klaw:
	.byte #0xFE,#0x00
	.byte #0xFD,#0x00
	.byte #0xFB,#0x00
	.byte #0xF7,#0x00
__str_0:
	.ascii " : "
	.db 0x00
__str_1:
	.ascii "Warszawa"
	.db 0x00
__str_2:
	.ascii "Moskwa"
	.db 0x00
__str_3:
	.ascii "Tokio"
	.db 0x00
__str_4:
	.ascii "Londyn"
	.db 0x00
__str_5:
	.ascii "Chicago"
	.db 0x00
__str_6:
	.ascii "Kijow"
	.db 0x00
__str_7:
	.ascii "Pekin"
	.db 0x00
__str_8:
	.ascii "Bagdad"
	.db 0x00
	.area XINIT   (CODE)
