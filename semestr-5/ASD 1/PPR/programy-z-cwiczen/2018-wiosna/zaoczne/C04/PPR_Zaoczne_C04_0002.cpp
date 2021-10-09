#include <iostream>
using namespace std;
///*******************************************************************************
///*******************************************************************************
int MyRead(int);
void MyLine(int, string );
void MySquare(int, string);
void Triangle1(int);

/**
x ?= 5

 * * * * *
 * * * *
 * * *
 * *
 *

*/
void Triangle2(int);
/**
x ?= 5

 * * * * *
   * * * *
     * * *
       * *
         *

*/
void ChessBoard(int, int);
void DoubleSquareLine(int sCb, int sS,string, string);
void SquareLine(int sCb, int sS,string, string);
void MultiLine(int sCb, int sS,string, string);
void DoubleLine(int sS,string, string);
///*******************************************************************************
///*******************************************************************************
int MyRead(int i){
    int x;
    cout<<"x"<<i<<" ?=";
    cin>>x;

    return x;
    }
///*******************************************************************************
void MyLine(int x, string myStr){
    for(int i=0; i<x;++i)
        cout<<myStr;
    }
///*******************************************************************************
void MySquare(int x, string myStr){
    for(int i=0; i< x; ++i){
        MyLine(x, myStr);
        cout<<endl;
        }
    }
///*******************************************************************************
void Triangle1(int x){
    for(int i=0; i< x; ++i){
        MyLine(x-i, " *");
        cout<<endl;
        }
    }
///*******************************************************************************
void Triangle2(int x){
    for(int i=0; i< x; ++i){
        MyLine(i, "  ");
        MyLine(x-i, " *");
        cout<<endl;
        }
    }
///*******************************************************************************
void ChessBoard(int sCb, int sS){
    for(int i=0; i<sCb;++i)
        DoubleSquareLine(sCb, sS, " *", "  ");
    }
///*******************************************************************************
void DoubleSquareLine(int sCb, int sS,string mStr1, string mStr2){
    SquareLine(sCb, sS,mStr1, mStr2);
    SquareLine(sCb, sS,mStr2, mStr1);
    }
///*******************************************************************************
void SquareLine(int sCb, int sS,string mStr1, string mStr2){
    for(int i=0; i<sS; ++i){
        MultiLine(sCb, sS,mStr1, mStr2);
        cout<<endl;
        }
    }
///*******************************************************************************
void MultiLine(int sCb, int sS,string mStr1, string mStr2){
    for(int i=0; i<sCb; ++i)
        DoubleLine(sS,mStr1, mStr2);
    }
///*******************************************************************************
void DoubleLine(int sCb,string mStr1, string mStr2){
    MyLine(sCb,mStr1);
    MyLine(sCb,mStr2);
    }
///*******************************************************************************
///*******************************************************************************
int main(){

    int x1 =MyRead(1);
    int x2 =MyRead(2);

    ChessBoard(x1,x2);

    return 0;
    }
