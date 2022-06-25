# Alicja wylosowała dwie liczby pierwsze p=37 i q=47 oraz wartość e=1001. 
# Wyznaczyć klucze asymetryczne RSA dla Alicji.

def euclides_extended(a, b):
    a, b = max(a, b), min(a, b)

    q = a//b
    r = a - q*b

    x2 = 1
    x1 = 0
    y2 = 0
    y1 = 1
    x = 1
    y = y2 - (q-1)*y1

    while r != 0:
        a = b
        b = r

        x = x2 - q*x1
        x2 = x1
        x1 = x

        y = y2 - q*y1
        y2 = y1
        y1 = y

        nwd = r
        q = a//b
        r = a - q*b

    return y


assert euclides_extended(1001, 1656) == 761

# W celu wygenerowania pary kluczy (prywatnego i publicznego) należy posłużyć się algorytmem:

# 1. Wybieramy losowo dwie duże liczby pierwsze p i q (najlepiej w taki sposób, aby obie miały zbliżoną długość w bitach,
# ale jednocześnie były od siebie odległe wartościami – istnieją lepsze mechanizmy faktoryzacji,
# jeżeli liczba ma dzielnik o wartości bliskiej n {\displaystyle {\sqrt {n}}} {\sqrt n}).


p = 37
q = 47

# 2. Obliczamy wartość n = pq.

n = p * q

#     Obliczamy wartość funkcji Eulera dla n: φ ( n ) = ( p − 1 ) ( q − 1 ).

fi = (p-1)*(q-1)

#     Wybieramy liczbę e (1 < e < φ(n)) względnie pierwszą z φ(n).

e = 1001

#     Znajdujemy liczbę d, gdzie jej różnica z odwrotnością modularną liczby e jest podzielna przez φ(n):

# d ≡ e−1 (mod φ(n)).
# Ta liczba może być też prościej określona wzorem:
# d⋅e ≡ 1 (mod φ(n)).

d = euclides_extended(e, fi)
print(e, fi)
print((d*e) % fi)

# Klucz publiczny jest definiowany jako para liczb (n, e), natomiast kluczem prywatnym jest para (n, d).

print("Klucz publiczny (e,n): ", (e, n))
print("Klucz prywatny (d,n): ", (d, n))
