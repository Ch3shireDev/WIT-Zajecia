Jeżeli chcemy wykonać kilka poleceń naraz to należy oddzielić je średnikami.

Jeżeli polecenie nie mieści się w jednej linijce to należy użyć backslashu i zacząć pisać polecenie w kolejnej linijce.


- `exit / logout` - polecenie to służy do zamknięcia sesji ssh
- `clear` - polecenie to służy do wyczyszczenia okna terminala
- `date` - polecenie to służy do wyświetlenia aktualnej daty oraz czasu systemowego
- `who` - polecenie to służy do wyświetlenia aktualnie pracujących użytkowników 
- `whoami` - polecenie to wyświetla nazwę konta, na którym w danym momencie pracujemy
- `who am i` - polecenie to wyświetla listę aktualnie otwartych połączeń ssh
- `stty` - polecenie to umożliwia wyświetlenie parametrów pracy terminala
- `-a` - parametr ten wyświetla wszystkie ustawienia terminala
- `stat` - polecenie to wyświetla podstawowe informacje o pliku lub katalogu
- `ls` - polecenie to wyświetla zawartość bieżącego katalogu
- `ls [(ścieżka do katalogu)]` - polecenie to wyświetla zawartość danego katalogu
	- `-a` - parametr ten umożliwia wyświetlenie ukrytych plików w folderze
	- `-l` - parametr ten umożliwia wyświetlenie atrybutów plików w folderze w postaci listy (w niektórych systemach jest specjalnie utworzony alias ll)
	- `-F` - zaznacza pliki za pomocą specjalnych symboli (/ - nazwę katalogu, * - plik z programem binarnym, @ - dowiązania symboliczne)
	- `-s` - parametr ten umożliwia wyświetlenie rozmiaru plików i katalogów w KB
	- `-ld` - parametr ten umożliwia wyświetlenie informacji na temat danego katalogu
	- `-R` - polecenie to umożliwia wyświetlenie zawartości katalogu oraz zawartości podkatalogów
	- `-xd` - polecenie to umożliwia wyświetlenie zawartości katalogu i wypisanie jej alfabetycznie wierszami
	- `-lt` - parametr ten umożliwia wyświetlenie plików i posortowanie ich według daty ostatniego dostępu zaczynając od tych ostatnio odczytanych
	- `-ltr` - parametr ten umożliwia wyświetlenie plików i posortowanie ich według daty ostatniego dostępu zaczynając od tych najdawniej odczytanych
	- `-- sort=(parametr)` - parametr ten umożliwia posortowanie wyniku polecenia i posortowanie go według danego parametru (dostępne parametry: none, time, size, extension, version)
- `passwd` - polecenie to umożliwia zmianę hasła bieżącego użytkownika
- `passwd (nazwa użytkownika)` - polecenie to umożliwia zmianę hasła dowolnego użytkownika


- `uname` - polecenie to umożliwia wyświetlenie informacji na temat bieżącego systemu operacyjnego
	- `-a` - parametr ten umożliwia wyświetlenie szczegółowych informacji na temat bieżącego systemu operacyjnego
- `grep (nazwa użytkownika) /etc/passwd` - polecenie to umożliwia wyświetlenie informacji na temat użytkownika
- `finger` - polecenie to wyświetla wszystkich użytkowników aktualnie zalogowanych do systemu
- `finger (nazwa użytkownika)` - polecenie to wyświetla informacje na temat użytkownika oraz wszystkie terminale, na których jest zalogowany
	- `-m` - parametr ten umożliwia wyświetlenie nazwy shella, na którym dany użytkownik pracuje
