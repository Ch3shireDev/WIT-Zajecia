#include<stdio.h>
#include<stdlib.h>
#include<string.h>

#define TAK 1
#define NIE 0
#define printfln printf("\n")

/* STRUKTURY DANYCH */

struct sasiedzi                    /* adresy sasiadow wierzcholka     */
{ struct wierzcholek *sasiad;      /* dokladny adres sasiada          */
  struct sasiedzi *kolejny;        /* kolejnego adres sasiada         */ 
};

struct wierzcholek                 /* wierzcholek                     */
{ char * nazwa;                    /* nazwa wierzcholka               */
  struct sasiedzi *incydentne;     /* adres do listy sasiadow         */
  int    odwiedzony;               /* czy zostal odwiedzony           */
  struct wierzcholek *nast;        /* adres do nastepnego wierzcholka */
};

struct wierzcholek *gr; /* jestem leniem ...                          */
                        /* zly styl programowania... prosze poprawic  */


/* FUNKCJE */


/* ta funkcja wypisuje caly graf */
void wypisz(struct wierzcholek *wezel)
{ struct sasiedzi *pom;

  if(wezel!=NULL)
  { printf("%s : ", wezel->nazwa);
    pom=wezel->incydentne;
    
    while(pom!=NULL)
	 { printf("%s, ", pom->sasiad->nazwa);
   	pom=pom->kolejny;
    }

    printfln;
    wypisz(wezel->nast);
  }
};

/* ta funkcja wyszukuje wierzcholek o nazwie 'alfa' w grafie */
struct wierzcholek * znajdz(char *alfa, struct wierzcholek *wezel)
{	if(wezel!=NULL)
	{ if(strcmp(alfa,wezel->nazwa)==0) return(wezel); 
     else znajdz(alfa,wezel->nast);
   }
   else return(NULL);
}	

/* ta funkcja tworzy liste sasiadow dla danego wierzcholka */
struct sasiedzi * tworz_liste(struct wierzcholek *wezel)
{ char *st="";
  struct sasiedzi *sas_bierz, *sas_next;
  struct sasiedzi *zwrot;
  printfln;
  printf("Tworze liste incydencji dla wierzcholka %s\n", wezel->nazwa);
  st=(char *)calloc(80,sizeof(char));
  printf("Podaj nazwe: "); gets(st);
  if(*st=='\0') zwrot=NULL;

  else
  {  sas_bierz=(struct sasiedzi *)calloc(1,sizeof(struct sasiedzi));
     sas_bierz->sasiad=znajdz(st,gr);
     sas_bierz->kolejny=NULL;
	  zwrot=sas_bierz;
	  st=(char *)calloc(80,sizeof(char));
	  printf("Podaj nazwe: "); gets(st);

	  while(*st!='\0')
	   { sas_next=(struct sasiedzi *)calloc(1,sizeof(struct sasiedzi));
	     sas_next->sasiad=znajdz(st,gr);
	     sas_next->kolejny=NULL;
        sas_bierz->kolejny=sas_next;
	     sas_bierz=sas_next;
	     st=(char *)calloc(80,sizeof(char));
	     printf("Podaj nazwe: "); gets(st);
	   }

    return(zwrot);

  }

};

/* rekurencyjna wersja algorytmu DFS */
void DFS(struct wierzcholek *wezel)
{ struct sasiedzi *pom;
  printf("%s, ", wezel->nazwa);
  wezel->odwiedzony=TAK;
  pom=wezel->incydentne;
  while(pom!=NULL)
   { if(pom->sasiad->odwiedzony==NIE) DFS(pom->sasiad);
     pom=pom->kolejny;
   }
};      


/* ta funkcja wstawia wierzcholek do grafu */
void wstaw(void)
{ 
  char *st;
  struct sasiedzi    *sas_pom;
  struct sasiedzi    *sas_pom2;
  struct wierzcholek *wezel;
  struct wierzcholek *wez_pom2;

  printfln;

  /* wstaw wierzcholek na liste */
  st=(char*)calloc(80,sizeof(char));
  printf("Podaj nazwe nowego wierzcholka: "); gets(st);
  wezel=(struct wierzcholek *)calloc(1,sizeof(struct wierzcholek));
  wezel->nazwa=st;
  wezel->nast=gr;
  
  /* zbuduj liste sasiadow wierzcholka */
  wezel->incydentne=tworz_liste(wezel);

  /* dla kazdego sasiada wierzcholka popraw jego liste incydencji */
  /* dostaw na poczatku adres do nowego wierzcholka               */
  gr=wezel;
  sas_pom=wezel->incydentne;
  while(sas_pom!=NULL)
   { wez_pom2=sas_pom->sasiad;
     sas_pom2=(struct sasdiedzi *)calloc(1, sizeof(struct sasiedzi));
     sas_pom2->sasiad=wezel;
     sas_pom2->kolejny = wez_pom2->incydentne;
     wez_pom2->incydentne=sas_pom2;
     
     sas_pom=sas_pom->kolejny;
   }
   
};

