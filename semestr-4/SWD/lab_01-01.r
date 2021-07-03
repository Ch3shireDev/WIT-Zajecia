# library(zeallot)

# Ponizsze dane przedstawiaja liczbe nowych kont zarejestrowanych w ciagu kolejnych 10 dni

data = c(43,37,50,51,58,105,52,45,45,10)

# a) Oblicz srednia, mediane, kwartyle oraz odchylenie standardowe. 

s = summary(data)

min = min(data)
print("Min: ")
print(min)
q1 = s[2] # pierwszy kwartyl - liczba ponizej której jest 25% wartosci
median(data) #s[3] # drugi kwartyl, mediana - liczba ponizej której jest 50% wartosci
mean(data) #s[4] # srednia
q3 = s[5] # trzeci kwartyl - liczba ponizej której jest 75% wartosci
max(data) # czwarty kwartyl, najwyzsza wartosc - liczba ponizej której jest 100% wartosci

sd(data) # odchylenie standardowe

# Zinterpretuj otrzymane wartosci.

# b) Sprawdz czy sa obecne obserwacje odstajace (zgodnie z regula 1,5*IQR).

boxplot(data) 
# boxplot tworzy wykres skrzynkowy. Brana jest mediana i zakres od pierwszego 
# do trzeciego kwartylu.
iqr = IQR(data)

# wartosc minimalna na wykre

print(iqr)
print(q3-q1)

whisker_left = q1 - 1.5*iqr
whisker_right = q3 + 1.5*iqr

print(whisker_left)
print(whisker_right)

data[data<whisker_left]
data[data>whisker_right]

# c) Usun zidentyfikowane obserwacje odstajace i oblicz ponownie srednia, mediane, kwartyle i odchylenie standardowe.
# Jaki wplyw na wyznaczone statystyki mialy obserwacje odstajace?

data_new = data[data>=whisker_left & data <= whisker_right]
summary(data)
sd(data)
summary(data_new)
sd(data_new)