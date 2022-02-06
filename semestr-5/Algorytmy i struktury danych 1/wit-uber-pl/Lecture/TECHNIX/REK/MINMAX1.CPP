
   // minmax wersja iteracyjna, time ~ 2*n 
   
	#include<stdio.h>

   const size = 6;  

   void minmax(int [], int , int*, int*);


	main()
	{
   	int min,	max;

      int t[size];

      for(int i = 0 ; i < size ; i++) scanf("%d,", &t[i]);

      minmax(t, size, &max, &min);

      for(int i = 0 ; i < size ; i++) printf("%d,", t[i]);

      printf("\nmax=%d\n", max);

      printf("\nmin=%d\n", min); 
   }



   void minmax(int t[], int size, int *admax, int *admin)
   { 
      int i, max, min;

      max = min = t[0];
      
      for(i = 1 ; i < size ; i++)
       {
          if(t[i] > max) max = t[i];

          if(t[i] < min) min = t[i];
        }

      *admax = max;

      *admin = min;
   }  
  
