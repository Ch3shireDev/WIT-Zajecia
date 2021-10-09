#ifndef CAT_H
#define CAT_H
#include "Animal.h"

class Cat:public Animal{
    public:
        Cat(string);
        virtual string AnimalName();
        virtual void Test();
    protected:

    private:
};

#endif // CAT_H