- `man (polecenie)` - polecenie to wyświetla informacje na temat danego polecenia
- `id` - polecenie to wyświetla podstawowe informacje na temat użytkownika
- `write (nazwa użytkownika) [nazwa terminala]` - polecenie to umożliwia wysłanie wiadomości do innego aktualnie zalogowanego użytkownika
- `mesg [y/n]` - polecenie to umożliwia wyświetlenie aktualnego stanu przyjmowania wiadomości jak i również jego modyfikację (y - przyjmowanie wiadomości, n- odrzucanie wiadomości)
- `wall (treść wiadomości)` - polecenie to umożliwia wysłanie wiadomości do wszystkich użytkowników z konta administratora
- `echo (treść)` - polecenie to wyświetla w terminalu wprowadzoną treść
- `pwd` - polecenie to wyświetla aktualny katalog
- `cd (folder)` - polecenie to zmienia bieżącą lokalizację do tej wskazanej
- `cd ..` - polecenie to zmienia bieżącą lokalizację o piętro wyżej
- `mkdir (nazwa katalogu)` - polecenie tworzy nowy katalog w bieżącym katalogu
- `mkdir (ścieżka)/(nazwa katalogu)` - polecenie tworzy nowy katalog w podanej ścieżce
- `-p` - parametr ten umożliwia tworzenie hierarchii katalogów w przypadku podania ścieżki składającej się z kilku folderów
- `Rmdir (nazwa katalogu)` - polecenie usuwa dany katalog
- `rmdir (ścieżka)/(nazwa katalogu)` - polecenie usuwa katalog w podanej ścieżce
- `W przypadku gdy katalog nie jest pusty należy użyć polecenia rm` -r
- `file (nazwa pliku)` - polecenie to umożliwia wyświetlenie typu danych znajdujących się w pliku
- `cat` - polecenie to wyświetla zawartość pliku
	- `	-v` - parametr ten umożliwia wyświetlenie znaków ukrytych (bez TAB i NEWLINE)
	- `	-t` - parametr ten umożliwia wyświetlenie znaków tabulacji w postaci ^I
	- `	-e` - parametr ten umożliwia wyświetlenie znaków końca wiersza w postaci $
	- `	-n` - parametr ten umożliwia wyświetlenie numerów wierszy
	- `	-b` - parametr ten umożliwia wyświetlenie numerów wierszy z pominięciem pustych
- `more (nazwa pliku)` - polecenie to wyświetla zawartość pliku strona po stronie
- `head` -(liczba wierszy) (nazwa pliku) - polecenie to umożliwia wyświetlenie n pierwszych wierszy
- `tail` -(liczba wierszy) (nazwa pliku) - polecenie to umożliwia wyświetlenie n ostatnich wierszy
- `cp (ścieżka źródłowa) (ścieżka docelowa)` - polecenie to kopiuje plik z jednej lokalizacji do drugiej
	- `-i` - parametr ten sprawia, że system żąda potwierdzenia od użytkownika czy ten chce na pewno skopiować dany plik
	- `	-r` - parametr ten umożliwia kopiowanie katalogów z podkatalogami
	- `mv (ścieżka źródłowa) (ścieżka docelowa)` - polecenie to przenosi plik
	- `-b` - parametr ten sprawia, że system tworzy kopie w przypadku istnienia pliku w lokalizacji docelowej
	- `-i` - parametr ten sprawia, że system żąda potwierdzenia od użytkownika czy ten chce na pewno przenieść dany plik
	- `-f` - parametr ten sprawia, że system pomija żądanie potwierdzenia 
	- `rm (nazwa pliku)` - polecenie to usuwa plik
	- `-r` - parametr ten sprawia, że system usuwa katalog oraz wszystkie pliki i podkatalogi w nim zawarte
	- `-i` - parametr ten sprawia, że system żąda potwierdzenia od użytkownika czy ten chce na pewno usunąć dany plik
	- `-f` - parametr ten sprawia, że system pomija żądanie potwierdzenia 
- `ln (ścieżka do pliku) (nazwa linku)` - polecenie to tworzy link do pliku
	- `-s` - parametr ten tworzy link symboliczny (należy podać ścieżki bezwzględne!)
- `touch (nazwa pliku)` - polecenie to tworzy pusty plik, lub modyfikuje datę modyfikacji już istniejącego
	- `-t (rok)(miesiąc)(dzień)(godzina)(minuta) (bez spacji numerycznie)` - parametr ten umożliwia modyfikacje daty ostatniego użycia pliku na wskazaną przez nas
	- `--date='rok-miesąc-dzień godzina:minuta'`- parametr ten umożliwia modyfikacje daty ostatniego użycia pliku na wskazaną przez użytkownika
	- `-r (plik 1) (plik 2)` - parametr ten umożliwia modyfikacje daty ostatniego użycia pliku 2 na taką jak w pliku 1
