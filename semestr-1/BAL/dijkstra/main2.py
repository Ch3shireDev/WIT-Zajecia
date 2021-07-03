distances = {
    'S': {'A': 7, 'B': 2, 'C': 3},
    'A': {'S': 7, 'B': 3, 'D': 4},
    'B': {'S': 2, 'A': 3, 'D': 4, 'H': 1, 'C': 12},
    'C': {'S': 3, 'L': 2},
    'D': {'A': 4, 'B': 4, 'F': 5},
    'E': {'G': 2, 'K': 5},
    'F': {'D': 5, 'H': 3},
    'G': {'H': 2, 'I': 10, 'E': 2},
    'H': {'B': 1, 'F': 3, 'G': 2},
    'I': {'J': 6, 'K': 4, 'L': 4},
    'J': {'K': 4, 'L': 4},
    'K': {'I': 4, 'J': 4, 'E': 5},
    'L': {'C': 2, 'I': 4, 'J': 4}
}

import networkx as nx
import matplotlib.pyplot as plt

G=nx.Graph()
G.add_node("a")
G.add_nodes_from(["b","c"])

G.add_edge(1,2)
edge = ("d", "e")
G.add_edge(*edge)
edge = ("a", "b")
G.add_edge(*edge)

print("Nodes of graph: ")
print(G.nodes())
print("Edges of graph: ")
print(G.edges())

# adding a list of edges:
G.add_edges_from([("a","c"),("c","d"), ("a",1), (1,"d"), ("a",2)])

nx.draw(G)
plt.savefig("simple_path.png") # save as png
plt.show() # display
