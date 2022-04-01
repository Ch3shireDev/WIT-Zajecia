#include <iostream>
#include <string>

using namespace std;

int main()
{

    string tekst;
    int klucz;

    cout << "Wprowadz tekst:"<<endl;
    getline(cin,tekst);

    cout <<"Podaj klucz:  (klucz ujemny - odszyfrowywanie)"<<endl;
    cin >> klucz;

    cout <<"\nTekst:\n"<< tekst<<endl;
    cout <<"\nKlucz:\n"<< klucz<<endl;

    ///Zamiana liter na du¿ych na ma³e i wyrzucanie spacji.
    for(int i=0;i<tekst.length();++i)
    {
        int pom=(int)tekst[i];

        if( pom >= 65 && pom <=90){
            pom+=32;
            tekst[i]=(char)pom;
        }
        if(pom==32){
            tekst.erase(i,1);
            --i;
        }
    }
    cout << endl <<"tekst: \n"<< tekst<<"\n"<<endl;


    int* t=new int [tekst.length()];

 cout << endl << "tekst zamieniony na liczby" << endl ;


    /// Zamiana wartosci kodu ANSCII liter na wartosci od 0 25 dla tekstu
    for(int i=0;i<tekst.length();++i){

        t[i]=((int)tekst[i])-97;
        cout << t[i]<<"|";
    }

 cout << endl << "po przesunieciu o klucz" << endl ;

    /// przestawienie
    for(int i=0;i<tekst.length();++i){

        if ((t[i] + klucz )< 0)
        {
            t[i]= 26 + t[i]+ klucz;
        }
        else
        {
            t[i]=( t[i] + klucz )% 26;
        }

        cout << t[i]<<"|";
    }

    cout << endl << "zakodowany" << endl;

    /// Zamiana wartosci kodu ANSCII liter na wartosci od 0 25 dla tekstu
    for(int i=0;i<tekst.length();++i){

        tekst[i]=((char)t[i] +97 );

        cout << tekst[i]<<"|";
    }


 cout << endl << endl;


    delete[] t;
    return 0;
}