- `chmod u+/-/=rwx g+/-/=rwx o+/-/=rwx (plik/katalog)` - polecenie to służy do zmiany uprawnień do pliku lub folderu (zapis literami)
- `chmod (liczba)(liczba)(liczba) (plik/katalog)` - polecenie to służy do zmiany uprawnień do pliku lub folderu (zapis cyframi)
	- `a+-=rwx` - parametr ten daje/zabiera/ustawia takie same uprawnienia dla użytkownika, grupy i innych
	- `-R` - parametr ten zmienia uprawnienia nie tylko do folderu, ale i do zawartości

## Uprawnienia

- `umask (liczba)(liczba)(liczba) (plik/katalog)` - polecenie to zmienia domyślne wartości uprawnień do plików i katalogów w taki sposób, że dla plików odejmuje wprowadzoną wartość od 666 a dla folderów od 777
- `chown (nazwa użytkownika) (plik/katalog)` - polecenie to służy do zmiany właściciela danego pliku lub katalogu
	- `-R` - parametr ten zmienia właściciela nie tylko folderu, ale i zawartości
- `chgrp (nazwa grupy) (plik/katalog)` - polecenie to służy do zmiany grupy właścicielskiej danego pliku lub katalogu
	- `-R` - parametr ten zmienia grupę właścicielską nie tylko folderu, ale i zawartości
- `groups` - polecenie to wyświetla grupy, do których należy bieżący użytkownik
- `su (nazwa użytkownika)` - polecenie to umożliwia nam na przelogowanie się na konto innego użytkownika w terminalu (użycie - zamiast nazwy użytkownika przeloguje nas na konto root)
- `newgrp (nazwa grupy)` - polecenie to zmienia domyślną grupę bieżącego użytkownika (wydanie polecenia bez nazwy przywróci grupę do domyślnej)
- `vi (ścieżka do pliku)` - polecenie to uruchamia plik w edytorze vi

- `(nazwa zmiennej)=(wartość zmiennej)` - polecenie to tworzy zmienną o danej nazwie i danej wartości
- `export (nazwa zmiennej)` - polecenie to zmienia typ zmiennej na środowiskowy (dostępny w każdym shellu)
- `set` - polecenie to wyświetla wszystkie zmienne
- `env` - polecenie to wyświetla zmienne środowiskowe
- `echo $(nazwa zmiennej)` - polecenie to wyświetla wartość zmiennej
- `whereis` - polecenie to umożliwia znalezienie ścieżki do polecenia
	- `-b` - parametr ten umożliwia wyszukanie programów binarnych
	- `-m` - parametr ten umożliwia wyszukanie stron podręcznika
	- `-s` - parametr ten umożliwia wyszukanie kodów źródłowych
- `PS1=’(symbol gotowości)’` - polecenie to umożliwia zmianę symbolu gotowości shella

Meta znaki używane do generowania nazw plików:



Przykłady zastosowania:



Meta znaki przeadresowania:

- `set` -o noclobber - polecenie to umożliwia zmianę ustawienia noclobber na włączone. Jeżeli opcja ta jest włączona to meta znaki przeadresowania nie będą w stanie zmodyfikować plików wyjściowych w przypadku, jeżeli istnieją
- `set +o noclobber` - polecenie to umożliwia zmianę ustawienia noclobber na wyłączone

Można zmodyfikować ustawienia opcji noclobber poprzez dopisanie do meta znaku przeadresowania symbol | np. 2>|.
- `Wyście jednego polecenia można przekierować do wejścia drugiego za pośrednictwem symbolu | np. ls` -l | lp

