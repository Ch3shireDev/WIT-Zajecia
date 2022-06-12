# Alicja otrzymała od Boba szyfrogram Y=(130, 414). Obliczyć przez Alicję wartość tekstu jawnego x.


from lib import power_mod, euclides_extended

# Klucz publiczny Alicji (p, g, A):
p, g, B = (1619, 2, 1454)
print(f"Klucz publiczny Alicji (p, g, B): ({p}, {g}, {B})")

# Klucz prywatny Alicji (p, g, t):
p, g, t = (1619, 2, 937)
print(f"Klucz prywatny Alicji (p, g, t): ({p}, {g}, {t})")

# Wartość szyfrogramu od Boba: Y = (130, 414)
Y = (130,414)
ax, y = Y
print(f"Szyfrogram od Boba (ax, y): ({ax}, {y})")

bx = power_mod(ax, t, p)
print(f"Deszyfrowanie wiadomości. Obliczanie bx = (g^r)^t: {bx}")

ibx = euclides_extended(bx, p)
print(f"Obliczanie odwrotności bx-1 = bx mod p: {ibx}")

x2 = y * ibx % p
print(f"Odszyfrowana wiadomość: y*bx-1 mod p = {x2}")
