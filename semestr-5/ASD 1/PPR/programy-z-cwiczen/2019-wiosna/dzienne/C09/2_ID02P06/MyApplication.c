void ApplicationStart(){
    Main03();
    }
///********************************************
void Main01(){
    int x = MyRead("x? = ");
    printf("x = %d\n",x);
    }
///********************************************
void Main02(){
    FILE* myFile;
    myFile = fopen("KP4_0001.txt","r");
    ///r - read
    ///w - write
    ///a - append
    if(NULL==myFile){
        printf("There is no file: %s\n","KP4_0001.txt");
        return;
        }
    fclose(myFile);
    }
///********************************************
void Main03(){
    FILE* myFile;
    char* fileName = "KP5_0001.txt";
    myFile = fopen(fileName,"r");
    int f;
    char c;
    ///r - read
    ///w - write
    ///a - append
    if(NULL==myFile){
        printf("There is no file: %s\n",fileName);
        return;
        }


    f = fscanf(myFile,"%c",&c);
    while(1==f){
        printf("%c",c);
        f = fscanf(myFile,"%c",&c);
        }



    fclose(myFile);
    }
///********************************************