W systemach linux zostały zaimplementowane następujące znaki cytowania:
- `\` - usuwa specjalne znaczenie wszystkich znaków
- `‘` - usuwa specjalne znaczenie wszystkich znaków
- `„` - usuwa specjalne znaczenie wszystkich znaków oprócz \ „” $ `
- `alias (nazwa) =”(komenda)”` - polecenie to tworzy nowy alias o danej nazwie (aby był zdefiniowany na stałe należy go dopisać do pliku .bash_profile pod sekcją #bash_profile). Jeżeli alias podmienia jakieś wbudowane lub zewnętrzne polecenie to można je wywołać tak aby działało w domyślny sposób poprzedzając je znakiem \ (zewnętrzne) lub „” (wbudowane)
- `alias` - polecenie to wyświetla listę wszystkich zdefiniowanych aliasów
- `unalias (nazwa)` - polecenie to usuwa dany alias
- `wc (nazwa pliku)` - polecenie to umożliwia zliczenie wierszy, słów oraz znaków w danym pliku
	- `	-c` - parametr ten umożliwia zliczenie znaków
	- `	-w` - parametr ten umożliwia zliczenie słów
	- `	-l` - parametr ten umożliwia zliczenie wierszy
- `sort` - polecenie to umożliwia posortowanie wyniku polecenia według zadanych parametrów
	- `	-t (znak)` - parametr ten umożliwia zdefiniowanie znaku separatora pól
	- `-k (numer pola)` - parametr ten umożliwia zdefiniowanie numeru pola, po którym wynik polecenia ma zostać posortowany 
- `tr (napis 1) (napis 2)` - polecenie to kopiuje standardowe wejście na standardowe wyjście dokonując zmiany lub usunięcia znaków
- `napis 1` - lista znaków poszukiwanych w strumieniu wejściowym
- `napis 2` - lista znaków, którymi należy zastąpić znalezione znaki
	- `-d` - parametr ten umożliwia usunięcie znaków zawartych w napisie 1
	- `-s` - parametr ten umożliwia usunięcie powtórzeń znaków

- `cut` - polecenie to służy do wycinania określonej części pliku. Polecenie to czyta plik jak tabelę, gdzie pojedynczym polem jest każdy symbol.
	- `-f (lista)` - parametr ten służy do zdefiniowania pól, które mają zostać wycięte z pliku np. 1-6
	- `-c (lista)` - parametr ten służy do zdefiniowania kolumn, które mają zostać wycięte z pliku np. 1-6
	- `-d (znak)` - parametr ten służy do zmiany znaku rozdzielającego pola
- `uniq (nazwa pliku wejściowego) (nazwa pliku wyjściowego)` - polecenie to służy do usuwania identycznych wierszy z pliku
	- `-c` - parametr ten umożliwia wyświetlenie przed wierszem ilości identycznych wierszy
	- `-d` - parametr ten umożliwia wyświetlanie po jednym wierszu (ignorowanie wierszy identycznych)
	- `	- u` - parametr ten umożliwia zignorowanie identycznych wierszy
	- `	-u` - parametr ten umożliwia wyświetlenie wierszy, które się nie powtarzają
	- `	-(liczba)` - parametr ten umożliwia zignorowanie określonej liczby pól
	- `	+(liczba)` - parametr ten umożliwia zignorowanie określonej liczby znaków

- `join (plik1) (plik2)` - polecenie to wyświetla część wspólną dwóch plików
- `nl (plik)` - polecenie to umożliwia wyświetlenie zawartości pliku numerując każdy wiersz
	- `-v (liczba)` - parametr ten umożliwia ustawienie początkowego indeksu numerowania na dowolną wartość 
	- `	-i (liczba)` - parametr ten umożliwia ustawienie różnicy pomiędzy kolejnymi indeksami
- `split` -(ilość wierszy) (plik wejściowy) (nazwa pliku wyjściowego) - polecenie to umożliwia podzielenie pliku wejściowego na fragmenty po n wierszy
- `grep ‘(wyrażenie regularne)’ [nazwa pliku]` - polecenie to umożliwia wierszy zawierających podany wzorzec
	- `-c` - parametr ten umożliwia wyświetlenie liczby wierszy zawierających podany wzorzec
	- `-v` - parametr ten umożliwia wyświetlenie wierszy, które nie odpowiadają podanemu wzorcowi
	- `-l` - parametr ten umożliwia wyświetlenie nazw plików, które zawierają wiersze z podanym wzorcem
- `-i` - parametr ten umożliwia ignorowanie wielkości liter
- `-n` - parametr ten umożliwia poprzedzenie każdego wiersza jego numerem w pliku
- `-s` - parametr ten umożliwia wyłączenie powiadomień o błędach (np. dostępu do pliku)

Rodzaje polecenia grep:
- `grep` - we wzorcu można umieścić podzbiór znaków używanych w wyrażeniach regularnych, szuka względnie szybko
- `egrep` - we wzorcu można umieścić każdy ze znaków używanych w wyrażeniach regularnych, szuka wolno
- `fgrep` - szybkie poszukiwanie wg stałego tekstu

Znaki specjalne używane w wyrażeniach regularnych polecenia grep:
- `^` - dopasuj do początku wiersza
- `$` - dopasuj do końca wiersza
- `[lista]` - dopasuj do jednego ze znaków listy w nawiasach
- `[^lista]` - dopasuj bez dowolnego znaku z listy w nawiasach
- `.` - dopasuj do dowolnego pojedynczego znaku
- `*` - powtórz jedno-znakowe wyrażenie regularne umieszczone przed znakiem gwiazdki 0 lub więcej razy 
- `.*` - powtórz dowolny znak 0 lub więcej razy
- `ps` - polecenie to wyświetla listę wszystkich procesów posiadających efektywny ID użytkownika wydającego polecenie 
- `-f` - parametr ten umożliwia wyświetlenie pełnej informacji o procesach
- `-u (nazwa użytkownika)` - parametr ten umożliwia wyświetlenie informacji o procesach danego użytkownika
- `-e` - parametr ten umożliwia wyświetlenie informacji o wszystkich procesach w systemie
- `-t` - parametr ten umożliwia wyświetlenie informacji o procesach związanych z danym terminalem
- `-l` - parametr ten umożliwia wyświetlenie szczegółowych informacji na temat procesów
- `kill [-s nazwa sygnału |` -numer sygnału] (numer procesu) - polecenie to umożliwia zakończenie danego procesu

