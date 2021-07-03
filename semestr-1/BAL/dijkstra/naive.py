from math import inf

graph = [
    [0, 6, 3, 4, 1],
    [6, 0, 1, inf, inf],
    [3, 1, 0, 2, 1],
    [4, inf, 2, 0, 3],
    [1, inf, 1, 2, 0]
]

N = len(graph)
known = set()
costs = [inf for i in range(N)]
paths = [None for i in range(N)]
paths[0] = -1

current = 0
current_cost = 0

costs = [x if x>0 else inf for x in graph[current]]

cost, current = min([(costs[i], i) for i in range(N) if i not in known])

current_cost += cost
known.add(current)

x = graph[current]

cost, current = min([(x[i], i) for i in range(N) if i not in known])

print(current)