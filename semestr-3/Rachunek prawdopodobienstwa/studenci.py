from random import random

f= lambda : sum([1 if random() < 0.1 else 0 for i in range(6)]) > 1

n= 100000
s = sum([1 if f() else 0 for i in range(n)])

print(s/n)