//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str;
    cout << "Podaj tekst: ";
    cin >> str;

    string output;
    int n = str.length();
    for (int i = 0; i < n; i++)
    {
        output += str[n - i - 1];
    }
    cout << "Tekst od tyłu: " << output << endl;
}