//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str1, str2, str3, str4;
    cout << "Podaj 1 łańcuch (A): ";
    getline(cin, str1);
    cout << "Podaj 2 łańcuch (B): ";
    getline(cin, str2);
    cout << "Podaj 3 łańcuch (C): ";
    getline(cin, str3);
    cout << "Podaj 4 łańcuch (D): ";
    getline(cin, str4);

    string kolejnosc;
    cout << "Podaj kolejność sklejania w formie liter (np. AABBAC): ";
    cin >> kolejnosc;

    string output;

    for (int i = 0; i < kolejnosc.length(); i++)
    {
        int x = tolower(kolejnosc[i]) - 'a';
        switch (x)
        {
        case (1):
            output += str1;
        case (2):
            output += str2;
        case (3):
            output += str3;
        case (4):
            output += str4;
        }
    }

    cout << "Posklejany string: " << output << endl;
}