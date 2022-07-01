# Przetwarzanie obrazów

## Wykład 1

### Podstawowe pojęcia: obraz, obraz cyfrowy, histogram obrazu i linia profilu obrazu cyfrowego. Model obrazu cyfrowego i historia powstania dziedziny zwanej przetwarzaniem i rozpoznawaniem obrazów.

Obraz to wynik obserwacji świata przedstawiony na ograniczonej płaszczyźnie.

Obraz cyfrowy w naukach technicznych i przyrodniczych to:
Zwarty, jednorodny i przestrzennie uporządkowany zbiór
sygnałów:

- związanych z cechą/cechami pomiarowymi, na bazie których
  tworzymy obraz (natężenie fali elektromagnetycznej,
  akustycznej, wielkości nie falowe np. czas relaksacji)
- dostosowanych do materialnego nośnika obrazu (papieru,
  kliszy, dyskietki, pamięci dyskowej itp.)
- niosących informację o odwzorowywanej rzeczywistości

Obraz to dyskretna dwuwymiarowa funkcja f(x, y) określona na ograniczonym fragmencie płaszczyzny, której wartości f to intensywność (jasność, kolor) w tym punkcie (x, y).

Zwarty, jednorodny i przestrzennie uporządkowany zbiór
sygnałów:

- związanych z cechą/cechami pomiarowymi, na bazie
  których tworzymy obraz (natężenie fali
  elektromagnetycznej, akustycznej, wielkości nie falowe
  np. czas relaksacji)
- dostosowanych do materialnego nośnika obrazu
  (papieru, kliszy, dyskietki, pamięci dyskowej itp.)
- niosących informację o > odwzorowywanej rzeczywistości

### Rozdzielczość obrazu.

- Rozdzielczość przestrzenna - określa stopień rozróżnialności detali; tym lepsza, im większa wartość N/na jednostkę długości. Jest wyrażana w jednostkach zwanych punktami na cal (ang. Dot per inch)
- Rozdzielczość poziomów szarości — określa ilość rozróżnianych poziomów szarości lub kolorów; tym lepsza, im większa wartość M. Jest dobierana tak, aby wartość M była potęgą liczby 2 — co ułatwia kodowanie.
- Inne rozdzielczości: całkowita, interpolowana, urządzeń prezentacjj obrazu jak monitor, drukarka, ploter, urządzeń akwizycji.

### Histogram

Histogram obrazu - struktura która pomija informacje o tym gdzie znajduje się piksel, zlicza tylko poziomy jasności w formie wykresu słupkowego. Wysokość słupka odpowiada ilości wystąpień potencjalnego poziomu jasności występującego w obrazie.

Histogram to wykres słupkowy przedstawiający ilość pikseli o każdej potencjalnej wartości występującej w obrazie.

- Statystyka odzwierciedlająca rozkład jasności punktów w obrazie.
- Pewna estymata rozkładu jasności oryginalnego obrazu analogowego i rzeczywistości.

### Proces akwizycji obrazów cyfrowych: pojęcia próbkowania przestrzennego i tonalnego (poziomów szarości).

Akwizycja obrazu to przetworzenie informacji o fizycznym obiekcie do postaci zbioru danych dyskretnych nadających się do zapisania w pamięci komputera.

Akwizycja (pozyskiwanie, zbieranie) obrazu - przetworzenie informacji o fizycznym obiekcie lub scenie do postaci zbioru danych dyskretnych (f(x,y) - obraz cyfrowy) nadających się do zapisania w pamięci komputera, a następnie do wyświetlenia, drukowania i dalszego przetwarzania za pomocą odpowiedniego oprogramowania.

Elementy procesu akwizycji:

1. Oświetlenie obrazu.
2. Formowanie obrazu (optyczne).
3. Detekcja obrazu.
4. Formowanie wyjściowego sygnału z urządzenia (kamera, skaner)

Elementy procesu akwizycji

1. Formowanie obrazu/sygnału (optyczne, akustyczne, inne)
2. Detekcja sygnału przez czujniki analogowo-cyfrowe.
   Formowanie kodu obrazu (kamera,
   skaner, MRI, USG).

Matryce CCD są elementami pozyskiwania obrazu

- Płaska periodyczna struktura dyskretna, której elementy zmieniają wiatło na prąd o napięciu proporcjonalnym do jasności.

Cechy procesu akwizycji:

- nakładanie szumu
- nakładanie zniekształceń

Dyskretyzacja obrazu to dyskretyzacja funkcji f
(x,y) na dwóch poziomach:

- przestrzenna (próbkowanie dziedziny funkcji)
- amplitudowa (kwantyzacja wartości funkcji)

Obraz jest więc strukturą podwójnie dyskretną

### Charakterystyka obrazów cyfrowych: szum akwizycji, zniekształcenia obrazu.

Szum - przypadkowe, niestacjonarne zakłócenia wartości sygnału w czasie i/lub w przestrzeni.

Rodzaje szumu:

- szum niskoczęstotliwościowy
- szum wysokoczęstotliwościowy
- szum o małej amplitudzie
- szum o dużej amplitudzie

Szum w aparatach cyfrowych wynika z:

- parametrów technicznych matrycy fotoczułej
- niestabilności światła lub z jego niewielkiej ilości
- zjawisk towarzyszącch zamianie światła na prąd
- nałożenia termicznych ruchów elektronów na mierzony sygnał

Szum powstaje na skutek

- Nałożenia termicznych ruchów elektronów w materii na
  mierzony sygnał, który jest zamieniany na prąd (np.: w
  przetwornikach zamieniających światło na prąd zgodnie
  ze zjawiskiem fotoelektrycznym)
- Niestabilności źródła formowania sygnału, np.:
  promieniowania X, fali akustycznej czy radiowej;
  Zrozumienie zjawiska i jego przyczyn zwykle
  prowadzi do unikania zaszumienia, a nie do jego
  likwidacji czy choćby redukcji

### Sposoby walki z szumem akwizycji.

Redukcja szumu:

- Na poziomie akwizycji:
- Wybór maksymalnie długiego czasu naświetlania
- Wybór niskich czułości ISO
- Chłodzenie matrycy
- Wykonywanie zdjęć wielokrotnych (braketing)
- Wykonywanie zdjęć lekko prześwietlonych (HighKey)
- Na poziomie przetwarzania (obróbki) obrazów:
- Uśrednianie zdjęć wielokrotnych
- Filtrowanie
- Uwaga: Nie redukujemy szumu przez
- Rozjaśnianie obrazu w miejscach niedoświetlenia
- Rozjaśnianie cieni w obrazie

- Uśrednianie czasowe (dotyczy obrazów statycznych)
- Uśrednianie przestrzenne (obrazy statyczne oraz zmienne w czasie)

### Różnica miedzy obrazem zawierającym wielkości pomiarowe (typu RAW) a obrazami generowanymi przez typowe aparaty cyfrowe.

## Wykład 2

