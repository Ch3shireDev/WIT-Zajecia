# Specyfikacja wymagań dla projektu Samochody ciężarowe, wersja 0.0.7

## Autor: Igor Nowicki

## 1\. Opis systemu

System służy do przechowywania definicji pojazdów ciężarowych i ich zespołów, wraz z informacjami o załadunku. Przewidziana jest możliwość przechowywania pojazdów różnego rodzaju (samochody z przestrzenią ładunkową, ciągniki siodłowe, przyczepy, naczepy), z różnego rodzaju przestrzeniami ładunkowymi (zdefiniowane jako skrzyniowa, kontenerowa, cysterna). Program przewiduje mechanizm przechowywania danych na temat pojazdu pomiędzy sesjami poprzez zapis i odczyt z i do pliku dyskowego w formacie JSON.

Program realizuje następujące działania:

- Logowanie i wylogowanie operatora
- Logowanie i wylogowanie administratora
- Wczytanie stanu systemu z repozytorium do pamięci
- Zapis stanu systemu z pamięci do repozytorium
- Wprowadzenie nowego pojazdu
- Skasowanie istniejącego pojazdu
- Zarządzanie pojazdami przez operatora:

  - dodawanie pojazdów
  - edycja pojazdów
  - usuwanie pojazdów
  - wyświetlanie danych o pojazdach
  - łączenie i rozłączanie pojazdów w zespoły pojazdów według zdefiniowanych zasad
  - ładunek i rozładunek pojazdów z przestrzenią ładunkową według zdefiniowanych zasad

- Zarządzanie operatorami przez administratora:

  - dodawanie operatorów
  - edycja operatorów
  - usuwanie operatorów
  - wyświetlanie danych o operatorach

## Słownik dziedziny problemu

- Pojazd (Vehicle) - abstrakcyjny obiekt określających dowolną jednostkę jeżdżącą.
- Pojazd silnikowy (Motorized Vehicle) - abstrakcyjny obiekt dziedziczący z Pojazdu, opisujący dowolny pojazd posiadający silnik.
- Pojazd bezsilnikowy (Non Motorized Vehicle) - abstrakcyjny obiekt dziedziczący z Pojazdu, opisujący dowolny pojazd nieposiadający silnika.
- Pojazd ładunkowy (Loadable) - abstrakcyjny pojazd posiadający możliwość przechowywania ładunku.
- Pojazd przyczepowy (Trailerable) - abstrakcyjny pojazd posiadający możliwość doczepienia przyczepy.
- Pojazd naczepowy (Semi-Trailerable) - abstrakcyjny pojazd posiadający możliwość doczepienia naczepy.
- Przyczepa (Trailer) - pojazd bezsilnikowy, ładunkowy, z możliwością bycia przyczepionym do pojazdu przyczepowego.
- Naczepa (SemiTrailer) - pojazd bezsilnikowy, ładunkowy, z możliwością bycia przyczepionym do pojazdu naczepowego.
- Ciągnik siodłowy (Truck) - pojazd silnikowy, naczepowy.
- Samochód ciężarowy (TrailerCar) - pojazd silnikowy, przyczepowy.
- Samochód z przestrzenią ładunkową (Cargo Space Car) - pojazd silnikowy, ładunkowy.
- Operator - użytkownik z możliwością zarządzania bazą danych pojazdów.
- Administrator - użytkownik z możliwością zarządzania bazą danych użytkowników.

### 2.1\. OBIEKTY BIZNESOWE

#### Pojazd (Vehicle)

Opis: Abstrakcyjny obiekt określających dowolną jednostkę jeżdżącą.

Każdy pojazd opisywany jest zestawem parametrów:

- Id (int) - Identyfikator (liczba całkowita dodatnia)
- Name (string) - Nazwa (tekst na podstawie pozycji katalogowej producenta)
- VIN (string) - Vehicle Identification Number (15 lub 17 znaków alfanumerycznych)
- Year - Rok produkcji (czterocyfrowa liczba całkowita w zakresie od roku 1900 do roku bieżącego)

