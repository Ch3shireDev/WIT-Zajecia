//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string string_join(string a, string b, int n)
{
    switch (n)
    {
    case (1):
        return a + b;
    case (2):
        return b + a;
    default:
        return a;
    }
}

int main()
{
    string a, b;
    int n;
    cout << "Podaj pierwszy ciąg (A): ";
    getline(cin, a);
    cout << "Podaj drugi ciąg (B): ";
    getline(cin, b);
    cout << "Wybierz wariant: " << endl;
    cout << "1. A + B" << endl;
    cout << "2. B + A" << endl;
    cin >> n;
    cout << string_join(a, b, n) << endl;
}