### Pozostałe aspekty charakterystyki obrazów cyfrowych w kontekście ich inherentnych cech związanych z procesem akwizycji (powstawaniem szumu i zniekształceń obrazu) w szczególności zniekształaceń radiometrycznych, geometrycznych i chromatycznych.

Zniekształcenia obrazu w procesie akwizycji:

- Zniekształcenia radiometryczne to zniekształcenia odczytu wartości cechy, na podstawie której tworzymy obraz;
- nierównomiernością oświetlenia,
- błędami konwersji oświetlenie — sygnał elektryczny (tzn. błędami detekcji, uszkodzeniami przetworników)
- Zniekształcenia geometryczne to zniekształcenia odczytu położenia
  odczytanych wartości względem siebie
  dla obrazów kolorowych i wielospektralnych
- Zniekształcenia (aberracje) chromatyczne to zniekształcenia wynikające z charakterystyki współczynnika odbicia lub przejścia przez ośrodek fali elektromagnetyczne o różnej długości

Celem wstępnego przetwarzania obrazu jest redukcja zniekształceń obrazu powstałych w procesie akwizycji.

Zniekształcenia geometryczne

Zniekształcenia geometryczne (dystorsje) są spowodowane:

- nieliniowością układów optycznych wchodzących w skład toru
  optycznego np.: mikroskopu
- nierównoległością płaszczyzn obrazu i matrycy światłoczułej np.:
  krzywizna Ziemi w zdjęciach satelitarnych, zmienna wysokości
  powierzchni ziemi w zdjęciach do sporządzania map, skaningowy
  mikroskop elektronowy,
- obrotem płaszczyzn obrazu i matrycy światłoczułej np.: skróty
  perspektywy
- zmianami skali

  lub połączeniem powyżej wymienionych.

Konieczność usuwania zniekształceń geometrycznych:

- Pomiary odległości i pól powierzchni,

* Dopasowywanie obiektów na obrazach,
* Dopasowywanie obrazów na potrzeby rekonstrukcji obrazu z  fragmentów,
* Tworzenie map, planów na podstawie zdjęć,

- Nakładania obrysów mapy na zdjęcia satelitarne, pogodowe.
- Nakładanie map rozkładu potencjału elektrycznego na
  powierzchnie 3D.
  Realizacja korekcji zniekształceń geometrycznych
- Aproksymacja transformacji wielomianem

* Przekształcenia rozciągające

- Przekształcenia afiniczne

### Omówienie procesu akwizycji obrazu na podstawie aparatu fotograficznego ze zwróceniem uwagi na źródła zniekształceń radiometrycznych, geometrycznych i chromatycznych.

Jak to się dzieje, że aparat fotograficzny jest w stanie przedstawiać rozpoznawalną rzeczywistość?

1. Aby obraz był uformowany, musi być oświetlony, rzut tego obrazu musi w całości padać na mozaikę fotoczułą.

2. Mozaika fotoczuła jest złożona z trzech filtrów (czerwony, zielony, niebieski),

Najważniejsze elementy formowania sygnału w procesie akwizycji

Dyskretyzacja obrazu to dyskretyzacja funkcji $f(x,y)$ na dwóch poziomach:

- przestrzenna (próbkowanie dziedziny funkcji)
- amplitudowa (kwantyzacja wartości funkcji)

Inherentne cechy procesu akwizycji

- Nakładanie szumu i delikatnego rozmycia krawędzi
  (dla aparatu cyfrowego — szumu kwantyzacji, czyli
  odpowiednika ziarna dla tradycyjnej fotografii oraz s-owaty
  kształt linii profilu przechodzącej przez krawędzie)
- Nakładanie zniekształceń
  (dla aparatu cyfrowego - zniekształcenia obiektywów
  szerokokątnych, dystorsje soczewek, gorące i zimne pisksle
  w matrycy, halo na około obiektów fotografowanych na tle
  nieba)

Urządzenia akwizycji charakteryzuje się przez podanie
informacji o poziomie szumu i rozmycia krawędzi oraz zakłóceń
radiomatrycznych, geometrycznych i chromatycznych

### Przedstawienie sprzętowych i programowych sposobów walki z zniekształceniami wprowadzanymi w procesie akwizycji.

Zniekształcenia obrazu w procesie akwizycji:

- Zniekształcenia radiometryczne to zniekształcenia odczytu wartości cechy,
  na podstawie której tworzymy obraz;
- nierównomiernością oświetlenia,
- błędami konwersji oświetlenie — sygnał elektryczny (tzn. błędami detekcji, uszkodzeniami
  przetworników)
- Zniekształcenia geometryczne to zniekształcenia odczytu położenia
  odczytanych wartości względem siebie
  dla obrazów kolorowych i wielospektralnych
- Zniekształcenia (aberracje) chromatyczne to zniekształcenia wynikające z
  charakterystyki współczynnika odbicia lub przejścia przez ośrodek fali
  elektromagnetyczne o różnej długości
  Celem wstępnego przetwarzania obrazu jest redukcja zniekształceń obrazu powstałych w
  procesie akwizycji

Szum powstaje na skutek

- Nałożenia termicznych ruchów elektronów w materii na mierzony sygnał, który jest zamieniany na prąd (np.: w przetwornikach zamieniających światło na prąd zgodnie ze zjawiskiem fotoelektrycznym)
- Niestabilności źródła formowania sygnału, np.: promieniowania X, fali akustycznej czy radiowej;

Zrozumienie zjawiska i jego przyczyn zwykle
prowadzi do unikania zaszumienia, a nie do jego
likwidacji czy choćby redukcji

Miara szumu

Stosunek sygnału do szumu (ang. signal to noise ratio — SNR), jednostka decybele dB.

Brak "odczuwania" szumu oznacza, że jego stosunek do sygnału jest taki, że nasze sensory (wzrokowe, słuchowe) odbierają sygnał a pomijają szum.

Szum nakładany na obraz powstały w cyfrowym aparacie wynika z:

- Parametrów technicznych matrycy fotoczułej (wielkość sensora)
- Niestabilności światła lub z jego niewielkiej ilości (nocą)
- Zjawisk towarzyszących zamianie światła na prąd (ang. banding noise, trunced, .. )
- Nałożenia termicznych ruchów elektronów na mierzony sygnał

Szum w obrazach cyfrowych zależny od:

- typu (egzemplarza) aparatu cyfrowego
- od ustawień przy wykonywaniu zdjęcia (czułość ISO, czas naświetlenia)
- jasności fotografowanych obiektów i obszarów (w cieniach szumu jest więcej niż w tonach jasnych)
- temperatury otoczenia - im wyższa tym silniej widać (ang. Fixed pattern noise)

- Na poziomie akwizycji:
  - Wybór maksymalnie długiego czasu naświetlania
  - Wybór niskich czułości ISO
  - Chłodzenie matrycy
  - Wykonywanie zdjęć wielokrotnych (braketing)
  - Wykonywanie zdjęć lekko prześwietlonych (HighKey)
