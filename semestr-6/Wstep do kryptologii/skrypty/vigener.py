message = 'kryptoanaliza'
key = 'szyfr'

key = [key[i % len(key)] for i in range(len(message))]

pairs = zip(message, key)

for a, k in pairs:
    a1 = ord(a) - ord('a')
    k1 = ord(k) - ord('a')
    x1 = (a1+k1) % 26
    x = chr(x1 + ord('a'))
    print(f"{a} {a1:02d} {k} {k1:02d} {x1:02d} {x}")
