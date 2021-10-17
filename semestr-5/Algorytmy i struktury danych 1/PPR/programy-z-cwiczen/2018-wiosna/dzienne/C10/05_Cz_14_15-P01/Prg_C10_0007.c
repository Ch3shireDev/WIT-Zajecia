#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    fprintf(stdout,"%s",myStr);
    fscanf(stdin,"%d", &x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    FILE* myFile;
    int x,y,i,f;
    char* fileName="MyData.dat";
    char* fileName2="c:/temp/MyData1.dat";

    myFile = fopen(fileName2,"r");

    if(myFile==NULL){
        printf("There is no file: \"%s\"\n",fileName);
        return -1;
        }


    for(i=0;i<10;++i){
        f=fscanf(myFile,"%d %d",&x,&y);
        printf("x = %d\tf = %d\n",x,f);
        printf("y = %d\tf = %d\n",y,f);
        }

    return 0;
    }







