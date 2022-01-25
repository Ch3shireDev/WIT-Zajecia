# Lab 1

## Ćwiczenie 1

Wyznaczyć reprezentację dziesiętną liczby dwójkowej 10011101001

## Ćwiczenie 2

Jaką największa liczbę można zapisać na k bitach?

## Ćwiczenie 3

Zamienić liczbę dziesiętną 125 na liczbę dwójkową.

## Ćwiczenie 4

Wypisać reprezentacje binarne kolejnych cyfr szesnastkowych

## Ćwiczenie 5

Ile razy więcej jest adresów IPv6 od adresów IPv4?

## Ćwiczenie 6

Podzielić sieć klasy C o adresie 213.135.45.0 na dwie równe części.

## Ćwiczenie 7

Podzielić sieć klasy C o adresie w.x.y.0 (192  w  223) na 4 równe części.

## Ćwiczenie 8

Utworzyć kolejne wiersze powyższej tabeli dla 8 i 16 podsieci.

## Ćwiczenie 9

Podzielić sieć klasy B o adresie 150.10.0.0/16 na 4 podsieci.

# Lab 2

## Zadanie 1

Podzielić sieć 200.10.5.0 na trzy jak najmniejsze podsieci w taki sposób, aby w pierwszej móc zaadresować 50, w drugiej 55, a w trzeciej 110 komputerów.

## Zadanie 2

Czy można tak podzielić sieć 200.10.5.0 na jak najmniejsze podsieci, aby w pierwszej z nich umieścić 50 komputerów, w drugiej 110, a w trzeciej 55?

## Zadanie 3

Wydzielić z sieci 200.10.5.0 trzy jak najmniejsze podsieci, tak aby w pierwszej umieścić 100, w drugiej 25, a w trzeciej 55 komputerów.

## Zadanie 4

Podzielić sieć 192.168.1.0 na 4 podsieci, tak aby w kolejnych podsieciach można było umieścić odpowiednio 100, 50, 25 i 20 komputerów

## Zadanie 5

Podzielić sieć 192.168.1.0 na 4 podsieci, tak aby w kolejnych podsieciach można było umieścić odpowiednio 100, 25, 50 i 20 komputerów

## Zadanie 6

Podzielić sieć klasy B o adresie 150.20.0.0 na 4 kolejne podsieci o rozmiarach 2^15, 2^14, 2^13 i 2^13.

## Zadanie 7

Czy można połączyć w sieć IP następujące 4 sieci klasy C?

200.10.0.0, 200.10.1.0, 200.10.2.0, 200.10.3.0

## Zadanie 8

Czy można połączyć w sieć IP następujące 4 sieci klasy C:

200.10.6.0, 200.10.7.0, 200.10.8.0, 200.10.9.0

## Zadanie 9

Czy następujące sieci klasy C można połączyć w sieć IP?

200.10.4.0, 200.10.5.0, 200.10.6.0, 200.10.7.0, 200.10.8.0, 200.10.9.0

## Zadanie 10

Czy następujące sieci klasy C można połączyć w sieć IP?

200.10.4.0, 200.10.5.0, 200.10.8.0, 200.10.9.0

## Zadanie 11

Czy blok adresów 200.10.5.0/21 jest siecią IP?

# Lab 3

## Wysyłanie danych z sieci IP

Przed wysłaniem danych stacja źródłowa sprawdza, czy adresat znajduje się w sieci lokalnej, czy w innej. W tym celu wykonuje operację nałożenia własnej maski na docelowy adres IP.

Jeśli wynik nałożenia JEST adresem sieci lokalnej, to adresat znajduje się w tej sieci.

Jeśli wynik NIE JEST adresem sieci lokalnej, to adresat znajduje się w innej sieci.

Adres sieci lokalnej jest wynikiem nałożenia własnej maski na własny adres IP.

Nałożenie maski na adres polega na pomnożeniu kolejnych bitów adresu przez kolejne bity maski.

# Lab 4

# Lab 5

## Zadanie 1

