# Organizacja i Architektura Komputerów

## Zadania zamknięte

### Zadanie 1

1. Algorytm Bootha dotyczy:

- a. odejmowania liczb całkowitych ze znakiem
- b. mnożenia liczb całkowitych bez znaku
- c. mnożenia liczb całkowitych w notacji uzupełnienia do dwóch
- d. mnożenia liczb całkowitych w notacji znak-moduł

### Rozwiązanie

Dla pomnożenia dwu liczb n-bitowych X (mnożna) i Y (mnożnik) stosuje się układ rejestrów podłączonych do sumatora binarnego. Rejestr Q zawiera X, rejestr M zawiera Y. Rejestr A jest połączony z Q i rejestrem S. Rejestry M, A, Q są n-bitowe. Rejestr S jest 1-bitowy. Rejestr SAQ przechowuje wynik końcowy i częściowe wyniki w trakcie mnożenia.

Metoda jest wzorowana na ręcznym dziesiętnym mnożeniu. Metoda dodaje mnożną Y do siebie tyle razy, ile wynosi X. Zawartość M jest dodawana do A dla kolejnych jedynek w X w rejestrze Q, począwszy od bitu najmniej znaczącego, z przesuwaniem całego rejestru SAQ o jedną pozycjęw prawo po każdym dodaniu M oraz po każdym wykryciu zerowego bitu mnożnika na zerowej pozycji rejestru Q.
Otrzymany wynik ma podwójną liczbę bitów w porównaniu z agumentami mnożenia.
Otrzymany wynik można sprowadzic do formatu argumentów poprzez obcięcie połowy bitów i zaokrąglenie. Zaokrąglenie wykonuje się przez dodanie na najmniej znaczącej pozycji obciętego wyniku 1 i wykonanie propagacji przeniesień, jeśli pierwszy bit z obciętej części jest równy 1.

Algorytm mnożenia zapisany w języku algorytmicznym jest podany poniżej.

Przykład:

```
Pomnóż X = 01010 przez Y = 11001 (czyli 10 przez -7 w systemie dziesiętnym).
S 	A 	Q 	Operacja do wykonania
0 	00000 	01010 	przesuń w prawo
0 	00000 	00101 	dodaj M do A
1 	11001 	00101 	przesuń w prawo
1 	11100 	10010 	przesuń w prawo
1 	11110 	01001 	dodaj M do A
1 	10111 	01001 	przesuń w prawo
1 	11011 	10100 	przesuń w prawo
1 	11101 	11010

Wynik 1110111010 (czyli -70 w systemie dziesiętnym).
```

### Zadanie 2

Wynik przesunięcia arytmetycznego w prawo o dwa bity ośmiobitowej liczby -32 to:

- a. -64
- b. -8
- c. -4
- d. -128

#### Rozwiązanie

Odpowiedź b

### Zadanie 3

Wartość NaN:

- a. oznacza wartość, która jest zbyt mała aby zostać przedstawiona w komputerze
- b. oznacza wartość uzyskaną przy użyciu bitów zabezpieczenia
- c. jest uzyskiwana w wyniku stopniowego niedomiaru
- d. może zostać uzyskana w wyniku pierwiastkowania niektórych liczb

#### Rozwiązanie

Odpowiedź d. Wszystkie pozostałe odpowiedzi nie mają sensu, do d dochodzimy metodą eliminacji.

### Zadanie 4

Która cecha dotyczy dużej tablicy rejestrów (wykorzystywanej w procesorach RISC):

- a. przechowuje zmienne globalne przechowywane przez kompilator
- b. działa na blokach pamięci
- c. przechowuje ostatnio używane skalary lokalne
- d. wymiana zawartości odbywa się przy pomocy algorytmu LRU

### Zadanie 5

Dostęp do danych w pamięci typu pendrive ma charakter:

- a. sekwencyjny
- b. bezpośredni
- c. swobodny
- d. skojarzeniowy

### Zadanie 6

Adresowanie pośrednie:

- a. Wymaga dwóch dostępów do pamięci
- b. Jest wykorzystywane w architekturach SMP
- c. Wymaga stałej długości rozkazu
- d. Może być zrealizowane jako adresowanie z rejestrem podstawowych

### Zadanie 7

Które stwierdzenie dotyczące pamięci jest prawdziwe:

- a. Większy czas dostępu oznacza większy koszt jednego bitu
- b. Większa pojemność oznacza większy czas dostępu
- c. Większy koszt jednego bitu oznacza mniejszą częstotliwość dostępu przez procesor
- d. Większa pojemność oznacza większy koszt jednego bitu

### Zadanie 8

