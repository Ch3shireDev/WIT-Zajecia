/******************************************************************************/
/*                                                                            */
/*  SHELSORT.CPP - Standard shellsort from Sedgewick 'Algorithms'             */
/*                                                                            */
/* Copyright (c) 1993 by Academic Press, Inc.                                 */
/*                                                                            */
/* All rights reserved.  Permission is hereby granted, until further notice,  */
/* to make copies of this diskette, which are not for resale, provided these  */
/* copies are made from this master diskette only, and provided that the      */
/* following copyright notice appears on the diskette label:                  */
/* (c) 1993 by Academic Press, Inc.                                           */
/*                                                                            */
/* Except as previously stated, no part of the computer program embodied in   */
/* this diskette may be reproduced or transmitted in any form or by any means,*/
/* electronic or mechanical, including input into storage in any information  */
/* system for resale, without permission in writing from the publisher.       */
/*                                                                            */
/* Produced in the United States of America.                                  */
/*                                                                            */
/* ISBN 0-12-479041-0                                                         */
/*                                                                            */
/******************************************************************************/

#include <stdio.h>
#include <string.h>
#include <math.h>
#include <conio.h>
#include <ctype.h>
#include <stdlib.h>

void shellsort (
      int n ,    // Length of x array
      double *x  // Data to be sorted ascending
      )
{
   int i, j, width, other ;
   double sentinel ;

/*
   Generate (in reverse order) a good sequence of sorting widths
*/

   for (width=1 ; width<n ;)    // Until we get large enough
      width = 3 * width + 1 ;   // avoid common factors in widths

   do {             // Outer loop does each of a diminishing sequence of widths
      width /= 3 ;  // Next shell width

      for (i=width ; i<n ; i++) {  // Do each of the shells

         sentinel = x[i] ;
         j = i ;

          for (;;) {
            other = j - width ;
            if ((other < 0)  ||  (x[other] <= sentinel))
               break ;
            x[j] = x[other] ;
            j = other ;
            }

         x[j] = sentinel ;
         } // For each shell of this width

      } while (width > 1) ;  // Outer loop does diminishing sequence of widths
}  
