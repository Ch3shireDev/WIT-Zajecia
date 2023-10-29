#include <iostream.h>
#include <conio.h>
#include<stdio.h>
int n,k,a;
long double x=1;

long double silnia(int n)
{ if(n==0)
return 1;
else
return n*silnia(n-1);
};

long double silniaiter(int n)
{ x=1;
for(a=1;a<=n;a++)
{ x=x*a;
};
return x;
}

main()
{ 
cout<<"Podaj liczbe: "; cin>>n;
cout<<"Silnia z liczby "<<n<<" liczona rekurencyjnie wynosi "<<silnia(n);
cout<<"\n";
cout<<"Silnia z liczby "<<n<<" liczona iteracyjnie wynosi "<<silniaiter(n);
while(!kbhit());

cout<<"Obliczanie symbolu Newtona\n\n";
cout<<"Podaj n: "; cin>>n;
cout<<"Podaj k: (k<n) "; cin>>k;
if(k>n)
{ cout<<"k jest wieksze od n !";
while(!kbhit());
return 0;
};
cout<<"Wartosc symbolu Newtona liczona rekurencyjnie wynosi: "<<silnia(n)/(silnia(k)*silnia(n-k));
cout<<"\nWartosc symbolu Newtona liczona iteracyjnie wynosi: "<<silniaiter(n)/(silniaiter(k)*silniaiter(n-k));
while(!kbhit());
return 0;
};

