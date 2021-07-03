
# zadanie 1 Zestaw 4

x <- c(36, 64, 49, 21, 28, 47, 58, 19, 32) # roczny dochóD w tys.$
y <- c(129, 310, 260, 92, 126, 242, 288, 81, 134) # wartoœæ domu w tys.$

# a) Wyznacz prosta regresji wartosci domu (Y) wzgledem dochod (X).

# Y - zmiennna zale¿na
# X - zmienna niezale¿na
# Jak Y zalezy od X?

plot(x,y, pch=20, xlab='dochod', ylab = 'wartosc domu')

# widoczna jest zale¿noœæ liniowa dodatnia, raczej silna, bo punkty s¹ 
# blisko prostej

# korelacja Pearsona [-1; 1]
cor(x,y)
# r= 0.980419 - b.silna zale¿noœæ dodatnia

cor.test(x,y)
# H0: X i Y s¹ niezale¿ne
# H1: X i Y s¹ zale¿ne
# p-value = 3.394e-06 < 5%, czyli jest zaleznosc pomiedzy X a Y

# wyznaczenie prostej regresji y = a + b*x  >>> MNK
lm(y~x)

# nasza prosta regresji: y = -30.344 + 5.466*x
abline(lm(y~x), col=2, lwd=2)
text(50, 200, 'y = -30.344 + 5.466*x', col=2)

segments(x, lm(y~x)$fitted, x, y) # rys reszt 



# b)
# model regresji prostej liniowej: Y = a + b*X + epsilon
# a = -30.344, b= 5.466
model <- lm(y~x)
summary(model)

# Czy mo¿na przyj¹æ powy¿sze równanie jako model? = b)

# 1) Czy istnieje zale¿noœæ pomiêdzy Y a X?
# H0: b = 0 (NIE)
# H1: b!= 0 (TAK)
# p-value = 3.39e-06 < 5%, czyli H1

# 2) Czy wyraz wolny jest istotny w modelu?
# H0: a = 0 (NIE)
# H1: a!= 0 (TAK)
# p-value =  0.126 > 5%, czyli H0 >>> usuwamy wyraz wolny z modelu

model2 <- lm(y~x+0) # Y = b*X + epsilon
summary(model2)
# Nasz nowy (aktualny) model: Y = 4.7940 * X + epsilon
abline(model2, col=4, lwd=2)

# 3) wspó³czynnik determinacji R^2 in [0,1]
# 0.6 - 1 >>> wtedy model jest u¿yteczny
# Multiple R-squared:  0.9905
# miara w jakim stopniu model wyjaœnia Y na podstawie X

# model w b.du¿ym stopniu wyjaœnia Y na podstawie X =
# model jest bardzo dobrze dopasowany do danych


# 4) analiza reszt (sprawdzenie za³o¿enia o normalnoœci reszt,
# o wartoœci  œredniej reszt i o losowoœci reszt)

reszty <- model2$residuals
reszty

# H0: reszty maj¹ rozklad normalny
# H1: nie maj¹
shapiro.test(reszty)
# p-value = 0.8283 >> czyli za³o¿enie spe³nione

# H0: mu_eps = 0
# H1: mu_eps != 0 

t.test(reszty, mu=0)
# p-value = 0.5862, czyli za³o¿enie spe³nione

plot(reszty)
abline(h=0, lty=2)
# widoczna chmura punktów, czyli przyjmujemy, ¿e reszty s¹ losowe
# i nieskorelowane, czyli jest OK


# c), d) PROGNOZA

# jakie Y dla x=40 tys$????
# Y = 4.7940 * X + epsilon
4.7940 *40 # w tys.$
points(40, 191.76, pch=18, col=2, cex=2)


predict(model2, list(x=40), level = 0.95, interval = 'p') # prognoza Y dla x=40
predict(model2, list(x=40), level = 0.95, interval = 'c') # prognoza EY dla x=40


# Zadanie 2
x <- c(58, 69, 43, 39, 63, 52, 47, 31, 74, 36) # wiek
y <- c(189, 235, 193, 177, 154, 191, 213, 175, 198, 181) # poziom cholesterolu

# Zadanie 7
x <- c(8, 10, 12, 14, 15, 17, 20, 21, 23, 26) # liczba reklam
y <- c(0.4, 0.42, 0.43, 0.44, 0.46, 0.45, 0.48, 0.49, 0.5, 0.51) # odsetek klientów


# Zadanie 8
y <- c() # koszt jednostkowy z³
x <- c() # wielkoœæ produkcji (w tys. sztuk)

