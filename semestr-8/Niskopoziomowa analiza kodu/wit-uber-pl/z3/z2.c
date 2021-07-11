xdata at 0x8000 unsigned char U15;
xdata at 0xFFFF unsigned char U10;

sfr at 0xA8 IE;

sfr at 0x89 TMOD;
sfr at 0x8D TH1;
sfr at 0x8b TL1;
sfr at 0x88 TCON;


#define SEG_A 0x02
#define SEG_B 0x04
#define SEG_C 0x40
#define SEG_D 0x10
#define SEG_E 0x08
#define SEG_F 0x01
#define SEG_G 0x20
#define SEG_H 0x80


#define cyfra_n 0
#define cyfra_0 SEG_A | SEG_B | SEG_C | SEG_D | SEG_E | SEG_F
#define cyfra_1 SEG_B | SEG_C
#define cyfra_2 SEG_A | SEG_B | SEG_D | SEG_E | SEG_G
#define cyfra_3 SEG_A | SEG_B | SEG_C | SEG_D | SEG_G
#define cyfra_4 SEG_B | SEG_C | SEG_F | SEG_G
#define cyfra_5 SEG_A | SEG_C | SEG_D | SEG_F | SEG_G
#define cyfra_6 SEG_A | SEG_C | SEG_D | SEG_E | SEG_F | SEG_G
#define cyfra_7 SEG_A | SEG_B | SEG_C
#define cyfra_8 SEG_A | SEG_B | SEG_C | SEG_D | SEG_E | SEG_F | SEG_G
#define cyfra_9 SEG_A | SEG_B | SEG_C | SEG_D | SEG_F | SEG_G
#define cyfra_a SEG_A | SEG_B | SEG_C | SEG_E | SEG_F | SEG_G
#define cyfra_b SEG_C | SEG_D | SEG_E | SEG_F | SEG_G
#define cyfra_c SEG_A | SEG_D | SEG_E | SEG_F
#define cyfra_d SEG_B | SEG_C | SEG_D | SEG_E | SEG_G
#define cyfra_e SEG_A | SEG_D | SEG_E | SEG_F | SEG_G
#define cyfra_f SEG_A | SEG_E | SEG_F | SEG_G


#define cyfra_n 0


#define cyfra_up SEG_A
#define cyfra_up_right_up SEG_A | SEG_B
#define cyfra_right_up SEG_B
#define cyfra_right_down SEG_C
#define cyfra_down_right_down SEG_C | SEG_D
#define cyfra_down SEG_D
#define cyfra_down_left_down SEG_D | SEG_E
#define cyfra_left_down SEG_E
#define cyfra_left_up SEG_F
#define cyfra_up_left_up SEG_A | SEG_F

#define cyfra_up_left SEG_A | SEG_E| SEG_F
#define cyfra_down_left SEG_D | SEG_E| SEG_F

#define cyfra_up_right SEG_A | SEG_B| SEG_C
#define cyfra_down_right SEG_B | SEG_C| SEG_D


const char w1[12]  = {cyfra_up_left, cyfra_up_left_up, cyfra_up, cyfra_n, cyfra_n, cyfra_n, cyfra_n, cyfra_n, cyfra_n, cyfra_down, cyfra_down_left_down, cyfra_down_left};    
const char w2[12]  = {cyfra_n, cyfra_up, cyfra_up, cyfra_up, cyfra_n, cyfra_n, cyfra_n, cyfra_n, cyfra_down, cyfra_down, cyfra_down, cyfra_n}; 
const char w3[12] = {cyfra_n, cyfra_n, cyfra_up, cyfra_up, cyfra_up, cyfra_n, cyfra_n, cyfra_down, cyfra_down, cyfra_down, cyfra_n, cyfra_n}; 
const char w4 [12] = {cyfra_n, cyfra_n, cyfra_n, cyfra_up, cyfra_up_right_up, cyfra_up_right, cyfra_down_right, cyfra_down_right_down, cyfra_down, cyfra_n, cyfra_n, cyfra_n}; 

void czekaj()
{
	int i;
	for( i= 0; i< 30000; i++);

}

char zawart_wysw[4];
const char wybor_wysw[4] = { 0xdf, 0xef, 0x7f, 0xbf };

int t= 0;


void func_isr (void) interrupt 3
{
	if (t > 3) t = 0;
	
	U15 = wybor_wysw[t];
	U10 = cyfra_n;
	U10 = zawart_wysw[t];

	t++;


}

void init(void)
{
	IE =	0x88;
        TMOD =	0x20;  	    //tryb, nr licznika, czy z samoprzeladowaniem
  	
  	TH1 = TL1 = 0;     //Wartosc startowa

  	TCON = 0x40;
  
	
}



main (void){
init();


while(1){
 int a;	
for (a=0;a<12;a++)
{

	zawart_wysw[0] = w1[a];	
	zawart_wysw[1] = w2[a];
	zawart_wysw[2] = w3[a];
	zawart_wysw[3] = w4[a];

	czekaj();
	czekaj();
	czekaj();
	czekaj();


}
}

}
