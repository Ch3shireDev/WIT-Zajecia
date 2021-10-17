#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int *t0, *t1, *t2;
    int* *t;
    int s1T, s2T;
    s1T = 3;
    s2T = 4;
    t=(int* *)malloc(sizeof(int*)*s1T);

    t0=(int*)malloc(sizeof(int)*s2T);
    t1=(int*)malloc(sizeof(int)*s2T);
    t2=(int*)malloc(sizeof(int)*s2T);

    for(int i=0; i<s2T;++i){
        t0[i] = rand()%10;
        t1[i] = rand()%10;
        t2[i] = rand()%10;
        }

    for(int i=0; i<s2T;++i){
        printf("%d  %d  %d\n",t0[i],t1[i],t2[i]);
        }

    t[0]=t0;
    t[1]=t1;
    t[2]=t2;

    printf("\n");
    for(int i=0; i<s2T;++i){
        printf("%d  %d  %d\n",t[0][i],t[1][i],t[2][i]);
        }

    return 0;
    }
