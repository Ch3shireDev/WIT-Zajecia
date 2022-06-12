# Bob otrzymał od Alicji wiadomość, której skrót wynosi h=357,
# oraz podpis cyfrowy ELGamala (u,s)=(1310,1579).
# Zweryfikuj przez Boba otrzymany od Alicji podpis cyfrowy.
from lib import power_mod, euclides_extended

# Klucz publiczny Alicji (p, g, B):
p, g, B = (1619, 2, 1454)
print(f"Klucz publiczny Alicji (p, g, B): ({p}, {g}, {B})")

# Skrót wiadomości
h = 357
print(f"Skrót wiadomości Alicji h: {h}")

u, s = 1310, 1579
print(f"Podpis cyfrowy Alicji (u, s) = ({u}, {s})")

# Obliczanie f = g^h mod p
f = power_mod(g,h,p)
print(f"Wartość f = g^h mod p = {f}")

# Obliczanie l = B^u * u^s
q = power_mod(B,u,p) * power_mod(u,s,p) % p
print(f"Wartość q = B^u * u^s mod p = {q}")

if f == q:
    print(f"Uzyskane wartości f = q. Podpis jest poprawny.")
else:
    print(f"Uzyskana wartości f ≠ q (f = {f}, q = {q}). Weryfikacja nieprawidłowa.")

