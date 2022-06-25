# Bob chce wysłać do Alicji wiadomość, której wartość wynosi x=20 zaszyfrowaną przy użyciu algorytmu RSA.
# Oblicz wartość szyfrogramu y.

from potegowanie import power_mod as pow


def cipher(m, e, n):
    return pow(m, e, n)


def decipher(c, d, n):
    return pow(c, d, n)


m, e, n, d = 20, 1001, 1739, 761

print("Wiadomość:", m)
c = cipher(m, e, n)
print("Szyfrogram:", c)
print("Odszyfrowana wiadomość:", decipher(c, d, n))
