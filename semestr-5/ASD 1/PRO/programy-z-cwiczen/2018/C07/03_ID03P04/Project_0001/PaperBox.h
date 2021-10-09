#ifndef PaperBox_H
#define PaperBox_H
#include <iostream>
#include "MyUsing.h"
class PaperBox{
    public:
        PaperBox(double, double, double, double=1);

    private:
        double Capacity();
        void   SetCapacity();
        double Weight();
        void   SetWeight();

        double width;
        double height;
        double length;
        double specificWeight;

        double capacity;
        double weight;
friend ostream& operator<<(ostream&, PaperBox&);
    };
#include "PaperBox.cpp"
#endif // PaperBox_H
