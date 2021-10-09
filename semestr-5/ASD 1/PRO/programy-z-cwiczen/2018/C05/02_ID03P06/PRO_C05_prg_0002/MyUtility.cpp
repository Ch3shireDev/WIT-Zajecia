int MyRead(string myStr, istream& is, ostream& os){
    int x;
    os<<myStr;
    is>>x;
    return x;
    }
///****************************************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///****************************************************************************************
int MyRead(){return MyRead("x? = ");}
