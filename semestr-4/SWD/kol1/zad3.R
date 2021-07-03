# a)

TempF5 = airquality$Temp[airquality$Month == 5]

# przekształcam temperaturę w skali Fahrenheita do skali Celsiusza
TempC5 = (TempF5 - 32)*5/9

# b) testowanie hipotezy. H0: temperatura w maju nie różni się w sposób istotny od 4 stopni C.
# poziom istotności: 0.05

alpha = 0.05
mu0 = 4

# nie wiemy czy rozkład jest normalny oraz nie znamy odchylenia standardowego. Korzystamy z testu Shapiro
# starając się obalić hipotezę że rozkład temperatur ma rozkład inny niż normalny

shapiro.test(TempC5)
# p-value = 0.1349

# możemy stwierdzić, że rozkład TempC5 nie różni się w sposób istotny od rozkładu normalnego. Zatem wolno nam korzystać z testu t-studenta

t.test(TempC5, mu=4)
# t = 21.401, df = 30, p-value < 2.2e-16
# alternative hypothesis: true mean is not equal to 4

# wartość p jest grubo poniżej 5%, zatem możemy stwierdzić że udało nam się odrzucić hipotezę H0 - średnia temperatur w maju różni się istotnie od 4 stopni celsjusza.


# Wynik: 3 punkty