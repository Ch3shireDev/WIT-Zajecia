int MyRead(string myStr, istream& iS, ostream& oS){
    int x;
    oS<<myStr;
    iS>>x;
    return x;
    }
///*****************************************************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///*****************************************************************************************************
int MyRead(){
    return MyRead("x? = ");
    }
