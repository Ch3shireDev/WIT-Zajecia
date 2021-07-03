# Wektor liczbowy czas zawiera dane o czasie przejazdu ze stacji metra Ratusz-Arsenał do stacji metra Wilanowska (w min) trzema środkami transportu. 
# Czynnik transport zawiera nazwy środków transportu. 
# Czy czasy przejazdu dla tych środków transportu różnią się istotnie? 
# Przeprowadź analizę ANOVA. Przyjmij poziom istotności 0,05.

czas = c(10.3, 9.9, 9.0, 10.1, 11.6, 11.4, 10.4, 11.4, 11.6, 11.6, 21.3, 18.0,
         21.2, 21.5, 20.3, 18.0, 19.3, 18.2, 23.6, 21.0, 22.7, 24.8, 25.1, 25.7, 24.4, 25.8,
         25.4, 23.9, 25.5, 25.2)
transport = gl(3, 10, 30, labels = c('metro', 'autobus', 'rower'))

# Aby przeprowadzić analizę ANOVA, musimy najpierw sprawdzić, czy:
# 1) Czy dla każdego poziomu czynnika (w tym przypadku, rodzaju transportu) zmienna X (czyli czas przejazdu) ma taką samą wartiancję,
# 2) Dla każdego poziomu czynnika A rozkład zmiennej X jest normalny.

# 1) Stawiamy H0: Wariancje X1, X2, X3 (czyli czasy dla metra, autobusu i roweru) nie różnią się istotnie.
bartlett.test(czas~transport)

# Bartlett test of homogeneity of variances
# 
# data:  czas by transport
# Bartlett's K-squared = 5.6824, df = 2, p-value = 0.05836

# p-value > 0.05 (chociaż ledwie), zatem nie udało nam się odrzucić hipotezy zerowej. Wariancje X1, X2, X3 nie różnią się istotnie,
# zatem warunek 1) jest spełniony.

# 2) Stawiamy H0: Dla każdego rodzaju transportu rozkład czasów przejazdu jest normalny.
tapply(czas, transport, shapiro.test)
# $metro
# 
# Shapiro-Wilk normality test
# 
# data:  X[[i]]
# W = 0.86066, p-value = 0.07768
# 
# 
# $autobus
# 
# Shapiro-Wilk normality test
# 
# data:  X[[i]]
# W = 0.91501, p-value = 0.3172
# 
# 
# $rower
# 
# Shapiro-Wilk normality test
# 
# data:  X[[i]]
# W = 0.87169, p-value = 0.1046

# We wszystkich trzech przypadkach p-value > 0.05, zatem nie udało nam się odrzucić H0. Przyjmujemy że dla każdego rodzaju transportu rozkład czasów przejazdu jest normalny.

# Ponieważ założenia analizy ANOVA są spełnione, możemy dokonać testu F.

# H0: średnie czasów przejazdu dla różnych rodzajów transportów nie różnią się od siebie w sposób istotny.
anova(lm(czas~transport))

# Analysis of Variance Table
# 
# Response: czas
# Df  Sum Sq Mean Sq F value    Pr(>F)    
# transport  2 1036.89  518.44  301.75 < 2.2e-16 ***
#   Residuals 27   46.39    1.72                      
# ---
#   Signif. codes:  0 ‘***’ 0.001 ‘**’ 0.01 ‘*’ 0.05 ‘.’ 0.1 ‘ ’ 1

# Ponieważ p-value << 0.05, to z całą pewnością możemy odrzucić H0 - zatem średnie czasów przejazdu różnią się w sposób istotny od siebie.

boxplot(czas~transport, horizontal=TRUE)

# Widzmy na wykresach pudełkowych, że czasy przejazdów różnią się od siebie.
