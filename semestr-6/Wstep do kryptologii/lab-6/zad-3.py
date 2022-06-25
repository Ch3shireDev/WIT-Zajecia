# Alicja chce wygenerować klucze asymetryczne ElGamala.
# W tym celu przyjęła wartość p=1619 oraz generator g=2.
# Wyznacz klucze asymetryczne Alicji dla jej wartości prywatnej t=937.

from lib import power_mod

p, g = 1619, 2
t = 937

print(f"Wartość p: {p}")
print(f"Generator g: {g}")
print(f"Wartość prywatna t: {t}")

A = power_mod(g, t, p)

print(f"Wartość publiczna A: g^t mod p = {A}")

# klucz publiczny
p, g, p = A, g, p
print(f"Klucz publiczny Alicji (p, g, A): ({p}, {g}, {A})")

print(f"Klucz prywatny Alicji (t, g, p): ({t}, {g}, {p})")
