# Miniprojekt - implementacja algorytmu Dijkstry

Dany jest graf ważony krawędziowo (o nieujemnych wagach), reprezentowany przez macierz kwadratową. Przykładowo, poniższy graf (rysunek po lewej) będzie reprezentowany przez macierz (rysunek po prawej). 

![](./i00.png) ![](./i02.png)

Węzłom A, B, C, D, E odpowiadają indeksy odpowiednio od 1 do 5, w macierzy wartość w i-tej kolumnie i j-tym wierszu odpowiada wadze połączenia między węzłami i oraz j. Brak połączenia jest reprezentowany jako wartość 0.

Stwórz funkcję `dijkstra(g, v1, v2)` która dla danego grafu `g` znajdzie połączenie o najniższej sumie wag pomiędzy parą wierzchołków o indeksach `v1` i `v2` implementując algorytm Dijkstry. Wynik będzie zwracany jako para elementów `lista, wagi`, gdzie `lista` jest listą indeksów wierzchołków optymalnej trasy, natomiast `wagi` to suma wag trasy.