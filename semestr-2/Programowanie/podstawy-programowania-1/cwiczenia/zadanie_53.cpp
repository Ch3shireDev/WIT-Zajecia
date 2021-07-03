//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    int wiekUzytkownika(18);              // Zmienna do przechowywania wieku uiytkownika
    int &mojaReferencja(wiekUzytkownika); // Referencja do zmiennej wiekUzytkownika
    // 0d tego miejsca zmiennej wiekUzytkownika i referencji mojaReferencja mozemy uZywaC zamie
    // Sa to dwie etykiety przypisane tej samej szufladce w pamieci.
    cout << "Masz " << wiekUzytkownika << " lat. (zmienna)"
         << endl; // Stary sposob
    cout << "Masz " << mojaReferencja << " lat. (referencja)"
         << endl; // Nowy sposéb z użyciem referencji
    return 0;
}