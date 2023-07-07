#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector<int> nominals = vector<int>{200, 100, 50, 20, 10, 5, 2, 1};
    int n;
    cin >> n;

    for (int i = 0; i < nominals.size(); i++)
    {
        int x = n / nominals[i];
        if (x == 0)
            continue;
        n %= nominals[i];
        for (int j = 0; j < x; j++)
        {
            cout << nominals[i] << " ";
        }
    }
}