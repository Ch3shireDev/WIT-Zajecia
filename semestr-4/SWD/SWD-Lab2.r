# SWD Lab 1 - Statystyka opisowa w R

# zadanie 1 --------------------------------------------------------------------

x <- c(43, 37, 50, 51, 58, 105, 52, 45, 45, 10)

#a)
summary(x)
sd(x)

# uwaga na sposób liczenia kwantyli
quantile(x,0.25,type=2)
quantile(x,0.75,type=2)

#b)
IQR(x)
# czy są obserwacje o watościach mniejszych niż ....
43.50 - 1.5*8.25 # Q1-1.5*IQR = 31.125
x[x<31.125]

# czy są obserwacje o watościach większych niż ....
51.75 + 1.5*8.25 # Q3+1.5*IQR = 64.125
x[x>64.125]

# Odp. Tak są dwie obserwacje odstające: 10, 105

#c) 
y <- x[x>=31.125 & x<=64.125]
y
summary(x)
summary(y)
sd(x)
sd(y)

# zadanie 2 --------------------------------------------------------------------

#a)
auta <- read.csv2('samochody.csv')
getwd()
dim(auta)

#b)
summary(auta)
sapply(auta, typeof)
auta$producent

auta$producent <- factor(auta$producent)
levels(auta$producent) # uwaga: czynnik (Factor) nie jest w R typem podstawowym,
# nie stosujemy typeof(), można zastoswać np. is.factor()
is.factor(auta$producent)

levels(auta$producent) <- c('A', 'E', 'J')
auta$producent

#c)
auta <- na.omit(auta)

#d) 
auta$zp <- (100*3.785)/(auta$mpg*1.609)

#e)
hist(auta$zp)
hist(auta$zp, breaks = 5)
hist(auta$zp, breaks = 20)

#f)
stem(auta$zp)

#g)
mean(auta$zp) #średnia,
median(auta$zp) #mediana, 
quantile(auta$zp) #kwartyle, 
quantile(auta$zp, c(0.1, 0.9)) #10. i 90. percentyl, 
min(auta$zp); max(auta$zp) #wartości ekstremalne, 
range(auta$zp)
var(auta$zp) #wariancja, 
sd(auta$zp) #odchylenie standardowe, 
diff(range(auta$zp)) #rozstęp, 
IQR(auta$zp) #rozstęp międzykwartylowy, 

install.packages('e1071')
library(e1071)
skewness(auta$zp) #współczynnik asymetrii, 
kurtosis(auta$zp) #kurtoza, 

mean(auta$zp)/sd(auta$zp) #współczynnik zmienności

#h)
boxplot(auta$zp)
boxplot(auta$zp, horizontal = TRUE)


# zadanie 3 --------------------------------------------------------------------
#a)
auta$zp_kat[auta$zp <= 7] <- 'mało'
auta$zp_kat[auta$zp > 7 & auta$zp <= 10] <- 'średnio'
auta$zp_kat[auta$zp > 10] <- 'dużo'

#c)
table(auta$zp_kat)
# czynnik z nadanym porządkiem
auta$zp_kat <- factor(auta$zp_kat, ordered = TRUE, 
       levels = c("mało", "średnio", "dużo"))
table(auta$zp_kat)
prop.table(table(auta$zp_kat)) # odsetki
prop.table(table(auta$zp_kat))*100 # procenty

#d)
barplot(table(auta$zp_kat)) # wykres słpukowy
pie(table(auta$zp_kat)) # wykres kołowy


# zadanie 4 --------------------------------------------------------------------
tapply(auta$zp, auta$producent, mean)
tapply(auta$zp, auta$producent, sd)
boxplot(auta$zp~auta$producent, col=2:4)


# zadanie 5 --------------------------------------------------------------------
# podobnie jak w zad4, zamiast auta$producent wstawić auta$cylindry


# zadanie 6 --------------------------------------------------------------------
przysp.A <- auta$przysp[auta$producent=='A']
przysp.J <- auta$przysp[auta$producent=='J']

boxplot(przysp.A, przysp.J)


# zadanie 7 --------------------------------------------------------------------
x <- auta$zp[auta$waga < 2500]
summary(x)
var(x)
sd(x)
skewness(x)


# zadanie 8 --------------------------------------------------------------------
x <- auta$przysp[auta$waga > 2500 & auta$waga < 3000]

#a)
boxplot(x, horizontal = TRUE)

#b)
hist(x)

#c) podaj wartość przyspieszenia, którą przekracza 25% wybranych samochodów


# zadanie 9 --------------------------------------------------------------------



# zadanie 10 -------------------------------------------------------------------
rok <- seq(1790, 2020, 10)
popul <- c(3.9, 5.3, 7.2, 9.6, 12.9, 17.1, 23.2, 31.4, 38.6, 50.2, 63.0, 76.2,
           92.2, 106.0, 123.2, 132.2, 151.3, 179.3, 203.3, 226.5, 248.7, 281.4,
           308.7, 332.7)

#a)
plot(rok, popul)

#b)
d <- diff(popul)
plot(rok[-1], d)
plot(rok[-1], d, type = 'h')

#c)
f <- diff(popul)/popul[-length(popul)]


# zadanie 11 -------------------------------------------------------------------
przed <- c(56, 47, 49, 37, 38, 60, 50, 43, 43, 59, 50, 56, 54, 58)
po <- c(53, 21, 32, 49, 45, 38, 44, 33, 32, 43, 53, 46, 36, 48, 39, 35, 37, 36, 39, 45)

boxplot(przed, po)
boxplot(przed, po, names = c('przed','po'))
summary(przed)
summary(po)

# koniec -----------------------------------------------------------------------
