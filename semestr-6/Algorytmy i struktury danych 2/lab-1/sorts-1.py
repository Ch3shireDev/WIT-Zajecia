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


def get_tab(filename):
    with open(filename, 'r') as f:
        tab = f.readlines()
        tab = [int(x.strip()) for x in tab]
        f.close()
        
    return tab

for fun, name in [(bubble_sort, 'bubble_sort'), (bubble_sort_smart, 'bubble_sort_smart'), (insertion_sort, 'insertion_sort')]:
    tab = get_tab('Sort_0001.csv')
    tab2, swap_count, compare_count = fun(tab)
    print(f"function name: {name}")
    print(f"swaps: {swap_count}")
    print(f"compares: {compare_count}")
    print(f"output: {tab2}")
    print()