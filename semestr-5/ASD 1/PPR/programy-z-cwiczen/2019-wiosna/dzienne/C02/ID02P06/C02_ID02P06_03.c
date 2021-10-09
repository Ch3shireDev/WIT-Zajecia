#include <stdio.h>

int main(){
    int x;

    printf("x? = ");
    scanf("%d", &x);

    if(x>12){
        printf("%d > 12\n",x);
        }
    else{
        printf("%d <= 12\n",x);
        }

    return 0;
    }
