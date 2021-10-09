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
        string ToString();
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
    Vehicle vC1(12,158,2);
    MonoCycle mC1(10, 0, 2548);
    Cat cC1(124, 13, 43);
    cout<<vC1.ToString()<<endl;
    cout<<mC1.ToString()<<endl;
    cout<<cC1.ToString()<<endl;
    return 0;
    }
