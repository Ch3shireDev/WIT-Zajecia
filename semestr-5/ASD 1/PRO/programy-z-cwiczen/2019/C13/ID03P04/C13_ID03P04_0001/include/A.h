#ifndef A_H
#define A_H
#include<iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;

class A{
    public:
        A(int);
        string ToString();
        int GetX();
        void Aqq();
    private:
        int x;
};
#endif // A_H
