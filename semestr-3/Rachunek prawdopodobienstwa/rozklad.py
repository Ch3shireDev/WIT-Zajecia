import matplotlib.pyplot as plt

names = ['2', '3', '4', '5']
values = [0.15, 0.55, 0.1, 0.2]
sums = [sum(values[:i]) for i in range(1, 5)]

plt.bar(names, values)
plt.suptitle("Wykres prawdopodobieństw ocen ze sprawdzianu")
plt.xlabel("Ocena")
plt.ylabel("Prawdopodobieństwo")
plt.savefig('oceny.png')

plt.bar(names, sums)
plt.suptitle("Wykres dystrybuanty ocen ze sprawdzianu")
plt.xlabel("Ocena")
plt.ylabel("Dystrybuanta")
plt.savefig('oceny-dyst.png')

    