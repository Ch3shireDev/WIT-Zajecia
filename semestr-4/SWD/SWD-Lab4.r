
# zmienna niezalezna - roczny dochód
x = c(36,64,49,21,28,47,58,19,32)

# zmienna zalezna - wartosc domu
y = c(129,310,260,92,126,242,288,81,134) 

r = cor(x,y)
cor.test(x,y)

# prosta regresji wartosci domu wzgledem dochodu
model = lm(y~x)



plot(x,y)
abline(model)
segments(x, model$fitted, x,y)

model

# y = -30.344 + 5.466 x

# b) Przeanalizuj dopasowanie modelu

summary(model)

# Multiple R-squared: 0.9612
# B. dobry model, bo R-squared > 0.9

# Mamy dwie hipotezy do sprawdzenia

# 1) H0: b = 0
# Poniewaz p-value jest < 5%, to b != 0

# 2) H0: a = 0
# Poniewaz p-value jest > 5%, to nie udalo sie odrzucic H0, zatem przyjmujemy a = 0 dla populacji.

# Nowy model:

model2 = lm(y~x+0)




summary(model2)

# Jeszcze lepsze dopasowanie, multiple R-squared = 0.9905

# Zatem dla populacji mamy wzór:

# Y = 4.7940*X + Epsilon

# Sprawdzamy, czy reszty w danych spelniaja rozklad normalny

e = model2$residuals

# H0: rozklad e nie rózni sie od rozkladu normalnego
shapiro.test(e)
# p-value=0.8283, zatem nie odrzucamy H0, zatem rozklad e ~ N

# H0: srednia e nie rózni sie w sposób istotny od 0
t.test(e)
# p-value = 0.58, zatem nie odrzucamy H0

# teraz robimy chmure

plot(e)
abline(h=0)
# mamy wykurwista chmure punktów a Hubert nie wie co gada

# c)

predict(model2, list(x=40), level=0.95, interval='p')
# Szacowane dla pojedycznej rodziny z 95% przedzialem ufnosci jest pomiedzy 140 tys $ a 242 tys $,
# czyli srednio 191 tys dolarow

predict(model2, list(x=40), level=0.95, interval='c')
# Szacowane dla sredniej z wielu rodzin z 95% przedzialem ufnosci jest rowne 191, pomiedzy 176 a 207.

4.7940*40