# Pytania podstawowe do egzaminu z przedmiotu SSR

## I. Budowa i funkcjonowanie systemów rozproszonych)

### 1. Wyjaśnić pojęcie przezroczystości w systemach rozproszonych.

Ważnym celem systemu rozproszonego jest ukrywanie faktu, że jego procesy i zasoby są fizycznie rozproszone na wielu komputerach. O systemie rozproszonym, który potrafi prezentować się swoim użytkownikom i aplikacjom tak, jakby był tylko jednym systemem komputerowym, mówimy, że jest **przezroczysty** (ang. _transparent_).

Rodzaje przezroczystości:

- **przezroczystość replikacji** - nawet jeśli nie ma dostępu do jednej z maszyn, użytkownik nie powinien obserwować braku dostępu do danych.
- **przezroczystość dostępu** - ukrywanie różnic w reprezentacji danych i metodach, którymi zasoby udostępnia się użytkowniom.
- **przezroczystość położenia** - użytkownicy nie są w stanie określić, w którym miejscu systemu zasób jest ulokowany fizycznie.
- **przezroczystość zwielokrotniania** - ukrywanie faktu, że istnieje kilka kopii zasobu
- **przezroczystość wędrówki** - maskowanie zmiany fizycznej lokalizacji zasobów
- **przezroczystość przemieszczenia** - maskowanie zmiany fizycznej lokalizacji zasobów w trakcie ich używania
- **przezroczystość pod względem awarii** - użytkownik nie zauważa awarii zasobu, podczas gdy system dokonuje usunięcia skutków uszkodzenia
- **przezroczystość trwałości** - maskowanie faktu, czy zasób jest w pamięci ulotnej, czy może gdzieś na dysku.

### 2. Czym różni się wieloprocesor od multikomputera?

Komputery mające pamięć dzieloną (wspólną) nazywamy **wieloprocesorami**, natomiast komputery które mają osobne pamięci, nazywamy **multikomputerami**.

Komputer wieloprocesorowy ma wiele procesorów i jedną współdzieloną między wszystkimi procesorami pamięć. Multikomputer ma wiele procesorów, z których każdy z nich korzysta z własnej pamięci.

W wieloprocesorze istnieje jedna fizyczna przestrzeń adresowa, użytkowana wspólnie przez wszystkie jednostki centralne.

W multiomputerze każda z maszyn ma własną, prywatną pamięć - np. zbiór komputerów osobistych połączonych za pomocą sieci.

### 3. Czy różni się synchronizacja czasu fizycznego od synchronizacji czasu logicznego?

W przypadku synchronizacji czasu fizycznego, komputery synchronizują czas tak, by był zgodny z czasem rzeczywistym - z zewnętrznym zegarem. W przypadku synchronizacji czasu logicznego, komputery synchronizują czas między sobą, bez względu na zewnętrzny zegar.

Synchronizacja czasu fizycznego polega na komunikacji z zewnętrznym serwisem czasu. Jeśli jeden z komputerów ma dostęp do serwisu, to pozostałe komputery starają się synchronizować czasy z tym komputerem. Jeśli wszystkie komputery mają dostęp do serwisu, to każdy z nich synchronizuje się z nim z osobna.

W przypadku synchronizacji czasu logicznego maszyny synchronizują się jedynie między sobą.

W obydwu przypadkach synchronizacji istotne jest przestrzeganie zasad przyczynowości, tj. relacji między przyczyną a skutkiem - skutek zawsze będzie miał czas późniejszy niż przyczyna. W związku z tym synchronizowany komputer **nie może cofać swojego czasu** - może go jedynie zachować albo zmienić na czas późniejszy.

### 4. Co to jest uniwersalny czas koordynowany i do czego jest stosowany?

Uniwersalny czas koordynowany - (UTC) Universal Coordinated Time. Czas atomowy skoordynowany z czasem astronomicznym przez dodawanie sekund przestępnych. Wzorzec dla wszystkich współczesnych cywilnych pomiarów czasu.