- Na poziomie przetwarzania (obróbki) obrazów:
  - Uśrednianie zdjęć wielokrotnych
  - Filtrowanie
- Uwaga: Nie redukujemy szumu przez
  - Rozjaśnianie obrazu w miejscach niedoświetlenia
  - Rozjaśnianie cieni w obrazie

### Proces korekcji radiometrycznej

#### Korekcja sumacyjna jednorodnego jasnego obrazu odniesienia

$$P_{KORA}(x,y) = P_{od}(x,y) - KORA(x,y)$$

- $KORA(x,y)$ - wartość (poziom jasnosci) piksela obrazu przy zasłoniętym obiektywie (ciemny braz odniesienia)
- $P_{od}(x,y)$ - wartość piksela jednorodnego jasnego obrazu odniesienia
- $P_{KORA}(x,y)$ - Wartość piksela jednorodnego jasnego obrazu odniesienia po korekcji sumacyjnej

#### Korekcja iloczynowa

$$ Pkoam (XV) = [P(xy) — KORA(x,y)] + KORM (Gy)$$

- $P(x,y)$ - wartość piksela obrazu wejściowego
- $KORM(x,y)$ — wartość współczynnika korekcji dla piksela o współrzędnych (x,y) obliczona według wzoru:
  $$KORM (x,y)= P_{KORA max} / P_{KORA}(GV)$$
- \$P\\_{KORAmax} - Maksymalna wartość piksela w obrazie \\$[P\\_{KORA}(X, Y)]\$
- $P_{KORM}(x,y)$ - wartość piksela obrazu wynikowego (po korekcji radiometrycznej)

### Przedstawienie ogólnego schematu przetwarzania i analizy obrazów.

Operacje na obrazach

Metody w przetwarzaniu obrazów ze względu na sposób
liczenia:

- Globalne (operacje na wszystkich pikselach obrazu)
- Lokalne (operacje na ROI; ang. region of interest)
  - Punktowe;
  - Małym otoczeniu

Ze względu na typy matematycznych (w tym arytmetycznych, logicznych, statystycznych) operacji, które są wykonywane na wartościach intensywności.

Funkcje operacji na obrazach będą omawiane przy każdej operacji
oddzielnie.

### Definicja operacji na obrazach i ich podział ze według na kryteria matematyczne, zasięg informacji obrazawej potrzebnej do otrzymania wyniku i ze względu na ich funkcje i rezultaty.

Operacje punktowe

Proste:

- operacje jednoargumentowe —
  transformacje jasności
- operacje arytmetyczne: jedno-,
  dwu- i wieloargumentowe
- manipulowanie histogramem

Zaawansowane:

- metody progowania
- wyrównywanie histogramu
- klasyfikacja punktów obrazu

### Omówienie operacji jednopunktowych jednoargumentowych.

Są to operacje, w których na wartość zadanego piksela obrazu wynikowego o współrzędnych (i, j) ma wpływ wartość tylko jednego piksela obrazu pierwotnego o współrzędnych (i, j):

[q(i, j)] =f [p(i, j)] f - operator (liniowy lub nieliniowy)

- [p(i, j)] - obraz pierwotny
- [q(i, j)] - obraz wynikowy
- p(i,j), q(i,j) - wartości piksela o współrzędnych (i, j)
  obrazu pierwotnego i wynikowego

### Analiza działania operacji punktowych jednoargumentowych oraz ich wykorzystanie do poprawy jakości i czytelności obrazu.

Wartość piksla obrazu wyjściowego zależy od wartości piksla o takich samych współrzędnych na obrazie wejściowym (nie uwzględniamy sąsiedztwa)

Wykonywanie po wierszach, "piksel po pikselu"

Operacje punktowe

Definiowane przez:

- Definicję funkcji; z jawnie postawionymi warunkami logicznymi np.: dla UOP (Uniwersalnego Operatora Punktowego);
- Wykres funkcji we współrzędnych OXY; na osi OX są wszystkie potencjalne wartości poziomów szarości obrazu pierwotnego P, a na OY obrazu po przekształceniu Q;
- Tablica przekodowań (LUT— Look Up Table).

### Wykorzystanie tablicy LUT jako formy zapisu histogramu lub operacji jednopunktowej.

Operację punktową można zapisać jako definicję matematyczną, jako wykresu funkcji, oraz jako tablicę przekodowań LUT.

LUT to pojedyncza tablica wartości z przedziału od minimalnej do maksymalnej poziomu jasności, o liczbie elementów od 0 do Lmax. Nowy poziom jasności jest pobierany z indeksu równego bieżącemu poziomowi jasności.

### Manipulowanie tablicą LUT stanowiącą Uniwersalny Operator Punktowy (UOP).

## Wykład 3

### Operacje punktowe wieloargumentowe (arytmetyczne i logiczne).

Operacje jednopunktowe dwuargumentowe i wieloargumentowe

Są to operacje, w których na wartość zadanego piksela
obrazu wynikowego o współrzędnych $(i,j)$ mają wpływ
tylko wartości pikseli obrazów pierwotnych
(argumentów) o współrzędnych $(i,j)$:

$$ C_{ij} =f_D(a_{ij}, b_{ij}) $$

- $f_D$ - operacja arytmetyczna lub logiczna (dodawanie,
  odejmowanie, mnożenie, dzielenie, NOT, OR, AND, XOR...)

- $c_{i,j}$- wartość piksela obrazu wynikowego (w przypadku
  otrzymania ułamka następuje zaokrąglenie do najbliższej
  liczby całkowitej(lub obcięcie))
- $a_{i,j}, b_{i,j}$ - wartości pikseli obrazów pierwotnych

Operacje punktowe wieloargumentowe

Wykonywane na dwóch lub większej liczbie obrazów

- Dodawanie (uśrednianie)
- Odejmowanie (różnica i różnica bezwzględna)
- Mnożenie
- Dzielenie
- AND
- OR
- XOR
- Uśrednienie obrazów

Dodatkowo jednoargumentowe - pominięte

- NOT
- Pseudokolor

### Wstęp do operacji sąsiedztwa.

Operacje kontekstowe (sąsiedztwa)

Są to operacje, w których na wartość zadanego piksela
obrazu wynikowego współrzędnych (ij) mają wpływ
wartości:

- pikseli o współrzędnych (i,j) obrazu pierwotnego p, oraz
- pikseli go otaczających, czyli tzw. otoczenia

Otoczenie definiujemy określając jego:
— Kształt: kwadratowe, prostokątne, kołowe
— Wielkość: 3x3, 5x5, 7x7, 9x9, 11x11, itd..

Funkcje operacji sąsiedztwa:

