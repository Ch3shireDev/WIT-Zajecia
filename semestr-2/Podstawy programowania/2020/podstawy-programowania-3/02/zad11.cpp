//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str1, str2;
    cout << "Podaj pierwsze słowo: ";
    cin >> str1;
    cout << "Podaj drugie słowo: ";
    cin >> str2;

    string output;
    int n1 = str1.length(), n2 = str2.length();
    int n = n1 > n2 ? n1 : n2;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0 && i < n1)
        {
            output += str1[i];
        }
        if (i % 2 == 1 && i < n2)
        {
            output += str2[i];
        }
    }

    cout << "Wynik: " << output << endl;
}