Obliczyć efektywną przepustowość segmentu sieci Ethernet o przepustowości nominalnej 100 Mb/s, jeśli przesyłane są w nim ramki o długości pola danych równej 500 B?

## Zadanie 2

Jaka jest efektywna przepustowość segmentu sieci Ethernet o przepustowości nominalnej 100 Mb/s, jeśli przesyłane są w nim ramki o największej dopuszczalnej długości pola danych?

## Zadanie 3

Policzyć algorytmem CRC sumę kontrolną ciągu 101010010110 przy zastosowaniu klucza generującego 1011

## Zadanie 4

Obliczyć algorytmem CRC sumę kontrolną ciągu 1100101101 przy zastosowaniu klucza 1001

## Zadanie 5

Policzyć algorytmem CRC sumę kontrolną ciągu 101011000110 przy zastosowaniu klucza generującego 1011

## Zadanie 4

W sieć Ethernet wysyłany jest pakiet IP z nagłówkiem o dług. 20 B i polem danych o dług. 5600 B. Przedstawić powstałe fragmenty zakładając, że mają być jak najdłuższe.

## Zadanie 5

Zapisać w postaci bitowej pole Offset trzeciego fragmentu z poprzedniego zadania.

# Lab 6

## Zadanie 1:

W łącze obsługiwane przez protokół PPP (MTU=296) wysyłany jest pakiet IP z nagłówkiem bez pola opcji (nagłówek ma 20 B) i polem danych o dług. 1000 B. Przedstawić na rysunku i w standardowym zapisie powstałe fragmenty przy założeniu, że wszystkie oprócz ostatniego mają maksymalną długość.

## Zadanie 2

Wypisać zawartość pola Offset trzeciego fragmentu z Zad. 1

## Zadanie 3

W łącze telekomunikacyjne obsługiwane przez protokół X.25 (MTU = 576) wysyłany jest segment TCP z 20-bajtowym nagłówkiem i polem danych o dług. 2100 B. Segment ten znajduje się w pakiecie IP z 20-bajtowym nagłówkiem. Przedstawić na rysunku i w standardowym zapisie powstałe fragmenty przy założeniu, że wszystkie oprócz ostatniego mają maksymalną długość.

# Lab 7

## Polecenie

```
ping  -R  <komp. docelowy>  (Linux)
```

albo

```
ping  -r 9  <komp. docelowy>  (Windows)
```

zapisuje trasę tam i z powrotem w POLU OPCJI nagłówka IPv4. W tym celu wykorzystywana jest opcja zapisu trasy (ang. Record Route). Ponieważ w pierwszym słowie pola opcji jest zapisany kod opcji, a pole opcji ma maksymalnie 40 bajtów, więc zostaje tam miejsce na 9 adresów IPv4. Z tego powodu nie da się tam zapisać całej trasy, jeśli jest zbyt długa.

Zapisywane są adresy interfejsów, przez które pakiet OPUSZCZA kolejne komputery na swojej trasie (oprócz komp. źródłowego i docelowego są to routery), przy czym Linux zapisuje jako pierwszy adres interfejsu źródłowego, a Windows - adres pierwszego routera.

## Ćwiczenie 1

Wydaj polecenie ping –R (Linux) albo ping –r 9 (Windows) do komputera wskazanego przez prowadzącego i zanotuj adresy kolejnych routerów na trasie tam i z powrotem. Następnie wydaj polecenie traceroute (Linux) lub tracert (Windows) z tym samym adresem docelowym i zanotuj adresy kolejnych routerów na trasie tam. Na podstawie uzyskanych danych postaraj się zbudować mapę środowiska sieciowego, w którym były przesyłane pakiety generowane przez powyższe polecenia.

```
ping –r 9 –n 1 wp.pl (Windows)
```

## Aplikacja Wireshark

