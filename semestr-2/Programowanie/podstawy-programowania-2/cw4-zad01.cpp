//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <vector>

using namespace std;

class Question
{
    string question;
    string answers[4];
    int answer;

public:
    Question(string question, string answerA, string answerB, string answerC, string answerD, int answer)
    {
        this->question = question;
        this->answers[0] = answerA;
        this->answers[1] = answerB;
        this->answers[2] = answerC;
        this->answers[3] = answerD;
        this->answer = answer;
    }

    int ask()
    {
        cout << question << endl;
        cout << "1. " << answers[0] << endl;
        cout << "2. " << answers[1] << endl;
        cout << "3. " << answers[2] << endl;
        cout << "4. " << answers[3] << endl;
        int x;
        cin >> x;
        if (x == answer)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
};

vector<Question> questions{
    Question("Co oznacza ifstream?", "Strumień zapisu do pliku", "Strumień odczytu z pliku", "Strumień tworzony jeśli spełniony jest warunek", "Strumień dostępny jeśli podany plik jest poprawny", 1),
    Question("Co oznacza ofstream?", "Strumień zapisu do pliku", "Strumień odczytu z pliku", "Strumień tworzony jeśli spełniony jest warunek", "Strumień dostępny jeśli podany plik jest poprawny", 2),
    Question("Co oznacza flaga ios::out?", "Dane będą pobierane z pliku", "Dane będą zapisywane do pliku", "Dane będą wysyłane poza serwer", "Dane będą ściągane z zewnętrznego serwera", 2),
    Question("Co oznacza flaga ios::trunc?", "Dane w pliku będą usunięte przed zapisem nowych", "Dane w pliku będą skrócone", "Dane w pliku będą skompresowane", "Dane w pliku będą zapisane w postaci binarnej", 1),
    Question("Co oznacza flaga ios::app?", "Dane w pliku będą dopisane na końcu pliku", "Plik będzie aplikacją wykonywalna", "Edytowane będą metadane pliku", "Dane w pliku będą zapisane w postaci binarnej", 1),
    Question("Co oznacza fstream?", "Strumień danych pozwalający jednocześnie na zapis lub odczyt danych", "Strumień zmiennych typu float", "Strumień przetwarzany w postaci fstringów", "Strumień folderów", 1),
    Question("Co oznacza wyrażenie `int x[10];`?", "Stworzenie tablicy liczb typu int na 10 elementów", "Stworzenie zmiennej o nazwie x i wartości 10", "Odwołanie się do 10 pozycji na liście", "Przypisanie wartości 10", 1),
    Question("W jaki sposób uzyskać 3cią wartość w tablicy tab?", "tab[3]", "tab[2]", "tab(3);", "tab(2)", 1),
    Question("Dla operacji int tab[10]; - jaki typ ma zmienna tab?", "int", "int[]", "int*", "int&", 3),
    Question("Jak odwołać się do ostatniej wartości dla tablicy zadeklarowanej jako: int tab[10]; ?", "tab[9]", "tab[10]", "tab(9);", "tab(10)", 1),

};
int main()
{
    int suma = 0;
    for (int i = 0; i < questions.size(); i++)
    {
        suma += questions[i].ask();
    }

    cout<<"Twój wynik to "<<suma<<" na "<<questions.size()<<" punktów!"<<endl;
}