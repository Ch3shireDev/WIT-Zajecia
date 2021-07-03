# Rachunek prawdopodobieństwa i statystyka

### Zestaw zadań nr 1

Temat: Doświadczenie losowe i rachunek zdarzeń losowych. Podstawowe metody obliczania prawdopodobieństwa.

### Zadanie 1

Podaj przykład doswiadczenia losowego, dla którego zbiór wszystkich możliwych wyników (zwany przestrzenią zdarzeń elementarnych $\Omega$) jest:

- a) skonczony,
- b) nieskonczony przeliczalny,
- c) nieskonczony nieprzeliczalny

#### Rozwiązanie

- a) Rzut kością, rzut monetą
- b) Rzut kością do momentu wypadnięcia konkretnej wartości
- c) Rzut strzałą w tarczę (i zapisywanie lokalizacji)

### Zadanie 2

Podaj przykład doświadczenia losowego, dla którego przestrzeń zdarzeń elementarnych $\Omega = \{1, 2, 3, 4, 5, 6\}$. Dla tej
przestrzeni określono podzbiory: 
- $A = \{1, 2\},$ 
- $B = \{2, 4, 6\}$,
- $C = \{1, 3\}$. 

Znajdź zbiory:
- $A \cap B,$ 
- $B \cup C,$
- $A \cap \{B \cup C\}'.$

#### Rozwiązanie

- $A \cap B,$ 

Część wspólna zbiorów A i B to zbiór składający się z elementów należących jednocześnie do A oraz B - $\{2\}$.

- $B \cup C,$

Suma zbiorów B i C - elementy należące jednocześnie do B oraz C: $\{1,2,3,4,6\}$.

- $A \cap \{B \cup C\}'.$

Krok po kroku:

- $B\cup C$ to suma zbiorów B i C, czyli $\{1,2,3,4,6\}$.
- dopełnienie $\{B\cup C\}'$ to $\{5\}$.
- Przecięcie zbioru A z dopełnieniem $\{B\cup C\}'$ to zbiór pusty $\empty$.

### Zadanie 3

Niech A, B i C oznaczają trzy dowolne zdarzenia w przestrzeni zdarzeń elementarnych $\Omega$ (np. takie jak w zadaniu 2).

Przedstaw na diagramie Venna i zapisz następujace zdarzenia: 

spośród zdarzeń A, B oraz C
- a) zachodzi tylko A,



- b) zachodzą A i B, a C nie zachodzi,
- c) zachodzą wszystkie trzy,
- d) zachodzi co najmniej jedno,
- e) zachodzą co najmniej dwa,
- f) zachodzi tylko jedno,
- g) zachodzą dokładnie dwa,
- h) żadne nie zachodzi,
- i) zachodzą co najwyżej dwa.

### Zadanie 4

W wyniku egzaminu student może uzyskać jedną z czterech ocen: 2, 3, 4, 5. Interesuje nas ocena z egzaminu losowo wybranego studenta.
a) Określ przestrzeń zdarzeń elementarnych $\Omega$.
b) Wypisz wszystkie zdarzenia dla tego doświadczenia.
c) Zinterpretuj nast˛epujace
˛ zdarzenia: A = {3, 4, 5}, B = {2}, C = {4, 5}, A ∪ B, A\B, B ∩ C, B 0 .
d) Zakładajac,
˛ że zdobycie każdej oceny jest jednakowo prawdopodobne, oblicz prawdopodobieństwo zdania egzaminu.

### Zadanie 5

Wśród sześciu układów scalonych dwa są uszkodzone. Wylosowano (bez zwracania) dwa układy do testowania. Jakie
jest prawdopodobieństwo, że oba z nich są wadliwe? Zapisz przestrzeń zdarzeń elementarnych dla tego doświadczenia.

### Zadanie 6

Doświadczenie polega na trzykrotnym rzuceniu symetryczną (uczciwa)
˛ moneta.˛ Znajdź przestrzeń zdarzeń elementarnych $\Omega$. Oblicz prawdopodobieństwo zajścia nast˛epujacych
˛
zdarzeń (a) reszka pojawi si˛e dwa razy, (b) reszka pojawi
si˛e co najmniej dwa razy, (c) reszka pojawi si˛e co najwyżej dwa razy.

