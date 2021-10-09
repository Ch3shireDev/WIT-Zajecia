#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
///**********************************************************************************
int MyRead(string);
int** PascalTriangle(int);
void PrintPascalTriangle(int**, int);
void PrintPascalTrianglePt(int**, int);
///**********************************************************************************
int MyRead(string myStr){
    int x;

    cout<<myStr;
    cin>>x;

    return x;
    }
///**********************************************************************************
/**
x ?= 4

1
1 1
1 2 1
1 3 3 1
1 4 6 4 1

*/
int** PascalTriangle(int sT){
    int ** pT;
    int i, ssT;
    ++sT;
    ssT= ((sT+1)*sT)/2;
    pT = new int* [sT];

    pT[0] = new int[ssT];

    for(i=1;i<sT;++i)
       *(pT+i) = pT[i-1]+i;

    for(i=0;i<ssT;++i)
        pT[0][i]=i;

    return pT;
    }
///**********************************************************************************
void PrintPascalTriangle(int** pT, int sT){
    int i,j;
    ++sT;
    for(i=0;i<sT;++i){
        for(j=0;j<=i;++j){
                /*
            cout.width(3);
            cout<<pT[i][j];
            cout<<" ";
            */
            }
        //cout<<endl;
        }
    }
///**********************************************************************************
void PrintPascalTrianglePt(int** pT, int sT){
    int i;
    ++sT;
    int *tB, *tE;
    for(i=0;i<sT;++i, ++pT){
        for(tB=*pT, tE=*pT+i;tB<=tE;++tB){
                /*
            cout.width(3);
            cout<<*tB;
            cout<<" ";*/
            }
        //cout<<endl;
        }
    }
///**********************************************************************************
///**********************************************************************************
///**********************************************************************************
int main(){

    int** pT, sT=30000;
    //sT=MyRead("x ?=");

    pT=PascalTriangle(sT);
    PrintPascalTriangle(pT,sT);

    return 0;
    }
