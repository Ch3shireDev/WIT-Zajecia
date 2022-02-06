#include<iostream.h>
#include<iomanip.h>
#include<ctype.h>
#include<conio.h>

struct node 
{ int num, bal;
  struct node *pLeft, *pRight; 
};

class AVLtree{

 public:
   AVLtree(): root(NULL) {}
   void insert(int x)  { ins(root, x); }
   void DelNode(int x) { del(root, x); }
   void print() const  { pr(root, 0);  }

 private:
   node *root;
   void LeftRotate(node* &p);
   void RightRotate(node* &p);
   int ins(node* &p, int x);
   int del(node * &, int x);
   void pr(const node *p, int nSpace) const;

};

void AVLtree::LeftRotate(node * &p)
{ node *q = p;
  p = p -> pRight;
  q -> pRight = p -> pLeft;
  p -> pLeft  = q;
  q -> bal--;
  if(p -> bal > 0) q -> bal -= p -> bal;
  p -> bal--;
  if(q -> bal < 0) p -> bal += q -> bal;
}

void AVLtree::RightRotate(node* &p)
{ node *q = p;
  p = p -> pLeft;
  q -> pLeft  = p -> pRight;
  p -> pRight = q;
  q -> bal++;
  if(p -> bal < 0) q ->bal -= p-> bal;
  p -> bal++;
  if(q -> bal > 0) p-> bal += q -> bal;
}

int AVLtree::ins(node* &p, int x)
{ int deltaH = 0;
  if(p ==NULL)
  { p = new node;
    p -> num = x;
    p -> bal = 0;
    p -> pLeft = p ->pRight = NULL;
    deltaH = 1;
  }else
    if(x > p -> num)
    { if(ins(p -> pRight, x))
      { p -> bal ++;
        if(p -> bal == 1) deltaH = 1; 
        else 
         if(p -> bal == 2)
         { if(p -> pRight -> bal == -1)
             RightRotate(p -> pRight);
           LeftRotate(p);
         }
       }
    } 
    else 
    if(x < p -> num)
    { if(ins(p -> pLeft, x))
      { p -> bal --;
        if(p -> bal == -1) deltaH = 1; 
        else 
         if(p -> bal == -2)
         { if(p -> pLeft -> bal == 1)
             LeftRotate(p -> pLeft);
           RightRotate(p);
         }
       }           
     }

     return deltaH;
}  
int AVLtree::del(node* &p, int x)
{ node **qq, *p0;
  int deltaH = 0;
  if(p ==NULL) return 0;
  if(x < p -> num)
  { if(del(p -> pLeft, x))
      { p -> bal ++;
        if(p -> bal == 0) deltaH = 1; 
        else 
         if(p -> bal == 2)
         { if(p -> pRight -> bal == -1)
             RightRotate(p -> pRight);
           LeftRotate(p);
           if(p -> bal == 0) deltaH = 1;
         }
       }
    } 
    else 
    if(x > p -> num)
    { if(del(p -> pRight, x))
      { p -> bal --;
        if(p -> bal == 0) deltaH = 1; 
        else 
         if(p -> bal == -2)
         { if(p -> pLeft -> bal == 1)
             LeftRotate(p -> pLeft);
           RightRotate(p);
           if( p -> bal == 0) deltaH = 1;
         }
       }           
     } 
     else
     { if(p -> pRight == NULL)
       { p0= p; p = p -> pLeft;
         delete p0; return 1;
       }
       else
        if(p -> pLeft == NULL)
        { p0 = p;  p = p -> pRight;
          delete p0; return 1;
        } 
        else  
        { qq = &p -> pLeft;
          while((*qq) -> pRight != NULL) qq = &(*qq) -> pRight;
          p -> num = (*qq) -> num;
          (*qq) -> num =x;
          if(del(p -> pLeft, x))
          { p -> bal ++;
            if(p -> bal == 0) deltaH = 1; 
            else 
            if(p -> bal == 2)
            { if(p -> pRight -> bal == -1)  RightRotate(p -> pRight);
              LeftRotate(p);
              if(p -> bal == 0) deltaH = 1;
         }
       }
    }  
  }
  return deltaH;
}  

void AVLtree::pr(const node *p, int nSpace) const
{
  if(p!=NULL)
  { pr(p -> pRight, nSpace+= 6);
    cout << setw(nSpace) << "(" << p -> num << "," << p -> bal << ")" << endl;
    pr(p -> pLeft, nSpace);
  }
}	

int main()
{ AVLtree t;
  for(int i=0; i<20; i++) t.insert(i);
  t.print();
  getch();
  cout << endl << endl << endl;
  for(int i=0; i<10; i++) t.DelNode(2*i);
  t.print();
  getch();
  return 0;
}
   