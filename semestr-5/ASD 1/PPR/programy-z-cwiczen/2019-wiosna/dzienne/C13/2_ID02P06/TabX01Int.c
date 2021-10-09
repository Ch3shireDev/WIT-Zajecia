///********************************************************
///********************************************************
TabX01Int TabX01IntNew(int sT){
    TabX01Int myT;
    if(sT<1){
        myT.pT=NULL;
        myT.sT=0;
        }
    else{
        myT.pT=(int*)malloc(sizeof(int)*sT);
        myT.sT=sT;
        }
    return myT;
    }
///********************************************************
TabX01Int TabX01IntDelete(TabX01Int* myT){
    if(NULL!=myT->pT)
        free(myT->pT);
    myT->pT = NULL;
    myT->sT = 0;
    return *myT;
    }
///********************************************************
TabX01Int TabX01IntRand(TabX01Int myT, int a, int b){
    for(int i=0; i<myT.sT;++i)
        myT.pT[i]=rand()%(b-a)+1+a;
    return myT;
    }
///********************************************************
TabX01Int TabX01IntPrint(TabX01Int myT, int s){
    for(int i=0; i<myT.sT;++i)
        printf("[%*d]",s,myT.pT[i]);
    return myT;
    }
///********************************************************
TabX01Int TabX01IntLoad(char* name){
    FILE * myFile;
    TabX01Int myT;

    myFile = fopen(name,"r");
    if(NULL==myFile){
        printf("load error file: %s\n",name);
        myT.sT=0;
        myT.pT=NULL;
        return myT;
        }
    fscanf(myFile,"%d", &myT.sT);
    myT = TabX01IntNew(myT.sT);

    for(int i=0; i<myT.sT;++i)
        fscanf(myFile,"%d",&myT.pT[i]);

    fclose(myFile);
    return myT;
    }
///********************************************************
TabX01Int TabX01IntSave(TabX01Int myT, char* name){
    FILE * myFile;
    myFile = fopen(name,"w");
    if(NULL==myFile){
        printf("save error file: %s\n",name);
        return myT;
        }
    fprintf(myFile,"%d\n\n",myT.sT);
    for(int i =0; i<myT.sT;++i)
        fprintf(myFile,"%d\n",myT.pT[i]);
    fclose(myFile);
    return myT;
    }
///********************************************************
TabX01Int TabX01IntCopy(TabX01Int myT){
    TabX01Int myTc = TabX01IntNew(myT.sT);
    for(int i=0; i< myT.sT;++i)
        myTc.pT[i] = myT.pT[i];

    return myTc;
    }
///********************************************************
///********************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d", &x);
    return x;
    }
///********************************************************
///********************************************************
