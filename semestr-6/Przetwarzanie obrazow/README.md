# Przetwarzanie obrazów

## Wykład 1

### Podstawowe pojęcia: obraz, obraz cyfrowy, histogram obrazu i linia profilu obrazu cyfrowego.

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

Histogram obrazu - struktura która pomija informacje o tym gdzie znajduje się piksel, zlicza tylko poziomy jasności w formie wykresu słupkowego. Wysokość słupka odpowiada ilości wystąpień potencjalnego poziomu jasności występującego w obrazie.

Histogram to wykres słupkowy przedstawiający ilość pikseli o każdej potencjalnej wartości występującej w obrazie.

- Statystyka odzwierciedlająca rozkład jasności punktów w obrazie.
- Pewna estymata rozkładu jasności oryginalnego obrazu analogowego i rzeczywistości.

### Model obrazu cyfrowego i historia powstania dziedziny zwanej przetwarzaniem i rozpoznawaniem obrazów.

### Światło i inne zakresy fal elekromagnetycznych jak źródło powstawania obrazów.

### Proces akwizycji obrazów cyfrowych: pojęcia próbkowania przestrzennego i tonalnego (poziomów szarości).

Akwizycja obrazu to przetworzenie informacji o fizycznym obiekcie do postaci zbioru danych dyskretnych nadających się do zapisania w pamięci komputera.

Akwizycja (pozyskiwanie, zbieranie) obrazu -
przetworzenie informacji o fizycznym obiekcie lub
scenie do postaci zbioru danych dyskretnych (f(x,y)
obraz cyfrowy) nadających się do zapisania w
pamięci komputera, a następnie do wyświetlenia,
drukowania i dalszego przetwarzania za pomocą
odpowiedniego oprogramowania.

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

### Sposoby walki z szumem akwizycji.

Redukcja szumu:

- Na poziomie akwizycji:
  — Wybór maksymalnie długiego czasu naświetlania
  — Wybór niskich czułości ISO
  — Chłodzenie matrycy
  — Wykonywanie zdjęć wielokrotnych (braketing)
  — Wykonywanie zdjęć lekko prześwietlonych (HighKey)
- Na poziomie przetwarzania (obróbki) obrazów:
  — Uśrednianie zdjęć wielokrotnych
  — Filtrowanie
- Uwaga: Nie redukujemy szumu przez
  — Rozjaśnianie obrazu w miejscach niedoświetlenia
  — Rozjaśnianie cieni w obrazie

- Uśrednianie czasowe (dotyczy obrazów statycznych)
- Uśrednianie przestrzenne (obrazy statyczne oraz zmienne w czasie)

### Rozdzielczość obrazu.

Rozdzielczość przestrzenna - określa stopień rozróżnialności detali; tym lepsza, im większa wartość N/na jednostkę długości. Jest wyrażana w jednostkach zwanych punktami na cal (ang. Dot per inch)

- Rozdzielczość poziomów szarości — określa ilość
  rozróżnianych poziomów szarości lub kolorów; tym
  lepsza, im większa wartość M. Jest dobierana tak, aby
  wartość M była potęgą liczby 2 — co ułatwia kodowanie.
- |nne rozdzielczości: całkowita, interpolowana, urządzeń
  prezentacjj obrazu jak monitor, drukarka, ploter,
  urządzeń akwizycji.

### Histogram

Histogram to wykres słupkowy rzedstawiający ilość pikseli o każdej
potencjalnej wartości poziomu szarości lub intensywności koloru
występującej w obrazie.

- Statystyka odzwierciedlająca rozkład jasności punktów w obrazie.
- Pewna estymata rozkładu jasności oryginalnego obrazu analogowego i
  rzeczywistości.

### Różnica miedzy obrazem zawierającym wielkości pomiarowe (typu RAW) a obrazami generowanymi przez typowe aparaty cyfrowe.

## Wykład 2

### Pozostałe aspekty charakterystyki obrazów cyfrowych w kontekście ich inherentnych cech związanych z procesem akwizycji (powstawaniem szumu i zniekształceń obrazu) w szczególności zniekształaceń rediometrycznych, geometrycznych i chromatycznych.

Zniekształcenia obrazu w procesie akwizycji:

- Zniekształcenia radiometryczne to zniekształcenia odczytu wartości cechy, na podstawie której tworzymy obraz;
  - nierównomiernością oświetlenia,
  - błędami konwersji oświetlenie — sygnał elektryczny (tzn. błędami detekcji, uszkodzeniami przetworników)
- Zniekształcenia geometryczne to zniekształcenia odczytu położenia
  odczytanych wartości względem siebie
  dla obrazów kolorowych i wielospektralnych
