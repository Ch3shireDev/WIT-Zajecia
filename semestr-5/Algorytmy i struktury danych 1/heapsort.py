
def print_graph(tab):
    
    
    print("```dot")
    print('graph base_flow {')
    for i in range(1, len(tab)):
        print(f'{tab[(i-1)//2]} -- {tab[i]};')
    print('}')
    print("```")

def heapsort(tab):
    if len(tab) == 0:
        return tab

    # tworzymy strukturę drzewa binarnego z elementów tablicy
    # każdemu elementowi na i-tym indeksie poza 0 (pień główny) odpowiada jeden i dokładnie jeden element pnia
    # indeks pnia jest równy (i-1)//2 (dzielenie całkowite przez 2)

    output = []

    while len(tab) > 1:
        print_graph(tab)
        for i in range(1, len(tab)):
            # oblicz poziom pnia
            k = len(tab) - i
            r = (k-1)//2
            # jeśli liść jest większy od pnia, zamień je miejscami
            if tab[k] > tab[r]:
                print_graph(tab)
                print(f"Zamiana {tab[k]} z {tab[r]}")
                tab[k], tab[r] = tab[r], tab[k]
                print_graph(tab)

        output.append(tab[0])
        tab = tab[1:]
        
        print(output, tab)

    output += tab
    return output


tab = [11, 5, 7, 2, 15, 4, 6]


x = heapsort(tab)