### 5. Wyjaśnić ideę algorytmu Cristiana synchronizacji czasu fizycznego.

Załóżmy, że jedna z maszyn ma dostęp do zewnętrznego serwisu czasu (np. posiada odbiornik WWV). Nazwiemy wtedy tę maszynę serwerem czasu. Każda z pozostałych maszyn okresowo, nie częściej niż co $\delta/2\rho$ s (gdzie $\delta$ to maksymalna dopuszczalna różnica czasu między maszynami, natomiast $\rho$ to współczynnik maksymalnego tempa odchylenia), wysyła do serwera czasu żądanie o bieżący czas. Serwer czasu odpowiada możliwie jak najszybciej za pomocą komunikatu zawierającego aktualny czas.

Po otrzymaniu odpowiedzi, nadawca może ustawić swój zegar. Jednak jeśli jego zegar się spieszy, nie może go cofnąć, ze względu na warunek przyczynowości - zdarzenie wysłania wiadomości musi zajść przed zdarzeniem odbioru. W związku z tym mierzone jest tempo spieszenia się, poprzez porównanie czasu odbioru z czasem wysłania. Na podstawie tego tempa, ustanawiane jest stopniowe korygowanie czasu maszyny, poprzez zmniejszenie lub zwiększenie tempa naliczania czasu.

### 6. Wyjaśnić ideę algorytmu Lamporta synchronizacji czasu logicznego.

Po pierwsze, stosujemy relację uprzedniości zdarzeń, tj. zasadę, że jeśli $a$ poprzedza $b$ (zapisywane jako $a\to b$), to czas $a$ musi być mniejszy niż czas $b$, również po korekcie czasu w maszynie. Jeśli mamy $a\to b$ oraz $b\to c$, to również możemy powiedzieć, że $a\to c$ - relacja jest **przechodnia**. Natomiast, jeśli zdarzenia $x$ i $y$ występują na różnych, niesynchronizowanych ze sobą maszynach, to nie możemy powiedzieć, by $x\to y$ lub $y\to x$. O takich zdarzeniach mówimy że są **współbieżne**.

![](./images/15.png)

Algorytm znaczników czasu Lamporta działa następująco. Maszyny wysyłają do siebie komunikaty z informacją o aktualnym czasie nadawcy. Jeśli odbiorca ma czas późniejszy niż odebrany, nic nie robi. Jeśli ma czas wcześniejszy lub równy, ustawia swój zegar na najmniejszy możliwy czas od odebranego komunikatu. Maszyny wysyłają sobie informacje co ustalony okres czasu, prowadząc do synchronizacji.

### 7. Na czym polega problem wzajemnego wyłączania i jak jest rozwiązywany w systemach rozproszonych?

W przypadku, gdy mamy wiele procesów (bądź maszyn) żądających dostępu do jednego zasobu, mamy problem sekcji krytycznej. Problem kolejności dostępu do zasobu jest rozwiązywany poprzez algorytmy wzajmnego wyłączania (wykluczania).

W systemach rozproszonych jest dodatkowy problem, bowiem nie można zastosować algorytmów wykorzystujących pamięć dzieloną - tak jak semafory i monitory.

### 8. Podać przykłady algorytmów rozwiązujących problem wzajemnego wyłączania w systemach rozproszonych?

Stosowane są m.in. następujące algorytmy:

1. **Algorytm scentralizowany**:

- Jeden proces jest koordynatorem.
- Proces, który chce wejść do sekcji krytycznej wysyła zamówienie do koordynatora.Koordynator odpowiada (udziela zezwolenia), gdy żaden inny proces nie jest w sekcji krytycznej.
- Proces, po odebraniu zezwolenia, wchodzi do sekcji krytycznej.
- Proces wychodząc z sekcji krytycznej wysyła komunikat do koordynatora.
  ![](./images/16.png)
