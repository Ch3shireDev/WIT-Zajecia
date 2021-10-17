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
double StringSum(stringstream&);
///---------------------------------------------------------------------------
int main(){
    string str1;
    getline(cin, str1);        

    double x, sum = 0;
    int cnt = 0;

    stringstream s1(str1);
    
    
    while(s1>>str1){        
        if(stringstream(str1)>>x){        
            sum += x;
            ++cnt;
            }            
        }
        
    cout<<"Suma "<<cnt<<" liczb = "<<sum<<endl;
    return 0;
    }
///18, 18, 10 ...

