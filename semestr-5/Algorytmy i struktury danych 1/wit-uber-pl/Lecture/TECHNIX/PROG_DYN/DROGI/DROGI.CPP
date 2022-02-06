
	// min. droga w tablicy int

	#include<stdio.h> 

	const n = 4;
   int a[n][n];

	main()
	{ 
  		int i, j, min;

  		for( i = 0; i < n ; i++ )

   		for( j = 0; j < n ; j++)
  			  {
      		printf(" a[%d,%d]= ", i, j); 

      		scanf(" %d ", &a[i][j]);
   		  }; 

 	   printf(" \n ");


      
  		for( i = 0; i < n ; i++ )
  		 {
         for( j = 0; j < n ; j++)

          printf(" %d, ", a[i][j]);


    		 printf(" \n ");
       };

		printf(" \n ");
   

   
      for( i = 1; i < n; i++ ) a[0][i] += a[0][i-1];

      for( j = 1; j < n; j++ ) a[j][0] += a[j-1][0];



      for( i = 1; i < n ; i++ )

       for( j = 1; j < n ; j++ )
        { 
          if( a[i-1][j] > a[i][j-1]) min = a[i][j-1];

          else                       min = a[i-1][j];

          a[i][j] += min;
        }   

      printf(" %d ", a[n-1][n-1]);

   }   