- Cechy algorytmu scentralizowanego:
  - zapewnia wzajemne wyłączanie,
  - nie zachodzi głodzenie procesów,
  - łatwy w realizacji,
  - wrażliwy na awarie.

2. **Algorytm rozproszony**:

- Wymagane jest całkowite uporządkowanie czasowe zdarzeń - komunikatów (np. stosując algorytm Lamporta).
- Proces, który chce wejść do sekcji krytycznej wysyła do wszystkich procesów komunikat zawierający nazwę sekcji krytycznej, swój numer, bieżący czas.
- Każdy komunikat jest potwierdzany (zapewnienie niezawodności).
- Proces odbierający komunikat:
  1. Jeśli nie jest w sekcji krytycznej i nie chce do niej wejść – wysyła do nadawcy komunikat OK.
  2. Jeśli jest w sekcji krytycznej - nie odpowiada.
  3. Jeśli chce wejść do sekcji krytycznej - sprawdza znacznik czasu odebranego komunikatu i komunikatu, który sam wysłał. Jeśli odebrany komunikat ma znacznik czasu mniejszy - wysyła OK.
- Proces nadawca:
  - Czeka aż wszystkie procesy udzielą zezwolenia, wtedy wchodzi do sekcji krytycznej.
  - Wychodząc z sekcji krytycznej wysyła OK. do procesów, które ustawił w kolejce.
    ![](./images/17.png)
- Cechy algorytmu:
  - Zapewnienie wzajemnego wyłączania bez głodzenia.
  - Wrażliwy na awarie - brak odpowiedzi spowodowany awarią procesu jest traktowany jako brak zgody - blokowanie procesów próbujących wejść do sekcji krytycznej (jest możliwość rozwiązania).
  - Wymagana komunikacja grupowa lub każdy proces musi utrzymywać listę procesów znajdujących się w grupie, wchodzących i wychodzących - obciążenie systemu.

3. **Algorytm pierścienia logicznego z żetonem**

- Rozpatrzmy system rozproszony, w którym zbiór procesów jest połączonych szyną Wprowadza się logiczne (programowe) uporządkowanie procesów tworząc pierścień. W pierścieniu krąży żeton.
- Proces po otrzymaniu żetonu sprawdza, czy chce wejść do sekcji krytycznej,
  - nie - przekazuje żeton sąsiadowi,
  - tak - zatrzymuje żeton aż wyjdzie z sekcji krytycznej.
- Cechy algorytmu:
  - Zapewnia wzajemne wyłączanie.
  - Nie powoduje głodzenia procesów.
  - Powstają problemy związane z zaginięciem żetonu.
  - Wrażliwy na awarie procesów.

4. Algorytmy elekcji:

- Cel: wybór procesu, który będzie pełnił rolę koordynatora lub inicjatora w systemie rozproszonym.
- Założenia:

  - każdy proces ma niepowtarzalny numer,
  - każdy proces zna numery wszystkich pozostałych,
  - procesy nie wiedzą, które z nich aktualnie działają, a które są unieruchomione, próbuje się zlokalizować proces o największym numerze.

  1. **Algorytm tyrana**:

  - Działanie:
    1. Proces A zauważył, że koordynator nie odpowiada. A wysyła komunikat ELEKCJA do wszystkich procesów z większymi numerami.
    2. Brak odpowiedzi, to A zostaje koordynatorem.
    3. Nadchodzi komunikat od procesu B o większym numerze. Proces A przestaje działać w elekcji. B przejmuje sterowanie i kontynuuje elekcję (zgodnie z punktami 1, 2, 3 ).
    4. Proces, który wygrywa elekcję wysyła do pozostałych komunikat: KOORDYNATOR.

  ![](./images/18.png)

  2. **Algorytm pierścieniowy**

  - Założenie: procesy są fizycznie i logicznie uporządkowane. (Każdy proces przechowuje strukturę pierścienia).
  - Działanie:
    1. Proces A zauważył, że koordynator nie działa. Wysyła komunikat ELEKCJA do
       kolejnego nie wyłączonego procesu w pierścieniu. Komunikat zawiera jego numer.
    2. Proces B otrzymujący komunikat ELEKCJA, dopisuje swój numer i przesyła do
       następnego, itd.
    3. Proces A po odebraniu komunikatu z własnym numerem, wysyła komunikat:
       KOORDYNATOR z pełną listą procesów występujących aktualnie w pierścieniu i
       wskazujący proces o najwyższym nu-
       merze, który zostaje koordynatorem.
    4. Koordynator rozpoczyna działanie.

  ![](./images/19.png)

