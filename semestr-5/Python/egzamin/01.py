# deckOfCards
# Napisz funkcję (25 punktów)
# karty(<'lista_kolorow'>)
# <'lista_kolorow'> - parametr typu tekst zawierający listę CZTERECH nazw kolorów kart
# typ wyniku funkcji     Python List
# która będzie generowała potasowaną talię kart.
# Działanie funkcji:
#     Zadaniem programu jest wygenerowanie talii kart, potasowanych losowo (w kolejności losowej).
#     Potasowane karty mają być przedstawione w postaci listy ich symboli.
#     Symbole kart mają być przedstawione w formacie "kolor(karta)".
#     >kolor< - reprezentuje jedną z nazw kolorów, przekazanych w parametrze
#     >karta< - reprezentacja wartości karty: {2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A }
#     odpowiednio dla (numerów (2 .. 10), Jack, Queen, King, Ace)
# Przykład wywołania funkcji:
# print (karty('wiosna,lato,jesien,zima') )
# ['jesien(J)','wiosna(A)','wiosna(6)','lato(A)','zima(2)','lato(J)','zima(9)','jesien(2)','wiosna(3)','jesien(4)','jesien(9)','lato(3)','zima(Q)','zima(A)','wiosna(2)','lato(5)','wiosna(5)','zima(10)','lato(K)','jesien(10) ','zima(4)','zima(K)','zima(7)','jesien(6)','jesien(A)','jesien(8)','zima(8)','wiosna(9)','zima(6)','jesien(Q)','lato(Q)','jesien(3)','zima(J)','lato(2)','wiosna(4)','lato(10)','wiosna(K)','C(5)','lato(9)','wiosna(10)','wiosna(8)','lato(8)','lato(7)','wiosna(J)','wiosna(Q)','lato(4)','jesien(5)','jesien(7)','zima(3)','lato(6)','wiosna(7)','jesien(K)']

# UWAGA:

# Proponowane jest wykorzystanie podstawowej biblioteki random, która jest dostępna w pakiecie podstawowym dystrybucji Python’a.  Sprawdzian dotyczy wiedzy i umiejętności uzyskanych wyłącznie w zakresie materiału przerabianego podczas ćwiczeń w Szkole. Zadanie musi być rozwiązane wyłącznie przy pomocy bazowego Pythona, bez importowania żadnych "ciekawych i użytecznych" bibliotek oraz stosowania "hakerskich sztuczek".

# Wprowadź odpowiedź

from random import shuffle

def shuffled(tab):
    shuffle(tab)
    return tab

def karty(lista_kolorow):
    return shuffled([f'{kolor}({karta})' for karta in list(range(2, 11)) + ['J', 'Q', 'K', 'A'] for kolor in lista_kolorow.split(',')])

for karta in karty('wiosna,lato,jesien,zima'):
    print(karta)


assert len(karty('wiosna,lato,jesien,zima')) == 52