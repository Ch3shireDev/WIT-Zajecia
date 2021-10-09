#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char * myStr);
int CountNumbers(char*);/**3, 4, 5 */
/*********************************************************/
/*********************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
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
/*********************************************************/
int main(){
    char * myStr ="MyData.dat";
    printf("Number of the numbers in file ");
    printf("\"%s\" is %d\n",myStr,CountNumbers(myStr));

    return 0;
    }