— Wygładzanie (całkowanie przestrzenne)
wytłumianie szumu
— Uwypuklające krawędzie (różniczkowanie przestrzenne)
wydobywanie informacji przez zwiększenie kontrastu
— Konturowanie (operatory oparte na gradientach,
laplasjany, różniczki przestrzenne)
wydobywanie informacji przez wskazanie ”zera”
— Analiza kształtu i położenia obiektów
(morfologia matematyczna)

Matematyczny podział operacji
sąsiedztwa

- Liniowe (oparte na pewnej liniowej operacji, polegającej na
  wykonaniu liniowej kombinacji wartości wybranych piksli
  obrazu wejściowego)
- Są proste w implementacji, tak na poziomie oprogramowania, jaki
  procesorów sprzętowych.
- Łączne i separowalne (rozdzielcze), przemienne.
- Dają efekty odpowiadające manipulacji pewnymi zakresami
  częstotliwości.
- Nieliniowe (oparte na funkcjach nieliniowych, np.
  statystycznych, logicznych i morfologii matematycznej)
- Są czasochłonne i często skomplikowane.
- Mają bogatsze możliwości.
- Nie można ich interpretować w kategoriach manipulowania tylko
  określonymi częstotliwościami

### Omówienie operacji uśredniających o jednakowych i niejednakowych wagach (w tym o wagach odpowiadających dwuwymiarowej funkcji Gaussa) jako przykład operacji liniowych (konwolucyjnych).

Operacje wygładzania stanowią praktyczną realizację filtracji dolnoprzepustowej (FD) i dzielą się na operacje
filtracji liniowej i nieliniowej.

Operacje filtracji nieliniowej dzielą się na operacje filtracji
logicznej i medianowej.

Operacje wyostrzania stanowią praktyczną realizację filtracji górnoprzepustowej (FG) i dzielą się na operacje filtracji gradientowej i laplasjanowej.

Podstawowe zadanie wygładzania: usuwanie zakłóceń z obrazu
Filtracja liniowa (metody konwolucyjne, tzn. uwzględniające pewne
otoczenie przetwarzanego piksela):

$$g(x,y) = \sum_{k=1}^n w_k f_k(x,y)$$

- $n$ - liczba punktów (pikseli) otoczenia wraz z pikselem przetwarzanym
- $f(x,y)$ - wartość piksela o współrzędnych x,y obrazu pierwotnego
- $g(x,y)$ - wartość piksela o współrzędnych x,y obrazu wynikowego
- $w_k$ - waga k-tego piksela otoczenia

Sposoby zapisu operacji filtracji liniowej (wygładzanie liniowe)

1. Za pomocą macierzy wag
2. Za pomocą maski filtracji dolnoprzepustowej (FD)

Macierz wag

$$
\left[
\begin{array}{ccc}
1/9 & 1/9 & 1/9 \\
1/9 & 1/9 & 1/9 \\
1/9 & 1/9 & 1/9
\end{array}
\right]
$$

Maska filtracji dolnoprzepustowej

$$
\left[
\begin{array}{ccc}
1 & 1 & 1 \\
1 & 1 & 1 \\
1 & 1 & 1
\end{array}
\right] K = 9
$$

K - współczynnik maski

### Wprowadzenia nieliniowych operacji sąsiedztwa (logicznych i statystycznych) prowadzących do efektów w postaci wygładzania obrazu.

Operacje wyostrzania

Metoda: konwolucja + maska filtracji górnoprzepustowej(FG).
W wyostrzaniu stosuje się metody numeryczne aproksymujące
pochodną.

Zadanie wyostrzania:

- podkreślenie na obrazie konturów obiektów
- podkreślenie na obrazie punktów informatywnych (np.
  wierzchołki dla wielokątów, zakończenia, skrzyżowania,
  rozgałęzienia linii dla rysunków technicznych, wykresów lub
  pisma).

Inne zadania wyostrzania: wydobycie i uwypuklenie krawędzi obiektu.

Detekcja (wykrywanie) krawędzi (edge detection)

Jest to technika segmentacji obrazu, polegająca na znajdowaniu pikseli
krawędziowych przez sprawdzanie ich sąsiedztwa.

Krawędź

Zbiór pikseli na krzywej mający taką właściwość, że
piksele w ich sąsiedztwie, lecz po przeciwnych stronach
krzywej mają różne poziomy jasności.

Cel detekcji

znalezienie lokalnych nieciągłości w poziomach jasności
obrazu oraz granic obiektów zawartych w obrazie.

Opis matematyczny operacji wyostrzania

Model krawędzi: linia prosta separująca dwa obszary o różnej intensywności (jasności) $l_1$, i $l_2$.

Użycie funkcji $u(z)$ do matematycznego opisu krawędzi

$$
\begin{array}{ll}
1 & \text{dla } z>0 \\
\frac12 & \text{dla } z=0 \\
0 & \text{dla } z<0
\end{array}
\right. $$

Jeśli $\delta(t)$ - impuls Diracta, to:
$$

Założenia:

Krawędź leży wzdłuż linii prostej opisanej równaniem:

$x \sin\phi -y\cos\phi+p=0$ (postać normalna prostej)

Intensywność obrazu:
$$f(x,y)=I_1,+(I_2-I_1) u (x\sin\phi-y\cos\phi+\rho)$$

Cyfrowa wersja gradientu i laplasjanu.

### Porównanie operacji: a) liniowych i nieliniowych; b) punktowych i sąsiedztwa z podziałam na liniowe i nieliniowe.

Operacje punktowe - podsumowanie

- Zalety: łatwe do implementacji i szybkie
- Implementowane przez LUT (manipulacje na palecie szarości lub barw) bo dziedzina funkcji jest skończona
- Dla różnowartościowych funkcji (bezstratnych) istnieją przekształcenie odwrotne
- Dla nieróżnowartościowych funkcji (stratnych) nie istnieją przekształcenie odwrotne - większość praktycznie stosowanych
- Wady: ignorują przestrzenną zależność wartości intensywności w obrazie tzn. lokalną charakterystykę przestrzenną obrazu

Matematyczny podział operacji sąsiedztwa

- Liniowe (oparte na pewnej liniowej operacji, polegającej na
  wykonaniu liniowej kombinacji wartości wybranych piksli
  obrazu wejściowego)
- Są proste w implementacji, tak na poziomie oprogramowania, jaki
  procesorów sprzętowych.
- Łączne i separowalne (rozdzielcze), przemienne.
- Dają efekty odpowiadające manipulacji pewnymi zakresami
  częstotliwości.
- Nieliniowe (oparte na funkcjach nieliniowych, np.
  statystycznych, logicznych i morfologii matematycznej)
- Są czasochłonne i często skomplikowane.
- Mają bogatsze możliwości.
- Nie można ich interpretować w kategoriach manipulowania tylko
  określonymi częstotliwościami

### Laplasjany i różnica między nimi a wygladzającymi filtrami konwolucyjnymi.

### Metody operacji na pikselach wchodzących w skład skrajnych kolumn i wierszy

