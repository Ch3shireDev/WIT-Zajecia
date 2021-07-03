# pobieram dane z biblioteki
library(MASS)
x = Pima.te

# wyszczególniam dwie grupy danych - age_diab jako wiek kobiet z cukrzycą
age_diab = x$age[x$type == 'Yes']

# age_ndiab jako wiek kobiet bez cukrzycy
age_ndiab = x$age[x$type == 'No']
alpha = 0.01

# obydwa zbiory danych są niezależne (tj. różne osoby), są duże (n > 25). Mogę zatem użyć testu t-studenta, tj. t-test.
# stawiana hipoteza H0 jest następująca: średnia wieku indianek z jednej grupy nie różni się od średniej wieku z drugiej grupy

t.test(age_diab, age_ndiab)
# wynik p-value = 2.746e-07, zatem możemy odrzucić hipotezę H0. 
# Wiek indianek z cukrzycą różni się w sposób istotny od wieku indianek bez cukrzycy

# średnia wieku indianek z cukrzycą
mean(age_diab)

# średnia wieku indianek bez cukrzycy
mean(age_ndiab)


# Wynik: 10 punktów