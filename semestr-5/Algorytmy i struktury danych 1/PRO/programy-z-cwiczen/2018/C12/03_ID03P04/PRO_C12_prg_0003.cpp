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
        virtual string ToString();
        int WHEEL();
        int SEATS();
        int WEIGHT();

    protected:
        string type;
    private:
        int wheelNo;
        int seatsNo;
        int weightVe;
    };
///********************************************************************
///********************************************************************
class MonoCycle: public Vehicle{
    public:
        MonoCycle(int, int, int);
        string ToString();

    protected:

    private:
        int pedalsNo;
        int spokesNo;
    };
///********************************************************************
///********************************************************************
class Cat: public Vehicle{
    public:
        Cat(int, int, int);
        string ToString();
    protected:

    private:
        int tailsNo;
        int wipersNo;
    };
///********************************************************************
///********************************************************************
Vehicle::Vehicle(int wheelNo,
                 int seatsNo,
                 int weightVe):
                        wheelNo(wheelNo),
                        seatsNo(seatsNo),
                        weightVe(weightVe)
    {type = "Vehicle";}
///********************************************************************
///********************************************************************
string Vehicle::ToString(){
    string myStr = type;

    myStr.append(":: Wheels No: ");
    myStr.append(to_string(wheelNo));

    myStr.append(", Seats No: ");
    myStr.append(to_string(seatsNo));

    myStr.append(", Weight: ");
    myStr.append(to_string(weightVe));

    return myStr;
    }
///********************************************************************
int Vehicle::WHEEL(){return wheelNo;}
int Vehicle::SEATS(){return seatsNo;}
int Vehicle::WEIGHT(){return weightVe;}
///********************************************************************
///********************************************************************
MonoCycle::MonoCycle(int weightVe,
                     int pedalsNo,
                     int spokesNo):
                        Vehicle(1,1,weightVe),
                        pedalsNo(pedalsNo),
                        spokesNo(spokesNo)
                {type = "MonoCycle";}
///********************************************************************
string MonoCycle::ToString(){
    string myStr = Vehicle::ToString().append(", Pedals No: ");

    myStr.append(to_string(pedalsNo));

    myStr.append(", Spokes No: ");
    myStr.append(to_string(spokesNo));

    return myStr;
    }
///********************************************************************
///********************************************************************
Cat::Cat(int weightVe,
         int tailsNo,
         int wipersNo):
             Vehicle(8, 2, weightVe),
             tailsNo(tailsNo),
             wipersNo(wipersNo)
             {type = "UniCat";}
///********************************************************************
string Cat::ToString(){
    string myStr = Vehicle::ToString().append(", Tails No: ");

    myStr.append(to_string(tailsNo));

    myStr.append(", Wipers No: ");
    myStr.append(to_string(wipersNo));

    return myStr;
    }
///********************************************************************
///********************************************************************
int main(){
    srand(time(NULL));
    int sT = 13;
    Vehicle** v = new Vehicle*[sT];

    for(int i = 0; i<sT;++i){
        if(rand()%2==1){
            v[i] = new MonoCycle(5+rand()%11, 0+rand()%6, 548+rand()%1100);
            }
        else{
            v[i] = new Cat(50+rand()%2348, 2+rand()%24, 3+rand()%47);
            }
        }

    for(int i = 0; i<sT;++i)
        cout<<v[i]->ToString()<<endl;

    return 0;
    }
