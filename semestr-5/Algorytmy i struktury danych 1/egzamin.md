ASD Niestacjonarne Egzamin Nazwisko i imię: Grupa: WSISiZ 2022.02.05

0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,T: 11,5,7,2,15,4,6,12,87,15,6,45,41,18,17,39,24,64,36,22,17,91,92,96,97,

# Zadanie 0.

Weryfikacja ćwiczeń.

Proszę zaproponować algorytm znajdujący amplitudę wartości w tablicy i wykonać go dla poniższej tablicy.

```
11,5,7,2,15,4,6,12,87,15,6,45,41,18,17,39,24,64,36,22,17,91,92,96,97,
```

```c++
int amplituda(int *tab, int n){
    if(n==0)return 0;
    int max = tab[0];
    int min = tab[0];
    for(int i=0;i<n;i++){
        if(tab[i]>max)max=tab[i];
        if(tab[i]<min)min=tab[i];
    }
    return max - min;
}
```

```python
def amplituda(tab):
    if len(tab) == 0:
        return 0
    return max(tab) - min(tab)
```

Wynik: 95.

## Zadania 0 - 55 p.

### Zadanie 1\. 20 p.

Proszę wykonać CountingSort dla poniższej tablicy.

```
1,1,7,2,5,4,6,2,7,1,6,4,4,8,7,3,2,6,6,2,7,1,9,6,7,
```

```c++
int* counting_sort(int *tab, int n){
    // jeśli dostajemy pustą tablicę, zwracamy pustą tablicę.
    if(n == 0)return tab;
    // ustalanie przedziału tablicy
    int min = tab[0];
    int max = tab[0];
    for(int i=0;i<n;i++){
        if(tab[i]>max)max=tab[i];
        if(tab[i]<min)min=tab[i];
    }

    // tworzenie tablicy zliczeń
    int NC = max-min+1;
    int *counts = new int[NC];
    for(int i=0;i<NC;i++){
        counts[i] = 0;
    }

    // zliczanie elementów
    for(int i=0;i<n;i++){
        counts[tab[i]-min]++;
    }

    // sumowanie wystąpień elementów mniejszych lub równych niż
    for(int i=1;i<NC;i++){
        counts[i] += counts[i-1];
    }

    // wypełnianie tablicy wynikowej
    int *wynik = new int[n];

    for(int i=0;i<n;i++){
        int count = counts[tab[n-i-1]];
        wynik[count - 1] = T[n-i-1];
        counts[tab[n-i-1]] -= 1;
    }

    return wynik;
}
```

```python
def counting_sort(tab):
    if len(tab) == 0:
        return tab
    tmin = min(tab)
    tmax = max(tab)
    NC = max - min + 1
    counts = [0] * NC
    for i in range(len(tab)):
        counts[tab[i] - tmin] += 1
    for i in range(1, NC):
        counts[i] += counts[i - 1]
    wynik = [0] * len(tab)

    for i in range(len(tab)):
        wynik[counts[tab[i] - tmin] - 1] = tab[i]
        counts[tab[i] - tmin] -= 1

    return wynik
```

### Zadanie 2\. 20 p.

Proszę wykonać SelectionSort dla poniższej tablicy.

```
11,5,7,2,15,4,6,12,87,36,22,17,91,92,96,97,
```

```c++
void selection_sort(int *tab, int n){
    if(n==0)return;
    for(int j=0;j<n-1;j++){
        // znajduje najmniejszy element spośród podanych
        int min_index = j;
        for(int i=j+1;i<n;i++){
            if(tab[i]<tab[min_index]) min_index = i;
        }
        // zamienia miejscami najmniejszy element z elementem z indeksem j
        int x = tab[j];
        tab[j] = tab[min_index];
        tab[min_index] = x;
    }
}
```

```python
def selection_sort(tab):
    if len(tab) == 0:
        return tab
    for i in range(len(tab)):
        min_index = i
        for j in range(i, len(tab)):
            if tab[j] < tab[min_index]:
                min_index = j
        tab[i], tab[min_index] = tab[min_index], tab[i]
    return tab
```

### Zadanie 3\. 25 p.

Proszę wykonać InsertionSort dla poniższej tablicy.

```
11,5,7,2,15,4,6,12,87,36,22,17,91,92,96,97,
```

