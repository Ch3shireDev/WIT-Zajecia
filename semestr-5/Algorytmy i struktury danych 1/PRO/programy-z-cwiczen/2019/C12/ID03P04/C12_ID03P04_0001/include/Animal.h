#ifndef ANIMAL_H
#define ANIMAL_H
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;

class Animal
{
    public:
        Animal(string);
        virtual string AnimalName();
        virtual void Test();
    protected:

    private:
        string animalName;
};

#endif // ANIMAL_H