### 9. Omówić algorytm rotacyjnego (pierścienia logicznego z żetonem) rozwiązujący problem wzajemnego wyłączania w systemach rozproszonych.

Patrz wyżej.

### 10. Czemu służą algorytmy elekcji? Podać przykład?

Patrzy wyzej.

### 11. Na czym polega synchronizacja czasu fizycznego?

Patrz punkt 5.

### 12. Na czym polega przetwarzanie transakcyjne?

### 13. Podać i wyjaśnić właściwości transakcji.

### 14. Podać przykłady metod realizacji przetwarzania transakcyjnego?

### 15. Jak wykonywane jest przetwarzanie transakcyjne z wykorzystaniem metody prywatnej przestrzeni roboczej?

### 16. Jak wykonywane jest przetwarzanie transakcyjne z wykorzystaniem rejestru zapisów wyprzedzających?

### 17. Na czym polega problem nadzorowania współbieżności wykonywania transakcji w systemach rozproszonych?

### 18. Podać przykłady algorytmów nadzorowania współbieżności transakcji w systemach rozproszonych?

### 19. Jak można wykrywać blokady (zakleszczenia) w systemach rozproszonych?

### 20. Czy różni się praca wielowątkowa od jednowątkowej?

### 21. Czy serwer wielowątkowy może działać efektywniej od jednowątkowego w przypadku jednego procesora? Odpowiedź uzasadnić.

### 22. Wyjaśnić zagadnienie planowania w systemie rozproszonym MACH.

### 23. Wykorzystanie bezczynnych stacji roboczych w systemie rozproszonym.

### 24. Omówić model puli procesorów jako systemu rozproszonego z uwzględnieniem teorii masowej obsługi.

### 25. Co to jest redundancja i jakie typy redundancji stosuje się w systemach rozproszonych?

### 26. Na czym polega tolerowanie awarii w systemach rozproszonych i jak jest realizowane?

### 27. Czym różni się stosowanie aktywnego zwielokrotnienia od zastosowania zasobów rezerwowych do tolerowania uszkodzeń?

### 28. Na czym polega zastosowanie aktywnego zwielokrotnienia do tolerowania uszkodzeń?

### 29. Czym różnią się wady wyciszenia od wad bizantyjskich?

### 30. Czym różni się system rozproszony budowany według modelu stacji roboczych od modelu puli procesorów?

### 31. Jak mogą być wykorzystane dyski lokalne w modelu stacji rooczych? Podać wady i zalety różnych rozwiązań.

### 32. Jak mogą być organizowane wątki w procesie? Podać przykłady.

### 33. Rozpatrzyć zespół wątków realizujących pewne zadanie. Co mają wspólne w ramach zadania, a co każdy ma niezależne?

## II. Sieci

### 1. Jakie warstwy występują w modelu OSI (7 warstw), a jakie w modelu TCP/IP (4 warstwy)?

