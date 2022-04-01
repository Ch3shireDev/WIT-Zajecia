from random import randint

def counting_sort(tab):
    tab_min = min(tab)
    tab_max = max(tab)
    
    counts = [0] * (tab_max - tab_min + 1)
    
    for x in tab:
        counts[x - tab_min] += 1
        
    for i in range(1, len(counts)):
        counts[i] += counts[i-1]
        
    output = [0] * len(tab)
    
    for i in range(len(tab)-1, -1, -1):
        output[counts[tab[i] - tab_min]-1] = tab[i]
        counts[tab[i]- tab_min] -= 1
        
    return output


tab = [randint(-9, 99) for _ in range(200)]

output = counting_sort(tab)

print(output)
assert output == sorted(tab)