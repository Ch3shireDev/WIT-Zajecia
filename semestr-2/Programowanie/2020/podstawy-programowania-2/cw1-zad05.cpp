//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cstdlib>
using namespace std;

int main()
{
    int x, y, z;
    cout << "Podaj trzy liczby: ";
    cin >> x >> y >> z;

    bool flag = (x + y > z) && (y + z > x) && (z + x > y);
    cout << "Z liczb " << x << " " << y << " " << z << " ";
    if (flag)
    {
        cout << "można zbudować trójkąt" << endl;
    }
    else
    {
        cout << "nie można zbudować trójkąta" << endl;
    }
}