- Zniekształcenia (aberracje) chromatyczne to zniekształcenia wynikające z charakterystyki współczynnika odbicia lub przejścia przez ośrodek fali elektromagnetyczne o różnej długości

Celem wstępnego przetwarzania obrazu jest redukcja zniekształceń obrazu powstałych w procesie akwizycji.

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
  $$KORM (Xx,y)= P_{KORA max} / P_{KORA}(GV)$$
- \$P\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\_{KORAmax} - Maksymalna wartość piksela w obrazie \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\$[P\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\_{KORA}(X, Y)]\$
- $P_{KORM}(x,y)$ - wartość piksela obrazu wynikowego (po korekcji radiometrycznej)

### Przedstawienie ogólnego schematu przetwarzania i analizy obrazów.

Operacje na obrazach

Metody w przetwarzaniu obrazów ze względu na sposób
liczenia:

- Globalne (operacje na wszystkich pikselach obrazu)
- Lokalne (operacje na ROI; ang. region of interest)
  - Punktowe;
  - Małym otoczeniu

Ze względu na typy matematycznych (w tym arytmetycznych,
logicznych, statystycznych) operacji, które są wykonywane na
wartościach intensywności.

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

$$ u(z) = \left\{
\begin{array}{ll}
1 & \text{dla } z>0 \\
\frac12 & \text{dla } z=0 \\
0 & \text{dla } z<0
\end{array}
\right. $$

Jeśli $\delta(t)$ - impuls Diracta, to:

$$u(z) = \int_{-\infty}^\infty\delta(t)\text dt$$

Założenia:

Krawędź leży wzdłuż linii prostej opisanej równaniem:

$x \sin\phi -y\cos\phi+p=0$ (postać normalna prostej)

Intensywność obrazu:
$$f(x,y)=I_1,+(I_2-I_1) u (x\sin\phi-y\cos\phi+\rho)$$

Cyfrowa wersja gradientu i laplasjanu.

### Porównanie operacji: a) liniowych i nieliniowych; b) punktowych i sąsiedztwa z podziałam na liniowe i nieliniowe.

### Laplasjany i różnica między nimi a wygladzającymi filtrami konwolucyjnymi.

## Wykład 4

### Operacje sąsiedztwa oparte na matematycznych operacjach wyliczania gradientu, pierwszej i drugiej pochodnej

### Operacje kierunkowych gradientów i operatorów gradientowych pokazujących wartości skoku w otoczeniu analizowanego piksela oraz operacje sąsiedztwa oparte o laplasjany

### Porównanie operacji sąsiedztwa: a) opartych na uśrednianiu i opartych na gradientach; b) gradientowych i laplasjanowych oraz c) filtrów kierunkowych i operatorów gradientowych

### Operacje morfologii matematycznej i ich porównanie z operacjami konwolucyjnych oprecji filtracji

### Podstawowe operacje morfologii matematycznej erozja, dylacja, otwarcie, zamknięcie i ich interpretacja oraz wyniki dzialania na obrazów binarnych i w odcieniach szarości

### Niektóre zaawansowanie operacje morfologii matematycznej: gradient morfologiczny, ekstrakcja konturów, pocienienie i pogrubianie

### Rozszerzenia definicji operacji podstawowych na obrazy w odcieniach szarości.

## Wykład 5

### Operacje globalne - transformaty.

### Transformata Fouriera, jej rola w przetwarzaniu i analizie obrazów: 1) poszukiwania kierunkowości i periodyczności w obrazie oraz 2) dokonywanie manipulacji zawartością obrazu w dziedzinie częstotliwości.

### Porównanie wyników filtracji dolno- i górnoprzepustowej wykonywanej w dziedzinie częstotliwości z filtracją konwolucyjną za pomocą odpowiednich filtrów.

### Przykład wykorzystanie analizy różnych zakresów częstotliwości do rozwikłania tajemnicy obrazu Mony Lizy Leonarda DaVinci.

### Transformata Hougha i jej działanie.

### Analiza przykładów zastosowanie transformata Hougha w przestrzni o dwóch i trzech parametrach opisu poszukiwanej figury geometrycznej.

### Transformaty kosinusowa (wykorzystywana w formacie jpg) i falkowa (w jpg2000) i ich zastosowania.

### Definicje związane z procesem segmentacji obrazu.

### Podział metod segmentacji na grupy i omówienie przykładowych metod z każdej grupy.

## Wykład 6

### Percepcji koloru i jasności przez oko ludzkie

### Błędy w postrzeganiu i rozróżnianiu kolorów przez człowieka

### Pojęcia związane z prawem Webera, pasma Macha i hamowanie oboczne

### Wykorzystanie zjawiska metameryzmu w kolorymetrii trójbarwnej oraz inne sposoby zapisu kolory (w tym kodowania koloru atlasch wzorców barw). Modele barw związane z obrazami cyfrowymi i urządzeniami peryferyknymi komputerów: model addytywny, model substraktywny oraz modele oparte na zasadach percepcji koloru przez oko ludzkie (HSV, Lab, La*b*). Problem różnego zakresu odtwarzanie kolorów na różnych urządzeniach i metody przystosowania grafiki do tego problemu

### Informacjie historyczne o zapisu koloru w fotografii klasycznej i w czasach reprodukcji koloru za pomocą trójwarstwowych prezentacji na szkle

### Przedstawienie osiągnięć Jana Szczepanika (polskiego Edisona).

### Teoretyczne podstawy porównywanie obrazów jako tablic i jako wektorów: obrazy różnicowe i metryki służące do wyznaczania odległości obrazów (Euklidesowa, Manhatan i Czebyszewa) w przestrzeni obrazów.

### Kompresja obrazów i definicja współczynnika kompresji

### Przykłady algorytmów i metod kompresji stratnej i bezstratnej

### Formaty zapisu obrazów i metody kompresji z których korzystają: jpeg, tif, png, gif.

## Wykład 7

### Definicja rozpoznawania jako procesu psychofizycznego zachodzącego w mózgu człowiek i prowadzącego do interpretacji (przypisania znaczenia) stymulacjom ludzkich zmysłów, w tym ludzkiego oka

### Znaczenie świadomości i wiedzy w procesie rozpoznawania zachodzacym w ludzkim mózgu

### Podstawowe psychologiczne teorie rozpoznawania

### Definicja komputerowego rozpoznawanie obrazów jako część dziedziny rozpoznawania wzorców (ang

### pattern recognision). Podobieństwa i różnice rozpoznawania wykonywanego przez człowieka i system wizyjny z oprogramowaniem do rozpoznawania obrazów

### Cele i metody rozpoznawania komputerowego obrazów i ich podział na dwa podejścia: podejście klasyczne z definiowaniem i wyborem cech przez dewelopera systemu i podejście oparte o automatyzację procesu wyboru cech związane z uczeniem maszynowym

### Definicje następujących pojęć: cechy, przestrzeni cech, przekształcenia zwanego analizą, przekształcenia zwanego właściwym rozpoznawaniem, pojęcia klas obiektów

### Przedstawienie pełnego schematu przebiegu przygotowania i wykorzystywania klasycznych metod rozpoznawania obrazów

### Dwie z metod: porównywanie do wzorca i metoda k- najbliższych sąsiadów są przedstawiane szczegółowo (ponieważ ostanią z nich studenci implemetują w Excelu w ramach laboratoriów). Wprowadzenia pojęcia uczenia maszynowego; w tym uczenia się sieci neuronowych (płytkich i głębokich). Definicja pojęć związanych z różnym typem uczenia się sieci neuronowych oraz z ich architekturą. Matematyczne podstawy uczenia się sieci neuronowych (funkcja propagacji wstecznej, rodzaje optymalizacji). Ewolucja architektury sieci neuronowych od sieci trójwardtwowej aż do wykorzystywanych do rozpoznawania obrazów sieci konwolucyjnych z enkoderem i dekoderem (U-net). Metod rozpoznawania obrazów oparte o algorytmy automatycznie wybierające cechy w kontekscie cech wybieranych w klasycznych metodach rozpoznawania

### Przedstawienia specyfiki sieci konwolucyjnych i typowych zastosowań sieci rozpoznających obrazy: sieci do przenoszenia stylu obrazu, sieci rozpoznającej i lokalizującej twarze, sieci do analizy i segmentacji obrazów biomedycznych (do wspomagania diagnostyki obrazowej). Omówienie zagadnień związanych z wizualizacją informacji zawartej w sieci i ze zrozumieniem jej działania.

## Wykład 8

### Proces przetwarzania, analizy i rozpoznawania obrazów w postaci ogólnego schematu

### Pokazanie jak w poszczególnych elemtach schematu rozwijały się metody w ujęciu historycznym z przjeściem to aktualnego rozwoju dziedziny i przyszłych wyzwań. Przedstawienie przykładu różnego zobrazowanie tej samej rzeczywistości (ludzkiej ręki zobrazowanej w promieniowaniu rentgenowskim, w zakresie widma widzialnego i w termowizji) oraz informacji o obiekcie przekazywanej przez każdy ze sposoby obrazowania

### Analiza, które z metod analizy obrazów pozwalających na dotarcie do tej informacji

### Dyskusja o znanych studentom innych metodach zastosowania przetwarzania, analizy i rozpoznawania obrazów w kontekście metod przedstawionych w wykładzie

### Definicja steganografii; ukrywania informacji z ukryciem faktu przekazywania informacji

### Steganografia z wykorzystaniem obrazu jako nośnika informacji.

$$
$$
