#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
int CountNumbers(char*);/**3, 4, 5 */
void CreateFileNumber(char*, int);
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
void CreateFileNumber(char* fileName, int no){
    FILE* myFile;
    int i;
    myFile=fopen(fileName,"w");

    for(i=1;i<=no;++i)
        fprintf(myFile,"T[%2d]=%3d\n",i,MyRead("x ?="));

    fclose(myFile);
    }
/*********************************************************/
/*********************************************************/
int main(){
    char* myStr="MyData.dat";
    char* myStr2="MyNo.dat";
    printf("There are %d numbers ",CountNumbers(myStr));
    printf(" in file: \"%s\"\n",myStr);
    CreateFileNumber(myStr2,4);
    return 0;
    }







