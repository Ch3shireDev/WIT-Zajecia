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
class TabIntX01{
    public:
        TabIntX01(int=0);
        TabIntX01(const TabIntX01&);
        ~TabIntX01();
        TabIntX01& operator=(const TabIntX01&);

        int& operator[](int);
        int Length();
    private:
        int  sT;
        int* pT;
    friend ostream& operator<<(ostream&, const TabIntX01&);
    };
///********************************************************************************************
///********************************************************************************************
class TabIntX02{
    public:
        TabIntX02(int=0, int=0);
        ///TabIntX01(const TabIntX01&);
        ///~TabIntX01();
        ///TabIntX01 operator=(const TabIntX01&);

        ///int& operator[](int);
        ///int Length();
    private:
        int  sT1, sT2;
        TabIntX01* pT;
    ///friend ostream& operator<<(ostream&, const TabIntX01&);
    };
///********************************************************************************************
///********************************************************************************************
TabIntX01::TabIntX01(int sT){
    if(sT<1){
        this->sT = 0;
        this->pT = NULL;
        }
    else{
        this->sT = sT;
        this->pT = new int[this->sT];
        }
    cout<<"Konstruktor  TabIntX01 - rozmiar: "<<sT<<endl;
    }
///********************************************************************************************
TabIntX01::TabIntX01(const TabIntX01& tabIntX01){
    if(tabIntX01.sT<1){
        this->sT = 0;
        this->pT = NULL;
        }
    else{
        this->sT = tabIntX01.sT;
        this->pT = new int[this->sT];
        for(int i=0; i<this->sT; ++i) this->pT[i] = tabIntX01.pT[i];
        }
    }
///********************************************************************************************
TabIntX01::~TabIntX01(){
    delete[] this->pT;
    this->sT = 0;
    this->pT = NULL;
    cout<<"----------->>>>>>>>>>>> Destruktor  TabIntX01 "<<endl;
    }
///********************************************************************************************
TabIntX01& TabIntX01::operator=(const TabIntX01& tabIntX01){
    delete[] this->pT;
    if(tabIntX01.sT<1){
        this->sT = 0;
        this->pT = NULL;
        }
    else{
        this->sT = tabIntX01.sT;
        this->pT = new int[this->sT];
        for(int i=0; i<this->sT; ++i) this->pT[i] = tabIntX01.pT[i];
        }
    return *this;
    }
///********************************************************************************************
int& TabIntX01::operator[](int i){
    return this->pT[i];
    }
///********************************************************************************************
int TabIntX01::Length(){return this->sT;}
///********************************************************************************************
ostream& operator<<(ostream& s, const TabIntX01& tabIntX01){
    if(tabIntX01.sT<1){s<<"NULL";return s;}
    for(int i = 0; i<tabIntX01.sT;++i){
        s<<"[";
        s.width(3);
        s<<tabIntX01.pT[i];
        s<<"]";
        }
    return s;
    }
///********************************************************************************************
///********************************************************************************************
TabIntX02::TabIntX02(int sT1, int sT2){
    if(sT1<1){
        this->sT1 = 0;
        this->sT2 = 0;
        this->pT = NULL;
        }
    else{
        this->sT1 = sT1;
        this->pT = new TabIntX01[this->sT1];
        if(sT2<1){
            this->sT2 = 0;
            }
            else{
                for(int i = 0;i<sT1;++i)
                    pT[i] = TabIntX01(sT2);
            }
        }
        for(int i=0;i<sT1;++i)
            cout<<pT[i]<<endl;
    }
///********************************************************************************************
///********************************************************************************************
///********************************************************************************************
int main(){
    srand(time(NULL));
    TabIntX02 tX02(2,3);
    return 0;
    }
