//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ofstream myfile;
    myfile.open("zad3.txt");

    string firstName, lastName;
    string buf;
    
    cout << "Podaj imię i nazwisko: ";
    while (cin >> firstName >> lastName)
    {
        myfile << firstName << " " << lastName << endl;
        cout << "Podaj imię i nazwisko: ";
    }

    myfile.close();
}