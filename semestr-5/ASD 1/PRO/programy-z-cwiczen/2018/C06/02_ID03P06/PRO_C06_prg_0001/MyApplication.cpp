void MyApplication::ApplicationRun(){
    MyMain0005();
    }
///****************************************************************************************
void MyApplication::MyMain0001(){
    MyA myA(1,2,3);
    MyA myB(10,20,30);
    cin>>myB;
    cout<<myB<<endl;
    }
///****************************************************************************************
void MyApplication::MyMain0002(){
    MyBox myBox(MyA(1,2,3),MyA(4,5,6), MyA(7,8,9));
    MyBox myBox1;
    }
///****************************************************************************************
void MyApplication::MyMain0003(){
    int x =2;
                                                    /// 00000010
                                                    /// 00100000
    x=x<<4; /// <=> x = x * 2^4
    cout<<x<<endl;

    }
///****************************************************************************************
void MyApplication::MyMain0004(){
    MyBox myBox(MyA(1,2,3),MyA(4,5,6), MyA(7,8,9));
    cout<<myBox<<endl;
    myBox.SetX2(122,2);
    cout<<myBox<<endl;
    }
///****************************************************************************************
void MyApplication::MyMain0005(){
    MyBox myBox;
    cin>>myBox;
    cout<<myBox<<endl;
    }


