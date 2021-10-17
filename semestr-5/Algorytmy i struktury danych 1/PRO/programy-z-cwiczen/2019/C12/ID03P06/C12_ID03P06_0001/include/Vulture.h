#ifndef VULTURE_H
#define VULTURE_H
#include "Animal.h"

class Vulture:public Animal{
    public:
        Vulture(string animalName);
        virtual string AnimalName();
        virtual void Kicikici();
    protected:

    private:
};

#endif // VULTURE_H
