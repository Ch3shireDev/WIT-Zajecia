# Egzamin

## Zadanie 1

Omówić algorytmy elekcji w systemach rozproszonych. Do czego służą? Zasady działania.

### Rozwiązanie

W wielu algorytmach rozproszonych jest zapotrzebowanie, by jeden z procesów pełnił rolę koordynatora. Taką rolę wyłania się spośród procesów z zastosowaniem algorytmów elekcji, tj. algorytmów zapewniających zgodność wszystkich procesów co do funkcji koordynatora.

Zakładamy, że każdy z procesów ma przydzielony unikatowy numer pozwalający na porównanie go z innymi procesami w relacji niższy/wyższy.

Do algorytmów elekcji należą:

- Algorytm tyrana. Załóżmy że jeden z procesów zauważa, że koordynator przestaje odpowiadać na zamówienia. Proces ten zaczyna przeprowadzać elekcję według następującego schematu:
    1. Proces wysyła komunikat ELEKCJA do wszystkich procesów o wyższych numerach identyfikacyjnych.
    2. Jeśli nikt nie odpowie, proces staje się koordynatorem.
    3. Jeśli odpowie proces o wyższym numerze, to przejmuje kontrolę.

    Dodatkowo, proces w dowolnym momencie może dostać komunikat ELEKCJA od innego procesu o niższym numerze. W tym wypadku odbiorca wysyła komunikat OK by poinformować go o przejęciu sterowania.

- Algorytm pierścieniowy. Zakładamy że procesy są tak uporządkowane, że każdy z procesów zna swojego następcę. Ponownie, 

    1. Proces zaczyna się gdy zauważy brak koordynatora. Wysyłany jest wtedy komunikat ELEKCJA z numerem procesu do jego następcy. Jeśli następca jest wyłączony, nadawca go pomija i idzie dalej, aż do odnalezienia działającego procesu. 
    2. Proces otrzymujący komunikat ELEKCJA, dopisuje swój numer i przesyła do następnego, itd.
    3. Pierwotny nadawca po odebraniu komunikatu z własnym numerem, wysyła komunikat: KOORDYNATOR z pełną listą procesów występujących aktualnie w pierścieniu i wskazujący proces o najwyższym numerze, który zostaje koordynatorem.
    4. Koordynator rozpoczyna działanie.