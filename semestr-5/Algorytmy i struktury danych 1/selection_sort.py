
def selection_sort(tab):
    if len(tab) == 0:
        return tab
    for i in range(len(tab)):
        min_index = i
        for j in range(i, len(tab)):
            if tab[j] < tab[min_index]:
                min_index = j
        tab[i], tab[min_index] = tab[min_index], tab[i]
        
        print(min_index, tab)
    return tab


tab = [11,5,7,2,15,4,6,12,87,36,22,17,91,92,96,97]

selection_sort(tab)