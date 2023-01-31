# Wstęp do inteligencji komputerowej

## Zadania z egzaminu

### Zadanie 1 - Sieci neuronowe - liniowa separowalność

Na czym polega ograniczenie jednowarstwowej sztucznej sieci neuronowej typu perceptronowego, nazywane liniową separowalnością? Czy istnieją metody przewyciężenia go, jeśli tak, to jaka lub jakie?

Odpowiedź:

Perceptron jest przypadkiem sieci neuronowej o jednej warstwie i jednym neuronie ze skokową funkcją aktywacji. Oznacza to podział przestrzeni wektorowej danych wejściowych na dwie kategorie, oddzielone od siebie hiperpłaszczyzną. W przypadku, gdy dane wejściowe nie są liniowo separowalne - na przykład przypadek funkcji XOR - to perceptron nie jest w stanie poprawnie klasyfikować danych wejściowych. W takim przypadku można użyć wielowarstwowych sieci neuronowych, które są w stanie rozwiązać problem liniowej separowalności.

### Zadanie 2 - Obliczenia rozmyte 2

Dla liczb rozmytych $A=0.25/0 + 0.5/1 + 1/2$ i $B=1/0 + 0.5/1 + 0.25/2$ proszę policzyć sumę $(A+B)$, różnicę $(A-B)$, iloczyn $(A*B)$ i iloraz $(A/B)$ rozmyty.

Odpowiedź:

Tworzymy tabelę prawdopodobieństw dla każdej z liczb:

Dla sumy bierzemy maksimum z kombinacji prawdopodobieństw:

| B \ A      | 0.25/0 | 0.5/1  | 1/2    |
| ---------- | ------ | ------ | ------ |
| **1/0**    | 0.25/0 | 0.5/1  | 1/2    |
| **0.5/1**  | 0.25/1 | 0.5/2  | 0.5/3  |
| **0.25/2** | 0.25/2 | 0.25/3 | 0.25/4 |

Czyli: 0.25/0 + 0.5/1 + 1/2 + 0.5/3 + 0.25/4

Dla różnicy A-B bierzemy maksimum z kombinacji prawdopodobieństw:

| B \ A      | 0.25/0  | 0.5/1   | 1/2    |
| ---------- | ------- | ------- | ------ |
| **1/0**    | 0.25/0  | 0.5/1   | 1/2    |
| **0.5/1**  | 0.25/-1 | 0.5/0   | 0.5/1  |
| **0.25/2** | 0.25/-2 | 0.25/-1 | 0.25/0 |

Czyli: 0.25/-2 + 0.25/-1 + 0.5/0 + 0.5/1 + 1/2

Dla iloczynu A\*B bierzemy maksimum z kombinacji prawdopodobieństw:

| B \ A      | 0.25/0 | 0.5/1  | 1/2    |
| ---------- | ------ | ------ | ------ |
| **1/0**    | 0.25/0 | 0.5/0  | 1/0    |
| **0.5/1**  | 0.25/0 | 0.5/1  | 0.5/2  |
| **0.25/2** | 0.25/0 | 0.25/2 | 0.25/4 |

Czyli: 1/0 + 0.5/1 + 0.25/2 + 0.25/4


Dla iloczynu A/B bierzemy maksimum z kombinacji prawdopodobieństw:

| B \ A      | 0.25/0 | 0.5/1  | 1/2    |
| ---------- | ------ | ------ | ------ |
| **1/0**    | 0.25/0 | 0.5/0  | 1/0    |
| **0.5/1**  | 0.25/0 | 0.5/1  | 0.5/2  |
| **0.25/2** | 0.25/0 | 0.25/2 | 0.25/4 |

Czyli: 1/0 + 0.5/1 + 0.5/2 + 0.25/4

Dla ilorazu A/B bierzemy maksimum z kombinacji prawdopodobieństw:

| B \ A        | 0.25 / 0 | 0.5 / 1    | 1 / 2    |
| ------------ | -------- | ---------- | -------- |
| **1 / 0**    | -        | -          | -        |
| **0.5 / 1**  | 0.25 / 0 | 0.5  / 1   | 0.5  / 2 |
| **0.25 / 2** | 0.25 / 0 | 0.25 / 1/2 | 0.25 / 1 |

Czyli: 0.25 / 0 + 0.25 / 1/2 + 0.5 / 1 + 0.5 / 2

### Zadanie 3 - Heurystyki - algorytmy populacyjne vs. niepopulacyjne

Jakie wady i zalety mają populacyjne (działające na wielu rozwiązaniach na raz) algorytmy heurystyczne w stosunku do tych działających na jednym rozwiązaniu (niepopulacyjnych). Proszę podać po 2 przykłady metod populacyjnych i niepopulacyjnych.

Odpowiedź: 

Populacyjne:

- algorytmy genetyczne
- algorytmy ewolucyjne
- algorytmy roju cząstek
- algorytmy symulowanego wyżarzania

Niepopulacyjne:

- algorytmy zachłanne
- algorytmy tabu search

Algorytmy ewolucyjne - zalety:

- Niepotrzebne są założenia o postaci funkcji celu, istnieniu pochodnych, ciągłości, itp.
- Tego samego schematu rozwiązywania można używać do szerokiej gamy zadań.
- Obliczenia prowadzone są równolegle przez dużą grupę "osobników" - rozwiązań, więc jest spora szansa na odwiedzenie wielu obiecujących obszarów.
- Obliczenia trudniej utykają w ekstremach lokalnych i łatwiej mogą je opuścić dzięki wymianie informacji pomiędzy „osobnikami”.
- Obliczenia można łatwo zrównoleglić w systemach wieloprocesorowych, rozproszonych, itp.
- Metoda jest skalowalna, łatwo ją przystosować do konkretnego zadania i jego rozmiaru.
- Mimo braku gwarancji na otrzymanie rozwiązań optymalnych, dobrze dobrana metoda działa szybko i skutecznie.

