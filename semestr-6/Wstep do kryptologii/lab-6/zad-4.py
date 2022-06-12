# Bob chce wysłać do Alicji wiadomość której wartość liczbowa wynosi x=20.
# Oblicz wartość tekstu zaszyfrowanego C, wiedząc, że do zaszyfrowania wybrany został randomizer r=320.

from lib import power_mod, euclides_extended

# Klucz publiczny Alicji (p, g, A):
p, g, A = (1619, 2, 1454)
print(f"Klucz publiczny Alicji (p,g,A): ({p}, {g}, {A})")

# Klucz prywatny Alicji (p, g, t):
p, g, t = (2, 1619, 937)
print(f"Klucz prywatny Alicji (p,g,t): ({p}, {g}, {t})")

r = 320
print(f"Wybrany randomizer: {r}")

x = 20
print(f"Wiadomość do zaszyfrowania: {x}")

ax = power_mod(g, r, p)
print(f"Wartość publiczna ax: g^r mod p = {ax}")

y = (x * power_mod(A, r, p)) % p
print(f"Zaszyfrowana wiadomość (x*A^r mod p): {y}")

cipher = (ax, y)
print(f"Para zaszyfrowana (ax, y): ({ax}, {y})")

bx = power_mod(ax, t, p)
print(f"Deszyfrowanie wiadomości. Obliczanie bx = (g^r)^t: {bx}")

ibx = euclides_extended(bx, p)
print(f"Obliczanie odwrotności bx-1 = bx mod p: {ibx}")

x2 = y * ibx % p
print(f"Odszyfrowana wiadomość: y*bx-1 mod p = {x2}")
