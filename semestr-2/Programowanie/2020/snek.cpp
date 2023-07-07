#include <iostream>
#include <windows.h>
#include <conio.h>
#include <time.h>
#include <cstdio>
#include <string>
/* KONIEC */

/*! DEFINICJE MAKR !*/
#define NIEBIESKI 8700  /* Numer specjalny koloru. */
#define ZIELONY 8701    /* Numer specjalny koloru. */
#define CZERWONY 8702   /* Numer specjalny koloru. */
#define ZOLTY 8703      /* Numer specjalny koloru. */
#define BLEKIT 8704     /* Numer specjalny koloru. */
#define FIOLETOWY 8705  /* Numer specjalny koloru. */
#define ZEGAR 2719      /* Numer specjalny zegara. */
/* KONIEC */

typedef COORD PunktNaMapie; /* Utworzenie typu pochodnego od COORD z WinApi
dla wygody pracy. Struktura COORD zawiera dwie wspolrzedne konsoli:
a) |Kolumna - COORD.X| --> |Kolumna - PunktNaMapie.X|
b) |Wiersz - COORD.Y| --> |Wiersz - PunktNaMapie.Y|
*/

/*! Deklaracje funkcji !*/ /* W dalszej czesci kodu znajduja sie definicje ich ciala */
void Kolorek( int KOLOR );
void ZmienPozycjeKursora( PunktNaMapie Wspolrzedne );
void StworzMape();
int Menu( int & Petla );
void Sterowanie( PunktNaMapie & Waz, double & Czas, int & IloscRuchow, PunktNaMapie IleRuchow );
void RysujOwoc( PunktNaMapie & Owoc, PunktNaMapie & Waz, int IdentyfikatorOwocaX[], int IdentyfikatorOwocaY[], int & NumerOwoca );
bool CzyZebrano( PunktNaMapie & Waz, int IdentyfikatorOwocaX[], int IdentyfikatorOwocaY[] );
void UsuniecieInformacjiOwoca( PunktNaMapie & Waz, int IdentyfikatorOwocaX[], int IdentyfikatorOwocaY[] );
/* KONIEC */

