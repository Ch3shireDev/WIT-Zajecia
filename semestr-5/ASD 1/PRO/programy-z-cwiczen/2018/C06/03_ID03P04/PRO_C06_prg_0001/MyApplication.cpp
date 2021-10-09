void MyApplication::ApplicationRun(){
    MyMain0002();
    cout<<"\tR. I. P."<<endl;
    }
///*****************************************************************************************************
void MyApplication::MyMain0001(){
    MyA myB(1,2,3);

    cout<<myB<<endl;
    cin>>myB;
    cout<<myB<<endl;

    }
///*****************************************************************************************************
void MyApplication::MyMain0002(){
    MyBox myBox(MyA(1,2,3),MyA(4,5,6),MyA(7,8,9));
    cin>>myBox;
    cout<<myBox<<endl;
    }


