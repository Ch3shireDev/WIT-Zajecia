# Zadania z wykładu 7 i 8
## A. Serwer jedno- i wielowątkowy

Proszę porównać operacje czytania pliku za pomocą jednowątkowego serwera plików i serwera wielowątkowego.

Otrzymanie zamówienia na pracę, skierowanie go do wykonania i reszta niezbędnego przetwarzania zajmuje 9 ms, pod warunkiem, że potrzebne dane znajdują się w podręcznej pamięci bloków.

Jeżeli istnieje konieczność wykonania operacji dyskowej, co stanowi jedną piątą zamówień, potrzeba dodatkowo 72 ms, podczas których wątek jest uśpiony.

- Ile zamówień na sekundę może obsłużyć serwer jednowątkowy i jakie będzie procentowe wykorzystanie czasu procesora?
- Ile zamówień na sekundę może obsłużyć serwer wielowątkowy i jakie będzie wówczas procentowe wykorzystanie czasu procesora?

Proszę podać sposób rozwiązania i dokładnie uzasadnić.

### Rozwiązanie

W przypadku serwera jednowątkowego średnio cztery zamówienia na pięć będą wykonywane w czasie 9 ms. Jedno zamówienie na pięć będzie wykonywane w czasie $72+9=81$ ms. Procesor będzie wykonywał 5 zamówień na $72+5*9 = 117$ ms, czyli $5/0.117 = 42.73$ zamówień na sekundę. Procentowe wykorzystanie czasu procesora to 5*9/117 = 38.5%.

W przypadku serwera wielowątkowego każda operacja procesora jest wykonywana współbieżnie, pod warunkiem że procesor nie musi czekać na wykonanie operacji dyskowej. Operacje dyskowe są jednowątkowe, tj. aby rozpocząć kolejną operacją dyskową, musi zostać zakończona poprzednia. Średnio co piąte zadanie będzie wymagało operacji dyskowych, co jest wąskim gardłem całego procesu. Oznacza to, że w czasie 72 ms (jednej operacji dyskowej) wykonuje się średnio 5 zadań, co daje nam częstotliwość 69.44 zadań na sekundę. W czasie tych 72 ms procesor będzie zajęty przez 5*9 = 45 ms, co daje nam wydajność procesora równą 62.5%.

## B. Zadanie dotyczące teorii masowej obsługi

Rozpatrzmy porównanie modelu stacji roboczych i modelu puli procesorów z uwzględnieniem teorii masowej obsługi. W modelu stacji roboczych jest 20 stacji, każda ma procesor przetwarzający średnio 50 zamówień na sekundę. Do każdego przychodzą losowo zamówienia, średnio 30/sek.

1. Wyznaczyć średni czas odpowiedzi zgodnie z teorią masowej obsługi w przypadku tego modelu.
2. Wyznaczyć średni czas odpowiedzi zgodnie z teorią masowej obsługi w przypadku modelu puli procesorów, w którym pula procesorów zawiera zsumowane 20 procesorów stacji roboczych, a przychodzą do niej losowo w sumie te same zamówienia, co w przypadku modelu stacji roboczych.

### Rozwiązanie

Zgodnie z teorią masowej obsługi, średni czas odpowiedzi wynosi:

$$T = \frac1{\mu-\lambda},$$

gdzie $\mu$ to średnia liczba zamówień które mogą być przetworzone w ciągu sekundy, natomiast $\lambda$ to średnia liczba zgłaszanych zamówień w ciągu sekundy.

1. Średni czas odpowiedzi wynosi: $T=\frac1{50 \text{Hz}-30 \text{Hz}}=0.05$ s.
2. Dla zsumowanej puli $n$ procesorów modyfikujemy powyższy wzór w następujący sposób:

$$T = \frac1{n\cdot\mu-n\cdot\lambda} = \frac{1}{20}\cdot0.05 s = 0.0025s$$