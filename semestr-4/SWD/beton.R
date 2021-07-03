

x = c(204,200,198,204, 197,205,213,209,190,208,202,210)
czA = gl(3,4,12,labels=c("I", "II", "III"))


# Dwa założenia dla ANOVY

# 1) H0: średnie u1, u2, u3 nie różnią się istotnie
bartlett.test(x~czA)
# Jest spełnione

# 2) H0: Każdy z tych rozkładów ma rozkład normalny
tapply(x,czA, shapiro.test)
# Każdy z nich ma rozkład normalny

# Obydwa założenia są spełnione, zatem wolno nam użyć testu ANOVA, tj. test F

# H0 : średnie są takie same
anova(lm(x~czA))
# p-value > 0.05, zatem średnie są takie same


kruskal.test(x~czA)



## Dodatkowe pytania

# * czy wiem co to jest zmienna zależna i zmienna niezależna, 
# * czy umiem wstępnie ocenić zależność, 

cor.test(x,y)

# * czy umiem wyznaczyć prostą regresji,

model = lm(y~x)

# * czy umiem zbudować model regresji i zweryfikować jego poprawność, 

# 1) H0: b = 0
# 2) H0: a = 0
# 3) R-squared > 0.6
# 4) shapiro.test(model$residuals) p-value > 0.05
# 5) t.test(model$residuals) p-value > 0.05
# 6) chmura punktów

# * czy wiem co zrobić, gdy zależność wygląda na nieliniową,



# * czy potrafię zastosować model do wyznaczenia prognozy, 



# * czy umiem zapisać hipotezę dla porównania więcej niż dwóch średnich?
# * czy znam i potrafię zastosować testy do testowania hipotezy o więcej niż dwóch średnich.
