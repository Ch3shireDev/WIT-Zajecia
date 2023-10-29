//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string reverse(string str)
{
    string output;
    for (int i = 0; i < str.length(); i++)
    {
        output += str[str.length() - 1 - i];
    }
    return output;
}

int main()
{
    string str;
    cout << "Podaj łańcuch: ";
    getline(cin, str);

    if (reverse(str) == str)
    {
        cout << "Łańcuch " << str << " jest palindromem." << endl;
    }
    else
    {
        cout << "Stworzony palindrom: " << str + reverse(str) << endl;
    }
}