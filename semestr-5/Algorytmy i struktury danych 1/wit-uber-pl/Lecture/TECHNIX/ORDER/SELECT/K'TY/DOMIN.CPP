  #include<stdio.h>

  const n = 20;

  int tab[n] = {1,2,1,3,3,3,2,3,3,3,2,3,3,2,3,2,3,1,3,1};

  main()
  { 
    int licz = 0, i, temp = tab[0];

    printf(" \n ");

    for(i = 0; i < n; i++) printf(" %d, ", tab[i]);

    printf("\n0,");

    for(i = 1; i < n ; i++)
      {
       if(tab[i] == temp) licz++;
   
       else if(licz != 0) licz--;

	         else          temp = tab[i];
        
       printf("%d,", licz);

      }
      
    return 0;
  }