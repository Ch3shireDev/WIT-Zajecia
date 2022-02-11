# III. Zadania

## Zadanie 1

Proszę rozważyć trzy procesy, każdy działający na innej maszynie. Każda maszyna ma lokalny czasomierz. W przypadku bez korekty czasu maszyn, proces P1 wysyła komunikat A w chwili 40\. Komunikat ten odbierany jest przez proces P2, wg jego lokalnego czasu w chwili 28\. Następnie proces P2 w hwili 30 wysyła komunikat B do procesu P3\. Proces P3 odbiera ten komunikat, wg jego lokalnego czasu, w chwili 42\. Proces P3 w chwili 47 wysyła komunikat C do procesów P1 i P2\. Komunikat ten jest odbierany przez proces P1 w chwili 47 wg jego czasu lokalnego, oraz w chwili 37 przez proces P2 wg jego czasu. Czasy których maszyn należy skorygować, kiedy i jak oraz jakie będą czasy nadania i odbioru komunikatów po dokonaniu synchronizacji logicznej czasu wymienionych maszyn, zgodnie z algorytmem Lamporta?

### Rozwiązanie

przed korektą:

```
P1(40) -> A(40) -> P2(28)
P2(30) -> B(30) -> P3(42)
P3(47) -> C(47) -> P1(47)
P3(47) -> C(47) -> P2(37)
```

Zgodnie z algorytmem Lamporta, należy zmodyfikować czasy maszyn tak, by odbieranie komunikatów następowało minimalnie później po ich wysłaniu.

```
P1(40) -> A(40) -> P2(28) + 13 (należy dodać 13 kwantów czasu do P2)
P2(43) -> B(43) -> P3(42) + 2  (należy dodać 2 kwanty czasu do P3)
P3(49) -> C(49) -> P1(47) + 3  (należy dodać 3 kwanty czasu do P1)
P3(49) -> C(49) -> P2(50) + 0  (nie należy dodawać kwantów czasu do P2 - po modyfikacji wiadomość została odebrana po jej wysłaniu według zegarów maszyn)
```

## Zadanie 2

Aplikacja używająca protokołu UDP, uruchomiona w sieci o MTU1=1494 B, wysyła 3012 B danych użytkownika. Powstałe fragmenty następnie przesyłane są do drugiej sieci o MTU2=726 B. Ile powstanie fragmentów oraz jakie jest ich przesunięcie i wielkość. Podaj w notacji `W@Przes_Flaga`. Opisz ramkę, w której przesyłany jest trzeci fragment po drugiej fragmentacji.

### Rozwiązanie

(Inżynieria odwrotna)

- MTU1 = 1494 B
- MTU2 = 726 B
- Dane = 3012 B
- Nagłówek UDP = 8 B
- Nagłówek IP = 20 B

IP   | UDP | Dane
---- | --- | ------
20 B | 8 B | 3012 B

UDP + Dane = 3020 B

Przesunięcia:

```
1440@0MF
1440@1440MF
140@2880LF
```

## Zadanie 3

Aplikacja używająca protokołu ICMP, uruchomiona w sieci o MTU1=1500B, wysyła 3022 B danych użytkownika. Powstałe fragmenty następnie przesyłane są do drugiej sieci o MTU2=730 B. Ile powstanie fragmentów oraz jakie jest ich przesunięcie i wielkość. Podaj w notacji `W@Przes_Flaga`. Opisz ramkę, w której przesyłany jest trzeci fragment po drugiej fragmentacji.

### Rozwiązanie

- MTU1 = 1500 B
- MTU2 = 730 B
- Dane = 3022 B
- Nagłówek = 20 B
- max fragment = 1480 B (`1480 % 8 == 0`)

```
1480@0MF
1480@1480MF
70@2960LF

2*1480+70 = 3030 B (dane + nagłówek ICMP)
```

```
MTU = 730 B
730 - 2 = 710 B
fragment = 704 B

704@0MF
704@704MF
72@1408MF
704@1480MF
704@2184MF
72@2888MF
70@2960LF
```

