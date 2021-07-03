# Organizacja i Architektura Komputerów - egzamin końcowy

## I. Zaznacz prawidłową odpowiedź (tylko jedna jest prawidłowa)

### Zadanie 1

Algorytm Bootha dotyczy:

- a. odejmowania liczb całkowitych ze znakiem
- b. mnożenia liczb całkowitych bez znaku
- c. mnożenia liczb całkowitych w notacji uzupełnienia do dwóch
- d. mnożenia liczb całkowitych w notacji znak-moduł

### Zadanie 2

Wynik przesunięcia arytmetycznego w prawo o dwa bity ośmiobitowej liczby -32 to:

- a. -64
- b. -8
- c. -4
- d. -128

### Zadanie 3

Wartość NaN:

- a. oznacza wartość, która jest zbyt mała, aby zostać przedstawiona w komputerze
- b. oznacza wartość uzyskaną przy użyciu bitów zabezpieczenia
- c. jest uzyskiwana w wyniku stopniowego niedomiaru
- d. może zostać uzyskana w wyniku pierwiastkowania niektórych liczb

### Zadanie 4

Który rozkaz procesora nie modyfikuje rejestru stanu:

- a. Odwrócenie wartości flagi przeniesienia
- b. Dodawanie dwóch liczb całkowitych
- c. Dzielenie całkowitoliczbowe
- d. Zamiana zawartości dwóch bajtów

### Zadanie 5

Która cecha dotyczy dużej tablicy rejestrów (wykorzystywanej w procesorach RISC):

- a. przechowuje zmienne globalne przechowywane przez kompilator
- b. działa na blokach pamięci
- c. przechowuje ostatnio używane skalary lokalne
- d. wymiana zawartości odbywa się przy pomocy algorytmu LRU

### Zadanie 6

Która z następujących cech jest charakterystyczna dla procesorów typu RISC (np.
PowerPC):

- a. Cykl rozkazowy jest rozbijany na mniejsze etapy, wykonywane sekwencyjnie
- b. Rejestry są podzielone na tzw. okna
- c. Procesor współpracuje z pamięciami podręcznymi 3. poziomu
- d. Przewidywanie rozgałęzień odbywa się na podstawie tablicy historii

### Zadanie 7

W jaki sposób czasomierz systemowy komunikuje procesorowi potrzebę obsługi:

- a. Przez linię sygnałową INTR
- b. Za pomocą wyjątku programowego
- c. Za pośrednictwem sterownika DMA
- d. Poprzez linię sygnałową NMI

### Zadanie 8

Najbardziej wydajnym algorytmem zastępowania bloków w pamięci podręcznej jest:

- a. Najdawniej używany (LRU)
- b. losowy
- c. najrzadziej używany (LFU)
- d. pierwszy wchodzi, pierwszy wychodzi (FIFO)

### Zadanie 9

Jednostka sterująca we współczesnym mikroprocesorze (typu Intel Core i7):

- a. Pobiera rozkazy bezpośrednio z pamięci głównej
- b. Przechowuje informację na temat aktualnej fazy cyklu rozkazowego
- c. Ma bezpośredni kontakt z urządzeniami wejścia-wyjścia
- d. Pobiera rozkazy bezpośrednio z pamięci podręcznej pierwszego poziomu

### Zadanie 10

Sterowanie zewnętrzne w systemie komputerowym

- a. Wymaga jednostki sterującej wewnątrz procesora
- b. Było stosowane w komputerze ENIAC
- c. Jest podstawową cechą architektury von Neumanna
- d. Jest stosowane powszechnie w układach scalonych
  II.
  Zaznacz prawidłową odpowiedź (wiele prawidłowych jest możliwych):

### Zadanie 11

Moduł wejścia-wyjścia:

- a. Jest bezpośrednio podłączony do magistrali systemowej
- b. Buforuje dane z/do urządzenia wejścia-wyjścia
- c. Jest elementem wewnętrznym procesora
- d. Zawiera rejestry danych i sterowania

### Zadanie 12

Architektura Harvard:

