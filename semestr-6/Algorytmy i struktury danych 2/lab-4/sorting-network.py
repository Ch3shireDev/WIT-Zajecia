import csv
from random import randint

def get_data(filename):
    with open(filename, newline='') as csvfile:
        data = csv.reader(csvfile, delimiter=',')
        data = list([x.strip() for x in row] for row in data)
        csvfile.close()
    return data


def get_transforms_from_network_data(network_data):
    transforms = []
    for row in network_data:
        transform_data = []
        for element in row:
            x, y = element.split('-')
            x = int(x)
            y = int(y)
            transform_data.append((x, y))
        transforms.append(transform_data)
    return transforms

def apply_transform(transform, values):
    for x, y in transform:
        if values[x-1] < values[y-1]:
            values[x-1], values[y-1] = values[y-1], values[x-1]
    return values

def get_network_from_file(fname):
    network_data = get_data(fname)
    transforms = get_transforms_from_network_data(network_data[2:])
    return transforms

def get_values_from_file(fname):
    input_data = get_data(fname)
    values = [int(x) for x in input_data[1:][0][0].split()]
    return values



def process_values(network, values):
    output_data = []
    for transform in network:
        output_data.append(str.join(' ', [f"{i+1}:{values[i]}" for i in range(len(values))]))
        output_data.append(str.join(' ', [f"{x}-{y}" for x,y in transform]))
        values = apply_transform(transform, values)
    output_data.append(str.join(' ', [f"{i+1}:{values[i]}" for i in range(len(values))]))
    
    return values, output_data


network_20 = get_network_from_file("Network_20_0001.csv")
network_42 = get_network_from_file("Network_42_0001.csv")
values = get_values_from_file("Input_0001.csv")

values, output_data = process_values(network_20, values)

values = get_values_from_file("Input_0001.csv")

values = [randint(1,9) for x in range(4)]
values, output_data = process_values(network_42, values)

for row in output_data:
    print(row)
