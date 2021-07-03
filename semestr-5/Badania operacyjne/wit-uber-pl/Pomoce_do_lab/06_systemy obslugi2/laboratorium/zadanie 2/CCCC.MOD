2
0
CCCC

1;
---
0
0
0
1
+++++
1
1
generator zgloszen
0
1;
---
2
1
2
1
1
2
59;
---
---
5
tag<1000;
---
1;
---
---
---
tag:=tag+1;
---
+++++
1
2
stanowisko
0
stan>=1;
---
0
2
1
2
51;
---
---
1
stan:=stan-1;
---
---
stan:=stan+1; wy:=wy+1;
---
+++++
********
1
2
kolejka
2
1
---
kol:=kol+1;
---
czas_czek:=czas_czek+duration/1000; kol:=kol-1;
---
+++++
********
clock
System Variable
2
0.000000
+++++
czas_czek

2
0.000000
+++++
duration
System Variable
2
0.000000
+++++
kol

1
0.000000
+++++
run
System Variable
1
0.000000
+++++
stan

1
1.000000
+++++
tag
System Variable
1
0.000000
+++++
wy

1
0.000000
+++++
********
********
********
6

100.000000
1
10.000000
1
200.000000
data1
clock run czas_czek
---
+++++
********
0
********
