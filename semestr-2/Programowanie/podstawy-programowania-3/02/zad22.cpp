//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str1, str2;
    cout << "Podaj pierwszy łańcuch: ";
    getline(cin, str1);
    cout << "Podaj drugi łańcuch: ";
    getline(cin, str2);

    int counter = 0;

    cout << "Parzyste znaki z pierwszego łańcucha: ";
    for (int i = 0; i < str1.length(); i++)
    {
        if (i % 2 == 1)
        {
            counter++;
            cout << str1[i];
        }
    }
    cout << endl;

    cout << "Nieparzyste znaki z drugiego łańcucha: ";
    for (int i = 0; i < str2.length(); i++)
    {
        if (i % 2 == 0)
        {
            counter++;
            cout << str2[i];
        }
    }
    cout << endl;
    cout << "Wyświetlono " << counter << " znaków." << endl;
}