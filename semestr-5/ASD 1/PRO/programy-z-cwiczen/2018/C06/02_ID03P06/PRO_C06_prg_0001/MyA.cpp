MyA::MyA(int x2, int x1, int x0): x2(x2), x1(x1),x0(x0){
            SetCrC();
            }
///****************************************************************************************
MyA::MyA(const MyA& myA){
    MyAIni(myA.x2, myA.x1, myA.x0);
    }
///****************************************************************************************
MyA& MyA::MyAIni(int x2, int x1, int x0){
            this->x2 = x2;
            this->x1 = x1;
            this->x0 = x0;
            SetCrC();
            return *this;
            }
///****************************************************************************************
MyA& MyA::MyAPrint(){
    cout<<"x2 = "<<x2<<", x1 = "<<x1<<", x0 = "<<x0<<", CRC = "<<cRc<<endl;
    return *this;
    }
///****************************************************************************************
int MyA::CrC(){
    return 4*(x2%2)+2*(x1%2)+x0%2;
    }
///****************************************************************************************
int MyA::SetCrC(){
    cRc = CrC();
    return cRc;
    }
///****************************************************************************************
int MyA::GetX2(){return x2;}
int MyA::GetX1(){return x1;}
int MyA::GetX0(){return x0;}
int MyA::GetCrC(){return cRc;}
///****************************************************************************************
int MyA::SetX2(int x2){
    int x=this->x2;
    this->x2 = x2;
    SetCrC();
    return x;
    }
///****************************************************************************************
int MyA::SetX1(int x1){
    int x=this->x1;
    this->x1 = x1;
    SetCrC();
    return x;
    }
///****************************************************************************************
int MyA::SetX0(int x0){
    int x=this->x0;
    this->x0 = x0;
    SetCrC();
    return x;
    }
///****************************************************************************************
MyA MyA::MyAAdd(const MyA& myA)const{
    return MyA(x2+myA.x2, x1+myA.x1, x0+myA.x0);
    }
///****************************************************************************************
MyA MyA::operator+(const MyA& myA)const{
    return MyA(x2+myA.x2, x1+myA.x1, x0+myA.x0);
    }
///****************************************************************************************
MyA MyA::operator+(int x)const{
    return MyA(x2+x, x1+x, x0+x);
    }
///****************************************************************************************
MyA& MyA::operator++(){
    ++x2;
    ++x1;
    ++x0;
    SetCrC();
    return *this;
    }
///****************************************************************************************
MyA MyA::operator++(int){
    MyA myA(*this);
    ++(*this);
    return myA;
    }
///****************************************************************************************
///****************************************************************************************
MyA operator+(int x, const MyA& myA){
    return myA + x;
    }
///****************************************************************************************
ostream& operator<<(ostream& s, MyA myA){
    s<<"("<<myA.GetX2()<<", "<<myA.GetX1();
    s<<", "<<myA.GetX0()<<") -> "<<myA.GetCrC();
    return s;
    }
///****************************************************************************************
istream& operator>>(istream& s, MyA& myA){
    myA.SetX2(MyRead("x2? = ",s));
    myA.SetX1(MyRead("x1? = ",s));
    myA.SetX0(MyRead("x0? = ",s));
    return s;
    }