- a. jest architekturą mikrokontrolerów
- b. została zaimplementowana w procesorach serwerowych Intel Itanium
- c. jest traktowana jako architektura CISC
- d. charakteryzuje się spekulatywnym ładowaniem

### Zadanie 13

Przewidywanie rozgałęzień w architekturze potokowej obejmuje:

- a. Stopień granulacji adresu
- b. Przewidywanie zawsze następującego rozgałęzienia
- c. Przewidywanie rozgałęzienia na podstawie kodu operacji
- d. Adresowanie stosowe

### Zadanie 14

Następujące przerwania są dopuszczalne w systemie komputerowym:

- a. Związane z uszkodzeniem sprzętu
- b. programowe
- c. zegarowe
- d. związane z urządzeniami wejścia-wyjścia

### Zadanie 15

Które rodzaje adresowania nie są implementowane w architekturach RISC:

- a. natychmiastowe
- b. pośrednie wielopoziomowe
- c. bezpośrednie
- d. indeksowanie wstępne

### Zadanie 16

Parametry wydajnościowe pamięci głównej obejmują:

- a. czas dostępu
- b. czas cyklu
- c. liczbę bajtów na sektor
- d. czas przeszukiwania

### Zadanie 17

Mnożenie liczb zmiennoprzecinkowych:

- a. Wykorzystuje jednostki zmiennoprzecinkowe
- b. Jest możliwe bez użycia jednostek zmiennoprzecinkowych
- c. Ustawia flagi rejestru stanu w jednostce zmiennoprzecinkowej
- d. Wymaga wsparcia systemu operacyjnego

### Zadanie 18

Pamięć podręczna z odwzorowaniem skojarzeniowym:

- a. Dzieli adres na dwie części
- b. Ma stałą długość znacznika
- c. Jest najefektywniejszym rozwiązaniem pamięci podręcznych
- d. Może odwzorowywać nieokreśloną liczbę bajtów z pamięci głównej

### Zadanie 19

Pamięć główna charakteryzuje się:

- a. Krótszym czasem dostępu, niż pamięć dyskowa
- b. Sekwencyjnym sposobem dostępu
- c. Mniejszym kosztem jednego megabajta, niż pamięć podręczna
- d. Nieulotnością zawartości

### Zadanie 20

Które operacje nie są wykonywane podczas przetwarzania przerwań:

- a. Wprowadzenie procesora w stan obniżonego poboru mocy
- b. Odtworzenie licznika rozkazu i PSW
- c. Komunikacja z modułem wejścia-wyjścia
- d. Ustawienie magistrali systemowej w stan początkowy

### Zadanie 21

Kompilator:

- a. tłumaczy kod programu wysokiego poziomu na asembler
- b. może być wykorzystany do modyfikacji kolejności rozkazów
- c. może służyć do optymalizacji wykorzystania rejestrów
- d. zarządza wykorzystaniem pamięci podręcznej

### Zadanie 22

Sprzętowe zarządzanie pamięcią przez procesor:

- a. Wspomaga stronicowanie i/lub segmentację
- b. Obejmuje definiowanie poziomów ochrony poszczególnych segmentów
  pamięci
- c. Służy do generowania adresów wirtualnych na podstawie liniowych
- d. Wykorzystuje bufor translacji adresów

### Zadanie 23

Architektura hiperpotokowa:

- a. Wymaga wielu jednostek arytmetyczno-logicznych wykonujących rozkazy
- b. Wymaga podziału cyklu rozkazowego na dużą liczbę etapów
- c. Wykorzystuje przemianowywanie rejestrów w celu rozwiązywania problemów
  zależności danych
- d. Wymaga wydajnej jednostki przewidywania rozgałęzień (BPU)

### Zadanie 24

W mikrorozkazach pionowych:

- a. rozkaz jest zakodowany
- b. nie ma adresu mikrorozkazu
- c. jednostka sterująca wykorzystuje pamięć sterującą
- d. nie wykorzystuje się rozgałęzień

### Zadanie 25

Instrukcja skoku warunkowego:

- a. Może poważnie spowolnić pracę procesora potokowego
- b. Nie jest implementowana w architekturach RISC
- c. Może zostać wywołana tylko w ramach pierwszych 64 MB segmentu
  programu
