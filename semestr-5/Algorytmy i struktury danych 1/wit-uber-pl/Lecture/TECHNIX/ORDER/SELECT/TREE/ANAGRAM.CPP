/* program pt.: "ANAGRAMY" aytor Robert Salamon  gr. 254 nr. indeksu 1380 */
#include <stdio.h>

void input(FILE *,int licz[],char);
void out(FILE *,FILE *,long );
void add(struct element_drzewa * *,int licz[],long);
void inorder(FILE *,FILE *,struct element_drzewa *);


FILE *we;  //pliki wejscia wyjscia
FILE *wy;

struct element_drzewa             //struktura wezla w drzewie
{
	long pozycja;
	int licz[26];
	struct lista *nast;
	element_drzewa *lewy,*prawy;
};

struct lista                    //struktura elementu listy
{
	int licz[26];
	long pozycja;
	lista *nast;
};

void main()
{
	char *plikwe="c:\\dane.txt";     //sciezki dostepu do plikow
	char *plikwy="c:\\wynik.txt";

	we=fopen(plikwe,"r");
	wy=fopen(plikwy,"w");

	char znak;
	int licz[26];
	long pozycja;
	struct element_drzewa *korzen=NULL;

	pozycja=ftell(we);               //adres pierwszego wyrazu w pliku we

	while((znak=fgetc(we)) != EOF)   //petla przechodzaca plik we az do jego konca
	{

		input(we,licz,znak);          //wczytywanie licznikow znakow do tablicy
		add(&korzen,licz,pozycja);    //wkladanie tablic do drzewa
		pozycja=ftell(we);            //adres nastepnego wyrazu w pliku we

	}
	//add(&korzen,licz,pozycja);
	inorder(we,wy,korzen);           //przechodzenie calego drzewa i wypisanie anagramow

	fclose(we);                     //zamykanie plikow
	fclose(wy);
}

void  input(FILE *we,int licz[],char znak)    //pobieranie slowa z we
{
	for (int i=0;i<26;i++)  //zerowanie tablicy
		licz[i] = 0;


		while((znak>=97)&&(znak<=122))    //zliczanie ilosci wystapien danego
		{                                 //znaku, wpisanie licznika do tablicy
			licz[znak-97]++;
			znak=fgetc(we);
		}

}

void add(struct element_drzewa * * p,int licz[],long pozycja)  //wkadanie na drzewo
{
	int i;
	struct lista *nr1,*nr2;
	if((*p)==NULL)                       //jezeli wczytany element jest null,
	{                                    //to jest to korzen
		(*p) = new struct element_drzewa;
		for(i=0;i<26;i++)
		(*p)->licz[i]=licz[i];
		(*p) -> pozycja = pozycja;
		(*p) -> nast = NULL;
		(*p) -> lewy = (*p) -> prawy = NULL;

	}
	else
	{
		i=0;

		while (((*p) -> licz[i]) == (licz[i]))      //porownywanie nowo wczytanej tablicy
			i++;			                             //z tablicami zawartymi w drzewie
		if(i != 26)                                 //jezeli liczniki sa rowne sprawdza nastepne
		{
			if( ((*p)->licz[i]) > (licz[i]) )        //jezeli nowo wczytany jest mniejszy idzie do lewego syna
				add(&(*p)->lewy,licz,pozycja);        //jezeli wiekszy do prawego
			if( ((*p)->licz[i]) < (licz[i]) )
				add(&(*p)->prawy,licz,pozycja);
		}
			else
			{
				if((*p)->nast != NULL)                 //przechodaenie listy az do ostatniego elementu
				{
					nr1=(*p)->nast;
					while(nr1->nast!=NULL)
					nr1=nr1->nast;
				}
			nr2=new struct lista;                      //wprowadzenie nowego elementu do listy
			for(i=0;i<26;i++)
			nr2->licz[i]=licz[i];
			nr2->pozycja=pozycja;
			nr2->nast=NULL;

			if((*p)->nast == NULL)
				(*p)->nast=nr2;
			else
				nr1->nast=nr2;

			}
	}
}

void inorder(FILE *we,FILE *wy,struct element_drzewa *p)    //przechodzenie drzewa
{
	struct lista *anag;
	if(p != NULL)
	{
		inorder(we,wy,p->lewy);

		if((p->nast) != NULL)
		{
			fputs("Slowa nalezace do grupy anagramow :",wy);
			fputs("\n\n",wy);
			out(we,wy,p->pozycja);

			anag=p->nast;
			while(anag != NULL)
			{
				out(we,wy,anag->pozycja);
				anag=anag->nast;
			}
		  fputs("\n",wy);
		}
		inorder(we,wy,p->prawy);


	}
}

void out(FILE *we,FILE *wy,long p)      //wpisywanie anagramow do pliku wyjsciowego
{
	char zn;
			 fseek(we,p,SEEK_SET);
			 while(((zn=fgetc(we))!= EOF)&&((zn>=97)&&(zn<=122)))
			 fputc(zn,wy);fputs("\n",wy);
}
