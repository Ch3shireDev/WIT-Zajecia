//Igor Nowicki
//IZ02P03
//18608

#include "kalkulator.h"
#include <cmath>

float op(int a, int b, int n)
{
    switch (n)
    {
    case (1):
        return a + b;
    case (2):
        return a - b;
    case (3):
        return a * b;
    case (4):
        return a / b;
    case (5):
        return pow(a, b);
    case (6):
        return log(a) / log(b);
    }
    return 0;
}