```
[ 20 ][   704   ]
           [ 20 ][   704   ]
                      [ 20 ][  72  ]
----------- 1 pakiet ---------------
                              [ 20 ][   704   ]
                                         [ 20 ][   704   ]
                                                    [ 20 ][  72  ]
                              ------------- 2 pakiet -------------
                                                            [ 20 ][  70  ]
                                                            -- 3 pakiet --

2960 + 70 = 3030 B
```

## Zadanie 4

Proszę rozpatrzyć możliwe plany współbieżnej realizacji następujących trzech transakcji:

```
a)  POCZĄTEK_TRANSAKCJI
    X = 3; Y = 0; X = X - Y; Y = Y - 2;
    KONIEC_TRANSAKCJI
b)  POCZĄTEK_TRANSAKCJI
    X = 2; Y = -3; X = X + 3; Y = X - Y + 1;
    KONIEC_TRANSAKCJI
c)  POCZĄTEK_TRANSAKCJI
    X = 0; X = X + 6; Y = 4; Y = Y + X;
    KONIEC_TRANSAKCJI
```

Proszę określić pełną listę dopuszczalnych wartości (rozdzielając je słowami "lub", ewentualnie "i"), które mogą przyjmować na końcu zmienne `x` i `y`. Proszę podać przykład niedopuszczalnego planu realizacji transakcji. Odpowiedź należy uzasadnić.

### Rozwiązanie

Dopuszczalne wartości końcowe muszą być takie, jakby transakcje były wykonywane jedna po drugiej, w dowolnej kolejności, ale nie jednocześnie. Ponieważ każda z transakcji przypisuje nowe wartości do `x, y`, to ich wartość jest determinowana przez ostatnią z wykonanych transakcji. W związku z tym są trzy możliwości:

- a) `x = 3, y = -2`
- b) `x = 5, y = 9`
- c) `x = 6, y = 10`

O ile transakcje mogą być wykonywane jednocześnie, tak długo dopóki skutkuje to identycznymi wartościami końcowymi, o tyle niedopuszczalne jest, by były wykonywane jednocześnie takie operacje, które powodują uzyskanie innych wartości niż przedstawione powyżej. Przykładem niedopuszczalnej operacji będzie:

```
    X = 3;          # A1
    Y = 0;          # A2
    X = X - Y;      # A3
    Y = Y - 2;      # A4
    
    X = 2;          # B1
    Y = -3;         # B2

    X = 0;          # C1
    X = X + 6;      # C2
    Y = 4;          # C3
    Y = Y + X;      # C4

    X = X + 3;      # B3
    Y = X - Y + 1;  # B4
```

Z wynikiem końcowym `x = 9, y = 0`.

## Zadanie 5

Proszę porównać operacje czytania pliku za pomocą jednowątkowego serwera plików i serwera wielowątkowego. Otrzymane zamówienia na pracę, skierowanie go do wykonania i reszta niezbędnego przetwarzania zajmuje 8 ms, pod warunkiem, że potrzebne dane znajdują się w podręcznej pamięci bloków. Jeżeli istnieje konieczność wykonania operacji dyskowej, co stanowi jedną szóstą zamówień, potrzeba dodatkowo 60 ms, podczas których wątek jest uśpiony. Ile zamówień na sekundę może obsłużyć serwer jednowątkowy i jakie będzie procentowe wykorzystanie czasu procesora? Ile zamówień na sekundę może obsłużyć serwer wielowątkowy i jakie będzie wówczas procentowe wykorzystanie czasu procesora? Proszę podać sposób rozwiązania i dokładnie uzasadnić.

### Rozwiązanie

Dla serwera jednowątkowego:

Czas przetwarzania zamówienia: 8 ms
Czas operacji dyskowej: 60 ms (dodatkowo)
Ułamek operacji dyskowych: 1/6

```
Procesor: [ 8 ms ]                   [ 8 ms ][ 8 ms ][ 8 ms ][ 8 ms ][ 8 ms ]
Dysk:             [      60 ms      ]
```

Średnio aby przetworzyć 6 zamówień, serwer potrzebuje 108 ms. Zatem w czasie sekundy jest w stanie wykonać 55.56 zamówień. Ponieważ w czasie 108 ms wątek jest czynny jedynie 48 ms, procentowe wykorzystanie czasu procesora wynosi 44.4%.

