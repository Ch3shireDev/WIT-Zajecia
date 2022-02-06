

	// minmax wersja rekurencyjna
   
	#include<stdio.h>
      
	const n = 8;

        int tab[n] = {2,3,5,1,5,6,2,9};  

	void minmax(int, int, int*, int*);

	main()
	{
         int m = tab[0], M = tab[0];
   
	 minmax(0, n - 1, &m, &M);
    
	 printf("m=%d,M=%d", tab[m], tab[M]);

        }

	void minmax(int i, int j, int *am, int *aM)
	{
         int m1, m2, M1, M2, sr;
    
	 if(i + 1 == j)
  	  {
            if(tab[j] > tab[i]) { *am = i; *aM = j; }
  	
            else                { *am = j; *aM = i; };
 	  }
	 else
  	  { 
            sr = (i + j) / 2;
       	  
            minmax(i, sr, &m1, &M1);
        
   	    minmax(sr + 1, j, &m2, &M2);
        
    	    *am = (tab[m2] > tab[m1]) ? m1 : m2;
            
            *aM = (tab[M1] > tab[M2]) ? M1 : M2;
	  }
	}    
     
