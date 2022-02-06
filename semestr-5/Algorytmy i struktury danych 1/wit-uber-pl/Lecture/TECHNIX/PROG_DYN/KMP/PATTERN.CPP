#include<stdio.h>
#include<conio.h> 
main()
{ FILE *fpi, *fpo;
  char c;
  int flaga=0, stan=1, nr=0;
  char *nazwai="C:\\text.txt";
  char *nazwao="C:\\wynik.txt";

  fpi=fopen(nazwai,"r");
  fpo=fopen(nazwao,"w");

  clrscr();
  while(!flaga && (c=fgetc(fpi))!=EOF)
    {printf("%d, %c> ", stan, c);
     fputc(stan+48,fpo);
     switch(c)
      { case 'a':if (stan==1) stan=2;
		 else if (stan==3) stan=2;
		 else if (stan==4) flaga=1;
		 break;

	case 'b':if(stan==2) stan=3;
		 else if(stan==3) stan=4;
		 else if(stan==4) stan=1;
		 break;

	default: ;//pusta czynnosc
      };
     nr++;
    }

  fclose(fpi);
  fclose(fpo);

  if(flaga) printf("\nw tekscie jest slowo: abba na pozycji: %d",nr);
  else      printf("\nw tekscie nie ma slowa: abba");
  return 0;
}
