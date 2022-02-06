
	// wyznaczanie najdluzszego rosnacego podciagu

	#include<stdio.h>

   const n = 10;

   int a[n], b[n];

   main()
   { 
     int i, j, max;
     
	  for(i = 0; i < n ; i++)
         {
           printf("a[%d]=", i);

           scanf("%d", &a[i]);
         };

	  b[0] = 1;
     
  	  for( i = 1; i < n ; i++)
       { 
         max = 0;

         for(j = 0; j < i ; j++) 

           if(a[j] < a[i] && b[j] > max) max = b[j];

         b[i] = max + 1;
         
		  };
          
	  for(i = 0; i < n ; i++) printf("%d,", i); 

     printf("\n");
     
	  for(i = 0; i < n ; i++) printf("%d,", a[i]);

     printf("\n");
     
	  for(i = 0; i < n ; i++) printf("%d,", b[i]); 
      
}  
