# BD02 LAB 09

1. Zmodyfikować tabelę `BD4_KLIENT` dodając do niej kolumnę `STATUS_KLIENTA`. Kolumna ta
będzie określała status klienta na podstawie sumarycznej wielkości przeprowadzanych
transakcji według zasady:
Jeśli suma zakupów przekroczy wartość HIGH klient otrzymuje status BARDZO WAŻNY,
jeśli ta suma jest w zakresie LOW i HIGH to klient otrzymuje status WAŻNY, w przeciwnym
przypadku nie ma żadnego statusu.
Opracować kod PL/SQL (blok anonimowy lub procedurę), który jednorazowo na podstawie
zawartości tabeli BD4_RACHUNEK dokona modyfikacji zawartości kolumny `STATUS_KLIENTA`.

Opracować wyzwalacz, który na bieżąco będzie dokonywał modyfikacji tej kolumny
w momencie rejestrowania nowego zamówienia w tabeli BD4_RACHUNEK.
2. Opracować jeden zbiorczy wyzwalacz łączący w sobie omówione w materiale wyzwalacze
zbudowane w oparciu o tabelę BD4_RACHUNEK i reagujący na zdania insert, update i delete.
Wykorzystać predykaty warunkowe INSERTING, UPDATING i DELETING.
3. Utworzyć tabelę słownikową BD4_RABATY zawierającą wartości procentowe rabatów
przyznawanych klientom o odpowiednim statusie przy składaniu kolejnych zamówień. Tabela
może składać się z dwóch kolumn: nazwa_statusu (HIGH i LOW) oraz wartości progowych (np.
10% i 5%).

Utworzyć odpowiednią relację między tabelami BD4_RABATY i BD4_KLIENCI.
Zmodyfikować tabelę BD4_RACHUNEK dodając do niej dwie kolumny: RABAT oraz
WARTOSC_RACHUNKU. Kolumna RABAT otrzymuje wartość zgodną ze statusem klienta,
a wartość rachunku obliczana jest na podstawie ilości zamówionego produktu, ceny tego
produktu i przydzielonego rabatu.

Zmodyfikować, opracowany w punkcie 2, wyzwalacz uwzględniający przyznawanie rabatu
klientowi przy składaniu zamówień.

III. Zadania ( jobs ) jako automaty czasowe
Omawiane do tej pory automaty typu wyzwalacze działały w ten sposób, że były wyzwalane zdarzeniem
jakim mogło być jedno ze zdań DML (insert, update czy delete).
Automaty czasowe zwane zadaniami (częściej "jobami") są wyzwalane czasem. Można na przykład
określić zadanie polegające na wydruku raportu analitycznego pierwszego dnia każdego miesiąca
o godzinie 06:16, czy też uruchamiać konkretną procedurę co dwie godziny.
Podstawowymi pojęciami używanymi w tej tematyce są: schedule, program i job.
Schedule (harmonogram) - terminarz wykonywania jobów. Można zrobić harmonogram który określa
realizację pewnej czynności z określoną częstotliwością i skojarzyć go z kilkoma jobami. Dzięki temu
kilka jobów uruchamianych jest zgodnie z jednym harmonogramem i w przypadku konieczności jego
zmiany robi się to w jednym miejscu. Odpowiada na pytanie: Kiedy to ma się wykonać?
Program – w nim można zdefiniować działania przy pomocy bloku anonimowego, procedury PL/SQL
czy też pliku zewnętrznego z poziomu systemu operacyjnego. Można go skojarzyć
z wieloma jobami i również w przypadku jego zmiany robi się to w jednym miejscu. Odpowiada na
pytanie: Co ma się wykonać?
Job - łączy w sobie definicje harmonogramu i programu czyli odpowiada na pytanie: Jaki program
i zgodnie z jakim harmonogramem ma się wykonać? Jako jedyny z tych obiektów ma charakter
dynamiczny, to znaczy tylko uruchomienie joba zrealizuje zadanie. Harmonogramy i programy stanowią
statyczne definicje.
Do zarządzania zadaniami (tworzenie zadań, uruchamianie ich oraz kasowanie) służy specjalny pakiet
programowy Oracle o nazwie dbms_scheduler.
Poniżej zostaną przedstawione przykładowe sposoby definiowania elementów umożliwiających
wykorzystanie jobów w realizacji zadań w bazie danych.



