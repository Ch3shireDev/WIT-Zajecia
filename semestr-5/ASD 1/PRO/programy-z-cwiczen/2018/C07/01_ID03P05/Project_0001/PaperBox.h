#ifndef PaperBox_H
#define PaperBox_H
#include <iostream>
#include "MyUsing.h"
class PaperBox{
    public:
        PaperBox(double, double, double, double=1);

    private:
        double Capacity();
        void SetCapacity();
        double Weigth();
        void SetWeigth();

        double width;
        double height;
        double length;
        double specificWeigth;

        double capacity;
        double weigth;
friend ostream& operator<<(ostream&, PaperBox&);
    };



#include "PaperBox.cpp"
#endif // PaperBox_H