### Zadanie 7

Doświadczenie polega na rzucaniu monetą do momentu wyrzucenia po raz pierwszy orła. Podaj przestrzeń zdarzeń
elementarnych $\Omega$. Wyznacz prawdopodobieństwo otrzymania orła nie później niż w czwartym rzucie.

### Zadanie 8

Oblicz prawdopodobieństwo, że przypadkowo wybrany punkt kwadratu |x| ≤ 2, |y| ≤ 2 jest jednocześnie punktem
leżacym
˛
wewnatrz
˛ okr˛egu o równaniu x2 + y 2 = 4.

### Zadanie 9

Niech C i D oznaczają zdarzenia, takie że P (C) = 0,25, P (D) = 0,45, P (C ∩ D) = 0,1. Oblicz P (C 0 ∩ D).

### Zadanie 10

Nowy wirus komputerowy może dostać si˛e do systemu pocztą elektroniczną lub przez Internet. Jest 30% szans na dostanie si˛e go przez e-mail. Jest 40% szans na dostanie si˛e go przez Internet. Wirus dostaje si˛e do systemu jednocześnie
za pośrednictwem poczty elektronicznej i Internetu z prawdopodobieństwem 0,15. Jakie jest prawdopodobieństwo, że
wirus w ogóle nie dostanie si˛e do systemu?

Anna.Olwert@wit.edu.pl

WSISiZ Wydział Informatyki

Strona 1

RACHUNEK PRAWDOPODOBIEŃSTWA I STATYSTYKA

Zestaw zadań nr 2

Temat: Prawdopodobieństwo warunkowe i zdarzenia niezależne. Twierdzenie o prawdopodobieństwie całkowitym i reguła Bayesa.

### Zadanie 1

Wśród pracowników pewnej firmy, 70% potrafi programować w , 60% - w Fortranie, a 50% zna oba j˛ezyki programowania. Jaka cz˛eść programistów:
(a) nie zna j˛ezyka Fortran?
(b) nie zna j˛ezyka Fortran i nie zna j˛ezyka C/C++?
(c) umie programować w C/C++, ale nie w Fortranie?
(d) jeśli zna Fortran, to zna też C/C++?
(e) jeśli zna C/C++, to zna również Fortran?

### Zadanie 2

Antek i Tomek niezbyt cz˛esto pojawiają si˛e na zaj˛eciach w szkole. Antek jest obecny na 60% zaj˛eć, zaś jego kolega
wagaruje zwykle 3 razy na 10 lekcji. Obu można spotkać jednocześnie na 40% lekcji. Oblicz prawdopodobieństwo,
że na zaj˛eciach (a) jest choć jeden z nich, (b) jest dokładnie jeden z nich, (c) nie ma żadnego z nich. Czy "przyjście
Antka"i "przyjście Tomka" na zaj˛ecia są zdarzeniami niezależnymi?

### Zadanie 3

Program komputerowy składa si˛e z dwóch bloków napisanych niezależnie przez dwóch programistów. Prawdopodobieństwo tego, że w pierwszym bloku jest bład
˛ wynosi 0,2, zaś tego, że w drugim - 0,3. Jeśli program zwraca bład,
˛
jakie jest prawdopodobieństwo bł˛edu w obu blokach?

### Zadanie 4

W przypadku dobrych warunków pogodowych 80% przylotów jest na czas. W czasie złej pogody, tylko 30% przylotów jest na czas. Janek planuje odebrać jutro gościa z lotniska i wie, że z prawdopodobieństwem 0,6 przewidywana
jest na jutro dobra pogoda. Jakie jest prawdopodobieństwo, że gość Janka wyladuje
˛
o planowanym czasie (przylot nie
b˛edzie opóźniony)?

### Zadanie 5

