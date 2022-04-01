# zaszyfruj słowo kryptologia
import sys

def get_num(char,k):
    n = ord(char)-ord('a')
    letter = '+' if k>=0 else ''
    print(f'{char} = {n} -> {n}{letter}{k} = {n+k} -> {n+k}%26 -> {(n+k)%26} = {get_char((n+k)%26)}')
    return ord(char) - ord('a')

def get_char(num):
    return chr((num+26)%26 + ord('a'))

def caesar_cipher(text, k):
    alphabet = 'abcdefghijklmnopqrstuvwxyz'
    return ''.join([get_char(get_num(c,k) + k) if c in alphabet else c for c in text])

k = int(sys.argv[1])
text = sys.argv[2]

print(caesar_cipher(text, k))