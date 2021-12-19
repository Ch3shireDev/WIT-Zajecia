var w1 >= 0;
var w2 >= 0;
var w3 >= 0;
var w4 >= 0;

maximize funkcja_celu:
4*w1 + 5*w2 + 6*w3 + 5*w4;

subject to ograniczenie1:
4*w1 + 3*w2 + 3*w3 + 1*w4 <= 35;
subject to ograniczenie2:
1*w1 + 8*w2 + 8*w3 + 4*w4 <= 40;
subject to ograniczenie3:
2*w1 + 6*w2 + 6*w3 + 6*w4 <= 60;