### 1. Jakie są warunki prawidłowego rozwiązania problemu sekcji krytycznej?

Sekcją krytyczną jest ten fragment procesu, który do działania wymaga dostępu do wspólnych zasobów, do których mogą w tym samym czasie uzyskiwać dostęp inne procesy. Rozwiązanie problemu sekcji krytycznej składa się z trzech warunków:

01. Wzajemne wykluczanie - jeśli dany proces działa w swojej sekcji krytycznej, to żaden inny z procesów nie może działać w swojej sekcji krytycznej.
02. Postęp - jeśli żaden z procesów nie działa w sekcji krytycznej i jakieś procesy chcą wejść w swoje sekcje krytyczne, to tylko procesy niewykonujące w danej chwili innych zadań mogą tam wejść.
03. Ograniczone czekanie - musi istnieć ograniczona liczba wejść po tym jak dany proces zgłosił chęć na wejście do swojej sekcji krytycznej.

### 2. W jaki sposób wykrywa się istnienie blokady (zakleszczenia) procesów? W jaki sposób można przełamać blokadę?

Zakleszczenia wykrywa się poprzez budowę grafu oczekiwania (dla procesów korzystających z zasobów o pojedynczym egzemplarzu) lub poprzez zastosowanie algorytmu wykrywania blokad (opisanego w Podstawach systemów operacyjnych). Skupimy się na wariancie dla zasobów o pojedynczym egzemplarzu.

Tworzony jest graf oczekiwania - ponieważ zasoby występują w jednym egzemplarzu, każdy proces który czeka na zasób jest blokowany przez dokładnie jeden, inny, proces. Następnie w takim grafie sprawdza się, czy nie występuje cykl - jeśli występuje, spełniony jest warunek zakleszczenia.

Zakleszczenia przełamuje się poprzez:
* usunięcie jednego lub wielu procesów przetrzymujących zasób
* wywłaszczenie procesów z przetrzymywanych zasobów

### 03. Jak system operacyjny wieloprocesora zarządza szeregowaniem procesów?

### 11. Jak działa system operacyjny w przypadku wieloprocesora?

System wieloprocesorowy zawiera jedną kolejkę uruchomień, wspólną pamięć dzieloną, wspólne zasoby, połączenie szyną oraz wiele jednostek centralnych (tj. procesorów). W przypadku systemów operacyjnych wieloprocesorowych z kwantem czasu kiedy na jednym z procesorów kończy się kwant czasu, przekazywany jest do niego kolejny proces czekający w kolejce, natomiast bieżący proces przechodzi na koniec kolejki.

### 04. Wyjaśnić pojęcie spójności pamięci i w jaki sposób zapewnia się spójność pamięci w wieloprocesorach korzystających z pamięci podręcznych?

### 07. W jaki sposób zapewnia się spójność pamięci w wieloprocesorach korzystających z pamięci podręcznych?

### 05. Wyjaśnić pojęcie spójności pamięci w wieloprocesorach.

Dane zapisywane w pamięci podręcznej powinny być takie same jak dane zapisywane w pamięci operacyjnej. Jeśli jeden z procesorów aktualizuje wartość zmiennej w swojej pamięci podręcznej (odpowiadającej zmiennej w pamięci operacyjnej), to wszystkie inne procesory korzystające też z tej zmiennej również powinny mieć zaktualizowaną wartość tej zmiennej w swoich pamięciach podręcznych.

Aby zapewnić spójność pamięci, pamięć podręczna powinna być:

* przepisywalna - aktualizacja wartości przechowywanych w pamięciach podręcznych w przypadku jeśli zmieni się wartość w pamięci operacyjnej.
* podglądająca - powinna podsłuchiwać szynę na wypadek przechodzenia przez nią adresów danych których kopię przechowuje ona w pamięci podręcznej. W wypadku przechodzenia takich danych, pamięć podręczna powinna albo zaktualizować swoje dane, albo wyrzucić zmienną z pamięci podręcznej, by wymusić odwołanie się do pamięci operacyjnej (co jest powolniejsze, ale gwarantuje uzyskanie aktualnej wartości).

### 05. Co to jest stan bezpieczny systemu przydziału zasobów?

Stan systemu określa się jako bezpieczny, jeśli istnieje porządek w którym system może przydzielić zasoby każdemu procesowi, stale unikając zakleszczenia. (str. 295).

### 06. Co to jest sekcja krytyczna?

Sekcja krytyczna procesu jest takim fragmentem, w którym proces wymaga uzyskania dostępu i zablokowania współdzielonych zasobów dla innych procesów.

### 08. Co to jest semafor?

