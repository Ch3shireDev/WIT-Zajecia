///213.135.46.21:7075
#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;



int main(){
    int t[8];
    int j=0;

    for(int &i:t)i=++j;

    for(int &i:t)cout<<i<<endl;


    cout<<endl<<sizeof(t)/sizeof(int)<<endl;
    return 0;
    }





