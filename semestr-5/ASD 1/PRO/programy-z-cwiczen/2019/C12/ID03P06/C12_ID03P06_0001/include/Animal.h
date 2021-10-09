#ifndef ANIMAL_H
#define ANIMAL_H
#include "MyUtility.h"

class Animal
{
    public:
        Animal(string);
        virtual string AnimalName();
        virtual void Kicikici();
    protected:

    private:
        string animalName;
};

#endif // ANIMAL_H
