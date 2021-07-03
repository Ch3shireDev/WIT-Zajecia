from random import random

def fun():
    return sum([1 if random() <= 0.9 else 0 for i in range(104)]) > 100


tab = []
while True:
    n = 10000

    x = sum([1 if fun() else 0 for i in range(n)])/n
    tab.append(x)
    print(sum(tab)/len(tab))