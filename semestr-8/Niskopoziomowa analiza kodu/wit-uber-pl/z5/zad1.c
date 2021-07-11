sfr at 0x90 P1; //wyswietlacz LCD
char E = 0x08;
char RS = 0x04;

char produkt[6];

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

void init()
{
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
	wyslij_polecenie4(0x0E); //15
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

int i;
int j = 0;
int cyfry=1;

void wyswietl_iloczyn(int x, int y)
{
	int iloczyn = x * y;

	for (i = 0; i<6; i++)
		produkt[i] = 0;


		for (i = 0; i<6; i++)
		{
			if ( iloczyn > cyfry)
			{
			j++;
			cyfry = cyfry * 10;
			}

		}


		produkt[5] = '0' + (iloczyn / 100000);

		iloczyn = iloczyn %100000;

		produkt[4] = '0' + (iloczyn / 10000);

		iloczyn = iloczyn %10000;

		produkt[3] = '0' + (iloczyn / 1000);

		iloczyn = iloczyn %1000;

		produkt[2] = '0' + (iloczyn / 100);

		iloczyn = iloczyn %100;

		produkt[1] = '0' + (iloczyn / 10);

		iloczyn = iloczyn %10;

		produkt[0] = '0' + (iloczyn / 1);


	for (i = j-1; i>=0; i--)
	{
		wyslij_dane(produkt[i]);
		czekaj(100);
	}

}

void wyswietl_iloczyn_v2(int x, int y)
{
    int iloczyn = x * y;

	for (i = 0; i<6; i++)
		produkt[i] = 0;


		for (i = 0; i<6; i++)
		{
			if ( iloczyn > cyfry)
			{
			j++;
			cyfry = cyfry * 10;
			}

		}
		int dzielnik;
		dzielnik = 100000;

    for (i = 5; i>=0; i--)
	{

        produkt[i] = '0' + (iloczyn / dzielnik);
        iloczyn = iloczyn %dzielnik;
        dzielnik = dzielnik/10;

	}

	for (i = j-1; i>=0; i--)
	{
		wyslij_dane(produkt[i]);
		czekaj(100);
	}



}

void wyswietl_iloczyn_v3(int x, int y)
{
    int iloczyn = x * y;

//	for (i = 0; i<6; i++)
//		produkt[i] = 0;


		for (i = 0; i<6; i++)
		{
			if ( iloczyn > cyfry)
			{
			j++;
			cyfry = cyfry * 10;
			}

		}

    for (i = j-1; i>=0; i--)
	{

        produkt[i] = '0' + (iloczyn / cyfry);
        iloczyn = iloczyn %cyfry;
        cyfry = cyfry/10;
        wyslij_dane(produkt[i]);
		czekaj(100);

	}





}




void main(void)
{
  init();
    czekaj(100);
    wyslij_polecenie4(0x01);
    czekaj(100);
	czekaj(100);
czekaj(100);




  gotoXY(5,1);
  czekaj(100);

wyswietl_iloczyn(10,12);

  //wyslij_dane('A');
    //czekaj(100);
      //czekaj(100);
  //wyslij_dane('B');


}


pow (int a, int t)
{

    int wynik;
    int i;

    wynik = a;

    for (i =0; i< t; i++)
        wynik = wynik * a;

    return wynik;

}