Służy ona do analizy ruchu sieciowego przechodzącego przez lokalny interfejs sieciowy. Działa w trybie graficznym i prezentuje ramki wysyłane i odbierane na wskazanym interfejsie. Jeśli jest włączony tryb mieszany (promiscuous mode), to prezentowane są wszystkie ramki odbierane przez dany interfejs, a nie tylko ramki do niego zaadresowane i rozgłoszeniowe.
(Interfejs sieciowy może odbierać ramki zaadresowane do innego interfejsu, jeśli, na przykład, jest przyłączony do koncentratora, a nie do przełącznika). Ramki są prezentowane w podziale na poszczególne warstwy modelu OSI. Żeby przechwytywać tylko ramki spełniające określone kryteria, należy użyć filtru przechwytywania. Filtr taki wpisujemy w następujące pole: 

Przechwytuj -> Opcje -> Zakładka Wejście -> Filtr przechwytywania

Należy przy tym pamiętać, żeby zaznaczyć właściwy interfejs na liście. Filtr przechwytywania jest pewnym wyrażeniem logicznym składającym się z wyrażeń elementarnych (primitives) połączonych operatorami and, or, not.

Przykłady wyrażeń elementarnych:

host w.x.y.z <- adresem IP komp. źródłowego albo docelowego jest w.x.y.z (ramka nie musi zawierać pakietu IP, np. może być ramką ARP)

src host w.x.y.z <- adresem IP komputera źródłowego jest w.x.y.z (ramka nie musi zawierać pakietu IP)

dst host w.x.y.z <- adresem IP komputera docelowego jest w.x.y.z (ramka nie musi zawierać pakietu IP)

ip host w.x.y.z <- adresem IP komp. źródłowego albo docelowego jest w.x.y.z, a ramka musi zawierać pakiet IP

ip src host w.x.y.z <- adresem IP komp. źródłowego jest w.x.y.z, a ramka musi zawierać pakiet IP

ip dst host w.x.y.z <- adresem IP komp. docelowego jest w.x.y.z, a ramka musi zawierać pakiet IP

arp albo ether proto \arp <- ramka (Ethernet) z komunikatem ARP (request albo reply)

ip albo ether proto \ip <- ramka (Ethernet) z pakietem IP

icmp albo ip proto \icmp <- pakiet IP z komunikatem ICMP

ip[2:3]=0xab01c2 <- ramka musi zawierać pakiet IP, a bajty 3, 4 i 5 są odpowiednio równe ab, 01

i c2; bajty nagłówka danego protokołu (w tym przypadku IP) są numerowane od zera, więc bajt

o numerze 2 jest trzecim bajtem nagłówka.

tshark - tekstowa wersja Wireshark (prezentacja ramek w trybie tekstowym w mało czytelny

sposób)

tcpdump - analizator ruchu sieciowego działający w trybie tekstowym

man tcpdump - opis polecenia tcpdump w podręczniku man; składnia filtrów przechwytywania

w Wireshark pochodzi z tcpdump

# Lab 8

## Analiza ruchu na lokalnej karcie sieciowej z użyciem analizatora Wireshark

Symbol A oznacza stację lokalną z Wireshark na Windows, a symbol B – stację zdalną.

1. Analiza ramek generowanych przez protokół ARP

Filtr przechwytywania:

host <adres stacji A> and host <adres stacji B> and arp

Polecenie wydane na stacji B (Linux):

arping –c1 <adres stacji A>

2. Analiza ramek generowanych przez polecenia śledzenia trasy pakietów

Filtry przechwytywania dla polecenia tracert (polecenie systemu Windows generujące

komunikaty echo request, po 3 komunikaty na każde TTL):

Polecenie wydane na stacji A (Windows):

tracert –d –4 fedora.pl

Filtr przepuszczający tylko komunikaty "echo request" wysyłane ze stacji A do stacji B:

src host <adres IP stacji A> and dst host <adres IP stacji B> and icmp[0:1]=0x08

Filtr przepuszczający tylko komunikaty "TTL exceeded"

wysyłane z kolejnych routerów (adresy nieznane) do stacji A

i komunikaty "echo reply" wysyłane ze stacji B do stacji A:

( dst host <adres stacji A> and icmp[0:1]=0x0b ) or

( src host <adres stacji B> and dst host <adres stacji A> and icmp[0:1]=0x00 )

## Filtr przechwytywania dla polecenia ping –r 9 –n 1 (polecenie systemu Windows generujące

