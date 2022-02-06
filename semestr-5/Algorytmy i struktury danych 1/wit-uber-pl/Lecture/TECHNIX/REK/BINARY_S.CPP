#include<stdio.h>
int szukaj_rec(int *,int,int,int);

void main()
{    
    int tabl[12]={1,2,6,18,20,23,29,32,34,39,40,41};
    int x=23,temp;
    temp=szukaj_rec(tabl,x,0,11);
	if(temp>-1)
	   printf("tab[%d]=%d",temp,x);
	else 
       printf("brak w tablicy elementu %d",x);
}


int szukaj_rec(int * tab,int x,int left,int right)
{
   if(left>right) return -1; /* element nie znaleziony */
   
   else
    {
     int mid=(left+right)/2;
   
	 if(tab[mid]==x) return mid; /* element znaleziony! */
     
	 else
	      if(x<tab[mid])  return szukaj_rec(tab,x,left,mid-1); 
		  
		  else		      return szukaj_rec(tab,x,mid+1,right);


      }
}