- **OSI**:

  - **warstwa fizyczna** - umożliwia przesyłanie pojedynczych bitów (są one jednostką usług i jednostką protokołu) między stacjami połączonymi łączem. Dostępne usługi tej warstwy to przesłanie ciągu bitów z zachowaniem ich sekwencji, wykrywanie nieprawidłowości transmisji przez odbiorcę (odrzucenie bitu) i wykrywanie stanów specjalnych łącza. Decydującym czynnikiem określającym parametry transmisji danych jest jakość łącza. Wpływa ona na opóźnienia transmisyjne, szybkość transmisji oraz na liczbę błędów. Warstwa ta szczegółowo określa fizyczne cechy interfejsu sieciowego stacji takie jak: elementy mechaniczne i elektryczne, złącza, poziomy napięć i inne aspekty elektryczne. Znanymi interfejsami łącza fizycznego są np.: RS-232, RS-449. Warstwa ta określa też cechy funkcjonalne takie jak: założenie, utrzymywanie i zdemontowanie łącza fizycznego;

  - **warstwa łącza danych** - definiuje reguły przesyłania i otrzymywania informacji, zapewnia prawidłową transmisję między stacjami lub węzłami sieci. Umożliwia wykrywanie i korygowanie błędów powstałych w warstwie fizycznej. Jeśli wiele stacji jest połączonych jednym nośnikiem to warstwa ta realizuje funkcję wykrywania stanu łącza oraz bezkolizyjnego dostępu do tego łącza (w wypadku gdyby wiele stacji chciało nadawać jednocześnie). Warstwa ta jest najniższą warstwą, która realizuje transmisję ramek (sekwencje bitów) o określonej strukturze oraz jawnie określonym początku i końcu. Protokoły tej warstwy dobiera się w zależności od jakości łączy. W wypadku gdy łącza są bardzo dobrej jakości pomija się wykrywanie błędów (można to przenieść do wyższych warstw) co daje znaczne przyspieszenie transmisji. W warstwie tej pracują mosty (bridges). Typowe protokoły tej warstwy to HDLC, sterowniki i metody dostępu w sieciach lokalnych (np.: Ethernet, Token Ring), NDIS (Microsoft), ODI (Novell) oraz sieci rozległe z szybką komutacją pakietów (Frame Relay, ATM);

  - **warstwa sieci** - umożliwia utworzenie (przy pomocy węzłów sieci) drogi transmisji między stacjami końcowymi oraz, co się z tym wiąże, wybór drogi lub dróg transmisji (routing). Funkcje tej warstwy umożliwiają unikanie przeciążeń w sieci. Znaczenie jej jest tym większe im więcej jest możliwych dróg przekazywania informacji oraz im bardziej są zróżnicowane charakterystyki poszczególnych fragmentów sieci. W warstwie tej pracują routery. Funkcje tej warstwy odczytują adres docelowy pakietu i kierują go bezpośrednio do stacji w sieci (jeśli adres dotyczy sieci lokalnej) lub przez router do innego segmentu sieci. Typowe protokoły tej warstwy to: IP, X.25, IPX (Novell);

  - **warstwa transportowa** - zapewnia transmisje z wymaganymi charakterystykami, takimi jak: przepustowość, stopa błędów, opóźnienia transmisyjne. Warstwa ta optymalizuje użycie usług sieciowych tak, aby wymagane warunki techniczne spełnić w sposób jak najbardziej ekonomiczny. Warstwa ta „przesłania" usługi oferowane przez niższe warstwy aby ukryć przed wyższymi warstwami szczegóły związane ze znajdującą się niżej siecią. Warstwa ta gwarantuje ponadto dostarczenie danych do odbiorcy oraz realizuje kontrolę błędów i inne operacje związane z niezawodnością transmisji jeśli nie są one realizowane w niższych warstwach (np.: Frame Relay, ATM). Warstwa ta oferuje usługi połączeniowe (ustalane jest łącze przez które pakiety wędrują do miejsca przeznaczenia i docierają tam w kolejności sekwencyjnej) lub bezpołączeniowe. W razie gdy pakiet nie dotrze do odbiorcy lub dojdzie uszkodzony to protokół warstwy transportowej zażąda retransmisji tego pakietu. Typowe protokoły tej warstwy to: TCP, UDP, SPX (Novell), NetBIOS / NetBEUI (Microsoft);

  - **warstwa sesji** - rozszerza funkcje warstwy transportowej o środki umożliwiające synchronizację dialogu i zarządzanie wymianą danych między jej usługobiorcami (aplikacjami). Ustala, który z partnerów ma prawo do nadawania oraz to, czy komunikacja jest naprzemienna, czy równoczesna w obu kierunkach. Warstwa ta umożliwia tworzenie punktów synchronizacji służących do powrotu przez obu uczestników dialogu do takiego punktu w razie wystąpienia nieprawidłowości (np. utrata wysłanych danych w wyniku awarii łącza);

  - **warstwa prezentacji** - w różnych systemach używane są różne postaci informacji, np. kod znaku, typ danych, itd. Warstwa ta zapewnia przekształcenie tych postaci w jednorodną formę sieciową. Przekształcenie to dotyczy składni (syntaktyki) a nie sensu (semantyki) informacji. W warstwie tej następuje również kompresja i szyfrowanie transmitowanych danych. Nadchodzące dane są zamieniane na postać, którą można przedstawić użytkownikowi (na ekranie lub wydruku);

  - **warstwa aplikacji** - oferuje całość usług komunikacyjnych procesom użytkowników. Dostępne są funkcje takie jak: ustalenie protokołu transmisji, zawieszanie i wznawianie połączenia, dotyczące synchronizacji działań i stwierdzanie autentyczności partnerów. Typowymi usługami tej warstwy są również: transfer plików i działanie zdalne na plikach, dostęp i działanie na zdalnych bazach danych, praca procesu użytkowego jako terminala zdalnego komputera, poczta elektroniczna i inne;

