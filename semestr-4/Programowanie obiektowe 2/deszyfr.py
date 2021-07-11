import sys

def caesar(text, n):
    deciphered = ""
    for letter in text:
        if letter >= 'a' and letter <= 'z':
            letter = chr((ord(letter) - ord('a') + n)% 26 + ord('a'))
        deciphered += letter
    return deciphered


fname = sys.argv[1]
n = int(sys.argv[2])


with open(fname, encoding='1252') as f:
    text = f.read()
    decipher = caesar(text, n)

with open('deszyfr.html', 'w+', encoding='1252') as f:
    f.write(decipher)
    f.close()