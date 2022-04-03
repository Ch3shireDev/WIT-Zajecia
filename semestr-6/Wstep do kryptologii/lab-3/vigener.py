from pprint import pprint
import csv

def save_csv(filename, tab):  
    tab = [[tab[j][i] for j in range(len(tab))] for i in range(len(tab[0]))]

    f = open(filename, 'w')

    # create the csv writer
    writer = csv.writer(f)

    for row in tab:
        writer.writerow(row)

    # close the file
    f.close()
    

def encrypt_vigener(plaintext, cipherkey):
    encrypted = ""
    tab = []
    for i in range(len(plaintext)):
        a = plaintext[i]
        x = ord(a) - ord('a')
        d = cipherkey[i % len(cipherkey)]
        c = ord(d) - ord('a')
        y = x + c
        y %= 26
        e = chr(y + ord('a'))
        encrypted += e
        tab.append([a, x, c, d, y, e])

    save_csv('vigener_encrypted.csv', tab)
    return encrypted


def decrypt_vigener(encrypted, cipherkey):
    decrypted = ""
    tab = []
    for i in range(len(encrypted)):
        a = encrypted[i]
        x = ord(a) - ord('a')
        c = cipherkey[i % len(cipherkey)]
        d = ord(c) - ord('a')
        y = x-d
        y %= 26
        z = chr(y + ord('a'))
        decrypted += z
        tab.append([a, x, c, d, y, z])
        
    save_csv('vigener_decrypted.csv', tab)
        
    return decrypted


plaintext = "kryptografiaikryptoanaliza"
cipherkey = "keylog"
encrypted = encrypt_vigener(plaintext, cipherkey)
decrypted = decrypt_vigener(encrypted, cipherkey)

print(f'Plaintext: {plaintext}')
print(f'Encrypted: {encrypted}')
print(f'Decrypted: {decrypted}')
