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


if __name__ == "__main__":
    m = 20
    e = 1001
    n = 1739

    power_mod(m, e, n)
