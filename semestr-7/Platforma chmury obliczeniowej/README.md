# Platforma chmury obliczeniowej

Wejściówki na każdych zajęciach!

Laboratoria - sprawozdania z zadań

marcin.pytlic@pracowniait.com

4 części chmury obliczeniowej

- Wstęp do chmury
- Azure Active Directory
- IAAS czyli VM
- PAAS czyli usługi Storage
- Bazy danych
- No Code / Low code
- SAAS Microsoft 365 Power Automate / Power Apps
- IAC

Skrypty PowerShell

Rodzaje oprogramowania:

- On premise
- Private cloud
- Public cloud
- Government cloud
- Hybrid cloud

Local Redundant Zone - maszyna wirtualna składowana jest na 3 osobnych maszynach fizycznych

Regiony (niekoniecznie geograficzne):

- EAST US
- NORTH EUROPE
- WEST EUROPE

Istotna jest lokalizacja Data Center - niektóre dane nie mogą przebywać poza granicami Unii Europejskiej

Możliwe rozwiązania chmurowe:

- App Service
- On premises / Private - zarządzamy wszystkim
- IAAS (infrastructure as a service) - Infrastruktura jako serwis, zarządzamy tylko VM
- PAAS (platform as a service) - Platforma jako serwis, zarządzamy tylko aplikacją
- SAAS (software as a service) - Oprogramowanie jako serwis, zarządzamy tylko danymi

Podczas konfigurowania serwisu wybieramy runtime.
Możemy też wybrać obraz dockerowy.

Azure Storage:

- BLOB (Big Large Object)
- File (max. 5 TB)
- Queue

PAAS - Architektura trójwarstwowa:

- serwery frontonu
  -serwery partycji
  -serwery storage

Frank Codd - twórca relacyjnych baz danych

12 postulatów Franka Codda:

1.  postulat informacyjny - dane są reprezentowane jedynie przez wartości atrybutów w wierszach tabel (w krotkach)
2.  postulat dostępu - każda wartość w bazie danych jest dostępna poprzez podanie nazwy tabeli, atrybutu i wartości klucza podstawowego (głównego)
3.  postulat dotyczący wartości NULL - dostępna jest specjalna wartość NULL dla reprezentacji zarówno wartości nieokreślonej, jak i nieadekwatnej, inna od wszystkich i podlegająca przetwarzaniu
4.  postulat dotyczący katalogu - wymaga się, aby system obsługiwał wbudowany katalog relacyjny z bieżącym dostępem dla uprawnionych użytkowników używających języka zapytań
5.  postulat języka danych - system musi dostarczać pełny język przetwarzania danych, który może być używany zarówno w trybie interaktywnym, jak i w obrębie programów, obsługuje operacje definiowania danych, operacje manipulowania danymi, ograniczenia związane z bezpieczeństwem i integralnością oraz operacje zarządzania transakcji
6.  postulat modyfikowalności perspektyw - system musi umożliwiać modyfikowanie perspektyw, o ile jest ono semantycznie realizowalne.

    Semantykę bazy danych określa się, opisując zbiór legalnych stanów, czyli ograniczając dozwoloną zawartość tabel. Operacje modeluje się jako funkcje: operacja: stan->stan. Operacje powinny przeprowadzać legalne stany w legalne stany. Jednak w czasie wykonywania powiązanego ciągu operacji przejściowo baza danych może przyjmować nielegalne stany. Takie ciągi obudowujemy transakcjami i traktujemy transakcje jako niepodzielne operacje.

7.  postulat modyfikowalności danych - system musi umożliwiać operacje modyfikacji danych, musi obsługiwać operacje INSERT, UPDATE oraz DELETE
8.  postulat fizycznej niezależności danych - zmiany fizycznej reprezentacji danych i organizacji dostępu nie wpływają na aplikacje
9.  postulat logicznej niezależności danych - zmiany wartości w tabelach nie wpływają na aplikacje
10. postulat niezależności więzów spójności - więzy spójności są definiowane w bazie i nie zależą od aplikacji
11. postulat niezależności dystrybucyjnej - działanie aplikacji nie zależy od modyfikacji i dystrybucji bazy
12. postulat bezpieczeństwa względem operacji niskiego poziomu - operacje niskiego poziomu nie mogą naruszać modelu relacyjnego i więzów spójności

Terminologia wykorzystywana w modelu relacyjnym baz danych - podsumowanie

Relacja w ujęciu formalnym to tabela posiadająca kolumny i wiersze, w ujęciu matematycznym, każdy podzbiór iloczynu kartezjańskiego zbiorów, w ujęciu intuicyjnym - powiązanie pomiędzy tabelami.

