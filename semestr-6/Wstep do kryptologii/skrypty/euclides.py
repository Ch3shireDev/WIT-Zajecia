import sys

def euclides(a, b):
    a, b = max(a, b), min(a, b)
    x, r = 0, 1
    y, s = 1, 0
    while b != 0:
        q = a//b
        print(f"{a=}, {b=}, {a%b=}, {q=}, {x=}, {r=}, {y=}, {s=}")
        a, b = b, a % b
        r, x = x-q*r, r
        s, y = y-q*s, s
    return a, x, y

if len(sys.argv) < 3:
    print("Należy podać dwie liczby jako argumenty wywołania.")
    
x = int(sys.argv[1])
y = int(sys.argv[2])
    
print(euclides(x,y))


# x=0, y=1, r=1, s=-5
# x=1, y=-5, r=-4, s=21
# x=-4, y=21, r=5, s=-26
# x=5, y=-26, r=-9, s=47
# x=-9, y=47, r=23, s=-120
# 1 -9 47
