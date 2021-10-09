void MyApplication::ApplicationRun(){
    MyMain0002();
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

