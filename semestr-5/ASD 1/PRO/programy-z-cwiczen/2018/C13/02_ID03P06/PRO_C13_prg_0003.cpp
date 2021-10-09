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
        virtual int MP(){return 0;}
        virtual int PowerWand(){return 0;}
        virtual int MmArmour(){return 0;}
    protected:


    private:
        int mmHeight;
        int gWeight;
        int hP;
    };
///*********************************************************************************************************
class Knight:virtual public Person{
    public:
        Knight(int, int, int, int);
        virtual int MmArmour();
        virtual string ToString();
    protected:

    private:
        int mmArmour;

    };
///*********************************************************************************************************
class Wizard:virtual public Person{
    public:
        Wizard(int, int, int, int, int);
        virtual int MP();
        virtual int PowerWand();
        virtual string ToString();
    protected:

    private:
        int mP;
        int powerWand;
    };
///*********************************************************************************************************
class Palladin: public Knight, public Wizard{
    public:
        Palladin(int, int, int, int, int, int);
        virtual string ToString();
    protected:

    private:
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
Wizard::Wizard(int mmHeight, int gWeight, int hP, int mP, int powerWand):
                Person(mmHeight, gWeight, hP),mP(mP),  powerWand(powerWand){}
///*********************************************************************************************************
int Wizard::MP(){return mP;}
///*********************************************************************************************************
int Wizard::PowerWand(){return powerWand;}
///*********************************************************************************************************
string Wizard::ToString(){
    string myStr = Person::ToString();
    myStr.append(", MP = ");
    myStr.append(to_string(mP));
    myStr.append(" Power of the Wand = ");
    myStr.append(to_string(powerWand));

    return myStr;
    }
///*********************************************************************************************************
///*********************************************************************************************************
Palladin::Palladin(int mmHeight, int gWeight, int hP, int mmArmour, int mP, int powerWand):
                Person(mmHeight, gWeight, hP),
                Knight(mmHeight, gWeight, hP, mmArmour), Wizard(mmHeight, gWeight, hP, mP, powerWand)

//                Person(mmHeight, gWeight, hP),mP(mP)
{}
///*********************************************************************************************************
string Palladin::ToString(){
    string myStr = Knight::ToString();
    myStr.append(", MP = ");
    myStr.append(to_string(Wizard::MP()));
    myStr.append(" Power of the Wand = ");
    myStr.append(to_string(Wizard::PowerWand()));

    return myStr;
    }
///*********************************************************************************************************



///*********************************************************************************************************
///*********************************************************************************************************
int main(){
    Person* p1 = new Person(2450000, 150000, 237);
    Person* p2 = new Knight(1540000, 110000, 72, 97);
    Person* p3 = new Wizard(1740000, 19000, 92, 60, 145);

    cout<<"Person p1 : "<<p1->ToString()<<endl;

    cout<<"Height = "<<p1->MmHeight()<<endl;
    cout<<"Weight = "<<p1->GWeight()<<endl;
    cout<<"HP =  = "<<p1->HP()<<endl;


    cout<<"Person p2 : "<<p2->ToString()<<endl;

    cout<<"Armour =  "<<p2->MmArmour()<<endl;
    ///9, 10, 11


    cout<<"Person p3 : "<<p3->ToString()<<endl;

    cout<<"MP =  "<<p3->MP()<<endl;
    cout<<"Power of the Wand =  "<<p3->PowerWand()<<endl;


    return 0;
    }
