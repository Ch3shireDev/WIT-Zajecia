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
    string myStr;
   char z;
    
    while(fileStream>>std::noskipws>>z) cout<<z;
   
    
    fileStream.close();
    return 0;
    }
///25, 25, 20, 20, 20, 15...

