void MyMain::ApplicationRun(){
    MyMain0002();
    }
///*********************************************************************
void MyMain::MyMain0001(){
    MyA myA(1,2,3);
    MyA myB(10,20,30);
    MyA myC;
    MyA myD(myA);
    myC = myA + myB;
    myC.MyAPrint();

    myC = myC + 5;
    myC.MyAPrint();
    myC = 5 + myC;
    myC.MyAPrint();
    ++myC;
    myC.MyAPrint();
    myD.MyAPrint();
    myC = myD++;
    myC.MyAPrint();
    myD.MyAPrint();
    }
///*********************************************************************
void MyMain::MyMain0002(){
    MyA myA(1,2,3);
    MyA myB(10,20,30);

    cin>>myA;
    cout<<myA<<endl;

    }