/*! FUNKCJA GLOWNA !*/
int main( void )
{
    /*! DEKLARACJE ZMIENNYCH */
    PunktNaMapie Waz; /* Egzemplarz struktury PunktNaMapie, przechowuje polozenie weza. */
    PunktNaMapie Owoc; /* Egzemplarz struktury PunktNaMapie, przechowuje polozenie owoca. */
    PunktNaMapie IleRuchow; /* Egzemplarz struktury PunktNaMapie, przechowuje polozenie wyniku ruchow. */
    PunktNaMapie Zegarek; /* Egzemplarz struktury PunktNaMapie, przechowuje polozenie stopera. */
    PunktNaMapie TablicaWyniku; /* Egzemplarz struktury PunktNaMapie, przechowuje polozenie tablicy z wynikiem. */
    MSG Komunikat; /* MSG - wiadomosc. Zmienna przechowujaca zdarzenia programu.
        Potrzebujemy jej do wlaczenia stopera,ktory bedzie nam odliczac czas. */
   
    IleRuchow.X = 19; /* Nadanie wartosci X egzemplarzowi struktury. */
    IleRuchow.Y = 13; /* Nadanie wartosci Y egzemplarzowi struktury. */
    Waz.X = 4; /* Nadanie wartosci X egzemplarzowi struktury. */
    Waz.Y = 6; /* Nadanie wartosci Y egzemplarzowi struktury. */
    Zegarek.X = 18; /* Nadanie wartosci X egzemplarzowi struktury. */
    Zegarek.Y = 11; /* Nadanie wartosci Y egzemplarzowi struktury. */
    TablicaWyniku.X = 9; /* Nadanie wartosci X egzemplarzowi struktury. */
    TablicaWyniku.Y = 9; /* Nadanie wartosci Y egzemplarzowi struktury. */
   
    int IloscRuchow; /* Zmienna przechowujaca ilosc ruchow. */
    int Wynik; /* Zmienna przechowujaca wynik */
    int GenerujOwoc; /* Zmienna, ktora przechowuje wynik losowania,
        czy utworzyc owoc, czy nie. */
    int Zakoncz = 1; /* Zmienna pozwalajaca wyjsc z petli programu i go zakonczyc. */
    double Czas; /* Zmienna przechowujaca czas. */
    const WORD Zegar = ZEGAR; /* Utworzenie stopera o nazwie zegar, z numerem
        identyfikacyjnym makra ZEGAR, czyli 2719. Makra definiujemy sami i nadajemy
        im wartosci. */
    int IdentyfikatorOwocaX[ 47 ]; /* Tablica przechowujaca punkty X pola, na ktorych dostaniemy punkty
        za zebranie owocka. */
    int IdentyfikatorOwocaY[ 47 ]; /* Tablica przechowujaca punkty Y pola, na ktorych dostaniemy punkty
        za zebranie owocka. */
    int NumerOwoca; /* Zmienna do numerowania tablic owocow. */
    bool Punkt; /* Zmienna przechowujaca wartosci, czy przyznac punkt czy nie. */
    /* KONIEC */
   
   
    srand( time( NULL ) ); /* Wyrazenie zapewniajace pseudolosowosc liczb. */
   
    /*! PETLA GLOWNA !*/
    for(;; ) /* Petla nieskonczona, ktora opuscimy tylko wychodzac z programu. */
    {
        system( "cls" ); /* Czyszczenie ekranu. Wywoluje je tutaj, ze wzgledu na mozliwosc,
            zagrania jeszcze raz. Wtedy wymarze stary obraz i wyswietli nowy. */
        Menu( Zakoncz ); /* Wywolanie funkcji Menu. [Definicja ciala znajduje sie pod funkcja main]. */
       
        if( Zakoncz == 0 ) /* Jesli z menu wybierzemy opcje 'wyjdz', to wylaczymy program. */
        {
            return 0;
        }
       
        /*! Nadanie wartosci nowej gry zmiennym !*/
        IloscRuchow = 0;
        NumerOwoca = 0;
        Wynik = 0;
        Czas = 60;
        /* Koniec */
       
        SetTimer( NULL, Zegar, 10, NULL ); /* Wlaczenie stopera, ktory nada komunikat [wiadomosc]
            co 10 milisekund. */
        Kolorek( ZOLTY ); /* Wywolanie funkcji Kolorek */
        std::cout << "\nWynik:   ";
       
        Kolorek( FIOLETOWY );
        std::cout << Wynik << '\n' << '\n';
       
        Kolorek( ZIELONY );
        std::cout << "Pozostaly czas:   ";
       
        Kolorek( CZERWONY );
        std::cout << Czas << '\n' << '\n';
       
        Kolorek( BLEKIT );
        std::cout << "Wykonano ruchow:   ";
       
        Kolorek( NIEBIESKI );
        std::cout << IloscRuchow;
       
        std::cout << '\n' << '\n' << "Wcisnij Escape, aby zakonczyc.";
       
        Kolorek( ZOLTY );
        ZmienPozycjeKursora( Waz ); /* Wywolanie funkcji zmiany pozycji, i przejscie do pozycji startowej weza. */
        std::cout << "O";
       
       
        while( Czas > 0 ) /* Petla rozgrywki, ktora zakonczy sie, gdy czas bedzie mniejszy od zera. */
        {
            if( GetMessage( & Komunikat, NULL, 0, 0 ) == 1 ) /* Jesli aplikacja dostanie jakis komunikat,
                    a w naszym przypadku od stopera. */
            {
                Kolorek( CZERWONY );
                if( Komunikat.message == WM_TIMER ) /* Sprecyzowanie, od stopera. */
                {
                    Czas -= 0.01; /* Odjecie jednej setnej sekundy od pozostalego czasu. */
                    GenerujOwoc =( rand() % 99 ) + 1; /* Wylosowanie liczby dla generatora owocu. */
                    ZmienPozycjeKursora( Zegarek ); /* Przejscie na pozycje miernika czasu. */
                    std::cout << Czas; /* Nadpisanie jego zawartosci, pozostalym czasem. */
                }
               
                if( GenerujOwoc % 99 == 0 ) /* Zabezpieczenie, aby owoce nie tworzyly sie co jedna
                                    setna sekundy - owoc utworzy sie, gdy program wylosuje liczbe 99. */
                {
                    RysujOwoc( Owoc, Waz, IdentyfikatorOwocaX, IdentyfikatorOwocaY, NumerOwoca ); /* Wywolanie
                                            funkcji rysuj owoc. Jej cialo znajduje sie ponizej. */
                }
               
                if( kbhit() ) /* Jesli wcisniemy jakis przycisk na klawiaturze, to wywolaj funkcje sterowanie. */
                     Sterowanie( Waz, Czas, IloscRuchow, IleRuchow ); /* Wywolanie funkcji - jej cialo ponizej. */
               
                Punkt = CzyZebrano( Waz, IdentyfikatorOwocaX, IdentyfikatorOwocaY ); /* Sprawdzenie, czy nasz waz
                                    zjadl owocka :P. Sprawdzamy to funkcja CzyZebrano - jej cialo patrz nizej. */
                if( Punkt == true ) /* Jesli zjadl to: */
                {
                    ZmienPozycjeKursora( TablicaWyniku ); /* Przejscie kursora na miejsce wyniku. */
                    Wynik++; /* Zwiekszenie o jeden zmiennej wynik */
                    Kolorek( FIOLETOWY );
                    std::cout << Wynik; /* Nadpisanie. */
                    UsuniecieInformacjiOwoca( Waz, IdentyfikatorOwocaX, IdentyfikatorOwocaY ); /* Usuwamy informacje,     ze pole na ktore wjechalismy, posiada owoc. Gdybysmy tego nie zrobili, to dodawaloby nam punkty, tak dlugo, jak stalibysmy na tym polu. Wywolujemy funkcje - jej cialo patrz nizej. */
                }
            }
        }
        system( "cls" ); /* Gdy czas sie skonczy czyscimy ekran. */
       
        /* Wysietlamy statystyki gry. */
        Kolorek( ZIELONY );
        std::cout << "\n\t\tZdobyles ";
       
        Kolorek( FIOLETOWY );
        std::cout << Wynik;
       
        Kolorek( ZIELONY );
        std::cout << " punktow.";
       
        Kolorek( ZOLTY );
        std::cout << "\n\n\t\tWykonales ";
       
        Kolorek( CZERWONY );
        std::cout << IloscRuchow;
       
        Kolorek( ZOLTY );
        std::cout << " ruchow.";
       
        getch();
        std::cout << "\n\n";
       
        Kolorek( BLEKIT );
        system( "pause" );
       
        /* Az dotad. Zauwaz, ze musimy wcisnac dwa razy dowolny klawisz, zabezpieczy to przed
                niepowolanym wyjsciem bez obejrzenia statystyk.*/
       
       
    }
}
/*! KONIEC FUNKCJI GLOWNEJ !*/


