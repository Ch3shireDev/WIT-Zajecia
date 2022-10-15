import matplotlib.pyplot as plt
from matplotlib import image
from sys import argv

if len(argv) < 2:
    print("Nalezy podac nazwe pliku")
    exit()

filename = argv[1]

image = image.imread(filename)

# jeśli obrazek jest monochromatyczny, to ma tylko wymiary x,y
if len(image.shape) == 2:
    # biorę jeden kanał w tablicy
    images = [image]
# jeśli obrazek ma 3 kanały, to ma wymiary x, y, kanał
else:
    # biorę trzy kanały w tablicy
    images = [ image[:,:,0], image[:,:,1], image[:,:,2] ]

# wygeneruj wszystkie histogramy
for image in images:
    # zmien tablice z dwuwymiarowej na jednowymiarową
    x, y = image.shape
    image = image.reshape(x*y)

    plt.hist(image, 256)

# pokaż wszystkie histogramy na raz
plt.show()

# wygeneruj każdy histogram z osobna
for image in images:
    # zmien tablice z dwuwymiarowej na jednowymiarową
    x, y = image.shape
    image = image.reshape(x*y)

    plt.hist(image, 256)
    # pokaż wszystkie histogramy na raz
    plt.show()
