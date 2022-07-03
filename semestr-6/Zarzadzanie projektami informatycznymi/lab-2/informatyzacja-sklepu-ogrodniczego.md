## Planowanie projektu informatycznego

Termin do środy 18.05, 23:59.

Należy stworzyć harmonogram projektu dotyczącego informatyzacji sklepu ogrodniczego.
Termin wykonania projektu - 3 miesiące od dnia dzisiejszego.
Zadania szczegółowe:

- Należy określić zakres projektu
- Należy opracować harmonogram projektu. W tym celu:

  a) wyspecyfikować zadania i ich zależności czasowe
  b) oszacować pracochłonność zadań
  c) określić listę niezbędnych zasobów i przydzielić je do zadań
  d) oszacować koszty zadań
  e) dokonać analizy harmonogramu i ewentualnej jego korekty
  f) sporządzić syntetyczną charakterystykę harmonogramu (pod względem czasu realizacji, kosztów, wykorzystania zasobów)

## Założenia

1. Sklep ogrodniczy jest mały, mieści się w jednym budynku i zatrudnia łącznie ok. 20 pracowników.
2. Baza danych towarów ma współpracować ze stroną internetową.
3. Aplikacja okienkowa pozwala na kompleksowe zarządzanie bazą danych z poziomu lokalnych komputerów sklepu.
4. Aplikacja webowa ma umożliwiać przeglądanie oferty sklepu, logowanie się klientów, składanie zamówień, śledzenie realizacji i komunikację ze sklepem.

# 1. Zakres projektu

Projekt zakłada informatyzację sklepu ogrodniczego. Informacje na temat bieżącego wyposażenia powinny się znaleźć w postaci cyfrowej, w bazie danych.

W bazie danych powinny się znajdywać informacje o:

- towarach w sklepie
- pracownikach
- klientach
- zamówieniach
- transakcjach
- fakturach

Do obsługi bazy danych przewiduje się aplikację desktopową. Aplikacja będzie umożliwiała:

- zarządzanie towarami w sklepie
- zarządzanie pracownikami
- zarządzanie klientami
- zarządzanie zamówieniami
- zarządzanie transakcjami
- zarządzanie fakturami
- przeprowadzanie inwentaryzacji

Zakłada się stworzenie sklepu internetowego, z poziomu którego klient będzie mógł:

- zarejestrować się jako stały klient
- zobaczyć listę towarów wraz z cenami i dostępnością w sklepie
- dodać produkt do koszyka
- zobaczyć listę produktów w koszyku
- złożyć zamówienie
- podejrzeć stopień realizacji zamówienia.

W związku z tak przedstawionymi założeniami, będą konieczne następujące elementy projektu:

1. Projekt bazy danych (grupa A)
3. Projekt aplikacji desktopowej (grupa B)
2. Projekt biblioteki programistycznej (grupa C)
4. Projekt zaplecza (backendu) sklepu internetowego (grupa D)
5. Projekt witryny (frontendu) sklepu internetowego (grupa E)

Proces wdrożenia będzie wymagał:

1. Konfiguracji wewnętrznej sieci sklepu
2. Konfiguracji serwera bazy danych
3. Konfiguracji serwera aplikacji webowej
4. Konfiguracji sewera pocztowego sklepu

W związku z tak przedstawionymi założeniami, istnieje przynajmniej 5 częściowo związanych ze sobą zadań według których można przydzielać członków grupy.

Zakłada się konieczność pracy 5 osób nad elementami projektu. Dodatkowo potrzebna będzie osoba do przeprowadzenia wdrożenia (może to być członek zespołu lub inna osoba z doświadczeniem konfiguracji serwera). Być może niezbędne będzie zaangażowanie na pierwszym etapie projektu specjalisty od CI/CD celem automatyzacji integracji części projektu.

## Założenia pracy zespołu