Atrybut (pole) - kolumna relacji opatrzona nazwą. Atrybuty mogą się pojawić w relacji w dowolnej kolejności bez wpływu na znaczenie relacji. Z każdym atrybutem związana jest para (nazwa atrybutu, typ danych).

Dziedzina - zbiór dopuszczalnych wartości dla jednego lub większej liczby atrybutów.

Krotka - wiersz relacji (rekord).

Stopień (krotność) relacji - liczba atrybutów relacji.

Moc relacji - ilość (liczba) krotek, które znajdują się w relacji.

Relacyjna baza danych - zbiór znormalizowanych relacji o różnych nazwach (relacyjny system zarządzania bazą danych określa jedynie, że taka baza jest dla użytkownika zbiorem relacji (tabel), czyli odnosi się do warstwy konceptualnej i zewnętrznej modelu ANSI).

Encja (ang. entity) jest rzeczą lub obiektem mającym dla nas znaczenie rzeczywiste bądź wyobrażone, o którym informacje muszą być znane lub przechowywane. Nazwa encji powinna być podana w liczbie pojedynczej i zapisana WIELKIMI LITERAMI. Encją może być:

    obiekt fizyczny (np. samochód, bilet lotniczy)
    obiekt niematerialny (np. konto bankowe, zamówienie)
    zdarzenie (np. urlop pracownika, sprzedaż samochodu)
    istniejący fakt (np. znajomość języków obcych)

3. Własności relacji

Relacyjna baza danych jest zbiorem relacji o następujących własnościach:

- każda relacja (tabela) w bazie danych jest jednoznacznie określona przez swoją nazwę.
- każda kolumna w relacji (atrybut) ma jednoznaczną nazwę w ramach tej relacji.
  kolumny relacji tworzą zbiór nieuporządkowany, mogą być wpisywane w dowolny sposób.
- wszystkie wartości w danej kolumnie muszą być tego samego typu (pochodzić z tej samej dziedziny).
- każdy wiersz (krotka) jest inny - nie ma duplikatów krotek.
- teoretycznie, kolejność wierszy nie ma znaczenia ( w praktyce może mieć to wpływ na efektywność wyszukiwania odpowiednich grup krotek).
- każde pole (przecięcie kolumny z wierszem) zawiera wartość elementarną (atomową) z dziedziny określonej przez kolumnę. Brakowi wartości odpowiada wartość specjalna NULL, zgodna z każdym typem kolumny (chyba że została jawnie wykluczona przez definicję typu kolumny).
- każda relacja zawiera klucz główny (podstawowy) - kolumnę (lub kolumny), której wartości jednoznacznie identyfikują wiersz (a więc w szczególności nie powtarzają się). Wartością klucza głównego nie może być NULL. Każda tabela musi mieć dokładnie jeden klucz główny.

4. Rodzaje kluczy

- superklucz (ang. superkey) - kolumna lub zestaw kolumn jednoznacznie identyfikujących każdą krotkę w tabeli
- klucz podstawowy (główny) (PRIMARY KEY) - klucz wybrany przez projektanta bazy danych, aby unikatowo identyfikować krotki tabeli
- klucz kandydujący (potencjalny), zwany w skrócie kluczem
- klucz obcy - klucz w podrzędnej tabeli powiązany z kluczem głównym w nadrzędnej tabeli celem zapewnienia integralności referencyjnej bazy danych
- klucz prosty - klucz oparty na jednej kolumnie
- klucz złożony - klucz oparty na wielu kolumnach
- klucz sztuczny - pole sztucznie wprowadzone do relacji, aby stał się kluczem podstawowym

5. Właściwości klucza głównego

- trwałość - pole kluczowe nie może być puste i nie może zawierać wartości NULL
- unikatowość - dane w polu kluczowym nie mogą się powtarzać (indeksowanie bez powtórzeń)
- stabilność - dane w polu kluczowym nie mogą się zmienić; nie powinno się jako klucz głównych używać kolumn przechowujących dane nietrwałe (np. numer telefonu - może się zmienić lub zostać przypisany innej osobie)
- nieredukowalność - żaden podzbiór właściwy pól tworzących pole klucza nie jest kluczem

Tabela może zawierać więcej niż 1 klucz, ale jeden klucz podstawowy. Atrybuty, które należą do któregoś z kluczy, nazywać będziemy atrybutami kluczowymi, a te, które nie należą do żadnego z kluczy - atrybutami niekluczowymi.

## Data Warehouse

Bill Inmen, Ralph Kimball

Trzymana jest tabela faktów oraz tabela wymiarów.

- Tabela faktów - przechowuje informacje biznesowe
- Tabela wymiarów - opisuje fakty

Data Mart - sposób na odchudzenie data warehouse

Azure Synapse również dostarcza usługę Data Warehouse

## Data Lake

Miejsce przechowywania danych, które nie są jeszcze gotowe do analizy.
