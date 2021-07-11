### Co to jest sekcja krytyczna?

Sekcja krytyczna procesu jest takim fragmentem, w którym proces wymaga uzyskania dostępu i zablokowania współdzielonych zasobów dla innych procesów.

### Jakie są warunki prawidłowego rozwiązania problemu sekcji krytycznej?

Sekcją krytyczną jest ten fragment procesu, który do działania wymaga dostępu do wspólnych zasobów, do których mogą w tym samym czasie uzyskiwać dostęp inne procesy. Rozwiązanie problemu sekcji krytycznej składa się z trzech warunków:

01. Wzajemne wykluczanie - jeśli dany proces działa w swojej sekcji krytycznej, to żaden inny z procesów nie może działać w swojej sekcji krytycznej.
02. Postęp - jeśli żaden z procesów nie działa w sekcji krytycznej i jakieś procesy chcą wejść w swoje sekcje krytyczne, to tylko procesy niewykonujące w danej chwili innych zadań mogą tam wejść.
03. Ograniczone czekanie - musi istnieć ograniczona liczba wejść po tym jak dany proces zgłosił chęć na wejście do swojej sekcji krytycznej.

### W jaki sposób wykrywa się istnienie blokady (zakleszczenia) procesów? W jaki sposób można przełamać blokadę?

Zakleszczenia wykrywa się poprzez budowę grafu oczekiwania (dla procesów korzystających z zasobów o pojedynczym egzemplarzu) lub poprzez zastosowanie algorytmu wykrywania blokad (opisanego w Podstawach systemów operacyjnych). Skupimy się na wariancie dla zasobów o pojedynczym egzemplarzu.

Tworzony jest graf oczekiwania - ponieważ zasoby występują w jednym egzemplarzu, każdy proces który czeka na zasób jest blokowany przez dokładnie jeden, inny, proces. Następnie w takim grafie sprawdza się, czy nie występuje cykl - jeśli występuje, spełniony jest warunek zakleszczenia.

Zakleszczenia przełamuje się poprzez:
* usunięcie jednego lub wielu procesów przetrzymujących zasób
* wywłaszczenie procesów z przetrzymywanych zasobów

### Czym różnią się metody zapobiegania od metod unikania blokady (zakleszczenia) procesów?

Zapobieganie blokadom polega na wyeliminowaniu co najmniej jednego z warunków koniecznych do zakleszczenia procesów - wzajemnego wykluczenia, trzymania zasobów i oczekiwania, cyklicznego oczekiwania, braku wywłaszczania zasobów.

Unikanie blokad polega na podejmowaniu decyzji przez system operacyjny czy proces zamawiający dany zasób ma czekać czy uzyskać go od razu.

### Co to jest stan bezpieczny systemu przydziału zasobów?

Stan systemu określa się jako bezpieczny, jeśli istnieje porządek w którym system może przydzielić zasoby każdemu procesowi, stale unikając zakleszczenia. (str. 295).

### Co to jest semafor?

Semafor jest współdzieloną zmienną do której jest dostęp poprzez dwie atomowe operacje, `czekaj()` oraz `sygnalizuj()` . Operacja `czekaj()` zawiesza proces na tak długo, dopóki zmienna semaforowa nie stanie się dodatnia, wtedy wartość zmiennej s. obniżana jest o jeden i proces wykonuje się dalej (ideowo, wchodząc do sekcji krytycznej). Operacja `sygnalizuj()` obniża wartość zmiennej semaforowej o 1 i ideowo, jest wywoływana przez proces po wyjściu z sekcji krytycznej. Semafory pozwalają na koordynację wykonywania sekcji krytycznych przez procesy i rozwiązywanie problemu zakleszczeń.

### Jak działa system operacyjny w przypadku wieloprocesora? Jak system operacyjny wieloprocesora zarządza szeregowaniem procesów?

System wieloprocesorowy zawiera jedną kolejkę uruchomień, wspólną pamięć dzieloną, wspólne zasoby, połączenie szyną oraz wiele jednostek centralnych (tj. procesorów). W przypadku systemów operacyjnych wieloprocesorowych z kwantem czasu kiedy na jednym z procesorów kończy się kwant czasu, przekazywany jest do niego kolejny proces czekający w kolejce, natomiast bieżący proces przechodzi na koniec kolejki.

