# Egzamin z PUL 2015

## Zadanie 1a

Jaką liczbę dziesiętną całkowitą reprezentuje liczba 10111 dana w naturalnym kodzie binarnym?

## Zadanie 1b
Zapisać liczbę 19 w naturalnym kodzie binarnym.

## Zadanie 1c
Podać nazwy dwóch dowolnych bloków funkcjonalnych sekwencyjnych.

- pamięć
- rejestr
- licznik
- sumatory

## Zadanie 2

Podaj tablicę przejść przerzutnika typu T i jego funkcję charakterystyczną.

| Q \ T | 0 | 1 |
|-------|---|---|
| 0     | 0 | 1 |
| 1     | 1 | 0 |

$$ Q' = T\bar Q + \bar T Q$$
## Zadanie 3

Dla par sprzecznych: (1,2), (1,5), (2,3), (2,6), (4,5), (5,6) obliczyć (metodą wg par sprzecznych) wszystkie maksymalne klasy zgodności.

$$
(k_1+k_2)
(k_1+k_5)
(k_2+k_3)
(k_2+k_6)
(k_4+k_5)
(k_5+k_6)=
$$

$$(k_1+k_2k_5)(k_2+k_3k_6)(k_5+k_4k_6)=$$
$$(k_1k_2 + k_2k_5+k_1k_3k_6)(k_5+k_4k_6)=$$
$$k_2k_5+k_1k_2k_4k_6+k_1k_3k_6$$

Klasy zgodności uzyskujemy biorąc zbiory $k_1, k_2, ..., k_6$ i odejmując od nich elementy w iloczynach.

Daje to następujące klasy zgodności:

- $k_1k_3k_4k_6$
- $k_3k_5$
- $k_2k_4k_5$

## Zadanie 3b
Za pomocą przekształceń algebraicznych znajdź najprostszą postać wyrażenia 

$(\bar x+y)(x+z)(x+\bar z)$.

# Zadanie 4

Dla tablicy poniżej obliczyć wyrażenie logiczne dla decyzji e = 0.


| U | a | b | c | d | e |
|---|---|---|---|---|---|
| 1 | 1 | 0 | 0 | 1 | 1 |
| 2 | 1 | 0 | 0 | 0 | 1 |
| 3 | 0 | 0 | 0 | 0 | 0 |
| 4 | 1 | 1 | 1 | 1 | 0 |
| 5 | 1 | 0 | 1 | 2 | 2 |

Decyzja $e = 0$:

| U | a | b | c | d | e |
|---|---|---|---|---|---|
| 3 | 0 | 0 | 0 | 0 | 0 |
| 4 | 1 | 1 | 1 | 1 | 0 |

Rozwiązanie:

$$f = (a+b+c+d)(\bar a+\bar b+\bar c+\bar d)$$
