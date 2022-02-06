tab = [11, 5, 7, 2, 15, 4, 6, 12, 87, 15, 6, 45, 41,
       18, 17, 39, 24, 64, 36, 22, 17, 91, 92, 96, 97]

def partitioning(tab, left, right):
    # wybieramy środkowy element jako nasz pivot
    pivot = tab[(left + right) // 2]
    print("pivot:",pivot)
    # powtarzamy tak długo dopóki indeks lewej strony jest mniejszy bądź równy od prawej
    while left < right:
        # zawiększ indeks lewej strony tak długo, dopóki element odpowiadajacy 
        # indeksowi lewej strony jest mniejszy od pivotu
        while tab[left] < pivot:
            left += 1
        # zrób analogicznie z prawej strony, tym razem zmienjszając tak długo dopóki jest większy od pivotu
        while tab[right] > pivot:
            right -= 1
            
        # kiedy masz już indeksy lewej i prawej strony, zamien elementy miejscami, a następnie zwiększ
        # indeks lewej strony o 1 a indeks prawej strony zmniejsz o 1. 
        # Jeśli indeks lewej strony jest większy lub równy indeksowi prawej strony, zakończ działanie.
        
        if left <= right:
            print(tab[left], tab[right])
            print("zamiana:", tab)
            tab[left], tab[right] = tab[right], tab[left]
            print("po zamianie:", tab)
            left += 1
            right -= 1
            
    print(tab)
    return left


partitioning(tab, 0, len(tab) - 1)