1. Każdy dzień pracy zaczyna się od 15-minutowego zebrania z członkami projektu przy tablicy, gdzie każdy z członków opowiada o stanie swojej pracy, napotkanych problemach i znalezionych rozwiązaniach.
2. Każdy kamień milowy kończy się i zaczyna konsultacją z klientem. Ze względu na możliwe opóźnienia w realizacji powinna być możliwość ustalenia w ostatnim możliwym terminie terminu konsultacji, jak również przełożenia.
3. Członkowie zespołu wybierają część projektu nad którą chcą pracować. Również należy przewidzieć, kto będzie zajmował się wdrażaniem projektu, oraz kto będzie zajmował się rozmową z klientem.
4. Podczas konsultacji z klientem powinni być obecni wszyscy członkowie zespołu.

## 2. Harmonogram projektu

Przewiduje się pięć kamieni milowych:

1. Planowanie - przygotowanie wstępnego planu działania każdego z komponentów projektu.
2. Wersja alfa - produkt minimalny prezentujący działanie interfejsu i ogólne założenia. Do wglądu i krytyki ze strony klienta, zakładane są duże zmiany na późniejszych etapach.
3. Wersja beta - produkt zbliżony funkcjonalnością i wyglądem interfejsu do wersji końcowej, gotowy do nanoszenia poprawek w fazie testowania.
4. Wersja finalna - produkt do wdrożenia na maszynach klienta.
5. Wdrożenie - proces wdrożenia produktu na maszynach klienta.

### 1. Planowanie (1 tydzień = 5 dni)

1. Rozmowa z klientem w celu zebrania informacji na tematy wymagań funkcjonalnych, niefunkcjonalnych oraz przypadków użycia (grupy ABCDE)
2. Ustalenie interfejsów pomiędzy podprojektami (grupy ABCDE)
3. Planowanie struktury bazy danych (grupa A)
4. Planowanie struktury aplikacji okienkowej (grupa B)
5. Planowanie struktury biblioteki programistycznej (grupa C)
6. Planowanie struktury zaplecza (grupa D)
7. Planowanie struktury witryny (grupa E)

#### 2. Wersja alfa (2 tygodnie = 10 dni)

1. Konsultacja z klientem i naniesiesienie zmian w planach struktury (grupy ABCDE)
2. Tworzenie bazy danych (grupa A)
3. Tworzenie aplikacji okienkowej (grupa B)
4. Tworzenie biblioteki komunikacji aplikacji z bazą danych (grupa C)
5. Tworzenie zaplecza (grupa D)
6. Tworzenie witryny (grupa E)

### 3. Wersja beta (3 tygodnie = 15 dni)

1. Konsultacja z klientem po przygotowaniu wersji alfa - zbieranie uwag i zmiany w planach projektu (grupy ABCDE)
2. Rozwijanie bazy danych (grupa A)
3. Rozwijanie aplikacji okienkowej (grupa B)
4. Rozwijanie biblioteki komunikacji aplikacji z bazą danych (grupa C)
5. Rozwijanie zaplecza (grupa D)
6. Rozwijanie witryny (grupa E)
7. Przygotowanie wersji beta dla klienta + testowanie (grupy ABCDE)

### 4. Wersja finalna (3 tygodnie = 15 dni)

1. Testy wersji beta, zebranie informacji o błędach w funkcjonalności + wytycznych od klienta.
2. Finalizacja bazy danych (grupa A)
3. Finalizacja aplikacji okienkowej (grupa B)
4. Finalizacja biblioteki komunikacji aplikacji z bazą danych (grupa C)
5. Finalizacja zaplecza (grupa D)
6. Finalizacja witryny (grupa E)

### 5. Wdrożenie (1 tydzień = 5 dni)

1. Konfiguracja witryny internetowej - konfiguracja serwera i domeny.
2. Konfiguracja serwera pocztowego.
3. Konfiguracja maszyny serwera bazy danych.
4. Konfiguracja lokalnych maszyn klienta.
5. Komunikacja z zespołami w przypadku problemów z działaniem.
6. Wdrożenie wersji finalnej na maszynach klienta i zatwierdzenie.

