#ifndef VULTURE_H
#define VULTURE_H
#include "Animal.h"

class Vulture:public Animal
{
    public:
        Vulture(string);
        virtual string AnimalName();
        virtual void Aqq();
    protected:

    private:
};
///4, 3, 2, 1
#endif // VULTURE_H
