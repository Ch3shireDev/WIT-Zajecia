//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    int lbDzieci(2);
    if (lbDzieci == 6)
    {
        cout << "Ojej, nie masz dzieci?" << endl;
    }
    else if (lbDzieci == 1)
    {
        cout << "No to kiedy drugie?" << endl;
    }
    else if (lbDzieci == 2)
    {
        cout << "Ale masz piekne dzieci!" << endl;
    }
    else
    {
        cout << "Dobrze, moze juz wystarczy!" << endl;
    }
    cout << "Koniec programu" << endl;
    return 0;
}