//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str;
    int counter = 0;
    cout << "Podaj łańcuch tekstowy: ";
    getline(cin, str);
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] != 'a')
            continue;

        counter++;
        cout << str[i] << " " << i << endl;
    }

    cout << "W tekście było " << counter << " liter a." << endl;
}