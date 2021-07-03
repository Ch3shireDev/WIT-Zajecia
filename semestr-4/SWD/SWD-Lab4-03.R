x = c(1890,1900,1910,1920,1930,1940,1950,1960,1970,1980,1990,2000,2010,2020)
y = c(62.947,75.994,91.972,105.710,122.775,131.669,150.697, 179.323,203.235,226.542,248.718,281.422,308.746,323.996)

cor.test(x,y)
# Zajebista korelacja.

# a więc - mamy wykładniczy model wzrostu populacji, czyli y = exp(a + b*x) LUB log(y) = a+b*x

model = lm(log(y)~x)

summary(model)

# log(y) = -1.956e+01  + 1.260e-02*x + epsilon

plot(x,log(y))
abline(model)
segments(x,model$fitted,x,log(y))

# Dwie hipotezy:

# 1) H0: b = 0
# Odrzucamy, bo p<5%

# 2) H0: a = 0
# Odrzucamy, bo p<5%

e = model$residuals

# Model jest pieprznięty bo reszty nie mają rozkładu normalnego.
shapiro.test(e)

t.test(e)

plot(e)
abline(h=0)

# Pieprznięty model



exp(predict(model, list(x=2030), interval='p'))

# Oczekujemy populacji 408 milionów, z 95% przedziałem ufności pomiędzy 354 a 472.