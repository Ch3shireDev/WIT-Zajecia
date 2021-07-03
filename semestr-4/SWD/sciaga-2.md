# Tematy na 2 kolokwium

## Regresja

### Przypadek modelu liniowego

01. Ustalamy zmienną zależną: $y$ oraz niezależną: $x$ dla próbki.
02. Rysujemy wstępny wykres - funkcja `plot(x, y)`.
03. Jeśli punkty mniej więcej układają się na prostej, zakładamy model liniowy. Jeśli nie, szukamy innej funkcji regresji.
04. Obliczamy korelację Pearsona, `cor(x,y)`. Wartości są pomiędzy `[-1 : 1]`, gdzie im bliżej 1 (lub -1) tym mocniejsza korelacja dodatnia (lub ujemna). Uwaga - interpretować korelację dla zależności liniowej możemy tylko wtedy, kiedy faktycznie dane układają się na prostej.
05. Przeprowadzamy `cor.test(x,y)` - dostajemy ten sam współczynnik korelacji, ale również test dla H0 - X i Y są niezależne. Wartość $p < \alpha$ oznacza odrzucenie hipotezy zerowej na poziomie istotności $\alpha$.
06. Jeśli nie udało się odrzucić H0, kończymy zadanie.
07. Obliczamy model `model = lm(y~x)` dla prostej regresji `y = a + b*x` i rysujemy go na wykresie przy użyciu `abline(model)`.
08. Możemy dodatkowo narysować reszty, funkcją `segments(x, model$fitted, x, y)`, oraz podpisać funkcję liniową, metodą `text(50,200, 'napis', col=3)`.
09. Tworzymy teraz model regresji prostej liniowej dla populacji (zamiast dla próbki). Najpierw ustalamy `Y = a + b*X + epsilon` i sprawdzamy, czy wyznaczony wcześniej model ma sens dla całej populacji.
10. Używamy `summary(model)` aby ustalić istotność wartości `a` oraz `b`.
11. Przyjmujemy pierwszą hipotezę H0 jako `b=0`, a drugą hipotezę `H0` jako `a=0`. Z `summary(model)` wyciągamy wartości `p-value` dla obydwu hipotez.

```

Call:
lm(formula = y ~ x)

Residuals:
    Min      1Q  Median      3Q     Max 
-37.445  -9.504   3.286   7.550  22.492 

Coefficients:
            Estimate Std. Error t value Pr(>|t|)    
(Intercept)  -30.344     17.484  -1.736    0.126    
x              5.466      0.415  13.172 3.39e-06 ***
---
Signif. codes:  0 ‘***’ 0.001 ‘**’ 0.01 ‘*’ 0.05 ‘.’ 0.1 ‘ ’ 1

Residual standard error: 18.8 on 7 degrees of freedom
Multiple R-squared:  0.9612,	Adjusted R-squared:  0.9557 
F-statistic: 173.5 on 1 and 7 DF,  p-value: 3.394e-06
```

12. Współczynnik `p-value` dla `a` znajujemy przy `(Intercept)` (ostatnia kolumna), współczynnik `p-value` dla `b` - przy `x`. Dodatkowo mamy wartość $R^2$ (`R-squared`). Wartość $R^2$ w zakresie od 0.6 do 1 jest ok. Wartość mniejsza od 0.8 jest średnio dobra, do 0.9 jest dobra, powyżej 0.9 jest bardzo dobra. 
13. Jeśli `p-value` jest mniejsze od `alpha` to odrzucamy H0, jeśli nie, to zostawiamy - w tym drugim wypadku tworzymy nowy model z wyzerowaną wartością.
14. Jeśli tworzymy nowy model z wyzerowanym `a`, to robimy to metodą:

```r
model2 = lm(y~x+0)
```

