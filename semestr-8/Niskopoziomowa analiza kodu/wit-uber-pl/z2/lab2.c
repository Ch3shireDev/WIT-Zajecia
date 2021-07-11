#include <math.h>

sfr at 0x99 SBUF;
sfr at 0x98 SCON;
sfr at 0x89 TMOD;
sfr at 0x8d TH1;
sfr at 0x8b TL1;
sfr at 0x88 TCON;
sfr at 0x87 PCON;

sbit at 0X98 RI;
sbit at 0X99 TI;



void init()
{
    SCON = 0x50;	//konfiguracja rs232 (L1, 8-bit, samoprzeladowalny)
    TMOD &=	0x0F;	//konfiguracja licznika
    TMOD |=	0x20;	//czy uzywamy licznika 0 czy 1 tryb z samo przeladowaniem czy bez
    TH1 = TL1 = 253;	//wartosc startowa rejestr jest 16 bitowy
    TCON =	0x40;	//uruchomienie
    PCON = 0x80;

}

char getchar()
{
    char znak;
    while(RI == 0);
    RI = 0;

    znak = SBUF;
    return znak;
}

void putchar(char znak)
{
    SBUF = znak;
    while(TI==0);
    TI=0;

}

unsigned int get_number()
{
    char znak = 'a';

    char tab[5];

    int liczba = 0;
    int i =0;
    int ile_cyfr;
    int j;
    int rzut_znak;
    int pot;

    tab[0] = '0';
    tab[1] = '0';
    tab[2] = '0';
    tab[3] = '0';



    while(znak != ' ')
    {
        znak=getch();
        tab[i]=znak;
        i++;
    }

    ile_cyfr = i -1 ;
    for (j=0 ; j<i-1; j++)
    {

        ile_cyfr--;
        // putchar(tab[j]);
        rzut_znak =(tab[j] - '0');
        //pot = 10^ile_cyfr;
        pot=10;
        pot=pow(pot, ile_cyfr);

        liczba = liczba + rzut_znak*pot;
        //liczba = rzut_znak;


    }

    return liczba;


}


void put_number(unsigned int liczba)
{
    char znak;
//    int x;
    int i, j;
    int start;

    i=0;
    start = 0;

    char tablica[4];


    if( (liczba/1000) != 0 )
    {
        tablica[i++] = (liczba/1000)+ '0';
        start = 1;
    }

    if ((liczba%1000)/100 != 0 || start == 1)
    {
        tablica[i++] = ((liczba%1000)/100)+ '0';
    }

    if (((liczba%100)/10) != 0 || start == 1)
    {
        tablica[i++] = ((liczba%100)/10)+ '0';
    }

    if ( (liczba%10) != 0 || start == 1)
    {
        tablica[i++] = (liczba%10)+ '0';
    }



    for (j=0; j<i; j++)
    {
        putchar(tablica[j]);

    }
}


main(void)
{
    char c;
    unsigned int liczba;
    init();
    for(;;)
    {

        liczba = get_number();

        liczba+=200;

        printf("lala: %d \n",liczba);

        put_number(liczba);



    }
}