jeden komunikat echo request z opcją zapisu 9 etapów trasy tam i z powrotem):

host <adres stacji A> and host fedora.pl and ( icmp[0:1]=0x08 or icmp[0:1]=0x00 )

3. Analiza fragmentacji

Na stacji B (Linux) przestawiamy MTU na 296:

ip link set mtu 296 dev <nazwa interfejsu sieciowego>

Na stacji B (Linux) wydajemy polecenie generujące komunikat "echo request",

w którym za nagłówkiem ICMP jest 1000 oktetów danych:

ping -c1 -s1000 <adres stacji A>

Filtr przepuszczający pofragmentowane komunikaty "echo request"

wysłane ze stacji B (Linux) do stacji A:

src host <adres stacji B> and dst host <adres stacji A> and ip[9:1]=1

Przy analizowaniu przechwyconych ramek należy zwrócić uwagę na to, że w polu Protocol

nagłówka IP każdego fragmentu jest kod protokołu ICMP, czyli liczba 1, natomiast nagłówek

ICMP znajduje się tylko w pierwszym fragmencie. Z tego względu w wyrażeniu filtrującym jest

warunek, aby 10 oktet nagłówka IP (pole „protokół”) miał wartość 1, ale nie ma warunku, aby w

ramce był komunikat ICMP „echo request”, bo taki filtr przepuściłby tylko pierwszy fragment, a

zatrzymał pozostałe.

Uwaga: opcja Edit -> Preferences -> Protocols -> IPv4 -> Reassemble fragmented IPv4 datagrams

ma być niezaznaczona! W przeciwnym przypadku do ostatniego fragmentu zostanie dołączony

cały pakiet, co znacznie utrudni analizę tego fragmentu.

# Lab 9

## Funkcje protokołu TCP (powtórzenie z wykładu)

- dostarczenie danych do aplikacji określonej w polu „port docelowy”

- zapewnienie niezawodnej transmisji danych; segmenty docierają wszystkie, bez powtórzeń

  i w takiej kolejności w jakiej zostały wysłane

  (numerowanie segmentów w polu SeqNo i potwierdzanie ich odbioru w polu AckNo)

- zapewnienie integralności danych; dane docierają do odbiorcy w niezmienionej postaci

  (pole suma kontrolna)

- kontrola przepływu (ang. flow control), czyli dostosowanie tempa nadawania do tempa

  przetwarzania odbiorcy

  (pole Window informujące, ile jest wolnego miejsca w buforze odbiorcy)

Protokół TCP realizuje tzw. transmisję strumieniową, tzn. od nadawcy do odbiorcy płynie

strumień danych podzielony na segmenty. Strumień to przesyłany w sieci ciąg bajtów

pewnego zbioru danych, w którym nie ma ubytków, powtórzeń ani zmiany kolejności.

Strumień jest identyfikowany losowo generowanym numerem x.

Pierwszy bajt w strumieniu ma numer x+1.

Segmenty nie są numerowane kolejnymi liczbami całkowitymi, tylko numerami pierwszych

bajtów w kolejnych segmentach, tak jak na rysunku:

x+1 x+101 x+301

------------|------------------------|-------- ...

100 B 200 B

SeqNo(1) = x+1, SeqNo(2) = x+101, SeqNo(3) = x+301, ...

1,2,… - numery porządkowe kolejnych segmentów

SeqNo(1), SeqNo(2),… - numery sekwencyjne kolejnych segmentów

Reguła numerowania segmentów:

Nr sekw. segmentu n+1 = Nr sekw. segmentu n + Liczba bajtów danych w segmencie n

SeqNo(n+1) = SeqNo(n) + LB(n), gdzie n1

## Reguła potwierdzania segmentów:

Odebranie segmentu o numerze porządkowym n jest potwierdzane przez wysłanie w polu

AckNo numeru sekwencyjnego (SeqNo) segmentu o numerze porządkowym n+1, czyli

AckNo(n) = SeqNo(n+1)

Inaczej, numer potwierdzenia jest numerem sekwencyjnym segmentu następnego po

