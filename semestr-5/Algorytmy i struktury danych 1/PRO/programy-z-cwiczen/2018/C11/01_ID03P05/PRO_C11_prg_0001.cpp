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
class TabCharX01{
    public:
        TabCharX01(int=0);
        TabCharX01(const TabCharX01&);
        ~TabCharX01();
        TabCharX01 operator=(const TabCharX01&);
        char& operator[](int);
        int SIZE();
    private:
        int  sT;
        char* pT;
    };
///********************************************************************************************
///********************************************************************************************
TabCharX01::TabCharX01(int sT){
    if(sT<1){
        this->sT=0;
        this->pT=NULL;
        }
    else{
        this->sT=sT;
        this->pT=new char[this->sT];
        }
    }
///********************************************************************************************
TabCharX01::TabCharX01(const TabCharX01& tabCharX01){
    if(tabCharX01.sT>0){
        this->sT = tabCharX01.sT;
        this->pT = new char[this->sT];
        for(int i=0; i<this->sT;++i)
            this->pT[i]=tabCharX01.pT[i];
        }
    else{
        this->sT = 0;
        this->pT = NULL;
        }
    }
///********************************************************************************************
TabCharX01::~TabCharX01(){
    delete[] pT;
    pT=NULL;
    sT=0;
    }
///********************************************************************************************
TabCharX01 TabCharX01::operator=(const TabCharX01& tabCharX01){
    delete[] this->pT;
    if(tabCharX01.sT>0){
        this->sT = tabCharX01.sT;
        this->pT = new char[this->sT];
        for(int i=0; i<this->sT;++i)
            this->pT[i]=tabCharX01.pT[i];
        }
    else{
        this->sT = 0;
        this->pT = NULL;
        }
    return *this;
    }
///********************************************************************************************
char& TabCharX01::operator[](int i){
    return this->pT[i];
    }
///********************************************************************************************
int TabCharX01::SIZE(){
    return this->sT;
    }
///********************************************************************************************
///********************************************************************************************
int main(){
    srand(time(NULL));
    TabCharX01 tabCharX01(10);
    for(int i=0;i<tabCharX01.SIZE();++i)
        tabCharX01[i] = (char)(rand()%26+65);

    for(int i=0;i<tabCharX01.SIZE();++i)
        cout<<tabCharX01[i]<<endl;


    return 0;
    }