#### Pojazd silnikowy (MotorizedVehicle)

Opis: Abstrakcyjny obiekt dziedziczący z Pojazdu, opisujący dowolny pojazd posiadający silnik.

- Engine (Engine) - parametry silnika (poniżej)

#### Silnik (Engine)

Opis: Obiekt definiowany wewnątrz pojazdu silnikowego. Definiowany następującymi parametrami:

- Name (string) - Nazwa (tekst na podstawie pozycji katalogowej producenta)
- Capacity (int) - Pojemność (liczba całkowita dodatnia, cm3)
- Power (int) - Liczba koni mechanicznych (liczba całkowita dodatnia)

### Pojazd bezsilnikowy (NonMotorizedVehicle)

Opis: Abstrakcyjny obiekt dziedziczący z Pojazdu, opisujący dowolny pojazd nieposiadający silnika.

### Pojazd ładunkowy (Loadable)

Opis: Interfejs zawierający przestrzeń ładunkową dla pojazdu.

- Storage (Storage) - Przestrzeń ładunkowa (poniżej)

#### Przestrzeń ładunkowa (Storage)

Opis: Abstrakcyjny obiekt definiowany wewnątrz pojazdu z którego dziedziczą opisane poniżej typy przestrzeni ładunkowej.

- StorageDescription (string) - Opis przestrzeni ładunkowej. Definiowany na poziomie definicji klasy.
- Items (List of Items) - Lista towarów.
- IsSingle (bool) - Czy przestrzeń ładunkowa może zawierać jeden typ towarów.

#### Towar (Item)

Abstrakcyjny obiekt opisujący dowolną jednostkę towarową. Wyszczególnione są następujące obiekty pochodne:

- BoxItem - Towar typu skrzyniowego
- ContainerItem - Towar typu kontenerowego
- LiquidItem - Towar typu płynnego

Parametry:

- Name (string) - Nazwa towaru
- GrossMass (decimal) - Waga brutto towaru
- Description (string) - Opis towaru

Metody:

- GetDimensions (string) - abstrakcyjna funkcja definiowana na poziomie funkcji pochodnych zwracająca opis fizycznej przestrzeni zajmowanej przez towar.

#### Skrzyniowa przestrzeń ładunkowa (BoxStorage)

Opis: Typ przestrzeni ładunkowej. Umożliwia załadunek towaru typu skrzyniowego.

- StorageDescription (string) - parametr, zwraca "Przestrzeń skrzyniowa"
- IsSingle (bool) - zwraca "fałsz"

#### Towar typu skrzyniowego (BoxItem)

Typ towaru, ładowany do skrzyniowej przestrzeni ładunkowej.

- Nazwa (Name) (tekst na podstawie pozycji katalogowej producenta)
- Masa brutto (GrossMass) (liczba zmiennoprzecinkowa, w tonach).
- Width - Szerokość (w cm)
- Height - Wysokość (w cm)
- Length - Długość (w cm)

#### Kontenerowa przestrzeń ładunkowa (ContainerStorage)

Opis: Typ przestrzeni ładunkowej. Umożliwia załadunek towaru typu kontenerowego. Opisywany następującymi parametrami:

- StorageDescription (string) - parametr, zwraca "Przestrzeń kontenerowa"
- IsSingle (bool) - parametr, zwraca "prawda"

#### Towar typu kontenerowego (ContainerItem)

Typ towaru, ładowany do kontenerowej przestrzeni ładunkowej. Metody:

- GetDimensions() - zwraca "-" (standardowy wymiar kontenera)

#### Cysternowa przestrzeń ładunkowa (TankStorage)

Opis: Typ przestrzeni ładunkowej. Umożliwia załadunek towaru typu płynnego.

- StorageDescription (string) - parametr, zwraca "Cysterna".

#### Towar typu płynnego (LiquidItem)