/* ta funkcja usuwa wierzcholek z grafu */
void usun(struct wierzcholek *wezel)
{
   struct wierzcholek *pom;
   struct sasiedzi *pom2, *pom3;

    /* niszcze liste incydencji wierzcholka */
   
   pom2=wezel->incydentne;
   while(pom2!=NULL)
    { pom3=pom2->kolejny;
      free(pom2);
      pom2=pom3;
    } 
   wezel->incydentne=NULL;            
   
   /* znajduje wszystkie dowiazania */
   pom=gr;
   while(pom!=NULL)
    { 
      pom2=pom->incydentne;

      /* niszcze gdy jest pierwszy */
      if(pom2!=NULL && pom2->sasiad==wezel)
 	   {  pom->incydentne=pom2->kolejny;
         free(pom2);
       }

      else 
       {
         /* niszczy na dalszych pozycjach */
         while(pom2!=NULL)
          {    
               pom3=pom2->kolejny;
               if(pom3!=NULL && pom3->sasiad==wezel)
                { pom2->kolejny=pom3->kolejny;
                  free(pom3);
                }
               pom2=pom2->kolejny;
          }
       }
          
       pom=pom->nast;
    }

   /* szukam poprzednika na liscie wierzcholkow */
    
   if(wezel==gr) gr=gr->nast;
   else
     { pom=gr;
       while(pom->nast!=wezel) pom=pom->nast;

       pom->nast=wezel->nast; /* omijam wezel */
     }

    free(wezel);     /* i na koncu niszcze wierzcholek */
};


/* funkcja budujaca graf */
void tworz_nowy_graf(void)
{
 struct wierzcholek *pom, *bierz, *next;
 char *st;

 st=(char *)calloc(80,sizeof(char));
 printfln;
 printf("Najpierw podaj nazwe wierzcholkow\n");
 printf("Zakoncz PUSTYM ENTEREM\n");
 printfln;
 /* spis wierzcholkow grafu */
 printf("Podaj nazwe wierzcholka: ");
 gets(st);
 if(*st=='\0') gr=NULL;
 else
  { gr=(struct wierzcholek *)calloc(1,sizeof(struct wierzcholek));
    gr->nazwa=st;
    gr->nast=NULL;
    bierz=gr;
    st=(char*)calloc(80, sizeof(char));
    printf("Podaj nazwe wierzcholka: "); gets(st);

    while(*st!='\0')
     {  next=(struct wierzcholek *)calloc(1,sizeof(struct wierzcholek));
        next->nazwa=st;
        next->nast=NULL;
        bierz->nast=next;
        bierz=next;
        st=(char*)calloc(80, sizeof(char));
        printf("Podaj nazwe wierzcholka: "); gets(st);
     }
   }

   /* budowa list incydencji */
   pom=gr;
   while(pom!=NULL)
    { printf("////////////////////////////////////////////");
      pom->incydentne=tworz_liste(pom);
      pom=pom->nast;
    }
};           


main()
{
  int koniec, odp;
  char *st;
  struct wierzcholek *pom;

  printf("PROSTY EDYTOR GRAOW");
  printfln;
  koniec=NIE;
  gr=NULL;
  while(koniec==NIE)
   { 
   printfln;
   printf("DOSTEPNY OPERACJE         \n");
   printf("1. Nowy graf              \n");
   printf("2. Wstaw wierzcholek      \n");
   printf("3. Usun wierzcholek       \n");
   printf("4. Wypisz zawartosc grafu \n");
   printf("5. DFS                    \n");
   printf("6. Koniec                 \n");
   printfln;
   printf("Podaj numer operracji: "); scanf("%d", &odp);
   fflush(stdin);
   printfln;
   switch(odp)
    {  
     case 1: tworz_nowy_graf();
             break;
     case 2: wstaw();
             break;
     case 3: printfln;
             st=(char *)calloc(80,sizeof(char));
             printf("Podaj nazwe wierzcholka do usunieca : ");
             gets(st);
             pom=znajdz(st,gr);
             if(pom==NULL)
              printf("Wierzcholek o nazwie %s nie istnieje \n", st);
             else usun(pom);
             break;
     case 4: wypisz(gr);
             break;
     case 5: pom=gr;
             while(pom!=NULL)
               {   pom->odwiedzony=NIE;
                   pom=pom->nast;
               }
             st=(char *)calloc(80,sizeof(char));
             printf("Podaj wierzcholek, z ktorego chcesz rozpoczac DFS  ");
             gets(st);
             pom=znajdz(st,gr);
             if(pom!=NULL) 
              { DFS(pom);
                printfln;
              }  
             else { printf("Takiego wierzcholka nie ma");
                    printfln;
                  }
             break;
     case 6: koniec=TAK;
             while(gr!=NULL) usun(gr); 
             break;
                            	                      
    }
   }
}               
   

