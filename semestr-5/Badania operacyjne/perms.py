data = [(1,5,7),
        (2,11,30),
        (3,10,40),
        (4,1,10),
        (5,9,20),
        (6,7,25),
        (7,4,14),
        (8,9,55),
        (9,10,45),
        (10,8,34)
        ]


def calc(data):
    postponed = 0
    time = 0
    for i, p, d in data:
        time += p
        if time > d:
            print(i)
            postponed += 1
    return postponed

# from itertools import permutations

# min_v = 1000
# min_tab = None
# for tab in permutations(data):
#     x = calc(tab)
#     if x < min_v:
#         min_v = x
#         min_tab = tab
#         print(min_v, [i for i,j,k in min_tab])

data_opt = [
    (1,5,7),
    (4,1,10),
    (7,4,14),
    (6,7,25),
    (10,8,34),
    (3,10,40),
    (9,10,45),
    (8,9,55),
    (2,11,30),
    (5,9,20),
    ]

calc(data_opt)