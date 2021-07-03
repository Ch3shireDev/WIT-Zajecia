

# dostępne testy dla H0: mu=mu0: 
# - t.test - test t-studenta dla:
#   - rozkładu normalnego o nieznanej sigmie
#   - lub dla dużej próby
# - z.test dla znanej sigmy (TeachingDemos)

# dostępne testy dla weryfikacji hipotezy H0: sigma^2 = sigma_0^2
# - sigma.test  (TeachingDemos)

# dostępne testy dla weryfikacji hipotezy H0: p=p0
# - binom.test
# - prop.test

# przypisujemy mu=mu0, stdev=sigma, sigma=sigma_0, p=p0, k=liczba sukcesów w próbie, n=liczność próby

#zad 1
data = c(1.36,1.14,1.27,1.15,1.20,1.29,1.27,1.18,1.23,1.36,1.38,1.37,1.30,1.21,1.33,1.28,1.32,1.29,1.33,1.25)
mu0 = 1.20
sigma0 = 0.07
n = 20
alpha = 0.04

# install.packages('TeachingDemos')
library(TeachingDemos)

# ponieważ chcemy zweryfikować hipotezę że wartość mu jest większa niż mu0, używamy alt='g'
# ponieważ znamy sigmę oraz chcemy ustalić mu, stosujemy z.test

value = z.test(data, mu0, sigma0, alt='g')$p.value
value
value < alpha

# zad 2

x = chickwts
data = x$weight[x$feed=='soybean']
alpha = 0.05
mu0 = 2.6

# a) nie mamy sigma, więc używamy t.test
# chcemy zweryfikować hipotezę H1 czy mu > 2.6, a zatem odrzucić hipotezę H0 że mu0 <= 2.6

t.test(data, alt='g', mu=mu0)$p.value < alpha

# b) szukamy odchylenia standardowego, hipoteza H0 jest że sigma=sigma0=50
# używamy sigma.test

sigma.test(data, sigma=50, alt='t')

# p-value = 0.58 dla hipotezy że sigma różni się od 50, zatem przyjmujemy, 
# że sigma nie różni się istotnie od 50

# zad 10

data1 = c(145,150,153,148,141,152,146,154,139,148)
data2 = c(152,150,147,155,140,146,158,152,151,143,153)

#wybieram less bo testuję hipotezę czy srednia(data1) < srednia(data2)
t.test(data1, data2, alt='l', var.equal=TRUE)

# zad 7

n1 = 250
k1 = 10
n2 = 300
k2 = 18

alpha = 0.02

# czy jakosc tych partii rozni sie istotnie?
# czyli H0 = eq, H1 = neq

prop.test(c(k1,k2), c(n1,n2), alt='t')
# proby nie roznia sie istotnie, bo p >> 0.05