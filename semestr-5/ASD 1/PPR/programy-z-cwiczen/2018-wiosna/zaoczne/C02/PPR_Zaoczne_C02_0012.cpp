#include<iostream>
using namespace std;

int main(){
    int *myT;
    int sT = 4;
    myT = new int[sT];
    *(myT + 0) = 12; /// myT[0] = 12;
    *(myT + 1) =  9; /// myT[1] =  9;
    *(myT + 2) =  4; /// myT[2] =  4;
    *(myT + 3) = -9; /// myT[3] = -9;


    /// myT[i] <=> *(myT + i) <=> *(i + myT) <=> i[myT]

    for(int i = 0; i< sT; ++i)
        cout<<myT[i]<<endl;

    for(int i = 0; i< sT; ++i){
        cout<<*myT<<endl;
        ++myT;
        }

    for(int i = 0; i< sT; ++i){
        --myT;
        }

   for(int i = 0; i< sT; ++i){
        cout<<myT[0]<<endl;
        ++myT;
        }

    for(int i = 0; i< sT; ++i){
        --myT;
        }
    delete[] myT;



    return 0;
    }
