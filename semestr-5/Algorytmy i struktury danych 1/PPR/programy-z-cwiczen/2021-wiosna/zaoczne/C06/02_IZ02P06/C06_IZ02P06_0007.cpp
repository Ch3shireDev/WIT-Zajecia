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
    string myStr, str;
    stringstream s1, s2;
    double x, sum = 0;
    int cnt = 0;
    
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 = stringstream(myStr);    
    
    while(s1>>str){        
        if(stringstream(str)>>x){
            sum += x;
            ++cnt;
            }                
        }
    cout<<"suma "<<cnt<<" liczb ="<<sum<<endl;
    
    return 0;
    }
///26, 23, 23, 18, 18, 18, 10 ...
