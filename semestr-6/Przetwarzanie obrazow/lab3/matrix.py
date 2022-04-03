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
        i = 0
    if j >= len(image[0]):
        j = 0
    if i < 0:
        i = len(image) - 1
    if j < 0:
        j = len(image[0]) -1
    return image[i][j]


def mult(aa, bb):
    new_image = []
    for i in range(len(bb)):
        new_image.append([])
        for j in range(len(bb[i])):
            new_image[i].append(0)
    summ = sum([sum(row) for row in aa])
    for i in range(len(bb)):
        for j in range(len(bb[i])):
            a = aa[0][0]*f(bb, i-1, j-1)
            b = aa[0][1]*f(bb, i-1, j-0)
            c = aa[0][2]*f(bb, i-1, j+1)
            d = aa[1][0]*f(bb, i-0, j-1)
            e = aa[1][1]*f(bb, i-0, j-0)
            z = aa[1][2]*f(bb, i-0, j+1)
            g = aa[2][0]*f(bb, i+1, j-1)
            h = aa[2][1]*f(bb, i+1, j-0)
            k = aa[2][2]*f(bb, i+1, j+1)
            qprim = (a+b+c+d+e+z+g+h+k)/summ
            new_image[i][j] = qprim
            qprim = max(0, qprim)
            qprim = min(255, qprim)
    return new_image


lo_pass = load_matrix('./lab03_resources/LoPass3x3.txt')
hi_pass = load_matrix('./lab03_resources/HiPass3x3.txt')

pprint(lo_pass)
pprint(hi_pass)

arr = [[1,1,1,1,1],[1,1,1,1,1],[1,1,1,1,1],[1,1,1,1,1],[1,1,1,1,1],]

a = mult(hi_pass, arr)
b = mult(lo_pass, a)

pprint(b)
