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
    stringstream s1, s2;
    double x;
    
    getline(cin, myStr);
    cout<<myStr<<endl;

    s1 = stringstream(myStr);
    
    s1>>str;
    while(!s1.fail()){
        cout<<"---------------------------------"<<endl;
        cout<<str<<endl;
        s2 = stringstream(str);
        cout<<"---------------------------------"<<endl;
        
        s2>>x;
        if(!s2.fail()){
            cout<<"x = "<<x<<endl;
            cout<<"---------------------------------"<<endl;
            }
        
        s1>>str;
        }
    
    
    return 0;
    }
///26, 23, 23, 18, 18, 18, 10 ...
