///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct{
    int* pT;
    int  sT;
    }TabIntX01;
///*******************************************************
///*******************************************************
TabIntX01 TabIntX01New(int);
TabIntX01 TabIntX01Delete(TabIntX01*);
TabIntX01 TabIntX01Rand(TabIntX01, int, int);
TabIntX01 TabIntX01Print(TabIntX01, int);
TabIntX01 TabIntX01Load(char*);
TabIntX01 TabIntX01Save(TabIntX01, char*);
TabIntX01 TabIntX01Copy(TabIntX01);
///*******************************************************
///*******************************************************
int MyRead(char*);
///*******************************************************
///*******************************************************
TabIntX01 TabIntX01New(int sT){
    TabIntX01 myT;
    if(sT<1){
        myT.pT=NULL;
        myT.sT=0;
        return myT;
        }
    myT.sT=sT;
    myT.pT=(int*)malloc(sizeof(int)*sT);
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Delete(TabIntX01* myT){
    if(NULL!=myT->pT) free(myT->pT);
    myT->pT=NULL;
    myT->sT=0;
    return *myT;
    }
///*******************************************************
TabIntX01 TabIntX01Rand(TabIntX01 myT, int a, int b){
    for(int i = 0; i<myT.sT; ++i)
        myT.pT[i] = rand()%(b-a) + a;
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Print(TabIntX01 myT, int s){
    for(int i = 0; i<myT.sT; ++i)
        printf("[%*d]",s, myT.pT[i]);
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Load(char* name){
    TabIntX01 myT;
    FILE* myFile;
    myFile = fopen(name, "r");
    if(NULL == myFile){
        printf("load error file: %s\n",name);
        myT.pT =NULL;
        myT.sT =0;
        return myT;
        }
    fscanf(myFile, "%d", &myT.sT);
    myT=TabIntX01New(myT.sT);
    for(int i=0; i<myT.sT;++i)
        fscanf(myFile, "%d", &myT.pT[i]);

    fclose(myFile);
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Save(TabIntX01 myT, char* name){
    FILE* myFile;
    myFile = fopen(name, "w");
    if(NULL == myFile){
        printf("save error file: %s\n",name);
        return myT;
        }
    fprintf(myFile,"%d\n\n", myT.sT);
    for(int i=0; i<myT.sT; ++i)
        fprintf(myFile,"%d\n", myT.pT[i]);

    fclose(myFile);
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Copy(TabIntX01 myT){
    TabIntX01 myTc;
    myTc = TabIntX01New(myT.sT);
    for(int i=0; i<myT.sT;++i)
        myTc.pT[i] = myT.pT[i];
    return myTc;
    }
///*******************************************************
///*******************************************************
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
///*******************************************************
///*******************************************************
int main(){
    srand(time(0));
    TabIntX01 myT, myT2, myT3;
    myT = TabIntX01Print(TabIntX01Rand(TabIntX01New(MyRead("size of tab ? = ")), MyRead("a? = "), MyRead("b? = ")),2);
    printf("\n\n*********************************************\n\n");
    TabIntX01Save(myT, "Tab01.csv");
    myT2 = TabIntX01Load("Tab01.csv");
    printf("\n\n*********************************************\n\n");
    TabIntX01Print(myT2,2);
    printf("\n\n*********************************************\n\nmyT3: ");
    myT3 = TabIntX01Copy(myT);
    myT.pT[0]=-1;
    TabIntX01Print(myT3,2);
    printf("\n\n*********************************************\n\nmyT : ");
    TabIntX01Print(myT,2);
    printf("\n\n*********************************************\n\n");


    TabIntX01Delete(&myT);
    TabIntX01Delete(&myT2);

    TabIntX01Delete(&myT);

    return 0;
    }
