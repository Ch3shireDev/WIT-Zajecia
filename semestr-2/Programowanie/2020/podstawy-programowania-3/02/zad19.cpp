//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str1, str2;
    cout << "Podaj pierwszą liczbę: ";
    cin >> str1;
    cout << "Podaj drugą liczbę: ";
    cin >> str2;
    int x = atoi(str1.c_str());
    int y = atoi(str2.c_str());
    cout << "Suma: " << x + y << endl;
    cout << "Iloczyn: " << x * y << endl;
}