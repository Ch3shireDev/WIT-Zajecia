#include <iostream>

using namespace std;

int main()
{
    int hours = 0;
    int minutes = 0;
    int seconds = 0;

    while (true)
    {
        printf("%02d:%02d:%02d\n", hours, minutes, seconds);
        system("timeout 1 >nul");
        seconds += 1;
        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }
        if (minutes == 60)
        {
            minutes = 0;
            hours += 1;
        }
        if (hours == 24)
        {
            hours = 0;
        }
    }
}