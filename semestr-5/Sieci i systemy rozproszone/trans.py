# a)  POCZĄTEK_TRANSAKCJI
#     X = 3; Y = 0; X = X - Y; Y = Y - 2;
#     KONIEC_TRANSAKCJI
# b)  POCZĄTEK_TRANSAKCJI
#     X = 2; Y = -3; X = X + 3; Y = X - Y + 1;
#     KONIEC_TRANSAKCJI
# c)  POCZĄTEK_TRANSAKCJI
#     X = 0; X = X + 6; Y = 4; Y = Y + X;
#     KONIEC_TRANSAKCJI

def trans_a(x, y):
    x = 3
    y = 0
    x = x - y
    y = y - 2
    return x, y


def trans_b(x, y):
    x = 2
    y = -3
    x = x+3
    y = x - y + 1
    return x, y


def trans_c(x, y):
    x = 0
    x = x+6
    y = 4
    y = y+x
    return x, y


a,b,c = trans_a,trans_b,trans_c

def fun(a,b,c):
    x, y = 0, 0
    x, y = a(x, y)
    x, y = b(x, y)
    x, y = c(x, y)
    print(f"{x=} {y=}")

fun(c,b,a)
fun(a,c,b)
fun(b,a,c)
fun(b,c,a)
fun(c,a,b)
fun(a,b,c)