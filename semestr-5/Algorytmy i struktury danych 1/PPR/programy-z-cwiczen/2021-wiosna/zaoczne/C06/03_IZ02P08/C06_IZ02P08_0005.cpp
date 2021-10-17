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
    double x;
    cout<<str1<<endl;    
    stringstream s1(str1), s2;
    
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    s2 = stringstream(str2);
    s2>>x;
    cout<<"x = "<<x<<endl;
    
    s1>>str2;
    s2 = stringstream(str2);
    s2>>x;
    cout<<"x = "<<x<<endl;
        

    s1>>str2;
    s2 = stringstream(str2);
    s2>>x;
    cout<<"x = "<<x<<endl;


    return 0;
    }