Dla serwera wielowątkowego:

```
Procesor: [8][8][8][8][8][8]      [8][8][8][8][8][8]
Dysk:        [         60 ms        ][         60 ms        ] 
```

W tym wypadku wąskim gardłem jest przetwarzanie zamówień przez dysk. Procesor może mieć dowolną liczbę wolnych wątków i wykonywać je dowolnie szybko, jednak tak długo jak część zamówień będzie wymagała dostępu do dysku, prędkość ich wykonywania będzie limitowała całkowity czas wykonywania zamówień.

Z sześciu zamówień jedno wymaga dostępu do dysku. W czasie operacji dyskowej (60 ms) jest wykonywane średnio 6 zamówień. Zatem 1 zamówienie jest wykonywane średnio w czasie 10 ms, co daje nam 100 zamówień na sekundę. Ponieważ jeden procesor mógłby wykonywać w czasie sekundy maksymalnie 125 zamówień, wydajność wynosi 80% (100/125).

## Zadanie 6

Z jakiej minimalnej sieci pochodzą komputery o adresach IP: `192.168.4.209` i `192.168.4.214`? Dokonaj obliczeń. Podaj adres IP tej sieci i maskę.

## Zadanie 7

Kiedy i w jaki sposób zachodzi przesyłanie bezpośrednie datagramu IP?

### Rozwiązanie

Dostarczanie bezpośrednie zachodzi podczas procesu wyznaczania tras. Gdy datagramy są przekazywane w ramach jednej sieci i nie wychodzi poza jej obręb, wówczas nie jest wymagane pośrednictwo routera i mamy do czynienia z presyłaniem bezpośrednim (maszyna nie kieruje datagramu na router, tylko wysyła do docelowego hosta, przyłączonego do tej samej sieci)

## Zadanie 8

Czy adres sprzętowy docelowy w ramce eternetowej ulega zmianie przy przesyłaniu pakietu danych przez kolejne routery? Odpowiedź uzasadnij.

### Rozwiązanie

Adres sprzętowy ulega zmianie podczas przesyłania danych przez kolejne routery. Dzieje się tak ponieważ adresy sprzętowe (docelowe) nie są od początku znane czy też przechowywane. W przeciwieństwie do adresów logicznych. Adres sprzętowy docelowy może się zmieniać (wymiana sprzętu) co nie przeszkodzi pakietowi w dotarciu do celu poprzez adres logiczny. Wyjątkiem możę być sieć wewnętrzna, np. z pojedynczym routerem.

## Zadanie 9

Czy adres IP docelowy w datagramie IP zmienia się przy przesyłaniu datagramu przez kolejne routery? Odpowiedź uzasadnij.

### Rozwiązanie

Adres docelowy w datagramie IP nie może zmieniać się przy przejściu prez kolejne routery, gdyż wtedy nie można by było ustalić dokąd datagram ma dojść. W rezultacie żaden datagram nie dotarłby do celu. Adres docelowy jest używany do wyznaczenia trasy datagramu.

## Zadanie 9

Co się dzieje z polem identyfikacja w nagłówku datagramu IP przy fragmentacji datagramu? Odpowiedź uzasadnij.

### Rozwiązanie

Pole identyfikacja w nagłówku IP ma 16 bitów i jest używane do jednoznacznego oznaczenia każdego fragmentu pierwotnego datagramu. Identyfikator zaznaczony w tym polu jest powtarzany we wszystkich fragmentach składających się na pierwotny datagram.

## Zadanie 10

W trakcie sesji FTP serwer wysyła do klienta fragment pliku o długości 1460 bajtów. Numer sekwencyjny (SeqNo) segmentu TCP mieszczącego te dane wynosi 7300\. W jaki sposób klient potwierdzi, że otrzymał ten segment od serwera?



## Zadanie 11

Jakie polecenie systemu Linux wypisze adresy interfejsów, przez które pakiet **opuszcza** routery znajdujące się na trasie do wskazanego komputera i z powrotem? Z którego pola nagłówka IP korzysta to polecenie? Ile najwięcej adresów może być wypisanych?