- **TCP/IP**:

  - **Warstwa aplikacji** – zawiera aplikacje do usuwania błędów w sieci, transmisji plików, zdalnego sterowania przepływem i działań internetowych.

  - **Warstwa transportowa** – odpowiada za sterowanie przepływem informacji, sprawdzanie danych oraz potwierdzanie otrzymania danych w sieci. Służy jako interfejs dla aplikacji sieciowych.

  - **Warstwa internetowa** – umożliwia logiczne adresowanie niezależne od sprzętu, co pozwala danym przenosić się między sieciami o różnej strukturze fizycznej. Zapewnia routing redukujący ruch oraz zapewniający dostarczanie przesyłek międzysieciowych. Łączy adresy fizyczne (używane w warstwie interfejsu sieciowego) z adresami logicznymi.

  - **Warstwa interfejsu sieciowego** – zapewnia interfejs z siecią fizyczną. Formatuje dane do transmisji przez nośnik oraz adresuje dane do podsieci, opierając się na adresach fizycznych. Zapewnia sprawdzanie błędów przesyłu w sieci fizycznej.

### 2. Jakie warstwy modelu OSI odpowiadają warstwie interfejsu sieciowego w modelu TCP/IP? (warstwy fizyczna i łącza danych)

### 3. Jaką długość w bitach mają adresy MAC, IPv4 i IPv6?

### 4. Jaka jest zasadnicza różnica między UDP i TCP?

### 5. Jakie są podstawowe zasady mechanizmu CSMA/CD?

### 6. Jakie ograniczenia ma długość pola danych w nagłówku Ethernet II?

### 7. Jak jest realizowana multipleksacja protokołów w nagłówkach Ethernet II i IP?

### 8. Czym jest numer portu w protokołach warstwy transportowej?

### 9. W jaki sposób TCP zapewnia niezawodny transport?

### 10. W jaki sposób zachodzi proces nawiązywania połączenia za pomocą TCP?

### 11. Czym jest nr inicjujący w protokole TCP?

### 12. W jaki sposób zachodzi proces zakończenia połączenia za pomocą TCP?

### 13. W jaki sposób przebiega transmisja danych za pomocą TCP?

### 14. Jaka jest rola flagi PUSH w protokole TCP?

### 15. Z których pól obliczana jest suma kontrolna w nagłówku Ethernet II?

### 16. Z których pól obliczana jest suma kontrolna w nagłówkach IP i TCP?

### 17. Co to jest CRC i w którym protokole jest stosowany?

