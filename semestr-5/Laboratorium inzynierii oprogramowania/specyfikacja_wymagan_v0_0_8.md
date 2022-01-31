# Specyfikacja wymagań dla projektu Samochody ciężarowe, wersja 0.0.8

## Autor: Igor Nowicki

## Opis systemu

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

### Obiekty Biznesowe

#### Pojazd (Vehicle)

Opis: Abstrakcyjny obiekt określających dowolną jednostkę jeżdżącą.

Każdy pojazd opisywany jest zestawem parametrów:

- Id (liczba całkowita) - Identyfikator (liczba całkowita dodatnia).
- Name (tekst) - Nazwa (tekst na podstawie pozycji katalogowej producenta).
- VIN (tekst) - Vehicle Identification Number (15 lub 17 znaków alfanumerycznych).
- Year - Rok produkcji (czterocyfrowa liczba całkowita w zakresie od roku 1900 do roku bieżącego).

#### Pojazd silnikowy (MotorizedVehicle)

Opis: Abstrakcyjny obiekt dziedziczący z Pojazdu, opisujący dowolny pojazd posiadający silnik.

- Engine (Engine) - parametry silnika (poniżej).

#### Silnik (Engine)

Opis: Obiekt definiowany wewnątrz pojazdu silnikowego. Definiowany następującymi parametrami:

- Name (tekst) - Nazwa (tekst na podstawie pozycji katalogowej producenta).
- Capacity (liczba całkowita) - Pojemność (liczba całkowita dodatnia, cm3).
- Power (liczba całkowita) - Liczba koni mechanicznych (liczba całkowita dodatnia).

### Pojazd bezsilnikowy (NonMotorizedVehicle)

Opis: Abstrakcyjny obiekt dziedziczący z Pojazdu, opisujący dowolny pojazd nieposiadający silnika.

### Pojazd ładunkowy (Loadable)

Opis: Interfejs zawierający przestrzeń ładunkową dla pojazdu.

- Storage (Storage) - Przestrzeń ładunkowa (poniżej)

#### Przestrzeń ładunkowa (Storage)

Opis: Abstrakcyjny obiekt definiowany wewnątrz pojazdu z którego dziedziczą opisane poniżej typy przestrzeni ładunkowej.

- StorageDescription (tekst) - Opis przestrzeni ładunkowej. Definiowany na poziomie definicji klasy.
- Items (List of Items) - Lista towarów.
- IsSingle (bool) - Czy przestrzeń ładunkowa może zawierać jeden typ towarów.

#### Towar (Item)

Abstrakcyjny obiekt opisujący dowolną jednostkę towarową. Wyszczególnione są następujące obiekty pochodne:

- BoxItem - Towar typu skrzyniowego
- ContainerItem - Towar typu kontenerowego
- LiquidItem - Towar typu płynnego

Parametry:

- Name (tekst) - Nazwa towaru
- GrossMass (decimal) - Waga brutto towaru
- Description (tekst) - Opis towaru

Metody:

- GetDimensions (tekst) - abstrakcyjna funkcja definiowana na poziomie funkcji pochodnych zwracająca opis fizycznej przestrzeni zajmowanej przez towar.

#### Skrzyniowa przestrzeń ładunkowa (BoxStorage)

Opis: Typ przestrzeni ładunkowej. Umożliwia załadunek towaru typu skrzyniowego.

- StorageDescription (tekst) - parametr, zwraca "Przestrzeń skrzyniowa"
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

- StorageDescription (tekst) - parametr, zwraca "Przestrzeń kontenerowa"
- IsSingle (bool) - parametr, zwraca "prawda"

#### Towar typu kontenerowego (ContainerItem)

Typ towaru, ładowany do kontenerowej przestrzeni ładunkowej. Metody:

- GetDimensions() - zwraca "-" (standardowy wymiar kontenera)

#### Cysternowa przestrzeń ładunkowa (TankStorage)

Opis: Typ przestrzeni ładunkowej. Umożliwia załadunek towaru typu płynnego.

- StorageDescription (tekst) - parametr, zwraca "Cysterna".

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
N2 | Windows Presentation Foundation | Wysoki    | Program ma zostać zaprojektowany dla platformy Windows Presentation Foundation
N3 | Interfejs graficzny             | Wysoki    | Interfejs programu ma być w postaci graficznej (GUI)
N4 | Wymagania zapisu                | Wysoki    | Program ma automatycznie zapisywać stan magazynu przy zmianach
N5 | Wymagania odczytu               | Wysoki    | Program ma automatycznie wczytywać stan magazynu przy zmianach

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

class ILoadable{
<<interface>> ILoadable
}

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

MotorizedVehicle <|-- TrailerCar
MotorizedVehicle <|-- Truck
MotorizedVehicle <|-- CargoSpaceCar

CargoSpaceCar --|> ILoadable
SemiTrailer --|> ILoadable
Trailer --|> ILoadable

NonMotorizedVehicle <|-- SemiTrailer
NonMotorizedVehicle <|-- Trailer

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

Storage <|-- ContainerStorage
Storage <|-- BoxStorage
Storage <|-- TankStorage

