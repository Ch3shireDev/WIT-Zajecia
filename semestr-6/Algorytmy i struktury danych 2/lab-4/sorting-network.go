package main

import (
	"encoding/csv"
	"fmt"
	"log"
	"os"
	"strconv"
	"strings"
)

func getCsvData(fileName string) [][]string {
	f, err := os.Open(fileName)
	if err != nil {
		log.Fatal(err)
	}

	defer f.Close()

	csvReader := csv.NewReader(f)
	csvReader.FieldsPerRecord = -1
	data, err := csvReader.ReadAll()
	if err != nil {
		log.Fatal(err)
	}
	return data
}

func getNetwork(filename string) [][][]int {
	data := getCsvData(filename)
	network := make([][][]int, len(data)-2)
	for i, row := range data[2:] {
		network[i] = make([][]int, len(row))
		for j, value := range row {
			value = strings.Trim(value, " ")
			values := strings.Split(value, "-")
			x, _ := strconv.Atoi(values[0])
			y, _ := strconv.Atoi(values[1])
			network[i][j] = make([]int, 2)
			network[i][j][0] = x
			network[i][j][1] = y
		}
	}
	return network
}

func getValues(fname string) []int {
	data := getCsvData(fname)
	values := make([]int, 4)
	elements := strings.Split(data[1][0], " ")
	for i, value := range elements {
		values[i], _ = strconv.Atoi(value)
	}

	return values
}

func processValues(network [][][]int, values []int) []int {
	for _, transform := range network {
		values = processValuesBySingleTransform(transform, values)
	}

	return values
}

func processValuesBySingleTransform(transform [][]int, values []int) []int {
	for _, pair := range transform {
		x, y := pair[0], pair[1]
		if values[x-1] < values[y-1] {
			values[x-1], values[y-1] = values[y-1], values[x-1]
		}
	}

	return values
}

func main() {
	// fmt.Println(network)
	values := getValues("Input_0001.csv")
	network := getNetwork("Network_20_0001.csv")
	// outputData := getCsvData("Output_0001.csv")
	_ = values
	_ = network
	fmt.Println(values)

	values = processValues(network, values)
	fmt.Println(values)
}
