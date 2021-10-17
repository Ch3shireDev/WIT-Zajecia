#include<iostream>
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

        void TmpIni(int x=0){
            for(int i = 0;i<sT;++i)pT[i]=i+x;
            }
        void TmpPrint(){
            for(int i = 0;i<sT;++i)cout<<"T["<<i<<"]="<<pT[i]<<endl;
            }
    private:
        int  sT;
        int* pT;
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
    return TabIntX01(tabIntX01);
    }
///********************************************************************************************
void StupidFunction(TabIntX01 tabIntX01){
    }
///********************************************************************************************
///********************************************************************************************
int main(){
    TabIntX01 tabIntX01(10);
    TabIntX01 tabIntX;
    tabIntX01.TmpIni();
    tabIntX01.TmpPrint();
    tabIntX=tabIntX01;
    tabIntX.~TabIntX01();
    cout<<"*************************************"<<endl;
    TabIntX01 tabIntX02(10);
    tabIntX02.TmpIni(20);
    tabIntX01.TmpPrint();

    return 0;
    }
