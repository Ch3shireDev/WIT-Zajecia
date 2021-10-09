#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main05();
    }
///******************************************************
void Application::Main01(){
    A a(3);
    cout<<a.ToString()<<endl;
    cout<<"A::GetX() = "<<a.GetX()<<endl;
    }
///******************************************************
void Application::Main02(){
    B1 b(3,4);
    cout<<b.ToString()<<endl;
    cout<<"A::GetX() = "<<b.GetX('A')<<endl;
    cout<<"B1::GetX() = "<<b.GetX()<<endl;
    }
///******************************************************
void Application::Main03(){
    C1 c(3, 4, 5);
    cout<<c.ToString()<<endl;
    cout<<"A::GetX() = "<<c.GetX('A')<<endl;
    cout<<"B1::GetX() = "<<c.GetX('B')<<endl;
    cout<<"C1::GetX() = "<<c.GetX()<<endl;
    }
///******************************************************
void Application::Main04(){
    B2 b(3, 4, 5);
    cout<<b.ToString()<<endl;
    cout<<"A::GetX() = "<<b.GetX('A')<<endl;
    cout<<"B2::GetX() = "<<b.GetX()<<endl;
    cout<<"B2::GetY() = "<<b.GetY()<<endl;
    }
///******************************************************
void Application::Main05(){
    C1 c(3, 4, 5);
    cout<<c.ToString()<<endl;
    cout<<"A::GetX() = "<<c.GetX('A')<<endl;
    cout<<"B1::GetX() = "<<c.GetX('B')<<endl;
    cout<<"C1::GetX() = "<<c.GetX()<<endl;
    c.Aqq();
    }
///******************************************************