Najczęściej używanymi sygnałami przerwania są:
- `15 (SIGTERM)` - przesłanie do procesu informacji, że ma się zakończyć. Proces może odrzucić sygnał i nie zakończyć się.
- `9 (SIGKILL)` - przesłanie do procesu informacji, że ma się zakończyć natychmiast. Proces nie może odrzucić tego sygnału.

Numery wszystkich sygnałów przerwania: https://students.mimuw.edu.pl/SO/LabLinux/PROCESY/PODTEMAT_3/sygnaly.html

Wykonywanie poleceń w tle (tworzenie zadań):

Aby wykonać polecenie w tle na jego końcu należy użyć znaku &.
- `jobs` - polecenie to wyświetla listę wszystkich zleconych zadań.

Zadanie może być:

- `at (godzina) [data] [+ przyrost] [skrypt]` - polecenie to umożliwia jednorazowe wykonanie danego polecenia lub skryptu. Pierwsze dwie cyfry oznaczają godzinę, kolejne dwie minutę np. 1234 - 12:34. Data powinna zostać zapisana w formacie dzień miesiąc rok. Można zastosować do tego tak jak w przypadku godziny format liczbowy, gdzie pierwsze dwie cyfry oznaczają dzień, dwie kolejne miesiąc a cztery ostatnie rok. Można również użyć zapisu słownego np. WED MAR 21. Istnieją również słowa specjalne takie jak dzień tygodnia (Monday, Tuesday itd..), jak i również słowa today, tomorrow. Można również użyć przyrostu np. +5 (minutes, hours, days, weeks, months, years).

## Cykliczne wykonywanie poleceń

W systemie linux może zostać uruchomiony określony daemon a mianowicie cron, który umożliwia wykonywanie poleceń cyklicznie.

Format pliku zleceń wygląda następująco:

1. Minuty (0-59)
2. Godziny (0-23)
3. Dni miesiąca (1-31)
4. Miesiące (1-12)
5. Dni tygodnia (0-6) (0 oznacza niedzielę)
6. Shell, który ma wykonać polecenie
7. Polecenie do wykonania

### Przykład

- `*` - zastępuje dowolną dopuszczalną wartość
- `Liczby podawane w jednym polu oddzielane są przecinkiem np. 20,45. Zakres definiowany jest z użyciem` - np. 1-5.
- `crontab (ścieżka do pliku)` - polecenie to umożliwia wykonanie zadań z wcześniej przygotowanego pliku
	- `-e` - parametr ten umożliwia edycję pliku z zadaniami
	- `-l` - parametr ten umożliwia wyświetlenie zaplanowanych zadań
	- `-r` - parametr ten umożliwia usunięcie zaplanowanych zadań
