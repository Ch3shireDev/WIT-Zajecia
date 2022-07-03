from random import choice

with open('pytania.md', 'r') as f:
    pytania = f.readlines()
    f.close()
    
pytania = [x.strip() for x in pytania if x]

print(choice(pytania))