#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main02();
    }
///******************************************************
void Application::Main01(){
   /* MyA mA;
    mA.Print();*/
    }
///******************************************************
void Application::Main02(){
    MyA11 mA;
    mA.Print();
   // mA.MyA::x = 101;
    //mA.MyA::y = 202;
    cout<<endl;
    cout<<"---------------------"<<endl;
    mA.Print();
    }
///******************************************************
