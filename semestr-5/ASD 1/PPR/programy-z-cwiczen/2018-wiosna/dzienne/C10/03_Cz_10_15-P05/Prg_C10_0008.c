#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char * myStr);
int CountNumbers(char*);/**3, 4, 5 */
void CreateNumberFile(char*);
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    fprintf(stdout, "%s", myStr);
    fscanf(stdin,"%d", &x);

    return x;
    }
/*********************************************************/
int CountNumbers(char* fileName){
    FILE* myFile;
    int cnt, f,x;
    cnt=0;
    myFile=fopen(fileName,"r");
    if(myFile == NULL){
        printf("There is no file : %s\n", fileName);
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
void CreateNumberFile(char* myStr){
    FILE* myFile;
    int i;
    myFile=fopen(myStr, "w");
    for(i=1; i<=5;++i)
        fprintf(myFile,"T[%2d]=%3d\n",i,MyRead("x ?="));
    fclose(myFile);
    }
/*********************************************************/
/*********************************************************/
int main(){
    char * myStr ="MyData.dat";
    char * myStr2 ="MyData2.dat";
    printf("Number of the numbers in file ");
    printf("\"%s\" is %d\n",myStr,CountNumbers(myStr));
    CreateNumberFile(myStr2);

    return 0;
    }