Typ towaru, ładowany do cysternowej przestrzeni ładunkowej. Opisywany listą parametrów:

- Volume - Objętość (w litrach, opisywana liczbą całkowitą dodatnią)

### Aktorzy Biznesowi

Aktorzy biznesowi przetwarzają obiekty biznesowe lub są z nimi w interakcji.

Id | Nazwa         | Opis
-- | ------------- | -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
A1 | Operator      | Podstawowy użytkownik aplikacji. Może przeglądać listy pojazdów i informacje na temat każdego z pojazdów. Może przeprowadzać załadunek i rozładunek pojazdów oraz łączenie i rozłączanie zespołów pojazdów.
A2 | Administrator | Użytkownik z uprawnieniami administratora. Może zarządzać użytkownikami systemu – dodawać, usuwać, edytować informacje i wyświetlać listę zarejestrowanych użytkowników i administratorów systemu.

### Reguły Biznesowe

ID | Definicja reguły                                                                       | Typ          | Źródło
-- | -------------------------------------------------------------------------------------- | ------------ | -----------------------
A1 | Do skrzyniowej przestrzeni ładunkowej można ładować jedynie towary typu skrzyniowego   | ograniczenie | Definicja
A2 | Do kontenerowej przestrzeni ładunkowej można ładować jedynie towary typu kontenerowego | ograniczenie | Definicja
A3 | Do cysternowej przestrzeni ładunkowej można ładować jedynie towary typu płynnego       | ograniczenie | Definicja
B1 | Skrzyniowa przestrzeń ładunkowa może przechowywać wiele towarów.                       | definicja    | Rozmowa w trakcie zajęć
B2 | Kontenerowa przestrzeń ładunkowa może przechowywać tylko jeden towar.                  | ograniczenie | Rozmowa w trakcie zajęć
B3 | Cysterna może być załadowana jednym rodzajem płynu.                                    | ograniczenie | Rozmowa w trakcie zajęć
C1 | Przyczepę można przyczepić jedynie do pojazdu typu przyczepowego                       | ograniczenie | -
C2 | Naczepę można przyczepić jedynie do pojazdu typu naczepowego                           | ograniczenie | -

### Wymagania Funkcjonalne

Rozdział zawiera spis wymagań funkcjonalnych dla tworzonego produktu informatycznego.

ID  | Nazwa                                               | Priorytet | Proces biznesowy
--- | --------------------------------------------------- | --------- | ------------------------------------------------------------------------
F1  | Operator może wyświetlać listę pojazdów.            | Wysoki    | Operator może wyświetlać listę pojazdów.
F2  | Operator może wyświetlać dane pojedynczego pojazdu. | Wysoki    | Operator może wyświetlać dane pojedynczego pojazdu.
F3  | Operator może stworzyć nowy pojazd.                 | Wysoki    | Operator może stworzyć nowy pojazd.
F4  | Operator może zaktualizować dane pojazdu.           | Wysoki    | Operator może zaktualizować dane pojazdu.
F5  | Operator może skasować pojazd.                      | Wysoki    | Operator może skasować pojazd.
F6  | Złączanie pojazdów (przyczepa)                      | Wysoki    | Operator może złączyć pojazd typu ciągnikowego z przyczepą.
F7  | Rozłączanie pojazdów (przyczepa)                    | Wysoki    | Operator może rozłączyć pojazd typu ciągnikowego z przyczepą.
F8  | Złączanie pojazdów (naczepa)                        | Wysoki    | Operator może złączyć pojazd typu siodłowego z naczepą.
F9  | Rozłączanie pojazdów (naczepa)                      | Wysoki    | Operator może rozłączyć pojazd typu siodłowego z naczepą.
F10 | Załadunek pojazdu                                   | Wysoki    | Operator może przeprowadzić załadunek pojazdu z przestrzenią ładunkową.
F11 | Rozładunek pojazdu                                  | Wysoki    | Operator może przeprowadzić rozładunek pojazdu z przestrzenią ładunkową.
F12 | Zapis i odczyt z pliku                              | Wysoki    | Operator może zapisać/odczytać dane do/z pliku.
F13 | Autoryzacja użytkownika                             | Wysoki    | Operator autoryzuje się przed rozpoczęciem pracy.
F14 | Dodawanie użytkownika                               | Wysoki    | Administrator może dodać użytkownika do systemu
F14 | Usuwanie użytkownika                                | Wysoki    | Administrator może usunąć użytkownika z systemu.

