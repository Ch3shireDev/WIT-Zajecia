# Zadanie 7

Adres IP  i maska wynoszą odpowiednio: 192.168.2.xy (gdzie xy dwie ostatnie cyfry z liczby określonej jako nr indeksu +1), 255.255.255.248. Proszę obliczyć z jakiej sieci pochodzi w/w adres i jaki jest adres broadcastu w tej sieci. Podać adresy dziesiętne i binarne. Podać sposób obliczenia i uzasadnienie odpowiedzi.

Numer indeksu: 18608
Adres IP: 192.168.2.08
Maska: 255.255.255.248

## Rozwiązanie

Adres IP: 192.168.2.08 = 11000000.10101000.00000010.00001000
Maska: 255.255.255.248 = 11111111.11111111.11111111.11111000

Adres sieci liczymy poprzez wzięcie operacji bitowej AND adresu z maską. Uzyskujemy wtedy:

Adres sieci: 11000000.10101000.00000010.00001000 = 192.168.2.8

Adres broadcastu uzyskujemy poprzez wzięcie adresu sieci i zastąpienie wartości przykrywanych przez maskę jedynkami, tj. w tym wypadku trzy ostatnie zera adresu sieci zastępujemy jedynkami. Uzyskujemy zatem:

Adres broadcastu: 11000000.10101000.00000010.00001111 = 192.168.2.15