1. Pozostawienie wartości pikseli bez zmian
2. Wartości pikseli są nieokreślone (xxxxxxxxxx)
3. Nadanie pikselom wartości arbitralnie zadanych przez użytkownika (np. same wartości "0", "15", "10" itd.
4. Operacje z zastosowaniem kolumn i wierszy pomocniczych (zdublowanie (powielenie) skrajnych wierszy i kolumn)
5. Operacje z wykorzystaniem pikseli z istniejącego sąsiedztwa.

- Lewa skrajna kolumna (oprócz pikseli górnego i dolnego rogu) — kierunki
  0,1,2,6,7,
- Lewa skrajna kolumna piksel w górnym rogu — kierunki 0, 6,7,
- Lewa skrajna kolumna (piksel w dolnym rogu) — kierunki 0,1,2,
- Prawa skrajna kolumna (oprócz pikseli górnego i dolnego rogu) — kierunki
  2,3,4,5,6,
- Prawa skrajna kolumna piksel w górnym rogu — kierunki 4,5,6,
- Prawa skrajna kolumna (piksel w dolnym rogu) — kierunki 2,3,4,
- Górny skrajny wiersz (oprócz pikseli z lewego i prawego rogu) — kierunki 4,5,6,7,0
- Dolny skrajny wiersz (oprócz pikseli z l ewego i prawego rogu) — kierunki 0,1,2,3,4.

## Wykład 4

### Operacje sąsiedztwa oparte na matematycznych operacjach wyliczania gradientu, pierwszej i drugiej pochodnej.

### Operacje kierunkowych gradientów i operatorów gradientowych pokazujących wartości skoku w otoczeniu analizowanego piksela oraz operacje sąsiedztwa oparte o laplasjany

### Porównanie operacji sąsiedztwa: a) opartych na uśrednianiu i opartych na gradientach; b) gradientowych i laplasjanowych oraz c) filtrów kierunkowych i operatorów gradientowych

### Operacje morfologii matematycznej i ich porównanie z operacjami konwolucyjnych oprecji filtracji

Operacje morfologiczne

Są to operacje, w których modyfikacja danego piksla obrazu jest uzależniona od kształtu elementu strukturalnego (wzorca) użytego w danej operacji oraz od spełnienia zadanego warunku logicznego.

Metody te oparte o matematycznej teorii zbiorów i poszukują i uwypukla lub wyrzucają cech, które ujawniają się w obrazie/obiekcie w kontekście narzędzia badawczego, którym jest element strukturalny

Cel: przygotowanie poszczególnych elementów obrazu do etapu analizy obrazów

Główna cecha różniąca operacje morfologiczne od operacji punktowych i operacji sąsiedztwa:

W operacjach morfologicznych przekształcana jest tylko ta część pikseli obrazu,
których otoczenie jest zgodne z elementem strukturalnym — koincydentne

Operacje morfologii matematycznej na obrazach

Pozwalają na budowanie złożonych operacji nieliniowych, do analizę kształtu i wzajemnego położenia obiektów.

Fundamentalne pojęcie: element strukturalnym (strukturujący) — podzbiór obrazu z wyróżnionym punktem, zwanym często punktem centralnym

- w elemencie strukturalnym występują następujące symbole:
- 1 element wskazuje piksel zapalony tzn. wartość obiektu w
  masce binarnej
- 0 element wskazuje piksel wytłumiony tzn. wartość tła w
  masce binarnej
- X element wskazuje dowolną wartość tzn. wartość tła lub obiektu w masce binarnej

Przekształcenia polegają na pozostawieniu lub zmianie intensywności według pewnej funkcji skojarzonej z nazwą funkcji punktu przykrytego przez punkt centralny elementu strukturalnego jeśli jego otoczenie nie ma lub ma zgodność z założeniami zakodowanemu symbolami w elemencie strukturalnym.

Operacje morfologiczne przekształcają tylko część punktów obrazu

### Podstawowe operacje morfologii matematycznej erozja, dylacja, otwarcie, zamknięcie i ich interpretacja oraz wyniki dzialania na obrazów binarnych i w odcieniach szarości

Operacje morfologiczne

Operacje morfologiczne binarne działają na tzn. maskach czyli obrazach binarnych, w którym obiekty oznaczone są „1” a tło „O” lub na obrazach w odcieniach szarości, ale korzystając z uogólnionej definicji

Element strukturalny jest przemieszczany po wszystkich punktach obrazu tak, że punkt centralny elementu strukturalnego jest nakładany na kolejne punkty w kolejnych wierszach.

W każdym położeniu elementu sprawdza się, czy rzeczywista konfiguracja punktów jest zgodna (koincydentna) ze wzorcem zawartym w elemencie strukturalnym zakodowanym symbolami 1, 0, X.

W przypadku wykrycia zgodności jest wykonywana operacja związana z filtrem, a w przeciwnym przypadku wartość występująca w obrazie pierwotnym jest przepisywana.

Jeśli punkt otoczenia jest wygaszony (równy wartości tła - 0) przy zapalonym (większym od tła - 1) elemencie centralnym, element pod elementem centralnym zostaje wygaszany — zrównany z tłem, a w przeciwnym wypadku zostawiamy jego poprzednią wartość.

Przykładowe operacje morfologiczne

- Erozja — oparta o różnicę Minkowskiego;

Def.: jeżeli choć jeden piksel z sąsiedztwa określonego elementem strukturalnym ma wartość "O" to punkt centralny otrzymuje wartość "0", w przeciwnym przypadku jego wartość nie ulega zmianie

- dylatacja — oparta o sumę Minkowskiego;

Def.: jeżeli choć jeden piksel z sąsiedztwa określonego elementem strukturalnym ma wartość "1" to punkt centralny otrzymuje wartość "1", w przeciwnym przypadku przyjmuje wartość "0"

- Otwarcie - złożenie erozji i dylatacji,

Operacja morfologiczna, która opiera się na dwóch innych
operacjach: erozji i dylatacji. Otwarcie polega na wykonaniu
na obrazie najpierw erozji (minimum), a następnie na tak
przetworzonym obrazie należy zastosować dylatację
(maksimum) na tym samym elemencie strukturyzyjącym.

- Zamknięcie — złożenie dylacji i erozji.

Operacja morfologiczna, która opiera się na dwóch innych operacjach: dylatacji i erozji. Zamknięcie polega na wykonaniu na obrazie najpierw dylatacji (maksimum), a następnie na tak przetworzonym obrazie należy zastosować erozję (minimum) na tym samym elemencie strukturyzyjącym.

### Niektóre zaawansowanie operacje morfologii matematycznej: gradient morfologiczny, ekstrakcja konturów, pocienienie i pogrubianie

- Pocienianie
  Zmniejszenie obiektu o piksele będące jego krawędzią.
- Pogrubianie
  Zwiększenie obiektu o dodatkowe piksele tła stykające się z krawędzią obiektu.
- Ekstrakcja konturu
  Kolejność działań: 1) operacja erozji obrazu, 2) odjęcie wyniku erozji od obrazu pierwotnego. W wyniku otrzymujemy kontur obiektu.
