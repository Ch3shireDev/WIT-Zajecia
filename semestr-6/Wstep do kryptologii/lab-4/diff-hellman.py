# potęgowanie modularne

def power_mod(a, b, n):
    print(f"Obliczanie {a}^{b} mod {n}")
    b_bin = bin(b)[2:]
    print(f"{b} binarnie: {b_bin}")
    result = 1
    for i in range(len(b_bin)):
        if b_bin[-i-1] == '1':
            x = a**(2**(i))
            print(f"{b_bin[-i-1]}: {a}^{2**i} = {x%n} (mod {n})")
            result *= x
            result %= n
        else:
            print(f"{b_bin[-i-1]}: Pomijanie {a}^{2**i}")

    print(f"Wynik: {a}^{b} mod {n} = {result}")
    print()
    return result


# assert power_mod(2, 3, 5) == 2**3 % 5
# assert power_mod(88, 112, 100) == 88**112 % 100

p = 1019
g = 2
a = 638
b = 719

# 0. Alicja i Bob uzgadniają liczbę pierwszą p=23 i podstawę g=5.
# 1. Alicja wybiera tajną liczbę całkowitą a=6, i wysyła Bobowi
# A = g^a mod p
print("Krok pierwszy (Alicja): A = g^a mod p")
A = power_mod(g, a, p)

# 2. Bob wybiera tajną liczbę całkowitą b=15, i wysyła Alicji
# B = g^b mod p
print("Krok drugi (Bob): B = g^b mod p")
B = power_mod(g, b, p)

# 3. Alicja oblicza
# s = B^a mod p
print("Krok trzeci (Alicja): sa = B^a mod p")
sa = power_mod(B, a, p)

# 4. Bob oblicza
# s = A^b mod p
print("Krok czwarty (Bob): sb = A^b mod p")
sb = power_mod(A, b, p)

print(f"Uzgodnione klucze: sa = sb = {sa} = {sb}")