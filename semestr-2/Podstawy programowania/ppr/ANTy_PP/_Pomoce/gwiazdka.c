#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#define ESC 27
void next(int &x1,int &y1,int &x2,int &y2,
int a,int b,int x,int y)
{
 int xp=x2,yp=y2;
if((x2==x)&&(y2<b+y))y2++;
else if((y2==y+b)&&(x2<x+a))x2++;
else if((x2==x+a)&&(y2>y))y2--;
else if((y2==y)&&(x2>x))x2--;
x1=xp;
y1=yp;
}
void rysuj(int x1,int y1,int x2,int y2)
{
 gotoxy(x1,y1);
printf(" ");
gotoxy(x2,y2);
printf("*");
}
void main()
{
 int x,y,a,b,x1,x2,y1,y2,i;
char znak=1;
printf("x= ");
scanf("%i",&x);
printf("y= ");
scanf("%i",&y);
printf("a= ");
scanf("%i",&a);
printf("b= ");
scanf("%i",&b);
x1=x;
y1=y;
x2=x;
y2=y;
while(znak!=ESC)
{
 rysuj(x1,y1,x2,y2);
next(x1,y1,x2,y2,a,b,x,y);
znak=getch();
}
}
