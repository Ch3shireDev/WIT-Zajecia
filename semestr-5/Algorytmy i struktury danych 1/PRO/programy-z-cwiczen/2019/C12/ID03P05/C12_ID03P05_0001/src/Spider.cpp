#include "Spider.h"
///******************************************************
Spider::Spider(string animalName):Animal(animalName){
    }
///******************************************************
string Spider::AnimalName(){
    return "Spider: " + Animal::AnimalName();
    }
///******************************************************
void Spider::Aqq(){
    cout<<"It's me, your pet ..."<<endl;
    }
///******************************************************
