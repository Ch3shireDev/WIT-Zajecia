#!/bin/bash
#zsk4.sh: snpwalk

HOST=sz210.wsisiz.edu.pl
szukane=sysDescr

zmienna=`snmpget -v1 -c public -Of $host $szukane | tr '.' '\n' |grep $zmienna2 -n | cut -d':' -f1`
zmienna2=`echo $zmienna | cut -d'.' -f1`

let index_pre=$zmienna2-1

pre=snmpget -v1 -c public -Of $HOST $zmienna | cut -d'.' -f$index_pre

echo $pre


