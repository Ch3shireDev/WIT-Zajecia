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
        virtual string ToString();
        virtual int MmArmour(){return 0;}
    protected:


    private:
        int mmHeight;
        int gWeight;
        int hP;
    };
///*********************************************************************************************************
class Knight: public Person{
    public:
        Knight(int, int, int, int);
        virtual int MmArmour();
        virtual string ToString();
    protected:

    private:
        int mmArmour;

    };
///*********************************************************************************************************
class Wizard: public Person{
    public:
        Wizard(int, int, int, int, int, int);
        virtual int MP();
        virtual int PowerWand();
        virtual string ToString();
    protected:

    private:
        int mP;
        int powerWand;

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
Knight::Knight(int mmHeight, int gWeight, int hP, int mmArmour):
                Person(mmHeight, gWeight, hP), mmArmour(mmArmour){}
///*********************************************************************************************************
int Knight::MmArmour(){return mmArmour;}
///*********************************************************************************************************
string Knight::ToString(){
    string myStr = Person::ToString();
    myStr.append(", Armour = ");
    myStr.append(to_string(mmArmour));
    myStr.append(" mm");

    return myStr;
    }
///*********************************************************************************************************
///*********************************************************************************************************
int main(){
    Person* p1 = new Person(2450000, 150000, 237);
    Person* p2 = new Knight(1540000, 110000, 72, 97);

    cout<<"Person p1 : "<<p1->ToString()<<endl;

    cout<<"Height = "<<p1->MmHeight()<<endl;
    cout<<"Weight = "<<p1->GWeight()<<endl;
    cout<<"HP =  = "<<p1->HP()<<endl;


    cout<<"Person p2 : "<<p2->ToString()<<endl;

    cout<<"Armour =  "<<p2->MmArmour()<<endl;
    ///9, 10, 11


    return 0;
    }
