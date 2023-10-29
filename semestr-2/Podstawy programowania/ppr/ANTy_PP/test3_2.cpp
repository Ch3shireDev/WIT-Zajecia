#include<stdio.h>
#include<conio.h>
#include<math.h>

void main(){
    int a,b;
    printf("Program liczy najwiekszy wspolny dzielnik dwoch liczb\n");
    printf("-----------------------------------------------------\n");

    printf("Podaj a: ");
    scanf("%d",&a);
    printf("Podaj b: ");
    scanf("%d",&b);
      
    int x,y,temp;
    x = a;
    y = b;
    while(y){
        temp=y;
        y=x%y;
        x=temp;
    };

    printf("nwd(%d,%d)=%d",a,b,x);

	printf("\n");
getche();


}



