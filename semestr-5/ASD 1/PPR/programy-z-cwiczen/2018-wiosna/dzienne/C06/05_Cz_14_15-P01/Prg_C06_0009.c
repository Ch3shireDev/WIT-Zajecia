#include <stdio.h>
#include <stdlib.h>

int main(){
    int* * myT;
    unsigned sT, i, j;
    printf("size ?=");
    scanf("%u", &sT);

    while(sT>3){
        system("cls");
        myT = (int**)malloc(sizeof(int*)*sT);

        myT[0] = (int*)malloc(sizeof(int)*((sT+1)*sT)/2);

        for(i =1; i<sT; ++i)
            myT[i]= myT[i-1]+i;

        for(i=0; i<((sT+1)*sT)/2;++i)
            myT[0][i]=i;

        for(i=0; i<sT; ++i){
            for(j=0; j<=i; ++j)
                printf("[%3d]", myT[i][j]);
            printf("\n");
            }
        free(myT[0]);
        free(myT);
        printf("size ?=");
        scanf("%u", &sT);
    }
    return 0;
    }

