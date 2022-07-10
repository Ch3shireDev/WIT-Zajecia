from random import random

N = 10000000
n = 0

for i in range(N):
    x, y = random()*3, random()*9

    if x**3+1 > y and x**2 < y:
        n += 1
        
total_area = 3*9
area = n/N*total_area

print(f"Pole powierzchni: {area}")