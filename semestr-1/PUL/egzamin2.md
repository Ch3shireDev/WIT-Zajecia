# Przykładowy test egzaminacyjny.

## Zadanie 1a

Zapisać w kodzie U2 liczby –11, –16:

Najwyższa potęga dwójki (dla n bitów bedzie to $2^{n-1}$) w kodzie U2 będzie zapisywana ze znakiem ujemnym.

Tzn:

- $$-11 = -16 + 4 + 1 \rightarrow 10101$$
- $$-16 \rightarrow 10000$$

Dla porównania, kod U1 różni się tym, że waga najwyższego bitu ma wartość $-2^{n-1}+1$.

## Zadanie 1b

Jaką liczbę dziesiętną całkowitą reprezentuje liczba binarna: 10110 jeżeli jest ona dana
    - w kodzie naturalnym binarnym
    - w kodzie U2

## Zadanie 1c

Liczba 4C dana jest heksadecymalnie, zapisać tę liczbę w naturalnym kodzie binarnym.

## Zadanie 2

Napisać tablicę przejść–wyjść licznika mod 4 o mikrooperacjach: zliczanie w górę, w dół oraz HOLD. Sygnały sterujące są: a, b.

| s\x | a  | b  | hold | y |
|-----|----|----|------|---|
| s0  | s1 | s3 |  s0  | 0 |
| s1  | s2 | s0 |  s1  | 0 |
| s2  | s3 | s1 |  s2  | 0 |
| s3  | s0 | s2 |  s3  | 1 |
## Zadanie 3

Narysować schemat blokowy licznika uniwersalnego umożliwiającego wpisywanie z dwóch szyn A, B i wykonującego mikrooperacje: LOADA, LOADB, HOLD, COUNT. 

Do dyspozycji MUX, licznik z μ-operacjami HOLD, LOAD, COUNT przy sterowaniu x, y: 1–, 00, 01 oraz odpowiedni układ sterujący.

## Zadanie 4

- Krótka charakterystyka układów MAX.
- Wyjaśnić skróty: PLD, FPGA, ASIC, LAB.

PLD - programmable logic device, programowalny układ logiczny. W skrócie kawałek elektroniki na którym można zapisać własny program.

FPGA - field-programmable gate array - rodzaj PLD, z opcją wieloktrotnego programowania. Programuje się go w blokach logicznych. Wolniejsze od dedykowanych układów scalonych, ale wielokrotnego użytku i tańsze w eksploatacji. Bardzo użyteczne w eksperymentach naukowych (np. programowanie detektorów).

ASIC - application-specific integrated circuit - układ zaprojektowany do z góry ustalonego zadania.

## Zadanie 5

Obliczyć wszystkie minimalne uogólnienia reguły decyzyjnej e dla obiektu U = 1.

| U | a | b | c | d | e |
|---|---|---|---|---|---|
| 1 | 0 | 1 | 0 | 1 | 0 |
| 2 | 0 | 1 | 0 | 0 | 0 |
| 3 | 0 | 0 | 0 | 0 | 1 |
| 4 | 1 | 1 | 0 | 1 | 1 |
| 5 | 1 | 1 | 0 | 2 | 2 |

### Rozwiązanie:

1. Tworzy się macierz porównań M
2. Wyznacza się minimalne pokrycie M
3. Atrybutami reguły minimalnej są atrybuty należące do minimalnego pokrycia M.

1. Tworzenie macierzy M - porównujemy wiersze , jeśli dwa elementy w kolumnie są zgodne to wpisujemy 0, jeśli przeciwne to wpisujemy 1. Wynik (tj. e) pomijamy.

Dostajemy:

| 0 | 1 | 0 | 1 |
|---|---|---|---|
| 0 | 1 | 0 | 1 |
| 1 | 0 | 0 | 0 |
| 1 | 0 | 0 | 1 |

2. Znajdujemy minimalne pokrycia, tj. dla kolejnych wierszy sprawdzamy gdzie są jedynki.

Tutaj dostajemy:


- b, d
- a
- a, d

Widzimy, że minimalnymi pokryciami może być (a, b) lub (a, d). Zatem bierzemy bazową tablicę i w slocie U1 zostawiamy jedynie a i d:


| U | a | b | c | d | e |
|---|---|---|---|---|---|
| 1 | 0 | 1 | - | - | 0 |
| 2 | 0 | 1 | 0 | 0 | 0 |
| 3 | 0 | 0 | 0 | 0 | 1 |
| 4 | 1 | 1 | 0 | 1 | 1 |
| 5 | 1 | 1 | 0 | 2 | 2 |

Co prowadzi do zredukowania drugiego wiersza.