### a) Specyfikacja zadań i ich zależności czasowych. Prachochłonność zadań.

Każdy z kamieni milowych musi być wykonany by móc przejść do następnego etapu.

Przewiduje się następujące czasy wykonania poszczególnych kamieni milowych (1 tydzień = 5 dni roboczych):

1. Planowanie - 1 tydzień (5 dni)
2. Wersja alfa - 2 tygodnie (10 dni)
3. Wersja beta - 3 tygodnie (15 dni)
4. Wersja finalna - 3 tygodnie (15 dni)
5. Wdrożenie - 1 tydzień (5 dni)

W tak przygotowanej rozpisce czasowej dopuszcza się dodatkowy czas 10 dni (2 tygodni) na opóźnienia w projekcie. 

### c) Lista niezbędnych zasobów i przydzielenie ich do zadań

Potrzebne jest przynajmniej 5 osób które będą wykonywały projekt programistyczny. 

Do finalnego etapu potrzebna jest osoba z doświadczeniem konfiguracji maszyn produkcyjnych - serwera webowego, serwera bazodanowego, serwera pocztowego, konfiguracji domeny, zabezpieczenia serwera przed atakami z zewnątrz.

### d) Koszty zadań

Zakłada się zaangażowanie 5 osób projektu przez 60 dni roboczych. Przez ten czas członkowie projektu nie powinni mieć przydzielanych innych zadań.

Dodatkowo, wymagane jest podjęcie decyzji o maszynach produkcyjnych - czy serwerem będzie maszyna znajdująca się w sklepie, czy wydzierżawiona od dostawców usług internetowych, czy klient decyduje się na skalowalną usługę chmurową, czy na zakup serwera VPS, na jakie natężenie ruchu maszyna powinna być przygotowana etc. Dodatkowo, należy ustalić możliwe domeny dla witryny internetowej i ich koszta. Klient powinien mieć dostępne kilka rozwiązań do wyboru, z przedstawionymi wadami i zaletami każdego z nich.

Można przewidzieć zatrudnienie pentesterów do przeprowadzenia testów penetracyjnych po wdrożeniu w celu uszczelnienia systemu przed atakami hackerskimi. Można również przewidzieć zatrudnienie zewnętrznej firmy testującej do przetestowania aplikacji i znalezienia błędów w funkcjonalności.

### e) Analizy harmonogramu i jego korekta

Możliwe jest, że niektóre etapy harmonogramu zostaną zrealizowane znacznie szybciej od innych. W przypadku większościowej realizacji punktów harmonogramu (np. 4 z 5 grup wywiązały się z wyznaczonych zadań) należy przeanalizować możliwe przypadki działania - grupy które wywiązały się z zadań mogą zająć się kolejnymi zadaniami.

W przypadku istotnego opóźnienia pracy grup, należy podjąć decyzję o przydzieleniu dodatkowych osób do zadań. Codzienne konsultacje mają na celu zapobiegnięciu istotnym opóźnieniom w projekcie.

### f) sporządzić syntetyczną charakterystykę harmonogramu (pod względem czasu realizacji, kosztów, wykorzystania zasobów)

Realizacja zadań według zaplanowanego harmonogramu zajmie 10 tygodni, tj. 50 dni roboczych. Dodatkowe 10 dni przeznaczone są na opóźnienia w projekcie. Do projektu będzie zaangażowane co najmniej 5 osób. Może być wymagana dodatkowa osoba do wdrożenia rozwiązania na serwery produkcyjne. Dodatkowe koszta przewidują wykupienie domeny oraz wydzierżawienie serwera, jak również kupienie i konfiguracja maszyn lokalnych w sklepie. Dodatkowe koszta mogą być związane ze zleceniem testów wersji beta i wersji finalnej niezależnym firmom.