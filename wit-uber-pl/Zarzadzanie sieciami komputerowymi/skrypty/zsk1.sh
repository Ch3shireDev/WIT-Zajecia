#!/bin/bash
#zsk1.sh: baza_urzadzen
#towrzenie bazy urzadzen pracujacej w tej sieci
#skrypt uruchmiany z crona
#sprawdza, czy pojawilysie nowe urzadzenia, jak tak to dodac do bazy

i=1
while [ $i -ne 254 ]
do

ping -c 1 -i 0.4 213.135.45.$i  

i=$(( $i + 1 ))

done

i=1

while [ $i -ne 254 ]
do

arp -a 213.135.45.`echo $i` | grep -v incomplete >> ./lista

i=$(( $i + 1 ))

done
