-- 3. (15 punktów)
-- Opracować zbiór zawierający:
-- nazwisko i imię klienta,
-- nazwę produktu,
-- zyski ze sprzedaży każdego produktu każdemu klientowi,
-- liczbę sprzedanych egzemplarzy każdego produktu każdemu klientowi.

-- Zbiór ma uwzględniać tylko te pozycje, dla których zyski ze sprzedaży przekraczają 200.

select 
    CUST_FIRST_NAME || ' ' || CUST_LAST_NAME as "Nazwisko i imię klienta",
    PRODUCT_NAME as "Nazwa produktu"
    SUM(UNIT_PRICE * QUANTITY) as "Zyski ze sprzedaży"
    SUM(QUANTITY) as "Liczba sprzedanych egzemplarzy"
from
    BD5_ORDER_ITEMS
    inner join BD5_ORDERS using (ORDER_ID)
    inner join BD5_PRODUCTS using (PRODCUCT_ID)
    inner join BD5_CUSTOMERS using (CUSTOMER_ID)
group by
    CUST_FIRST_NAME || ' ' || CUST_LAST_NAME,
    PRODUCT_NAME
having
    SUM(UNIT_PRICE * QUANTITY) > 200