## Zadanie 12

Jakie polecenie systemu Linux wypisze interfejsy, przez które pakiet **wpływa** do routerów znajdujących się na trasie do komputera `213.135.45.252`? Które pole nagłówka IP jest tu w istotny sposób wykorzystywane? Jaki jest rozmiar tego pola w bitach?

## Zadanie 13

W trakcie sesji TCP strona A otrzymała od strony B segment potwierdzający odebranie danych wysłanych przez A. W segmencie tym pole "Window Size" miało wartość 10 KB. Ile kolejnych segmentów o maksymalnym rozmiarze może wysłać strona A bez oczekiwania na następne potwierdzenie od B? Zakłada się, że maksymalny rozmiar pola danych w segmentach wysyłanych przez A ma wynosić 1460 B.

## Zadanie 14

Pole "suma kontrola" w nagłówku TCP jest liczone z:

- [ ] nagłówka TCP
- [ ] nagłówka TCP i danych
- [ ] nagłówka TCP, danych i pseudonagłówka

## Zadanie 15

Przy nawiązywaniu połączenia za pomocą protokołu TCP w nagłówku drugiego segmentu są ustawione flagi:

- [ ] SYN
- [ ] SYN i ACK
- [ ] FIN i ACK

## Zadanie 16

Rekord zasobów typu SOA zawiera:

- [ ] adres e-mail administratora strefy
- [ ] czas odświeżania informacji dla zapasowych serwerów DNS
- [ ] adresy IP zapasowych serwerów DNS

## Zadanie 17

Rekord zasobów typu PTR zawiera:

- [ ] translację adresu IP na nazwę DNS
- [ ] translację nazwy DNS na adres IP
- [ ] adres IP serwera danej strefy

## Zadanie 18

Następujące trzy transakcje są realizowane współbieżnie:

- a) `x=3;y=2;x=x-y;y=x-1;`
- b) `x=2;y=0;x=x+7;y=x+y;`
- c) `x=0;x=x+6;y=1;y=y+x;`

- Podać pełną listę dopuszczalnych wartości tych zmiennych (rozdzielając je operatorami logicznymi "i" oraz "lub").

- Czy następujący plan realizacji transakcji jest dopuszczalny ze względu na właściwość izolacji?

```
{x=0;x=x+6;x=3;y=2;x=x-y;y=x-1;x=2;y=0;x=x+7;y=x+y;y=1;y=y+x;}
{x=0;x=x+6;y=1;y=y+x;x=3;y=2;x=x-y;y=x-1;x=2;y=0;x=x+7;y=x+y;}
{x=2;y=0;x=x+7;x=0;y=x+y;x=x+6;y=1;y=y+x;x=3;y=2;x=x-y;y=x-1;}
```

## Zadanie 19

Proszę porównać operacje czytania pliku za pomocą jednowątkowego i wielowątkowego serwera plików. Otrzymanie zamówienia na pracę, skierowanie go do wykonania i reszta niezbędnego przetwarzania zajmuje 8 ms, pod warunkiem, że potrzebne dane znajdują się w podręcznej pamięci bloków. Operacja dyskowa, występująca w jednej czwartej zamówień, zajmuje dodatkowo 48 ms, podczas których wątek jest uśpiony.

**Serwer jednowątkowy**

Ile zamówień na sekundę może obsłużyć serwer jednowątkowy? (z dokładnością do 1 zamówienia/sek)? Dla uproszczenia przyjmujemy, że po każdym zamówieniu wymagającym dostępu do dysku przychodzą trzy zamówienia bezdyskowe.

`125, 50, 40`

Jakie będzie procentowe wykorzystanie czasu procesora (z dokładnością do 1%):

`100%, 60%, 40%`

**Serwer wielowątkowy**

Ile zamówień na sekundę może obsłużyć serwer wielowątkowy? (z dokładnością do 1 zamówienia/sek)? Dla uproszczenia obliczeń proszę przyjąć, że po każdym zamówieniu wymagającym dostępu do dysku przychodzą trzy zamówienia bezdyskowe.