```cpp
void insertion_sort(int *tab, int n){
    if(n==0)return;
    // powtarzam co następuje dla wszystkich elementów poza indeksem 0
    for(int i=1;i<n;i++){
        int x = tab[i];
        // jeśli poprzednie elementy są większe, 
        // to przesuwam je na kolejne miejsca w tablicy
        int j = i - 1;
        while(j>0 && tab[j]>x){
            tab[j] = tab[j-1];
            j--;
        }
        // na końcu wrzucam ten element na odpowiednie miejsce
        tab[j+1] = x;
    }
}
```

```python
def insertion_sort(tab):
    if len(tab) == 0:
        return tab
    for i in range(1, len(tab)):
        x = tab[i]
        j = i - 1
        while j >= 0 and tab[j] > x:
            tab[j + 1] = tab[j]
            j -= 1
        tab[j + 1] = x
    return tab
```

### Zadanie 4\. 10 p. Proszę wykonać BubbleSort dla poniższej tablicy.

```
11,5,7,2,15,4,6,12,87,36,22,17,91,92,96,97
```

```cpp
void bubble_sort(int *tab, int n){
    if(n==0)return;
    // zmienna pomocnicza
    bool swapped = true;
    // powtarzam co następuje dla wszystkich elementów poza indeksem 0
    for(int i=0;i<n-1 && swapped;i++){
        swapped = false;
        // jeśli poprzednie elementy są większe, 
        // to przesuwam je na kolejne miejsca w tablicy
        for(int j=0;j<n-i-1;j++){
            if(tab[j]>tab[j+1]){
                int x = tab[j];
                tab[j] = tab[j+1];
                tab[j+1] = x;
                swapped = true;
            }
        }
        if(!swapped) break;
    }
}
```

```python
def bubble_sort(tab):
    if len(tab) == 0:
        return tab
    swapped = True
    for i in range(len(tab) - 1):
        swapped = False
        for j in range(len(tab) - i - 1):
            if tab[j] > tab[j + 1]:
                tab[j], tab[j + 1] = tab[j + 1], tab[j]
                swapped = True
        if not swapped:
            break
    return tab
```

### Zadanie 5\. 15 p. Proszę wykonać RadixSort dla poniższej tablicy.

```
111,25,477,2,15,414,316,212,87,915,56,345,341,118,517,539,324,64,436,122,717,191,592,496,697,
```

```python
# tutaj się poddałem z implementacją w c++, bo musiałbym implementować dodatkowe struktury danych

def radix_sort(tab):
    if len(tab) == 0:
        return tab
    exp = 10
    # powtarzamy tak długo dopóki pozycja cyfry znaczącej jest mniejsza od maksymalnej
    while exp <= max(tab):
        buckets = [[] for i in range(10)]
        for i in range(len(tab)):
            # dzielimy elementy na kontenery
            buckets[(tab[i] // exp) % 10].append(tab[i])
        tab = []
        for bucket in buckets:
            # łączę elementy z kontenerem
            tab.extend(bucket)
        exp *= 10
    return tab
}
```

## Zadania 76 - 100 p.

### Zadanie 6\. 15 p. Proszę wykonać HeapSort dla poniższej tablicy.

```
11,5,7,2,15,4,6,
```

```python
def heapsort(tab):
    if len(tab) == 0:
        return tab

    # tworzymy strukturę drzewa binarnego z elementów tablicy
    # każdemu elementowi na i-tym indeksie poza 0 (root) odpowiada jeden i dokładnie jeden element pnia
    # indeks pnia jest równy (i-1)//2 (dzielenie całkowite przez 2)

    output = []

    while len(tab) > 1:
        for i in range(1, len(tab)):
            # oblicz poziom pnia
            k = len(tab) - i
            r = (k-1)//2
            # jeśli liść jest większy od pnia, zamień je miejscami
            if tab[k] > tab[r]:
                tab[k], tab[r] = tab[r], tab[k]

        output.append(tab[0])
        tab = tab[1:]

    return output
```


### Zadanie 7\. 15 p. Proszę wykonać Partitioning dla poniższej tablicy.

```
11,5,7,2,15,4,6,12,87,15,6,45,41,18,17,39,24,64,36,22,17,91,92,96,97,
```