### Wyjaśnić pojęcie spójności pamięci i w jaki sposób zapewnia się spójność pamięci w wieloprocesorach korzystających z pamięci podręcznych?

Dane zapisywane w pamięci podręcznej powinny być takie same jak dane zapisywane w pamięci operacyjnej. Jeśli jeden z procesorów aktualizuje wartość zmiennej w swojej pamięci podręcznej (odpowiadającej zmiennej w pamięci operacyjnej), to wszystkie inne procesory korzystające też z tej zmiennej również powinny mieć zaktualizowaną wartość tej zmiennej w swoich pamięciach podręcznych.

Aby zapewnić spójność pamięci, pamięć podręczna powinna być:

* przepisywalna - aktualizacja wartości przechowywanych w pamięciach podręcznych w przypadku jeśli zmieni się wartość w pamięci operacyjnej.
* podglądająca - powinna podsłuchiwać szynę na wypadek przechodzenia przez nią adresów danych których kopię przechowuje ona w pamięci podręcznej. W wypadku przechodzenia takich danych, pamięć podręczna powinna albo zaktualizować swoje dane, albo wyrzucić zmienną z pamięci podręcznej, by wymusić odwołanie się do pamięci operacyjnej (co jest powolniejsze, ale gwarantuje uzyskanie aktualnej wartości).

### Czym różni się wieloprocesor od multikomputera?

Wieloprocesor jest pojedynczą maszyną z wieloma procesorami i współdzieloną pamięcią operacyjną oraz zasobami. Wszystkie procesory korzystają z jednej szyny.

Multikomputer jest wieloma komputerami z własnymi pamięciami operacyjnymi, połączonymi poprzez sieć LAN.

### Co to jest stan blokady (zakleszczenia) procesów? Jakie są warunki konieczne wystąpienia blokady (zakleszczenia) procesów?

Stan zakleszczenia występuje wtedy, gdy:
* istnieją w systemie zasoby niepodzielne, tj. takie w których korzystanie z egzemplarza zasobu przez jeden proces uniemożliwia korzystania z niego innemu procesowi
* proces przetrzymujący egzemplarz któregoś z zasobu oczekuje na zasób przetrzymywany przez inny proces
* nie jest możliwe wywłaszczenie zasobów z procesu, tj. zwolnienie zasobu następuje jedynie po użyciu go przez dany proces
* istnieje w systemie operacyjnym cykl n procesów, z których każdy kolejny proces oczekuje na zasób przetrzymywany przez proces następny w kolejności (modulo n, tj. proces Pn-1 oczekuje na zasób przetrzymywany przez proces P0).

### Czym różni się połączenie szynowe od połączenia przełączanego? Czym różni się architektura powiązań szynowych od przełączanych?

W architekturze szynowej mamy procesory (posiadające własne pamięci podręczne) połączone jedną szyną danych z główną pamięcią.

W architekturze przełączanej mamy pewną ilość procesorów i pewną ilość pamięci, łączonych przy pomocy wybieraka krzyżowego.

### Co to jest dostępność systemu?

(ang availability) Gotowość systemu do natychmiastowego użycia - prawdopodobieństwo, że system działa poprawnie w dowolnej chwili i jest gotów działać na zlecenie użytkowników.

### Co to jest system rozproszony? Co oznacza pojęcie przezroczystości w systemach rozproszonych?

System rozproszony to układ niezależnych komputerów sprawiający wrażenie na użytkowniku że jest jedną maszyną (tj. spełniający warunki przezroczystości).

Przezroczystością określa się ukrywanie przed użytkownikami faktu, że pracują na systemie rozproszonym pomiędzy wieloma komputerami, zamiast na jednej maszynie. Wyszczególnia się przezroczystości:

