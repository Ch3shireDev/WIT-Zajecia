package main

import (
	"fmt"
	"math/rand"
	"time"
)

func get_pi(n int) (pi float64) {
	points_inside_circle := 0

	for i := 0; i < n; i++ {

		x := rand.Float64()
		y := rand.Float64()

		r2 := x*x + y*y

		if r2 <= 1 {
			points_inside_circle += 1
		}
	}

	pi = 4 * float64(points_inside_circle) / float64(n)
	return
}

func main() {

	n := 1000
	m := 100

	rand.Seed(time.Now().UnixNano())

	mean_pi := 0.0

	variance := 0.0

	for i := 0; i < m; i++ {
		pi := get_pi(n)
		mean_pi += pi
		variance += pi * pi
	}

	mean_pi /= (float64)(m)
	variance /= (float64)(m)

	variance -= mean_pi * mean_pi

	fmt.Println("Srednia wartosc pi dla n = ", n, "m = ", m, ":", mean_pi)
	fmt.Println("Wariancja dla n = ", n, " oraz m = ", m, "powtorzen: ", variance)

}
