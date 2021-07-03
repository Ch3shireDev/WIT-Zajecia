#!/bin/bash
#zsk3.sh: uzcie interfejsu snmp
#in1 = snmpget -v1 - c public sz209 ifInOctet2, ifOuttoctet.0
#skrypt co na tej podstawie wyliczy % uzycie interfejsu
#ich ronica w odstepie x sek
#czyli max z tych 2
#przez 

HOST=localhost

in1=`snmpget -v1 -c public $HOST ifInOctets.2|cut -f4 -d' ' `
out1=`snmpget -v1 -c public $HOST ifOutOctets.2|cut -f4 -d' ' `

sleep 60

in2=`snmpget -v1 -c public $HOST ifInOctets.2|cut -f4 -d' ' `
out2=`snmpget -v1 -c public $HOST ifOutOctets.2|cut -f4 -d' ' `

let in=$in2-$in1
let out=$out2-$out1

speed=`snmpget -v1 -c public $HOST ifSpeed.2|cut -f4 -d' ' `

let inuse=$in*8/$speed 
let outuse=$out*8/$speed 

echo "uzycie interfejsu wynosi: " 

if [ "$inuse" -gt "$outuse" ]
  then
     echo $inuse
  else
     echo $out
  fi 
 
exit 0