- Szkieletyzacja
  Operacja, która wykrywa szkielet obiektu. Przykładowy algorytm szkieletyzacji: 1) obliczyć, ile erozji można wykonać, aby obraz nie został sprowadzony do tła, 2) wykonać obliczoną ilość razy erozję i otwarcie. Wyniki kolejnych kroków erozji i otwarcia należy od siebie odjąć. Wyniki odejmowania z kolejnych kroków należy wstawić w obraz wynikowy.
- Gradient morfologiczny (= Otwarcie+Zamknięcie)
- Wygładzanie morfologiczne (=Dylacja—Erozja)
- Odcinanie gałęzi (artefaktów z nieregularności obiektów szkeletyzowanych)
- Detekcja centroidów (punktów centralnych obiektu)
- Dylatacja bez styków (SKIZ ang. Skeleton by influece zone)
- Erozja warunkowa
- Automediana

### Rozszerzenia definicji operacji podstawowych na obrazy w odcieniach szarości.

## Wykład 5

## Operacje globalne na obrazach – transformaty (transformacja Fouriera i transformacja Hough’a).

### Operacje globalne - transformaty.

Są to operacje, w których na wartość zadanego piksela obrazu wynikowego q o współrzędnych (ij) mają wpływ wartości wszystkich pikseli obrazu pierwotnego p, czyli są to operacje kontekstowe dla których otoczeniem piksela jest cały obraz p.

- Transformacje
- Fouriera (matematyczny pryzmat)
- kosinusowa
- Falkowa (matematyczny mikroskop)
- Hough'a
- Odległościowa (morfologia matematyczna)
- Inne globalne
- Skalowanie rozmiarów
- Rejestracja multimodalna i multisesyjna

### Transformata Fouriera, jej rola w przetwarzaniu i analizie obrazów: 1) poszukiwania kierunkowości i periodyczności w obrazie oraz 2) dokonywanie manipulacji zawartością obrazu w dziedzinie częstotliwości.

Transformata

Przekształcenie matematyczne odwracalne i bezstratne, przenoszące sygnał z jednej przestrzeni w inną, w której wygodniej dokonywać pewnych analiz lub procesów (np.: kompresji informacji), ponieważ w przestrzeni docelowej uwypuklane są cechy sygnału istotne z punktu widzenia celu analizy lub przetwarzania.

W przestrzeni docelowej sygnał jest dekomponowany ze względu na zbiór funkcji bazowych tej przestrzeni.

Transformata Fouriera

Główne zastosowanie: — poprawa jakości sygnału według przyjętego kryterium

Interpretacja częstotliwościowa filtracji

Transformata Fouriera: to transformacja która przenosi obraz (dyskretny sygnał dwuwymiarowy) z dziedziny oryginalnej do dziedziny częstotliwości przestrzennych.

Do czego wykorzystujemy FFT w przetwarzaniu obrazów

- Do obserwacji periodyczności w obrazie
- Do wyznaczania kierunku struktur w obrazie
- Do wytłumiania lub wzmacniania pewnych kategorii informacji
- Do wygładzania i wyostrzania obrazu

## Filtracja górnoprzepustowa (low pass filters) i dolnoprzepustowa (High pass filters) z wykorzystaniem reprezentacji częstotliwościowej obrazu.

## Praktyczne przykłady wykorzystania transformaty Fouriera w przetwarzaniu i analizie obrazów.

### Porównanie wyników filtracji dolno- i górnoprzepustowej wykonywanej w dziedzinie częstotliwości z filtracją konwolucyjną za pomocą odpowiednich filtrów.

### Przykład wykorzystanie analizy różnych zakresów częstotliwości do rozwikłania tajemnicy obrazu Mony Lizy Leonarda DaVinci.

### Transformata Hougha i jej działanie.

Detekcja krawędzi z wykorzystaniem Transformaty Hougha

Detekcja linii daje rezultaty w postaci fragmentów prostej lub krzywej, grupy pikeseli (piksele) poszukiwanej krawędzi.

Metoda detekcji krzywych analitycznych (jak w zapisie wektorowym obrazu) nie pikseli (!)) przez transformatę wynikającą z dualności pomiędzy punktami na krzywej a parametrami tej krzywej.

Krzywa analityczna o postaci f(x,a) = 0 gdzie x — punkt obrazu, a - wektor parametrów.

Zaleta:

działa dobrze nawet wówczas, gdy ciągłość krawędzi nie jest zachowana i oprócz punktów krawędzi występują dodatkowe elementy (najczęściej z powodu szumów).

Założenia:

Piksele o niezerowej wartości są elementami krawędzi (obraz po krawędziowaniu).
Jeśli piksel (x,y) leży na prostej > znaleźć zbiór wartości (p, \$) w przestrzeni
parametrów tej prostej.

(x,y) - stałe, (p, b) - zmienne — równanie normalne prostej przedstawia relację
pomiędzy krzywą w przestrzeni parametrów, a punktem w obrazie.

Punkt (x,y) leży na prostej — krzywa w przestrzeni parametrów to sinusoida
TH - transformacja pomiędzy punktami obrazu a przestrzenią parametrów
poszukiwanej krzywej.

Równanie normalne prostej: $x\cdot\cos\phi+y\cdot\sin\phi = \rho$

## Kompresja obrazów.

Rodzaje kompresji (kodowania)

- Bezstratna (ang. lossless coding) odwracalna (ang. reversible) redukcja redundancji statystycznej (ang. statistical redundancy) w czasie i przestrzeni
- Stratna (ang. lossy coding) nieodwracalna (ang. irreversible)
  redukcja redundancji subiektywnej (ang. subjective redundancy), dotycząca nieistotnej informacji (ang. irrelevancy),
  z lub bez uwzględnienia charakterystyki słuchu i wzroku człowieka
- "Prawie" bezstratna lub percepcyjnie bezstratna, tzn. stratna, ale poziom zmian względem oryginału nie jest odczuwany przez człowieka

## Wykład 6

### Percepcji koloru i jasności przez oko ludzkie

Barwa to zarówno kombinacja fizycznych (spetralnych) własności światła jaki i sposób jego interpretacji przez ludzkie oko i mózg.

Różne długości fali elektromagnetycznej z zakresu widma widzialnego (380 - 760 nanometrów) są odbierane jako barwy, a ich mieszanina jako światło białe

Uwaga! Jednakowe bodźce barwne wywołują jednakowe wrażenia, ale takie samo wrażenie mogą wywołać bodźce różniące się fizycznym (spektralnym) składem promieniowania elektromagnetycznego (metam eryzm)

Barwa

Fizycznie: długość fali

Subiektywnie: to co odróżnia zieleń od błękitu a jest wspólne dla różnych
odcieni czerwonego.

Jasność