class Engine{
  +Engine()
  +Engine(Engine)
  +string Name
  +int Capacity
  +int Power
}
Engine --* MotorizedVehicle

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
  <<abstract>> Item
  +Name : string
  +GrossMass : float
}

class LiquidItem{
    + LiquidItem();
    + LiquidItem(LiquidItem item) ;
    + Volume: decimal;
    + GetDimensions(): string;
}

class BoxItem{
  +Width: int
  +Height: int
  +Length: int
}

ContainerStorage -- ContainerItem
BoxStorage -- BoxItem 1..*
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
    +Id: int
    +ItemProxy(Item item)
    +Item: Item
    +Name: string
    +GrossMass: string
    +Dimensions: string
    +TypeDescription: string
    -GetTypeDescription(): string
    -GetDimensions(): string
}

Item -- ItemProxy
```

## Diagramy sekwencji

### Logowanie do systemu

```plantuml
@startuml
actor User
participant "LoginWindow" as LW
participant "LoginModel" as LM
participant UserService as US

activate US
User -> LW : Start()
activate LW
LW -> LM : new Model()
activate LM
LW <-- LM : model
User -> LW : Login()
LW -> LM : GetUser()
activate LM
LM -> US : Authorize()
US -> US : FindUser()
alt użytkownik istnieje
US -> US : Verify(password, user.hash, user.salt)
alt hasło poprawne
LM <-- US : return user
LW <-- LM : return user
alt user.type == administrator
User <-- LW : ShowOperatorsWindow()
else user.type == operator
User <-- LW : ShowVehiclesWindow()
end group

else hasło niepoprawne
LM <-- US : throw new Exception("Niepoprawne hasło")
LW <-- LM : throw
User <-- LW : ShowMessageBox("Niepoprawne hasło.")
end group

else użytkownik nie istnieje
LM <-- US : throw Exception("Niepoprawna nazwa użytkownika")
LW <-- LM : throw
User <-- LW : ShowMessageBox("Użytkownik nie istnieje")
end group
deactivate LM
deactivate LW

@enduml
```

### Dodaj operatora

```plantuml
@startuml
actor Administrator as A
participant UsersWindow as UW
participant UserEditorWindow as UEW
participant UserEditorModel as UEM
participant UserService as US

activate UW
A -> UW : AddOperator()
UW -> UEW : new UserEditorWindow()
activate UEW
UEW -> UEM : new UserEditorModel()
activate UEM
UEW <-- UEM : model
UEW -> UEM : model.CreateOperator()
alt correct credentials
UEM -> US : CreateOperator()
activate US
US  --> UEM : return true
deactivate US
UEM --> UEW : return
UEW -> UEW : Save()
UEW --> UW : return true
else incorrect credentials
UEM --> UEW : throw new Exception("Hasło nie może być puste")
deactivate UEM
UEW --> UW : throw new Exception()
UW --> A : ShowError()
end group

A <-- UW

@enduml
```

### Dodaj samochód

```plantuml
@startuml
actor Operator as O
participant VehiclesWindow as VW
participant VehiclesModel as VM
participant VehicleEditorWindow as VEW
participant VehicleEditorModel as VEM

activate VW
VW -> VM : new VehiclesModel()
activate VM
VM --> VW : model
O -> VW : AddVehicle()
VW -> VM : model.AddVehicle()
VM --> VW : vehicle
VW -> VEW : new VehicleEditorWindow(vehicle)
activate VEW
VEW -> VEM : new VehicleEditorModel(vehicle)
activate VEM
VEW <-- VEM : model
O -> VEW : set vehicle data
VEW -> VEM : Update()
alt operator accepts
VEW --> VW : return true
else operator cancels
VEW --> VW : return false
VW -> VM : model.RemoveVehicle(vehicle)
end group
deactivate VEW
deactivate VEM
VW -> VW : Save()
VW -> VW : Refresh()
VW --> O : show new vehicles list
deactivate VW
deactivate VM

@enduml
```

### Usuń samochody

```plantuml
@startuml
actor Operator as O
participant VehiclesWindow as VW
participant VehiclesModel as VM

activate VW
VW -> VM : new VehiclesModel()
activate VM
VM -> VM : new Vehicles()
VM -> VW : model
VW -> VM : Load()
VM -> VM : Load()
activate VM
deactivate VM
O -> VW : DeleteVehicles()
alt selectedVehicles.count() > 0
VW -> VM : model.RemoveVehicles(selectedVehicles)
activate VM
VM -> VM : Vehicles.Remove(selectedVehicles)
O <-- VW : vehicle
VM -> VW : return
VW -> VW : Save()
VW -> VW : Refresh()
VW -> O : show new vehicles list
deactivate VM
else
VW -> O : ShowError()
end group
@enduml
```

### Łącz pojazdy

```plantuml
@startuml
actor Operator as O
participant VehicleEditorWindow as VEW
participant VehicleEditorModel as VEM
participant ConnectTrailerWindow as CTW