Semafor jest współdzieloną zmienną do której jest dostęp poprzez dwie atomowe operacje, `czekaj()` oraz `sygnalizuj()` . Operacja `czekaj()` zawiesza proces na tak długo, dopóki zmienna semaforowa nie stanie się dodatnia, wtedy wartość zmiennej s. obniżana jest o jeden i proces wykonuje się dalej (ideowo, wchodząc do sekcji krytycznej). Operacja `sygnalizuj()` obniża wartość zmiennej semaforowej o 1 i ideowo, jest wywoływana przez proces po wyjściu z sekcji krytycznej. Semafory pozwalają na koordynację wykonywania sekcji krytycznych przez procesy i rozwiązywanie problemu zakleszczeń.

### 09. Czym różni się wieloprocesor od multikomputera?

### 02. Jakie są różnice między wieloprocesorami a multikomputerami?

Wieloprocesor jest pojedynczą maszyną z wieloma procesorami i współdzieloną pamięcią operacyjną oraz zasobami. Wszystkie procesory korzystają z jednej szyny.

Multikomputer jest wieloma komputerami z własnymi pamięciami operacyjnymi, połączonymi poprzez sieć LAN.

### 10. Co to jest stan blokady (zakleszczenia) procesów?

### 12. Jakie są warunki konieczne wystąpienia blokady (zakleszczenia) procesów?

Stan zakleszczenia występuje wtedy, gdy:
* istnieją w systemie zasoby niepodzielne, tj. takie w których korzystanie z egzemplarza zasobu przez jeden proces uniemożliwia korzystania z niego innemu procesowi
* proces przetrzymujący egzemplarz któregoś z zasobu oczekuje na zasób przetrzymywany przez inny proces
* nie jest możliwe wywłaszczenie zasobów z procesu, tj. zwolnienie zasobu następuje jedynie po użyciu go przez dany proces
* istnieje w systemie operacyjnym cykl n procesów, z których każdy kolejny proces oczekuje na zasób przetrzymywany przez proces następny w kolejności (modulo n, tj. proces Pn-1 oczekuje na zasób przetrzymywany przez proces P0).

### 11. Czym różni się połączenie szynowe od połączenia przełączanego?

### 03. Czym różni się architektura powiązań szynowych od przełączanych?

W architekturze szynowej mamy procesory (posiadające własne pamięci podręczne) połączone jedną szyną danych z główną pamięcią.

W architekturze przełączanej mamy pewną ilość procesorów i pewną ilość pamięci, łączonych przy pomocy wybieraka krzyżowego.

### 13. Co to jest dostępność systemu?

(ang availability) Gotowość systemu do natychmiastowego użycia - prawdopodobieństwo, że system działa poprawnie w dowolnej chwili i jest gotów działać na zlecenie użytkowników.

### 14. Co oznacza pojęcie przezroczystości w systemach rozproszonych?

### 01. Co to jest system rozproszony?

### 12. Wyjaśnić pojęcie przezroczystości w systemach rozproszonych?

### 13. Co oznacza przezroczystość położenia (location transparency) w systemach rozproszonych?

### 14. Co oznacza przezroczystość zwielokrotnienia w systemach rozproszonych?

### 15. Co oznacza przezroczystość wędrówki - migracji (migration transparency) w systemach ### rozproszonych?

### 16. Jakie są dwie podstawowe koncepcje budowy operacyjnych systemów rozproszonych?

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

### 15. Czym różnią się metody zapobiegania od metod unikania blokady (zakleszczenia) procesów?

Zapobieganie blokadom polega na wyeliminowaniu co najmniej jednego z warunków koniecznych do zakleszczenia procesów - wzajemnego wykluczenia, trzymania zasobów i oczekiwania, cyklicznego oczekiwania, braku wywłaszczania zasobów.

Unikanie blokad polega na podejmowaniu decyzji przez system operacyjny czy proces zamawiający dany zasób ma czekać czy uzyskać go od razu.

### 04. Co to jest szyna? Jak procesory korzystają z szyny porozumiewając się z pamięcią? 

### 06. Jakie właściwości muszą posiadać pamięci podręczne w wieloprocesorach, aby zapewnić spójność ### pamięci?

### 07. Czy wieloprocesory szynowe mogą być budowane z większej liczby procesorów niż przełączane, czy z mniejszej? Wyjaśnić, dlaczego?

### 08. Wyjaśnić ideę przełącznika krzyżowego stosowanego w wieloprocesorach.

### 09. Wyjaśnić ideę sieci "Omega" stosowaną w wieloprocesorach. 

### 10. Czym różnią się prawdziwe systemy rozproszone od stosowanych obecnie powszechnie systemów ### sieciowych?
