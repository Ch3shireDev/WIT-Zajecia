#include <iostream>
using namespace std;

int main(){
    int n;
    int i;
    int silnia;

    cout<<" n ?= ";
    cin>>n;

    silnia = 1;
    i = 2;
    while(i<=n){
        silnia*=i++;
        }

    cout<<n<<"! = "<< silnia<<endl;

    return 0;
    }
