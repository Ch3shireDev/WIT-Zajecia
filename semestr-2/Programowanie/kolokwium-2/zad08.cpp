#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    for (int i = 0; i <= 180; i += 10)
    {
        double x = sin(i / 180. * M_PI);
        double y = cos(i / 180. * M_PI);
        // cout << i << "\t" << x << "\t" << y << endl;
        printf("Out: %03d %1.3f %1.3f\n", i, x, y);
    }
}