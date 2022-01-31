# Diagramy UML

Poniżej znajduje się diagram UML dla projektu Samochody Ciężarowe.

```mermaid
classDiagram
    Pojazd o-- Silnik
    Pojazd o-- PrzestrzeńŁadunkowa
    Pojazd <|-- PojazdSilnikowy
    Pojazd <|-- CiągnikSiodłowy
    PrzestrzeńŁadunkowa <|-- SkrzyniowaPrzestrzeńŁadunkowa
    PrzestrzeńŁadunkowa <|-- KontenerowaPrzestrzeńŁadunkowa
    PrzestrzeńŁadunkowa <|-- CysternowaPrzestrzeńŁadunkowa

    PrzestrzeńŁadunkowa o-- Naczepa
    PrzestrzeńŁadunkowa o-- Przyczepa
    Pojazd <|-- Naczepa
    Pojazd <|-- Przyczepa

    class Pojazd {
        +Identyfikator
        +Opis
        +VIN
        +RokProdukcji
    }

    class Silnik {
        +Nazwa
        +Pojemność
        +LiczbaKoniMechanicznych
    }

    class PrzestrzeńŁadunkowa{

    }

    class SkrzyniowaPrzestrzeńŁadunkowa{
        +Szerokość
        +Wysokość
        +Długość
        +Towary
    }

    class KontenerowaPrzestrzeńŁadunkowa{
        +MaksymalnaLiczbaKontenerów
        +Lista Kontenery
    }

    class CysternowaPrzestrzeńŁadunkowa{
        +Pojemność
        +Towar
    }

    class PojazdSilnikowy{
        +Silnik
        +Przyczepa
    }

    class Naczepa{
        +Nazwa
        +PrzestrzeńŁadunkowa
    }


```

```plantUML
@startuml
:Administrator: --> (Use)
"Operator" as Admin
"Use the application" as (Use)
Admin --> (Admin the application)
@enduml
```

Wymagane są:

- diagramy Use Case
- diagramy klas

