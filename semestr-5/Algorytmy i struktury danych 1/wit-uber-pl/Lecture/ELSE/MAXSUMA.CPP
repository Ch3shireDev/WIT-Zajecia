	// Wyznaczamy odcinek w tablicy tze. Max.Suma

   #include<stdio.h>

   const n = 16;

   //int a[n]={5,-8,5,2,-1,4,1,1,2,-1};
   //int a[n]={2,10,8,-4,-11,-4,8,7,-3,4,5,-4,-10,-6,10,9};

	int a[n] = {-9,10,-1,4,-8,4,-2,16};

	main()
	{
     int DotadNaj = 0, MaxKoniec = 0;

     printf("\nTablica: ");
      
     for(int i = 0; i < n; i++) printf("%d,", a[i]);
     
     for(int i = 0; i < n; i++)
      { 
        MaxKoniec = (MaxKoniec+a[i] > 0)?  MaxKoniec+a[i] : 0;
      
        DotadNaj  = (DotadNaj > MaxKoniec)?     DotadNaj  : MaxKoniec;
       };
       
	  printf("\nDotadNaj=%d", DotadNaj);
	} 