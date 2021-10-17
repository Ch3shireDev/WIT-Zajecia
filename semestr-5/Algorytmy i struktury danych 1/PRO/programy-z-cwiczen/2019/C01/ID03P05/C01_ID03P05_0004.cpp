///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;


int main(){
    int sT;
    int * pT;

    cout<<"sT ?= ";
    cin>>sT;



    pT = new int[sT];
    for(int i=0; i<sT;pT[i]=i++);
    for(int i=0; i<sT;cout<<"pT["<<i++<<"] = "<<pT[i]<<endl);

    for(int i=0; i<sT;++i)
        pT[i]=i;

    int x = sT++;

    sT++;
    return 0;
    }
