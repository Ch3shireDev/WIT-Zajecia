#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    double x, y;
    double x0, y0;

    bool flag = false;
    double total = 0;
    while (cin >> x >> y)
    {
        if (flag)
        {
            double l = sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
            total += l;
            x0 = x;
            y0 = y;
        }
        flag = true;
    }

    cout << "Długość łamanej: " << total;
}