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
        int& Value(int);
        int& operator[](int);

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
int& TabInt01::Value(int i){
    return pT[i];
    }
///**********************************
int& TabInt01::operator[](int i){
    return pT[i];
    }
///**********************************
int TabInt01::Length(){
    return sT;
    }
///**********************************
///**********************************
int MyRead(string="x? = ");
int main01();
int main02();
int main03();
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
    TabInt01 t(5);
    for(int i = 0; i<t.Length();++i )
        t.Value(i)=i;
    for(int i = 0; i<t.Length();++i )
        cout<<t.Value(i)<<endl;
    return 0;
    }
///**********************************
///**********************************
int main02(){
    TabInt01 t(5);
    for(int i = 0; i<t.Length();++i )
        t.operator[](i)=i;
    for(int i = 0; i<t.Length();++i )
        cout<<t.operator[](i)<<endl;
    return 0;
    }
///**********************************
///**********************************
int main03(){
    TabInt01 t(5);
    for(int i = 0; i<t.Length();++i )
        t[i]=i;
    for(int i = 0; i<t.Length();++i )
        cout<<t[i]<<endl;
    return 0;
    }
///**********************************
///**********************************
int main(){
    srand(time(0));
    main03();

    return 0;
    }

