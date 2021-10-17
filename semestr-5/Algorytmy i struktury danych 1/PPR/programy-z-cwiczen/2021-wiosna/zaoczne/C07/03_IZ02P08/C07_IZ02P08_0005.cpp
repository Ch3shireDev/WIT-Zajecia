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
    fstream fileStream, outStream;
    char myStr;
    stringstream ss1;
    
    fileStream.open("Bill_0001.txt",fstream::in);
    outStream.open("Bill_0001_copy.txt",fstream::out);
    
    
    while(fileStream>>std::noskipws>>  myStr)
        outStream<<myStr;
    
    outStream.close();
    fileStream.close();      
    
    outStream.open("Bill_0002_copy.txt",fstream::app);

    outStream<<"Ala ma kota\n";
        
    outStream.close();
    return 0;
    }


