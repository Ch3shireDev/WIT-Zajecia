tab = [1, 1, 7, 2, 5, 4, 6, 2, 7, 1, 6, 4,
       4, 8, 7, 3, 2, 6, 6, 2, 7, 1, 9, 6, 7 ]


def counting_sort(tab):
    if len(tab) == 0:
        return tab
    tmin = min(tab)
    tmax = max(tab)
    NC = tmax - tmin + 1
    counts = [0] * NC
    for i in range(len(tab)):
        counts[tab[i] - tmin] += 1
    for i in range(1, NC):
        counts[i] += counts[i - 1]
    wynik = [0] * len(tab)
    
    print(counts)
    for i in range(len(tab)):
        wynik[counts[tab[i] - tmin] - 1] = tab[i]
        counts[tab[i] - tmin] -= 1
    print(wynik)
    return wynik


counting_sort(tab)