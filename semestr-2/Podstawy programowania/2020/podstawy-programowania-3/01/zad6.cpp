//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;
int main(int argc, char **argv)
{
    if (argc < 2)
    {
        cout << "Podaj nazwę pliku" << endl;
        return 0;
    }

    string fname = argv[1];
    ifstream file;
    file.open(fname);
    if (!file.good())
    {
        cout << "Błąd w otwarciu pliku " << fname << ". Program zakończy działanie." << endl;
    }

    int linesCount = 0;
    int wordCount = 0;
    int charCount = 0;

    while (file.good())
    {
        string buffer;
        getline(file, buffer);
        linesCount++;

        stringstream ss(buffer);
        string buf2;
        while (ss >> buf2)
        {
            wordCount++;
        }
        charCount += buffer.length();
    }

    cout << "Lines: " << linesCount << endl;
    cout << "Words: " << wordCount << endl;
    cout << "Chars: " << charCount << endl;
}