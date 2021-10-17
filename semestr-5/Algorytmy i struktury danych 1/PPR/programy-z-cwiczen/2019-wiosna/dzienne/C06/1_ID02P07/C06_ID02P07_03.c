#include <stdio.h>

void MyShow(int px){
    for(int i=0;i<px;++i)
        printf("value = %d\n",px);
    printf("---------------------------\n");
    }

int main(){
    int x=6,y=7,z=12;

    MyShow(x);
    MyShow(y);
    MyShow(z);


    return 0;
    }
