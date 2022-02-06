def bubble_sort(tab):
    if len(tab) == 0:
        return tab
    swapped = True
    for i in range(len(tab) - 1):
        swapped = False
        for j in range(len(tab) - i - 1):
            if tab[j] > tab[j + 1]:
                tab[j], tab[j + 1] = tab[j + 1], tab[j]
                swapped = True
            print(i,j, tab)
        if not swapped:
            break
    return tab


tab = [11,5,7,2,15,4,6,12,87,36,22,17,91,92,96,97]

bubble_sort(tab)
