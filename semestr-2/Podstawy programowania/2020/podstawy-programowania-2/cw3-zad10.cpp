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
    for (int i = 0; i < n; i++)
    {
        cout << "Podaj rozmiar trójkąta " << i + 1 << ": ";
        cin >> tr[i];
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < tr[i]; j++)
        {
            for (int k = 0; k < j + 1; k++)
            {
                cout << "*";
            }
            cout << endl;
        }
    }
}