- `df/bdf` - polecenie to umożliwia wyświetlenie informacji na temat miejsca na dysku 
- `find (katalog początkowy) (kryterium wyszukiwania) (zadanie do wykonania w przypadku wystąpienia)` - polecenie to umożliwia przeszukanie systemu plików pod kątem zadanego parametru
- `-print` - parametr ten umożliwia wyświetlenie wszystkich znalezionych wystąpień
- `-name (nazwa pliku)` - parametr ten umożliwia wyszukanie wszystkich plików o zadanej nazwie
- `-type (typ pliku)` - parametr ten umożliwia wyszukanie wszystkich plików o zadanym typie
	- `f` - zwykły plik 
	- `d` - katalog 
	- `c` - plik urządzenia znakowego 
	- `b` - plik urządzenia blokowego
- `-user (nazwa użytkownika)` - parametr ten umożliwia wyszukanie określonego użytkownika w systemie
- `-group (nazwa grupy)` -parametr ten umożliwia wyszukanie określonej grupy w systemie
- `-perm (uprawnienia)` - parametr ten umożliwia wyszukanie określonych uprawnień w systemie (zapis uprawnień ósemkowo)
- `-atime +/-(liczba dni)` - parametr ten umożliwia wyświetlenie plików, których data ostatniego dostępu była mniejsza lub większa niż określona liczba dni 
- `-mtime +/-(liczba dni)` - parametr ten umożliwia wyświetlenie plików, których data ostatniej modyfikacji była mniejsza lub większa niż określona liczba dni 
- `-ctime +/-(liczba dni)` - parametr ten umożliwia wyświetlenie plików, których data ostatniej zmiany statusu (zmiana uprawnień) była mniejsza lub większa niż określona liczba dni 
- `-size +/-(ilość bloków 512 bajtowych)` - parametr ten umożliwia wyświetlenie plików, których rozmiar jest większy lub mniejszy niż wprowadzona wartość.


- `tar` - polecenie to umożliwia utworzenie nowego archiwum
	- `-c` - parametr ten umożliwia utworzenie nowego archiwum
	- `-u` - parametr ten umożliwia zaktualizowanie istniejącego archiwum (pliki nie są nadpisywane a dopisywane do archiwum)
	- `-r` - parametr ten umożliwia dodanie danego pliku do istniejącego archiwum na jego końcu
	- `-x` - parametr ten umożliwia wyjęcie plików z archiwum
	- `-t` - parametr ten umożliwia wyświetlenie zawartości archiwum
	- `-f` - parametr ten umożliwia określenie nazwy archiwum
	- `-v` - parametr ten umożliwia wyświetlanie bieżącego statusu archiwizacji

### Przykłady użycia
- `tar cf model.tar ~/*.f ` - utwórz archiwum wszystkich plików z rozszerzeniem *.f z katalogu osobistego i umieść w pliku model
- `tar tf model.tar` - wyświetl całą zawartość archiwum model
- `tar xvf model.tar` - odtwórz całą zawartość archiwum

- `cpio` - polecenie to umożliwia utworzenie nowego archiwum
	- `-o` - parametr ten umożliwia czytanie nazw pliku ze standardowego wejścia i dodawanie ich do archiwum
	- `-i (wzorzec)` - parametr ten umożliwia czytanie nazw pliku ze standardowego wejścia i dodawanie ich do archiwum, jeżeli odpowiadają one określonemu wzorcowi
	- `-p (katalog)` - parametr ten umożliwia czytanie nazw pliku ze standardowego wejścia i dodawanie ich do katalogu w archiwum
	- `-v` - parametr ten umożliwia wyświetlanie bieżącego statusu archiwizacji
	- `	-t` - parametr ten umożliwia wyświetlenie zawartości archiwum
	- `	-d` - parametr ten umożliwia tworzenie katalogów w archiwum, gdy jest to konieczne

### Przykłady użycia
- `ls ~/*.f | cpio` -o > model.cpio
- ` cpio` -i dane.f < model.cpio
- ` find .` -name '*.f' -print | cpio -pd program


- `compress (nazwa pliku)` - polecenie to umożliwia kompresję danego pliku
	- `	-v` - parametr ten umożliwia wyświetlanie stopnia kompresji
- `decompress (nazwa pliku)` - polecenie to umożliwia dekompresję danego pliku







