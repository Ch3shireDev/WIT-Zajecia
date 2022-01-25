from glob import glob

data = dict()

for file in glob("**/*.cs", recursive=True):
    if '\\obj\\' in file:
        continue
    print(file)
    dir = file.split('\\')[:-1]
    dir = '_'.join(dir)
    name = file.split('\\')[-1]
    
    if dir not in data:
        data[dir] = ''
    
    with open(file, 'r', encoding='utf-8') as f:
        data[dir] += f.read() + '\r\n'
        f.close()
        
for key in data:
    with open(f'{key}.md', 'w', encoding='utf-8') as f:
        f.write(data[key])
        f.close()