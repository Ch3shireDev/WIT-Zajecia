#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
///**************************************************************
///**************************************************************
int MyRead();
int MyRead(string);
int MyMax(int, int);
int** NewTabIntX02(int, int);
int FillTabIntX02(int**, int, int);
int PrintTabIntX02(int**, int, int);
int DeleteTabIntX02(int**);
///**************************************************************
///**************************************************************
int MyRead(){
    int x;
    cout<<"x? = ";
    cin>>x;
    return x;
    }
///**************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**************************************************************
int MyMax(int x0, int x1){
    if(x0>x1) return x0;
    return x1;
    }
///**************************************************************
int** NewTabIntX02(int sT1, int sT2){
    int** myTab;
    myTab = new int*[sT1];
    myTab[0] = new int[sT1*sT2];
    for(int i=1; i<sT1;++i)
        myTab[i] = myTab[0] + i*sT2;
    return myTab;
    }
///**************************************************************
int FillTabIntX02(int** myTab, int sT1, int sT2){
    if(NULL==myTab || sT1<1 || sT2<1) return 0;
    for(int i=0;i<sT1*sT2;++i)
            myTab[0][i]=i;
    return 1;
    }
///**************************************************************
int PrintTabIntX02(int** myTab, int sT1, int sT2){
    if(NULL==myTab || sT1<1 || sT2<1) return 0;
    for(int i=0;i<sT1;++i){
        for(int j=0;j<sT2; ++j){
            cout<<"[";
            cout.width(3);
            cout<<myTab[i][j];
            cout<<"]";
            }
        cout<<"\n";
        }
    return 1;
    }
///**************************************************************
int DeleteTabIntX02(int** myTab){
    if(NULL==myTab) return 0;
    delete[] myTab[0];
    delete[] myTab;
    return 1;
    }
///**************************************************************
///**************************************************************
int main(){
    int **myTab;
    int sT1, sT2;
    sT1 = MyRead("sT1? = ");
    sT2 = MyRead("sT2? = ");

    myTab = NewTabIntX02(sT1, sT2);
    FillTabIntX02(myTab, sT1, sT2);
    PrintTabIntX02(myTab, sT1, sT2);

    DeleteTabIntX02(myTab);

    return 0;
    }
