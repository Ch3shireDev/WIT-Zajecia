
# zmienna niezależna - roczny dochód
x = c(36,64,49,21,28,47,58,19,32)

# zmienna zależna - wartość domu
y = c(129,310,260,92,126,242,288,81,134) 

r = cor(x,y)

#
cor.test(x,y)