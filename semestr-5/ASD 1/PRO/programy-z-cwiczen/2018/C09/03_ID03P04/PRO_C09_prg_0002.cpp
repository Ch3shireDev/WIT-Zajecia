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
        ~TabIntX01();
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
TabIntX01::~TabIntX01(){
    delete[] this->pT;
    this->sT = 0;
    this->pT = NULL;
    }
///********************************************************************************************
void StupidFunction(){
    TabIntX01 tX01(999999);
    cout<<"Stupid ";
    }
///********************************************************************************************
///********************************************************************************************
int main(){
    for(int i=0;i<600;++i) StupidFunction();

    return 0;
    }
