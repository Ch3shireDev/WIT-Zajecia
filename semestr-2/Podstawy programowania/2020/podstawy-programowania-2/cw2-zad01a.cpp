//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
using namespace std;

string get_grade(int x)
{

    switch (x)
    {
    case 1:
        return "Ocena niedostateczna";
    case 2:
        return "Ocena dopuszczająca";
    case 3:
        return "Ocena dostateczna";
    case 4:
        return "Ocena dobra";
    case 5:
        return "Ocena bardzo dobra";
    case 6:
        return "Ocena celująca";
    default:
        return "Liczba nieprawidłowa.";
    }
}
int main()
{
    int x;

    cout << "Podaj liczbe: ";
    cin >> x;
    cout << get_grade(x) << endl;
}
