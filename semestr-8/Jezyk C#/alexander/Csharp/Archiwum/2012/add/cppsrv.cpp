#include <iostream>
#include <winsock2.h>
using namespace std;

unsigned short portSerwera=3336;
const int dlugoscKolejki=100;

int main(int n,char *p[])
  {
   WSAData ws;
   if(WSAStartup(0x101,&ws)!=0)
     {
      cerr<<"WSAStartup failed."<<endl;
      return 1;
     }

   int    gniazdkoNasluchujace=socket(PF_INET,SOCK_STREAM,0);
   sockaddr_in    adresSerwera;
   memset(&adresSerwera,0,sizeof(adresSerwera));
   adresSerwera.sin_family=PF_INET;
   adresSerwera.sin_addr.s_addr=htonl(INADDR_ANY);
   adresSerwera.sin_port=htons(portSerwera);
   bind(gniazdkoNasluchujace,(sockaddr*)&adresSerwera,sizeof(adresSerwera));
   listen(gniazdkoNasluchujace,dlugoscKolejki);
   cout<<"Gotowy"<<endl;
   for(;;)
     {
      sockaddr_in    adresKlienta;
      int    len=sizeof(adresKlienta),gniazdkoPolaczeniowe=accept(gniazdkoNasluchujace,(sockaddr*)&adresKlienta,&len);
      cout<<"Polaczenie z IP "<<inet_ntoa(adresKlienta.sin_addr)<<": "<<ntohs(adresKlienta.sin_port)<<endl;
      double argument;
      recv(gniazdkoPolaczeniowe,(char*)&argument,sizeof(double),0);
      cout<<"Pytanie "<<argument<<endl;
      double    wynik=argument*2;
      send(gniazdkoPolaczeniowe,(char*)&wynik,sizeof(double),0);
      cout<<"odpowiedz "<<wynik<<endl;
         closesocket(gniazdkoPolaczeniowe);
     }
   closesocket(gniazdkoNasluchujace);
   WSACleanup();
   return 0;
  } 
