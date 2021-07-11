# Zadanie 2

Wyjaśnić pojęcie stanu bezpiecznego i ciągu bezpiecznego w systemie przydziału zasobów?

## Rozwiązanie

Procesy wykonywane współbieżnie mogą wywoływać żądania do zasobów, których natura wymaga, by naraz były przetrzymywane przez najwyżej jeden proces. W przypadku, gdy nie można mówić o wywłaszczeniu - tj. zasób zwalniany jest tylko i wyłącznie wtedy, gdy proces oznajmia, że już go nie potrzebuje - może pojawić się zakleszczenie, czyli ciąg procesów w których każdy oczekuje na zasób trzymany przez kolejny (natomiast ostatni z procesów czeka na zasób przetrzymywany przez pierwszy proces). W takim stanie nigdy nie nastąpi wykonanie procesów bez zewnętrznej interwencji (np. działania systemu operacyjnego lub wyłączenia systemu przez użytkownika).

Stan systemu określa się jako bezpieczny tylko wtedy, gdy istnieje ciąg bezpieczny - tj. taka kolejność przydziału zasobów każdemu z procesów, że system nie jest narażony na stan zakleszczenia.
<!-- 
Ciąg procesów P1, ..., Pn jest bezpieczny w danym stanie przydziałów, jeśli dla każdego procesu Pi jego potencjalne zapotrzebowanie na zasoby może być zaspokojone przez bieżąco dostępne zasoby oraz zasoby użytkowane prze wszystkie procesy Pj, przy czym $j < i$ . Jeśli więc zasoby, których wymaga proces Pi, nie są natychmiast dostępne, to może on poczekać, aż zakończą się wszystkie procesy Pj. Po ich zakończeniu proces Pi może otrzymać wszystkie potrzebne mu zasoby, dokończyć przewidzianą pracę, oddać przydzielone zasoby i zakończyć działanie. -->