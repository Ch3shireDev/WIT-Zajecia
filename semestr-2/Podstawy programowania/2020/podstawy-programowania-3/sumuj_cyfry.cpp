//Igor Nowicki
//IZ02P03
//18608
#include <iostream>
#include <cstdlib>

using namespace std;

int sumuj(int x)
{
    int sum = 0;
    string str = to_string(x);
    for (int i = 0; i < str.length(); i++)
    {
        char c = str[i];
        int n = c - '0';
        sum += n;
    }
    return sum;
}

bool is_number(string str)
{
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] < '0' || str[i] > '9')
        {
            return false;
        }
    }
    return true;
}

int main()
{
    string str;
    bool flag = true;

    do
    {
        cout << "Proszę podać poprawną liczbę: ";
        cin >> str;
    } while (!is_number(str));

    int x = atoi(str.c_str());
    do
    {
        x = sumuj(x);
    } while (x > 17);
    cout << x << endl;
}