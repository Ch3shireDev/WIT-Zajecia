from scipy.special import binom

def factorial(n):
    if n==0:
        return 1
    return n*factorial(n-1)

def stirling(n, k):
    n1 = n
    k1 = k
    if n <= 0:
        return 1

    elif k <= 0:
        return 0

    elif (n == 0 and k == 0):
        return -1

    elif n != 0 and n == k:
        return 1

    elif n < k:
        return 0

    else:
        temp1 = stirling(n1-1, k1)
        temp1 = k1*temp1
        return (k1*(stirling(n1-1, k1)))+stirling(n1-1, k1-1)


def bell(n):
    return sum([stirling(n, k) for k in range(n+1)])


def P(n, k=None):
    if k is None:
        return sum([P(n, k) for k in range(1, n+1)])

    if n == 0 and k == 0:
        return 1
    if k <= 0:
        return 0
    if n < 0:
        return 0
    return P(n-1, k-1) + P(n-k, k)