### 18. Jaka jest rola pól „identyfikacja" i „offset" w nagłówku IP

### 19. Jaka jest rola poszczególnych flag w nagłówku IP

### 20. Do której warstwy modelu OSI należy protokół ICMP?

### 21. Czy 123.10.25.127 może być adresem unicast w sieci z maską 255.255.255.224?

### 22. Jaka jest domyślna maska dla adresu IP 135.240.24.67?

### 23. Co to jest rekord zasobów?

### 24. Jaka jest zasadnicza różnica między strukturą stref DNS i strukturą nazw DNS?

### 25. Do czego służy polecenie host systemu Linux?

### 26. Z którego rekordu zasobów korzysta klient SMTP przy wysyłaniu poczty?

### 27. Jaką metrykę stosuje protokół RIP?

### 28. Jakie trzy znaczenia ma adres 0.0.0.0 w tabeli routingu?

### 29. Co to jest domena wyszukiwania odwrotnego?

### 30. Co to są „root-servers" w usłudze DNS?

### 31. Jakiego protokołu transportowego używa DNS?

### 32. W jaki sposób włącza/wyłącza się usługę w odpowiednim pliku w katalogu /etc/xinetd.d?

### 33. Maska IP, czym jest i do czego jest używana?

### 34. Co to jest adres IP broadcastu?

### 35. Protokół IP do czego służy i w jakiej warstwie funkcjonuje?

### 36. Metoda CSMA/CD na czym polega?

### 37. Protokół ARP, do czego jest używany i jak funkcjonuje?

### 38. Dostarczanie bezpośrednie i pośrednie datagramów IP

### 39. Czy ramka jest zawarta (kapsułkowana) w datagramie?

### 40. Protokół ICMP do czego jest używany?

### 41. Z czego się składa tabela routingu IP?

### 42. Do czego jest używana brama (gatawey)?

### 43. Co to jest trasa domyślna w tabeli routingu?

### 44. Na podstawie czego jest wyznaczana trasa datagramu IP?

### 45. Pole identyfikacja w nagłówku datagramu IP

### 46. Pole offset w nagłówku datagramu IP. Podaj przykład.

### 47. Z czego obliczana jest suma kontrolna w nagłówku IP i nagłówku TCP?

### 48. Komunikat ICMP „prośba o echo"

### 49. Komunikat ICMP „czas przekroczony"

### 50. Czy składanie fragmentów datagramów IP może zachodzić w węzłach pośrednich?

### 51. Jak następuje nawiązywanie połączenia za pomocą protokołu TCP?

### 52. Jak się realizuje niezawodność przesyłania danych przy pomocy protokołu TCP?

### 53. Co to jest port w protokole TCP?

### 54. Do czego służy pole numer porządkowy w nagłówka TCP?

### 55. Flagi w nagłówku segmentu TCP

### 56. Czy na bazie protokołu UDP funkcjonuje usługa połączeniowa przekazywania danych. W której warstwie działa UDP?

### 57. Co to jest strefa DNS?

### 58. Różnica w organizacji struktury nazw domenowych DNS i serwerów DNS?

### 59. Jak zbudowany jest rekord SOA?

### 60. Do czego służy rekord PTR?

### 61. Różnica między serwerem DNS podstawowym i pomocniczym?

## III. Zadania

### Zadanie 1

Proszę rozważyć trzy procesy, każdy działający na innej maszynie. Każda maszyna ma lokalny czasomierz. W przypadku bez korekty czasu maszyn, proces P1 wysyła komunikat A w chwili 40. Komunikat ten odbierany jest przez proces P2, wg jego lokalnego czasu w chwili 28. Następnie proces P2 w hwili 30 wysyła komunikat B do procesu P3. Proces P3 odbiera ten komunikat, wg jego lokalnego czasu, w chwili 42. Proces P3 w chwili 47 wysyła komunikat C do procesów P1 i P2. Komunikat ten jest odbierany przez proces P1 w chwili 47 wg jego czasu lokalnego, oraz w chwili 37 przez proces P2 wg jego czasu. Czasy których maszyn należy skorygować, kiedy i jak oraz jakie będą czasy nadania i odbioru komunikatów po dokonaniu synchronizacji logicznej czasu wymienionych maszyn, zgodnie z algorytmem Lamporta?

