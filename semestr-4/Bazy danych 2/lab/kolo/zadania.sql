-- zad 1

select 
    ORDER_ID as "Numer zamówienia",
    TO_CHAR(ORDER_TIMESTAMP, 'YYYY-MM-DD') as "Data zamówienia",
    CUST_LAST_NAME as "Nazwisko klienta",
    PRODUCT_NAME as "Nazwa produktu",
    UNIT_PRICE*QUANTITY as "Wartość pozycji zamówienia"
from 
    BD5_ORDER_ITEMS
    inner join bd5_orders using(order_id)
    inner join bd5_products using(product_id)
    inner join bd5_customers using(customer_id)
where 
    EXTRACT(day FROM sysdate - order_timestamp) < 25
    and
    cust_postal_code not like '%1%'
    and
    cust_postal_code not like '%2%'
    and
    CATEGORY = 'Womens'

-- zad 2

select 
    PRODUCT_NAME as "Nazwa produktu",
    sum(UNIT_PRICE*QUANTITY) as "Zysk ze sprzedaży"
from
    BD5_ORDER_ITEMS
    inner join BD5_PRODUCTS using (PRODUCT_ID)
    inner join BD5_ORDERS ord using (ORDER_ID)
    inner join BD5_CUSTOMERS cus using (CUSTOMER_ID)
where
    ORDER_TIMESTAMP between 
        TO_DATE('2019/04/01', 'YYYY/MM/DD') 
        and 
        TO_DATE('2019/06/30', 'YYYY/MM/DD')
    and
    PRODUCT_NAME in ('Mens Shoes', 'Ladies Shoes')
    and
    CUST_STATE not in ('NY', 'IL')
order by
    2 desc

-- zad 3

-- wersja dla "Średnia wartość WSZYSTKICH zamówień oraz liczba zamówień W ROKU 2020"

select 
    CUST_FIRST_NAME || ' ' || CUST_LAST_NAME as "Nazwisko i imię klienta",
    AVG(ORDER_TOTAL) as "Średnia wartość wszystkich zamówień",
    count(case when extract(year from ORDER_TIMESTAMP) = 2020 then 1 end) as "Liczba zamówień w 2020"
from
    BD5_ORDERS
    inner join BD5_CUSTOMERS using (CUSTOMER_ID)
group by
    CUST_FIRST_NAME || ' ' || CUST_LAST_NAME
having
    AVG(ORDER_TOTAL) > 150
    and
    count(*) > 5


-- wersja dla "licz tylko zamówienia z roku 2020":

select 
    CUST_FIRST_NAME || ' ' || CUST_LAST_NAME as "Nazwisko i imię klienta",
    AVG(ORDER_TOTAL) as "Średnia wartość zamówień w 2020",
    count(*) as "Liczba zamówień w 2020"
from
(
    select * from
    BD5_ORDERS
    inner join BD5_CUSTOMERS using (CUSTOMER_ID)
    where
    extract(year from ORDER_TIMESTAMP) = 2020
)
group by
    CUST_FIRST_NAME || ' ' || CUST_LAST_NAME
having
    AVG(ORDER_TOTAL) > 150
    and
    count(*) > 5
