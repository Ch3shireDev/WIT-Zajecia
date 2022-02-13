Wątek jest częścią programu wykonywaną współbieżnie w obrębie procesu. Proces może powoływać kolejne wątki celem zrównoleglenia działania programu.

Każdy wątek posiada własny licznik rozkazów, zbiór rejestrów, stos, stan oraz wątki potomne. Współdzieli z innymi wątkami tego samego zadania: przestrzeń adresową, zmienne globalne oraz zasoby systemowe.

Wątki mogą być zorganizowane na jeden z trzech sposobów:

- model dyspozytor-pracownik (dispatcher – worker) – Zamówienia są w buforze, jeden wątek dyspozytor sprawdza czy jest zamówienie i budzi uśpionego robotnika, aby obsłużył zamówienie. Robotnik pobiera zamówienie i je realizuje. W wielu wątkach jest wielu uśpionych robotników czekających na obudzenie.

- model zespołu (team model) – Nie ma dyspozytora, wszystkie wątki są równoprawne. Pobierają i przetwarzają zamówienia (wątki mogą być wyspecjalizowane).

- model potoku (pipeline model) – Jeden wątek pobiera i przetwarza częściowo zamówienie, po czym podaje je dalej i może zacząć pobierać następne zamówienie.
