## Wykład 1

### Podstawowe pojęcia: obraz, obraz cyfrowy, histogram obrazu i linia profilu obrazu cyfrowego.

### Model obrazu cyfrowego i historia powstania dziedziny zwanej przetwarzaniem i rozpoznawaniem obrazów.

### Światło i inne zakresy fal elekromagnetycznych jak źródło powstawania obrazów.

### Proces akwizycji obrazów cyfrowych: pojęcia próbkowania przestrzennego i tonalnego (poziomów szarości).

### Charakterystyka obrazów cyfrowych: szum akwizycji, zniekształcenia obrazu.

### Sposoby walki z szumem akwizycji.

### Różnica miedzy obrazem zawierającym wielkości pomiarowe (typu RAW) a obrazami generowanymi przez typowe aparaty cyfrowe.

### Zaznajomienie się z komendami wykorzystywanymi do przetwrzania obrazów.

### Obserwacja zmian w obrazie ze względu na zmianę parametrów wpływających na formowanie powstającego obrazu cyfrowego (rozdzielczość przestrzenna i poziomów jasności).

### Definicja i praktyczne wykorzystanie histogramy w przetwarzaniu obrazów - sposoby prezentacji histogramu w oprogramowaniu do przetwarzania obrazów.

### Analiza obrazu z wykorzystaniem linii profilu: obserwacjia szumu w obrazie.

## Wykład 2

### Pozostałe aspekty charakterystyki obrazów cyfrowych w kontekście ich inherentnych cech związanych z procesem akwizycji (powstawaniem szumu i zniekształceń obrazu) w szczególności zniekształaceń rediometrycznych, geometrycznych i chromatycznych.

### Omówienie procesu akwizycji obrazu na podstawie aparatu fotograficznego ze zwróceniem uwagi na źródła zniekształceń radiometrycznych, geometrycznych i chromatycznych.

### Przedstawienie sprzętowych i programowych sposobów walki z zniekształceniami wprowadzanymi w procesie akwizycji.

### Przedstawienie ogólnego schematu przetwarzania i analizy obrazów.

### Definicja operacji na obrazach i ich podział ze według na kryteria matematyczne, zasięg informacji obrazawej potrzebnej do otrzymania wyniku i ze względu na ich funkcje i rezultaty.

### Omówienie operacji jednopunktowych jednoargumentowych.

### Analiza działania operacji punktowych jednoargumentowych oraz ich wykorzystanie do poprawy jakości i czytelności obrazu.

### Wykorzystanie tablicy LUT jako formy zapisu histogramu lub operacji jednopunktowej.

### Manipulowanie tablicą LUT stanowiącą Uniwersalny Operator Punktowy (UOP).

## Wykład 3

### Operacje punktowe wieloargumentowe (arytmetyczne i logiczne).

### Wstęp do operacji sąsiedztwa.

### Omówienie operacji uśredniających o jednakowych i niejednakowych wagach (w tym o wagach odpowiadających dwuwymiarowej funkcji gaussa) jako przykład operacji liniowych (konwolucyjnych).

### Wprowadzenia nieliniowych operacji sąsiedztwa (logicznych i statystycznych) prowadzących do efektów w postaci wygładzania obrazu.

### Porównanie operacji: a) liniowych i nieliniowych; b) punktowych i sąsiedztwa z podziałam na liniowe i nieliniowe.

### Laplasjany i różnica między nimi a wygladzającymi filtrami konwolucyjnymi.

## Wykład 4

### Operacje sąsiedztwa oparte na matematycznych operacjach wliczania gradientu, pierwszej i drugiej pochodnej.

### Operacje kierunkowych gradientów i operatorów gradientowych pokazujących wartości skoku w otoczeniu analizowanego piksela oraz operacje sąsiedztwa oparte o laplasjany.

### Porównanie operacji sąsiedztwa: a) opartych na uśrednianiu i opartych na gradientach; b) gradientowych i laplasjanowych oraz c) filtrów kierunkowych i operatorów gradientowych.

### Operacje morfologii matematycznej i ich porównanie z operacjami konwolucyjnych oprecji filtracji.

### Podstawowe operacje morfologii matematycznej erozja, dylacja, otwarcie, zamknięcie i ich interpretacja oraz wyniki dzialania na obrazów binarnych i w odcieniach szarości.

### Niektóre zaawansowanie operacje morfologii matematycznej: gradient morfologiczny, ekstrakcja konturów, pocienienie i pogrubianie.

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

### Percepcja koloru i jasności przez oko ludzkie.

### Błędy w postrzeganiu i rozróżnianiu kolorów przez człowieka.

### Pojęcia związane z prawem Webera, pasma Macha i hamowanie oboczne.

### Wykorzystanie zjawiska metameryzmu w kolorymetrii trójbarwnej oraz inne sposoby zapisu kolory (w tym kodowania koloru atlasch wzorców barw).

