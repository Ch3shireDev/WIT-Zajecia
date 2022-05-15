package main

import (
	"crypto/sha1"
	"encoding/csv"
	"fmt"
	"os"
	"time"
)

// To co robimy:
// Mamy plik transactions.csv
// Tworzymy blockchain transakcji - od kogo, do kogo, kiedy, ile, poprzedni sha, bieżący sha

type blockData struct {
	from      string
	to        string
	amount    string
	timestamp string
	prev_sha  string
	curr_sha  string
}

func getCsvLines(fileName string) ([][]string, error) {
	csvFile, err := os.Open("transactions.csv")
	if err != nil {
		fmt.Println(err)
	}
	fmt.Println("Successfully Opened CSV file")
	defer csvFile.Close()

	csvLines, err := csv.NewReader(csvFile).ReadAll()

	return csvLines, err

}

func getSha(data string) string {
	h := sha1.New()
	h.Write([]byte(data))
	sha := h.Sum(nil)
	return fmt.Sprintf("%x", sha)
}

func getTimestampStr() string {
	// gets unix timestamp in string
	return fmt.Sprintf("%d", time.Now().Unix())
}

func main() {

	csvLines, err := getCsvLines("transactions.csv")

	if err != nil {
		fmt.Println(err)
	}

	prev_sha := ""

	for _, line := range csvLines {
		time.Sleep(1 * time.Second)

		emp := blockData{
			from:      line[0],
			to:        line[1],
			amount:    line[2],
			timestamp: getTimestampStr(),
			prev_sha:  prev_sha,
			curr_sha:  "",
		}

		serialized := emp.from + " " + emp.to + " " + emp.timestamp + " " + emp.amount + " " + emp.prev_sha
		curr_sha := getSha(serialized)

		emp.curr_sha = curr_sha
		prev_sha = curr_sha

		fmt.Println("from: " + emp.from + " to: " + emp.to + " timestamp: " + emp.timestamp + " amount: " + emp.amount + " prev_sha: " + emp.prev_sha + " curr_sha: " + emp.curr_sha)

	}

}
