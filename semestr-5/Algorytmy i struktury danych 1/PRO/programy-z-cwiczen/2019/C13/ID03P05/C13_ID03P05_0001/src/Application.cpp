#include "Application.h"
///******************************************************
void Application::Run(){
    srand(time(0));
    Main05();
    }
///******************************************************
void Application::Main01(){
    A a(5);
    cout<<a.ToString()<<endl;
    cout<<"A::GetX() = "<<a.GetX()<<endl;
    }
///******************************************************
void Application::Main02(){
    B1 b(5, 6);
    cout<<b.ToString()<<endl;
    cout<<"A::GetX() = "<<b.GetX('A')<<endl;
    cout<<"B::GetX() = "<<b.GetX()<<endl;
    }
///******************************************************
void Application::Main03(){
    C1 c(5, 6, 7);
    cout<<c.ToString()<<endl;
    cout<<"A::GetX() = "<<c.GetX('A')<<endl;
    cout<<"B::GetX() = "<<c.GetX('B')<<endl;
    cout<<"C::GetX() = "<<c.GetX()<<endl;
    }
///******************************************************
void Application::Main04(){
    B2 b(5, 6, 7);
    cout<<b.ToString()<<endl;
    cout<<"A::GetX() = "<<b.GetX('A')<<endl;
    cout<<"B::GetX() = "<<b.GetX()<<endl;
    cout<<"B::GetY() = "<<b.GetY()<<endl;
    }
///******************************************************
void Application::Main05(){
    C1 c(5, 6, 7);
    cout<<c.ToString()<<endl;
    cout<<"A::GetX() = "<<c.GetX('A')<<endl;
    cout<<"B::GetX() = "<<c.GetX('B')<<endl;
    cout<<"C::GetX() = "<<c.GetX()<<endl;
    }
///******************************************************
