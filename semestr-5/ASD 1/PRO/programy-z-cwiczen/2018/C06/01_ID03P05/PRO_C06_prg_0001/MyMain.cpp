void MyMain::ApplicationRun(){
    MyMain0003();
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
///*********************************************************************
void MyMain::MyMain0003(){
    MyAAA myAAA(MyA(1,2,3),MyA(4,5,6),MyA(7,8,9));
    MyAAA myAA1(myAAA);
    myAA1.SetX2(122,2);


    cout<<myAAA<<endl;
    cout<<myAA1<<endl;


    cout<<"myAAA::X2::X2 = "<<myAAA.GetX2().GetX2()<<endl;

    }










