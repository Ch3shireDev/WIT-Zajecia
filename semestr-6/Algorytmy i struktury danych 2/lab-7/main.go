package main

import (
	"encoding/csv"
	"fmt"
	"os"
	"strconv"
)

func main() {
	csvFile, err := os.Open("Podzielnosc_0001.csv")
	if err != nil {
		fmt.Println(err)
	}
	defer csvFile.Close()

	csvLines, err := csv.NewReader(csvFile).ReadAll()
	if err != nil {
		fmt.Println(err)
	}

	var array []int

	for _, line := range csvLines {
		var x, _ = strconv.Atoi(line[0])
		array = append(array, x)
	}

	array = pop

	fmt.Println(array)
	var n int
	fmt.Printf("Proszę podać liczbę n: ")
	fmt.Scanf("%d", &n)
	fmt.Println(n)

}