## Wymagania Niefunkcjonalne

W tym rozdziale należy umieścić wszystkie wymagania niefunkcjonalne pamiętając, aby tak je sformułować, aby w przyszłości była możliwość ich weryfikacji.

ID | Nazwa                           | Priorytet | Proces biznesowy
-- | ------------------------------- | --------- | ------------------------------------------------------------------------------
N1 | Platforma Windows 10            | Wysoki    | Program ma działać na platformie Windows 10
N1 | Windows Presentation Foundation | Wysoki    | Program ma zostać zaprojektowany dla platformy Windows Presentation Foundation
N2 | Interfejs graficzny             | Wysoki    | Interfejs programu ma być w postaci graficznej (GUI)
N3 | Wymagania zapisu                | Wysoki    | Program ma automatycznie zapisywać stan magazynu przy zmianach
N3 | Wymagania odczytu               | Wysoki    | Program ma automatycznie wczytywać stan magazynu przy zmianach

## Diagramy Use Case

```plantuml
@startuml

left to right direction

  actor "Administrator" as admin
  actor "Użytkownik" as user
  actor "Operator" as operator
admin --|> user
operator --|> user

rectangle "Administracja" {
  usecase "Wyświetla listę użytkowników" as A1
  admin -- A1
  A1 <-- (Dodaje nowego użytkownika) : <<extend>>
  A1 <-- (Usuwa użytkownika) : <<extend>>
  A1 <-- (Zmienia hasło użytkownika) : <<extend>>
}

rectangle "Autoryzacja" {
  user -- (Loguje się do systemu)
  user -- (Wylogowuje się z systemu)
}

rectangle "Przechowywanie danych" {
  user -- (Zapisuje dane do pliku)
  user -- (Wczytuje dane z pliku)
}

rectangle "Zarządzanie magazynem" {
  usecase "Wyświetla listę pojazdów" as SHOW_VEHICLES
  usecase "Wyświetla informacje o pojeździe" as SHOW_VEHICLE
  ' usecase "Edytuje informacje o pojeździe" as SHOW_VEHICLE
  usecase "Dodaje nowy pojazd" as ADD_VEHICLE
  usecase "Usuwa pojazd" as DELETE_VEHICLE
  usecase "Łączy pojazdy" as JOIN_VEHICLES
  usecase "Rozłącza pojazdy" as DISJOIN_VEHICLES
  usecase "Uzupełnia dane pojazdu" as UPDATE_VEHICLE
  usecase "Wyświetla informacje o ładunku" as SHOW_ITEMS
  usecase "Przeprowadza załadunek" as ADD_ITEM
  usecase "Przeprowadza rozładunek" as DELETE_ITEM

  operator -- SHOW_VEHICLES

  SHOW_VEHICLES <-- ADD_VEHICLE : <<extend>>
  SHOW_VEHICLES <-- DELETE_VEHICLE : <<extend>>
  SHOW_VEHICLES <-- SHOW_VEHICLE : <<extend>>
  SHOW_VEHICLE <-- JOIN_VEHICLES : <<extend>>
  SHOW_VEHICLE <-- DISJOIN_VEHICLES : <<extend>>
  ADD_VEHICLE --> UPDATE_VEHICLE : <<include>
  SHOW_VEHICLE <-- UPDATE_VEHICLE : <<extend>>
  SHOW_VEHICLE <-- SHOW_ITEMS : <<extend>>
  SHOW_ITEMS <-- ADD_ITEM : <<extend>>
  SHOW_ITEMS <-- DELETE_ITEM : <<extend>>

}
@enduml
```

