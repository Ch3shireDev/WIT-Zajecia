//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string to_lower(string str)
{
    string output;
    for (int i = 0; i < str.length(); i++)
    {
        output += tolower(str[i]);
    }
    return output;
}

string reverse(string str)
{
    string output;
    for (int i = 0; i < str.length(); i++)
    {
        output += str[str.length() - i - 1];
    }
    return output;
}

string remove_spaces(string str)
{
    string output;
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] == ' ')
            continue;
        output += str[i];
    }
    return output;
}

int main()
{
    cout << "Podaj tekst: ";
    string str;
    getline(cin, str);
    string x = to_lower(str);
    x = remove_spaces(x);
    
    if (x == reverse(x))
    {
        cout << "Wyrażenie jest palindromem" << endl;
    }
    else
    {
        cout << "Wyrażenie nie jest palindromem" << endl;
    }
}