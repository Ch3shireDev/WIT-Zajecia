Aplikacja używająca protokołu UDP, uruchomiona w sieci z MTU=576 B, wysyła 2000 B danych za nagłówkiem UDP. Zapisz powstałe fragmenty w notacji "długość @ offset flaga" (długość i offset są podawane w bajtach). Przedstaw w zapisie binarnym zawartość pola offset drugiego fragmentu.

## Rozwiązanie

- MTU = 576 B
- Dane = 2000 B
- Nagłówek UDP = 8 B
- Nagłówek IP = 20 B

Całkowity rozmiar danych: 2000 B + 8 B = 2008 B.

Wygląd:

```
| Nagłówek IP | Nagłówek UDP | Dane   |
| 20 B        | 8 B          | 2000 B |
```

Każdy fragment musi zawierać nagłówek 20 B. Oznacza to, że na dane zostaje 556 B. Ponieważ 556 nie dzieli się przez 8, bierzemy rozmiar fragmentu danych = 552 B.

Kolejne fragmenty:

```
552@0MF
552@552MF
552@1104MF
352@1656LF
```

Zapis binarny zawartość pola offset drugiego fragmentu: `0001000101000` (552, 13 bitów).