- d. Wymaga przynajmniej dwóch argumentów

### Zadanie 26

Lokalność przestrzenna odniesień jest wykorzystywana:

- a. poprzez utrzymywanie ostatnio używanych rozkazów i danych w pamięci
  podręcznej
- b. poprzez stosowanie hierarchicznych struktur pamięci podręcznej
- c. poprzez posługiwanie się większymi blokami pamięci podręcznej
- d. poprzez wbudowanie do pamięci podręcznej bloków wstępnego pobierania

### Zadanie 27

Słowo stanu programu może zawierać informacje na temat:

- a. Poziomu uprzywilejowania wejścia-wyjścia
- b. Stanu zera
- c. Zezwolenia na przerwania
- d. Adresowania słowa w nieodpowiednich granicach

### Zadanie 28

Stopień granulacji adresu określa:

- a. Liczbę bajtów przesyłanych jednocześnie między procesorem i pamięcią
  główną
- b. Liczbę argumentów w instrukcji maszynowej
- c. Minimalną liczbę bajtów, o które można zwiększyć adres w liczniku programu
- d. Liczbę bitów identyfikujących rejestr ogólnego przeznaczenia

### Zadanie 29

Które z poniższych są rejestrami adresowymi:

- a. Akumulator
- b. Licznik programu
- c. Wskaźnik stosu
- d. Rejestr stanu

### Zadanie 30

Które rodziny rozkazów maszynowych procesorów Intel należą do kategorii SIMD:

- a. AES-NI
- b. MMX
- c. SSSE3
- d. AVX-2

### Zadanie 31

Pytania otwarte:

### Zadanie 32

Zaprojektować programy dla maszyn 1- i 2-argumentowych do obliczenia
następującego wyrażenia:
`X = (A+B\*C)/(D-E)`
Maszyny dysponują instrukcjami, odpowiednio: LOAD, STORE, ADD, SUB, MUL,
DIV oraz MOV, ADD, SUB, MUL, DIV (4 pkt.)

### Zadanie 33

W pamięci komputera znajdują się następujące zmienne (w nawiasach podano
rozmiar):

- a. char x = 4Ah (1B)
- b. int y = 72B2h (4B)
- c. byte z[3] = {21h, FFh, 8Ch} (3x1B)

Jak będzie wyglądać zawartość pamięci, jeśli sekcja danych zaczyna się od adresu
02DDh, komputer jest typu cienkokońcowego, a dane w pamięci są wyrównywane do
parzystego adresu? (3 pkt.)

### Zadanie 34

W systemie 32-bitowym wywołano procedurę z trzema argumentami: znakiem w
kodzie ASCII, liczbą rzeczywistą podwójnej precyzji oraz tablicą liczba całkowitych
typu long. Pokazać zawartość stosu, jeśli przed wywołaniem procedury wskaźnik
stosu pokazywał adres FFh, zaś stos rośnie "w dół" (3 pkt.).

### Zadanie 35

Przedstawić zgodnie z normą IEEE 754 (w formacie 32-bitowym) liczbę 55 (3 pkt.).

### Zadanie 36

Uporządkować fazy potoku procesora Pentium IV:

- a. Przemianowanie rejestrów
- b. Sprawdzenie rozgałęzień
- c. Szeregowanie mikrooperacji
- d. Pobieranie do pamięci podręcznej śladów
- e. Kolejkowanie mikrooperacji
- f. Ustawienie znaczników
  (3 pkt.)

### Zadanie 37

W komórce pamięci systemu komputerowego typu cienkokońcowego znajduje się 16bitowa liczba -95 (typ short int). Została ona zapisana do zmiennej przechowującej 8bitowe liczby całkowite bez znaku (np. char), zmiennej przechowującej liczby
całkowite 32-bitowe (typ int) oraz zmiennej przechowującej liczby całkowite 16bitowe bez znaku (unsigned short int). Jakie wartości będą przechowywać
poszczególne zmienne (pokazać reprezentację binarną i dziesiętną), jeśli procesor ma organizację typu grubokońcowego? Odpowiedzi uzasadnić. (4 pkt.)
