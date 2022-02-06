#include<malloc.h>
#include<stdio.h>
#include<conio.h>

struct wezel
{ char litera;
  int  dzieci;
  struct wezel *left, *right;
};

void add(struct wezel * *, char);
void inorder(struct wezel *);
void dzieci(struct wezel *);
void treeprint(struct wezel *,int);
char searchk(struct wezel *,int);
int  searchrek(struct wezel *,char);
int  searchiter(struct wezel *,char);
int  ranga(struct wezel *,char);
int  wysokosc(struct wezel *);
int  liscie(struct wezel *);

void main()
{ struct wezel *korzen=NULL;
  char zn;
  int x,i,temp;
  clrscr();

  while((zn=getche()) !=13)  add(&korzen,zn);

  printf("\n\n");
  treeprint(korzen,0);
  printf("\n");
  inorder(korzen);
  x=korzen->dzieci;
  printf("\n");
  for(i=1;i<x+1;i++) printf("%c,",searchk(korzen,i));

  printf("\n%d  %d\n", wysokosc(korzen), liscie(korzen));
  printf("\n");
  zn=getche();
  while(zn!='0')
   { if(searchrek(korzen,zn)==1) printf("   jest\n");
     else                        printf("   brak\n");

     zn=getche();
   }

  printf("\n");
  zn=getche();
  while(zn!='0')
   { if(searchiter(korzen,zn)==1) printf("   jest\n");
     else                         printf("   brak\n");

     zn=getche();
   }

  printf("\n");
  zn=getche();
  while(zn!='0')
    {temp=ranga(korzen,zn);
     if(temp!=-1)
      {
       printf("\n\n");
       treeprint(korzen,0);
       printf("ranga(%c)=%d\n\n",zn,temp);
      }
     else printf("\nbrak");
     zn=getche();

    }


  printf("\n");
  inorder(korzen);
  printf("\n");
  dzieci(korzen);
  getch();


}

void add(struct wezel * * p, char w)
{
  if((*p)==NULL)
   { (*p) = new struct wezel;
     (*p) -> litera = w;
     (*p) -> left   = (*p) -> right = NULL;
     (*p) -> dzieci = 1;
   }
  else
   {((*p)->dzieci)++;
    if((*p)->litera > w) add(&((*p)->left),w);
    else                 add(&((*p)->right),w);
   }
}

void dzieci(struct wezel *p)
{ if(p!=NULL)
   { dzieci(p->left);
     printf("%d,",p->dzieci);
     dzieci(p->right);
     free(p);
   }
}


void inorder(struct wezel *p)
{ if(p!=NULL)
   { inorder(p->left);
     printf("%c,",p->litera);
     inorder(p->right);
   }
}

char searchk(struct wezel *p,int k)
{ struct wezel *l,*r;
  char pom;
  int temp;
  if(p!=NULL)
   { l=p->left; r=p->right;
     if(l==NULL && r==NULL)   pom=p->litera;
     else 
       {if(l!=NULL)
	     { temp=(l->dzieci)+1;
          if(k==temp)         pom=p->litera;
	       else if(k< temp)    pom=searchk(l,k);
		         else if(r!=NULL && k>temp)
				                  pom=searchk(r,k-temp);
	     }
	     else if(k==1)         pom=p->litera;
		       else if(r!=NULL) pom=searchk(r,k-1);
	  }
    }
   return(pom);
}

void treeprint(struct wezel *p,int k)
{ if(p!=NULL)
   { treeprint(p->right,k+1);
     for(int i=0;i<k;i++) printf(" ");
     printf("%c\n",p->litera);
     treeprint(p->left,k+1);
   }
}

int searchrek(struct wezel *p,char zn)
{ int pom;
  if(p==NULL) pom=0;
  else
   if((p->litera)==zn) pom=1;
   else
    {
     if((p->litera)>zn) pom=searchrek(p->left,zn);
     else               pom=searchrek(p->right,zn);
    }
  return pom;
}

int searchiter(struct wezel *p,char zn)
{int pom=0;
  while(p!=NULL)
   { if((p->litera)==zn)
       { pom=1;
	 p=NULL;
       }
     else
      {
       if((p->litera)>zn) p=p->left;
       else               p=p->right;
      }
   }
  return pom;
}



int ranga(struct wezel *p,char zn)
{int pom=0;
 int flaga=0;

  while(p!=NULL)
   { if((p->litera)==zn)
       { if((p->left)!=NULL) pom=pom+((p->left)->dzieci);
	      p=NULL;
	      flaga=1;
       }
     else
       {
         if((p->litera)>zn) p=p->left; 
         else
	      { 
           if((p->left)!=NULL) pom=pom+((p->left)->dzieci);
           pom = pom+1;
	        p=p->right;
	      }
       }
   }

  if(flaga) return pom;
  else      return -1;
}

int wysokosc(struct wezel *p)
{  int a,b;
	if(p==NULL) return 0;
	else{ a=wysokosc(p->left);
          b=wysokosc(p->right);
          if(a < b)  return b + 1;
		   else   	 return a + 1;
       }  
}

int liscie(struct wezel *p)
{
  if(p==NULL) return 0;
  else  if(p->left == p->right) 
	          return 1;
        else  return liscie(p->left) + liscie(p->right);
}
