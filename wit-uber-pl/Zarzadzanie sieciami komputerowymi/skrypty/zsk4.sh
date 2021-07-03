#!/bin/bash
#zsk4.sh: snpwalk
#by @Michal Pawlowski

HOST=localhost
SZUKANE=$1

NEXT=$SZUKANE

STOP_C=`snmpgetnext -v1 -c public -Of $HOST $NEXT | grep $SZUKANE -ci`

snmpgetnext -v1 -c public $HOST $NEXT
NEXT=`snmpgetnext -v1 -c public  $HOST $NEXT | cut -d':' -f3 |cut -d ' ' -f1` 

while [ $STOP_C  -eq 1 ] ; do
    snmpgetnext -v1 -c public $HOST $NEXT
	NEXT=`snmpgetnext -v1 -c public  $HOST $NEXT | cut -d':' -f3 |cut -d ' ' -f1`
	STOP_C=`snmpgetnext -v1 -c public -Of $HOST $NEXT | grep $SZUKANE -ci`
	
	#echo stop c: $STOP_C
	#echo next: $NEXT
done
