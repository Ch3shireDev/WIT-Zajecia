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

    s1 <<myStr;
    s1<<" ";
    s1<<myStr;

    s1>>myStr;
    cout<<myStr<<endl;
    s1>>myStr;
    cout<<myStr<<endl;
    
    s1>>myStr;
    if(s1.fail())cout<<"Koniec"<<endl;
    else{
        cout<<myStr<<endl;
        s1>>myStr;
        cout<<myStr<<endl;
        s1>>myStr;
        cout<<myStr<<endl;
        }
    
    return 0;
    }

///10, 8, 8, 6, 6, 6, 5 ...
