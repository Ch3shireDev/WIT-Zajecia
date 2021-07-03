//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str1, str2;
    cout << "Tekst 1: ";
    getline(cin, str1);
    cout << "Teskt 2: ";
    getline(cin, str2);
    if (str1 == str2)
    {
        cout << "Teskty są identyczne" << endl;
    }
    else
    {
        cout << "Teksty nie są identyczne" << endl;
    }
}