int MyRead(){
    return MyRead("x? = ");
    }
///********************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///********************************************************
int MyRead(string myStr, istream& s){
    int x;
    cout<<myStr;
    s>>x;
    return x;
    }

