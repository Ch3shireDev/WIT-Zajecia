///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;

int main(){
    int x;
    double y;
    double * wy;

    cout<<"x? = ";
    cin>>x;
    cout<<"x = "<<x<<endl;

    y=(double)x;
    cout<<"y = "<<y<<endl;

    wy= &y;
    y = y / *wy;

    return 0;
    }
