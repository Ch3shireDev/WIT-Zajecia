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

    int sT = 20;
    Vehicle** vC00 = new Vehicle*[sT];

    for(int i=0; i<sT;++i){
        if(rand()%2==1){
            vC00[i] = new Hovercraft(128+rand()%201, 123123+i, 8+rand()%11, 10+rand()%21);
            }
        else{
            vC00[i] = new Tank(20+rand()%20, 3+rand()%3, 42323123+2*i, 120+rand()%11, 100+rand()%101);
            }
        }


    for(int i=0; i<sT;++i)
        cout<<vC00[i]->ToString()<<endl;




    return 0;
    }
