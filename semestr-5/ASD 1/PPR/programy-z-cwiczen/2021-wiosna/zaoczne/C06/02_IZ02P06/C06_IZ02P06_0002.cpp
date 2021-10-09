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
    stringstream s1;
    
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 = stringstream(myStr);
    
    s1>>str;
    cout<<"---------------------------------"<<endl;
    cout<<str<<endl;
    
    s1>>str;
    cout<<"---------------------------------"<<endl;
    cout<<str<<endl;
    
    s1>>str;
    cout<<"---------------------------------"<<endl;
    cout<<str<<endl;

    s1>>str;
    cout<<"---------------------------------"<<endl;
    cout<<str<<endl;

    s1>>str;
    cout<<"---------------------------------"<<endl;
    cout<<str<<endl;
    
    return 0;
    }

