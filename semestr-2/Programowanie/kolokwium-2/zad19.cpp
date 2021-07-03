#include <iostream>
#include <cstdlib>
#include <fstream>
using namespace std;

string caesar(string x, int n)
{
    string y;
    for (int i = 0; i < x.length(); i++)
    {
        char a = x[i];
        if (a >= 'a' && a <= 'z')
        {
            a = ((a - 'a') + n) % 26 + 'a';
        }
        if (a >= 'A' && a <= 'Z')
        {
            a = ((a - 'A') + n) % 26 + 'A';
        }
        y += a;
    }
    return y;
}

int main()
{
    int n;
    string fname1, fname2;
    cin >> n >> fname1 >> fname2;
    fstream file1;
    file1.open(fname1);

    ofstream file2;
    file2.open(fname2);

    string buffer;
    while (file1 >> buffer)
    {
        file2 << caesar(buffer, n) << " ";
    }

    file2.close();
}