# Zadania

## Ćwiczenia 2

### Zad 1.

Zaszyfruj słowo "kryptologia" za pomocą szyfru przesuwnego i klucza k=19.

#### Rozwiązanie

Klucz przesuwny polega na przyporządkowaniu wszystkim literom alfabetu łacińskiego liczb od 0 do 25 i dodawaniu modulo 26 liczby będącej kluczem do każdej liczby reprezentującej kolejną literę.

Proces szyfrowania odbywa się z użyciem poniższej tabeli:

| alfabet | a   | b   | c   | d   | e   | f   | g   | h   | i   | j   | k   | l   | m   | n   | o   | p   | q   | r   | s   | t   | u   | v   | w   | x   | y   | z   |
| ------- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| liczby  | 0   | 1   | 2   | 3   | 4   | 5   | 6   | 7   | 8   | 9   | 10  | 11  | 12  | 13  | 14  | 15  | 16  | 17  | 18  | 19  | 20  | 21  | 22  | 23  | 24  | 25  |

Operacja szyfrowania tekstu jawnego:

| k   | r   | y   | p   | t   | o   | l   | o   | g   | i   | a   |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 10  | 17  | 24  | 15  | 19  | 14  | 11  | 14  | 6   | 8   | 0   |
| 3   | 10  | 17  | 8   | 12  | 7   | 4   | 7   | 25  | 1   | 19  |
| d   | k   | r   | i   | m   | h   | e   | h   | z   | b   | t   |

Zaszyfrowany tekst: "DKRIMHEHZBT".

### Zad 2

Zdeszyfruj słowo "DKRIMHEHZBT" wiedząc, że powstało przy użyciu szyfru przesuwnego i klucza k=19.

### Zad 3

Zaszyfruj słowo "kryptologia" za pomocą szyfru afinicznego i klucza k=(21,6).

#### Rozwiązanie

Szyfr afiniczny uzyskuje się poprzez przypisanie każdej z liter alfabetu łacińskiego wartości liczbowej od 0 do 25, zastosowanie przekształcenia:

$$y = ax+b\mod 26,$$

gdzie $x$ to litera z tekstu jawnego, $y$ to litera z kryptogramu, a $a,b$ to elementy klucza.

### Zad 4

Zdeszyfruj słowo "IZQJPODOCSG" za pomocą szyfru afinicznego i klucza k=(21,6).

## Ćwiczenia 3

### Zad 1

Zaszyfruj słowo "kryptografiaikryptoanaliza" za pomocą szyfru Vigener'a i klucza k="keylog".

### Zad 2

Zdeszyfruj słowo "UVWAHUQVYQWGSOPJDZYELLZOJE" za pomocą szyfru Vigener'a i klucza k="keylog".

### Zad 3

Zaszyfruj słowo "telewizor" za pomocą szyfru Hill'a i klucza $k=[[9, 3, 4] [7, 2, 1] [6, 5, 8]]$.

### Zad 4

Zdeszyfruj słowo "FQMESYJGQ"/"TWOECQXMS" za pomocą szyfru Hill'a i klucza deszfrowania $k^{-1}=[[25, 24, 17] [14, 24, 3] [5, 19, 5]]$.

## Ćwiczenia 4

### Zad 1

Oblicz $88^{112} \mod 100.$

### Zad 2

Niech $p=1019$ oraz $g=2$ będące generatorem $Z_p^*$.
Alicja wybrała wartość prywatną $a=638$ oraz Bob wybrał wartość prywatną $b=719$.
Oblicz uzgodniony przez Alicję i Boba klucz za pomocą algorytmu Diffiego-Hellmana.

### Zad 3

Niech $p=1187$ oraz $g=5$ będące generatorem $Z_p^*$. Alicja wybrała wartość prywatną $a=700$ oraz Bob wybrał wartość prywatną $b=550$.

Oblicz uzgodniony przez Alicję i Boba klucz za pomocą algorytmu Diffiego-Hellmana. (k=397)

## Ćwiczenia 5

