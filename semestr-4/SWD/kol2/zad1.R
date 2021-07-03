# Badano zależność miesięcznych wydatków na rozrywki mieszkańców pewnego miasta od wysokości ich miesięcznych dochodów. 
# Poniższa tabela zawiera informacje o 7 losowo wybranych osobach.

y = c(186, 700, 490, 385, 266, 357, 650) # wydatki na rozrywki
x = c(2800, 4200, 3500, 3150, 2975, 3175, 3850) # dochody

# zmienna niezależna (x) to dochody, zmienna zależna to wydatki na rozrywki (y)

# a) Narysuj wykres rozproszenia i wyznacz współczynnik korelacji. Jak wstępnie możesz ocenić tę zależność?

plot(x,y) 
# punkty układają się na linii, zatem wstępnie możemy przyjąć model regresji liniowej.

cor.test(x,y) 
# bardzo wysoki dodatni współczynnik korelacji (0.986), zatem ewidentnie y koreluje z x.

# b) Wyznacz liniowy model regresji opisujący badaną zależność.

model = lm(y~x)
# y = -837.2466 + 0.3761*x + epsilon

# c) Zweryfikuj dopasowanie modelu.

# Stawiamy dwie hipotezy:

# 1) H0: b = 0, zatem dla populacji wydatki na rozrywki nie korelują z dochodami
# 2) H0: a = 0

summary(model)

# 1) Dla x (wartości b) mamy p-value 4.28e-05, zatem odrzucamy H0 z 1)
# 2) Dla Intercept (wartości a) mamy p-value = 0.000334, zatem odrzucamy H0 z 2)

# Dostaliśmy również R-squared = 0.9726, zatem jest to bardzo dobry model dla populacji.

# 3) Pozostaje kwestia reszt. Reszty (czyli epsilon) powinny mieć rozkład normalny ze średnią mu w zerze.

e = model$residuals

# H0: Rozkład e nie różni się w sposób istotny od rozkładu normalnego
shapiro.test(e)
# p-value = 0.6232, nie udało się odrzucić hipotezy zerowej, zatem przyjmujemy że epsilon istotnie ma rozkład normalny

# H0: Średnia mu nie różni się w sposób istotny od 0.
t.test(e, mu=0)
# p-value = 1, nie udało odrzucić się hipotezy zerowej - przyjmujemy zatem, że średnia epsilon nie różni się istotnie od rozkładu normalnego.

# Powinniśmy również uzyskać chmurę punktów po narysowaniu.

plot(e)
abline(h=0)

# Zakładam że jest to chmura punktów, więc wszystko jest ok.

# na podstawie tych wszystkich testów ustalamy, że w/w model bardzo dobrze opisuje nie tylko próbkę, ale i całą populację.

# d) Podaj przewidywaną wysokość wydatków na rozrywki osoby o dochodach w wysokości 4000zł. Podaj 95% przedział ufności dla prognozy. Zinterpretuj otrzymany wynik.

predict(model, list(x=4000), interval='p')
# fit      lwr      upr
# 1 667.1468 561.7982 772.4955

# Dla losowej osoby z populacji o zarobkach x = 4000 zł możemy z 95% prawdopodobieństwem stwierdzić, że jej wydatki na przyjemności będą zawarte pomiędzy 561.8 a 772.5 zł,
# z medianą równą 667 zł.

predict(model, list(x=4000), interval='c')
# fit      lwr      upr
# 1 667.1468 610.8464 723.4473

# Dla średniej próby z populacji możemy z 95% pewnością przyjąć, że wartość będzie zawarta pomiędzy 610.84 a 723.44 zł, również z medianą równą 667 zł.

# Interpretacja wyników - w danej populacji ludzie przeznaczają określony procent dochodów - pomiędzy 15 a 18% - na przyjemności.