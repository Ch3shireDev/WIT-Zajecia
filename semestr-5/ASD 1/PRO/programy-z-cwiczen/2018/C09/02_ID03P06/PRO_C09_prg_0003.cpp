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
        ~TabIntX01();
        void TmpIni(int x=0){for(int i=0; i<sT;++i)pT[i]=i+x;}
        void TmpPrint(){for(int i=0; i<sT;++i)cout<<"T["<<i<<"]="<<pT[i]<<endl;}
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
    delete[] pT;
    cout<<"DESTRUKTOR"<<endl;
/*    sT = 0;
    pT = NULL;
    */
    }
///********************************************************************************************
///********************************************************************************************
void StupidFunction(){
    TabIntX01 tabIntX01(10);
    //cout<<"StupidFunction ";
    }
///********************************************************************************************
///********************************************************************************************
int main(){
    StupidFunction();
    cout<<"*************************************"<<endl;

/*    TabIntX01 tabIntX01(10);
    tabIntX01.TmpIni(20);
    tabIntX01.TmpPrint();
    tabIntX01.~TabIntX01();
    //cout<<"*************************************"<<endl;
    TabIntX01 tabIntX02(10);
    tabIntX02.TmpIni();

    tabIntX01.TmpPrint();
*/

    return 0;
    }
