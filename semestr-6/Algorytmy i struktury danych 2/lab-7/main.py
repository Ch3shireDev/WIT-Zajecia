

filename = 'Podzielnosc_0001.csv'


with open(filename, 'r') as f:
    data = f.read()
    f.close()

data = [int(x.strip()) for x in data.splitlines() if x]

data = data[1:]

n = 5

data2 = [x%5 == 0 for x in data]

data3 = []

for x in data2:
    if len(data3) ==0:
        data3.append(x)
    else:
        data