segmencie potwierdzanym.

Obowiązuje zasada kumulacji potwierdzeń, tzn. potwierdzając odbiór segmentu n odbiorca

potwierdza zarazem odbiór wszystkich poprzednich n–1 segmentów. Z tej zasady wynika, że

nie jest konieczne potwierdzanie każdego segmentu osobno, można potwierdzać co któryś

segment.

Obserwacja ruchu sieciowego generowanego przez aplikację echo działającą na bazie TCP

Uruchamianie serwera aplikacji echo (Linux):

systemctl status iptables <- sprawdzenie czy mechanizm iptables jest aktywny

systemctl stop iptables <- wyłączenie iptables

systemctl status xinetd <- sprawdzenie czy jest uruchomiony xinetd

systemctl start xinetd <- uruchamianie xinetd (tylko jeśli powyższe polecenie wykaże

nieaktywność)

cd /etc/xinetd.d <- przejście do katalogu z plikami konfig. usług kontrolowanych przez xinetd

ls <- wypisanie zawartości katalogu (bez plików ukrytych)

less echo-stream <- sprawdzanie czy serwer usługi echo jest aktywny (disable = no)

Jeśli serwer echo jest nieaktywny (disable = yes), to trzeba zmienić yes na no

i przeładować xinetd poleceniem systemctl reload xinetd.

Przygotowanie Wireshark do przechwytywania ramek aplikacji echo:

filtr przechwytywania: host <adres klienta> and host <adres serwera> and tcp port 7

włączenie przechwytywania: Capture -> Start

## Uruchamianie klienta echo i wysyłanie danych z systemu Windows do serwera (Linux):

PuTTY -> wpisać adres serwera, Port 7, Connection Type Raw, Open

Wpisać krótki tekst (ala ma kota) i wcisnąć Enter

Tekst zostaje powtórzony w następnej linii

Zamknąć okno PuTTY

Wireshark powinien przechwycić 12 ramek

Analiza przechwyconych ramek:

Etap 1 - otwieranie (wirtualnego) połączenia TCP:

1. Klient żąda otwarcia połączenia TCP

   klient -> serwer: SrcPort=<losowy>, DstPort=7, SYN, SeqNo=x

   (x to identyfikator strumienia danych wysyłanych od klienta do serwera)

2. Serwer wyraża zgodę na otwarcie połączenia TCP

   serwer -> klient: SrcPort=7, DstPort=<losowy>, SYN, SeqNo=y, ACK, AckNo=x+1

   (y to identyfikator strumienia danych wysyłanych od serwera do klienta)

3. Klient potwierdza odebranie zgody

   klient -> serwer: SeqNo=x+1, ACK, AckNo=y+1

Uwaga: Odebranie segmentu z flagą SYN jest potwierdzane przez wysłanie w polu AckNo

        wartości SeqNo(segment potwierdzany) + 1

Etap 2 - utrzymywanie połączenia/transmisja danych:

4. Klient wysyła 1-szą porcję danych do serwera:

   klient -> serwer: SeqNo=x+1, 11 bajtów danych, ACK, AckNo=y+1

5. Klient wysyła Enter (0x0d0a) do serwera:

   klient -> serwer: SeqNo=x+12, 2 bajty danych, ACK, AckNo=y+1

6. Serwer potwierdza odebranie 1-szej porcji danych od klienta

   serwer -> klient: SeqNo=y+1, 0 bajtów danych, ACK, AckNo=x+12

7. Serwer potwierdza odebranie Enter od klienta

   serwer -> klient: SeqNo=y+1, 0 bajtów danych, ACK, AckNo=x+14

8. Serwer wysyła echo 1-szej porcji danych i Enter do klienta

   serwer -> klient: SeqNo=y+1, 13 bajtów danych, ACK, AckNo=x+14

## 9. Klient potwierdza odebranie echa od serwera

    klient -> serwer: SeqNo=x+14, 0 bajtów danych, ACK, AckNo=y+14

Numery sekwencyjne segmentów nie są kolejnymi liczbami całkowitymi,

