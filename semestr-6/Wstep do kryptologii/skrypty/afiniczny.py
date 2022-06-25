cipher = 'LKJOGDTKFIPF'

for c in cipher:
    y = ord(c) - ord('A')
    x = 19*(y-5) % 26
    z = chr(x + ord('A'))
    print(f"{c} {y:02d} {x:02d} {z}")