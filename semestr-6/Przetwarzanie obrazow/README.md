# Przetwarzanie obrazów

## Wykład 1

Podstawowe pojęcia: obraz, obraz cyfrowy, histogram obrazu i linia profilu obrazu cyfrowego. Model obrazu cyfrowego i historia powstania dziedziny zwanej przetwarzaniem i rozpoznawaniem obrazów. Światło i inne zakresy fal elekromagnetycznych jak źródło powstawania obrazów. Proces akwizycji obrazów cyfrowych: pojęcia próbkowania przestrzennego i tonalnego (poziomów szarości). Charakterystyka obrazów cyfrowych: szum akwizycji, zniekształcenia obrazu. Sposoby walki z szumem akwizycji. Różnica miedzy obrazem zawierającym wielkości pomiarowe (typu RAW) a obrazami generowanymi przez typowe aparaty cyfrowe.

## Czym jest akwizycja obrazu? Jakie są elementy procesu akwizycji? Jakie są inherentne cechy procesu akwizycji?

Akwizycja obrazu to przetworzenie informacji o fizycznym obiekcie do postaci zbioru danych dyskretnych nadających się do zapisania w pamięci komputera.

Elementy procesu akwizycji:

1. Oświetlenie obrazu.
2. Formowanie obrazu (optyczne).
3. Detekcja obrazu.
4. Formowanie wyjściowego sygnału z urządzenia

Matryce CCD są elementami pozyskiwania obrazu. Płaska periodyczna struktura dyskretna, której elementy zmieniają światło na prąd o napięciu proporcjonalnym do jasności.

Cechy procesu akwizycji:

- nakładanie szumu
- nakładanie zniekształceń

## Czym jest szum? Jakie są rodzaje szumu? Z czego wynika szum? Od czego zależy szum? Jakie są metody redukcji szumu?

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



## Wykład 2

Pozostała aspekty charakterystyki obrazów cyfrowych w kontekście ich inherentnych cech związanych z procesem akwizycji (powstawaniem szumu i zniekształceń obrazu) w szczególności zniekształaceń rediometrycznych, geometrycznych i chromatycznych. Omówienie procesu akwizycji obrazu na podstawie aparatu fotograficznego ze zwróceniem uwagi na źródła zniekształceń radiometrycznych, geometrycznych i chromatycznych. Przedstawienie sprzętowych i programowych sposobów walki z zniekształceniami wprowadzanymi w procesie akwizycji. Przedstawienie ogólnego schematu przetwarzania i analizy obrazów. Definicja operacji na obrazach i ich podział ze według na kryteria matematyczne, zasięg informacji obrazawej potrzebnej do otrzymania wyniku i ze względu na ich funkcje i rezultaty. Omówienie operacji jednopunktowych jednoargumentowych.

Na laboratorium korekcja zniekształceń nakładanych na obraz cyfrowy w procesie akwizycji: korekta radiometryczna, korekta parspektywy, korekta zniekształceń geometrycznych - beczkowatego i poduszkowatego - oraz typowych błędów amatorskiej fotografii - pochylenia horyzontu, przewracających się budynków, itp. Analiza działania operacji punktowych jednoargumentowych oraz ich wykorzystanie do poprawy jakości i czytelności obrazu. Wykorzystanie tablicy LUT jako formy zapisu histogramu lub operacji jednopunktowej. Manipulowanie tablicą LUT stanowiącą Uniwersalny Operator Punktowy (UOP). Wykorzystanie standardowego oprogramowania komercyjnego i darmowego oraz oprogramowania będącego własnoscia WIT.

## Wykład 3

