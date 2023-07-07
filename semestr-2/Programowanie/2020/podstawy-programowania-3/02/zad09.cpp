//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str, fraza, nowy;
    cout << "Podaj wiadomość: ";
    getline(cin, str);
    cout << "Podaj frazę do podstawienia: ";
    getline(cin, fraza);
    cout<<"Podaj nową frazę na miejsce starej: ";
    getline(cin, nowy);
    int n = str.find(fraza);
    if (n > -1)
    {
        string str1 = str.substr(0, n);
        string str2 = str.substr(n + fraza.length(), str.length() - n - fraza.length());
        str = str1 + nowy + str2;
    }
    cout << "Nowy string: " << str << endl;
}