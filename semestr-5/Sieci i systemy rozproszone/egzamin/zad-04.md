Proszę porównać operacje czytania pliku za pomocą jednowątkowego serwera plików i serwera wielowątkowego. 

Otrzymanie zamówienia na pracę, skierowanie go do wykonania i reszta niezbędnego przetwarzania zajmuje 9 ms, pod warunkiem, że potrzebne dane znajdują się w podręcznej pamięci bloków. 

Jeżeli istnieje konieczność wykonania operacji dyskowej, co stanowi jedną piątą zamówień, potrzeba dodatkowo 72ms, podczas których wątek jest uśpiony. 

- Ile zamówień na sekundę może obsłużyć serwer jednowątkowy i jakie będzie procentowe wykorzystanie czasu procesora? 
- Ile zamówień na sekundę może obsłużyć serwer wielowątkowy i jakie będzie wówczas procentowe wykorzystanie czasu procesora?  

Proszę podać sposób rozwiązania i dokładnie uzasadnić.

## Rozwiązanie

- Czas przetwarzania zamówienia przez procesor: 9 ms
- Czas operacji dyskowej: 72 ms
- Proporcja zamówień dyskowych: 1/5

### Serwer jednowątkowy

Serwer działa w następujący sposób - wątek otrzymuje zamówienie, przetwarza, w razie operacji dyskowej czeka na zakończenie, przetwarza dalej. Dla uproszczenia obliczeń założymy, że co piąte zamówienie jest operacją dyskową:

```
Procesor: [9ms]                              [9ms][9ms][9ms][9ms]
Dysk:         [            72ms              ]
```

Na obsłużenie 5 zamówień serwer poświęca 117 ms (`5*9+72`). Oznacza to, że serwer obsługuje średnio 42.73 zamówień na sekundę (5/0.117ms). Ponieważ procesor pracuje przez 45 ms (`5*9ms`), to jego wydajność wynosi 38.46% (45/117).

### Serwer wielowątkowy

Serwer działa w następujący sposób: kolejne wątki wykonują kolejne zamówienia, jeśli któryś wątek wymaga operacji dyskowej, czeka na jej zakończenie. Jedna operacja dyskowa musi się zakończyć zanim zacznie się druga. Oznacza to, że czas trwania operacji dyskowej będzie wąskim gardłem wydajności serwera.

```
Procesor: [9ms][9ms][9ms][9ms][9ms]          [9ms][9ms][9ms][9ms][9ms]
Dysk:         [            72ms                  ][                  72ms              ]
```

W czasie 72 ms serwer obsługuje 5 zamówień - nie jest w stanie obsłużyć więcej, bo operacje dyskowe są wymagane przez 1/5 zamówień. Wydajność serwera będzie wynosiła zatem 69.44 zamówień na sekundę (5 zamówień na 72 ms). Ponieważ w czasie 72 ms jeden wątek byłby w stanie teoretycznie wykonać 8 zamówień (72/9=8), a wykonuje tylko 5, to procentowe wykorzystanie czasu procesora wynosi 62.5% (5/8).