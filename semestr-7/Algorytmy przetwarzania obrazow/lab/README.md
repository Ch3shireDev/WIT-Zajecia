# ALGORYTMY PRZETWARZANIA OBRAZÓW

## Laboratorium 1

Algorytm i program wyliczania, przedstawiania reprezentacji graficznej i tablicowej histogramu dla obrazów kolorowych i monochromatycznych.

### Zadanie 1

- Przygotować środowisko do pracy z obrazami (zapisanymi w formatach: `.bmp; .tif; .png; .jpg`) w dowolnym wybranym przez siebie języku programowania i środowisku
- Zapewnić opcje wczytywania, zapisywania i duplikacji obrazu i możliwość jednoczesnego wyświetlania wielu obrazów.
- Opracować algorytm i uruchomić aplikację tworzenia histogramu wczytanych obrazów monochromatycznych i kolorowych.

## Laboratorium 2

Algorytm i program manipulacji histogramem oraz do wykonywania na obrazach operacji punktowych jednoargumentowych

Rozszerzyć działanie systemu tak, aby pokazywał obrazy w różnych powiększeniach:

- dopasowany do szerokości ekranu,
- 100% czyli piksel w piksel,
- pomniejszony (50%, 25%, 20% i 10%) i
- powiększony (150%, 200%)

wprowadzając tam gdzie to konieczne prowadnice do przesuwania w pionie i poziomie.

### Zadanie 1

Opracować algorytm i uruchomić aplikację rozciągania (liniowego i nieliniowego) i wyrównywania przez eqalizację histogramu (metodą przedstawioną na wykładzie).

Rozciąganie histogramu: w zakresach `[min; max]` i `[a; b]` zarówno gdy a i b są większe lub mniejsze od zakresu poziomów jasności występujących w obrazie w wersji liniowe i nie linowej.

Rozciąganie nieliniowe zaimplementować przez funkcję korekcji gamma ze współczynnikiem wyznaczanym przez użytkownika.

### Zadanie 2

Opracować algorytm i uruchomić aplikację realizującą typowe operacje punktowe jednoargumentowe takie jak:

- negacja,
- progowanie binarne lub bez zamiany liczby poziomów szarości z progiem wskazywanym suwakiem i wpisanym jako parametr,
- progowanie z zachowaniem poziomów szarości z progiem wskazywanym suwakiem,
- progowanie binarne lub bez zamiany liczby poziomów z dwoma progami wskazanymi przez wskazywanym suwakiem i wpisanym jako parametr.

Proszę o przygotowanie własnych monochromatycznych obrazów testowych.

Powyższe funkcjonalności proszę przetestować na obrazach, których histogramy pokazują rozdzielność zakres poziomów szarości obiektów i tła (obrazy o histogramie dwumodalnym o głębokiej dolince) i obrazach o zawężonym zakresie tonów (brak wypełnienia tonacji skrajnie ciemnych i skrajnie jasnych) oraz o pełnym wykorzystaniu całego zakresu tonów.

## Laboratorium 3

### Zadanie 1

Opracowanie algorytmu i uruchomienie funkcjonalności realizującej operacje punktowe
wieloargumentowych:

- dodawania obrazów z i bez wysycenia
- dodawanie, dzielenie i mnożenie obrazów przez liczbę całkowitą z i bez wysycenia
- liczenia różnicy bezwzględnej obrazów.

### Zadanie 2

Opracowanie algorytmu i uruchomienie funkcjonalności realizującej operacje logiczne na obrazach
monochromatycznych i binarnych:

- not
- and
- or
- xor.

Przy okazji proszę umożliwić użytkownikowi zamianę obrazów z maski binarnej na maskę zapisaną na 8 bitach i na odwrót (jeśli w wybranym środowisku i języku jest to możliwe). Proszę pamiętać o sprawdzeniu zgodności typów i rozmiarów obrazów stanowiących operandy.

Proszę pamiętać: w operacjach jednopunktowych dwuargumentowych logicznych na obrazach działania prowadzone są na odpowiednich pikselach obrazów stanowiących argumenty danej operacji. W szczególności działania prowadzone są na bitach o tej samej wadze.

Proszę o przygotowanie własnych monochromatycznych i binarnych obrazów testowych.

## Laboratorium 4

Proszę dołączyć bibliotekę OpenCV i korzystać z niej przygotowując poszczególne funkcjonalności.

### Zadanie 1

Opracowanie algorytmu i uruchomienie funkcjonalności realizującej operacje:

- wygładzania liniowego oparte na typowych maskach wygładzania (uśrednienie, uśrednienie z wagami, filtr gaussowski – przedstawione na wykładzie) przestawionych użytkownikowi jako maski do wyboru,
- wyostrzania liniowego oparte na 3 maskach laplasjanowych (podanych w wykładzie) przestawionych użytkownikowi maski do wyboru,
- kierunkowej detekcji krawędzi w oparciu o maski 8 kierunkowych masek Sobela (podstawowe 8 kierunków) przestawionych użytkownikowi do wyboru,

Proszę zaimplementować wybór sposobu uzupełnienie marginesów/brzegów w operacjach sąsiedztwa według zasady wybranej spośród następujących zasad:

- wypełnienie ramki wybraną wartością stałą `n` narzuconą przez użytkownika: `BORDER_CONSTANT`
- wypełnienie wyniku wybraną wartością stałą `n` narzuconą przez użytkownika
- wyliczenie ramki według `BORDER_REFLECT`
- wyliczenie ramki według `BORDER_WRAP`

### Zadanie 2

Opracowanie algorytmu i uruchomienie aplikacji realizującej uniwersalną operację medianową opartą na
otoczeniu 3x3, 5x5, 7x7, 9x9 zadawanym w sposób interaktywny (wybór z list, przesuwanie baru lub
wpisanie w przygotowane pole). Zastosować powyższych metod uzupełniania brzegowych pikselach
obrazu, dając użytkownikowi możliwość wyboru, jak w zadaniu 1.

## Laboratorium 5

### Zadanie 1.

Implementacji detekcji krawędzi operatorami opartymi na maskach Sobela i Prewitta oraz operatorem
Cannyego.

### Zadanie 2.

Opracować algorytm i uruchomić funkcjonalność realizującą segmentację obrazów następującymi
metodami:

- Dostosowanie obsługi do wykonywania prostego interaktywnego progowania z jednym i dwoma progami (zad 2 lab 2) tak, aby prezentować wyniki w chwili zmiany progu związanego z przesunięciem wskaźnika lub wpisania nowej wartości.

  Ponadto jako część "interface" operacji występuje wykonanie pozostałych dwóch poniżej wymienionych wersji progowania:

  - Progowanie metodą Otsu,
  - Progowanie adaptacyjne (adaptive threshold).

## Laboratorium 6

### Zadanie 1.

Opracować algorytm i uruchomić funkcjonalność wykonywania podstawowych operacji morfologii
matematycznej: erozji, dylacji, otwarcia i zamknięcia wykorzystując podstawowy element strukturalny
dysk 3x3.

### Zadanie 2.

Opracować algorytm i uruchomić funkcjonalność realizującą wyznaczanie następujących składowych
wektora cech obiektu binarnego:

- a) Momenty
- b) Pole powierzchni i obwód
- c) Współczynniki kształtu: aspectRatio, extent, solidity, equivalentDiameter

Przygotować zapis wyników w postaci pliku tekstowego do wczytanie do oprogramowania Excel.

Program przetestować na podstawowych figurach znakach graficznych (gwiazdka, wykrzyknik, dwukropek, przecinek, średnik, itp.).
