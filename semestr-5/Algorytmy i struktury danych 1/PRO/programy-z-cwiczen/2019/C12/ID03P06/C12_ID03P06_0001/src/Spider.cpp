#include "Spider.h"
///******************************************************
Spider::Spider(string animalName):Animal(animalName){}
///******************************************************
string Spider::AnimalName(){
    return "Spider: " + Animal::AnimalName();}
///***********************************************
void Spider::Kicikici(){cout<<"\n\tMiauuuuu ...\n";}
///***********************************************
void Spider::Aqq(){cout<<"\n---->>>Aqq\n";}
///***********************************************
