#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main06();
    }
///******************************************************
void Application::Main01(){
    Animal an01("Ciapciap");
    cout<<an01.AnimalName()<<endl;
    }
///******************************************************
void Application::Main02(){
    Vulture an01("Hau_hau");
    cout<<an01.AnimalName()<<endl;
    }
///******************************************************
void Application::Main03(){
    Vulture* an01 = new Vulture("Hau_hau");
    cout<<an01->AnimalName()<<endl;
    }
///******************************************************
void Application::Main04(){
    Animal* an01 = new Vulture("Hau_hau");
    cout<<an01->AnimalName()<<endl;
    an01->Aqq();
    }
///******************************************************
void Application::Main05(){
    Animal* an01 = new Spider("Miau");
    cout<<an01->AnimalName()<<endl;
    an01->Aqq();
    }
///******************************************************
void Application::Main06(){
    unsigned s =12;
    Animal** KinderGarden = new Animal*[s];
    for(unsigned i=0,v=0,sp=0; i<s;++i)
        if(1==rand()%2) KinderGarden[i] = new Vulture("Hau: "+to_string(++v));
        else KinderGarden[i] = new Spider("Koko: "+to_string(++sp));
    for(unsigned i=0; i<s;++i)
        cout<<KinderGarden[i]->AnimalName()<<endl;

    }
///******************************************************













