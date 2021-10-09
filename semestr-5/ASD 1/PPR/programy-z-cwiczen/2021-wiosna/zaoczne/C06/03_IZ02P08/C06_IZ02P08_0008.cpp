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
    string str1, str2 ;
    getline(cin, str1);        
    double x, sum = 0;
    int cnt = 0;
    cout<<str1<<endl;    
    stringstream s1(str1), s2;
    
    cout<<"--------------------------------------"<<endl;
    
    while(s1>>str2){
        s2 = stringstream(str2);        
        if(s2>>x){        
            sum += x;
            ++cnt;
            }            
        }
        
    cout<<"Suma "<<cnt<<" liczb = "<<sum<<endl;
        return 0;
    }


