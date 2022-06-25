import sys


def power_mod(a, b, n):
    print(f"Obliczanie {a}^{b} mod {n}")
    b_bin = bin(b)[2:]
    print(f"{b} binarnie: {b_bin}")
    result = 1
    x = a
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


if len(sys.argv) < 4:
    print("Należy podać trzy liczby jako argumenty wywołania.")
    exit()

a = int(sys.argv[1])
b = int(sys.argv[2])
n = int(sys.argv[3])


x = power_mod(a, b, n)

print(x)