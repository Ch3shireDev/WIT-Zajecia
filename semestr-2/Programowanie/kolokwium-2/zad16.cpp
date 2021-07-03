#include <iostream>
using namespace std;

//lambda gang

void rek()
{
    double x;
    if (cin >> x)
    {
        rek();
        cout << x << endl;
    }
}

int main()
{
    rek();
}