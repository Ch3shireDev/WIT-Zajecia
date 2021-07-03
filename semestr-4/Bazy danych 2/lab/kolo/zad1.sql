-- 1.(5punktów) Wykonać zestawienie ewidencyjne pozycji zamówień złożonych w pierwszym kwartale 2019 roku o postaci: 

-- nr zamówienia,
-- data zamówienia w formacie 'DD.MM.YYYY',
-- nazwisko klienta,
-- nazwa produktu,
-- liczba zamówionych sztuk produktu

-- na produkty nienależące do kategorii Mens lub dla których wartość pozycji przekracza 200 i posortowanych według numeru zamówienia i nazwy produktu. 

select 
    items.ORDER_ID as "Numer zamówienia",
    TO_CHAR(ORDER_TIMESTAMP, 'DD.MM.YYYY') as "Data zamówienia",
    CUST_LAST_NAME as "Nazwisko klienta",
    PRODUCT_NAME as "Nazwa produktu",
    QUANTITY as "Liczba zamówionych sztuk produktu"
from
    BD5_ORDER_ITEMS items
    inner join BD5_ORDERS ord using (ORDER_ID)
    inner join BD5_PRODUCTS prod using (PRODCUCT_ID)
    inner join BD5_CUSTOMERS cus using (CUSTOMER_ID)
where
    ORDER_TIMESTAMP between 
        TO_DATE('2019/01/01', 'YYYY/MM/DD') 
        and 
        TO_DATE('2019/03/31', 'YYYY/MM/DD')
    and
    (
        prod.CATEGORY != 'Mens'
        or
        LIST_PRICE > 200
    ) 
order by 1, 4