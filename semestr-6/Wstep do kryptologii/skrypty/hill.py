import numpy as np


def hill_encrypt(plaintext, cipherkey):
    """
    Encrypts plaintext using key.
    """
    n = len(cipherkey)

    encrypted = ''

    for i in range(len(plaintext)//n):
        x = plaintext[i*n:(i+1)*n]
        xx = np.array([ord(a) - ord('a') for a in x])
        c = np.array(cipherkey)
        y = np.dot(xx, c) % 26
        yy = [chr(a + ord('a')) for a in y]

        print(f"{x} -> {xx} -> {c}*{xx} = {y} -> {yy}")
        encrypted += ''.join(yy)

    return encrypted


def hill_decrypt(ciphertext, cipherkey):
    """
    Decrypts ciphertext using key.
    """


cipherkey = np.array([[3,15],[6,1]])
plaintext = 'warszawa'
encrypted = hill_encrypt(plaintext, cipherkey)
print(encrypted)
