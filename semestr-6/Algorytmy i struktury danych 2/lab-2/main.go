package main

import (
	"math/rand"
)

func main() {
	type opt struct {
		letter      byte
		probability float64
		code        string
	}

	var probs = []opt{
		{letter: 'A', probability: 0.15, code: "110"},
		{letter: 'D', probability: 0.12, code: "010"},
		{letter: 'E', probability: 0.12, code: "001"},
		{letter: 'B', probability: 0.11, code: "100"},
		{letter: 'C', probability: 0.11, code: "011"},
		{letter: 'F', probability: 0.10, code: "000"},
		{letter: 'G', probability: 0.10, code: "1111"},
		{letter: 'H', probability: 0.07, code: "1110"},
		{letter: 'I', probability: 0.06, code: "1010"},
		{letter: 'K', probability: 0.06, code: "1011"},
	}

	var codes = ""
	var text = ""

	for i := 0; i < 1000; i++ {
		var r = rand.Float64()
		prob := 0.0
		for j := 0; j < len(probs); j++ {
			prob += probs[j].probability
			if r <= prob {
				text += string(probs[j].letter)
				codes += probs[j].code
				break
			}
		}
	}

	println(codes)
	println(text)

	println("Liczba bitów kodu:", len(codes))
	println("Liczba bitów nieskompresowanego tekstu:", len(text)*4)

}
