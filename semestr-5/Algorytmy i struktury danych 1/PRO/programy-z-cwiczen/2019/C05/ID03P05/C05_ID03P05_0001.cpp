///213.135.46.21:7070
///\\sz240
#include <iostream>
#include<ctime>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
///**********************************
///**********************************
class TabInt01{
    public:
        TabInt01(int);
        TabInt01(const TabInt01&);
        ~TabInt01();
        int *PT();
        int Length();
    private:
        int *pT;
        int  sT;
    };
///**********************************
///**********************************
TabInt01::TabInt01(int sT){
    if(sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->sT = sT;
        this->pT = new int[this->sT];
        }
    }
///**********************************
TabInt01::TabInt01(const TabInt01& t){
    if(t.sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->sT = t.sT;
        this->pT = new int[this->sT];
        for(int i=0; i<sT;++i)
            this->pT[i] = t.pT[i];
        }
    }
///**********************************
TabInt01::~TabInt01(){
    delete[] pT;
    pT = NULL;
    sT = 0;
    }
///**********************************
int* TabInt01::PT(){return pT;}
///**********************************
int  TabInt01::Length(){return sT;}
///**********************************
///**********************************
int MyRead(string="x? = ");
int main01();
int main02();
int main03();
void Test01();
void Test02(TabInt01);
///**********************************
///**********************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**********************************
///**********************************
int main01(){
    for(int i =0; i<99999;++i)
        Test01();

    return 0;
    }
///**********************************
///**********************************
int main02(){
    TabInt01 t1(5);
    for(int i=0;i<t1.Length();++i)
        t1.PT()[i] = i;
    for(int i=0;i<t1.Length();++i)
        cout<<t1.PT()[i]<<endl;

    Test02(t1);
    TabInt01 t2(5);
    for(int i=0;i<t2.Length();++i)
        t2.PT()[i] = 999;

    for(int i=0;i<t1.Length();++i)
        cout<<t1.PT()[i]<<endl;
    return 0;
    }
///**********************************
///**********************************
int main03(){

    return 0;
    }
///**********************************
void Test01(){
    TabInt01 t(99999);
    }
///**********************************
void Test02(TabInt01 t){}
///**********************************
int main(){
    srand(time(0));
    main02();

    return 0;
    }

