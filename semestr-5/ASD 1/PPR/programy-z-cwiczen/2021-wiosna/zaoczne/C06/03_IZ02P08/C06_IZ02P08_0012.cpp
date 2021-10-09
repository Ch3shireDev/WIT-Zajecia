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
double StringSum(stringstream&&);
double InSum(istream&);
void Aqq1(int&);
//void Aqq1(int&&);
///---------------------------------------------------------------------------
double StringSum(stringstream& s1){
    string str1;   
    double x, sum = 0;
    
    while(s1>>str1)  if(stringstream(str1)>>x) sum += x;            

    return sum;
    }
///---------------------------------------------------------------------------
double StringSum(stringstream&& s1){
    string str1;   
    double x, sum = 0;
    
    while(s1>>str1)  if(stringstream(str1)>>x) sum += x;            

    return sum;
    }
///---------------------------------------------------------------------------
double InSum(istream& ss){
    string str;
    getline(ss, str);    
    return StringSum(stringstream(str));
    }
///---------------------------------------------------------------------------
void Aqq1(int& x){x =12; cout<<"x& = "<<x<<endl;}
//void Aqq1(int&& x){cout<<"x&& = "<<x<<endl;}
///---------------------------------------------------------------------------
int main(){
    double sum;

    sum = InSum(cin);
        
    cout<<"Suma liczb = "<<sum<<endl;
    int a =7;
    
    Aqq1(a);
    Aqq1(23);
    
    return 0;
    }
///10, 8, 8, 6 ...