`125, 83, 67`

Jakie będzie procentowe wykorzystanie czasu procesora, (z dokładnością do 1%):

`100%, 67%, 50%`

## Zadanie 20

Wydzielić z sieci klasy C o adresie 192.168.1.0 trzy **jak najmniejsze** podsieci, w taki sposób, aby w pierwszej umieścić 25, w drugiej 30, a w trzeciej 120 komputerów. **Uwaga: podana kolejność nie może być zmieniona!** Dla każdej podsieci należy podać: adres, maskę (w wersji kropkowo-dziesiętnej), adres broadcast i pełny zakres adresów hostów.

## Zadanie 21

Skonstruować potok, który wypisze liczbę nasłuchujących serwerów UDP na lokalnej maszynie.

## Zadanie 22

Odbiorca otrzymał sygnał pokazany na rysunku. Wiadomo, że wykorzystywany jest kod Manchester, a także algorytm CRC, w którym wielomianem dzielnikiem (generatorem) jest $x^3+x^2+1$. Co zrobi odbiorca z otrzymaną informacją? Odpowiedź uzasadnij.

![](./images/31.png)

## Zadanie 23

Wiadomo, że konfiguracja komputerów pracujących w sieci przedstawionej na rysunku jest następująca:

- A: adres IP = 192.168.26.133; adres MAC = 8:0:20:b :b0:83
- B: adres IP = 192.168.26.134; adres MAC = 8:0:20:b :b0:84
- C: adres IP = 192.168.26.135; adres MAC = 8:0:20:b :b0:85
- D: adres IP = 192.168.26.136; adres MAC = 8:0:20:b :b0:86

![](./images/32.png)

W sieci tej zaobserwowano ramkę, której początek podany jest niżej:

```
ffff ffff ffff 0800 200b b083 0806 0001
0800 0604 0001 0800 200b b083 c0a8 1a85
ffff ffff ffff c0a8 1a87
```

Co dokładnie zawiera ta ramka? Jaką odpowiedź powinien odebrać komputer, który tę ramkę wysłał?

## Zadanie 24

Komputery A i B znajdują się w różnych podsieciach. Osoba korzystająca z komputera A poinformowała o braku łączności z komputerem B. Sprawdzając konfiguracje komputera A otrzymano następujące dane:

```
Adres IP:           130.100.183.100
Maska:              255.255.248.0
Default gateway:    130.100.184.101
```

Czy na ich podstawie można określić przyczynę braku łączności między komputerami A i B?

## Zadanie 25

Rozpatrzmy porównanie modelu stacji roboczych i modelu puli procesorów z uwzględnieniem teorii masowej obsługi. W modelu stacji roboczych jest 20 stacji, każda ma procesor przetwarzający średnio 50 zamówień na sekundę. Do każdego przychodzą losowo zamówienia, średnio 30/sek.

1. Wyznaczyć średni czas odpowiedzi zgodnie z teorią masowej obsługi w przypadku tego modelu.
2. Wyznaczyć średni czas odpowiedzi zgodnie z teorią masowej obsługi w przypadku modelu puli procesorów, w którym pula procesorów zawiera zsumowane 20 procesorów stacji roboczych, a przychodzą do niej losowo w sumie te same zamówienia, co w przypadku modelu stacji roboczych.

### Rozwiązanie

Zgodnie z teorią masowej obsługi, średni czas odpowiedzi wynosi:

$$T = \frac1{\mu-\lambda},$$

gdzie $\mu$ to średnia liczba zamówień które mogą być przetworzone w ciągu sekundy, natomiast $\lambda$ to średnia liczba zgłaszanych zamówień w ciągu sekundy.

1. Średni czas odpowiedzi wynosi: $T=\frac1{50 \text{Hz}-30 \text{Hz}}=0.05$ s.
2. Dla zsumowanej puli $n$ procesorów modyfikujemy powyższy wzór w następujący sposób:

$$T = \frac1{n\cdot\mu-n\cdot\lambda} = \frac{1}{20}\cdot0.05 s = 0.0025s$$