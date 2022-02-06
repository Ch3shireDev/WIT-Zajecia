#include<stdio.h>
#include<conio.h>

const int n=16;

main()
{ 
 int a[n][n];
 int i,j;

 for(i=0;i<n;i++) a[i][0]=1;
 for(j=0;j<n;j++) a[0][j]=1;

 for(i=1;i<n;i++)
  for(j=1;j<n;j++)
   a[i][j]=(a[i-1][j]+a[i][j-1])%2;
   
 for(i=0;i<n;i++)
  {for(j=n-i;j>-1;j--)printf(" "); 
   for(j=0;j<i+1;j++)
    if(a[i-j][j])   printf("* ");
    else            printf("  ");
   printf("\n");
  }  

 getch(); 
}

/*  trojkat Pascala %2 = trojkat Sierpinskiego

                 *
                * *
               *   *
              * * * *
             *       *
            * *     * *
           *   *   *   *
          * * * * * * * *
         *               *
        * *             * *
       *   *           *   *
      * * * *         * * * *
     *       *       *       *
    * *     * *     * *     * *
   *   *   *   *   *   *   *   *
  * * * * * * * * * * * * * * * *


*/