Operacje punktowe wieloargumentowe (arytmetyczne i logiczne). Wstęp do operacji sąsiedztwa. Omówienie operacji uśredniających o jednakowych i niejednakowych wagach (w tym o wagach odpowiadających dwuwymiarowej funkcji gaussa) jako przykład operacji liniowych (konwolucyjnych). Wprowadzenia nieliniowych operacji sąsiedztwa (logicznych i statystycznych) prowadzących do efektów w postaci wygładzania obrazu.
Porównanie operacji: a) liniowych i nieliniowych; b) punktowych i sąsiedztwa z podziałam na liniowe i nieliniowe. Laplasjany i różnica między nimi a wygladzającymi filtrami konwolucyjnymi.

Na laboratorium rozwiązywanie zadań pozwalające zaobserwować skutki działania uśredniania wagowego i skutki operacji statystucznych (mediany z otoczenia). Analiza wpływy operacji sąsiedztwa (konwolucyjnych i statystycznych) na poziom szumu i histogram obrazu. Operacje filtracji laplasjanowej. Implamentacja filtracji konwolucyjnej i medianowej w Excelu i badanie wpływy metod implementacji wartości brzegowych/marginesów na ostateczny rezultat filtracji. Zadania wykonywane z wykorzystaniem oprogramowania zakupionego, darmowego i własnego szkoły WIT.

## Wykład 4

Operacje sąsiedztwa oparte na matematycznych operacjach wliczania gradientu, pierwszej i drugiej pochodnej. Operacje kierunkowych gradientów i operatorów gradientowych pokazujących wartości skoku w otoczeniu analizowanego piksela oraz operacje sąsiedztwa oparte o laplasjany. Porównanie operacji sąsiedztwa: a) opartych na uśrednianiu i opartych na gradientach; b) gradientowych i laplasjanowych oraz c) filtrów kierunkowych i operatorów gradientowych. Operacje morfologii matematycznej i ich porównanie z operacjami konwolucyjnych oprecji filtracji. Podstawowe operacje morfologii matematycznej erozja, dylacja, otwarcie, zamknięcie i ich interpretacja oraz wyniki dzialania na obrazów binarnych i w odcieniach szarości. Niektóre zaawansowanie operacje morfologii matematycznej: gradient morfologiczny, ekstrakcja konturów, pocienienie i pogrubianie. Rozszerzenia definicji operacji podstawowych na obrazy w odcieniach szarości.

Na laboratorium wykonywanie zadań pozwalających zaobserwować działanie kierunkowych filtrów gradientowych i operatorów zbudowanych z filtrów kierunkowych integrujących informacjię w dwóch prostopadłych kierunkach takich jak filtr Robertsa, Sobela, Prewitta i Kirscha. Nstępnie w ramach morfologii matematycznej studenci obserwują wpływ wielkości i kształtu elemetu struturalnego/struturyzującego na wynik operacji na obrazach w odcieniach szarości i binarnych. Rozwiązywanie zadań pokazujących wykorzystanie operacji morfologii matematycznej do krawędziawania i poprawiania wyników segmentacji. Do rozwiązywania zadań wykorzystywane jest oprogramowanie komercyjne, darmowe i własne WIT.

## Wykład 5

Operacje globalne - transformaty. Transformata Fouriera, jej rola w przetwarzaniu i analizie obrazów: 1) poszukiwania kierunkowości i periodyczności w obrazie oraz 2) dokonywanie manipulacji zawartością obrazu w dziedzinie częstotliwości. Porównanie wyników filtracji dolno- i górnoprzepustowej wykonywanej w dziedzinie częstotliwości z filtracją konwolucyjną za pomocą odpowiednich filtrów. Przykład wykorzystanie analizy różnych zakresów częstotliwości do rozwikłania tajemnicy obrazu Mony Lizy Leonarda DaVinci. Transformata Hougha i jej działanie. Analiza przykładów zastosowanie transformata Hougha w przestrzni o dwóch i trzech parametrach opisu poszukiwanej figury geometrycznej. Transformaty kosinusowa (wykorzystywana w formacie jpg) i falkowa (w jpg2000) i ich zastosowania.
Definicje związane z procesem segmentacji obrazu. Podział metod segmentacji na grupy i omówienie przykładowych metod z każdej grupy.

