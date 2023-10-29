#include <iostream>
#include <vector>
using namespace std;

void selection_sort(vector<int> &tab)
{
    int n = tab.size();
    for (int i = 0; i < n; i++)
    {
        int mini = i;
        for (int j = i + 1; j < n; j++)
        {
            if (tab[j] < tab[mini])
            {
                mini = j;
            }
        }
        int c = tab[mini];
        tab[mini] = tab[i];
        tab[i] = c;
    }
}

int main()
{
    vector<int> tab = vector<int>{8, 1, 2, 3, 6, 1, 2, 3, 3, 3};
    selection_sort(tab);
    for (int i = 0; i < tab.size(); i++)
    {
        cout << tab[i] << endl;
    }
}