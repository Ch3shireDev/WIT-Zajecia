// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
#include <string>
using namespace std;

string reverse(string str)
{
    string rev = "";
    for (int i = 0; i < str.length(); i++)
    {
        rev += str[i];
    }
    return rev;
}

int main()
{
    string str;
    cout << "Podaj ciąg znaków: ";
    getline(cin, str);
    if (str == reverse(str))
    {
        cout << "tak" << endl;
    }
    else
    {
        cout << "nie" << endl;
    }
}