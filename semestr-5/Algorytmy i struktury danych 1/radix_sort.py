
def radix_sort(tab):
    if len(tab) == 0:
        return tab
    exp = 1
    # powtarzamy tak długo dopóki pozycja cyfry znaczącej jest mniejsza od maksymalnej
    while exp <= max(tab):
        buckets = [[] for i in range(10)]
        for i in range(len(tab)):
            # dzielimy elementy na kontenery
            buckets[(tab[i] // exp) % 10].append(tab[i])
        tab = []
        
        for bucket in buckets:
            print(bucket)
        
        for bucket in buckets:
            # łączę elementy z kontenerem
            tab.extend(bucket)
        exp *= 10
        
        print(tab)
    return tab

tab = [111,25,477,2,15,414,316,212,87,915,56,345,341,118,517,539,324,64,436,122,717,191,592,496,697]

n = len(tab)
tab = radix_sort(tab)

print(tab)
assert len(tab) == n