/*! CIALA INNYCH FUNKCJI !*/
void Kolorek( int KOLOR )
{
    HANDLE UchwytKonsoli = GetStdHandle( STD_OUTPUT_HANDLE ); /* Pobieramy uchwyt konsoli i przypisujemy do zmiennej. */
   
    /* Jesli kolor wynosi pewna liczbe [tutaj uzywamy zdefiniowancyh makr], to zmien kolor
        czcionki na owy kolor ;). Reszta analogicznie. */
    if( KOLOR == 8700 )
    {
        SetConsoleTextAttribute( UchwytKonsoli, FOREGROUND_BLUE | FOREGROUND_INTENSITY );
    }
   
    if( KOLOR == 8701 )
    {
        SetConsoleTextAttribute( UchwytKonsoli, FOREGROUND_GREEN | FOREGROUND_INTENSITY );
    }
   
    if( KOLOR == 8702 )
    {
        SetConsoleTextAttribute( UchwytKonsoli, FOREGROUND_RED | FOREGROUND_INTENSITY );
    }
   
    if( KOLOR == 8703 )
    {
        SetConsoleTextAttribute( UchwytKonsoli, FOREGROUND_GREEN | FOREGROUND_RED | FOREGROUND_INTENSITY );
    }
   
    if( KOLOR == 8704 )
    {
        SetConsoleTextAttribute( UchwytKonsoli, FOREGROUND_BLUE | FOREGROUND_GREEN | FOREGROUND_INTENSITY );
    }
   
    if( KOLOR == 8705 )
    {
        SetConsoleTextAttribute( UchwytKonsoli, FOREGROUND_RED | FOREGROUND_BLUE | FOREGROUND_INTENSITY );
    }
}
void ZmienPozycjeKursora( PunktNaMapie Wspolrzedne )
{
    SetConsoleCursorPosition( GetStdHandle( STD_OUTPUT_HANDLE ), Wspolrzedne ); /* Ustaw pozycje kursora funkcja
        SetConsoleCursorPosition, w miejsce o koordynatach 'Wspolrzedne', ktore deklarujemy do funkcji jako struktura
        punkt na mapie. */
}
void StworzMape()
{
    /* Narysowanie mapy. */
    std::cout << "##########" << '\n';
    std::cout << "#        #" << '\n';
    std::cout << "#        #" << '\n';
    std::cout << "#        #" << '\n';
    std::cout << "#        #" << '\n';
    std::cout << "#        #" << '\n';
    std::cout << "#        #" << '\n';
    std::cout << "##########" << '\n';
}
int Menu( int & Zakoncz )
{
    int Petla = 1;
    char Wybor;
   
    Kolorek( FIOLETOWY );
    printf( "\t SnakeConsole Version Alpha! \n" ); /* printf to w uogolnieniu to samo co std::cout,
        piszac ten program naszla mnie dziwna ochota na uzycie go. */
   
    Kolorek( ZOLTY );
    printf( "\t\t\t\t\t\t\t$Programed by Buby$\n\n\n" );
   
    Kolorek( BLEKIT );
    printf( "\t\t MENU \n\n" );
   
    Kolorek( CZERWONY );
    printf( "[1] \t" );
   
    Kolorek( ZIELONY );
    printf( " Rozpocznij gre\n" );
   
    Kolorek( CZERWONY );
    printf( "[2] \t" );
   
    Kolorek( ZIELONY );
    printf( " Wyjdz\n" );
   
   
    while( Petla != 2 ) /* Petla wyboru opcji */
    {
        Wybor = getch();
       
        if( Wybor == '1' ) /* Jesli wcisnie jeden na klawiaturze, to wlacz nowa gre. */
        {
            system( "cls" );
           
            Kolorek( NIEBIESKI );
            StworzMape();
           
            Petla = 2;
        }
       
        if( Wybor == '2' ) /* Jesli wcisnie dwa na klawiaturze, to zamknij program. */
        {
            Petla = 2;
            Zakoncz = 0;
        }
       
    }
   
}
void Sterowanie( PunktNaMapie & Waz, double & Czas, int & IloscRuchow, PunktNaMapie IleRuchow )
{
    int Kierunek; /* Zmienna przechowujÂąca numer znaku. */
    Kierunek = getch(); /* Pobranie numeru znaku funkcjÂą getch() i zapis do zmiennej. */
   
    switch( Kierunek ) /* Instrukcja warunkowa switch. */
    {
    case 72: /* Strzalka w gore. */
        ZmienPozycjeKursora( Waz );
        std::cout << " "; /* Zamazanie starej pozycji. */
       
        if( Waz.Y != 1 ) /* Zabezpieczenie, ze waz nie wyjdzie poza mape. */
        {
            Waz.Y -= 1; /* Jeden wiersz w gore. */
            IloscRuchow++; /* Zwiekszenie ilosci ruchow. */
            ZmienPozycjeKursora( IleRuchow ); /* Zmiana pozycji na tabele wyswietlania ilosci ruchow. */
            Kolorek( NIEBIESKI );
            std::cout << IloscRuchow; /* Nadpisanie. */
        }
       
        Kolorek( ZOLTY );
        ZmienPozycjeKursora( Waz ); /* Przejscie do nowej pozycji weza. */
        std::cout << "O"; /* Nadpisanie. */
        break;
       
    case 80: /* Strzalka w dol. */
        ZmienPozycjeKursora( Waz );
        std::cout << " ";
       
        if( Waz.Y != 6 )
        {
            Waz.Y += 1; /* Jeden wiersz w dol. */
            IloscRuchow++;
            ZmienPozycjeKursora( IleRuchow );
            Kolorek( NIEBIESKI );
            std::cout << IloscRuchow;
        }
       
        Kolorek( ZOLTY );
        ZmienPozycjeKursora( Waz );
        std::cout << "O";
        break;
       
    case 75: /* Strzalka w lewo. */
        ZmienPozycjeKursora( Waz );
        std::cout << " ";
       
        if( Waz.X != 1 )
        {
            Waz.X -= 1; /* Jedna kolumna w lewo. */
            IloscRuchow++;
            ZmienPozycjeKursora( IleRuchow );
            Kolorek( NIEBIESKI );
            std::cout << IloscRuchow;
        }
       
        Kolorek( ZOLTY );
        ZmienPozycjeKursora( Waz );
        std::cout << "O";
        break;
       
    case 77: /* Strzalka w prawo. */
        ZmienPozycjeKursora( Waz );
        std::cout << " ";
       
        if( Waz.X != 8 )
        {
            Waz.X += 1; /* Jedna kolumna w prawo. */
            IloscRuchow++;
            ZmienPozycjeKursora( IleRuchow );
            Kolorek( NIEBIESKI );
            std::cout << IloscRuchow;
        }
       
        Kolorek( ZOLTY );
        ZmienPozycjeKursora( Waz );
        std::cout << "O";
        break;
       
    case VK_ESCAPE: /* Jesli wcisnie ESCAPE to petla sie zakonczy i wyjdzie do menu. */
        Czas = 0;
        break;
       
    }
   
}

