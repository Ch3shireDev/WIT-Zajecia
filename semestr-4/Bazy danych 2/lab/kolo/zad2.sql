--Wykonać zestawienie analityczne o postaci:
 -- nazwa produktu,
 -- sumaryczny zysk z jego sprzedaży dla butów męskich i damskich (Mens Shoes, Ladies Shoes) 
 -- w drugim kwartale 2019 roku 
 -- klientom nie pochodzącym ze stanów Nowy York (NY) i Illinois (IL).

 -- Uporządkować zbiór malejąco według zysków.

select 
    PRODUCT_NAME as "Nazwa produktu",
    sum(UNIT_PRICE*QUANTITY) as "Sumaryczny zysk"
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