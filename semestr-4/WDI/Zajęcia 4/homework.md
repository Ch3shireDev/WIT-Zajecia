# Praca domowa

## php cz. 1

1. Proszę o dodanie do formularza logowania automatycznego blokowania konta po nieudanych 3 próbach logowania (metoda dowolna).
2. Proszę o zahaszowaniehasła użytkownika w bazie danych przy pomocy algorytmu `bcrypt`. 
a. Do haszowania służy funkcja `password_hash()`

    https://www.php.net/manual/en/function.password-hash.php

b. Do weryfikacji poprawności wprowadzonego hasła należy wykorzystać funkcję `password_verify()`

    https://www.php.net/manual/en/function.password-verify.php

## php cz. 2

1. Proszę o uzupełnienie formularza dodawania samochodu (oraz obsługę w kodzie PHP) polami:
    a.Pojemność (pole tekstowe),
    b.liczba poduszek (lista rozwijalna z wartościami 1, 2, 4, 6, 8),
    c.abs (pole typu radio),
    d.esp (pole typu radio)

2. Proszę o wykonanie analogicznej czynności w formularzu edycji samochodu (należy pamiętać o poprawnym przepisaniu/zaznaczeniu wartości w polach formularza).
3. Proszę o dodanie potwierdzenia (np. w Javascript) przed operacją usunięcia rekordu.

## ajax

1. Proszę ukryć przycisk "Pobierz samochody" po kliknięciu w niego i wygenerowaniu tabeli HTML.
2. Proszę zmodyfikować funkcję `pokazSzczegoly()` tak, by szczegóły samochodu (wszystkie pozostałe kolumny tabeli samochod) zostały wyświetlone w prawej kolumniekontenera (element o ID szczegoly)
