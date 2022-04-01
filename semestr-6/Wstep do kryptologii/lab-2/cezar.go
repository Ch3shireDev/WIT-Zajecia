package main

import (
	"os"
	"strconv"
)

func get_num(chr byte) int {
	return int(chr - 'a')
}

func get_char(num int) byte {
	return byte((num+26)%26 + 'a')
}

func transform(char byte, key int)

func main() {

	args := os.Args[1:]

	key, _ := strconv.Atoi(args[0])
	plaintext := args[1]

	cipher := ""

	for i := 0; i < len(plaintext); i++ {
		num := get_num(plaintext[i])
		if num != -1 {
			num = (num + key) % 26
			cipher += string(get_char(num))
		} else {
			cipher += string(plaintext[i])
		}
	}
	
	println(cipher)
}
