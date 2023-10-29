//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str;
    cout << "Podaj łańcuch: ";
    getline(cin, str);
    string output;
    for (int i = 0; i < str.length(); i++)
    {
        if (i % 2 == 1)
            continue;
        output += str[i];
    }

    cout<<"Wynik: "<<output<<endl;
}