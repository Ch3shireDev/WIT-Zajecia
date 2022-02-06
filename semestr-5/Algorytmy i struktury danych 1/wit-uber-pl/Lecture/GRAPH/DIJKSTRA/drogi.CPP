//Program: dsp.cpp
//Autor: Megh Thakkar
//Cel: Implementacja C++ grafu wa¿onego
//           i algorytmu najkrótszej œcie¿ki Dijkstra.
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <iostream.h>

class graph {
    private:
        int adj_matrix[100][100];
//przechowuje koszt wejœcia u¿ytkownika
        int shortest_path_matrix[100][100];
//przechowuje najkrótsz¹ drogê pomiêdzy wêz³ami

    public:
          graph (int size) { }
          ~graph( ) { }
          void setup_matrix(int num_nodes);
int find_cost_of_shortest_path(int source, int destination);
          void init_adj_matrix(int num_nodes);
          void init_shortest_path_matrix(int num_nodes);
          void load_adj_matrix(int num_nodes);
          void load_shortest_path_matrix( int num_nodes);
};

int graph::find_cost_of_shortest_path(int source, int destination)
{
        int result;

    //najk_droga_mac zawiera policzone
    //najkrótsze drogi pomiêdzy ró¿nymi wêz³ami.

        result = shortest_path_matrix[source][destination];

        return(result);
}

void graph::setup_matrix(int num_nodes)
{
    init_adj_matrix(num_nodes);
//inicjalizujemy macierz s¹siednich elementów zerami
    load_adj_matrix(num_nodes);
    init_shortest_path_matrix(num_nodes);
    load_shortest_path_matrix(num_nodes);
}

void graph::init_adj_matrix(int num_nodes)
{
    int i, j;
    for ( i = 1; i <= num_nodes; i++)
        for ( j = 1; j <= num_nodes; j++)
            adj_matrix[i][j] = 0;
}

void graph::init_shortest_path_matrix(int num_nodes)
{
//Macierz najkrótszej drogi jest zainicjalizowana
//do macierzy s¹siednich elementów
    int i, j;
    for ( i = 1; i <= num_nodes; i++)
        for ( j = 1; j <= num_nodes; j++)
            shortest_path_matrix[i][j] = adj_matrix[i][j];

}

void graph::load_adj_matrix(int num_nodes)
{
    int i, j;
    int cost;
    char direct[1];
    const int LARGE_COST = 999999;

    for ( i = 1; i <= num_nodes; i++)
    {
        for ( j = 1; j <= num_nodes; j++)
        {
//Macierz s¹siednich elementów jest ³adowana jako zdefiniowana przez u¿ytkownika
        cout << "Is there a direct path from Node "
<< i << " to Node " << j << "? : ";
        cin >> direct;

        if ( ( direct[0] == 'y' ) || (direct[0] == 'Y'))
            {
          cout << "Enter the cost of the path from Node "
 << i << " to Node " << j << " : ";
            cin >> cost;

            cout << "\n";

            adj_matrix[i][j] = cost;
            }
         else
            adj_matrix[i][j] = LARGE_COST;
// bardzo du¿y koszt
        }
    }

}

void graph::load_shortest_path_matrix( int num_nodes)
{
    int i, j, k;
    const int LARGE_COST = 999999;

    for ( j = 1; j <= num_nodes; j++)
    {
        for ( i = 1; i <= num_nodes; i++)
        {
             for (k = 1; k <= num_nodes; k++)
             {
             if ( (shortest_path_matrix[j, k] > 0 ) )
             {
///Je¿eli istnieje jakaœ œcie¿ka, która jest
//ni¿ œcie¿ka znaleziona do tej pory
//to nowa œcie¿ka staje siê
//najkrótsz¹ pomiêdzy dwoma wêz³ami.
    if  ( (shortest_path_matrix[j][k] == LARGE_COST) ||
                   (shortest_path_matrix[i][j] + shortest_path_matrix[j][k]
                   < shortest_path_matrix[i][k]))
            shortest_path_matrix[i][k] = shortest_path_matrix[i][j] + shortest_path_matrix[j][k];
             }

             }
        }
    }
}

int main(void)
{
    int num_nodes;
    int source;
    int destination;
    int scost;

cout << "Enter the number of nodes in the graph (less than 100):  ";
    cin >> num_nodes;

    if ( num_nodes > 100 )
    {
        cout << " Sorry. This program has a limitation of only 100 nodes ";
        cout << "\n\n\n";
        exit (-1);
    }

    graph graph_obj(num_nodes);
    graph_obj.setup_matrix(num_nodes);

    cout << " Enter the node id of the source node: ";
    cin >> source;
    if (source > num_nodes)
    {
        cout << " Invalid source! ";

        cout << "\n\n\n";

    }

    cout << " Enter the node id of the destination node: ";
    cin >> destination;
    if (destination > num_nodes)
    {
        cout << " Invalid destination! ";

        cout << "\n\n\n";

    }

    scost = graph_obj.find_cost_of_shortest_path(source, destination);

    cout << "Shortest path between Node " << source
         << " and Node " << destination
<< " has a cost of " << scost;

    cout << "\n\n\n";
    return 0;
    getch();
}
