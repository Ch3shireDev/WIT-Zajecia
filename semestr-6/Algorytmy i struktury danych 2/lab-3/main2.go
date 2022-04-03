package main

import (
	"log"
	"os"
)

func find_naive(text string, pattern string) (int, int) {

	var matches_count = 0
	var search_count = 0

	for i := 0; i < len(text)-len(pattern); i++ {
		for j := 0; j < len(pattern); j++ {
			search_count += 1
			if text[i+j] != pattern[j] {
				break
			}
			if j == len(pattern)-1 {
				matches_count += 1
			}
		}
	}
	return matches_count, search_count
}

func main() {

	content, err := os.ReadFile("winnie_the_pooh_ch_01_0002.txt")
	if err != nil {
		log.Fatal(err)
	}

	naive_matches_count, naive_search_count := find_naive(string(content), "winniewinniepooh")
	log.Printf("Liczba wystąpień wzorca 'winniewinniepooh' w tekście (metoda naiwna): %d\n", naive_matches_count)
	log.Printf("Liczba przeszukiwań 'winniewinniepooh' (metoda naiwna): %d\n", naive_search_count)

	naive_matches_count_2, naive_search_count_2 := find_naive(string(content), "winnwinniepooh")
	log.Printf("Liczba wystąpień wzorca 'winnwinniepooh' w tekście (metoda naiwna): %d\n", naive_matches_count_2)
	log.Printf("Liczba przeszukiwań 'winnwinniepooh' (metoda naiwna): %d\n", naive_search_count_2)

}

// algorytm naiwny i KMP do wyszukania wzorca
// liczba wystąpień, liczba przeszukań