1. Tworzenie harmonogramów przy użyciu dbms_scheduler.create_schedule
begin
-- codziennie od Monday do Friday o godzinie 22:00
dbms_scheduler.create_schedule
(schedule_name => 'INTERVAL_DAILY_2200',
start_date=> trunc(sysdate)+18/24,
-- start dzisiaj o 18:00
repeat_interval=>'freq=DAILY; byday=MON,TUE,WED,THU,FRI; byhour=22',
comments=>'Uruchamiane (Mon-Fri) o 22:00'
);
end;
--------------------------------------------------begin
-- codziennie co godzinę
dbms_scheduler.create_schedule
(schedule_name => 'INTERVAL_EVERY_HOUR',
start_date => trunc ( sysdate ) + 18/24,
-- uaktywnienie nastąpi o godzinie 18:00
repeat_interval => 'freq=HOURLY; interval=1',
comments => 'Uruchamiane codziennie co godzinę'
);
-- codziennie co 5 minut
dbms_scheduler.create_schedule
(schedule_name => 'INTERVAL_EVERY_5_MINUTES',
start_date => trunc ( sysdate +1 ) + 20/24/60, -- uaktywnienie nastąpi o godzinie 00:20
-- następnego dnia
repeat_interval => 'freq=MINUTELY; interval=5',
comments => 'Uruchamiane codziennie co 5 minut'
);
-- codziennie co minutę przez 30 dni
dbms_scheduler.create_schedule
(schedule_name => 'INTERVAL_EVERY_MINUTE',
start_date => trunc ( sysdate +1 ) + 20//24/60,
end_date
=> trunc ( sysdate ) + 30,
repeat_interval => 'freq=MINUTELY; interval=1',
comments => 'Uruchamiane codziennie przez 30 dni co 1 minutę'
);
-- w każdą niedzielę o godzinie 18:00
dbms_scheduler.create_schedule
(schedule_name => 'INTERVAL_EVERY_SUN_1800',
start_date=> trunc ( sysdate ) + 18/24,
repeat_interval=> 'freq=DAILY; byday=SUN; byhour=18;',
comments=>'Uruchamiane w niedzielę o godzinie 18'
);
end;



2. Tworzenie programów przy użyciu dbms_scheduler.create_program
begin
-- wywołanie bloku anonimowego
dbms_scheduler.create_program
(program_name => 'PROG_INIT_DRAWING_TABLE',
program_action =>
' BEGIN
delete from DRAWING_TABLE;
END; ' ,
program_type => 'plsql_block',
comments => 'Inicjowanie tabeli DRAWING_TABLE',
);
end;
-----------------------------------

begin
-- wywołanie wbudowanej procedury
dbms_scheduler.create_program
(program_name=> 'PROG_DRAWING_ONE_VALUE',
program_type=> 'stored_procedure',
program_action=> 'pr_generation_drawing_value',
comments=>'Losowanie pojedynczej wartości'
);
end;
-----------------------------------

begin
-- wywołanie pakietowej procedury
dbms_scheduler.create_program
(program_name=> 'PROG_PERCENT_DRAWING_TABLE',
program_type=> ' stored_procedure ',
program_action=> 'pkg_drawing.pr_count_percent';
comments=>'Obliczanie procentów w DRAWING_TABLE'
);
end;
3. Tworzenie zadania (job) przez połączenie harmonogramu z programem
przy użyciu dbms_scheduler.create_job:
begin
-- połączenie harmonogramu z programem
dbms_scheduler.create_job
(job_name => 'JOB_DRAWING_ONE_VALUE',
program_name=> 'PROG_DRAWING_ONE_VALUE',
schedule_name=>'INTERVAL_EVERY_MINUTE',
comments=>'Losowanie jednej wartości co 1 minutę');