14. Sprawdzamy czy reszty (tj. `epsilon` z `Y = a + b*x + epsilon`) jest opisywany rozkładem normalnym. Robimy to poprzez `shapiro.test(model2$residuals)` dla H0: reszty mają rozkład normalny.
15. Jeśli `p-value` było większe od `alpha` (czyli rozkład jest normalny), to sprawdzamy dalej poprzez `t.test(model2$residuals, mu=0)` czy średnia reszt nie różni się w sposób istotny od 0. Jeśli nie, to dobrze.
16. Ostatecznie robimy `plot(reszty)` razem z `abline(h=0)` i sprawdzamy czy mamy chmurę punktów wokół linii `h=0`.
17. Jeśli chcemy oszacować wartość `y0` dla danej wartości `x0`, to robimy to poprzez `predict(model2, list(x=x0), level=0.95, interval='p')` (dla pojedynczej próbki - z 95% prawdopodobieństwem gdzie może wypaść wartość `y0` dla danego `x0`).
18. Możemy również oszacować wartość średniej dla danego `x0`:  `predict(model2, list(x=40), level=0.95, interval='c')`

### Przypadek modelu nieliniowego

01. Jeśli model nie jest liniowy, musimy go sprowadzić do liniowego - np. testując `lm(log(y)~x)` lub `lm(y~I(1/x))`.
02. Należy pamiętać o analizie reszt - `t.shapiro(model$residuals)`. Jeśli wynik ma `p-value < 0.05`, to znaczy że reszty nie spełniają rozkładu normalnego.
03. Być może kilka różnych modeli będzie wyglądało na pasujące. W takim przypadku porównujemy je poprzez wartość $R^2$ - wybieramy model o najwyższej wartości.
04. Przy stosowaniu funkcji `predict` pamiętamy o przywróceniu wartości `y` do oryginalnej postaci - np. jeśli model zawiera `log(y)`, wynik `predict` musimy poddać operacji `exp`.

## Analiza wariancji ANOVA

Będzie mini-zadanie a'la beton.
01. Wczytujemy dane.
02. Zapisujemy hipotezę że średnie są takie same.
03. Zawsze w ten sam sposób sprawdzamy założenia.
04. Jak są spełnione to ANOVA.
05. Jak nie są spełnione to Kruskal-Wallis.

06.  Jednoczynnikowa metoda ANOVA jest stosowana przy porównywaniu przynajmniej trzech grup danych o różnym czynniku. 
    

```
    x = c(204,200,198,204,197,205,213,209,190,208,202,210)
    czA = gl(3,4,12,labels=c("I","II","III")) # generate factor layers (3 po 4 z 12)
```

02.  Badamy hipotezę H0 - średnie wszystkich grup nie różnią się istotnie od siebie.
03.  Sprawdzamy czy są spełnione założenia testu ANOVA:
    01.  Czy dla każdego poziomu czynnika A zmienna X ma taką samą wariancję, tj. czy wariancje X1, X2, X3 nie różnią się istotnie?
    

```r
    # H0: Wariancje X1, X2, X3 nie różnią się istotnie.
    bartlett.test(x~czA)
    # Jeśli p-value > 0.05 to ok.
```

01.  Czy dla każdego poziomu czynnika A rozkład zmiennej X jest normalny, tj. czy X1, X2, X3 mają rozkłady normalne?
    

```r
    # H0: rozkłady X1, X2, X3 nie różnią się istotnie od rozkładów normalnych.
    tapply(x, czA, shapiro.test)
    # Jeśli każda z p-value > 0.05 to ok.
```

04. Jeśli założenia do testu ANOVA zostały spełnione, to możemy przeprowadzić test F:

```r
# H0: Średnie mu_1, mu_2, mu_3 nie różnią się w sposób istotny od siebie.
anova(lm(x~czA))
# Jeśli p-value (ostatnia wartość) > 0.05 to ok.
```

05. Jeśli okazałoby się, że któreś z założeń nie są spełnione, wtedy stosujemy test Kruskala-Wallisa:

```r
# H0: Średnie mu_1, mu_2, mu_3 nie różnią się w sposób istotny od siebie.
kruskal.test(x~czA)
# Jeśli p-value > 0.05 to ok.
```

## Dodatkowe pytania

* czy wiem co to jest zmienna zależna i zmienna niezależna, 
* czy umiem wstępnie ocenić zależność, 
* czy umiem wyznaczyć prostą regresji, 
* czy umiem zbudować model regresji i zweryfikować jego poprawność, 
* czy wiem co zrobić, gdy zależność wygląda na nieliniową, 
* czy potrafię zastosować model do wyznaczenia prognozy, 
* czy umiem zapisać hipotezę dla porównania więcej niż dwóch średnich?
* czy znam i potrafię zastosować testy do testowania hipotezy o więcej niż dwóch średnich.
