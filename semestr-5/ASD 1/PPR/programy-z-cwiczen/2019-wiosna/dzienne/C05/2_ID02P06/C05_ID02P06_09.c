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

    t[0]=(int*)malloc(sizeof(int)*s1T*s2T);

    for(int i = 1; i<s1T;++i)
        t[i] = t[0]+i*s2T;



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

    printf("\n");
    for(int i=0; i<s2T;++i){
        for(int j=0;j<s1T;++j)
            printf("%3d ",*(*(t+j)+i));
        printf("\n");
        }
    printf("\n");
    printf("max = %d\n",max);

    free(t[0]);
    free(t);


    return 0;
    }
///[5,10], [-9,99] max?
///1, 2, 3
