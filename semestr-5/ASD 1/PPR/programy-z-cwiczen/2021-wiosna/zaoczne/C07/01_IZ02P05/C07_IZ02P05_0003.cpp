#include <fstream>
#include <iostream>
#include <sstream>
#include <string>
#include <vector>
#include <iomanip>
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
    fileStream.open("Bill_0001.txt", fstream::in);
    string myStr, myLine;
    stringstream ss1;
    
    while( getline(fileStream, myLine)){
        ss1=stringstream("");
        ss1<<myLine;
        double x;
        while(ss1>>myStr){
            if(stringstream(myStr)>>x)cout<<x<<" ";
            }        
        cout<<endl;
        }
   
    
    fileStream.close();
    return 0;
    }
///35, 30, 30, 25, 25, 25, 20, 20, 20, 20, 15...