stopień podobieństwa do barwy białej (dla odcieni jasnych) lub czarnej (dla
odcieni ciemnych).

Nasycenie

czystość barwy np. stopień zbliżenia do barw zasadniczych występujących w
widmie słonecznym: czerwona, zielona, niebieska, żółta (RGBY).

Rozróżnialność barw

(uwzględniając jasności) ok. 400000 kolorów (przy porównywaniu).
Z pamięci: kilkadziesiąt barw. Subiektywna ocena barw obrazu na monitorze
przy różnym oświetleniu pomieszczenia.

Cechy bodźca świetlnego wywołującego wrażenie barwy

- Achromatyczne (widzenie skotopowe)
- Ilość (skuteczność pobudzenia) luminancja/jasność/jaskrawość czyli stopień podobieństwa do białej barwy, dającej maksymalne pobudzenie lub czarnej, dającej pobudzenie minimalne
- Chromatyczne (widzenie fotopowe)
- Jasność (intensywność pobudzenia R+G+B)
- Barwa/odcień/walor/Kolor/ (fizycznie: długość dominującej fali)
- Nasycenie/rozbielenie (czystość barwy czyli podobieństwo do barw widma słonecznego, bladość)

Widzenie pośrednie mezopowe; przy słabym świetle

### Błędy w postrzeganiu i rozróżnianiu kolorów przez człowieka

### Pojęcia związane z prawem Webera, pasma Macha i hamowanie oboczne

### Wykorzystanie zjawiska metameryzmu w kolorymetrii trójbarwnej oraz inne sposoby zapisu kolory (w tym kodowania koloru atlasch wzorców barw). Modele barw związane z obrazami cyfrowymi i urządzeniami peryferyknymi komputerów: model addytywny, model substraktywny oraz modele oparte na zasadach percepcji koloru przez oko ludzkie (HSV, Lab, La*b*). Problem różnego zakresu odtwarzanie kolorów na różnych urządzeniach i metody przystosowania grafiki do tego problemu

### Informacjie historyczne o zapisu koloru w fotografii klasycznej i w czasach reprodukcji koloru za pomocą trójwarstwowych prezentacji na szkle

### Przedstawienie osiągnięć Jana Szczepanika (polskiego Edisona).

### Teoretyczne podstawy porównywanie obrazów jako tablic i jako wektorów: obrazy różnicowe i metryki służące do wyznaczania odległości obrazów (Euklidesowa, Manhatan i Czebyszewa) w przestrzeni obrazów.

Metryka Euklidesowa:

$$\rho(x_1, x_2) = \sqrt{\sum (x_1-x_2)^2}$$

Metryka uliczna (Manhattan, city block distance):

$$\rho(x_1, x_2) = \sum|x_1-x_2|$$

Metryka Czebyszewa:

$$\rho(x_1,x_2) = \max|x_1-x_2|$$

### Kompresja obrazów i definicja współczynnika kompresji

### Przykłady algorytmów i metod kompresji stratnej i bezstratnej

### Formaty zapisu obrazów i metody kompresji z których korzystają: jpeg, tif, png, gif.

## Wykład 7

### Definicja rozpoznawania jako procesu psychofizycznego zachodzącego w mózgu człowiek i prowadzącego do interpretacji (przypisania znaczenia) stymulacjom ludzkich zmysłów, w tym ludzkiego oka

Rozpoznawanie bodźców

- Psychofizyczny proces zachodzący w mózgu człowieka pod wpływem stymulacji (np.: wzrokowej) lub nawet jej wyobrażenia, wywołujący przyporządkowanie stymulacji do pewnej kategorii zjawisk, obiektów, itp..

Ograniczamy się do bodźców wzrokowych

- W ten sposób rozpoznawanie to interpretacja stymulacji wzrokowej czyli przyporządkowanie jej odpowiedniej kategorii obiektów i sytuacji widzianych przez narząd wzroku (na podstawie poprzednich doświadczeń i znanych definicji)

### Znaczenie świadomości i wiedzy w procesie rozpoznawania zachodzacym w ludzkim mózgu

Świadomość i wiedza:

- Zdolność zdawania sobie sprawy z tego, że istnieją kategorie pojęciowe i że rozpoznanie oznacza postrzeżenie (reaktywność i percepcja) i zakwalifikowanie do kategorii czyli rozumienie
- Niejednoznaczność obrazów
- W postrzeganiu istnieje progu świadomości, czyli dolnej granicy wrażliwości na sygnały oraz wymagane są doświadczenia i informacja o otaczającej rzeczywistości

### Podstawowe psychologiczne teorie rozpoznawania

Rozpoznawanie

- Proces psychofizjologiczny zachodzący w mózgu na podstawie wrażenia zmysłowego lub jego wyobrażenia, przypisujący znaczenie procesom, które są „odbierane”.
- Rozpoznawanie wrażeń wzrokowych jest więc interpretacją znaczenia stymulacji wzrokowych przez zidentyfikowanie kategorii, do której należą obiekty stymulujące (odwołanie do wcześniejszych doświadczeń i wcześniej zdefiniowanych kategorii lub utworzenie nowej kategorii)

Tło gnostyczne = świadomość + wiedza

ontologie = wiedza i reguły wnioskowania

Teorie rozpoznawania:

- Teoria wzorca
- Przechowywanie nieskończonej liczby wzorców
- Porównywanie (dokładność)
- Klasyfikacja?
- Teoria cech
- Dopasowywanie cech obrazu do cech przechowywanych w pamięci
- Dowody: „detektory cech” w korze wzrokowej (Hubel & Wiesel)

### Definicja komputerowego rozpoznawanie obrazów jako część dziedziny rozpoznawania wzorców (ang. pattern recognision). Podobieństwa i różnice rozpoznawania wykonywanego przez człowieka i system wizyjny z oprogramowaniem do rozpoznawania obrazów

Komputerowe rozpoznawanie obrazów

Podejścia:

1. Klasyczne – oparte o cechy obiektu ułatwiające jednoznaczne rozpoznanie

- Analiza obrazu zajmuje się ekstrakcją cech na potrzeby rozpoznawania obrazów

2. Oparte na sztucznej inteligencji - bazuje na cechach wyznaczonych automatycznie w procesie uczenia

Cel rozpoznawania

- Wspomaganie ludzkich decyzji za pomocą informacji obrazowej lub informacji ekstrahowanej z obrazów
- Uzależniony od zastosowania:
- Zastąpienie człowieka
- Weryfikacja działania manipulatorów i robotów
- Selekcja dużych ilości danych (badania przesiewowe w diagnostyce medycznej)
- Biometria

### Cele i metody rozpoznawania komputerowego obrazów i ich podział na dwa podejścia: podejście klasyczne z definiowaniem i wyborem cech przez dewelopera systemu i podejście oparte o automatyzację procesu wyboru cech związane z uczeniem maszynowym

Komputerowe rozpoznawanie obrazów

