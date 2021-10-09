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
double StringSum(stringstream &);
///---------------------------------------------------------------------------
int main(){
    string myStr, str;
    double x, sum = 0;
    int cnt = 0;
    
    getline(cin, myStr);

    stringstream s1(myStr);    
    
    while(s1>>str){        
        if(stringstream(str)>>x){
            sum += x;
            ++cnt;
            }                
        }
    cout<<"suma "<<cnt<<" liczb ="<<sum<<endl;
    
    return 0;
    }
///10 ...