Na laboratorium wykonywane są zadania przedstawiajace własności transformaty Fouriera (periodyczność i kierunkowość) oraz jej własności pozwalające na proste definiowanie filtrów wygładzających i wyostrzjących. Następnie wykonywane są zadania poszukiwania kierunków prostych ograniczających wysegmentowany obiekt z użyciem transformaty Hougha. Przeprowadzania eksperymentów z procedurami segmentacji wybranych obiektów na obrazach cyfrowych z przejściem na zapis analityczny prostych ograniczających obiekty.
Do rozwiązywania zadań wykorzystywane jest oprogramowania do przetwarzania i analizy obrazów: komercyjne zakupione przez szkołę, darmowe i własne napisane przez studentów WIT.

## Wykład 6

Percepcji koloru i jasności przez oko ludzkie. Błędy w postrzeganiu i rozróżnianiu kolorów przez człowieka. Pojęcia związane z prawem Webera, pasma Macha i hamowanie oboczne. Wykorzystanie zjawiska metameryzmu w kolorymetrii trójbarwnej oraz inne sposoby zapisu kolory (w tym kodowania koloru atlasch wzorców barw). Modele barw związane z obrazami cyfrowymi i urządzeniami peryferyknymi komputerów: model addytywny, model substraktywny oraz modele oparte na zasadach percepcji koloru przez oko ludzkie (HSV, Lab, La*b*). Problem różnego zakresu odtwarzanie kolorów na różnych urządzeniach i metody przystosowania grafiki do tego problemu. Informacjie historyczne o zapisu koloru w fotografii klasycznej i w czasach reprodukcji koloru za pomocą trójwarstwowych prezentacji na szkle. Przedstawienie osiągnięć Jana Szczepanika (polskiego Edisona).
Teoretyczne podstawy porównywanie obrazów jako tablic i jako wektorów: obrazy różnicowe i metryki służące do wyznaczania odległości obrazów (Euklidesowa, Manhatan i Czebyszewa) w przestrzeni obrazów. Kompresja obrazów i definicja współczynnika kompresji. Przykłady algorytmów i metod kompresji stratnej i bezstratnej. Formaty zapisu obrazów i metody kompresji z których korzystają: jpeg, tif, png, gif.

Na labiratorium przeglądane są modele/przestrzenie barw w obrazach cyfrowych (RGB, HSV) i wykonywane konwersje modeli kolorów. Zadania obejmują eksperymenty na obrazach prowadzące do zrozumienia kolorów podstawowych, nasyconych i nienasyconych oraz narzędzi kontroli zamiany koloru na szary odcień. Ponadto obejmują analizę wyników mieszania kolorów i segmentacji na podstwie koloru. Zadania pokazujace wpływ kompresja obrazów cyfrowych na ich jakość (dla kompresji stratne i bezstratnej). Stratne i bezstratne formaty zapisu obrazów cyfrowych. Do rozwiązywania zadań wykorzystuje się komercyjne i darmowe oprogramowania do przetwarzania i analizy obrazów oraz oprogramowanie własne powstałe w szkole WIT.

## Wykład 7

