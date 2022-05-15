from random import randint
import numpy as np
from pprint import pprint


def load_matrix(filename):
    """
    Loads a matrix from a file.
    """
    with open(filename, 'r') as f:
        lines = f.readlines()
    matrix = []
    for line in lines:
        matrix.append([int(x) for x in line.split()])

    matrix = [row for row in matrix if len(row) > 0]
    return matrix


def f(image, i, j):
    if i >= len(image):
        i = i - len(image)
    if j >= len(image[0]):
        j = j - len(image[0])
    if i < 0:
        i = len(image) + i
    if j < 0:
        j = len(image[0]) + j
    return image[i][j]


def mult(aa, bb):
    new_image = []
    n = len(bb)
    for i in range(len(bb)):
        new_image.append([])
        for j in range(len(bb[i])):
            new_image[i].append(0)
    summ = sum([sum(row) for row in aa])
    for i in range(n):
        for j in range(n):
            tab = [0]*(n**2)
            for k in range(n**2):
                tab[k] = aa[k//n][k % n]*f(bb, i+k//n-n//2, j+k % n-n//2)
            qprim = sum(tab)/summ
            # qprim = max(0, qprim)
            # qprim = min(255, qprim)
            new_image[i][j] = qprim
    return new_image


def get_arr(n):
    return [[randint(0, 255) for i in range(n)] for i in range(n)]


lo_pass = load_matrix('./lab03_resources/LoPass3x3.txt')
hi_pass = load_matrix('./lab03_resources/HiPass3x3.txt')

arr = get_arr(5)

# lo_pass * (hi_pass * arr)
x = np.array(mult(lo_pass, mult(hi_pass, arr)))

# (lo_pass * hi_pass) * arr
y = np.array(mult(mult(lo_pass, hi_pass), arr))

print(x)
print(y)
print(x-y)


z = np.array([[-1, -2, -3, -2, -1],
              [-2, 5, 3, 5, -2],
              [-3, 3, 1, 3, -3],
              [-2, 5, 3, 5, -2],
              [-1, -2, -3, -2, -1]
              ])/10.0

print(z)
print(x-mult(z, arr))

print(mult(hi_pass, lo_pass))