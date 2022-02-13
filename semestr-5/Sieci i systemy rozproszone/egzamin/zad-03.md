Proszę rozpatrzyć możliwe plany współbieżnej realizacji następujących trzech transakcji:

```
a) 
POCZATEK_TRANSAKCJI
x = 0; y = -1; x = x - y; y = x + 2;
KONIEC_TRANSAKCJI

b) 
POCZATEK_TRANSAKCJI
x = 2; y = 1; x = x + 7; y = x + y + 2;
KONIEC_TRANSAKCJI

c) 
POCZATEK_TRANSAKCJI
x = 0; x = x + 3; y = 7; y = y + x;
KONIEC_TRANSAKCJI
```

Proszę określić pełną listę dopuszczalnych wartości (rozdzielając je słowami „lub" ewentualnie „i"), które mogą przyjmować na końcu zmienne: x i y. Proszę podać przykład niedopuszczalnego planu realizacji transakcji. Odpowiedź należy uzasadnić.

## Rozwiazanie

Ponieważ każda transakcja przypisuje nowe wartości do zmiennych x i y, to wartość końcowa zmiennych będzie zdeterminowana przez ostatnią transakcję. Transakcje spełniają warunek izolacji, czyli żadna z transakcji nie może zaburzać działania innej transakcji. Jeśli jednak wynik końcowy będzie taki sam, jakby transakcje wykonywały się jedna po drugiej, to transakcje mogą wykonywać się współbieżnie.

Dopuszczalne wartości zmiennych `x, y`:

- `x=1, y=3` lub
- `x=9, y=12` lub
- `x=3, y=10`

Przykład niedopuszczalnego planu realizacji transakcji:

```
x = 0           A1
y = -1          A2
x = x - y       A3
y = x + 2       A4

x = 2           B1
y = 1           B2

x = 0           C1
x = x + 3       C2
y = 7           C3
y = y + x       C4

x = x + 7       B3
y = x + y + 2   B4

(transakcja C wykonuje się w połowie wykonania transakcji B)

Wynik końcowy:
x=10, y=22
```