//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str;
    cout << "Podaj tekst do zamiany: ";
    getline(cin, str);

    string output;
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == ' ')
        {
            output += '_';
        }
        else
        {
            output += str[i];
        }
    }

    cout << "Zamieniony tekst: " << output << endl;
}