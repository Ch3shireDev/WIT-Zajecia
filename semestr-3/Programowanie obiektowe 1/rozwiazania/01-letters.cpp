
#include <iostream>
#include <cctype>

int main(){
    char chr;

    // Definiujemy tablicę do zliczania. 
    int tab[26] = {};

    while(std::cin >> chr){

        // Dla znaku z przedziału od a do z.
        if(chr >= 'a' && chr <= 'z') tab[chr-'a']++;

        // Dla znaku z przedziału od A do Z.
        if(chr >= 'A' && chr <= 'Z') tab[chr-'A']++;

    }

    for(int i=0;i<26;i++){
        std::cout<<tab[i]<<" ";
    }

}