tylko numerami pierwszych bajtów kolejnych segmentów,

więc numer sekwencyjny następnego segmentu to numer sekwencyjny poprzedniego

plus liczba bajtów danych w poprzednim segmencie, czyli SeqNo(n+1)=SeqNo(n)+LB(n)

Potwierdzenie odebrania segmentu od jego nadawcy polega na wysłaniu w polu AckNo

numeru sekwencyjnego następnego segmentu spodziewanego ze strony nadawcy.

Można to zapisać następująco:

AckNo(n) = SeqNo(n+1),

gdzie n oznacza n-ty odebrany segment,

AckNo(n) jest numerem wysyłanym w polu AckNo dla potwierdzenia odbioru n-tego

segmentu,

SeqNo(n+1) oznacza numer sekwencyjny jeszcze nieodebranego (n+1)-go segmentu.

Zamykanie połączenia:

10. Klient wysyła żądanie zamknięcia połączenia:

    klient -> serwer: SeqNo=x+14, 0 bajtów danych, FIN, ACK, AckNo=y+14

11. Serwer potwierdza odebranie żądania zamknięcia połączenia i akceptuje je:

    serwer -> klient: SeqNo=y+14, 0 bajtów danych, FIN, ACK, AckNo=x+15

12. Klient potwierdza odebranie akceptacji

    klient -> serwer: SeqNo=x+15, 0 bajtów danych, ACK, AckNo=y+15

Uwaga: Odebranie segmentu z flagą FIN jest potwierdzane przez wysłanie w polu AckNo

        wartości SeqNo(segment potwierdzany) + LB(segment potwierdzany) + 1

        (tak samo jest potwierdzane odebranie segmentu z flagą SYN)

# Lab 10

## Zadania na temat działania protokołu TCP

Załóżmy, że numer strumienia danych (losowo generowany Initial Sequence Number wysyłany

w segmencie z flagą SYN) wysyłanych przez stronę A połączenia TCP jest równy 5000 i że strona

A wysłała do strony B 5 segmentów z polem danych o jednakowej długości 1460 B. Przedstawić

je na rysunku podając ich numery sekwencyjne. W jaki sposób strona B potwierdzi ich odbiór?

Podaj wartość odpowiedniej flagi i pola w nagłówku TCP segmentu z potwierdzeniem.

5001 6461 7921 9381 10841

|--------------|--------------|--------------|--------------|--------------|

Strona B potwierdzi odbiór pierwszych 5 segmentów wysyłając w polu AckNo numer

sekwencyjny 6 segmentu wynoszący 10841+1460=12301

Flaga ACK=1

Pole AckNo=12301

Załóżmy że strona B wysłała do strony A segment z numerem potwierdzenia (AckNo) równym

12301 i wartością 6000 w polu Window. Ile segmentów (począwszy od pierwszego

niepotwierdzonego) z polem danych 1460 B może wysłać A do B przed odebraniem kolejnego

potwierdzenia od B? Przedstawić je na rysunku podając ich numery sekwencyjne (SeqNo).

Liczba segmentów =  Window/Długość segmentu  =  6000/1460  = 4

Kolejne segmenty w oknie:

12301 13761 15221 16681

|--------------|--------------|--------------|--------------|

Podstawowym wzorem używanym w powyższych zadaniach jest

SeqNo(n+1) = SeqNo(n) + Liczba_Bajtów(n)

## Dodawanie własnej aplikacji sieciowej do uruchamianych przez xinetd

1. Na serwerze do katalogu /etc/xinetd.d dodać plik o nazwie np. rozmowa i następującej

zawartości:

service mytalk

{

disable = no

user = root

wait = no

socket_type = stream

server = /usr/bin/tail

server_args = -f /tmp/tekst

}

mytalk jest nazwą usługi, którą trzeba powiązać z numerem portu jej serwera

w pliku /etc/services;

Uwaga: nazwa pliku (rozmowa) nie musi być taka sama jak nazwa usługi (mytalk)

2. Na serwerze do pliku /etc/services dopisać na końcu linię:

mytalk 65535/tcp

