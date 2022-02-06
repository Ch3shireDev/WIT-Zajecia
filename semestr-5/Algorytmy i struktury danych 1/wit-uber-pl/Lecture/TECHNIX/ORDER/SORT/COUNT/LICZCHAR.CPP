	// sortowanie znakow w pliku

	#include<stdio.h>
   #include<conio.h>
   
	const n = 26;

   main()

   { 
    int tab[n];

    FILE *fin, *fout;

    char *in  = "C:\\in.txt";
    char *out = "C:\\out.txt";
    
    char zn;

    int i;

    for(i = 0; i < n; i++) tab[i] = 0;

    fin = fopen(in, "r");
    
    while((zn = fgetc(fin)) != EOF)

       if(0 <= zn - 97 && zn - 97 < n) tab[zn - 97]++;

    fclose(fin);

    

    for(i = 0; i < n; i++) 

      { printf("\n%c : %d", i + 97, tab[i]); getch(); }


    fout = fopen(out, "w");
    
    for(i = 0; i < n; i++) 
    
         while(tab[i]) { fputc(i+97, fout); tab[i]--; }
      
    fclose(fout);
    

    return 0;
    }