* dostępu - ukrywane są różnice w reprezentacji danych i sposobie dostępu do zasobów
* położenia - ukrywane jest położenie zasobu
* wędrówki - ukrywana jest możliwość przenoszenia zasobu między maszynami
* przemieszczenia - ukrywane jest przenoszenie zasobów między maszynami w trakcie wykonywania procesu
* zwielokrotnienia - ukrywany jest fakt zwielokrotnienia zasobów przez system rozproszony
* współbieżności - ukrywany jest fakt uzyskiwania dostępu do jednego zasobu przez wielu użytkowników
* awarii - ukrywany jest fakt awarii części maszyn systemu
* trwałości - ukrywany jest fakt czy zasób przechowywany jest w pamięci czy na dysku.

### Jakie są dwie podstawowe koncepcje budowy operacyjnych systemów rozproszonych?

Niezawodność i Dostępność, w których nacisk położono na integralność danych, bezpieczeństwo danych i tolerowanie awarii wraz z mechanizmami ochrony przed utratą danych.

Sieciowe systemy operacyjne – użytkownicy są świadomi wielkości maszyn i w celu dostępu do zasobów muszą rejestrować się na zdalnych maszynach lub przesyłać dane z odległych maszyn do swoich.
Rozproszone systemy operacyjne – użytkownicy nie muszą być świadomi wielkości maszyn. Dostęp do zasobów zdalnych uzyskują oni tak samo jak do zasobów lokalnych.

Elastyczność oparta na dwóch strukturach systemów, w których:
* Każda maszyna wykonuje monolityczne jądro dostarczające większości usług.
* Idea mikrojądra zapewniającego nieliczne usługi, a większość usług zapewniana przez specjalizowane serwery poziomu użytkownika.

### Co to jest szyna? Jak procesory korzystają z szyny porozumiewając się z pamięcią? 

(str 533) Szyna (magistrala, bus) jest wiązką przewodów wraz ze ściśle zdefiniowanym protokołem, precyzującym zbiór komunikatów które można tymi przewodami przesyłać.

Szyna inaczej magistrala jest medium komunikacji między procesorami a pamięcią. Zawiera pewną liczbę linii adresowych, linii danych oraz linii kontrolnych. Z szyny korzystają wieloprocesory szynowe.

### Czy wieloprocesory szynowe mogą być budowane z większej liczby procesorów niż przełączane, czy z mniejszej? Wyjaśnić, dlaczego?

Wieloprocesory szynowe mogą być budowane z mniejszej liczby procesorów niż przełączane ze względu na charakter współpracy z pamięcią. W architekturze szynowej tylko jeden procesor może komunikować się w danej chwili z pamięcią, a w architekturze przełączanej każdy procesor może współpracować z odrębnym modułem pamięci w danej chwili, co jest bezpośrednim efektem użycia wybieraków krzyżowych.

### Wyjaśnić ideę przełącznika krzyżowego stosowanego w wieloprocesorach.

Przełącznik krzyżowy łączy proces z modułem pamięci. W przypadku gdy mamy dostępnych n procesorów i m modułów pamięci możemy skonstruować macierz n x m, gdzie na przecięciu każdego wiersza i kolumny umieszczamy jeden przełącznik krzyżowy. Umożliwia na to połączenie dowolnego z procesorów z dowolnym z dostępnych modułów pamięci. 

### Wyjaśnić ideę sieci "Omega" stosowaną w wieloprocesorach. 

W sieci Omega dzięki zastosowaniu przełączników poczwórnych możemy stworzyć sieć przełączającą łączącą dowolny procesor z dowolnym modułem pamięci tylko przy użyciu tej samej liczby przełączników co procesorów czy modułów pamięci. Dodatkowo sposób łączenie przełączników z procesorami i modułami pamięci umożliwia zestawienie wielu bezkonfliktowych połączeń pomiędzy wybranymi procesorami a modułami pamięci.

### Czym różnią się prawdziwe systemy rozproszone od stosowanych obecnie powszechnie systemów sieciowych?

Sieciowe systemy operacyjne:
Stacje robocze połączone są siecią LAN.
Każda maszyna ma własny system operacyjny

Prawdziwe systemy rozproszone:
Wiele komputerów połączonych siecią
Wrażenie jednolitego systemu (wirtualny monoprocesor)
Wszyscy wykonują jeden system operacyjny w n kopiach
Dzielenie plików na dobrze określoną semantykę.
