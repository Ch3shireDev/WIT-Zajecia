import sys


def generator_power(alpha, n):
    for i in range(2, n-1):
        if alpha**i % n == 1:
            return i
    return 0

def is_generator(alpha, n):
    return generator_power(alpha, n) == 0


if len(sys.argv) < 2:
    print("Należy podać wartość n grupy multiplikatywnej Z^*_n")
    exit()

n = int(sys.argv[1])

count = 0

for alpha in range(2, n-1):
    x = generator_power(alpha, n)
    if x == 0:
        count += 1
        print(f"{alpha} jest generatorem grupy multiplikatywnej Z^*_{n}")
    else:
        print(f"{alpha}^{x} mod {n} = 1")

print(f"Wygenerowano {count} generatorów grupy multiplikatywnej Z^*_{n}")