activate VEW
VEW -> VEM : new VehicleEditorModel()
activate VEM
VEW <-- VEM : model
O -> VEW : SetTrailer()
VEW -> VEM : model.GetTrailersList()
activate VEM
VEM -> VEM : GetTrailersList()
VEM --> VEW : trailersList
VEW -> CTW : new ConnectTrailerWindow(trailersList)
alt user selects
CTW --> VEW : return true
alt connection is possible
VEW -> VEM : model.Connect(selectedTrailer)
VEW -> VEW : Refresh()
else connection is not possible
VEW --> O : ShowError()
end group
else user cancels
CTW --> VEW : return false
end group
VEW --> O : return
@enduml
```

### Rozłącz pojazdy

```plantuml
@startuml
actor Operator as O
participant VehicleEditorWindow as VEW
participant VehicleEditorModel as VEM
participant TrailerConnector as TC

activate VEW
VEW -> VEM : new VehicleEditorModel()
activate VEM
VEW <-- VEM : model
O -> VEW : SetTrailer()
VEW -> VEM : model.Disconnect()
VEM -> TC : new TrailerConnector()
activate TC
TC --> VEM : connector
VEM -> TC : Unhook(vehicle)
alt success
TC --> VEM : return true
VEW -> VEW : Save()
VEW -> VEW : Refresh()
VEM --> VEW : return true
VEW --> O
else failure
TC --> VEM : throw new Exception()
VEM --> VEW : throw new Exception()
VEW --> O : ShowError()
end group
deactivate TC
@enduml
```

### Przeprowadź załadunek przestrzeni ładunkowej

```plantuml
@startuml
actor Operator as O
participant VehicleEditorWindow as VEW
participant StorageEditorWindow as SEW
participant StorageEditorModel as SEM
participant ItemEditorWindow as IEW
participant ItemEditorModel as IEM

activate VEW
O -> VEW : OpenStorageEditor()
VEW -> SEW : new StorageEditorWindow(vehicle)
activate SEW
SEW -> SEM : new StorageEditorModel(vehicle)
activate SEM
SEW <-- SEM : model
O -> SEW : AddGoods()
SEW -> SEM : GetNewItem()
SEM --> SEW : item
SEW -> IEW : new ItemEditorWindow(storage)
activate IEW
IEW -> IEM : new ItemEditorModel(storage)
activate IEM
O -> IEW : set item data
IEW -> IEM : UpdateItem(item)
IEM --> IEW : return
alt user accepts
IEW --> SEW : return true
SEW -> SEM : model.AddItem(item)
SEW -> SEW : Refresh()
else user cancels
IEW --> SEW : return false
end group

alt user accepts
SEW --> VEW : return true
else user cancels
SEW --> VEW : return false
end group

VEW -> VEW : Save()


@enduml
```



## Diagramy maszyny stanowej i czynności

### Logowanie do programu

```mermaid
stateDiagram-v2
start: Logowanie
vehicles: Wyświetlanie listy pojazdów
operators: Wyświetlanie listy operatorów
[*] --> start
start --> vehicles : Logowanie operatora 
start --> operators : Logowanie administratora
start --> start : Błąd logowania
operators --> start: Wylogowanie administratora
vehicles --> start: Wylogowanie operatora
start -->  [*]: Zakończenie programu
```

### Okno administratora

```mermaid
stateDiagram-v2
operators_list: Wyświetlanie listy operatorów
edit_operator: Edycja operatora

[*] --> operators_list: Logowanie jako administrator
operators_list --> edit_operator: Dodaj operatora
operators_list --> edit_operator: Edytuj operatora
edit_operator --> operators_list: Zapisz operatora
operators_list --> operators_list: Usuń operatora
edit_operator --> operators_list: Anuluj edycję
```

### Sesja operatora

```mermaid
stateDiagram-v2
vehicles_list: Wyświetlanie listy pojazdów
edit_vehicle: Edytowanie pojazdu
join_trailer: Łączenie pojazdów
disjoin_trailer: Rozłączanie pojazdów

[*] --> vehicles_list: Logowanie jako operator
vehicles_list --> edit_vehicle: Dodaj pojazd
vehicles_list --> edit_vehicle: Edytuj pojazd
edit_vehicle --> vehicles_list: Zapisz pojazd
edit_vehicle --> vehicles_list: Anuluj edycję pojazdu
vehicles_list --> vehicles_list: Usuń pojazd
edit_vehicle --> join_trailer: Połącz z pojazdem
join_trailer --> edit_vehicle: Edytuj pojazd
edit_vehicle --> disjoin_trailer: Rozłącz z pojazdem
disjoin_trailer --> edit_vehicle: Edytuj pojazd
```

### Okno dodawania towarów

```mermaid
stateDiagram-v2
edit_vehicle: Edycja pojazdu
edit_item: Edycja towaru
show_storage: Wyświetlanie przestrzeni ładunkowej

[*] --> edit_vehicle: Edycja pojazdu
edit_vehicle --> show_storage: Otwórz przestrzeń ładunkową
show_storage --> edit_item: Dodawanie towaru
show_storage --> edit_item: Edycja towaru
edit_item --> show_storage: Zapisz towar
edit_item --> show_storage: Anuluj dodawanie towaru
```

## Diagram klas 2

