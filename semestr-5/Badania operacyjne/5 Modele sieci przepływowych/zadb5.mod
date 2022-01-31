var af >= 0;
var ag >= 0;
var ah >= 0;
var bf >= 0;
var bg >= 0;
var bh >= 0;
var cf >= 0;
var cg >= 0;
var ch >= 0;

minimize funkcja_celu:
9*af+13*ag+7*ah + 10*bf + 7*bg+14*bh+3*cf+13*cg+4*ch;

subject to produkcja_A:
af+ag+ah <= 6;
subject to produkcja_B:
bf+bg+bh <= 11;
subject to produkcja_C:
cf+cg+ch <= 13;
subject to wykorzystanie_F:
af+bf+cf = 6;
subject to wykorzystanie_G:
ag+bg+cg = 13;
subject to wykorzystanie_H:
ah+bh+ch = 10;
