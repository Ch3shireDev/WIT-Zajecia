#ifndef DOG_H
#define DOG_H
#include "Animal.h"

class Dog:public Animal
{
    public:
        Dog(string);
        virtual string AnimalName();
        virtual void Test();

    protected:

    private:
};

#endif // DOG_H
