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
    cout<<3[myT]<<endl;

    delete[] myT;



    return 0;
    }
