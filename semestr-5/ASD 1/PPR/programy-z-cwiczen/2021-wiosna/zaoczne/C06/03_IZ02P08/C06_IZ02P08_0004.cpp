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
    cout<<str1<<endl;    
    stringstream s1(str1);
    
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    while(!s1.fail()) {    
        cout<<str2<<endl;
        s1>>str2;
        }
    cout<<"--------------------------------------"<<endl;
    
    return 0;
    }

