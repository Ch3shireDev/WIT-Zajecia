# Notatki

## Kolokwia

- 4 zajęcia (w formie testu)
    - prawa własności
    - poruszanie się po systemie

- wkrótce potem sprawdzian praktyczny
    - praktyczne problemy do rozwiązania

## Notatki

```
drwxrwxrwx 2 igor igor 4096 lis 20 00:03 xxx

- rodzaj obiektu: folder (d)/plik (-)/urządzenie (c)/gniazdo (s, socket)/ dowiązanie symboliczne (l, link)
- dostęp właściciela
- dostęp grupy
- dostęp wszystkich
- liczba dowiązań
- nazwa właściciela
- nazwa grupy
- data utworzenia
- nazwa pliku/katalogus

```

### Komendy

Polecenia shella (bash):
- `who` - kto jest zalogowany (szczegółowe dane)
- `whoami` - identyfikator użytkownika w systemie
- `date` - data systemowa
- `cat` - wypisywanie zawartości pliku
- `man` - manual, zawiera informacje o danym programie
- `info` - zestaw informacji
- `ls` - listowanie katalogu
- `ls -t` - listuje przesortowane po czasie
- `ls -C1 -t` - w jednej kolumnie (Columns 1)
- `ls -l` - wyświetla szczegółowe informacje (prawa dostępów, właściciel, rozmiar, data utworzenia, nazwa)
- `ls -R` - listuje rekurencyjnie
- `clear` - czyści zawartość terminala
- `history` - wyświetla przechowywane polecenia wykonane wcześniej
- `!<numer polecenia>` - wykonuje polecenie o danym numerze
- `!<część nazwy polecenia>` - wykonuje ostatnie polecenie o zadanym prefiksie
- `tree` - listowanie w postaci drzewa zadanego katalogu
- `tree -d` - listuje jedynie katalogi, bez plików
- `tree -L 2` - wyświetla nie więcej niż dwa poziomy zagłębienia

- `pwd` - (print working directory) zwraca bieżący katalog w którym znajduje się użytkownik
- `mkdir` - tworzy katalog o podanej ścieżce
- `mkdir -p` - brak błędu jeśli istnieje, tworzy również rodzime katalogi
- `rmdir` - usuwa katalog o podanej ścieżce
- `mc` - powłoka wizualna
- `touch` - tworzy ("dotyka") pusty plik o danej nazwie
- `cat > <nazwa pliku>` - 

### Laby 1

Struktura systemu:

1. Jądro
2. Biblioteki systemowe
3. Programy uzytkowe i biblioteki
4. Shell (dostęp użytkownika)


### Laby 2

Struktura plików Linuxa:

- `/`
    - `/bin` - user binaries
    - `/sbin` - system binaries
    - `/etc` - configuration files
    - `/dev` - device files
    - `/proc` - process information
    - `/var` - variable files
    - `/tmp` - temporary files
    - `/usr` - user programs
    - `/home` - home directories
    - `/boot` - boot loader files
    - `/lib` - system libraries
    - `/opt` - optional add-on apps
    - `/mnt` - mount directory
    - `/media` - removable devices
    - `/srv` - service data

### Laby 3

### Laby 4

## Literatura

Krotka lista źródeł przydatnych do laboratorium Sys. Op. 1, zima 2020-2021
Lista nie jest wyczerpująca ani obowiązkowa.
Piotr Koperski, 2020-10.

    - Polecenie systemowe: man, dostępne na każdej maszynie lnuksowej/uniksowej.
    - Polecenie systemowe: info, dostępne w każdym linuksie;
    - Uzupełniająca dokumentacja w lokalnym katalogu: /usr/share/doc

- Książka: "Ćwiczenia z systemu Linux", Leszek Madeja, wyd. Mikom, 1999: nie nowa, ale wystarczająca do nauki podstaw, dostępna w bibliotece WIT;

- Książka: "Unix, narzędzia do programowania powłok, Dawid Medinets", wyd. PLJ,
1999: prezentuje szczegółowo techniki programowania w shellu bash, a także
w języku perl i w języku Tcl, solidna i wiele wyjaśnia, ale to pozycja raczej 
dla lubiących zgłebiać tajemnice; powinna być w uczelnianej bibliotece.

- Książka: "Administracja i eksploatacja systemow komputerowych...", część 2,
z serii podręcznik do nauki zawodu Technik Informatyk, wydawnictwo WSiP :
wypatrzyłem zupełnie niedawno taką pozycję- zawiera popdstawy linuksa + administracji systemem linuksowym (jak widać linuks skutecznie trafił "pod strzechy").

- Portale internetowe (kilka spośród wielu) prezentujące artykuły "użytkowe":
    - https://www.thegeekstuff.com
    - Tecmint
    - LinuxTechi

- Najnowsze informacje o dystrybucjach linuksa (pomocne m.in. przy wyborze tego,
co zainstalować): https://distrowatch.com

- Artykuł wprowadzający (NIE wyczerpujący tematu!) z przykładami użycia poleceń:
https://www.linuxjournal.com/content/linux-command-line-interface-introduction-guide

- ... (i tak dalej)
