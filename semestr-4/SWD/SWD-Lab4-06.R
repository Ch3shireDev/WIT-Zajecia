x = c(55,50.5,43.5,42.5,42,41,35.7,34.5,33,32)
y = c(0.223,0.925,6.75,18.1,29.1,50.5,126,215,445,420)

cor.test(x,y)
# Sensowna korelacja ujemna, tj. dobra

plot(x,y)

model1 = lm(y~I(1/x)) #0.7594
summary(model1)
model2 = lm(log(y)~x) #0.9819
summary(model2)

plot(x,log(y))
abline(model2)

e = model2$residuals

shapiro.test(e)

t.test(e)

plot(e)
abline(h=0)

# Zatem szacujemy

exp(predict(model2, list(x=40), interval='p'))
# fit      lwr      upr
# 1 37.07198 15.30407 89.80175

exp(predict(model2, list(x=40), interval='c'))
# fit      lwr      upr
# 1 37.07198 28.32889 48.51344