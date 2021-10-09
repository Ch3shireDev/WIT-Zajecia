#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;

int main(){
    int x;

    cout<<"x? =";
    cin>>x;
    for(int i=0; i<x;++i)
        cout<<i<<endl;
    cout<<"***********************************"<<endl;
    for(int i=0; i<x;++i){
        cout<<"i = ";
        cout<<i<<endl;
        }
    cout<<"***********************************"<<endl;
    for(int i=0; i<x;++i){
        cout<<"i = "<<i<<endl;
        }
    cout<<"***********************************"<<endl;
    for(int i=0; i<x;++i){
        cout<<"i = ";
        cout.width(3);
        cout<<i<<endl;
        }
    cout<<"***********************************"<<endl;
    for(int i=0; i<x;++i){
        cout.width(7);
        cout<<"i = "<<i<<endl;
        }





    return 0;
    }
