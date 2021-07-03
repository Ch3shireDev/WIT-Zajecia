import matplotlib.pyplot as plt
import numpy as np

data = np.loadtxt("data.txt").T

x = np.arange(0,500)
z = (x/5500)**2*np.log(x)
    
plt.plot(data[0],data[1], 'ro-')

plt.plot(x,z)

plt.legend(["Czas wykonania programu","Krzywa $f(x)=x^2\log x$" ])
plt.xlabel("Liczba węzłów")
plt.ylabel("Czas wykonania (s)")
plt.title(
    "Czas wykonywania implementacji algorytmu Dijkstry")
plt.show()