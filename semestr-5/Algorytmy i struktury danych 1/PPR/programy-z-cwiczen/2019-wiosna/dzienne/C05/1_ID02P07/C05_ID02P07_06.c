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
    for(int j=0; j<st1; ++j)
        t[j]=(int*)malloc(sizeof(int)*st2);

    for(int i = 0; i<st1;++i)
        for(int j = 0; j<st2;++j)
            t[i][j] = rand()%10;


    for(int i = 0; i<st1;++i){
        for(int j = 0; j<st2;++j)
            printf("[%d]",t[i][j]);
        printf("\n");
        }
    printf("\n");
    for(int j = 0; j<st2;++j){
        for(int i = 0; i<st1;++i)
            printf("[%d]",t[i][j]);
        printf("\n");
        }

    for(int j=0; j<st1; ++j)
        free(t[j]);
    free(t);
    return  0;
    }



