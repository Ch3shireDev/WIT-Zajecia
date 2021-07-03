#!/bin/bash

alarmtime=160000

current=`cat /var/log/messages | wc -l`
last_l=`cat /tmp/lines`
#last_l=0

cat /var/log/messages | wc -l > /tmp/lines

let diff_l=$current-$last_l

if [ "$diff_l" = 0 ]
    then
	exit 0
else
    if [ 0 -gt "$diff_l" ]
	then
	    let diff_l=$current
    fi
fi

noferr=`tail -n $diff_l /var/log/messages | grep "Security alarm" | cut -f3 -d' ' | tr -d ':'|wc -l`

if [ "$noferr" = 0 ] 
    then
	exit 0
fi

hoferr=`tail -n $diff_l /var/log/messages | grep "Security alarm" | cut -f3 -d' ' | tr -d ':'|tail -n 1`

echo $hoferr
echo $alarmtime

if [ $hoferr -gt $alarmtime ]
then
    snmptrap -v 2c -c public localhost 6000 1.3.6.1.4.1.11.2.17.1.0.1001 1.3.6.1.4.1.11.2.17.1.0.1002 s "lipa !!"
    echo "lipa !!"
fi

exit 0
