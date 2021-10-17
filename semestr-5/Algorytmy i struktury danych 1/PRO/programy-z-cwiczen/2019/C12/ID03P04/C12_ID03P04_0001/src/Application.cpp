#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main05();
    }
///******************************************************
void Application::Main01(){
    Animal an01("Kajtek");
    cout<<an01.AnimalName()<<endl;
    }
///******************************************************
void Application::Main02(){
    Cat an01("Mruczek");
    cout<<an01.AnimalName()<<endl;
    }
///******************************************************
void Application::Main03(){
    Animal* an01 = new Cat("Mruczek");
    cout<<an01->AnimalName()<<endl;
    an01->Test();
    }
///******************************************************
void Application::Main04(){
    Animal* an01 = new Dog("Burek");
    cout<<an01->AnimalName()<<endl;
    an01->Test();
    }
///******************************************************
void Application::Main05(){
    unsigned s =10;
    Animal** ZOO = new Animal*[s];
    for(unsigned i =0,c=0,d=0; i<s;++i)
        if(1==rand()%2)
            ZOO[i] = new Cat("Mruczek" + to_string(++c));
        else
            ZOO[i] = new Dog("Burek" + to_string(++d));
    for(unsigned i =0; i<s;++i)
        cout<<ZOO[i]->AnimalName()<<endl;

    }
///******************************************************


















