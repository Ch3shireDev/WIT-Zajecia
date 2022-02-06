#include <iostream.h>

int min(int a,int  b)
{
if(a<b) return a;else return b;
}

const int n=7;

int G[n][n];

void init(int g[n][n])
{
for(int i=0;i<n;i++)
   for(int j=0;j<n;j++)
		g[i][j]=10000; // nieskonczonoœæ...
}

void zeruj(int g[n][n])
{
for(int i=0;i<n;i++)
	for(int j=0;j<n;j++)
		g[i][j]=0;
}

void floyd(int g[n][n])
{
for(int k=0;k<n;k++)
  for(int i=0;i<n;i++)
    for(int j=0;j<n;j++)
      g[i][j]=min( g[i][j], g[i][k]+g[k][j]);
}


void main()
{
int i,j;

init(G);

G[0][0]=0;G[1][1]=0;G[2][2]=0;G[3][3]=0;G[4][4]=0;G[5][5]=0;


G[0][3]=30; G[0][1]=10;

G[1][2]=15;
G[1][4]=40;

G[2][3]=5;
G[2][4]=20;

G[4][5]=20;
G[4][6]=10;

G[5][6]=5;

G[6][3]=25;





floyd(G);

for(i=0;i<n;i++)
   for(j=0;j<n;j++)
     {
     if(G[i][j]==10000) cout << i << "  <-->  " << j << "[drogi nie ma]\n";else
     if(i!=j) cout << i << "  <-->  " << j << "="<<G[i][j]<<endl;
     }
                       


}



