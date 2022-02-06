   // max. kwadrat 1 w tablicy 0/1

   #include<stdio.h>
   #include<conio.h>

   const lw = 5;
   const lk = 7;

   void main()
   { 

    FILE *fpi, *fpo;

    char c;

    fpi = fopen("C:\\dane.txt","r");

    int tab[lw][lk];
    
    int w = 0, k = 0, min;

    while((c = fgetc(fpi)) != EOF)
    { 
      if(c != '\n')
       { 
        if(c == '0') tab[w][k] = 0;

        if(c == '1') tab[w][k] = 1;

        k++;
       }
       
      else { w++; k=0; };
  }
  
  fclose(fpi);

  clrscr();
  
  for(w = 0; w < lw; w++)
   { 
    for(k = 0; k < lk; k++) printf("%d", tab[w][k]);
    
    printf("\n");
   }
   printf("\n");

  for(w = 1; w < lw; w++)
  
   for(k = 1; k < lk; k++)
    {
    if(tab[w][k] == 1)
      {
       if(tab[w-1][k-1] < tab[w-1][k]) min = tab[w-1][k-1];

       else                            min = tab[w-1][k];

       if(min > tab[w][k-1])           min = tab[w][k-1];

       else                       tab[w][k]= min + 1;
      }
    }


  for(w = 0; w < lw; w++)
   { 
    for(k = 0; k < lk; k++) printf("%d", tab[w][k]);

    printf("\n");
   }


  fpo = fopen("C:\\wyniki.txt", "w");
  
  for(w = 0; w < lw; w++)
  
   { for(k = 0; k < lk; k++) fputc(tab[w][k] + 48, fpo);

     fputc('\n', fpo);
   }
  fclose(fpo);
}
