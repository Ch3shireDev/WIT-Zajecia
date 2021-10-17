#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main03();
    }
///******************************************************
void Application::Main01(){
    A a1(4);
    cout<<a1.ToString()<<endl;
    }
///******************************************************
void Application::Main02(){
    B1 b1(4,5);
    cout<<b1.ToString()<<endl;
    cout<<"A::GetX() = "<<b1.GetX('A')<<endl;
    cout<<"B1::GetX() = "<<b1.GetX()<<endl;
    }
///******************************************************
void Application::Main03(){
    C1 c1(4,5,6);
    cout<<c1.ToString()<<endl;
    cout<<"A::GetX() = "<<c1.GetX('A')<<endl;
    cout<<"B1::GetX() = "<<c1.GetX('B')<<endl;
    cout<<"C1::GetX() = "<<c1.GetX('C')<<endl;
    c1.Aqq();
    }
///******************************************************
void Application::Main04(){
    B2 b2(4,5,6);
    cout<<b2.ToString()<<endl;
    cout<<"A::GetX() = "<<b2.GetX('A')<<endl;
    cout<<"B2::GetX() = "<<b2.GetX()<<endl;
    cout<<"B2::GetY() = "<<b2.GetY()<<endl;
    }
///******************************************************
