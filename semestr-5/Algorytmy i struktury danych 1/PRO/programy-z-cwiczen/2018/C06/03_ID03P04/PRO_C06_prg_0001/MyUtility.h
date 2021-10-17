#ifndef MyUtility_H
#define MyUtility_H

#include<iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;

int MyRead(string, istream&, ostream& = cout);
int MyRead(string);
int MyRead();

#include "MyUtility.cpp"

#endif // MyUtility_H