- Naśladuje rozpoznawanie wykonywane przez człowieka choć wiedza o świecie zgromadzona w oprogramowaniu jest bardzo ograniczona
- Jest znacznie mniej efektywne
- Jest związane z zastosowaniami:
- Zastąpieniem człowieka w trudnych warunkach (kontrola jakości mikroprocesorów), uciążliwych czynnościach (OCR)
- Weryfikacja działania manipulatorów i robotów
- Selekcją dużych ilości danych (badania skriningowe w diagnostyce medycznej)

Cel:

Wspomaganie ludzkich decyzji za pomocą informacji obrazowej lub informacji ekstrahowanej z obrazów

Proces rozpoznawania jest wieloetapowy, zawiera dwa typy działań:

- ukierunkowane (detekcja dopasowania, analiza kształtu, pomiar wielkości lub odległości)
- nieukierunkowane (filtracja obrazu, zamiana na obraz monochromatyczny, wyodrębnianie krawędzi)

- Rozpoznawanie obrazów jest związane
  z innymi dziedzinami nauk komputerowych: uczeniem maszynowym UM (machine learning, ML), sztuczną inteligencją (artificial intelligence AI), komunikacją człowiek-komputer
- Zastosowania:
- Bioidentyfikacja (oczy, uszy, odciski palców, głos)
- Kontrola jakości produktów, kontrola samochodów na drogach (rozpoznawanie tablic rejestracyjnych), roboty i manipulatory
- Badania przesiewowe ( w diagnostyce medycznej)
- Symulatory do nauki prowadzenia pojazdów (samolotów, pojazdów kosmicznych, samochodów wyścigowych, wieży kontrolnej lotów)
- Rozpoznawanie twarzy
- Marketing (Yamaha Motor)

### Definicje następujących pojęć: cechy, przestrzeni cech, przekształcenia zwanego analizą, przekształcenia zwanego właściwym rozpoznawaniem, pojęcia klas obiektów

- cechy obiektów są to współrzędne przestrzeni X; odwzorowanie obiektu w punkt charakteryzowany przez współrzędne

### Przedstawienie pełnego schematu przebiegu przygotowania i wykorzystywania klasycznych metod rozpoznawania obrazów

## Wykład 8

### Proces przetwarzania, analizy i rozpoznawania obrazów w postaci ogólnego schematu

### Pokazanie jak w poszczególnych elemtach schematu rozwijały się metody w ujęciu historycznym z przjeściem to aktualnego rozwoju dziedziny i przyszłych wyzwań. Przedstawienie przykładu różnego zobrazowanie tej samej rzeczywistości (ludzkiej ręki zobrazowanej w promieniowaniu rentgenowskim, w zakresie widma widzialnego i w termowizji) oraz informacji o obiekcie przekazywanej przez każdy ze sposoby obrazowania

### Analiza, które z metod analizy obrazów pozwalających na dotarcie do tej informacji

### Dyskusja o znanych studentom innych metodach zastosowania przetwarzania, analizy i rozpoznawania obrazów w kontekście metod przedstawionych w wykładzie

### Definicja steganografii; ukrywania informacji z ukryciem faktu przekazywania informacji

Steganografia - Nauka o komunikacji w taki sposób, by obecność komunikatu nie mogła zostać
wykryta, czyli ukrywanie/hermetyzacji informacji (ang. information hiding)

Słowo „steganografia” pochodzi z języka greckiego i oznacza ukryte pismo

Zaleta steganografii w stosunku do szyfrowania informacji jest ukrycie samego faktu porozumiewania się stron.

Ukrywanie informacji obrazowej (lub tekstowej) w obrazie ( image watermarking) w różnych celach:

1. Ochrona praw autorskich (ukryty obraz (lub tekst) pełni rolę znaku wodnego
   (watermark)), w tym przypadku konieczną własnością obrazu ukrytego jest
   (poza odpornością na usunięcie przez czynniki zewnętrzne) jego wystarczająca
   odporność na działanie standardowych operacji przetwarzania obrazów
   (filtracja, kompresja, zniekształcenia geometryczne itp.),
2. Ochrona autentyczności obrazu (ukryty obraz pełni rolę znaku wodnego
   (watermark)), w tym przypadku konieczną własnością obrazu ukrytego jest (poza
   odpornością na usunięcie przez czynniki zewnętrzne) jego wystarczająca
   podatność na działanie operacji przetwarzania obrazów (filtracja, kompresja,
   zniekształcenia geometryczne itp.).
3. Praktyczne przesyłania informacji

### Steganografia z wykorzystaniem obrazu jako nośnika informacji.

Ukrywanie obrazu w obrazie - nazwy obrazów

1. obraz ukrywający `[p]`
2. obraz ukrywany `[h]`
3. obraz ukrywany po przekształceniu `[nmod]`
4. obraz ukrywający wraz z obrazem ukrytym `[ph]`

Obrazy ukrywające z gradacją poziomów szarości

Obraz ukrywający: na 1 piksel obrazu ukrywanego przypada 1 bajt (8 bitów)

Obraz ukrywany może i powinien być uproszczony: na 1 piksel obrazu może
przypadać 1, 2, 3, 4,5, 6, 7, 8 bitów, co odpowiada 2,4,8,16,32,64,128,256
poziomom szarości (M)

W praktyce, ze względu na potrzebę ograniczenia wpływu obrazu ukrywanego
na wygląd obrazu ukrywającego, stosowane są wartości [M<<256, a obraz
ukrywany zapisywany jest na najmniej znaczących bitach obrazu ukrywającego.

Zajęcia badanie czy:

przy wzroście wartości liczby bitów obrazu ukrywanego następuje coraz większa zmiana wyglądu obrazu ukrywającego i jednocześnie coraz wyraźniejsze uwidocznienie obrazu ukrywanego w tym obrazie.

Obrazy ukrywające kolorowe np. w formacie RGB

Obraz ukrywający: na 1 piksel obrazu przypada 3 bajty (24 bity) odpowiadające 3
składowym R, G, B

Przykładowy zapis piksla obrazu ukrywanego: 2 najmłodsze bity składowej R oraz po
jednym najmłodszym bicie składowych G i B (razem 4 bity, co odpowiada obrazowi o M=16
poziomach)

Zapis informacji tekstowej obrazie RGB: 1 znak — 8 bitów co oznacza że do zapisu 1 znaku
można wykorzystać 2 piksle.

Dodatkowe kodowanie obrazów ukrywanych => lepsze ich ukrycie (np. przemieszanie poszczególnych piksli)

Operacje najczęściej stosowane w procesie ukrywania i odtwarzania obrazu

- Jednopunktowe jednoargumentowe
- progowania,
- redukcji poziomów szarości,
- rozciągania,
- uniwersalne operacje punktowe (UOP)
- Jednopunktowe dwuargumentowe
- arytmetyczne (dodawanie, odejmowanie)
- logiczne (suma (OR), iloczyn (AND))