np. wydać polecenie echo mytalk 65535/tcp >> /etc/services

Uwaga 1: Użyć podwójnego znaku większości! Użycie pojedynczego spowoduje

usunięcie dotychczasowej zawartości pliku!

Uwaga 2: Nazwa usługi (mytalk) musi być taka sama jak w jej pliku konfiguracyjnym w katalogu

/etc/xinetd.d

## 3. Na serwerze wydać polecenia:

systemctl stop iptables

systemctl reload xinetd

tee -a /tmp/tekst 1>/dev/null

polecenie tee przepisuje standardowe wejście (deskryptor 0)

do standardowego wyjścia (deskryptor 1)

i dodatkowo do pliku określonego opcją -a

4. Na kliencie (Linux) wydać polecenie:

```
telnet <adres serwera> 65535
```

albo na kliencie (Windows) w oknie PuTTY wpisać IP lub nazwę serwera, Port: 65535 oraz Connection type: Raw

Po wykonaniu tych czynności linia tekstu wpisanego z klawiatury na serwerze zostanie, po wciśnięciu Enter, zapisana do pliku /tmp/tekst.

Usługa mytalk, korzystając z tego, że polecenie tail z opcją -f /tmp/tekst prezentuje na bieżąco zmiany w pliku /tmp/tekst, wyśle do klienta dopisaną do tego pliku linię tekstu.

Używając aplikacji Wireshark przeanalizuj segmenty przesyłane między klientem a serwerem usługi mytalk. Zastosuj w tym celu następujący filtr przechwytywania:

```
host <IP_klienta> and host <IP_serwera> and tcp port 65535
```

Zaobserwuj jak przebiega etap zamknięcia połączenia kiedy zamyka je klient (Windows – zamknięcie okna, Linux – wciśnięcie Ctrl-]) oraz kiedy zamyka je serwer (systemctl stop xinetd).

# Lab 11

## Diagnostyka protokołów TCP i UDP

netstat -t <- wypisuje aktywne połączenia tcp (przychodzące i wychodzące) podając nazwy komputerów i portów w kolumnach „Local Address” i „Foreign Address”

netstat -tn <- wypisuje aktywne połączenia tcp (przychodzące i wychodzące) podając adresy komputerów i numery portów w powyższych kolumnach

Powyższe polecenia nie wypisują nasłuchujących serwerów tcp

netstat -lt <- wypisuje nasłuchujące serwery tcp (nazwy)

netstat -ltn <- wypisuje nasłuchujące serwery tcp (adresy i numery)

netstat -lu <- wypisuje nasłuchujące serwery udp (nazwy)

netstat -lun <- wypisuje nasłuchujące serwery udp (adresy i numery)

## Ćwiczenie 1

Otworzyć kilka połączeń ssh do komputera B (z innego lub innych niż B komputerów)

Na komputerze B wydać polecenia "netstat -tn" i "netstat -ltn"

Pierwsze z tych poleceń w kolumnach "local address" i "foreign address" wypisuje adresy i porty

obu stron poszczególnych połączeń tcp wychodzących z B lub przychodzących do B

Drugie z nich wypisuje serwery tcp nasłuchujące na B.

Na komputerze B wydać polecenie "systemctl stop sshd" zatrzymujące serwera ssh

Zauważyć, że otwarte wcześniej połączenia do serwera ssh działającego na B są nadal aktywne,

ale nie można otwierać nowych połączeń do B

Na komputerze B wydać polecenie "systemctl start sshd" uruchamiające ponownie serwera ssh

## Ćwiczenie 2

Napisać skrypt monitorujący liczbę połączeń tcp nawiązanych do serwera określonej usługi działającego na lokalnej maszynie. Skrypt ma wypisywać liczbę połączeń przy jego uruchomieniu i przy każdej zmianie tej liczby. Oprócz tego skrypt ma ostrzegać o osiągnięciu lub przekroczeniu przez liczbę połączeń określonej wartości progowej, oraz informować o spadku liczby połączeń poniżej tej wartości. Numer portu serwera i wartość progowa mają być podawane jako argumenty przy uruchamianiu skryptu.

