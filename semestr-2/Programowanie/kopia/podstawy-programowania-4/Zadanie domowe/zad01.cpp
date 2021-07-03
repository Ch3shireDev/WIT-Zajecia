// Igor Nowicki
// IZ02P03
// 18608

#include <iostream>
using namespace std;

int main()
{
    int x, y;
    cout << "Podaj wiek obydwu studentów: ";
    cin >> x >> y;
    if (x <= 1 || y <= 1)
    {
        cout << "Wiek powinien być większy od 0!" << endl;
        return 0;
    }

    if (x == y)
    {
        cout << "Studenci są w tym samym wieku" << endl;
        return 0;
    }

    if (x < y)
    {
        cout << "Drugi student jest starszy o " << y - x << " lat" << endl;
        return 0;
    }
    else
    {
        cout << "Pierwszy student jest starszy o " << x - y << " lat" << endl;
    }
}