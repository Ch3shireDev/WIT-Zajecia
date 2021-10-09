#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char*);
int CountNumbers(char*);/** 3, 4, 5 */
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    fprintf(stdout,"%s",myStr);
    fscanf(stdin,"%d", &x);

    return x;
    }
/*********************************************************/
int CountNumbers(char* fileName){
    FILE* myFile;
    int cnt=0;
    int f,x;
    myFile=fopen(fileName,"r");
    if(myFile==NULL){
        printf("There is no file: \"%s\"\n",fileName);
        return -1;
        }
    f=fscanf(myFile, "%d",&x);
    while(f==1){
        ++cnt;
        f=fscanf(myFile, "%d",&x);
        }
    fclose(myFile);
    return cnt;
    }
/*********************************************************/
/*********************************************************/
int main(){
    char* fileName="MyData.dat";
    char* fileName2="c:/temp/MyData1.dat";

    printf("Number of nubers in");
    printf(" \"%s\" is %d\n",fileName,CountNumbers(fileName));

    return 0;
    }







