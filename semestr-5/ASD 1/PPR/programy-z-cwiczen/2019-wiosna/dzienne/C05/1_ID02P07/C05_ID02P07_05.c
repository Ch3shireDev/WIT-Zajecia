#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int st1, st2;
    st1 = 3;
    st2 = 5;
    int* *t;


    t=(int**)malloc(sizeof(int*)*st1);
    int j;
    j=0;
    t[j]=(int*)malloc(sizeof(int)*st2);
    ++j;
    t[j]=(int*)malloc(sizeof(int)*st2);
    ++j
    t[j]=(int*)malloc(sizeof(int)*st2);


  /*  for(int i=0; i<st2;t0[i]=rand()%10,t1[i]=rand()%10,t2[i]=rand()%10,++i);
    for(int i=0; i<st2;printf(" %d  %d  %d\n",t0[i],t1[i],t2[i]),++i);


    printf("t0[0] = %d\n", *(*(t+0)+0));
    printf("t0[0] = %d\n", t[0][0]);
*/

    return  0;
    }



