#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
int CountNumbers(char*);/**3, 4, 5 */
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;

    fprintf(stdout,"%s", myStr);
    fscanf(stdin,"%d",&x);

    return x;
    }
/*********************************************************/
int CountNumbers(char* fileName){
    FILE* myFile;
    int cnt=0;
    int f,x;

    myFile=fopen(fileName,"r");
    if(myFile==NULL){
        printf("There is no file :\"%s\"",myFile);
        return -1;
        }
    f=fscanf(myFile,"%d",&x);

    while(f==1){
        ++cnt;
        f=fscanf(myFile,"%d",&x);
        }

    fclose(myFile);
    return cnt;
    }
/*********************************************************/
/*********************************************************/
int main(){
    FILE* myFile;
    char* myStr="MyData.dat";
    int x;
    int i, f;

    myFile = fopen(myStr,"r");



    for(i=0;i<18;++i){
        f=fscanf(myFile,"%d",&x);
        printf("x = %d\tf = %d\n",x,f);
        }

    fclose(myFile);
    return 0;
    }







