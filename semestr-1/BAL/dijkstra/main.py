from math import inf

def dijkstra(graph, start):
    n = len(graph)
    pozostale = set([i for i in range(n)])  #zbiór nieodwiedzonych węzłów
    poprzednicy = [None for i in range(n)] #lista poprzedzajacych węzłów
    koszty = [inf for i in range(n)] #lista kosztów dojścia do węzła
    koszty[start] = 0 #koszt dojścia do węzła startowego jest 0

    while len(pozostale) > 0:
        #znajdujemy wartość minimalną kosztów dla i spośród pozostałych
        #i zwracamy związany z nią indeks
        biezacy = min([(koszty[i], i) for i in pozostale])[1]
        #usuwamy bieżący indeks z listy nieodwiedzonych węzłów
        pozostale.remove(biezacy)
        #pobieramy listę dystansów z bieżącego węzła do sąsiadów
        dystans = graph[biezacy]
        for sasiad in range(n):
            #jeśli sąsiad został odwiedzony to zostawiamy go w spokoju
            #zerowy dystans do sąsiada oznacza brak połączenia

            if sasiad not in pozostale or dystans[sasiad] == 0:
                continue
            #nowa cena to bieżący koszt połączeń + koszt przejścia
            nowa_cena = koszty[biezacy] + dystans[sasiad]
            #jeśli nowa cena jest niższa, aktualizujemy koszty sąsiada
            if nowa_cena < koszty[sasiad]:
                poprzednicy[sasiad] = biezacy
                koszty[sasiad] = nowa_cena

    return koszty, poprzednicy

from random import randint
from timeit import timeit
import sys

num = 1000
N = 300
graph = [[randint(0,10) if i!=j else 0 for i in range(N)] for j in range(N)]
t = timeit('dijkstra(graph, 0)', setup="from __main__ import dijkstra, graph", number=num)/num
print(N,t)
