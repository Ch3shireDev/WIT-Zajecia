// Igor Nowicki
// 18608


// Zadanie 3

// Napisz program, który wypisze zawartość tablicy zadeklarowanej w następujący sposób:
// Należy napisać dwie funkcje: wersję zwykłą opartą o indeksowanie tablicy i wersję wskaźnikową.

#include <iostream>
using namespace std;

void show_array(int *tab, int n){
    for(int i=0;i<n;i++){
        cout<<tab[i]<<endl;
    }

}

void show_array_ptr(int *tab, int n){
for(int i=0;i<n;i++){
    cout<<*(tab+i)<<endl;
}
}

int main()
{
    int a[] = {1, 3, 5, 7, 9, 11, 13};
    show_array(a,7);
    show_array_ptr(a,7);
}