### Zad 1

Alicja wylosowała dwie liczby pierwsze p=37 i q=47 oraz wartość e=1001. Wyznaczyć klucze asymetryczne RSA dla Alicji.

### Zad 2

Bob chce wysłać do Alicji wiadomość, której wartość wynosi x=20 zaszyfrowaną przy użyciu algorytmu RSA. Oblicz wartość szyfrogramu y.

### Zad 3

Alicja otrzymała od Boba szyfrogram y=1327. Obliczyć przez Alicję wartość tekstu jawnego x.

### Zad 4

Bob chce wysłać do Alicji wiadomość, której wartość wynosi x=508 zaszyfrowaną przy użyciu algorytmu RSA. Oblicz wartość szyfrogramu y. (odp y=1454).

## Ćwiczenia 6

### Zad 1

Alicja chce wysłać do Boba wiadomość, której skrót wynosi h=357. Wygenerować przez Alicję podpis cyfrowy RSA dla tej wiadomości.

### Zad 2

Bob otrzymał od Alicji wiadomość, z której wyznaczył skrót h=357, oraz jej podpis cyfrowy RSA s=1630.
Zweryfikuj przez Boba otrzymany od Alicji podpis cyfrowy.

### Zad 3

Alicja chce wygenerować klucze asymetryczne ElGamala. W tym celu przyjęła wartość p=1619 oraz generator g=2.
Wyznacz klucze asymetryczne Alicji dla jej wartości prywatnej t=937.

### Zad 4

Bob chce wysłać do Alicji wiadomość której wartość liczbowa wynosi x=20.
Oblicz wartość tekstu zaszyfrowanego C, wiedząc, że do zaszyfrowania wybrany został randomizer r=320.

## Ćwiczenia 7

### Zad 1

Alicja otrzymała od Boba szyfrogram Y=(130, 414). Obliczyć przez Alicję wartość tekstu jawnego x.

### Zad 2

Alicja chce wysłać do Boba wiadomość, której skrót wynosi h=357.
Wygenerować przez Alicję podpis cyfrowy ElGamala dla tej wiadomości, wiedząc, że Alicja użyła randomizera r=515.

### Zad 3

Bob otrzymał od Alicji wiadomość, której skrót wynosi h=357,
oraz podpis cyfrowy ELGamala (u,s)=(1310,1579). Zweryfikuj przez Boba otrzymany od Alicji podpis cyfrowy.

## Kolokwium (2011)

### Zad 1

Dla pierścienia $Z_7$:

a) wyznacz tabelki działań $(+,*)$;
b) sprawdź, czy pierścień jest ciałem
c) wyznacz (jeśli istnieją) elementy przeciwne i odwrotne dla wszystkich elementów pierścienia
d) rozwiąż równanie $3*x = 5$.

### Zad 2

Stosując szyfr Vigenere'a zaszyfrować tekst "kryptoanaliza" przy użyciu klucza "szyfr".

### Zad 3

Stosując szyfr afiniczny zdeszyfrować kryptogram: "LKJOGDTKFIPF" wiedząc, że był on otrzymany w procesie szyfrowania przy użyciu klucza $k=(a,b)=(11,5)$.

### Zad 4

Stosując szyfr Hilla zaszyfrować tekst "Warszawa" przy użyciu klucza $K = \begin{bmatrix}3&15\\6&1\end{bmatrix}$

### Zad 5

Znajdź $u, v\in Z$ takie, że $1234u+849v=\gcd(1234,849)$. Podaj wartość $849^{-1}\mod 1234$ (jeśli istnieje) oraz $\gcd(1234,849).$

### Zad 6

Niech $x\in Z_{31}$ odpowiada wartości liczbowej tekstu jawnego i niech $y\in Z_{31}$ odpowiada wartości liczbowej szyfrogramu. Znajdź wartość liczbową tekstu jawnego wiedząc, że $y=29$, a do szyfrowania użyto szyfru afinicznego z kluczem $k=(a,b)=(11,12).$
