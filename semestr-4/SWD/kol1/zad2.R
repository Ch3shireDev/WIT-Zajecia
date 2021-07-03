

data = c(43, 56, 49, 41, 32, 42, 45, 56, 46, 38, 37, 32, 41, 53, 38, 44, 51, 45, 42, 40, 42, 44, 47, 35, 41, 36, 26, 36, 56, 36)
sigma = 7

# wiemy ze czas instalacji ma rozkład normalny, znamy również odchylenie standardowe, zatem możemy skorzystać z Modelu 1 z estymacji parametrycznej
# tj. z funkcji z.test. Domyślny parametr dla z.test to właśnie 95% przedziału ufności

z.test(data, stdev=sigma)
#95 percent confidence interval:
#39.82846 44.83821

# Wynik: 12 punktów