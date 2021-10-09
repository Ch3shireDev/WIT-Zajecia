#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int* *t;
    int s1T, s2T;
    s1T = 3;
    s2T = 4;
    t=(int* *)malloc(sizeof(int*)*s1T);

    int j=0;
    t[j]=(int*)malloc(sizeof(int)*s2T);
    ++j;
    t[j]=(int*)malloc(sizeof(int)*s2T);
    ++j;
    t[j]=(int*)malloc(sizeof(int)*s2T);

    for(int i=0; i<s2T;t[0][i] = rand()%10,t[1][i] = rand()%10,t[2][i] = rand()%10,++i);
    for(int i=0; i<s2T;printf("%d  %d  %d\n",t[0][i],t[1][i],t[2][i]),++i);


    return 0;
    }
