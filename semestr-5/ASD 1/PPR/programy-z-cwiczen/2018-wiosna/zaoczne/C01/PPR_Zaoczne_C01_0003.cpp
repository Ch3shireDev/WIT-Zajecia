#include <iostream>
using namespace std;

int main(){
    int x0, y0, z0;
    int x1, y1, z1;
    int tmp;

    cout<<" x ?= ";
    cin>>x0;
    cout<<" y ?= ";
    cin>>y0;
    cout<<" z ?= ";
    cin>>z0;

    x1 = x0;
    y1 = y0;
    z1 = z0;

    if(x1>y1){
        tmp = x1;
        x1 = y1;
        y1 = tmp;
        }
    if(z1<y1){
        tmp = z1;
        z1 = y1;
        y1 = tmp;
        }

    if(x1>y1){
        tmp = x1;
        x1 = y1;
        y1 = tmp;
        }

    cout<<"("<<x0<<", "<<y0<<", "<<z0<<") ->";
    cout<<"("<<x1<<", "<<y1<<", "<<z1<<")"<<endl;

    return 0;
    }
