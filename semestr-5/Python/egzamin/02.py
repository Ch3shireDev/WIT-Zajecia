# Pytanie 2 DziadekDzidek
# Napisz funkcję (45 punktów)
# dziadekDzidek('<tekst>')

# '<tekst>'          - parametr wywołania z planem drogi w postaci tekstu

# <psz>              parametr wywołania w postaci liczby

# typ wyniku funkcji     - boolean (True / False )


# Działanie funkcji:

#     Dziadek Dzidek wybrał się do lasu na grzyby. Babcia Dziunia dała mu plan drogi, żeby wrócił do domu.

#     Plan drogi jest tekstem, na który składają się:
#         wielkie litery, określające kierunek, w którym dziadek ma pójść:
#         'Z' - zawróć,
#         'L' - skręć w lewo o 90 stopni,
#         'P' - skręć w prawo o 90 stopni
#         liczby całkowite, określające liczbę kroków do wykonania

#     Znaki inne niż litery 'Z','L','P' oraz cyfry '0'..'9' mają być ignorowane.


def dziadekDzidek(tekst):
    # Zostawiamy tylko te elementy które wskazują drogę
    droga = ''.join([x for x in tekst if x in 'ZLP0123456789'])
    # Z jest tożsame z obrotem o 180 stopni
    droga = droga.replace('Z', 'PP')
    # oddzielamy przecinkami komendy
    droga = droga.replace('P', ',P,')
    droga = droga.replace('L', ',L,')
    # zostawiamy tylko pełne komendy, usuwamy puste
    droga = [x for x in droga.split(',') if x]
    # tworzymy lokalizację dziadka i kierunek
    pozycja_x, pozycja_y, kierunek = 0, 0, 0
    # idziemy krok po kroku za dziadkiem
    for komenda in droga:
        # jeśli skręcamy w lewo to ustalamy odpowiedni kierunek
        if komenda == 'L':
            kierunek += 90
        # jeśli skręcamy w prawo to ustalamy odpowiedni kierunek
        elif komenda == 'P':
            kierunek -= 90
        # w przeciwnym wypadku idziemy ustaloną liczbę kroków
        else:
            # aby uniknąć problem z ograniczonością int używam eval aby python policzył sobie liczbę i typ
            ruch = eval(komenda)
            # jeśli kierunek jest w prawo to idziemy w prawo
            if kierunek % 360 == 0:
                pozycja_x += ruch
            # jeśli kierunek jest do góry to idziemy do góry
            elif kierunek % 360 == 90:
                pozycja_y += ruch
            # jeśli kierunek jest w lewo to idziemy w lewo
            elif kierunek % 360 == 180:
                pozycja_x -= ruch
            # jeśli kierunek jest w dół to idziemy w dół
            elif kierunek % 360 == 270:
                pozycja_y -= ruch
    return pozycja_x == 0 and pozycja_y == 0



assert dziadekDzidek('20P20P20P20') == True
assert dziadekDzidek('20P20L20P20') == False
assert dziadekDzidek('20Z20') == True
assert dziadekDzidek('20Z10') == False
assert dziadekDzidek('100Z20P10Z10P80') == True
assert dziadekDzidek('1000000000000000000000000000000000Z1000000000000000000000000000000000') == True
assert dziadekDzidek('100000000000000000dasdasd0000000000000000Z1000000000adsasdasd000000000000000000000000') == True
assert dziadekDzidek('1000000000000000000000000000000000Z10000000000000000000000000000000001') == False
assert dziadekDzidek('1000000000000sadasdad000000000000000000000Z1000000000000asdadad0000000000000000000001') == False
assert dziadekDzidek('10LLLLL10L10L10') == True
assert dziadekDzidek('10PPPPPPLLZ10') == True

