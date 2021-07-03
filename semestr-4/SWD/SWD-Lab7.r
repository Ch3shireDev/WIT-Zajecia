
# SWD - Lab7 

# ======================== REGRESJA CD. ========================================

# Zadanie 2
x <- c(58, 69, 43, 39, 63, 52, 47, 31, 74, 36) #wiek
y <- c(189, 235, 193, 177, 154, 191, 213, 175, 198, 181) #poziom cholesterolu

plot(x,y)

model <- lm(y~x)
summary(model)



# Zadanie 3
x <- seq(1890, 2020, 10)
y <- c(62.947, 75.994, 91.972, 105.710, 122.775, 131.669, 150.697, 179.323, 
       203.235, 226.542, 248.718, 281.422, 308.746, 323.996)

plot(x,y)
plot(x,log(y))

# budowa modelu regresji i weryfikacja jego poprawnoœci
model <- lm(log(y)~x)
summary(model)

shapiro.test(model$residuals)
t.test(model$residuals, mu=0)
plot(model$residuals)

# prognoza
predict(model, list(x=2030), level = 0.95, interval = 'p') # prognoza logY
exp(predict(model, list(x=2030), level = 0.95, interval = 'p')) # prognoza Y



# rysunki
# plot(x,y)
# lines(x, exp(-19.5577 + 0.0126*x), col=2, lwd=2)
# text(1960, 100, 'y = exp(-19.5577 + 0.0126*x)', col=2)
# abline(lm(y~x), col=4)
# 
# plot(x,log(y))
# abline(model, col=2, lwd=2)
# text(1990, 5, 'log(y) = -19.5577 + 0.0126*x', col=2)



# Zadanie 4
x <- c(2000, 2300, 2500, 2600, 2800, 3000, 3100, 3400,
       3700, 3800, 4000, 4600, 4800)
y <- c(15, 27, 20, 21, 31, 26, 22, 23, 32, 39, 27, 43, 53)

plot(x,y)
plot(x,sqrt(y))

# budowa modelu regresji i weryfikacja jego poprawnoœci
model <- lm(sqrt(y)~x)
summary(model)

shapiro.test(model$residuals) # p-value = 0.6339
t.test(model$residuals, mu=0) #  p-value = 1
plot(model$residuals) # chmura punktów

# prognoza
predict(model, list(x=3500), level = 0.95, interval = 'p') # prognoza sqrt(Y)
(predict(model, list(x=3500), level = 0.95, interval = 'p'))^2 # prognoza Y
(predict(model, list(x=3500), level = 0.95, interval = 'c'))^2 # prognoza EY

# rysunki
# par(mfrow=c(2,1))
# plot(x,y)
# lines(x, (2.3250882+0.0009152*x)^2, col=2, lwd=2)
# text(4000, 15, 'y = (2.3250882+0.0009152*x)^2', col=2)
# abline(lm(y~x), col=4)
# 
# plot(x,sqrt(y))
# abline(model, col=2, lwd=2)
# text(4000, 4, 'sqrt(y) = 2.3250882+0.0009152*x', col=2)


# Zadanie 5
x <- c(20, 30, 40, 50, 80, 140, 200, 250) 
y <- c(4.8, 3.2, 2.5, 2.5, 1.5, 1.8, 1.2, 0.8) 

par(mfrow=c(2,2))
plot(x,y)
plot(x, log(y))
plot(x, 1/y)
plot(1/x, y)
par(mfrow=c(1,1))

model1 <- lm(y~x) # Y = a + b*X
model2 <- lm(log(y)~x) # log(Y) = a + b*X
model3 <- lm(I(1/y)~x) # 1/Y = a + b*X
model4 <- lm(y~I(1/x)) # Y = a + b*(1/X)

# wspó³czynniki determinacji R^2 dla tych modeli:
summary(model1)$r.squared # 0.6529195
summary(model2)$r.squared # 0.8352768
summary(model3)$r.squared # 0.8873296
summary(model4)$r.squared # 0.9576566


summary(model4) # Y = 0.7552 + 78.0908*(1/X)
# Coefficients:
#             Estimate Std. Error t value Pr(>|t|)    
# (Intercept)   0.7552     0.1656   4.559  0.00385 ** 
# I(1/x)       78.0908     6.7037  11.649 2.41e-05 ***

shapiro.test(model4$residuals) # p-value = 0.2704
t.test(model4$residuals, mu=0) #  p-value = 1
plot(model4$residuals) # chmura punktów

predict(model4, list(x=100), level = 0.95, interval = 'c') # prognoza EY
#       fit      lwr     upr
#  1.536108 1.243547 1.82867



# Zadanie 8
x <- c(10, 25, 35, 50, 70, 80, 95, 110) #wielkosc produkcji
y <- c(25, 21, 20, 17, 14, 9, 4, 2) #koszt jednostkowy

plot(x,y,xlab="wielkosc produkcji", ylab="koszt jednostkowy")

# budowa modelu regresji i weryfikacja jego poprawnoœci
model <- lm(y~x)
summary(model)

abline(model,col="red", lwd=2)
segments(x,model$fitted,x,y)


shapiro.test(model$residuals) # p-value = 0.6774
t.test(model$residuals, mu=0) #  p-value = 1
plot(model$residuals) # chmura punktów

#prognoza wraz z 95% przedzialem ufnosci 

predict(model, list(x=40), int="c", level=0.95)
#       fit      lwr      upr
#  18.52432 17.15686 19.89179


# zadanie 9
y <- c(345, 320, 452, 422, 328, 375, 660, 466, 290) # wartosc budynku
x1 <- c(150, 180, 200, 160, 175, 180, 300, 170, 135) # powierzchnia
x2 <- c(5.6, 1.2, 2.4, 7.2, 2.9, 2.5, 5.5, 4.8, 1.6) # odleglosc od centrum

model <- lm(y~x1+x2) # Y = a0 + a1*X1 + a2*X2 + epsilon
summary(model)


model <- lm(y~x1+x2+0) # Y = a1*X1 + a2*X2 + epsilon
summary(model)


# ========================= ANOVA ===============================

# Zadanie 1 

x <- c(204,200,198,204,197,205,213,209,190,208,202,210)
czynnikA <- factor(rep(c('I','II', 'III'), each=4))

View(data.frame(x,czynnikA)) 


# Zadanie 2 

x <- c(19,22,20,18,25,21,24,17,20,21,33,27,
       29,30,22,23,16,15,18,26,17,23,20,19) # czas reakcji w milisekundach

czynnikA <- gl(3, 8, 24, labels = c('I','II','III'))

View(data.frame(x,czynnikA)) 


# Zadanie 3

auta <- read.csv2("http://www.ibspan.waw.pl/~pgrzeg/stat_lab/samochody.csv")

x <- auta$mpg
czynnikA <- factor(auta$producent, levels = c(1,2,3), labels = c('A','E','J'))





