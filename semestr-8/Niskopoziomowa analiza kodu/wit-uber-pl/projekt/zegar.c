xdata at 0x8000 unsigned char U12;

sbit at 0xB4 T1; // speeker
sfr at 0x90 P1; //wyswietlacz LCD
char E = 0x08;
char RS = 0x04;

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


char produkt[6];

int godz;
int min;
int sek;
int alarm_godz = 0;
int alarm_min = 0;
int alarm_on =0;
int stop = 0;

int dlugosc_sekundy = 23500;


void wyslij_polecenie8(unsigned char polecenie)
{
 P1=polecenie;
 P1=polecenie | E; //gdzie E – jest mask¹ bitow¹ "ustawiaj¹c¹" liniê E – nale¿y j¹
		   // wyznaczyæ na podstawie znanego przypisania linii
                   // steruj¹cych do odpowiednich linii portu P1


 P1=polecenie & !E; //gdzie !E – jest zanegowana maska bitowa, zeruj¹c¹ linie E –
                    // nale¿y j¹ wyznaczyæ - jak wy¿ej
}

void wyslij_polecenie4(unsigned char polecenie)
{
  P1=polecenie & 0xf0; //najpierw starsza po³ówka bajtu
  P1=(polecenie & 0xf0) | E; //sygna³ „strob”
  P1=(polecenie & 0xf0) & !E;
  P1=(polecenie << 4) & 0xf0; //teraz m³odsza po³ówka bajtu
  P1=((polecenie << 4) & 0xf0) | E; //sygna³ „strob”
  P1=((polecenie << 4) & 0xf0) & !E;
}

void wyslij_dane(unsigned char dana)
{
  P1=(dana & 0xf0) | RS;
  P1=((dana & 0xf0) | E) | RS;
  P1=((dana & 0xf0) & !E) | RS;
  P1=((dana << 4) & 0xf0) | RS;
  P1=(((dana << 4) & 0xf0) | E) | RS;
  P1=(((dana << 4) & 0xf0) & !E) | RS;
}

void czekaj(int d){
	int i;
	for(i=0; i<d; i++){
	_asm
		nop
	_endasm;

	}
}


int key_set = 0;	//zmienna informujaca, o tym, ze wcisniety klawisz zostal przetworzony


int t;


void func_isr (void) interrupt 3
{

   t++;
   if(t==dlugosc_sekundy){
    	t=0;
    	sek++;
    	
    	}
  
}



void init()
{
	SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
	
	TMOD &=	0x0F;	//konfiguracja licznika
    	TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
	
	TH1 = TL1 = 253;     //Wartosc startowa
  	TCON = 0x40;
  	PCON = 0x80;
	IE =	0x88;


	wyslij_polecenie8(0x30); //3
	czekaj(100);
	wyslij_polecenie8(0x30); //5
	czekaj(100);
	wyslij_polecenie8(0x30); //7
	czekaj(100);
	wyslij_polecenie8(0x20); //9
	czekaj(100);
	wyslij_polecenie4(0x2F); //11
	czekaj(100);
	wyslij_polecenie4(0x08); //13
	czekaj(100);
	//wyslij_polecenie4(0x0E); //15
	wyslij_polecenie4(0x0C); //15 -- mod na wylaczenie kursora
	
	czekaj(100);
	wyslij_polecenie4(0x06); //17
	czekaj(100);
}

void gotoXY(unsigned char x, unsigned char y)
{
  char i;
  if(y==0)
  {
    i = 128;
  }
  else
  {
     i = 192;
  }
  i |= x;
  wyslij_polecenie4(i);
}

void czas(){
    	
    	if (sek==59)
    		{
    		min++;
    		sek = 0;
    		
    		if (min == 60) 
    			{
    				godz++;
    				min = 0;
    				if(godz == 24)
    				godz = 0;
    				
    			}
    		
    		}
    		
    	else {	
	sek = sek%59;
    	}
}

void wyswietl_godz()
{
    czas();
    
    wyslij_dane('0' + godz / 10 );
    czekaj(100);
    wyslij_dane('0' + godz % 10 );
    czekaj(100);
    wyslij_dane(':');
    czekaj(100);
    wyslij_dane('0' + min / 10 );
    czekaj(100);
    wyslij_dane('0' + min % 10 );
    czekaj(100);
    wyslij_dane(':');
    czekaj(100);
    wyslij_dane('0' + sek / 10 );
    czekaj(100);
    wyslij_dane('0' + sek % 10 );
    czekaj(100);
    gotoXY(0,0);     
    czekaj(100);
    czekaj(100);
}

void alarm(){
	
	unsigned char r=0;
	unsigned char hz=10;
	unsigned char i=0;
	int j;

	while (alarm_godz == godz && alarm_min == min && alarm_on == 1 && stop == 0)
	{
		
			
			//while(stop == 0)
			//{
			
			for(j=0;j<100;j++){
				if (( r & 0x01) == 0) // maskowanie
					T1 = 1;
				else
					T1 = 0;
				r++;
				for(i=0;i<hz;i++);
			
			}
			
						
				if (( U12 & 0x08 )== 0 )
				{
					stop=1;
					alarm_on=0;
					wyslij_polecenie4(0x01);
				}
				
				if (( U12 & 0x01 )== 0 )
				{
					alarm_godz =(alarm_godz +1)%24;
				}
			
		
				if (( U12 & 0x02 )== 0 )
				{
					alarm_min = (alarm_min +1)%60;
				}
			
			
			wyswietl_godz();
			
			
			
			//}
		 	
	
	
	}
	
}

void wyswietl_alarm()
{
	if(alarm_on == 1)
	{
    		gotoXY(0,1); 
    		wyslij_dane('0' + alarm_godz / 10 );
    		czekaj(100);
		wyslij_dane('0' + alarm_godz % 10 );
		czekaj(100);
		wyslij_dane(':');
		czekaj(100);
		wyslij_dane('0' + alarm_min / 10 );
		czekaj(100);
		wyslij_dane('0' + alarm_min % 10 );
		czekaj(100);
		gotoXY(0,0);     
		czekaj(100);
		czekaj(100);
	}

		
}





void main(void)
{
  init();
  
  t=0;
  czekaj(100);
  wyslij_polecenie4(0x01);
  czekaj(100);
  czekaj(100);
  czekaj(100);
  
  godz =11;
  min = 30;
  sek= 55;
  //alarm_on =1;
    wyswietl_godz();
  
  for(;;)
  {
   
		if (alarm_on == 0)
		{
		
			if (( U12 & 0x01 )== 0 )
			{
				godz =(godz +1)%24;
			}
			
		
			if (( U12 & 0x02 )== 0 )
			{
				min = (min +1)%60;
			}
		
			if (( U12 & 0x04 )== 0 )
			{
			
				sek=0;
			}
		
			if (( U12 & 0x08 )== 0 )
			{
				alarm_on=1;
				stop = 0;
			}
		}
		else if(alarm_on == 1)
		{
			if (( U12 & 0x01 )== 0 )
			{
				alarm_godz =(alarm_godz +1)%24;
			}
			
		
			if (( U12 & 0x02 )== 0 )
			{
				alarm_min = (alarm_min +1)%60;
			}
		
			if (( U12 & 0x04 )== 0 )
			{
			
				;
			}
		
			if (( U12 & 0x08 )== 0 )
			{
				alarm_on=0;
				wyslij_polecenie4(0x01);
			}
		
		
		}
		
		

  
  	wyswietl_godz();
 	wyswietl_alarm();
 	alarm();
	}


}



