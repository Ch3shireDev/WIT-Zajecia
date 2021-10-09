///*************************************************************************************
MyAAA::MyAAA(MyA x2, MyA x1, MyA x0){
    MyAAAIni(x2,x1,x0);
    }
///*************************************************************************************
MyAAA::MyAAA(const MyAAA& myAAA){
    this->x2 = myAAA.x2;
    this->x1 = myAAA.x1;
    this->x0 = myAAA.x0;
    SetCrC();
    }
///*************************************************************************************
MyAAA MyAAA::MyAAAIni(MyA x2, MyA x1, MyA x0){
    this->x2 = x2;
    this->x1 = x1;
    this->x0 = x0;

    SetCrC();
    return *this;
    }
///*************************************************************************************
int MyAAA::CrC(){
    return 64*x2.GetCrC()+ 8*x1.GetCrC()+ x0.GetCrC();
    }
///*************************************************************************************
int MyAAA::SetCrC(){
    cRc = CrC();

    return cRc;
    }
///********************************************************
MyA& MyAAA::GetX2(){return x2;}
///********************************************************
MyA& MyAAA::GetX1(){return x1;}
///********************************************************
MyA& MyAAA::GetX0(){return x0;}
///********************************************************
int MyAAA::GetCrC(){return cRc;}
///********************************************************
MyA& MyAAA::SetX2(int x, int i){
    if(i==2) x2.SetX2(x);
    if(i==1) x2.SetX1(x);
    if(i==0) x2.SetX0(x);
    SetCrC();

    return x2;
    }
///********************************************************
MyA& MyAAA::SetX1(int x, int i){
    if(i==2) x1.SetX2(x);
    if(i==1) x1.SetX1(x);
    if(i==0) x1.SetX0(x);
    SetCrC();

    return x1;
    }
///********************************************************
MyA& MyAAA::SetX0(int x, int i){
    if(i==2) x0.SetX2(x);
    if(i==1) x0.SetX1(x);
    if(i==0) x0.SetX0(x);
    SetCrC();

    return x0;
    }
///*************************************************************************************
ostream& operator<<(ostream& s, MyAAA& myAAA){
    s<<"( "<<myAAA.GetX2()<<", "<<myAAA.GetX1()<<", ";
    s<<myAAA.GetX0()<<") -> "<<myAAA.GetCrC()<<endl;
    return s;
    }
