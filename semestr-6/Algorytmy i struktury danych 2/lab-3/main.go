package main

import (
	"log"
	"os"
)

func get_prefix_suffix_array(pattern string) []int {

	// Tworzę sobie zmienną pomocniczą oznaczającą długość wzorca.
	pattern_length := len(pattern)

	// Deklaruję tablicę prefikso-sufiksową do uzupełnienia wartościami.
	var longest_prefix_suffix = make([]int, pattern_length)

	var i = 1

	var previous_longest_prefix_suffix = 0

	// Przechodzę przezy wzorzec i uzupełniam tablicę prefikso-sufiksowa
	for i < pattern_length {
		if pattern[i] == pattern[previous_longest_prefix_suffix] {
			previous_longest_prefix_suffix += 1
			longest_prefix_suffix[i] = previous_longest_prefix_suffix
			i += 1
		} else {
			if previous_longest_prefix_suffix != 0 {
				previous_longest_prefix_suffix = longest_prefix_suffix[previous_longest_prefix_suffix-1]
			} else {
				longest_prefix_suffix[i] = 0
				i += 1
			}
		}
	}

	return longest_prefix_suffix

}

func find_kmp(text string, pattern string) (int, int) {

	// Na początku tworzę countery dla liczby znalezionych wzorców i przeszukiwań
	var matches_count = 0
	var search_count = 0

	// Zmienne pomocnicze, oznaczające długości wzorca i tekstu
	pattern_length := len(pattern)
	text_length := len(text)

	// Tworzę tablicę prefikso-sufiksową dla podanego wzorca
	var prefix_suffix = get_prefix_suffix_array(pattern)

	var i, j = 0, 0

	// Iteruję po tekście
	for i < text_length {
		// Zwiększam licznik porównań o 1
		search_count += 1

		// Jeśli znak wzorca jest taki sam jak znak tekstu, odnotowujemy to
		if pattern[j] == text[i] {
			i += 1
			j += 1
		}
		// Jeśli dotarliśmy do końca wzorca, znaczy, że wzorzec został znaleziony. Zwiększamy licznik znalezionych wzorców o 1
		if j == pattern_length {
			// znaleziony wzorzec
			matches_count += 1

			j = prefix_suffix[j-1]
		} else if i < text_length && pattern[j] != text[i] {
			// Jeśli wzorzec się nie zgadza z tekstem, przeskakujemy na początek według tablicy prefikso-sufiksowej
			if j != 0 {
				j = prefix_suffix[j-1]
			} else {
				i += 1
			}
		}
	}

	return matches_count, search_count

}

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

	kmp_matches_count, kmp_search_count := find_kmp((string(content)), "winniewinniepooh")
	log.Printf("Liczba wystąpień wzorca 'winniewinniepooh' w tekście (metoda KMP): %d\n", kmp_matches_count)
	log.Printf("Liczba przeszukiwań 'winniewinniepooh' (metoda KMP): %d\n", kmp_search_count)

	kmp_matches_count_2, kmp_search_count_2 := find_kmp(string(content), "winnwinniepooh")
	log.Printf("Liczba wystąpień wzorca 'winnwinniepooh' w tekście (metoda KMP): %d\n", kmp_matches_count_2)
	log.Printf("Liczba przeszukiwań 'winnwinniepooh' (metoda KMP): %d\n", kmp_search_count_2)

}

// algorytm naiwny i KMP do wyszukania wzorca
// liczba wystąpień, liczba przeszukań