void RysujOwoc( PunktNaMapie & Owoc, PunktNaMapie & Waz, int IdentyfikatorOwocaX[], int IdentyfikatorOwocaY[], int & NumerOwoca )
{
    Owoc.X =( rand() % 7 ) + 1; /* Losujemy pozycje X owocka. */
    Owoc.Y =( rand() % 6 ) + 1; /* Losujemy pozycje Y owocka. */
   
    if( Owoc.X != Waz.X ) /* Jesli wylosowany punkt nie jest punktem weza. */
    {
        ZmienPozycjeKursora( Owoc );
        std::cout << "*";
        IdentyfikatorOwocaX[ NumerOwoca ] = Owoc.X; /* Zapis informacji, ze po najechaniu na to pole, ma przyznac punkt. X */
        IdentyfikatorOwocaY[ NumerOwoca ] = Owoc.Y; /* Zapis informacji, ze po najechaniu na to pole, ma przyznac punkt. Y */
        NumerOwoca++;
    }
    else
    {
        if( Owoc.X != 1 ) /* Jesli owoc znajduje sie w miejscu weza i nie jest przy lewej scianie to : */
        {
            Owoc.X -= 1; /* Owoc pojawi sie w lewo od weza. */
            ZmienPozycjeKursora( Owoc );
            std::cout << "*";
            IdentyfikatorOwocaX[ NumerOwoca ] = Owoc.X;
            IdentyfikatorOwocaY[ NumerOwoca ] = Owoc.Y;
            NumerOwoca++;
        }
       
       
        if( Owoc.X != 9 ) /* Analogicznie tylko w prawo. */
        {
            Owoc.X += 1;
            ZmienPozycjeKursora( Owoc );
            std::cout << "*";
            IdentyfikatorOwocaX[ NumerOwoca ] = Owoc.X;
            IdentyfikatorOwocaY[ NumerOwoca ] = Owoc.Y;
            NumerOwoca++;
        }
    }
   
    if( NumerOwoca == 47 ) /* Jesli zapelnimy tablice, to zerujemy licznik tablicy, aby
        program nie dostal critical error. */
    {
        NumerOwoca = 0;
    }
}

