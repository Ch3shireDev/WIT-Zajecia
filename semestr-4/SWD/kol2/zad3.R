# Dla wybranych losowo samochodów produkcji japońskiej badano
# zużycia paliwa w milach przejechanych na jednym galonie (zmienna mpg) względem wielkości ich mocy (zmienna horsepower).
# Dane o 15 losowo wybranych samochodach są następujące:

# mpg
y = c(43.1, 20.3, 17, 21.6, 16.2, 31.5, 31.9, 25.4, 27.2, 37.3, 41.5, 34.3, 44.3, 43.4, 36.4)
# horsepower
x = c(48, 103, 125, 115, 133, 71, 71, 77, 71, 69, 76, 78, 48, 48, 67)

# Zmienna niezależna to moc silnika (x), zmienna zależna to mpg (y)

# a) Wyznacz możliwie najlepszy model regresji opisujący badaną zależność.

plot(x,y)
# propozycja 1 - zależność liniowa y~x

model1 = lm(y~x)
summary(model1)
# mamy R-squared = 0.8255 - dobry, ale może znajdziemy coś lepszego.

# propozycja 2 - zależność hiperboliczna y~1/x
model2 = lm(y~I(1/x))
summary(model2)
# mamy R-squared = 0.8059 - gorsza niż liniowa.

# propozycja 3 - zależność wykładnicza log(y)~x
model3 = lm(log(y)~x)
summary(model3)
# R-squared = 0.872 - lepsza niż liniowa. Ponieważ nie jestem w stanie znaleźć niczego lepszego, zatrzymam się na tym.

plot(x,log(y))
abline(model3)

# b) Zweryfikuj dopasowanie modelu.

# Postulujemy, że model dla populacji to log(Y) = 4.341 - 0.011*X + epsilon.
# Mamy kilka hipotez do przetestowania:

# 1) H0: b = 0
# 2) H0: a = 0

summary(model3)

# W obydwu przypadkach - wyraz wolny i x - mamy p-value << 0.05, zatem możemy śmiało odrzucić obydwie hipotezy zerowe.
# Ponadto R-squared = 0.872, co wskazuje że model jest dobrze dopasowany do danych.

# 3) H0: Rozkład reszt (epsilon) nie różni się w sposób istotny od rozkładu normalnego.
e = model3$residuals
shapiro.test(e)
# p-value = 0.5714, nie udało nam się odrzucić H0, zatem możemy przyjąć, że reszty mają rozkład normalny.

# 4) H0: Średnia reszt nie różni się w sposób istotny od 0.

t.test(e, mu=0)
# p-value = 1, zatem nie udaje nam się odrzucić H0. Istotnie, reszty mają średnią równą zero i ich rozkład jest normalny.

# 5) Reszty powinny przyjmować kształt chmury.

plot(x,e)
abline(h=0)

# Wygląda jak chmura punktów, jest ok.

# c) Oszacuj zużycie paliwa auta z mocą 90KM.

exp(predict(model3, list(x=90), interval='p'))
# fit      lwr      upr
# 1 26.5417 19.97436 35.26829

# Szacujemy, że dla 90KM z 95% prawdopodobieństwem wartość MPG będzie zawarta pomiędzy 19.97 a 35.26, ze średnią w 26.54.

exp(predict(model3, list(x=90), interval='c'))
# fit      lwr      upr
# 1 26.5417 24.60528 28.63051

# Dla wielu powtórzeń średnia wartość MPG (przy mocy 90KM) z 95% zawiera się pomiędzy 24.605 a 28.63, ze średnią w 26.54.

# Nasze szacunkowe zużycie paliwa dla 90KM to 26.54.