Fabryka chemiczna jest wyposażona w system alarmowy. W razie zagrożenia system alarmowy działa w 95% przypadków. Istnieje jednak prawdopodobieństwo 0,02, że system właczy
˛
si˛e, gdy nie ma żadnego zagrożenia. Rzeczywiste
zagrożenie zdarza si˛e rzadko – jego prawdopodobieństwo wynosi 0,004. Gdy odzywa si˛e system alarmowy, jakie jest
prawdopodobieństwo, że naprawd˛e istnieje zagrożenie?

### Zadanie 6

Około 70% kobiet i 90% m˛eżczyzn posiada prawo jazdy. Z populacji liczacej
˛ 400 kobiet i 600 m˛eżczyzn wybrano
jedną osob˛e.
(a) Jakie jest prawdopodobieństwo, że wybrana osoba ma prawo jazdy?
(b) Wiedzac,
˛ że wybrana osoba posiada prawo jazdy, oblicz prawdopodobieństwo, że jest to m˛eżczyzna.

### Zadanie 7

Student składajacy
˛ komputer zauważył, że brakuje mu jeszcze jednej cz˛eści. W mieście znajdują si˛e 4 sklepy gdzie
można nabyć brakujac
˛ ą cz˛eść, przy czym: w sklepie A znajduje si˛e 2000 sztuk tej cz˛eści, z czego 5% jest wadliwych,
w sklepie B - 500 sztuk, z czego 40% jest wadliwych, w sklepach C i D jest po 1000 sztuk, a w każdym z nich 10%
jest wadliwych. Student nie wykazuje żadnych preferencji, co do wyboru sklepu, losowo wybiera jeden ze sklepów
i zakupuje brakujac
˛ ą cz˛eść.
(a) Jakie jest prawdopodobieństwo, że zakupiona cz˛eść jest wadliwa?
(b) Jakie jest prawdopodobieństwo, że zakupiona cz˛eść działa poprawnie?
(c) Okazało si˛e, że zakupiona cz˛eść jest wadliwa, jakie jest prawdopodobieństwo, że student nabył ją w sklepie A?
(d) Wiemy, że nabyta cz˛eść działa poprawnie, w którym ze sklepów została ona najprawdopodobniej zakupiona?

### Zadanie 8

Do serwisu komputerowego dostarczane są cz˛eści od trzech dostawców S1, S2 i S3. Od S1 pochodzi 50% zamówienia,
od S2 - 20%, a od S3 - 30%. Wiadomo, że 5% cz˛eści od dostawcy S1 jest wadliwych, a od dostawców S2 i S3,
odpowiednio 3% i 6%. Jakie jest prawdopodobieństwo, że dostarczona cz˛eść b˛edzie wadliwa? Jeśli zamówiona cz˛eść
okazała si˛e wadliwa, to jakie jest prawdopodobieństwo, że pochodzi ona od dostawcy S1?

### Zadanie 9

Czerwony Kapturek idzie do babci. Dziewczynk˛e po drodze mogą spotkać nieprzyjemności, na przykład czyhajacy
˛
w zaroślach - z prawdopodobieństwem 0,3 - zły wilk albo złamanie nogi z prawdopodobieństwem 0,2. Zdarzenia
te wydarzają si˛e niezależnie od siebie. (a) Oblicz prawdopodobieństwo, że babcia ujrzy dziś swoją wnuczk˛e całą
i zdrowa.˛ (b) Jakie jest prawdopodobieństwo spełnienia si˛e znanego powiedzenia, że nieszcz˛eścia chodzą parami?

WSISiZ Wydział Informatyki

Strona 1

RACHUNEK PRAWDOPODOBIEŃSTWA I STATYSTYKA

Zestaw zadań nr 2

### Zadanie 10

Program komputerowy jest testowany przez 3 niezależne testy. Jeśli w programie istnieje bład,
˛ testy te wykrywają go
z prawdopodobieństwami, odpowiednio, 0,2, 0,3 i 0,5. Przypuśćmy, że program zawiera bład.
˛ Jakie jest prawdopodobieństwo, że przynajmniej jeden z testów go wykryje?

### Zadanie 11

