///**************************************************
void Main01(){
    int x =MyRead("x? = ");
    printf("x = %d\n",x);
    }
///**************************************************
void Main02(){
    FILE* myFile;
    myFile = fopen("KP_0001.txt","r");
    ///r - read
    ///w - write
    ///a - append
    printf("Czytamy ... \n");
    if(NULL==myFile){
        printf("No file: %s","KP_0001.txt");
        return;
        }
    fclose(myFile);
    }
///**************************************************
void Main03(){
    FILE* myFile;
    char* fileName = "KP_0001.txt";
    myFile = fopen(fileName,"r");
    char c;
    int f;
    ///r - read
    ///w - write
    ///a - append
    printf("Czytamy ... \n");
    if(NULL==myFile){
        printf("No file: %s",fileName);
        return;
        }
    f = fscanf(myFile,"%c", &c);
    printf("f = %d\tc= %c\n",f,c);
    fclose(myFile);
    }
///**************************************************
void Main04(){
    FILE* myFile;
    char* fileName = "KP_0001.txt";
    myFile = fopen(fileName,"r");
    char c;
    int i=1;
    int f;
    ///r - read
    ///w - write
    ///a - append
    printf("Czytamy ... \n");
    if(NULL==myFile){
        printf("No file: %s",fileName);
        return;
        }
    f = fscanf(myFile,"%c", &c);
    while(1==f){
        printf("%c",c);
        f = fscanf(myFile,"%c", &c);
     //   if(++i%60==0){printf("\n");i=1;};
        }
    fclose(myFile);
    }







