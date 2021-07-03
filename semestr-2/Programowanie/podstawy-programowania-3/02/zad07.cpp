//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str, fraza;
    cout << "Podaj wiadomość: ";
    getline(cin, str);
    cout << "Podaj frazę do wyszukania: ";
    getline(cin, fraza);
    int n = str.find(fraza);
    if (n == -1)
    {
        cout << "W tekście nie ma zadanej frazy" << endl;
    }
    else
    {
        cout << "Fraza pojawia się na miejscu " << n << endl;
    }
}