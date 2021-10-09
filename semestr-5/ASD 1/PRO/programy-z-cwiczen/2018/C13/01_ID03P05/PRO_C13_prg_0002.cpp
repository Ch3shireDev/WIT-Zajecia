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

        virtual int MmArmour(){return 0;}
        virtual int MP(){return 0;}
        virtual int PowerWand(){return 0;}
        virtual string ToString();
    protected:

    private:
        int mmHeight;
        int gWeight;
        int hP;
    };
///*********************************************************************************************************
class Knight:public Person{
    public:
        Knight(int, int, int, int);
        virtual int MmArmour();
        virtual string ToString();
    protected:

    private:
        int mmArmour;
    };
///*********************************************************************************************************
class Wizard:public Person{
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
    string myStr="Height = ";
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
    string myStr=Person::ToString();
    myStr.append(", Armour = ");
    myStr.append(to_string(mmArmour));
    myStr.append(" mm");

    return myStr;
    }
///*********************************************************************************************************
///*********************************************************************************************************
Wizard::Wizard(int mmHeight, int gWeight, int hP, int mP, int powerWand):
    Person(mmHeight, gWeight, hP), mP(mP), powerWand(powerWand){}
///*********************************************************************************************************
int Wizard::MP(){return mP;}
///*********************************************************************************************************
int Wizard::PowerWand(){return powerWand;}
///*********************************************************************************************************
string Wizard::ToString(){
    string myStr=Person::ToString();
    myStr.append(", MP = ");
    myStr.append(to_string(mP));
    myStr.append(" mm, Power of the Wand = ");
    myStr.append(to_string(powerWand));

    return myStr;
    }
///*********************************************************************************************************
///*********************************************************************************************************
int main(){
    Person* person;
    Person* wizard;
    person = new Knight(1920, 120000, 245, 120);
    wizard = new Wizard(1200, 140000, 80, 190, 30);
    cout<<person->ToString()<<endl;
    cout<<"Armour = "<<person->MmArmour()<<" mm"<<endl;
    cout<<wizard->ToString()<<endl;
    cout<<"MP = "<<wizard->MP()<<endl;
    cout<<"Power of the wand = "<<wizard->PowerWand()<<endl;
    return 0;
    }
