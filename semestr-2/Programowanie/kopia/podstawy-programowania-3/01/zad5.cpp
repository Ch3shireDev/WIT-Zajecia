//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    ofstream file;
    file.open("zad5.txt");

    int a, b;

    while (cin >> a >> b)
    {
        int c = a + b;
        file << a << " " << b << " " << c << endl;
    }

    file.close();
}