from random import shuffle, randint


def bubble_sort(tab):
    swap_count = 0
    compare_count = 0
    for _ in range(len(tab)):
        for j in range(len(tab)-1):
            compare_count += 1
            if tab[j] > tab[j+1]:
                tab[j], tab[j+1] = tab[j+1], tab[j]
                swap_count += 1
    return tab, swap_count, compare_count


def bubble_sort_smart(tab):
    swap_count = 0
    compare_count = 0
    for _ in range(len(tab)):
        flag = True
        for j in range(len(tab)-1):
            compare_count += 1
            if tab[j] > tab[j+1]:
                flag = False
                tab[j], tab[j+1] = tab[j+1], tab[j]
                swap_count += 1
        if flag:
            break
    return tab, swap_count, compare_count


def insertion_sort(tab):
    swap_count = 0
    compare_count = 0
    for i in range(1, len(tab)):
        for j in range(0, i):
            compare_count += 1
            if tab[i-j] < tab[i-j-1]:
                tab[i-j], tab[i-j-1] = tab[i-j-1], tab[i-j]
                swap_count += 1
            else:
                break
    return tab, swap_count, compare_count


def get_tab(n=1000, m=2000):
    tab = [randint(1, m) for _ in range(n)]
    return tab


N = 100
TAB_SIZE = 1000

tab = get_tab(TAB_SIZE)
for i in range(N):
    shuffle(tab)

bubble_data = {'fun': bubble_sort, 'name': 'bubble_sort',
               'total_swaps': 0, 'total_compares': 0}
bubble_smart_data = {'fun': bubble_sort_smart, 'name': 'bubble_sort_smart',
               'total_swaps': 0, 'total_compares': 0}
insertion_data ={'fun': insertion_sort, 'name': 'insertion_sort',
               'total_swaps': 0, 'total_compares': 0}

for i in range(N):
    
    shuffle(tab)
    
    for data in [bubble_data, bubble_smart_data, insertion_data]:
        tab2 = tab.copy()
        func = data['fun']
        _, swaps, compares = func(tab2)
        data['total_swaps'] += swaps
        data['total_compares'] += compares
    
for data in [bubble_data, bubble_smart_data, insertion_data]:

    name = data['name']
    swaps_total = data['total_swaps']
    compares_total = data['total_compares']

    print(f"function name: {name}")
    print(f"mean number of swaps: {swaps_total / N}")
    print(f"mean number of compares: {compares_total / N}")
    print()
