// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int N, M;
    cout << "Podaj wartości N oraz M: ";
    cin >> N >> M;

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            cout << "*|";
        }
        cout << "*" << endl;
    }
}