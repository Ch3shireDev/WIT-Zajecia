

us = read.csv('populacja_us.csv')


plot(us$rok, us$liczba)

# install.packages('tis')
library(tis)

growth.rate(us$liczba,lag=1,start=end(us$liczba)+1, simple=T)