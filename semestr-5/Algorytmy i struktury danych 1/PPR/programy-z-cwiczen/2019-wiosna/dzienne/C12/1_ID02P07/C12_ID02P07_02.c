///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct{
    int* pT;
    int sT;
    }TabX01Int;
///********************************************************
///********************************************************
TabX01Int TabX01IntNew(int);
TabX01Int TabX01IntDelete(TabX01Int*);
TabX01Int TabX01IntRand(TabX01Int, int, int);
TabX01Int TabX01IntPrint(TabX01Int, int);
TabX01Int TabX01IntLoad(char*);
TabX01Int TabX01IntSave(TabX01Int, char*);
TabX01Int TabX01IntCopy(TabX01Int);
///********************************************************
///********************************************************
int MyRead(char*);
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
int main(){
    srand(time(0));
    TabX01Int myT,myT2, myT3;

    myT = TabX01IntPrint(TabX01IntRand(TabX01IntNew(MyRead("size of table ? = ")),
                        MyRead("a? = "),MyRead("b? = ")),2);
    TabX01IntSave(myT,"tab01.csv");

    printf("\n\n*****************************\n\n");
    myT2 = TabX01IntLoad("tab01.csv");
    TabX01IntPrint(myT2,2);
    printf("\n\n*****************************\n\n");
    myT3=TabX01IntPrint(TabX01IntCopy(myT),2);

    TabX01IntDelete(&myT);
    TabX01IntDelete(&myT2);
    TabX01IntDelete(&myT3);
    TabX01IntDelete(&myT);

    return 0;
    }
