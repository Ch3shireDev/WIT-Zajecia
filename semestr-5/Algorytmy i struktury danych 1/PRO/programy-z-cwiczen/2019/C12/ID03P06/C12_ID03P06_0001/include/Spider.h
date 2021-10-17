#ifndef SPIDER_H
#define SPIDER_H
#include "Animal.h"

class Spider:public Animal{
    public:
        Spider(string animalName);
        virtual string AnimalName();
        virtual void Kicikici();
        void Aqq();
    protected:

    private:
};
#endif // SPIDER_H
