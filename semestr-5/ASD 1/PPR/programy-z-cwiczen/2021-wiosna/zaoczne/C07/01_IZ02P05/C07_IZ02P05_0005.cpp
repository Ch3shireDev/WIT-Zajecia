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
    fstream fileStream, fileOut;
    fileStream.open("Bill_0001.txt", fstream::in);
    fileOut.open("Bill_0001_copy.txt", fstream::out);
    char z;
    
    while( fileStream>>std::noskipws>>z){
        fileOut<<z;
        }
   
    fileOut.close();
    fileStream.close();
    fileOut.open("Bill_0001_copy.txt", fstream::app);
    fileOut<<"\nAla ma kota\n\n";
    fileOut.close();
    return 0;
    }


