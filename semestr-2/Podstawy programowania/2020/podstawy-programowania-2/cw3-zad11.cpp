//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <vector>

using namespace std;

int main()
{
    cout << "Podaj liczbę trójkątów: ";
    int n;
    cin >> n;
    vector<int> tr = vector<int>(n);
    int max = 0;
    for (int i = 0; i < n; i++)
    {
        cout << "Podaj rozmiar trójkąta " << i + 1 << ": ";
        cin >> tr[i];
        int y = tr[i] * 2 + 1;
        if (y > max)
        {
            max = y;
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < tr[i]; j++)
        {
            for (int k = 0; k < max + 1; k++)
            {
                if (k > max / 2 - j - 1 && k < max / 2 + j + 1)
                {
                    cout << "*";
                }
                else
                {
                    cout << " ";
                }
            }
            cout << endl;
        }
    }
}