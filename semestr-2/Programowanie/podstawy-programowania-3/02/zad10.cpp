//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

void rozdziel(string str, string &s1, string &s2)
{
    s1 = "";
    s2 = "";
    for (int i = 0; i < str.length(); i++)
    {
        if (i % 2 == 0)
        {
            s1 += str[i];
        }
        else
        {
            s2 += str[i];
        }
    }
}

int main()
{
    string str;
    cout << "Podaj tekst po rozdzielenia: ";
    getline(cin, str);
    string s1, s2;
    rozdziel(str, s1, s2);
    cout << "Pierwsze słowo: " << s1 << endl;
    cout << "Drugie słowo: " << s2 << endl;
}