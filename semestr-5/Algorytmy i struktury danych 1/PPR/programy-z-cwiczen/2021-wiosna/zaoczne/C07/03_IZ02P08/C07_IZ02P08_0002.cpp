#include <fstream>
#include <iostream>
#include <sstream>
#include <string>
#include <vector>
#include <iomanip>
#include <fstream>
///Linux ctrl + d
///Windows ctrl + z potem ENTER
using std::istringstream;
using std::stringstream;
using std::string;
using std::getline;
using std::cin;
using std::cout;
using std::endl;
using std::vector;
using std::setw;
using std::istream;
using std::fstream;

///---------------------------------------------------------------------------
///---------------------------------------------------------------------------
///---------------------------------------------------------------------------
int main(){
    fstream fileStream;
    string myStr;
    
    fileStream.open("Bill_0001.txt",fstream::in);
    
    
    while(fileStream>>myStr) cout<<myStr<<endl;
    
    
    fileStream.close();    
    
    
    //freopen("Bill_0001.txt", "rb", stdin);    string mySTR;    while(getline(cin, mySTR))        cout << mySTR << endl; 
    
    return 0;
    }
///25, 20, 20, 20, 15 ...

