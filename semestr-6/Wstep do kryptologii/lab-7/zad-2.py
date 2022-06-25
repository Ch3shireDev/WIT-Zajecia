# Alicja chce wysłać do Boba wiadomość, której skrót wynosi h = 357.
# Wygenerować przez Alicję podpis cyfrowy ElGamala dla tej wiadomości,
# wiedząc, że Alicja użyła randomizera r = 515.

from lib import power_mod, euclides_extended


# Klucz publiczny Alicji (p, g, B):
p, g, B = (1619, 2, 1454)
print(f"Klucz publiczny Alicji (p, g, B): ({p}, {g}, {B})")

# Klucz prywatny Alicji (p, g, t):
p, g, t = (1619, 2, 937)
print(f"Klucz prywatny Alicji (p, g, t): ({p}, {g}, {t})")

# Randomizer Alicji.
r = 515
print(f"Randomizer Alicji r: {r}")

# Skrót wiadomości.
h = 357
print(f"Skrót wiadomości Alicji h: {h}")

# Obliczanie u = a^r mod p
u = power_mod(g,r,p)
print(f"Wartość u = g^r mod p = {u}")

# Obliczanie r^-1 mod (p-1)
rx = euclides_extended(r, p-1)
print(f"Wartość r^-1 mod (p-1) = {rx}")

# Obliczanie s = r^-1*(h-t*u) mod (p-1)
s = rx*(h-t*u) % (p-1)
print(f"Wartość s = r^-1*(h-t*u) mod (p-1) = {s}")

print(f"Podpis cyfrowy Alicji (u, s) = ({u}, {s})")