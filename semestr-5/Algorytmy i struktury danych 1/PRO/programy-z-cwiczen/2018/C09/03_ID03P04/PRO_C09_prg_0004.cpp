#include<iostream>
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
        TabIntX01 operator=(const TabIntX01&);

        void TmpIni(int x=0){for(int i=0;i<sT;++i)pT[i]=i+x;}
        void TmpPrn(){for(int i=0;i<sT;++i)cout<<"T["<<i<<"]="<<pT[i]<<endl;}
    private:
        int  sT;
        int* pT;
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
TabIntX01 TabIntX01::operator=(const TabIntX01& tabIntX01){
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
void StupidFunction(TabIntX01 tX01){

    }
///********************************************************************************************
///********************************************************************************************
int main(){
    TabIntX01 tX01(10);
    TabIntX01 tX;
    tX01.TmpIni(20);
    tX01.TmpPrn();

    tX=tX01;
///    tX.operator=(tX01);

    tX.~TabIntX01();

    TabIntX01 tX02(10);
    tX02.TmpIni();
    cout<<"**************************************"<<endl;

    tX01.TmpPrn();

    return 0;
    }
