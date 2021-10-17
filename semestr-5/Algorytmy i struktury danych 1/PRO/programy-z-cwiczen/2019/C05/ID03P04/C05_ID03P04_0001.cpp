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
        TabInt01(int=0);
        TabInt01(const TabInt01&);
        ~TabInt01();
   // private:
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
        this->pT = new int[sT];
        this->sT = sT;
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
        this->pT = new int[sT];
        for(int i=0;i<sT;++i)
            pT[i] = t.pT[i];
        }
    }
///**********************************
TabInt01::~TabInt01(){
    delete[] pT;
    pT = NULL;
    sT = 0;
    }
///**********************************
///**********************************
int MyRead(string="x? = ");
int main01();
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
    for(int j =0; j<99999;++j)
        Test01();
    return 0;
    }
///**********************************
int main02(){
    TabInt01 t1(5);

    for(int i =0;i<t1.sT;++i)
        t1.pT[i] = i;
    for(int i =0;i<t1.sT;++i)
        cout<<t1.pT[i]<<endl;

    Test02(t1);
    TabInt01 t2(5);
    for(int i =0;i<t2.sT;++i)
        t2.pT[i] = 9999;
    for(int i =0;i<t1.sT;++i)
        cout<<t1.pT[i]<<endl;

    return 0;
    }
///**********************************
void Test01(){
    TabInt01 t(99999);
    }
///**********************************
void Test02(TabInt01 t){
    }
///**********************************
///**********************************
int main(){
    srand(time(0));
    main02();

    return 0;
    }