Definicja rozpoznawania jako procesu psychofizycznego zachodzącego w mózgu człowiek i prowadzącego do interpretacji (przypisania znaczenia) stymulacjom ludzkich zmysłów, w tym ludzkiego oka. Znaczenie świadomości i wiedzy w procesie rozpoznawania zachodzacym w ludzkim mózgu. Podstawowe psychologiczne teorie rozpoznawania. Definicja komputerowego rozpoznawanie obrazów jako część dziedziny rozpoznawania wzorców (ang. pattern recognision). Podobieństwa i różnice rozpoznawania wykonywanego przez człowieka i system wizyjny z oprogramowaniem do rozpoznawania obrazów. Cele i metody rozpoznawania komputerowego obrazów i ich podział na dwa podejścia: podejście klasyczne z definiowaniem i wyborem cech przez dewelopera systemu i podejście oparte o automatyzację procesu wyboru cech związane z uczeniem maszynowym. Definicje następujących pojęć: cechy, przestrzeni cech, przekształcenia zwanego analizą, przekształcenia zwanego właściwym rozpoznawaniem, pojęcia klas obiektów. Przedstawienie pełnego schematu przebiegu przygotowania i wykorzystywania klasycznych metod rozpoznawania obrazów. Dwie z metod: porównywanie do wzorca i metoda k- najbliższych sąsiadów są przedstawiane szczegółowo (ponieważ ostanią z nich studenci implemetują w Excelu w ramach laboratoriów). Wprowadzenia pojęcia uczenia maszynowego; w tym uczenia się sieci neuronowych (płytkich i głębokich). Definicja pojęć związanych z różnym typem uczenia się sieci neuronowych oraz z ich architekturą. Matematyczne podstawy uczenia się sieci neuronowych (funkcja propagacji wstecznej, rodzaje optymalizacji). Ewolucja architektury sieci neuronowych od sieci trójwardtwowej aż do wykorzystywanych do rozpoznawania obrazów sieci konwolucyjnych z enkoderem i dekoderem (U-net). Metod rozpoznawania obrazów oparte o algorytmy automatycznie wybierające cechy w kontekscie cech wybieranych w klasycznych metodach rozpoznawania. Przedstawienia specyfiki sieci konwolucyjnych i typowych zastosowań sieci rozpoznających obrazy: sieci do przenoszenia stylu obrazu, sieci rozpoznającej i lokalizującej twarze, sieci do analizy i segmentacji obrazów biomedycznych (do wspomagania diagnostyki obrazowej). Omówienie zagadnień związanych z wizualizacją informacji zawartej w sieci i ze zrozumieniem jej działania.

Na laboratorium wykonywane są zadania klasyczne rozpoznawania obrazów czyli analiza wybranych cech obiektów wysegmentowanych w obrazie, konstruowanie wektora i przestrzeni cech na podstawie wybranych współczynników oraz kalsyfikacji przy użyciu metody K-NN na podstawie przygotowanego zbioru uczącego z wykorzystaniem Excela. Demonstracje procesu uczanie się konwolucyjnej sieci neuronowej rozpoznawania cyfr zapisanych ręcznie (na podstawie baza obrazów cyfr MNIST); sprawdzanie lokalizacji wagi odpowidzalnej za zaliczenie obiektów do każdej zdefiniowanej klasy. Laboratorium wykorzystaniem środowiska Python-Keras (darmowe).

## Wykład 8

Proces przetwarzania, analizy i rozpoznawania obrazów w postaci ogólnego schematu. Pokazanie jak w poszczególnych elemtach schematu rozwijały się metody w ujęciu historycznym z przjeściem to aktualnego rozwoju dziedziny i przyszłych wyzwań. Przedstawienie przykładu różnego zobrazowanie tej samej rzeczywistości (ludzkiej ręki zobrazowanej w promieniowaniu rentgenowskim, w zakresie widma widzialnego i w termowizji) oraz informacji o obiekcie przekazywanej przez każdy ze sposoby obrazowania. Analiza, które z metod analizy obrazów pozwalających na dotarcie do tej informacji. Dyskusja o znanych studentom innych metodach zastosowania przetwarzania, analizy i rozpoznawania obrazów w kontekście metod przedstawionych w wykładzie. Definicja steganografii; ukrywania informacji z ukryciem faktu przekazywania informacji. Steganografia z wykorzystaniem obrazu jako nośnika informacji.

Na laboratorium wykonywanie zadań dotyczących steganografii: kodowanie i rozkodowywanie informacji w obrazie. Rozwiązywanie zadań obliczeniowych. W czasie tego laboratorium studenci wykorzystują oprogramowanie własne WIT napisane jako prace dyplomowe przez starsze roczniki studentów wybierających specjalność inżynieria oprogramowania.
