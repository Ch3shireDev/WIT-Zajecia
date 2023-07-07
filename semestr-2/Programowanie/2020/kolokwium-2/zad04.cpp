#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    cout << "Podaj liczbę: ";
    int n;
    cin >> n;
    if (n >= 0 && n <= 10)
    {
        while (n >= 0)
        {
            switch (n)
            {
            case (10):
                cout << "Ten" << endl;
                break;
            case (9):
                cout << "Nine" << endl;
                break;
            case (8):
                cout << "Eight" << endl;
                break;
            case (7):
                cout << "Seven" << endl;
                break;
            case (6):
                cout << "Six" << endl;
                break;
            case (5):
                cout << "Five" << endl;
                break;
            case (4):
                cout << "Four" << endl;
                break;
            case (3):
                cout << "Three" << endl;
                break;
            case (2):
                cout << "Two" << endl;
                break;
            case (1):
                cout << "One" << endl;
                break;
            case (0):
                cout << "Start" << endl;
                break;
            }
            n--;
        }
    }
    else
    {
        cout << "Stop" << endl;
    }
}