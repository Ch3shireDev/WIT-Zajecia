//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    cout << "Podaj tekst: ";
    string str;
    getline(cin, str);
    cout << "Podaj poszukiwany znak: ";
    char x;
    cin >> x;

    int counter = 0;
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == x)
        {
            counter++;
        }
    }
    cout << "Znak " << x << " wystąpił " << counter << " razy." << endl;
}