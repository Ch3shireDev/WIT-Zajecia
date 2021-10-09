#include<iostream>
#include<cstdlib>
#include<ctime>
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::to_string;
using std::ostream;
using std::istream;
///*********************************************************************************************************
///*********************************************************************************************************
class Person{
    public:
        Person(int, int, int);
        int MmHeight();
        int GWeight();
        int HP();
        string ToString();
    protected:


    private:
        int mmHeight;
        int gWeight;
        int hP;
    };
///*********************************************************************************************************
class Knight{
    public:
        Knight(int, int, int, int);
        int MmArmour();
        string ToString();
    protected:


    private:
        int mmArmour;

    };
///*********************************************************************************************************
///*********************************************************************************************************
Person::Person(int mmHeight, int gWeight, int hP):mmHeight(mmHeight), gWeight(gWeight), hP(hP){}
///*********************************************************************************************************
int Person::MmHeight(){return mmHeight;}
///*********************************************************************************************************
int Person::GWeight(){return gWeight;}
///*********************************************************************************************************
int Person::HP(){return hP;}
///*********************************************************************************************************
string Person::ToString(){
    string myStr = "Height = ";
    myStr.append(to_string(mmHeight));
    myStr.append(" mm, Weight = ");
    myStr.append(to_string(gWeight));
    myStr.append(" g, HP = ");
    myStr.append(to_string(hP));

    return myStr;
    }
///*********************************************************************************************************
///*********************************************************************************************************
int main(){
    Person* p1 = new Person(2450000, 150000, 237);

    cout<<"Person p1:"<<p1->ToString()<<endl;

    cout<<"Height = "<<p1->MmHeight()<<endl;
    cout<<"Weight = "<<p1->GWeight()<<endl;
    cout<<"HP =  = "<<p1->HP()<<endl;

    return 0;
    }