## Diagram klas

```mermaid
classDiagram
class VehicleBuilder
VehicleBuilder .. VehicleProxy

class VehicleProxy
VehicleProxy -- Vehicle

class ILoadable
<<interface>> ILoadable

class Vehicle{
<<abstract>>
# Vehicle();
# Vehicle(Vehicle);
+  Id: int;
+  Name: string;
+  VIN: string;
+  Year: int;
+  TypeDescription*: string;
+ ToString(): string;
}

class MotorizedVehicle{
<<abstract>>
# MotorizedVehicle();
# MotorizedVehicle(Vehicle vehicle);
# MotorizedVehicle(MotorizedVehicle vehicle);
+Engine Engine;
}

class NonMotorizedVehicle{
<<abstract>> 
# NonMotorizedVehicle();
# NonMotorizedVehicle(Vehicle vehicle);
}

Vehicle <|-- MotorizedVehicle
Vehicle <|-- NonMotorizedVehicle

MotorizedVehicle <|.. TrailerCar
MotorizedVehicle <|.. Truck
MotorizedVehicle <|.. CargoSpaceCar

CargoSpaceCar ..|> ILoadable
SemiTrailer ..|> ILoadable
Trailer ..|> ILoadable

NonMotorizedVehicle <|.. SemiTrailer
NonMotorizedVehicle <|.. Trailer

class ISemiTrailerable{
<<interface>>
    +int SemiTrailerId
}
Truck --|> ISemiTrailerable

class ITrailerable{
<<interface>>
+int TrailerId
}
TrailerCar ..|> ITrailerable

ILoadable -- Storage

class Storage{
  <<abstract>>
+  StorageDescription*: string;
+ Items: List<Item>  ;
+  IsSingle*: bool ;
}

Storage <|.. ContainerStorage
Storage <|.. BoxStorage
Storage <|.. TankStorage

class Engine{
  +Engine()
  +Engine(Engine)
  +string Name
  +int Capacity
  +int Power
}
Engine *-- Vehicle

class ContainerStorage{
    + ContainerStorage();
    + ContainerStorage(ContainerStorage);
    + string StorageDescription
    + bool IsSingle
}

class BoxStorage{
    + BoxStorage();
    + BoxStorage(BoxStorage );
    + StorageDescription: string
    + IsSingle: bool
}

class TankStorage{
    + TankStorage();
    + TankStorage(TankStorage);
    +  StorageDescription : string
    +  IsSingle: bool
}

class Item{
  +Name : string
  +GrossMass : float
}

class LiquidItem{
    + LiquidItem();
    + LiquidItem(LiquidItem item) ;
    +  Volume: decimal;
    + string GetDimensions();
}

class BoxItem{
  +Width: int
  +Height: int
  +Length: int
}

    <<abstract>> Item

    ContainerStorage -- ContainerItem
    BoxStorage -- BoxItem
    TankStorage -- LiquidItem
    ContainerItem --|> Item
    BoxItem --|> Item
    LiquidItem --|> Item

    class Vehicle{
      +Id : int
      +Name : string
      +VIN : string
      +Year : int
      +Engine : Engine
      +CargoSpace : Storage
    }

class ItemProxy{
    + int Id ;
    + ItemProxy(Item item);
    + Item Item;
    + string Name => Item.Name;
    + string GrossMass;
    + string Dimensions => GetDimensions();
    + string TypeDescription => GetTypeDescription();
    - string GetTypeDescription();
    - string GetDimensions();
}

Item -- ItemProxy
```

## Diagramy sekwencji

### Get Vehicle

![](images/get_vehicle.png)

### Connect Trailer

![](images/connect_trailer.png)

### Save

![](images/save.png)

### Add Item

![](images/add_item.png)

### Add Goods

![](images/add_goods.png)

### Disconnect Trailer

![](images/disconnect_trailer.png)

## Set Storage

![](images/set_storage.png)

