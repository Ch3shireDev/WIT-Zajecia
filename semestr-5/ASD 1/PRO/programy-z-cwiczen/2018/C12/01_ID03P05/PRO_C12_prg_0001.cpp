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
        Vehicle(int seatsNo,
                int wheelNo,
                int weigthVe,
                int lengthVe);
        string ToString();
        int SEATS();
        int WHEEL();
        int WEIGHT();
        int LENGTH();
        string TYPE();
    protected:
        string veType;
    private:
        int seatsNo;
        int wheelNo;
        int weightVe;
        int lengthVe;
    };
///********************************************************************
class Bicycle: public Vehicle{
    public:
        Bicycle(int seatsNo,
                int wheelNo,
                int weigthVe,
                int lengthVe,
                int pedalsNo);
        string ToString();
    private:
        int pedalsNo;
    };
///********************************************************************
///********************************************************************
Vehicle::Vehicle(int seatsNo,
                 int wheelNo,
                 int weightVe,
                 int lengthVe):seatsNo(seatsNo),
                              wheelNo(wheelNo),
                              weightVe(weightVe),
                              lengthVe(lengthVe)
                 {veType = "Vehicle";}
///********************************************************************
///********************************************************************
class Car: public Vehicle{
    public:
        Car(int seatsNo,
                int wheelNo,
                int weigthVe,
                int lengthVe,
                int gearsNo,
                int powerEng);
        string ToString();

    private:
        int gearsNo;
        int powerEng;
    };
///********************************************************************
///********************************************************************
string Vehicle::ToString(){
    string myStr = veType;

    myStr.append(":: Seats No: ");
    myStr.append(to_string(seatsNo));

    myStr.append(", Wheel No: ");
    myStr.append(to_string(wheelNo));

    myStr.append(", Weight: ");
    myStr.append(to_string(weightVe));

    myStr.append(", Length: ");
    myStr.append(to_string(lengthVe));

    return myStr;
    }
///********************************************************************
int Vehicle::SEATS() {return seatsNo;}
///********************************************************************
int Vehicle::WHEEL() {return wheelNo;}
///********************************************************************
int Vehicle::WEIGHT(){return weightVe;}
///********************************************************************
int Vehicle::LENGTH(){return lengthVe;}
///********************************************************************
string Vehicle::TYPE(){return veType;}
///********************************************************************
///********************************************************************
Bicycle::Bicycle(int seatsNo,
                 int wheelNo,
                 int weightVe,
                 int lengthVe,
                 int pedalsNo):Vehicle(seatsNo,
                                       wheelNo,
                                       weightVe,
                                       lengthVe),
                                pedalsNo(pedalsNo)
                 {veType = "Bicycle";}
///********************************************************************
string Bicycle::ToString(){
    string myStr = Vehicle::ToString().append(", Pedals No: ");
    myStr.append(to_string(pedalsNo));
    return myStr;
    }
///********************************************************************
///********************************************************************
Car::Car(int seatsNo,
                 int wheelNo,
                 int weightVe,
                 int lengthVe,
                 int gearsNo,
                 int powerEng):Vehicle(seatsNo,
                                       wheelNo,
                                       weightVe,
                                       lengthVe),
                                gearsNo(gearsNo),
                                powerEng(powerEng)
                 {veType = "Car";}
///********************************************************************
string Car::ToString(){
    string myStr = Vehicle::ToString().append(", Gears No: ");
    myStr.append(to_string(gearsNo));
    myStr.append(", Power of Engine: ");
    myStr.append(to_string(powerEng));
    return myStr;
    }


///********************************************************************
int main(){
    srand(time(NULL));
    Bicycle bicycle(1,2,10,3,48);
    Car car(5,6, 1500, 4, 6, 320);
    cout<<endl<<bicycle.ToString()<<endl;
    cout<<endl<<car.ToString()<<endl;
    return 0;
    }
