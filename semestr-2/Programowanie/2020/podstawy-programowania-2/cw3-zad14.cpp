//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <vector>

using namespace std;

void fun(int x, int y = 0)
{
    for (int i = 0; i < y; i++)
    {
        cout << " ";
    }
    for (int i = 0; i < x; i++)
    {
        cout << "*";
    }
    cout << endl;
}

int main()
{
    int n,m;
    cout << "Podaj liczbę gwiazdek obydwu bokach: ";
    cin >> n>>m;

    for(int i=0;i<n;i++){
        fun(m,i);
    }

}