bool CzyZebrano( PunktNaMapie & Waz, int IdentyfikatorOwocaX[], int IdentyfikatorOwocaY[] )
{
    /* Jesli wjechales na pole na ktorym jest owoc to zwroci prawde. */
    if(( Waz.X == IdentyfikatorOwocaX[ 0 ] && Waz.Y == IdentyfikatorOwocaY[ 0 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 24 ] && Waz.Y == IdentyfikatorOwocaY[ 24 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 1 ] && Waz.Y == IdentyfikatorOwocaY[ 1 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 25 ] && Waz.Y == IdentyfikatorOwocaY[ 25 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 2 ] && Waz.Y == IdentyfikatorOwocaY[ 2 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 26 ] && Waz.Y == IdentyfikatorOwocaY[ 26 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 3 ] && Waz.Y == IdentyfikatorOwocaY[ 3 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 27 ] && Waz.Y == IdentyfikatorOwocaY[ 27 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 4 ] && Waz.Y == IdentyfikatorOwocaY[ 4 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 28 ] && Waz.Y == IdentyfikatorOwocaY[ 28 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 5 ] && Waz.Y == IdentyfikatorOwocaY[ 5 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 29 ] && Waz.Y == IdentyfikatorOwocaY[ 29 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 6 ] && Waz.Y == IdentyfikatorOwocaY[ 6 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 30 ] && Waz.Y == IdentyfikatorOwocaY[ 30 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 7 ] && Waz.Y == IdentyfikatorOwocaY[ 7 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 31 ] && Waz.Y == IdentyfikatorOwocaY[ 31 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 8 ] && Waz.Y == IdentyfikatorOwocaY[ 8 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 32 ] && Waz.Y == IdentyfikatorOwocaY[ 32 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 9 ] && Waz.Y == IdentyfikatorOwocaY[ 9 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 33 ] && Waz.Y == IdentyfikatorOwocaY[ 33 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 10 ] && Waz.Y == IdentyfikatorOwocaY[ 10 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 34 ] && Waz.Y == IdentyfikatorOwocaY[ 34 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 11 ] && Waz.Y == IdentyfikatorOwocaY[ 11 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 35 ] && Waz.Y == IdentyfikatorOwocaY[ 35 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 12 ] && Waz.Y == IdentyfikatorOwocaY[ 12 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 36 ] && Waz.Y == IdentyfikatorOwocaY[ 36 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 13 ] && Waz.Y == IdentyfikatorOwocaY[ 13 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 37 ] && Waz.Y == IdentyfikatorOwocaY[ 37 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 14 ] && Waz.Y == IdentyfikatorOwocaY[ 14 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 38 ] && Waz.Y == IdentyfikatorOwocaY[ 38 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 15 ] && Waz.Y == IdentyfikatorOwocaY[ 15 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 39 ] && Waz.Y == IdentyfikatorOwocaY[ 39 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 16 ] && Waz.Y == IdentyfikatorOwocaY[ 16 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 40 ] && Waz.Y == IdentyfikatorOwocaY[ 40 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 17 ] && Waz.Y == IdentyfikatorOwocaY[ 17 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 41 ] && Waz.Y == IdentyfikatorOwocaY[ 41 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 18 ] && Waz.Y == IdentyfikatorOwocaY[ 18 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 42 ] && Waz.Y == IdentyfikatorOwocaY[ 42 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 19 ] && Waz.Y == IdentyfikatorOwocaY[ 19 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 43 ] && Waz.Y == IdentyfikatorOwocaY[ 43 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 20 ] && Waz.Y == IdentyfikatorOwocaY[ 20 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 44 ] && Waz.Y == IdentyfikatorOwocaY[ 44 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 21 ] && Waz.Y == IdentyfikatorOwocaY[ 21 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 45 ] && Waz.Y == IdentyfikatorOwocaY[ 45 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 22 ] && Waz.Y == IdentyfikatorOwocaY[ 22 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 46 ] && Waz.Y == IdentyfikatorOwocaY[ 46 ] ) ||
    ( Waz.X == IdentyfikatorOwocaX[ 23 ] && Waz.Y == IdentyfikatorOwocaY[ 23 ] ) ||( Waz.X == IdentyfikatorOwocaX[ 47 ] && Waz.Y == IdentyfikatorOwocaY[ 47 ] ) )
    {
        return true;
    }
    else /* W przeciwnym wypadku falsz */
    {
        return false;
    }
}

