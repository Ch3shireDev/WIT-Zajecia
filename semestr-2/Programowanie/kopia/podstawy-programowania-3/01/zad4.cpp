//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    ifstream file;
    file.open("zad3.txt");
    string line;
    int i = 1;
    while (getline(file, line))
    {
        cout << "Line " << i++ << ": " << line << endl;
    }
    
}