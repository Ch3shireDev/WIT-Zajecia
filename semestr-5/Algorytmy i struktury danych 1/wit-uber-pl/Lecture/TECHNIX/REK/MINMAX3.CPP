
   // minmax wersja iteracyjna, time ~ 3/2*n 
   
	#include<stdio.h>
   #include<conio.h>
   
   const size = 8;  

   void minmax(int [], int , int*, int*);


	main()
	{
   	int min,	max;

      int t[size];

      for(int i = 0 ; i < size ; i++) scanf("%d", &t[i]);

      minmax(t, size, &max, &min);

      for(int i = 0 ; i < size ; i++) printf("%d, ", t[i]);

      printf("\n\nmax=%d", max);

      printf("\n\nmin=%d", min); 

      getch();
   }



   void minmax(int t[], int size, int *admax, int *admin)
   { 
      int i, max = t[0], min = t[1] ;

      if(t[0] < t[1]) { max = t[1]; min = t[0];}
      
      for(i = 2 ; i < (size - 1) ; i+=2)
       {
          if(t[i] > t[i+1]) 
           {
             if(t[i+1] < min)  min = t[i+1];

             if(t[i]   > max)  max = t[i];
           }
          else  
           {
             if(t[i]   < min)  min = t[i];

             if(t[i+1] > max)  max = t[i+1];
           }
           
       }
       
      *admax = max;

      *admin = min;
   }  
  