### Change password

![](images/change_password.png)

## Diagramy maszyny stanowej i czynności

### Logowanie do programu

```mermaid
stateDiagram-v2
start: Ekran logowania
vehicles: Ekran z listą pojazdów
operators: Ekran z listą operatorów
finish: Zakończenie programu
start_error: Informacja o błędzie logowania
[*] --> start
start --> vehicles : Logowanie operatora 
start --> operators : Logowanie administratora
start --> start_error : Błąd logowania
start_error --> start : Powrót do ekranu logowania
operators --> start: Wylogowanie administratora
vehicles --> start: Wylogowanie operatora
vehicles --> finish: Zakończenie programu
operators --> finish: Zakończenie programu
start --> finish: Zakończenie programu
finish --> [*]
```

### Okno administratora

```mermaid
stateDiagram-v2
operators_list: Lista operatorów
add_operator: Dodaj operatora
edit_operator: Edytuj operatora
save_operator: Zapisz operatora
delete_operator: Usuń operatora
cancel_operator: Anuluj dodawanie operatora

[*] --> operators_list: Logowanie jako administrator
operators_list --> add_operator: Dodaj operatora
operators_list --> edit_operator: Edytuj operatora
edit_operator --> save_operator: Zapisz operatora
edit_operator --> cancel_operator: Anuluj edycję operatora
add_operator --> save_operator: Zapisz operatora
add_operator --> cancel_operator: Anuluj dodawanie operatora
save_operator --> operators_list: Powrót do listy operatorów
operators_list --> delete_operator: Usuń operatora
delete_operator --> operators_list: Powrót do listy operatorów
cancel_operator --> operators_list: Powrót do listy operatorów
```

### Okno operatora pojazdów

```mermaid
stateDiagram-v2
vehicles_list: Lista pojazdów
add_vehicle: Dodaj pojazd
edit_vehicle: Edytuj pojazd
save_vehicle: Zapisz pojazd
delete_vehicle: Usuń pojazd
cancel_vehicle: Anuluj dodawanie pojazdu
join_trailer: Połącz pojazdy
disjoin_trailer: Rozłacz pojazdy

[*] --> vehicles_list: Logowanie jako operator
vehicles_list --> add_vehicle: Dodaj pojazd
add_vehicle --> edit_vehicle: Edytuj pojazd
vehicles_list --> edit_vehicle: Edytuj pojazd
edit_vehicle --> save_vehicle: Zapisz pojazd
save_vehicle --> vehicles_list: Powrót do listy pojazdów
edit_vehicle --> cancel_vehicle: Anuluj edycję pojazdu
cancel_vehicle --> vehicles_list: Powrót do listy pojazdów
vehicles_list --> delete_vehicle: Usuń pojazd
delete_vehicle --> vehicles_list: Powrót do listy pojazdów
edit_vehicle --> join_trailer: Połącz z pojazdem
join_trailer --> edit_vehicle: Edytuj pojazd
edit_vehicle --> disjoin_trailer: Rozłącz z pojazdem
disjoin_trailer --> edit_vehicle: Edytuj pojazd
```

### Okno dodawania towarów

```mermaid
stateDiagram-v2
edit_vehicle: Edytuj pojazd
add_item: Dodaj towar
edit_item: Edytuj towar
save_item: Zapisz towar
cancel_item: Anuluj dodawanie towaru
show_storage: Wyświetl przestrzeń ładunkową

[*] --> edit_vehicle: Edycja pojazdu
edit_vehicle --> show_storage: Otwórz przestrzeń ładunkową
show_storage --> add_item: Dodawanie towaru
show_storage --> edit_item: Edycja towaru
add_item --> edit_item: Edycja towaru
edit_item --> save_item: Zapisz towar
save_item --> show_storage: Powrót do przestrzeni ładunkowej
edit_item --> cancel_item: Anuluj dodawanie towaru
cancel_item --> show_storage: Powrót do przestrzeni ładunkowej
```
