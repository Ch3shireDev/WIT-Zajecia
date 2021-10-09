#include<iostream>
using namespace std;

int main(){
    int maxNp=0;
    int minP=0;
    int x;

    cout<<"x ?=";
    cin>>x;

    while(x!=0){
        if(x%2 !=0){
            if(maxNp == 0) {
                    maxNp = x;
            }
            else {
                    if(x > maxNp) maxNp = x;
                }
            }
        else{
            if(minP == 0) {
                minP = x;
                }
            else{

                if(x < minP) minP = x;
                }
            }
        cout<<"x ?=";
        cin>>x;
        }

    cout<<"Max Np = "<<maxNp<<", min P = "<<minP<<endl;

    return 0;
    }
