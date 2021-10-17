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
///********************************************************************
///********************************************************************
class Vehicle{
    public:
        Vehicle(int, int, int);

        int WHEEL();
        int SEATS();
        int VIN();
        virtual string ToString();
    protected:
        string type;
    private:
        int wheelNo;
        int seatsNo;
        int vin;
    };
///********************************************************************
///********************************************************************
class Tank:public Vehicle{
    public:
        Tank(int, int, int, int, int);
        string ToString();
    protected:

    private:
        int gunCal;
        int armorThick;
    };
///********************************************************************
///********************************************************************
class Hovercraft: public Vehicle{
    public:
        Hovercraft(int, int, int, int);
        string ToString();
    protected:

    private:
        int propellerNo;
        int crewNo;
    };
///********************************************************************
///********************************************************************
Vehicle::Vehicle(int wheelNo,
                 int seatsNo,
                 int vin):
                     wheelNo(wheelNo),
                     seatsNo(seatsNo),
                     vin(vin)
                 {type = "Vehicle"; }
///********************************************************************
int Vehicle::WHEEL(){return wheelNo;}
int Vehicle::SEATS(){return seatsNo;}
int Vehicle::VIN(){return vin;}
///********************************************************************
string Vehicle::ToString(){
    string myStr = type;

    myStr.append(":: Wheel No: ");
    myStr.append(to_string(wheelNo));

    myStr.append(", Seats No: ");
    myStr.append(to_string(seatsNo));

    myStr.append(", VIN: ");
    myStr.append(to_string(vin));

    return myStr;
    }
///********************************************************************
///********************************************************************
Tank::Tank(int wheelNo,
           int seatsNo,
           int vin,
           int gunCal,
           int armorThick):
                     Vehicle(wheelNo,
                             seatsNo,
                                 vin),
                     gunCal(gunCal),
                     armorThick(armorThick)
                 {type = "Tank"; }
///********************************************************************
string Tank::ToString(){
    string myStr = Vehicle::ToString().append(", caliber of gun: ");
    myStr.append(to_string(gunCal));
    myStr.append(", armour's thick: ");
    myStr.append(to_string(armorThick));

    return myStr;
    }
///********************************************************************
///********************************************************************
Hovercraft::Hovercraft(int seatsNo,
                       int vin,
                       int propellerNo,
                       int crewNo):
                            Vehicle(0,
                                    seatsNo,
                                    vin),
                            propellerNo(propellerNo),
                            crewNo(crewNo)
                 {type = "Hovercraft"; }
///********************************************************************
string Hovercraft::ToString(){
    string myStr = Vehicle::ToString().append(", Propellers No: ");
    myStr.append(to_string(propellerNo));
    myStr.append(", Crew No: ");
    myStr.append(to_string(crewNo));

    return myStr;
    }
///********************************************************************
///********************************************************************
int main(){
    srand(time(NULL));
    Hovercraft* vC01 = new  Hovercraft(128, 123123, 8, 10);
    Tank* vC02 = new Tank(30, 5, 123123, 120, 200);
    Vehicle* vC00;

    cout<<vC01->ToString()<<endl;
    cout<<vC02->ToString()<<endl;
    cout<<endl<<"********************************************"<<endl<<endl;
    vC00 = vC01;
    cout<<vC00->ToString()<<endl;
    vC00 = vC02;
    cout<<vC00->ToString()<<endl;




    return 0;
    }
