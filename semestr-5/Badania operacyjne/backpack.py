from itertools import permutations

data = [
    (1, 40, 50),
    (2, 20, 30),
    (3, 30, 40),
    (4, 10, 60),
    (5, 15, 50)
]

def gain(data):
    time = 50
    points = 0
    res = []
    for x,y,z in data:
        if y>time:
            continue
        time -= y
        points += z
        res.append(x)
    return points, res

max_gain = 0
max_res = []

for tab in permutations(data):
    g, res = gain(tab)
    if g > max_gain:
        max_gain, max_res = g, res
        print(max_gain, max_res)