Technika nie rozwiązująca problemu przetwarzania rozgałęzień warunkowych w architekturze potokowej to:

- a. Bufor pętli
- b. Opóźnione rozgałęzienie
- c. Zwielokrotnienie strumienia
- d. Pamięć podręczna śladów

### Zadanie 9

Instrukcja rotacji w lewo służy do:

- a. szybkiego mnożenia przez 2
- b. szybkiego dzielenia przez 2
- c. realizacji tzw. kodów cyklicznych
- d. konwersji znaków w kodzie ASCII na inne kody

### Zadanie 10

Do wykrycia podwójnego błędu dla 128 bitów danych potrzeba

- a. 7 bitów kontrolnych
- b. 8 bitów kontrolnych
- c. 9 bitów kontrolnych
- d. 10 bitów kontrolnych

## Wielokrotny wybór

### Zadanie 11

Cechy charakterystyczne procesora RISC to:

- a. Dwie pamięci podręczne pierwszego poziomu - jedna na mikroprogram, druga na dane
- b. Jednostka przewidywania rozgałęzień
- c. Okna rejestrów
- d. Hiperpotok

### Zadanie 12

Instrukcje 3D Now!:

- a. Są typu SIMD
- b. Są wykorzystywane do wykonania operacji na wektorach liczb rzeczywistych i całkowitych
- c. Pozwalają na dodanie lub mnożenie dwóch liczb z tego samego rejestru
- d. Wymagają dodatkowych rejestrów wektoroweych

### Zadanie 13

Stos:

- a. Jest implementowany jako oddzielny zbiór rejestrów
- b. Jest implementowany jako oddzielny fragment pamięci
- c. Może być wykorzystany do indeksowania
- d. Może być wykorzystany do wsparcia wywołań podprocedur

### Zadanie 14

Pamięć podręczna 2. poziomu:

- a. Znajduje się w rdzeniu procesora
- b. Jest bezpośrednio połączona z pamięcią danych 1. poziomu
- c. Służy do wprowadzenia rozkazów i danych bezpośrednio do ALU
- d. Zawiera mikrorozkazy

### Zadanie 15

Instrukcja skoku warunkowego

- a. Może poważnie spowolnić pracę procesora superskalarnego
- b. Nie jest implementowana w architekturach RISC
- c. Może zostać wywołana tylko w ramach pierwszych 64 MB segmentu programu
- d. Wymaga przynajmniej dwóch argumentów

### Zadanie 16

Lokalność przestrzenna odniesień jest wykorzystywana:

- a. Poprzez utrzymywanie ostatnio używanych rozkazów i danych w pamięci podręcznej
- b. poprzez stosowanie hierarchicznych struktur pamięci
- c. poprzez posługiwanie się większymi blokami pamięci podręcznej
- d. poprzez wbudowanie do pamięci podręcznej bloków wstępnego pobierania

### Zadanie 17

Segmentacja:

- a. Jest metodą podziału programu w pamięci na bloku funkcjonalne
- b. Jest widoczna dla programisty
- c. Wymaga specjalizowanych rejestrów
- d. Wymaga TLB

### Zadanie 18

Mnożenie liczb zmiennoprzecinkowych:

- a. Wykorzystuje jednostki zmiennoprzecinkowe
- b. Jest możliwe bez użycia jednostek zmiennoprzecinkowych
- c. Jest łatwiejsze w realizacji od dodawania takich liczb
- d. Wymaga wsparcia wystemu operacyjnego

### Zadanie 19

Do przyspieszania komunikacji z urządzeniami wejścia wyjścia są stosowane:

- a. Zwielokrotnione strumienie
- b. Bufory pętli
- c. Bezpośredni dostęp do pamięci
- d. Pamięć podręczna śladów

### Zadanie 20

Punkty kontrolne DMA

- a. Są wykorzystywane podczas tzw. "kradzieży cyklu"
- b. Wymuszają zatrzymanie pracy procesora
- c. Wymagają zapisu kontekstu programu wykonywanego dotychczas
- d. Generują przerwanie

### Zadanie 21

Zwiększanie dokładności obliczeń na liczbach rzeczywistych obejmuje w IEEE 754:

- a. Bity zabezpieczenia
- b. Formaty rozszerzone dla liczb pojedynczej i podwójnej precyzji
- c. Zaokrąglanie w kierunku NaN
- d. Zmianę podstawy liczby

### Zadanie 22

Sterowanie mikroprogramowalne:

- a. Służy do zarządzania pamięcią sterującą danych i rozkazów
- b. Obejmuje sterowanie rozgałęzieniami
- c. Wymaga dostępu do pamięci podręcznej
- d. Wymaga układowej jednostki sterującej w procesorze

