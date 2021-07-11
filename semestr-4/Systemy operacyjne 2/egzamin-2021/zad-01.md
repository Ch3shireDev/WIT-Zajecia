# Zadanie 1

Wyjaśnić powstawanie błędów synchronizacji przy współbieżnym wykonywaniu procesów. Kiedy mogą powstać i dlaczego?

## Rozwiązanie

Procesy wykonywane współbieżnie mogą dzielić ze sobą dane, zarówno poprzez dostęp do tych samych zmiennych przechowywanych w pamięci operacyjnej, lub poprzez dostęp do tych samych plików. Sprawia to, że wynik przeprowadzonych obliczeń może być zależny od kolejności przydzielania kwantów czasu procesom przez system operacyjny, albo od czasu wykonywania każdego z procesów. Takie błędy będą miały charakter losowy - czasem będą się pojawiały, a czasem nie.

Przykład - załóżmy, że mamy proces który dopisuje do pliku nazwy użytkowników, ale tylko wtedy gdy użytkownika o podanej nazwie jeszcze nie ma. Ponieważ taki proces jest wykonywany wielokrotnie przez wielu użytkowników bez wzajemnej wiedzy o sobie, musimy się liczyć z tym że proces może być wywołany dwa razy.

Załóżmy, że dwóch użytkowników w tej samej chwili wykonało żądanie o utworzenie nowego użytkownika o nazwie `abc` . Proces wywołany za sprawą pierwszego użytkownika najpierw uzyskuje dostęp do pliku w ramach odczytu, pobiera listę wszystkich użytkowników i stwierdza, że takiego użytkownika tam nie ma. W tym momencie kończy się kwant czasu pierwszego procesu i przydzielany jest kwant czasu drugiemu procesowi, zapoczątkowanemu przez drugiego użytkownika. Ów proces uzyskuje dostęp do zwolnionego przez pierwszy proces pliku i również uzyskuje informację, że nie ma takiego użytkownika. Następnie, drugi proces przeprowadza dopisywanie nowego użytkownika do listy i kończy pracę. Po tym kwant czasu przydzielany jest ponownie pierwszemu procesowi, który również dopisuje tego samego użytkownika do listy - w efekcie użytkownik o nazwie `abc` pojawia się na liście dwa razy, podczas gdy warunkiem przeszukiwania danych o użytkownikach jest, by nazwa użytkownika była unikalna. Taki użytkownik w skrajnym przypadku albo nie będzie mógł się zalogować do serwisu, albo będzie w stanie uzyskać dostęp od nieswoich danych.
