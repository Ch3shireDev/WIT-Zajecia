
# Zmienna nie
x = c(58,69,43,39,63,52,47,31,74,36)
y = c(189,235,193,177,154,191,213,175,198,181)

cor.test(x,y)

# Chujowa korelacja, pierdolę nie robię.

model = lm(y~x)
summary(model)

# Chujowy R-squared, pierdolę nie robię.