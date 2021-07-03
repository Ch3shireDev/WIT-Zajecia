#!/bin/bash
#zsk3.sh: uzcie interfejsu snmp
#in1 = snmpget -v1 - c public sz209 ifInOctet2, ifOuttoctet.0
#skrypt co na tej podstawie wyliczy % uzycie interfejsu
#ich ronica w odstepie x sek
#czyli max z tych 2
#przez 

HOST=localhost
TIME=30

in1=`snmpget -v1 -c public $HOST ifInOctets.2|cut -f4 -d' ' `
out1=`snmpget -v1 -c public $HOST ifOutOctets.2|cut -f4 -d' ' `

sleep $TIME

in2=`snmpget -v1 -c public $HOST ifInOctets.2|cut -f4 -d' ' `
out2=`snmpget -v1 -c public $HOST ifOutOctets.2|cut -f4 -d' ' `

let in=$in2-$in1
let out=$out2-$out1

speed=`snmpget -v1 -c public $HOST ifSpeed.2|cut -f4 -d' ' `


let speed_t=$speed*$TIME 

let inuse=$in*100*8/$speed_t 
let outuse=$out*100*8/$speed_t 

if [ "$inuse" -gt "$outuse" ]
  then
     echo "uzycie interfejsu wynosi: $inuse %"
  else
     echo "uzycie interfejsu wynosi: $outuse %"
  fi 
 
exit 0