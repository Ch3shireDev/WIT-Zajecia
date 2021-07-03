//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string ceasar(string plain, int n)
{
    string output;
    for (int i = 0; i < plain.length(); i++)
    {
        char letter = tolower(plain[i]);
        if (letter >= 'a' && letter <= 'z')
        {
            int x = int(letter - 'a');
            x = (x + n) % 26;
            letter = 'a' + x;
        }
        output += letter;
    }
    return output;
}

int main()
{
    cout << "Podaj tekst do szyfrowania: ";
    string plaintext;
    getline(cin, plaintext);
    cout << "Podaj klucz szyfru Cezara: ";
    int n;
    cin >> n;
    string cipher = ceasar(plaintext, n);
    cout << "Zaszyfrowany tekst: " << cipher << endl;
    cout << "Odszyfrowany tekst: " << ceasar(cipher, 26 - n) << endl;
}