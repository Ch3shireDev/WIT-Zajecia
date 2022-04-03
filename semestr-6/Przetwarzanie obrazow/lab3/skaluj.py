from matplotlib import pyplot as plt


def get_image(filename):
    with open(filename, 'r') as f:
        lines = f.readlines()
        numbers = [[int(x) for x in line.split()] for line in lines]
        f.close()
        return numbers


def f(image, i, j):
    if i >= len(image):
        i = 0
    if j >= len(image[0]):
        j = 0
    return image[i][j]


def smooth(image):
    new_image = []
    for i in range(len(image)):
        new_image.append([])
        for j in range(len(image[i])):
            new_image[i].append(0)
    for i in range(len(image)):
        for j in range(len(image[i])):
            a = f(image, i-1, j-1)
            b = f(image, i-1, j)
            c = f(image, i-1, j+1)
            d = f(image, i, j-1)
            e = 4*f(image, i, j)
            z = f(image, i, j+1)
            g = f(image, i+1, j-1)
            h = f(image, i+1, j)
            k = f(image, i+1, j+1)
            qprim = (a+b+c+d+e+z+g+h+k)/13
            new_image[i][j] = qprim
            qprim = max(0, qprim)
            qprim = min(255, qprim)
    return new_image

def sharpen(image):
    new_image = []
    for i in range(len(image)):
        new_image.append([])
        for j in range(len(image[i])):
            new_image[i].append(0)
    for i in range(len(image)):
        for j in range(len(image[i])):
            a = -f(image, i-1, j-1)
            b = -f(image, i-1, j)
            c = -f(image, i-1, j+1)
            d = -f(image, i, j-1)
            e = 9*f(image, i, j)
            z = -f(image, i, j+1)
            g = -f(image, i+1, j-1)
            h = -f(image, i+1, j)
            k = -f(image, i+1, j+1)
            qprim = (a+b+c+d+e+z+g+h+k)
            new_image[i][j] = qprim
            qprim = max(0, qprim)
            qprim = min(255, qprim)
    return new_image

def scale(image, n):
    new_image = []
    qmin = min([min(x) for x in image])
    qmax = max([max(x) for x in image])
    
    for i in range(len(image)):
        new_image.append([])
        for j in range(len(image[i])):
            new_image[i].append(0)
    for i in range(len(image)):
        for j in range(len(image[i])):
            q = image[i][j]
            qprim = (q - qmin)/(qmax - qmin)*(n-1)
            qprim = max(0, qprim)
            qprim = min(255, qprim)
            new_image[i][j] = qprim
    return new_image



image = get_image('obraz.txt')
image = sharpen(image)
image = scale(image, 2)

plt.imshow(image, interpolation='nearest')
plt.show()
