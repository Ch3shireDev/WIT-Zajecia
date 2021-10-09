#include<iostream>
#include<cstdlib>
#include<ctime>
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;
///********************************************************************************************
///********************************************************************************************
class TabIntX01{
    public:
        TabIntX01(int=0);
        TabIntX01(const TabIntX01&);
        ~TabIntX01();
        TabIntX01 operator=(const TabIntX01&);
        int& operator[](int);
        int SIZE();
    private:
        int  sT;
        int* pT;
    friend ostream& operator<<(ostream&, const TabIntX01&);
    friend istream& operator>>(istream&, TabIntX01&);
    };
///********************************************************************************************
///********************************************************************************************
class TabIntX02{
    public:
        TabIntX02(int=0, int=0);
        TabIntX02(const TabIntX02&);
        ~TabIntX02();
        TabIntX02 operator=(const TabIntX02&);
        //int& operator[](int);
        int SIZE(int);
    private:
        int  sT1,sT2;
        TabIntX01* pT;
    };
///********************************************************************************************
///********************************************************************************************
TabIntX01::TabIntX01(int sT){
    if(sT<1){
        this->sT=0;
        this->pT=NULL;
        }
    else{
        this->sT=sT;
        this->pT=new int[this->sT];
        }
    }
///********************************************************************************************
TabIntX01::TabIntX01(const TabIntX01& tabIntX01){
    if(tabIntX01.sT>0){
        this->sT = tabIntX01.sT;
        this->pT = new int[this->sT];
        for(int i=0; i<this->sT;++i)
            this->pT[i]=tabIntX01.pT[i];
        }
    else{
        this->sT = 0;
        this->pT = NULL;
        }
    }
///********************************************************************************************
TabIntX01::~TabIntX01(){
    delete[] pT;
    pT=NULL;
    sT=0;
    }
///********************************************************************************************
TabIntX01 TabIntX01::operator=(const TabIntX01& tabIntX01){
    delete[] this->pT;
    if(tabIntX01.sT>0){
        this->sT = tabIntX01.sT;
        this->pT = new int[this->sT];
        for(int i=0; i<this->sT;++i)
            this->pT[i]=tabIntX01.pT[i];
        }
    else{
        this->sT = 0;
        this->pT = NULL;
        }
    return *this;
    }
///********************************************************************************************
int& TabIntX01::operator[](int i){
    return this->pT[i];
    }
///********************************************************************************************
int TabIntX01::SIZE(){
    return this->sT;
    }
///********************************************************************************************
ostream& operator<<(ostream& s, const TabIntX01& tabIntX01){
    for(int i=0;i<tabIntX01.sT;++i){
        s<<"[";
        s.width(3);
        s<<tabIntX01.pT[i];
        s<<"]";
        }
    return s;
    }
///********************************************************************************************
istream& operator>>(istream& s, TabIntX01& tabIntX01){
    for(int i=0;i<tabIntX01.sT;++i){
        cout<<"T[";
        cout.width(2);
        cout<<i;
        cout<<"]? = ";
        s>>tabIntX01.pT[i];
        }
    return s;}
///********************************************************************************************
int main(){
    srand(time(NULL));
    TabIntX01 myT(20);
/*
    for(int i=0;i<myT.SIZE();++i)
        myT[i]=rand()%1000;
*/
    cin>>myT;
    cout<<myT<<endl;

    return 0;
    }
