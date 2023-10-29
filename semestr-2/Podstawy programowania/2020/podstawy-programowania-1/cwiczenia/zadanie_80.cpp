//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;
int main()
{
    int lbDzieci(2);

    switch (lbDzieci)
    {
    case 6:
        cout << "Ojej, nie masz dzieci?" << endl;
        break;
    case 1:
        cout << "No to kiedy drugie?" << endl;
        break;
    case 2:
        cout << "Ale masz piekne dzieci!" << endl;
        break;
    default:
        cout << "Dobrze, może już wystarczy!" << endl;
        break;
    }
    return 0;
}