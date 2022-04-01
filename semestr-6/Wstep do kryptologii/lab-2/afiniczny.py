from sys import argv


def mod(num, mod):
    while num < 0 and mod > 0:
        num += mod
    return num % mod


def cipher_letter(x, a, b):
    num = ord(x) - ord('a')
    num_cipher = a*(num) + b
    letter_cipher = chr(mod(num_cipher, 26) + ord('a'))

    print(f'{x} = {num} -> {num}*{a} + {b} = {num_cipher} -> {num_cipher}%26 = {mod(num_cipher,26)} = {letter_cipher}')
    return letter_cipher

def ad(a, m):
    for i in range(m):
        if a*i % m == 1:
            return i
        
def bd(b, m):
    bm = b*ad(a,26)
    while bm < 0 and m>0:
        bm+=m
    return bm

a = int(argv[1])
b = int(argv[2])

print(f"decipher pair: {ad(a,26)}, {bd(b,26)}")

print(''.join([cipher_letter(x, a, b) for x in argv[3]]))
