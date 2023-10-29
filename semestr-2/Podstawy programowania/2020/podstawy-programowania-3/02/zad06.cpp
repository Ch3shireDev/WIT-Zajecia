//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    string str;
    int n;
    cout << "Podaj ciąg tekstowy: ";
    getline(cin, str);
    cout << "Podaj miejsce przecięcia: ";
    cin >> n;
    string str1 = str.substr(0, n);
    string str2 = str.substr(n, str.length() - n);

    cout<<"Część 1: "<<str1<<endl;
    cout<<"Część 2: "<<str2<<endl;
}