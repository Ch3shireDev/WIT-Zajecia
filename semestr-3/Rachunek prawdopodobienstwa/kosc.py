from random import randint

def fun():
    return sum([1 if randint(1,6)==6 else 0 for i in range(5)]) == 3
    
n = 10000000
x = sum([1 if fun() else 0 for i in range(n)])

print(x/n)