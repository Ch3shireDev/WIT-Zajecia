T = airquality$T[airquality$Month == 8]

# a)
# podsumowanie
summary(T)
# Min. 1st Qu.  Median    Mean 3rd Qu.    Max. 
# 72.00   79.00   82.00   83.97   88.50   97.00 

# srednia
mean(T)
# 83.96774

# odchylenie standardowe
sd(T)
# 6.585256

# b)
# 25 percentyl
quantile(T, probs=c(0.25))
# 79

# c)

shapiro.test(T)
# p-value jest 0.3688, zatem rozkład T nie różni się w sposób istotny od rozkładu normalnego

# d) wykres skrzynkowy

boxplot(T)

# Wynik: 11 punktów