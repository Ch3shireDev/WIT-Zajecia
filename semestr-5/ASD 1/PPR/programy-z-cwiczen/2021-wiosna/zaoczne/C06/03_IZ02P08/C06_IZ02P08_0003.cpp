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
    stringstream s1;
    getline(cin, str1);
        
    cout<<str1<<endl;
    
    
    s1 = stringstream(str1);

    
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    

    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    cout<<"--------------------------------------"<<endl;
    s1>>str2;
    if(s1.fail()) cout<<"Koniec"<<endl;
    cout<<str2<<endl;
    

    return 0;
    }

