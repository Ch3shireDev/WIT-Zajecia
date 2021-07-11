# Zadanie 6

Wieloprocesor ma 2048 procesorów o szybkości 80 MIPS połączonych z pamięcią za pomocą sieci Omega z poczwórnymi przełącznikami. Jakie powinny być czasy przełączenia przełączników, aby zamówienie zdążyło dojść do pamięci i wrócić w jednym cyklu rozkazowym? Należy dokładnie podać sposób rozwiązania i uzasadnienie.

## Rozwiązanie

Liczba procesorów: 2048

Logarytm liczby procesorów - 11

Szybkość procesorów: $f = 80$ MIPS

minimalny czas przełączania $t = ???$

Sygnał idzie od procesora przez kolejne warstwy przełączników, których jest tyle, co $\log_2$ z liczby procesorów - w tym wypadku 11 - do pamięci RAM, po czym wraca z powrotem. Potrzebuje zatem przejść przez 22 przełączniki, z których każdy potrzebuje $t$ czasu na reakcję. Jeśli prędkość wykonywania instrukcji przez procesory wynosi 80 MIPS, oznacza to, że pojedynczy cykl rozkazowy wykonuje się w czasie $T = 0.125 \text{ ns}$. Jeśli w tym czasie sygnał musi przejść 22 razy przez wszystkie przełączniki, to czas działania jednego przełącznika powinien być równy najwyżej $t = \frac{T}{22} = 0.0057 \text{ ns} = 5.7 \text{ ps}$.