dbms_scheduler.create_job
(job_name => 'JOB_PERCENT_DRAWING_TABLE',
program_name=> 'PROG_PERCENT_DRAWING_TABLE',
schedule_name=>'INTERVAL_EVERY_5_MINUTES',
comments=>'Obliczanie procentów w DRAWING_TABLE');
end;
4. Tworzenie zadania (job) bez definicji harmonogramu i programu
przy użyciu dbms_scheduler.create_job:
Jedną z właściwości pakietów programowych jest możliwość przeciążania procedur w nich zawartych.
Procedura pakietowa create_job jest taką właśnie procedurą. Dzięki temu można definiować zadania
na różne sposoby.
Na przykład zawrzeć w jego definicji nazwę programu oraz szczegółowe parametry harmonogramu:
.......

dbms_scheduler.create_job
(job_name => 'JOB_DRAWING_ONE_VALUE',
program_name=> 'PROG_DRAWING_ONE_VALUE',
start_date => trunc ( sysdate ) + 18/24,
end_date
=> trunc ( sysdate ) + 30,
repeat_interval => 'freq=MINUTELY; interval=1',
comments=>'Losowanie jednej wartości co 1 minutę przez 30 dni');
.........
lub w ogóle nie definiować nazw programu i harmonogramu:
.......
dbms_scheduler.create_job
(job_name => 'JOB_PERCENT_DRAWING_TABLE',
program_type=> 'stored_procedure',
program_action=> 'pkg_drawing.pr_count_percent';
start_date => trunc ( sysdate ) + 18/24,
repeat_interval => 'freq=MINUTELY; interval=5'
comments=>'Obliczanie procentów w DRAWING_TABLE');
........
Procedura create_job zawiera w sobie wszystkie możliwe argumenty formalne występujące
w procedurach create_program i create_schedule.
5. Uruchamianie zadań (jobów):

begin
dbms_scheduler.run_job ( 'JOB_DRAWING_ONE_VALUE' );
dbms_scheduler.run_job ( 'JOB_PERCENT_DRAWING_TABLE' );
end;



6. Restart zadania:
W przypadku konieczności wznowienia działania zadania na skutek, na przykład, zmiany jego
parametrów należy zadanie deaktywować i ponownie aktywować:
begin
dbms_scheduler.disable ( 'JOB_DRAWING_ONE_VALUE' );
dbms_scheduler.enable ( 'JOB_DRAWING_ONE_VALUE' );
dbms_scheduler.disable ( 'JOB_PERCENT_DRAWING_TABLE' );
dbms_scheduler.enable ( 'JOB_PERCENT_DRAWING_TABLE' );
end;
7. Metadane związane z zadaniami, programami i harmonogramami
Definicje wszystkich obiektów związanych z zadaniami można analizować poprzez wyświetlanie ich
metadanych poniższymi zdaniami SQL:
select * from user_scheduler_jobs;
select * from user_scheduler_programs;
select * from user_scheduler_schedules;
8. Usuwanie definicji zadań, programów i harmonogramów
begin
dbms_scheduler.drop_job ( 'JOB_DRAWING_ONE_VALUE' );
dbms_scheduler.drop_job ( 'JOB_PERCENT_DRAWING_TABLE' );
dbms_scheduler.drop_program ( 'PROG_DRAWING_ONE_VALUE' );
dbms_scheduler.drop_program ( 'PROG_INIT_DRAWING_TABLE' );
dbms_scheduler.drop_program ( 'PROG_PERCENT_DRAWING_TABLE' );
dbms_scheduler.drop_schedule ( 'INTERVAL_DAILY_2200' );
dbms_scheduler.drop_schedule ( 'INTERVAL_EVERY_5_MINUTES' );
end;
Uwagi:
1. Istnieje możliwość zmiany zdefiniowanych uprzednio parametrów zadań, programów
i harmonogramów przy pomocy procedury pakietowej dbms_scheduler.set_attribute, na
przykład:
dbms_scheduler.set_attribute
(
name => 'INTERVAL_EVERY_MINUTE',
attribute => 'start_date',
value => to_date ( '23.12.2020 12:30' , 'dd.mm.yyyy hh24:mi' )
);
lub
dbms_scheduler.set_attribute
(
name => 'INTERVAL_EVERY_MINUTE',
attribute => 'repeat_interval',
value => 'freq=MINUTELY;interval=2'
);
2. Istnieje również możliwość przekazywania poprzez programy i zadania argumentów do
procedur poprzez te obiekty wykonywanych. Zagadnienie to nie będzie omawiane w tym
materiale.