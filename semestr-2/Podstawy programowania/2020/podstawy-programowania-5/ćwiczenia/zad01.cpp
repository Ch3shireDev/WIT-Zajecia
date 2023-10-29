// Zadanie 1
// Napisz program który sortuje bąbelkowo dowolną podaną ilość liczb rzeczywistych. podawanie liczb kończy naciśniecie klawisza "esc". Posortowane liczby zapisuje do pliku i dodatkowo wyświetla je na ekranie za pomocą printf.

#include <iostream>
#include <vector>
#include <string>
using namespace std;

template <typename T>
string show(vector<T> tab)
{
    string str;
    for (auto it = tab.begin(); it != tab.end(); it++)
    {
        str += " "+to_string(*it);
    }

    return str;
}

template <typename T>
void sort(vector<T> &tab){
    for(auto it1 = tab.begin();it1!=tab.end();it1++){
        for(auto it2 = tab.begin();it2!=tab.end()-1;it2++){
            T a = *it2;
            T b = *(it2+1);
            if(a>b){
                *(it2+1) = a;
                *(it2) = b;
            }
        }
    }
}

int main()
{

    vector<double> tab = vector<double>();

    double in;

    cout << "Podaj zestaw liczb. Zakończ kombinacją CTRL+D: ";
    while (cin >> in)
    {
        tab.push_back(in);
    }

    cout << "Podane liczby: " << show(tab) << endl;
    cout<<"Sortowanie..."<<endl;
    sort(tab);
    cout<<"Posortowane liczby: "<<show(tab)<<endl;
    return 0;
}