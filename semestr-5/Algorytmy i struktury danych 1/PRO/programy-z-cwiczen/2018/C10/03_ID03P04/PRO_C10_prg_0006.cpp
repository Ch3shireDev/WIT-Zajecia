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
        ~TabIntX02();
        ///TabIntX01 operator=(const TabIntX01&);

        TabIntX01& operator[](int);
        ///int Length(int);
    private:
        int  sT1, sT2;
        TabIntX01* pT;
    friend ostream& operator<<(ostream&, const TabIntX02&);
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
    }
///********************************************************************************************
///********************************************************************************************
TabIntX02::~TabIntX02(){
    delete[] this->pT;
    this->sT1 = this->sT2= 0;
    this->pT = NULL;
    }
///********************************************************************************************
TabIntX01& TabIntX02::operator[](int i){return pT[i];}
///********************************************************************************************
ostream& operator<<(ostream& s, const TabIntX02& tabIntX02){
    if(tabIntX02.sT1<1){s<<"NULL";return s;}
    for(int i = 0; i<tabIntX02.sT1;++i){
        s<<tabIntX02.pT[i];
        }
    return s;
    }
///********************************************************************************************
///********************************************************************************************
int main(){
    srand(time(NULL));
    TabIntX02 tX02(2,3);

    tX02[0][1]=12;
    cout<<tX02[0][1]<<endl;

    tX02.operator[](0).operator[](1) = 123;
    cout<<tX02[0][1]<<endl;

    return 0;
    }