### Modele barw związane z obrazami cyfrowymi i urządzeniami peryferyknymi komputerów: model addytywny, model substraktywny oraz modele oparte na zasadach percepcji koloru przez oko ludzkie (HSV, Lab, La*b*).

### Problem różnego zakresu odtwarzanie kolorów na różnych urządzeniach i metody przystosowania grafiki do tego problemu.

### Informacjie historyczne o zapisu koloru w fotografii klasycznej i w czasach reprodukcji koloru za pomocą trójwarstwowych prezentacji na szkle.

### Przedstawienie osiągnięć Jana Szczepanika (polskiego Edisona).

### Teoretyczne podstawy porównywanie obrazów jako tablic i jako wektorów: obrazy różnicowe i metryki służące do wyznaczania odległości obrazów (Euklidesowa, Manhatan i Czebyszewa) w przestrzeni obrazów.

### Kompresja obrazów i definicja współczynnika kompresji.

### Przykłady algorytmów i metod kompresji stratnej i bezstratnej.

### Formaty zapisu obrazów i metody kompresji z których korzystają: jpeg, tif, png, gif.

## Wykład 7

### Definicja rozpoznawania jako procesu psychofizycznego zachodzącego w mózgu człowieka i prowadzącego do interpretacji (przypisania znaczenia) stymulacjom ludzkich zmysłów, w tym ludzkiego oka.

### Znaczenie świadomości i wiedzy w procesie rozpoznawania zachodzacym w ludzkim mózgu.

### Podstawowe psychologiczne teorie rozpoznawania.

### Definicja komputerowego rozpoznawanie obrazów jako część dziedziny rozpoznawania wzorców (ang. pattern recognision).

### Podobieństwa i różnice rozpoznawania wykonywanego przez człowieka i system wizyjny z oprogramowaniem do rozpoznawania obrazów.

### Cele i metody rozpoznawania komputerowego obrazów i ich podział na dwa podejścia: podejście klasyczne z definiowaniem i wyborem cech przez dewelopera systemu i podejście oparte o automatyzację procesu wyboru cech związane z uczeniem maszynowym.

### Definicje następujących pojęć: cechy, przestrzeni cech, przekształcenia zwanego analizą, przekształcenia zwanego właściwym rozpoznawaniem, pojęcia klas obiektów.

### Przedstawienie pełnego schematu przebiegu przygotowania i wykorzystywania klasycznych metod rozpoznawania obrazów.

### Dwie z metod: porównywanie do wzorca i metoda k- najbliższych sąsiadów są przedstawiane szczegółowo (ponieważ ostanią z nich studenci implemetują w Excelu w ramach laboratoriów).

### Wprowadzenia pojęcia uczenia maszynowego; w tym uczenia się sieci neuronowych (płytkich i głębokich).

### Definicja pojęć związanych z różnym typem uczenia się sieci neuronowych oraz z ich architekturą.

### Matematyczne podstawy uczenia się sieci neuronowych (funkcja propagacji wstecznej, rodzaje optymalizacji).

### Ewolucja architektury sieci neuronowych od sieci trójwardtwowej aż do wykorzystywanych do rozpoznawania obrazów sieci konwolucyjnych z enkoderem i dekoderem (U-net).

### Metod rozpoznawania obrazów oparte o algorytmy automatycznie wybierające cechy w kontekscie cech wybieranych w klasycznych metodach rozpoznawania.

### Przedstawienia specyfiki sieci konwolucyjnych i typowych zastosowań sieci rozpoznających obrazy: sieci do przenoszenia stylu obrazu, sieci rozpoznającej i lokalizującej twarze, sieci do analizy i segmentacji obrazów biomedycznych (do wspomagania diagnostyki obrazowej).

### Omówienie zagadnień związanych z wizualizacją informacji zawartej w sieci i ze zrozumieniem jej działania.

## Wykład 8

### Proces przetwarzania, analizy i rozpoznawania obrazów w postaci ogólnego schematu.

### Pokazanie jak w poszczególnych elemtach schematu rozwijały się metody w ujęciu historycznym z przjeściem to aktualnego rozwoju dziedziny i przyszłych wyzwań.

### Przedstawienie przykładu różnego zobrazowanie tej samej rzeczywistości (ludzkiej ręki zobrazowanej w promieniowaniu rentgenowskim, w zakresie widma widzialnego i w termowizji) oraz informacji o obiekcie przekazywanej przez każdy ze sposoby obrazowania.

### Analiza, które z metod analizy obrazów pozwalających na dotarcie do tej informacji.

### Dyskusja o znanych studentom innych metodach zastosowania przetwarzania, analizy i rozpoznawania obrazów w kontekście metod przedstawionych w wykładzie.

### Definicja steganografii; ukrywania informacji z ukryciem faktu przekazywania informacji.

### Steganografia z wykorzystaniem obrazu jako nośnika informacji.
