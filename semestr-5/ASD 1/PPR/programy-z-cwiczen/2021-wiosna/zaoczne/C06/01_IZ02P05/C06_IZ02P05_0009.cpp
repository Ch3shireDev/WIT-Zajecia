#include <iostream>
#include <sstream>
#include <string>
#include <iomanip>
#include <vector>

using std::cout;
using std::cin;
using std::endl;
using std::setw;
using std::string;
using std::getline;
using std::stringstream;

///---------------------------------------------------------------------------
int main(){
    stringstream s1, s2;
    string  myStr;
    double x, sum =0;
    int cnt =0;
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 <<myStr;   
    
    
    while(s1>>myStr){
        if(stringstream(myStr)>>x){
            ++cnt;
            sum+=x;
            }                
        }
    
    cout<<"suma "<<cnt<<" liczb = "<<sum<<endl;
    return 0;
    }

///23, 18, 18, 10 ...