Sklep jest zaopatrywany w żarówki pochodzace
˛ z trzech fabryk, przy czym 20% żarówek pochodzi z pierwszej fabryki, 30% z drugiej, 50% z trzeciej. Produkcja pierwszej fabryki zawiera 1% żarówek wadliwych, produkcja drugiej
fabryki – 5% żarówek wadliwych, a produkcja trzeciej fabryki 10% żarówek wadliwych.
(a) Oblicz prawdopodobieństwo, że losowo wybrana w sklepie żarówka b˛edzie wadliwa.
(b) Losowo wybrana żarówka okazała si˛e wadliwa. Jakie jest prawdopodobieństwo, że wyprodukowała ją trzecia
fabryka?

### Zadanie 12

W zakładzie 20% wszystkich wyprodukowanych cz˛eści podlega specjalnej kontroli elektronicznej. Wiadomo, że
każda wyprodukowana cz˛eść, która została sprawdzona elektronicznie, nie ma wad z prawdopodobieństwem 0,95.
Dla cz˛eści, które nie zostały sprawdzone elektronicznie, prawdopodobieństwo to wynosi tylko 0,7. Klient otrzymuje
cz˛eść i znajduje w niej wady. Jakie jest prawdopodobieństwo, że ta cz˛eść przeszła kontrol˛e elektroniczna?
˛

### Zadanie 13

Uruchomienie wahadłowca zależy od prawidłowego działania trzech kluczowych niezależnych urzadzeń.
˛
Prawdopodobieństwa, że urzadzenia
˛
te nie zadziałają poprawnie wynosza,˛ odpowiednio, 0,01, 0,02 i 0,02. Jeśli okaże si˛e, że
któreś z urzadzeń
˛
nie zadziała, start wahadłowca zostanie odłożony. Oblicz prawdopodobieństwo uruchomienia promu
zgodnie z jego harmonogramem.

### Zadanie 14

Kabel o łacznej
˛
długości 3008 km, składa si˛e z odcinków 10-kilometrowych łaczonych
˛
specjalnymi przekaźnikami
wzmacniajacymi
˛
sygnał. Zakłada si˛e, że z prawdopodobieństwem 0,999 przekaźnik b˛edzie pracował niezawodnie
przez 10 lat oraz uszkodzenia przekaźników są od siebie niezależne. Oblicz prawdopodobieństwo niezawodnej pracy
wszystkich przekaźników przez 10 lat.

### Zadanie 15

Wszyscy sportowcy na igrzyskach olimpijskich są testowni na obecność sterydów. Test daje pozytywny wynik (wskazuje na ich obecność) dla 90% wszystkich stosujacych
˛
sterydy, ale też (nieprawidłowo) dla 2% nie przyjmujacych
˛
sterydów. Załóżmy, że 5% wszystkich zarejestrowanych sportowców jest pod wpływem sterydów. Jeśli sportowiec
jest badany negatywnie, jakie jest prawdopodobieństwo, że zastosował sterydy?

### Zadanie 16

Oblicz niezawodność każdego układu (rysunek poniżej), jeśli przekaźniki A, B, C, D i E działają niezależnie, a prawdopodobieństwa ich poprawnej pracy wynosza,˛ odpowiednio, 0,9, 0,8, 0,7, 0,6 i 0,5.

Odpowiedzi: 1a) 0.3, 1b) 0.2, 1c) 0.2, 1d) 5/6, 1e) 5/7, 2a) 0.9, 2b) 0.5, 2c) 0.1, nie są niezależne, 3) 0.1364, 4) 0.6, 5) 0.16,
6a) 0.82, 6b) 0.66, 7a) 0.16, 7b) 0.94 7c) 0.08, 7d) A, 8) 0.05, 0.51, 9a) 0.56, 9b) 0.06, 10) 0.72, 11a) 0.067, 11b) 0.75, 12)
0.04, 13) 0.95, 14) 0.74, 15) 0.005, 16a) 0.72, 16b) 0.838, 16c) 0.994, 16d) 0.892, 16e) 0.931

WSISiZ Wydział Informatyki

Strona 2
