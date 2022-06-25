# Alicja chce wysłać do Boba wiadomość, której skrót wynosi h=357. 
# Wygenerować przez Alicję podpis cyfrowy RSA dla tej wiadomości.

from lib import cipher, decipher

# skrót
h = 357

# klucz publiczny Alicji
e, n = 1001, 1739

# klucz prywatny Alicji
d, n = 761, 1739


print(f"Klucz publiczny (e,n): ({e}, {n})")
print(f"Klucz prywatny (d,n): ({d}, {n})")
print(f"Skrót: {h}")

x = cipher(h, d, n)

print(f"Podpis cyfrowy (szyfrowanie kluczem prywatnym (d,n)): {x}")

y = decipher(x, e, n)

print(f"Odszyfrowany skrót (deszyfrowanie kluczem publicznym (e,n)): {y}")
