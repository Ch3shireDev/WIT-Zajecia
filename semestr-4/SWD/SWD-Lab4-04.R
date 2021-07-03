x = c(2000,2300,2500,2600,2800,3000,3100,3400,3700,3800,4000,4600,4800)
y = c(15,27,20,21,31,26,22,23,32,39,27,43,53)

cor.test(x,y)

# dobry model (b. dobry od 0.9)

model = lm(sqrt(y)~x)
summary(model)

# R-squared: 0.72

# model dobry, ale dupy nie urywa

# sqrt(Y) = 2.3250882 + 0.0009152*X + epsilon

# plot(x,sqrt(y))
# abline(model)

e = model$residuals

plot(e)
abline(h=0)
# Wykurwista chmura punktów

# H0: e nie rozni sie od normalnego
shapiro.test(e)
# p-value 0.63 zatem normalny

t.test(e)
# p-value 1 zatem ma w zerze

predict(model, list(x=3500), interval='p')^2

# Srednia wypadkow 30.56 pomiedzy 18.87 a 45 z 95% prawd


predict(model, list(x=3500), interval='c')^2

# Średni wynik 30.56 pomiedzy 27 a 34 z 95% prawd