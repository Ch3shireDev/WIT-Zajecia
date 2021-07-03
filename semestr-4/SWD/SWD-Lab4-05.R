

x = c(20,30,40,50,80,140,200,250)
y = c(3.8,3.2,2.5,2.5,1.5,1.8,1.2,0.8)

# y = a + b/x
cor.test(x,y) # dobra/b. dobra korelacja ujemna -0.87

model1 = lm(y~I(1/x)) #0.9224
summary(model1)

model2 = lm(I(1/y)~x) #0.8889
summary(model2)

model3 = lm(y~x) #0.7732
summary(model3)

model4 = lm(y~I(1/x^2)) #0.78
summary(model4)

# Zatem wybieramy model 1

# Dopasowanie modelu Y = a + b*1/X + epsilon

summary(model1)

e = model1$residuals
shapiro.test(e)
# Nie udało się odrzucić że normalny, więc ok
t.test(e)
# Nie udalo sie odrzucic ze srednia w zerze wiec ok

plot(e)
abline(h=0)
# Wykurwista chmura punktów


plot(I(1/x), y)
abline(model1)

predict(model1, list(x=100), interval='p')
# fit       lwr      upr
# 1 1.573119 0.7555219 2.390715


predict(model1, list(x=100), interval='c')
# fit       lwr      upr
#  1.573119 1.256583 1.889654