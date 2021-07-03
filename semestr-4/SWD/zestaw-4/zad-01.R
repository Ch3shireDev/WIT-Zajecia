x = c(36,64,49,21,28,47,58,19,32) #zmienna niezalezna, dochód (w tys. $)
y = c(129,310,260,92,126,242,288,81,134) #zmienna zalezna, wartosc domu (w tys. $)

# a) wyznacz prosta regresji wartosci domu wzgledem dochodu

plot(x,y, pch=20, xlab="dochód", ylab="wartosc domu") 
# widac ze punkty mniej wiecej ukladaja sie na prostej

# Wyznaczamy korelacje Pearsona
r = cor(x,y) # wartosc 0.98, zatem jest mocna korelacja

# Przeprowadzamy test.
# H0 - y jest niezalezne od x
# H1 - y jest zalezne od x

# Jesli p < 5% to H1, inaczej H0.
cor.test(x,y)

# data:  x and y
# t = 13.172, df = 7, p-value = 3.394e-06
# alternative hypothesis: true correlation is not equal to 0
# 95 percent confidence interval:
#   0.9066015 0.9960167
# sample estimates:
#   cor 
# 0.980419 

# Poniewaz p-value=3.394e-6 jest ostro mniejsze od 5%, to mozemy odrzucic H0 na rzecz H1.

# Wyznaczamy prosta regresji y = a + b*x przy uzyciu MNK

model = lm(y~x)

abline(model, col=2,lwd=2)
segments(x, lm(y~x)$fitted, x,y) # rysunki reszt

summary(model)