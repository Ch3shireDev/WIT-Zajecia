Do jakiej najmniejszej sieci IP należą adresy 192.168.6.81 i 192.168.6.90? Podaj adres IP i maskę tej sieci. Czy adres 192.168.6.72 należy do powyższej sieci? Jeśli nie, to podaj adres i maskę innej najmniejszej sieci, do której należą wszystkie trzy adresy.

## Rozwiązanie

Postać bitowa adresów:

- `192.168.6.81 = 192.168.6.0101 0001`
- `192.168.6.90 = 192.168.6.0101 1010`

Adresy różnią się na ostatnich czterech bitach, oznacza to że mogą należeć do minimalnej sieci o adresie `192.168.6.01010000 = 192.168.6.80`. Maska takiej sieci to `/28 = 255.255.255.240`.

Adres `192.168.6.72 = 192.168.6.01001000` nie należy do tej sieci - część sieciowa jest inna. Adres minimalnej sieci zawierającej wszystkie trzy adresy możemy wyliczyć przez znalezienie takiej części sieciowej, która będzie wspólna dla wszystkich trzech adresów.

- `192.168.6.81 = 192.168.6.010 10001`
- `192.168.6.90 = 192.168.6.010 11010`
- `192.168.6.72 = 192.168.6.010 01000`

Ostatnie 5 bitów się różni, pozostałe bity są takie same. Adres sieci to
`192.168.6.01000000`, czyli `192.168.6.64` z maską `/27 = 255.255.255.224`.