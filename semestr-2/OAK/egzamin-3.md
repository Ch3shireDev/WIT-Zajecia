### Zadanie 1

Które opisy charakteryzują architekturę typu RISC a ktore CISC

- obszerna lista instrukcji
- duza liczba rejestrow GP
- mala liczba instrukcji
- stala dlugosc intrukcji
- zroznicowana dlugosc instrukcji

### Zadanie 2

Przeprowadź konwersje liczb z jednego systemu do drugiego:

- `1284_dec` = `hex`
- `65_dec` = `u2`
- `7D4C_hex` = `nkb`
- `10011001_u2` = `dec`

### Zadanie 3

zawartosc kolejnych komorek (bajtow) pamieci o adresach od 1000h do 1003h przechowujacych liczbe 6F457C8Ah zapisana w little-endian
adres

- 1000h=
- 1001h=
- 1002h=
- 1003h=

### Zadanie 4

oblicz srednie CPI dla procesora ktorego lista instrukcji ma nastepujaca charakterystyke

- instrukcje arytmetyczne wystepuja z czesto. 38%
- CPI instrukcji aryt = 1
- instrukcje przeslan wystepuja z czest 45%
- cpi instr przeslan = 2
- CPI pozostalych instrukcji = 2,4

CPI procesora=

### Zadanie 5

zaloz, ze w procesorze o charaktresystyce popdanej w zad 4 (poprzednim) dokonano ulepszenia ktore spowodowalo zmniejszenie CPI instrukcji przeslan z 2 do wartosci rownej 1,4.
Oblicz wspolczynnikj wzrostu wydajnosci procesora spowodowany tym ulepszeniem. zastosoj prawo amdahla. ile wynosi parametr frac_enh

frac_enh=
speedup=

### Zadanie 6

rozwaz system komputerowy o nastepujacej charakterystyce podsystemu pamieci

- pamiec operacyjna jest adresowana 32bit i ma pojemnosc 2^32
- pamiec cache ma pojemnosc 16kb
- linijka ma rozmiar 32 bajtow
- zastosowano odwzorowanie bezposrednie

oblicz nastepujace parametry tego systemu

- liczba bitow znacznika w pamieci cache =
- liczba rfoznych linijek z pamieci operacyjnej odwzorowanych na te sama linijke w cache=
- laczna liczba bitow w linijce=

### Zadanie 7

pewien procesor ma 5-stopniowy potok instrukcji. czasy realizacji zadań w kolejnych stopniach potoku podane w ps sa nastepujace 60, 50, 80, 70, 70.
Na wyjsciu kazdego stopnia potoku znajduje sie rejestr (bufor) o czasie propagacji rownym 20 ps. Oblicz czas kompletowania instrukcji w potoku (lattencu)
oraz jego przepustowosc (throughpuit) w GOPS

lattency = ps

throughput = GOPS

### Zadanie 8

Ponizej podano cztery przykladowe sekwencje instrukcji w jezyku asemblera x86. Zbadaj czy wystepuja w nich hazardy, a jesli tak to jakiego typu
Oznacz odpowiednie hazardy skrotami RAW, WAR lub WAW. W przypadku braku hazardu postaw znam minus

```
a) mov cx,[bx]
add ax,cx

b) mov dx, cx
mov ax,bx

c) mov bx,67a4h
add bx,cx

d) mov ax,1075
mov ds,ax
```

### Zadanie 9

Okresl typy adresowania ktorych uzyto w nastepujacych instrukcjach ase mblera x86 do wskazania drugiego z argumentow (source)
Zastosuj nastepujace skroty

- R - rejestrowy
- N - natychmiastowy
- D - bezposredni
- PR - posredni rejestrony
- BI - bazowo-indeksowy
- RW - rejestrowy wzgledny

- a) mov ax,var1
- b) mov ax,[si+400]
- c) mov ax,dx
- d) mov ax,[bx]
- e) mov ax,300h

### Zadanie 10

zalozmy, ze rejestr segmentu DS procesora Pentium zawiera liczbe 604Ch

- a) okresl fizyczny adres uzyty do zaadresowania drugiego argumentu w instrukcji `mov ah,[bx]` jesli rejestr BX zawiera liczbe 21D7h i jest wlaczony tryb adresow rzeczywistych x86 (real-address mode)
  adres fizyczne= h
- b) okresl fizyczny adres uzyty do zaadresowania drugiego argumentu w instrukcji `mov ah,[30FF4125h]` jesli deskryptor segmentu wskazywany przez DS w polu adresu b azowegog zaweiera liczbe 220011A6h i jest wlaczona standardowa segmentacja
  adres fizyczny = h
