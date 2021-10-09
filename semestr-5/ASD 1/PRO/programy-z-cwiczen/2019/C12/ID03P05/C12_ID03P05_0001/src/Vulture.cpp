#include "Vulture.h"
///******************************************************
Vulture::Vulture(string animalName):Animal(animalName){
    }
///******************************************************
string Vulture::AnimalName(){
    return "Vulture: " + Animal::AnimalName();
    }
///******************************************************
void Vulture::Aqq(){
    cout<<"It's me, your vulture ..."<<endl;
    }
///******************************************************