Algorytmy ewolucyjne - wady:

- Obliczenia są dość powolne i zasobochłonne.
- Dobre efekty można uzyskać tylko po dobrym przystosowaniu metody do wymogów zadania (wybór odpowiedniej metody kodowania, operatorów, selekcji, dostrojeniu parametrów). Standardowa wersja metody, stosowana do wszystkich problemów raczej nie spełni oczekiwań,
- Metoda często cierpi na chorobę „przedwczesnej zbieżności”, czyli zablokowania się rozwiązań w optimach lokalnych i stagnacji obliczeń.
- Problemowi „przedwczesnej zbieżności” trudno jest zapobiegać, wynika on często ze źle dobranych parametrów metody, ale też i ograniczeń środowiska komputerowego (skończona dokładność obliczeń, słabe parametry generatorów liczb losowych).
- Z problemem przedwczesnej zbieżności wiąże się też problem małego zróżnicowania populacji. Jeśli osobniki są prawie jednakowe, to efektywność obliczeń ewolucyjnych znacząco spada (wymiana jednakowej informacji między osobnikami).
- Brak sensownego kryterium stopu, ewolucja zapewne nie ma końca (koniec świata?) i trzeba zapewnić je sztucznie.
- Jak wszystkie metody heurystyczne nie gwarantuje znalezienia optimum w skończonej liczbie iteracji (dlatego symulacja AE prawie zawsze kończy się stagnacją, bo nie możemy czekać na wynik w nieskończoność).

### Zadanie 4 - Systemy ekspertowe - zapis wiedzy

Proszę opisać sposoby zapisu wiedzy w systemach ekspertowych.

Odpowiedź:

System ekspertowy (SE) – w najprostszym ujęciu jest to system komputerowy, który emuluje proces podejmowania decyzji przez eksperta w danej dziedzinie. Jego wyższość nad ekspertem (który zazwyczaj bierze udział w jego tworzeniu) polega na tym, że może brać pod uwagę zdecydowanie więcej faktów i przesłanek, zgromadzonych w
bazie wiedzy systemu oraz może to robić znacznie szybciej. System ekspertowy może służyć również do sterowania obiektami, nad którymi człowiek nie jest w stanie zapanować z uwagi na krótki czas reakcji.

W związku z funkcjonalnością systemu możemy je podzielić na:
- doradcze (wspomagające decyzje człowieka), 
- autonomiczne (samodzielnie podejmujące decyzje) i 
- krytykujące (oceniające sytuację i reakcję ludzką na taką sytuację).

System ekspertowy składa się najczęściej z następujących elementów:
- modułu wnioskującego
- bazy wiedzy
- modułu objaśniającego
- interfejsu z użytkownikiem/twórcą.

W wersji minimalnej system może nie posiadać modułu objaśniającego, choć to
dzięki niemu można prześledzić, jak powstała decyzja systemu (wyjaśnienie).
Moduł wnioskujący może być uniwersalny i może być niezależny od konkretnego
zastosowania systemu (choć nie musi), przetwarza on fakty i reguły z bazy
wiedzy tak, aby otrzymać odpowiedź na zadane pytanie.

Dodatkowo w trakcie używania i rozwijania systemu na pewno potrzebny jest interfejs, prosty przy zwykłym użyciu, bardziej skomplikowany przy rozbudowie bazy faktów (np. sprawdzający, czy tworzona baza wiedzy jest spójna).

Tworzeniem bazy wiedzy systemu ekspertowego zajmują się zazwyczaj inżynierowie wiedzy we współpracy z ekspertami w danej dziedzinie. 


Wiedzę w SE zapisuje się w postaci:
- rachunku zdań i rachunku predykatów (logika);
- metod wykorzystujących zapis stwierdzeń;
- metod wykorzystujących reguły i tzw. wektory wiedzy;
- sieci semantycznych;
- metod opartych na tzw. ramach;
- metod używających modeli obliczeniowych;

### Zadanie 5 - Heurystyki algorytmy heurestyczne vs. dokładne

W jakich sytuacjach (związanych z obliczeniami np. optymalizacją) opłacalne jest stosowanie algorytmów heurystycznych, a w jakich stosuje się metody dokładne?

Odpowiedź:

Optymalizacja klasyczna (algorytmy dokładne i aproksymacyjne):
- wykorzystywane są metody numeryczne o udowodnionej zbieżności i znanych właściwościach (otrzymane rozwiązanie jest optymalne lub znamy oszacowanie dokładności rozwiązań przybliżonych);
- stosowalność tych metod jest często bardzo ograniczona do konkretnych klas zadań lub określonych ich właściwości (np. zadania liniowe, „ciągłe”, dyskretne, bez ograniczeń, różniczkowalne, itp.);
- czas lub rzadziej ilość pamięci potrzebna do uzyskania przy ich użyciu rozwiązania są często nieakceptowalnie duże.

Optymalizacja heurystyczna:
- najczęściej brak dowodu i oszacowania charakteru zbieżności;
- metody mają dość szerokie spektrum zastosowań (często trzeba je specjalizować);
- wyniki otrzymywane są dość szybko, nawet dla dużych zadań i są sukcesywnie poprawiane, lecz nie są dokładne (nie można liczyć na optimum);
- często nie mają naturalnego kryterium stopu, przez co nie można nic powiedzieć o jakości otrzymanych rozwiązań.