#ifndef SPIDER_H
#define SPIDER_H
#include "Animal.h"

class Spider:public Animal
{
    public:
        Spider(string);
        virtual string AnimalName();
        virtual void Aqq();
    protected:

    private:
};

#endif // SPIDER_H
