#include <iostream>
#include <fstream>
using namespace std;

string replace(string instr, int n)
{
    string out;
    for (int i = 0; i < instr.length(); i++)
    {
        if (instr[i] == '\t')
        {
            for (int j = 0; j < n; j++)
                out += " ";
        }
        else
        {
            out += instr[i];
        }
    }
    return out;
}

int main()
{
    int n;
    string fname1, fname2;

    cin >> n >> fname1 >> fname2;

    // string buffer;

    fstream file1;
    file1.open(fname1);
    ofstream file2;
    file2.open(fname2);

    char buffer;
    string text;
    while (file1.read(&buffer, 1))
    {
        text += buffer;
    }

    file2 << replace(text, n);
}