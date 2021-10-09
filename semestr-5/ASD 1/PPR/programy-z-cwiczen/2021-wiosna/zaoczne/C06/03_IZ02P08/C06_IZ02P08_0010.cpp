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
double StringSum(stringstream&);
double InSum(istream&);
///---------------------------------------------------------------------------
double StringSum(stringstream& s1){
    string str1;   
    double x, sum = 0;
    
    while(s1>>str1)  if(stringstream(str1)>>x) sum += x;            

    return sum;
    }
///---------------------------------------------------------------------------
int main(){
    string str1;
    getline(cin, str1);        

    double sum;

    stringstream s1(str1);

    sum = StringSum(s1);
        
    cout<<"Suma liczb = "<<sum<<endl;
    return 0;
    }
///10, 8, 8, 6 ...

