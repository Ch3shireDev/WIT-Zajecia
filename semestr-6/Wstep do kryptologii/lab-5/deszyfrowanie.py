# Alicja otrzymała od Boba szyfrogram y=1327. Obliczyć przez Alicję wartość tekstu jawnego x.

from potegowanie import power_mod as pow

def cipher(m, e, n):
    return pow(m, e, n)


def decipher(c, d, n):
    return pow(c, d, n)


n, d = 1739, 761

c = 1327
print("Szyfrogram:", c)
print("Odszyfrowana wiadomość:", decipher(c, d, n))