### Zadanie 2

Aplikacja używająca protokołu UDP, uruchomiona w sieci o MTU1=1494B, wysyła 3012 B danych użytkownika. Powstałe fragmenty następnie przesyłane są do drugiej sieci o MTU2=726B. Ile powstanie fragmentów oraz jakie jest ich przesunięcie i wielkoość. Podaj w notacji `W@Przes_Flaga`. Opisz ramkę, w której przesyłany jest trzeci fragment po drugiej fragmentacji.

### Zadanie 3

Jak jet zbudowana tabela rutingu IP?

### Zadanie 4

Proszę rozpatrzyć możliwe plany współbieżnej realizacji następujących trzech transakcji:

```
a)  POCZĄTEK_TRANSAKCJI
    X = 3; Y = 0; X = X - Y; Y = Y - 2;
    KONIEC_TRANSAKCJI
b)  POCZĄTEK_TRANSAKCJI
    X = 2; Y = -3; X = X + 3; Y = X - Y + 1;
    KONIEC_TRANSAKCJI
c)  POCZĄTEK_TRANSAKCJI
    X = 0; X = X + 6; Y = 4; Y = Y + X;
    KONIEC_TRANSAKCJI
```

Proszę określić pełną listę dopuszczalnych wartości (rozdzielając je słowami "lub", ewentualnie "i"), które moggą przyjmować na końcu zmienne `x` i `y`. Proszę podać przykład niedopuszczalnego planu realizacji transakcji. Odpowiedź należy uzasadnić.

### Zadanie 5

Proszę porównać operacje czytania pliku za pomocą jednowątkowego serwera plików i serwa wielowątkowego. Otrzymane zamówienia na pracę, skierowanie go do wykonania i reszta niezbędnego przetwarzania zajmuje 8 ms, pod warunkiem, że potrzebne dane znajdują się w podręcznej pamięci bloków. Jeżeli istnieje konieczność wykonania operacji dyskowej, co stanowi jedną szóstą zamówień, potrzeba dodatkowo 60 ms, podczas których wątek jest uśpiony. Ile zamówień na sekundę może obsłużyć serwer jednowątkowy i jakie będzzie procentowe wykorzystanie czasu procesora? Ile zamówień na sekundę może obsłużyć serwer wielowątkowy i jakie będzie wówczas procentowe wykorzystanie czasu procesora? Proszę podać sposób rozwiązania i dokładnie uzasadnić.

### Zadanie 6

Z jakiej minimalnej sieci pochodzą komputery o adresach IP: `192.168.4.209` i `192.168.4.214`? Dokonaj obliczeń. Podaj adres IP tej sieci i maskę.

### Zadanie 7

Aplikacja używająca protokołu ICMP, uruchomiona w sieci o MTU1=1500B, wysyła 3022 B danych użytkownika. Powstałe fragmenty następnie przesyłane są do drugiej sieci o MTU2=730 B. Ile powstanie fragmentów oraz jakie jest ich przesunięcie i wielkość. Podaj w notacji `W@Przes_Flaga`. Opisz ramkę, w której przesyłany jest trzeci fragment po drugiej fragmentacji.

### Zadanie 8

Kiedy i w jakie sposób zachodzi przesyłanie bezpośrednie datagramu IP?

### Zadanie 9

Czy adres sprzętowy docelowy w ramce eternetowej ulega zmianie przy przesyłaniu pakietu danych przez kolejne routery? Odpowiedź uzasadnij.

### Zadanie 10

Co się dzieje z polem identyfikacja w nagłówku datagramu IP przy fragmentacji datagramu? Odpowiedź uzasadnij.
