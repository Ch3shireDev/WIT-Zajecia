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
        virtual string ToString();
        int SEATS();
        int WHEEL();
        int WEIGHT();
        int LENGTH();
        virtual int PEDALS(){return -10;}
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
        int PEDALS();
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
int Bicycle::PEDALS(){return pedalsNo;}
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
    Vehicle ** vehicle;
    int sT = 10;
    vehicle = new Vehicle*[sT];

    for(int i=0; i<sT;++i){
        if(rand()%2==0){
            vehicle[i]= new Bicycle(1,2,10+rand()%20,1+rand()%2,2);
            }
        else{
            vehicle[i]= new Car(5,6, 500+rand()%3000, 4, 6, 60+rand()%600);
            }
        }
    for(int i=0; i<sT;++i)
        cout<<endl<<vehicle[i]->ToString()<<endl;

    Vehicle *v = new Bicycle(1,2,10+rand()%20,1+rand()%2,2);;
    cout<<v->PEDALS()<<endl;

    return 0;
    }
