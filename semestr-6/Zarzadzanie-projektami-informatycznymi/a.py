import time

n = 100000
primes = []

def is_prime(primes, x):
    if x<2:
        return False
    for p in primes:
        if x%p == 0:
            return False
    return True

t0 = time.time()

for i in range(2, n):
    if not is_prime(primes, i):
        continue
    primes.append(i)

t1 =time.time()

print(t1-t0)