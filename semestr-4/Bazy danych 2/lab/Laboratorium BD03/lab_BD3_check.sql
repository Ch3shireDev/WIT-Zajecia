--Sprawdzenie liczności wierszy w tabelach

select 'BD3_KATEGORIE' "Tabela", count(*) "Liczba wierszy" from bd3_kategorie
union
select 'BD3_KLUBY', count(*) from bd3_kluby
union
select 'BD3_WYNIKI', count(*) from bd3_wyniki
union
select 'BD3_ZAWODNICY', count(*) from bd3_zawodnicy
union
select 'BD3_ZAWODY', count(*) from bd3_zawody;