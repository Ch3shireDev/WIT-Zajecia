2+2 # Ctrl+Enter
log(10); 5*10
?log


# Typy danych:
# - podstawowe (wektory: logiczny, liczbowy, napisów)
# - złożone (czynnik, ramka danych)

# wektor logiczny (logical)
TRUE
FALSE
T
F
true

c(TRUE, FALSE, TRUE)
is.logical(c(TRUE, FALSE, TRUE))
is.numeric(c(TRUE, FALSE, TRUE))

rep(TRUE, 6)
?rep
rep(c(TRUE,FALSE), 6)
rep(c(TRUE,FALSE), , ,6)
rep(c(TRUE,FALSE),each=6)


# wektor liczbowy (numeric)
2
c(-6, 0, .05, 2)

3:7
7:3
2.1:5

typeof(c(-6, 0, .05, 2))
typeof(3:7)
typeof(2.1:5)

# wektor napisów (character)
'abc'
rep('abc', 7)



# zasada element po elemencie: +,-,*,/,^,%%, %/%
c(1,2,3,4)+c(10,20,30,40)
# zasada zawijania
c(1,2,3,4)*c(10,20)
c(1,2,3,4)^2
c(1,2,3,4)*c(10,20,30)
# zasada uzgadniania typów
c(TRUE,FALSE,TRUE)*2
as.numeric(c(TRUE,FALSE,TRUE))
'abc'*2

c(TRUE, FALSE, 2, 2L, 'cos')
c(TRUE, FALSE, 2.5, 2L)