void UsuniecieInformacjiOwoca( PunktNaMapie & Waz, int IdentyfikatorOwocaX[], int IdentyfikatorOwocaY[] )
{
    /* Cala funkcja polega na sprawdzeniu, czy wjechales na pole z owocem. Jesli tak to funkcja ustawia informacje o    punkcie poza mapa. Gdybysmy tego nie zrobili, to wystarczyloby stac w jednym miejscu, a punkty lecialy by rowno z    odmierzaniem stopera. Wiem, ze topornie wyglada, ale mialem pustke w glowie. -,-' */
    if( Waz.X == IdentyfikatorOwocaX[ 0 ] && Waz.Y == IdentyfikatorOwocaY[ 0 ] )
    {
        IdentyfikatorOwocaX[ 0 ] = 0;
        IdentyfikatorOwocaY[ 0 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 1 ] && Waz.Y == IdentyfikatorOwocaY[ 1 ] )
    {
        IdentyfikatorOwocaX[ 1 ] = 0;
        IdentyfikatorOwocaY[ 1 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 2 ] && Waz.Y == IdentyfikatorOwocaY[ 2 ] )
    {
        IdentyfikatorOwocaX[ 2 ] = 0;
        IdentyfikatorOwocaY[ 2 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 3 ] && Waz.Y == IdentyfikatorOwocaY[ 3 ] )
    {
        IdentyfikatorOwocaX[ 3 ] = 0;
        IdentyfikatorOwocaY[ 3 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 4 ] && Waz.Y == IdentyfikatorOwocaY[ 4 ] )
    {
        IdentyfikatorOwocaX[ 4 ] = 0;
        IdentyfikatorOwocaY[ 4 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 5 ] && Waz.Y == IdentyfikatorOwocaY[ 5 ] )
    {
        IdentyfikatorOwocaX[ 5 ] = 0;
        IdentyfikatorOwocaY[ 5 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 6 ] && Waz.Y == IdentyfikatorOwocaY[ 6 ] )
    {
        IdentyfikatorOwocaX[ 6 ] = 0;
        IdentyfikatorOwocaY[ 6 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 7 ] && Waz.Y == IdentyfikatorOwocaY[ 7 ] )
    {
        IdentyfikatorOwocaX[ 7 ] = 0;
        IdentyfikatorOwocaY[ 7 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 8 ] && Waz.Y == IdentyfikatorOwocaY[ 8 ] )
    {
        IdentyfikatorOwocaX[ 8 ] = 0;
        IdentyfikatorOwocaY[ 8 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 9 ] && Waz.Y == IdentyfikatorOwocaY[ 9 ] )
    {
        IdentyfikatorOwocaX[ 9 ] = 0;
        IdentyfikatorOwocaY[ 9 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 10 ] && Waz.Y == IdentyfikatorOwocaY[ 10 ] )
    {
        IdentyfikatorOwocaX[ 10 ] = 0;
        IdentyfikatorOwocaY[ 10 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 11 ] && Waz.Y == IdentyfikatorOwocaY[ 11 ] )
    {
        IdentyfikatorOwocaX[ 11 ] = 0;
        IdentyfikatorOwocaY[ 11 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 12 ] && Waz.Y == IdentyfikatorOwocaY[ 12 ] )
    {
        IdentyfikatorOwocaX[ 12 ] = 0;
        IdentyfikatorOwocaY[ 12 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 13 ] && Waz.Y == IdentyfikatorOwocaY[ 13 ] )
    {
        IdentyfikatorOwocaX[ 13 ] = 0;
        IdentyfikatorOwocaY[ 13 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 14 ] && Waz.Y == IdentyfikatorOwocaY[ 14 ] )
    {
        IdentyfikatorOwocaX[ 14 ] = 0;
        IdentyfikatorOwocaY[ 14 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 15 ] && Waz.Y == IdentyfikatorOwocaY[ 15 ] )
    {
        IdentyfikatorOwocaX[ 15 ] = 0;
        IdentyfikatorOwocaY[ 15 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 16 ] && Waz.Y == IdentyfikatorOwocaY[ 16 ] )
    {
        IdentyfikatorOwocaX[ 16 ] = 0;
        IdentyfikatorOwocaY[ 16 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 17 ] && Waz.Y == IdentyfikatorOwocaY[ 17 ] )
    {
        IdentyfikatorOwocaX[ 17 ] = 0;
        IdentyfikatorOwocaY[ 17 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 18 ] && Waz.Y == IdentyfikatorOwocaY[ 18 ] )
    {
        IdentyfikatorOwocaX[ 18 ] = 0;
        IdentyfikatorOwocaY[ 18 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 19 ] && Waz.Y == IdentyfikatorOwocaY[ 19 ] )
    {
        IdentyfikatorOwocaX[ 19 ] = 0;
        IdentyfikatorOwocaY[ 19 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 20 ] && Waz.Y == IdentyfikatorOwocaY[ 20 ] )
    {
        IdentyfikatorOwocaX[ 20 ] = 0;
        IdentyfikatorOwocaY[ 20 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 21 ] && Waz.Y == IdentyfikatorOwocaY[ 21 ] )
    {
        IdentyfikatorOwocaX[ 21 ] = 0;
        IdentyfikatorOwocaY[ 21 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 22 ] && Waz.Y == IdentyfikatorOwocaY[ 22 ] )
    {
        IdentyfikatorOwocaX[ 22 ] = 0;
        IdentyfikatorOwocaY[ 22 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 23 ] && Waz.Y == IdentyfikatorOwocaY[ 23 ] )
    {
        IdentyfikatorOwocaX[ 23 ] = 0;
        IdentyfikatorOwocaY[ 23 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 24 ] && Waz.Y == IdentyfikatorOwocaY[ 24 ] )
    {
        IdentyfikatorOwocaX[ 24 ] = 0;
        IdentyfikatorOwocaY[ 24 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 25 ] && Waz.Y == IdentyfikatorOwocaY[ 25 ] )
    {
        IdentyfikatorOwocaX[ 25 ] = 0;
        IdentyfikatorOwocaY[ 25 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 26 ] && Waz.Y == IdentyfikatorOwocaY[ 26 ] )
    {
        IdentyfikatorOwocaX[ 26 ] = 0;
        IdentyfikatorOwocaY[ 26 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 27 ] && Waz.Y == IdentyfikatorOwocaY[ 27 ] )
    {
        IdentyfikatorOwocaX[ 27 ] = 0;
        IdentyfikatorOwocaY[ 27 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 28 ] && Waz.Y == IdentyfikatorOwocaY[ 28 ] )
    {
        IdentyfikatorOwocaX[ 28 ] = 0;
        IdentyfikatorOwocaY[ 28 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 29 ] && Waz.Y == IdentyfikatorOwocaY[ 29 ] )
    {
        IdentyfikatorOwocaX[ 29 ] = 0;
        IdentyfikatorOwocaY[ 29 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 30 ] && Waz.Y == IdentyfikatorOwocaY[ 30 ] )
    {
        IdentyfikatorOwocaX[ 30 ] = 0;
        IdentyfikatorOwocaY[ 30 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 31 ] && Waz.Y == IdentyfikatorOwocaY[ 31 ] )
    {
        IdentyfikatorOwocaX[ 31 ] = 0;
        IdentyfikatorOwocaY[ 31 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 32 ] && Waz.Y == IdentyfikatorOwocaY[ 32 ] )
    {
        IdentyfikatorOwocaX[ 32 ] = 0;
        IdentyfikatorOwocaY[ 32 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 33 ] && Waz.Y == IdentyfikatorOwocaY[ 33 ] )
    {
        IdentyfikatorOwocaX[ 33 ] = 0;
        IdentyfikatorOwocaY[ 33 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 34 ] && Waz.Y == IdentyfikatorOwocaY[ 34 ] )
    {
        IdentyfikatorOwocaX[ 34 ] = 0;
        IdentyfikatorOwocaY[ 34 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 35 ] && Waz.Y == IdentyfikatorOwocaY[ 35 ] )
    {
        IdentyfikatorOwocaX[ 35 ] = 0;
        IdentyfikatorOwocaY[ 35 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 36 ] && Waz.Y == IdentyfikatorOwocaY[ 36 ] )
    {
        IdentyfikatorOwocaX[ 36 ] = 0;
        IdentyfikatorOwocaY[ 36 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 37 ] && Waz.Y == IdentyfikatorOwocaY[ 37 ] )
    {
        IdentyfikatorOwocaX[ 37 ] = 0;
        IdentyfikatorOwocaY[ 37 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 38 ] && Waz.Y == IdentyfikatorOwocaY[ 38 ] )
    {
        IdentyfikatorOwocaX[ 38 ] = 0;
        IdentyfikatorOwocaY[ 38 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 39 ] && Waz.Y == IdentyfikatorOwocaY[ 39 ] )
    {
        IdentyfikatorOwocaX[ 39 ] = 0;
        IdentyfikatorOwocaY[ 39 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 40 ] && Waz.Y == IdentyfikatorOwocaY[ 40 ] )
    {
        IdentyfikatorOwocaX[ 40 ] = 0;
        IdentyfikatorOwocaY[ 40 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 41 ] && Waz.Y == IdentyfikatorOwocaY[ 41 ] )
    {
        IdentyfikatorOwocaX[ 41 ] = 0;
        IdentyfikatorOwocaY[ 41 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 42 ] && Waz.Y == IdentyfikatorOwocaY[ 42 ] )
    {
        IdentyfikatorOwocaX[ 42 ] = 0;
        IdentyfikatorOwocaY[ 42 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 43 ] && Waz.Y == IdentyfikatorOwocaY[ 43 ] )
    {
        IdentyfikatorOwocaX[ 43 ] = 0;
        IdentyfikatorOwocaY[ 43 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 44 ] && Waz.Y == IdentyfikatorOwocaY[ 44 ] )
    {
        IdentyfikatorOwocaX[ 44 ] = 0;
        IdentyfikatorOwocaY[ 44 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 45 ] && Waz.Y == IdentyfikatorOwocaY[ 45 ] )
    {
        IdentyfikatorOwocaX[ 45 ] = 0;
        IdentyfikatorOwocaY[ 45 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 46 ] && Waz.Y == IdentyfikatorOwocaY[ 46 ] )
    {
        IdentyfikatorOwocaX[ 46 ] = 0;
        IdentyfikatorOwocaY[ 46 ] = 0;
    }
   
    if( Waz.X == IdentyfikatorOwocaX[ 47 ] && Waz.Y == IdentyfikatorOwocaY[ 47 ] )
    {
        IdentyfikatorOwocaX[ 47 ] = 0;
        IdentyfikatorOwocaY[ 47 ] = 0;
    }
   
}