Polecenie zatrzymania serwera nasłuchującego na porcie o danym numerze (np. 22), jeśli serwer był uruchomiony przez mechanizm systemd:
```
systemctl stop `netstat -tln -p|awk '$1~"tcp$"'|awk '$4 ~ ":22$" {print $7}'|cut -f2 -d/`
```
Uwaga 1: instrukcja języka awk składa się z warunku i czynności wykonywanej na wierszach tekstu spełniających dany warunek, w powyższym przykładzie `awk '$1~"tcp$"'` wypisuje wiersze, których pierwsza kolumna kończy się znakami tcp, natomiast czynność nie jest określona, więc zostaną wypisane całe wiersze

Uwaga 2: polecenie `awk '$4 ~ ":22$" {print \$7}'` wypisuje siódmą kolumnę tych wierszy tekstu, które spełniają warunek `$4 ~ ":22$"` oznaczający, że czwarta kolumna wiersza kończy się znakami `:22`

Uwaga 3: w części warunkowej instrukcji języka `awk`, szukany wzorzec musi być ujęty w cudzysłów

Uwaga 4: gdyby serwer ssh nie został zatrzymany przez mechanizm systemd, ale np. "zabity" poleceniem kill w następujący sposób:

```
kill -9 `netstat -tln --program|awk '$1~"tcp$"'|awk '$4 ~ ":22$" {print $7}'|cut -f1 -d/`
```

to po pewnym czasie mechanizm systemd uruchomi go ponownie, jeśli w pliku konfigurującym serwer ssh w mechanizmie systemd, czyli w pliku `/etc/systemd/system/multi-user.target.wants/sshd.service` jest dyrektywa Restart=on-failure

Uwaga 5: po zmianie w pliku konfiguracyjnym jakiegoś serwera uruchamianego przez mechanizm systemd, należy wydać polecenie

```
systemctl daemon-reload
```

Konfiguracja samego serwera ssh jest zapisana w pliku /etc/ssh/sshd_config

Jedną z dyrektyw konfiguracyjnych jest `PermitRootLogin yes`,

która określa czy root może się logować do serwera ssh.

Po ewentualnych zmianach w powyższym pliku, aktywujemy je poleceniem

```
systemctl reload sshd
```

Polecenie nmap skanujące komputery i porty

```
nmap -sP 213.135.45.0/28 <- skanowanie komputerów o adresach z podanego zakresu
nmap -sS sz123.wsisiz.edu.pl <- skanowanie portów TCP na wskazanym komputerze (tylko root)
nmap -sT sz123.wsisiz.edu.pl <- skanowanie portów TCP na wskazanym komputerze (dowolny użytk.)
nmap -sT -p 20-30 sz123.wsisiz.edu.pl <- skanowanie portów TCP z podanego zakresu na wskazanym komp.
nmap -sU sz123.wsisiz.edu.pl <- skanowanie portów UDP na wskazanym komputerze (tylko root)
nmap -sU -p 20-30 sz123.wsisiz.edu.pl <- skanowanie portów UDP z podanego zakresu na wskazanym komp. (tylko root)
```

skanowanie portów oznacza wykrywanie otwartych portów.

## Ćwiczenie 3

Na komputerze B sprawdzić czy działa na nim mechanizm iptables (systemctl status iptables).

Jeśli tak, to zatrzymać iptables na B (`systemctl stop iptables`). Aktywować usługę echo na B (edycja plików `echo-stream` i `echo-dgram` w katalogu `/etc/xinetd.d` i polecenie `systemctl reload xinetd`).

Na komputerze A wydać polecenia

```
netstat -sS -p 1-200 <adres lub nazwa B>

netstat -sU -p 1-10 <adres lub nazwa B>
```

Następnie wznowić działanie iptables na B (systemctl start iptables) i ponownie wydać powyższe polecenia na komputerze A. Zaobserwować różnice. Uwaga: skanowanie portów UDP trwa dłużej niż portów TCP, dlatego podany zakres portów UDP jest mniejszy niż zakres portów TCP.
