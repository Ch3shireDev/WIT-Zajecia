#include <stdio.h>

void MyShow(int px){
    for(int i=0; i<px;++i)
        printf("value  = %d\n",px);
    printf("----------------------------------------------------\n");
    }

int main(){
    int x=3, y=5, z=2;


    MyShow(x);
    MyShow(y);
    MyShow(z);

    return 0;
    }
