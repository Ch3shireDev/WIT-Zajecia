# potęgowanie modularne

def power_mod(a, b, n):
    print()
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


def cipher(m, e, n):
    return power_mod(m, e, n)


def decipher(c, d, n):
    return power_mod(c, d, n)


def euclides_extended(a, b):
    a, b = max(a, b), min(a, b)

    q = a//b
    r = a - q*b

    x2 = 1
    x1 = 0
    y2 = 0
    y1 = 1
    x = 1
    y = y2 - (q-1)*y1

    while r != 0:
        a = b
        b = r

        x = x2 - q*x1
        x2 = x1
        x1 = x

        y = y2 - q*y1
        y2 = y1
        y1 = y

        nwd = r
        q = a//b
        r = a - q*b

    return y


assert euclides_extended(1001, 1656) == 761
