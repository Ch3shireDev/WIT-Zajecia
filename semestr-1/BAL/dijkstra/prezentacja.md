# Algorytm Dijkstry

Dane studenta i miniprojektu: 
- numer albumu studenta 
- numer grupy zajęciowej 
- numer miniprojektu 
- termin oddania raportu 

## Przedstawienie problemu

1. Przedstawienie problemu (zadania). Należy podać treść zadania. 

Mamy N punktów połączonych M krawędziami o ustalonych (nieujemnych) wagach - możemy myśleć o sieci miast połączonych drogami, z których każda ma ustalony czas przejazdu. Poszukujemy najniższego możliwego kosztu przejścia z jednego punktu do drugiego - w naszej analogii najkrótszego czasu by dostać się z miasta A do miasta B. Ponieważ zarówno miast jak i dróg jest sporo, staramy się zoptymalizować ten problem tak, by nie zajął nam zbyt sporo czasu.

Formalnie, zadanie polega na znalezieniu połączenia o najniższej wartości pomiędzy dwoma węzłami grafu nieskierowanego. Ów graf będziemy reprezentowali jako macierz symetryczną N x N, gdzie węzły są reprezentowane przez kolejne numery kolumn i wierszy, natomiast koszt połączenia między i-tym i j-tym miastem są reprezentowane jako wartości na przecięciach i-tej kolumny i j-tego wiersza. 

## Opis słowny algorytmu

Należy opisać w sposób ogólny zasadę działania naszego algorytmu, ewentualnie uzupełnić o zapis w pseudokodzie. 


Dany jest graf ważony krawędziowo (o nieujemnych wagach), reprezentowany przez macierz kwadratową. Przykładowo, poniższy graf (rysunek po lewej) będzie reprezentowany przez macierz (rysunek po prawej). 

![](./i00.png) ![](./i02.png)

Węzłom A, B, C, D, E odpowiadają indeksy odpowiednio od 1 do 5, w macierzy wartość w i-tej kolumnie i j-tym wierszu odpowiada wadze połączenia między węzłami i oraz j. Brak połączenia jest reprezentowany jako wartość 0.

Stwórz funkcję `dijkstra(g, v1, v2)` która dla danego grafu `g` znajdzie połączenie o najniższej sumie wag pomiędzy parą wierzchołków o indeksach `v1` i `v2` implementując algorytm Dijkstry. Wynik będzie zwracany jako para elementów `lista, wagi`, gdzie `lista` jest listą indeksów wierzchołków optymalnej trasy, natomiast `wagi` to suma wag trasy.


## Schemat blokowy z omówieniem

Należy umieścić schemat blokowy, ewentualnie dopisać objaśnienia, jeśli miałyby ułatwić analizę schematu. 


## Symulacja działania algorytmu dla kilku przykładowych zestawów danych wejściowych

## Zapis algorytmu w języku SCILAB (ew. w innym uzgodnionym z prowadzącym języku programowania). 
## Oszacowanie złożoności

Należy oszacować funkcję według schematu: — rozmiar zadania, — operacja dominująca (elementarna), — funkcja złożoności czasowej, — rząd złożoności w najgorszym przypadku. W przypadku funkcji/procedury rekurencyjnej jako operację dominującą możemy przyjąć wywołanie funkcji/procedury. 

## Przedstawienie wykresu zależności czasu realizacji zadania od rozmiaru zadania.

Zależność tę przedstawiamy znajdujemy za pomocą: — "ręczne" liczenie kroków, — bezpośredni pomiar czasu realizacji algorytmu (instrukcje: tic, toc). Należy odnieść kształt wykresu do oszacowanej wcześniej funkcji złożoności czasowej. 

8. Podsumowanie raportu.

## Zarys działania

1. From each of the unvisited vertices, choose the vertex with the smallest distance and visit it.
2. Update the distance for each neighboring vertex, of the visited vertex, whose current distance is greater than its sum and the weight of the edge between them.
3. Repeat steps 1 and 2 until all the vertices are visited.


## Implementacja

```python
from collections import namedtuple, deque
from pprint import pprint as pp
 
 
inf = float('inf')
Edge = namedtuple('Edge', ['start', 'end', 'cost'])
 
class Graph():
    def __init__(self, edges):
        self.edges = [Edge(*edge) for edge in edges]
        # print(dir(self.edges[0]))
        self.vertices = {e.start for e in self.edges} | {e.end for e in self.edges}
 
    def dijkstra(self, source, dest):
        assert source in self.vertices
        dist = {vertex: inf for vertex in self.vertices}
        previous = {vertex: None for vertex in self.vertices}
        dist[source] = 0
        q = self.vertices.copy()
        neighbours = {vertex: set() for vertex in self.vertices}
        for start, end, cost in self.edges:
            neighbours[start].add((end, cost))
        #pp(neighbours)
 
        while q:
            # pp(q)
            u = min(q, key=lambda vertex: dist[vertex])
            q.remove(u)
            if dist[u] == inf or u == dest:
                break
            for v, cost in neighbours[u]:
                alt = dist[u] + cost
                if alt < dist[v]:                                  # Relax (u,v,a)
                    dist[v] = alt
                    previous[v] = u
        #pp(previous)
        s, u = deque(), dest
        while previous[u]:
            s.appendleft(u)
            u = previous[u]
        s.appendleft(u)
        return s
 
 
graph = Graph([("a", "b", 7),  ("a", "c", 9),  ("a", "f", 14), ("b", "c", 10),
               ("b", "d", 15), ("c", "d", 11), ("c", "f", 2),  ("d", "e", 6),
               ("e", "f", 9)])
pp(graph.dijkstra("a", "e"))
```

## Złożoność

## Podsumowanie