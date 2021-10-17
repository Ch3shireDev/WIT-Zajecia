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
    
    fileStream.open("Matrix_0001.txt", fstream::in);
    size_t sT;
    fileStream>>sT;
    vector<int>  myT(sT);
    for(size_t i =0; i< myT.size();++i) fileStream>>myT[i];    
    
    fileStream.close();          
    
    for(size_t i =0; i< myT.size();++i) cout<<myT[i]<<endl;    
    
    
    return 0;
    }


