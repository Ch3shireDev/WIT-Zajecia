#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int* *t;
    int s1T, s2T;
    s1T = 5+rand()%6;
    s2T = 5+rand()%6;
    t=(int* *)malloc(sizeof(int*)*s1T);

    for(int j=0;j<s1T;++j)
        t[j]=(int*)malloc(sizeof(int)*s2T);

    for(int j=0;j<s1T;++j)
        for(int i=0; i<s2T;++i)
            t[j][i] = rand()%109-9;

    for(int j=0;j<s1T;++j){
        for(int i=0; i<s2T;++i)
            printf("%3d ",t[j][i]);
        printf("\n");
        }
    printf("\n");
    for(int i=0; i<s2T;++i){
        for(int j=0;j<s1T;++j)
            printf("%3d ",t[j][i]);
        printf("\n");
        }

    int max = t[0][0];

    for(int i=0; i<s2T;++i)
        for(int j=0;j<s1T;++j)
            if(max<t[j][i]) max = t[j][i];


    printf("max = %d\n",max);
    for(int j=0;j<s1T;++j)
        free(t[j]);
    free(t);


    return 0;
    }
///[5,10], [-9,99] max?
///1, 2, 3
