xdata at 0x8000 unsigned char U15;
xdata at 0x8000 unsigned char U12;
xdata at 0xFFFF unsigned char U10;

sfr at 0xA8 IE;
sfr at 0x89 TMOD;
sfr at 0x8D TH1;
sfr at 0x8b TL1;
sfr at 0x88 TCON;
sfr at 0x99 SBUF;
sfr at 0x98 SCON;
sfr at 0x87 PCON;
sbit at 0X98 RI;
sbit at 0X99 TI;

const unsigned char klawiszZKolumny[4] = { 0xd0, 0xe0, 0x70, 0xb0 }; // tablica klawiszy w kolumnach
const unsigned char kolumna[4] = { 0xfd, 0xfe, 0xf7, 0xfb}; 		 // tablica kolumn klawiszy
int key =-1;		//zmienna do przekazywania, ktory guzik zostal wcisniety
int t = 0;			//zmienna do iterowania kolumn
int key_set = 0;	//zmienna informujaca, o tym, ze wcisniety klawisz zostal przetworzony


void sleep(int d){
	int i;
	for(i=0; i<d; i++);
}

void func_isr (void) interrupt 3
{
	
	//U15=0x00;
	
	U15 = kolumna[t];
	 	
     if (((U12 & 0xf0) == klawiszZKolumny[2])&& key_set == 0 && t == 2) 
		{
			key =3;
			key_set = 1;
     	}
     	
     if (((U12 & 0xf0) == klawiszZKolumny[3]) && key_set == 0 && t == 2) 
     	{
     		key =1;
    	 	key_set = 1;
     	}	
      if (((U12 & 0xf0) == klawiszZKolumny[2])&& key_set == 0 && t == 3) 
      	{
      		key =2;
      		key_set = 1;
    	}    
         
      if (((U12 & 0xf0) == klawiszZKolumny[3])&& key_set == 0 && t == 3)  
     	{
      		key =0;
      		key_set = 1;
      	}
      
   t++;
   //if(t==4) t=0;
   t=t%4;
   
} 




void init(void)
{

	SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
	
	TMOD &=	0x0F;	//konfiguracja licznika
    TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
	
	TH1 = TL1 =253;     //Wartosc startowa
  	TCON = 0x40;
  	PCON = 0x80;
	IE =	0x88;


	
}

void putchar(char znak)
{
    SBUF = znak;
    while(TI==0);
    TI=0;
}

main (void){
init();
	
	for (;;)
	{
		switch(key){
		
		case 0 :
		putchar('A');
		putchar(' ');
		key = -1;
		sleep(40);
		key_set = 0;
		break;
		

		case 1 :
		putchar('B');
		putchar(' ');
		key = -1;
		sleep(40);
		key_set = 0;
		break;

		case 2 :
		putchar('C');
		putchar(' ');
		key = -1;
		sleep(40);
		key_set = 0;
		
		break;

		case 3 :
		putchar('D');
		putchar(' ');
		key = -1;
		sleep(40);
		key_set = 0;
		break;
		
		default :
		break;
		}

	}

}
