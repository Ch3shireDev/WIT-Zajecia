#!/bin/bash

read -p "Podaj napis (tylko cyfry i litery): " raz

id > \[0-9]_${raz}

k=3
let l=2*k
m=$k
echo -n OK, I\'m working\ 
for i in OTO nr 4 0
do
 if [ $i != "0" ]
 then
  name=${l}_${raz}-$i${m}
 else
  name=${l}_${raz}-${m}
  uname -i > ${name}
 fi
 date >> ${name}
 if [ $i == "-" ]
 then
  uname -v | cut -f-2 -d \  >> ${name}
 fi
 echo -n .
 sleep 1
 let k=k-1
 let l=2*k
 m=${m}${k}
done
echo -e \\n done.