### Zadanie 23

Obsługa przerwań przez procesor:

- a. Dotyczy tylko przerwań niemaskowalnych
- b. Jest możliwa po otrzymaniu odpowiedniego sygnału na wejście INTR
- c. Wykorzystuje tablicę wektorów przerwań
- d. Może wykorzystywać rejestr XER

### Zadanie 24

Komputery główne:

- a. Charakteryzują się wielopoziomową pamięcią podręczną
- b. Wykorzystują strukturę magistrali do komunikacji między procesorami
- c. Są sterowane przez system operacyjny ogólnego przeznaczenia
- d. Są przykładem architektury o równoległym przetwarzaniu symetrycznym.

### Zadanie 25

Kompilator

- a. tłumaczy kod programu wysokiego poziomu na asembler
- b. może być wykorzystany do modyfikacji kolejności rozkazów
- c. może służyć do optymalizacji wykorzystania rejestrów
- d. zarządza wykorzystaniem pamięci podręcznej

### Zadanie 26

Identyfikacja urządzeń wejścia-wyjścia odbywa się poprzez:

- a. Wiele linii przerwań
- b. Odpytywana za pomocą oprogramowania
- c. Odpytywana za pomocą sprzętu
- d. Arbitraż za pomocą magistrali

### Zadanie 27

Procesor PowerPC:

- a. Ma wszystkie rozkazy o takiej samej długości
- b. Jeśli wykonuje operacje arytmetyki zmiennopozycyjnej, używa wyłącznie adresowania rejestrowego
- c. Ma wszystkie rozkazy tego samego formatu
- d. Wyposażony jest w pamięć podręczną trzeciego poziomu

### Zadanie 28

Pamięć ROM:

- a. Jest wykorzystywana do przechowywania programów typu firmware
- b. Zawiera dane nieulotne
- c. Wykorzystuje bramki z jednym tranzystorem w każdej komórce
- d. Wymaga dekoderów linii adresowych

### Zadanie 29

Sprzętowe zarządzanie pamięcią przez procesor:

- a. Wspomaga stronicowanie i/lub segmentację
- b. Obejmuje definiowanie poziomów ochrony poszczególnych segmentów pamięci
- c. Służy do generowania adresów wirtualnych na podstawie liniowych
- d. Wykorzystuje bufor translacji adresów

### Zadanie 30

Słowo stanu programu może zawierać informacje na temat:

- a. Poziomu uprzywilejowania wejścia-wyjścia
- b. Stanu zera
- c. Zezwolenia na przerwania
- d. Adresowania słowa w nieodpowiednich granicach

## Zadania otwarte

### Zadanie 31

Jeśli ostatnią operacją w komputerze o słowie 8-bitowym było dodawanie, w którym dwoma argumentami były:

- a. 116 i 12
- b. -1 i 1

to jaka jest wartość następujących flag:

- przeniesienie
- zero
- znak
- parzystość

### Zadanie 32

Wyrazić liczbę -1/256 w 32-bitowym formacie zmiennopozycyjnym IEEE 754.

### Zadanie 33

Zamienić następujące wyrażenia odwrotnej notacji polskiej na notację wrostkową:

- a. `ABCDE+**/`
- b. `ABCDE+F/+G-H/*+`
- c. `AB/CD/+`

### Zadanie 34

Dany jest dysk twardy o czasie przeszukiwania równym 4 ms, prędkości obrotowej 7200 obr/min, 512-bajtowymi sektorami oraz 500 sektorami na ścieżce. Chcemy przeczytać 2500 sektorów. Obliczyć, ile czasu będzie zajmował odczyt wszystkich danych zakładając, że dane na dysku są ułożone w sposób maksymalnie zwarty. Podaż wartość opóźnienia obrotowego oraz czas odczytu wszystkich sektorów na ścieżce.

### Zadanie 35

W komórce pamięci znajduje się 8-bitowa liczba -79. Została ona zapisana do zmiennej przechowującej znaki (np. char), zmiennej przechowującej liczby całkowite 16-bitowe, zmiennej przechowującej liczby naturalne 8-bitowe oraz zmiennej przechowującej liczby całkowite 4-bitowe. Jakie wartości będą przechowywać poszczególne zmienne? Odpowiedź uzasadnić.

### Zadanie 36

Pamięć podręczna sekcyjno-skojarzeniowa składa się z 32 wierszy podzielonych na 4-wierszowe sekcje. Pamięć główna zawiera 4K bloków po 64 słów każdy. Jaki format mają adresy pamięci głównej?
