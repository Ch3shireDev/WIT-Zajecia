#include "Vulture.h"

///******************************************************
Vulture::Vulture(string animalName):Animal(animalName){}
///******************************************************
string Vulture::AnimalName(){
    return "Vulture: " + Animal::AnimalName();}
///***********************************************
void Vulture::Kicikici(){cout<<"\nKomu artyleria ... ? ...\n";}
///***********************************************
