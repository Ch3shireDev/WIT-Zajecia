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
double StreamSum(stringstream&);
///---------------------------------------------------------------------------
double StreamSum(stringstream& s1){
    double x, sum =0;
    string myStr;
    
    while(s1>>myStr){
        if(stringstream(myStr)>>x){
            sum+=x;
            }                
        }
    
    return sum;
    }
///---------------------------------------------------------------------------
int main(){
    stringstream s1;
    string  myStr;
    double sum;
    
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 <<myStr;   
    
    
    sum = StreamSum(s1);
    cout<<"suma  = "<<sum<<endl;
    return 0;
    }

///23, 18, 18, 10 ...
