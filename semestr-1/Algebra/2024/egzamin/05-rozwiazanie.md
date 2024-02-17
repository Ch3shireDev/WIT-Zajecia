# Zadanie 5

![Zadanie 5](./05.jpeg)

Dane są wektory:

$$\vec{v_1} = (1,2,3,3),$$
$$\vec{v_2} = (5,6,7,7),$$
$$\vec{v_3} = (3,4,5,5),$$
$$\vec{v_4} = (1,1,1,1),$$
$$\vec{v_5} = (x,0,3,3).$$

Pytanie jest następujące - czy możemy dobrać taką liczbę $x$, by istniały tylko dwa wektory niezależne? Najpierw zadajmy pytanie, czy wektory $\vec v_1 - \vec v_4$ są liniowo niezależne. Liniowa zależność (czyli możliwość konstrukcji jednego wektora z pozostałych) jest tożsama z zerowaniem się wyznacznika macierzy, której wierszami (bądź kolumnami) są wektory. Po wpisaniu do Wolframa Alpha uzyskujemy:

$$\det \begin{bmatrix} 
1 & 2 & 3 &3 \\ 
5 & 6 & 7 &7 \\
3 & 4 & 5 &5 \\ 
1 & 1 & 1 &1 \end{bmatrix} = 0.$$

Oznacza to, że wektory $\vec v_1 - \vec v_4$ są liniowo zależne, zatem istnieją co najwyżej trzy wektory liniowo niezależne wśród wektorów $\vec v_1 - \vec v_4$.

Zauważmy, że czwarta współrzędna jest we wszystkich przypadkach powieleniem trzeciej. Zatem moglibyśmy nasz przypadek zredukować do:

$$\vec{w_1} = (1,2,3),$$
$$\vec{w_2} = (5,6,7),$$
$$\vec{w_3} = (3,4,5),$$
$$\vec{w_4} = (1,1,1),$$
$$\vec{w_5} = (x,0,3).$$

Możemy zaobserwować, że wektor $\vec{w_3}$ jest sumą wektorów $\vec{w_1}$ oraz $\vec{w_2}$, podzieloną przez 2. Zatem redukujemy układ do:

$$\vec{w_1} = (1,2,3),$$
$$\vec{w_2} = (5,6,7),$$
$$\vec{w_4} = (1,1,1),$$
$$\vec{w_5} = (x,0,3).$$

Sprawdzamy, czy układ $\vec{w_1}, \vec{w_2}, \vec{w_4}$ jest liniowo niezależny. Wyznacznik macierzy:

$$\det \begin{bmatrix}
1 & 2 & 3 \\
5 & 6 & 7 \\
1 & 1 & 1 \end{bmatrix} = 0.$$

Zatem wektory są liniowo zależne. Istotnie, możemy zauważyć, że $\vec{w_1} + 4\vec{w_4} = \vec{w_2}$. Zatem zostawmy tylko wektory $\vec{w_1}$ oraz $\vec{w_4}$. Dorzućmy do nich wektor $\vec{w_5}$.

Głównym pytaniem jest, czy istnieje taka wartość $x$, by wektory $\vec{w_1}, \vec{w_4}, \vec{w_5}$ były liniowo zależne, tj. istniały tylko dwa liniowo niezależne. Już wiemy, że wektory będą liniowo zależne, jeśli macierz:

$$\det\begin{bmatrix}
1&2&3\\
1&1&1\\
x&0&3
\end{bmatrix} = 0$$

Prowadzi to do równania:

$$1\cdot1\cdot3 +2\cdot1\cdot x +3 \cdot  1\cdot0 - 1\cdot1\cdot 0 - 2\cdot 1 \cdot 3-3\cdot 1\cdot x = 0$$

$$ 3 + 2x -6 - 3x = 0$$

$$-3 -x = 0$$

$$ 3 + x = 0$$

Zatem $x = -3$.