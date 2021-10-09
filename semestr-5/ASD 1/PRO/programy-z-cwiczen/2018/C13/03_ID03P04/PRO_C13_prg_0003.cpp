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
///***********************************************************************************************************************************
///***********************************************************************************************************************************
class Person{
    public:
        Person(int, int, int);
        int MmHeight();
        int GWeight();
        int HP();
        virtual string ToString();

        virtual int WeaponId(){return 0;}
        virtual int MP(){return 0;}
        virtual int WandPower(){return 0;}

    private:
        int mmHeight;
        int gWeight;
        int hP;
    };
///***********************************************************************************************************************************
class Knight:virtual public Person{
    public:
        Knight(int, int, int, int);
        int WeaponId();
        string ToString();
    private:
        int weaponId;
    };
///***********************************************************************************************************************************
class Wizard:virtual public Person{
    public:
        Wizard(int, int, int, int, int);
        int MP();
        int WandPower();
        string ToString();
    private:
        int mP;
        int wandPower;
    };
///***********************************************************************************************************************************
class Palladin:public Knight, public Wizard{
    public:
        Palladin(int, int, int, int, int, int);
        string ToString();
    private:

    };
///***********************************************************************************************************************************
///***********************************************************************************************************************************
Person::Person(int mmHeight, int gWeight, int hP):mmHeight(mmHeight), gWeight(gWeight), hP(hP){}
///***********************************************************************************************************************************
int Person::MmHeight(){return mmHeight;}
///***********************************************************************************************************************************
int Person::GWeight(){return gWeight;}
///***********************************************************************************************************************************
int Person::HP(){return hP;}
///***********************************************************************************************************************************
string Person::ToString(){
    string myStr = "Height = ";
    myStr.append(to_string(mmHeight));
    myStr.append(" mm,  Weight = ");
    myStr.append(to_string(gWeight));
    myStr.append(" g,  HP = ");
    myStr.append(to_string(hP));

    return myStr;
    }
///***********************************************************************************************************************************
///***********************************************************************************************************************************
Knight::Knight(int mmHeight, int gWeight, int hP, int weaponId):Person(mmHeight, gWeight, hP), weaponId(weaponId){}
///***********************************************************************************************************************************
int Knight::WeaponId(){return weaponId;}
///***********************************************************************************************************************************
string Knight::ToString(){
    string myStr = Person::ToString();;
    myStr.append(", Weapon ID = ");
    myStr.append(to_string(weaponId));

    return myStr;
    }
///***********************************************************************************************************************************
///***********************************************************************************************************************************
Wizard::Wizard(int mmHeight, int gWeight, int hP, int mP, int wandPower):Person(mmHeight, gWeight, hP), mP(mP), wandPower(wandPower){}
///***********************************************************************************************************************************
int Wizard::MP(){return mP;}
///***********************************************************************************************************************************
int Wizard::WandPower(){return wandPower;}
///***********************************************************************************************************************************
string Wizard::ToString(){
    string myStr = Person::ToString();;
    myStr.append(", MP = ");
    myStr.append(to_string(mP));
    myStr.append(", Power of the wand = ");
    myStr.append(to_string(wandPower));

    return myStr;
    }
///***********************************************************************************************************************************
///***********************************************************************************************************************************
Palladin::Palladin(int mmHeight, int gWeight, int hP, int weaponId, int mP, int wandPower):
                   Person(mmHeight, gWeight, hP),
                   Knight(mmHeight, gWeight, hP,  weaponId),
                   Wizard( mmHeight, gWeight, hP, mP, wandPower)



                   {}
///***********************************************************************************************************************************
string Palladin::ToString(){
    string myStr = Knight::ToString();;
    myStr.append(", MP = ");
    myStr.append(to_string(Wizard::MP()));
    myStr.append(", Power of the wand = ");
    myStr.append(to_string(Wizard::WandPower()));

    return myStr;
    }
///***********************************************************************************************************************************
///***********************************************************************************************************************************
int main(){
    Person* p1 = new Knight(2480000, 65000, 65,4);
    cout<<p1->ToString()<<endl;
    cout<<"Weapon Id = "<<p1->WeaponId()<<endl;

    Person* p2 = new Wizard(2480000, 65000, 65,4, 234);
    cout<<p2->ToString()<<endl;
    cout<<"MP = "<<p2->MP()<<endl;
    cout<<"Power of the wand = "<<p2->WandPower()<<endl;



    return 0;
    }





