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
using std::istream;

///---------------------------------------------------------------------------
double StringSum(stringstream &);
double InSum(istream&);
///---------------------------------------------------------------------------
double StringSum(stringstream & s1){
    string str;
    double x, sum = 0;    
    
    while(s1>>str) if(stringstream(str)>>x) sum += x;
    
    return sum;
    }
///---------------------------------------------------------------------------
int main(){
    string myStr;
    double sum;
    
    getline(cin, myStr);
    stringstream s1(myStr);    
    
    sum = StringSum(s1);
    cout<<"suma  = "<<sum<<endl;
    
    return 0;
    }

///10, 8, 8, 6 ...
