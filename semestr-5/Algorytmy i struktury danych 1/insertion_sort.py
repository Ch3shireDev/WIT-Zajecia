
def insertion_sort(tab):
    if len(tab) == 0:
        return tab
    for i in range(1, len(tab)):
        x = tab[i]
        j = i - 1
        while j >= 0 and tab[j] > x:
            tab[j + 1] = tab[j]
            j -= 1
        tab[j + 1] = x
        
        print(i, tab)
    return tab


tab = [11,5,7,2,15,4,6,12,87,36,22,17,91,92,96,97]

insertion_sort(tab)