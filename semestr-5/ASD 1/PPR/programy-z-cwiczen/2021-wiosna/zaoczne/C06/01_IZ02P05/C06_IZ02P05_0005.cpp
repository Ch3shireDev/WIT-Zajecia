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
    double x;
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 <<myStr;
    
    s1>>myStr;

    s2 = stringstream(myStr);
    s2>>x;
    if(!s2.fail())
        cout<<"Liczba = "<<x<<endl;
    
    
        
    return 0;
    }

///23, 23, 18, 18, 18, 10 ...
