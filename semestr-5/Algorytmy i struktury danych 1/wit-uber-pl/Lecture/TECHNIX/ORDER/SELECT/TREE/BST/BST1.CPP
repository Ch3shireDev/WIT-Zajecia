#include<malloc.h>
#include<stdio.h>
#include<conio.h>

struct wezel
{ char litera;
  struct wezel *left, *right;
};

void add(struct wezel * *, char);
void inorder(struct wezel *);
void clean(struct wezel **);
void treeprint(struct wezel *,int);
int  searchrek(struct wezel *,char);
int  searchiter(struct wezel *,char);


int main()
{ 
  struct wezel *korzen=NULL;
  char zn;
  
  while((zn=getche()) !=13)  add(&korzen,zn);

  printf("\n\n");
  treeprint(korzen,0);
  printf("\n");

  inorder(korzen);
  printf("\n");
  

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
  clean(&korzen);
   
  return 1; 
}

void add(struct wezel ** p, char w)
{
  if((*p)==NULL)
   { (*p) = (struct wezel *)malloc(sizeof(struct wezel));
     (*p) -> litera = w;
     (*p) -> left   = (*p) -> right = NULL;
   }
  else
  
    if((*p)->litera > w) add(&((*p)->left),w);
    else                 add(&((*p)->right),w);
  
}

void clean(struct wezel **p)
{ if((*p)!=NULL)
   { clean(&((*p)->left));
     clean(&((*p)->right));
     free(*p);
   };
  (*p)=NULL; 
}


void inorder(struct wezel *p)
{ if(p!=NULL)
   { inorder(p->left);
     printf("%c,",p->litera);
     inorder(p->right);
   }
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


