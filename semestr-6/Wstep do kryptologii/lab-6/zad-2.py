# Bob otrzymał od Alicji wiadomość, z której wyznaczył skrót h=357, oraz jej podpis cyfrowy RSA s=1630. 
# Zweryfikuj przez Boba otrzymany od Alicji podpis cyfrowy.

from lib import cipher, decipher

# skrót wiadomości
h = 357

# podpis cyfrowy
s = 1630

# klucz publiczny Alicji
e, n = 1001, 1739

print(f"Wyznaczony skrót wiadomości: {h}")
print(f"Podpis cyfrowy: {s}")
print(f"Klucz publiczny (e,n): ({e}, {n})")
x = decipher(s, e, n)

print(f"Odszyfrowany skrót wiadomości: {x}")

if x == h:
    print(f"Podpis cyfrowy poprawny - odszyfrowany skrót ({x}) identyczny z wyznaczonym skrótem ({h}).")
else:
    print(f"Podpis cyfrowy niepoprawny - odszyfrowany skrót ({x}) inny niż z wyznaczony skrót ({h}).")
