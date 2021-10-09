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
    stringstream s1;
    string  myStr;
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 = stringstream(myStr);

    s1>>myStr;
    cout<<myStr<<endl;
    s1>>myStr;
    cout<<myStr<<endl;
    
    s1>>myStr;
    if(s1.fail())cout<<"Koniec"<<endl;
    cout<<myStr<<endl;
    s1>>myStr;
    cout<<myStr<<endl;
    s1>>myStr;
    cout<<myStr<<endl;
    
    
    return 0;
    }

