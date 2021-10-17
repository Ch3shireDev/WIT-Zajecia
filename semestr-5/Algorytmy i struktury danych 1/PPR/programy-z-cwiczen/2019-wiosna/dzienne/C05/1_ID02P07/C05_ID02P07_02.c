#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int st1, st2;
    st1 = 3;
    st2 = 5;
    int *t0, *t1, *t2;
    t0 =(int*)malloc(sizeof(int)*st2);
    t1 =(int*)malloc(sizeof(int)*st2);
    t2 =(int*)malloc(sizeof(int)*st2);

    //for(int i=0; i<st2;t0[i]=rand()%10,t1[i]=rand()%10,t2[i]=rand()%10,++i);
    for(int i=0; i<st2;++i){
        t0[i]=rand()%10;
        t1[i]=rand()%10;
        t2[i]=rand()%10;
        }
    for(int i=0; i<st2;printf(" %d  %d  %d\n",t0[i],t1[i],t2[i]),++i);


    return  0;
    }
