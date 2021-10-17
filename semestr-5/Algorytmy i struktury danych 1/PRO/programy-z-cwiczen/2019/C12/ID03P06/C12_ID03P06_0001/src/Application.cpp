#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main06();
    }
///******************************************************
void Application::Main01(){
    Animal an01("Ciuciuruciu");
    cout<<an01.AnimalName()<<endl;
    }
///******************************************************
void Application::Main02(){
    Spider an01("Ciuciuruciu");
    cout<<an01.AnimalName()<<endl;
    }
///******************************************************
void Application::Main03(){
    Spider* an01 = new Spider("Ciapciurapciu");
    cout<<an01->AnimalName()<<endl;
    }
///******************************************************
void Application::Main04(){
    Animal* an01 = new Spider("Babla_babla");
    cout<<an01->AnimalName()<<endl;
    an01->Kicikici();
    ((Spider*)an01)->Aqq();
    }
///******************************************************
void Application::Main05(){
    Animal* an01 = new Vulture("Ko_ko_ko");
    cout<<an01->AnimalName()<<endl;
    an01->Kicikici();
    }
///******************************************************
void Application::Main06(){
    unsigned sz = 12;
    Animal** ZOO = new Animal*[sz];
    for(unsigned i=0, v=0, s=0;i<sz;++i)
        if(1==rand()%2) ZOO[i] = new Vulture("Vuvu"+to_string(++v));
        else ZOO[i] = new Spider("Ciaciap"+to_string(++s));
    for(unsigned i=0;i<sz;cout<<ZOO[i]->AnimalName()<<" ",ZOO[i]->Kicikici(),++i);

    }
///******************************************************



















