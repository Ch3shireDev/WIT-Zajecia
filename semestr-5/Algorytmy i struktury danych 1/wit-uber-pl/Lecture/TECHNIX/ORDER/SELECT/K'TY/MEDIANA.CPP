   // wyznaczanie mediany z zastosowaniem funkcji k-search

   #include<stdio.h>
   #include<conio.h>
	#define n 10

	int data[n];
	int select(int [], int l, int r, int k);
	void swap(int *, int *);

	main()
	{ 
		int k, t, mediana;

      clrscr();

  		printf("Prosze podac %d liczb, (ostatnia max - wartownik) :\n", n);
  
  		for(k = 0; k < n - 1; k++) {printf("a[%d]=", k); scanf("%d,", &data[k]);}
  
  		data[n-1] = 32767;

  		mediana = select(data, 0, n - 2, n / 2);
  
  		printf("\nLiczby mniejsze od mediany=%d:\n", mediana);
  
  		for(k = 0; k < n - 1; k++)
  
   	 if(data[k] < mediana) printf("%d,", data[k]);
   
      getch();
      
  		return 0;
  
	}

	int select(int tab[], int l, int r, int k)
	{ 
  		int i, j, v;

  		if(l < r)
      {
    		v = tab[l]; i = l; j = r + 1;
   
    		do{

      		do{ i++; }while(tab[i] < v);

      		do{ j--; }while(tab[j] > v);

      		if(i < j) swap(&tab[i], &tab[j]);

     		}while(i < j);

      	tab[l] = tab[j]; tab[j] = v;
 
   		if(k - 1 == r - j)      return(v);

   		else if(k - 1 < r - j)  return select(tab, j + 1, r, k);

		   	  else               return select(tab, l, j - 1, k - (r - j + 1));
   	}
		else return(tab[l]);
	}

	void swap(int *px, int *py)
	{ 
  		int temp;

 		 temp = *px;

  		 *px  = *py;

  		 *py  = temp;
	}