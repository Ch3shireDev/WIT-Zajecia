// Program do rozwiązywania zadania z adresowania plików na dysku.

spacePad = (num, places) => String(num).padStart(places, " ");

function as_blocks(data, block_fragments) {
  let num = Math.floor(data.length / block_fragments);
  return [...Array(num)].map((x, i) =>
    data.slice(i * block_fragments, i * block_fragments + block_fragments)
  );
}

function find_all_zeroes_index(bit_map) {
  for (let i = 0; i < bit_map.length; i++) {
    let element = bit_map[i];
    if (element.includes(1)) continue;
    return i;
  }
  return -1;
}

function assign_data(bit_map, file_size, fragment_size, block_size) {
  // Liczba fragmentów do zajęcia przez plik.
  let fragments = Math.ceil(file_size / fragment_size);

  // Liczba fragmentów w bloku.
  let block_fragments = block_size / fragment_size;

  // 1. Jeśli rozmiar pliku jest mniejszy niż rozmiar fragmentu, plikowi temu przydzielany jest pierwszy wolny fragment.
  if (file_size < fragment_size) {
    let data = [...bit_map];
    let index = data.indexOf(0);
    data[index] = 1;
    return [[index], data];
  }
  // 2. Jeśli rozmiar pliku jest większy niż rozmiar fragmentu, ale mniejszy niż rozmiar bloku, plikowi temu przydzielane są kolejne fragmenty należące do tego samego bloku.
  else if (file_size < block_size) {
    let num = Math.ceil(file_size / fragment_size);
    let blocks = as_blocks(bit_map, block_fragments);

    for (let i = 0; i < blocks.length; i++) {
      let counter = 0;
      let correct = false;
      let indexes = [];
      for (let j = 0; j < block_fragments; j++) {
        if (blocks[i][j] == 0) {
          indexes.push(j + i * block_fragments);
          counter++;
        }
        if (blocks[i][j] == 1) {
          indexes = [];
          counter = 0;
        }
        if (counter == num) {
          correct = true;
        }
      }
      if (correct) {
        let data = blocks.flat();
        indexes.forEach((i) => {
          data[i] = 1;
        });

        return [[indexes[0]], data];
      }
    }
  }
  // 3. Jeśli rozmiar pliku jest większy niż rozmiar bloku, plikowi temu przydzielana jest odpowiednia liczba bloków, niekoniecznie znajdująca się obok siebie, o łącznym rozmiarze nieprzekraczającym rozmiaru pliku.
  else {
    let new_map = as_blocks(bit_map, block_fragments);

    // Znajdywany jest indeks pierwszego całkowicie pustego bloku.
    let index = find_all_zeroes_index(new_map);

    // Blok jest całkowicie zajmowany.
    new_map[index] = Array(block_size / fragment_size).fill(1);

    // Pozostała część pliku umieszczana jest w położonych obok siebie fragmentach należących do jednego bloku zgodnie z regułami 1 oraz 2.

    let [indices, data] = assign_data(
      new_map.flat(),
      file_size - block_size,
      fragment_size,
      block_size
    );

    return [[index * block_fragments].concat(indices), data];
  }
  return [];
}

function adresowanie(bit_map, block_size, fragment_size, file_size) {
  let output = "";

  let print = function (arg) {
    output += arg + "\n";
  };

  let [indices, data] = assign_data(
    bit_map,
    file_size,
    fragment_size,
    block_size
  );

  print(`PRZED  : ${bit_map.map((x) => spacePad(x, 2)).join("  ")}`);
  print(`PO     : ${data.map((x) => spacePad(x, 2)).join("  ")}`);
  print(
    `NUMERY : ${[...Array(data.length)]
      .map((x, i) => spacePad(i + 1, 2))
      .join("  ")}`
  );

  print("Struktura i-węzła:");
  indices.forEach((x, i) => {
    print(`${i + 1}: ${x}`);
  });

  return output;
}

function main() {
  // Rozmiar bloku na mapie bitowej, w kb.
  let block_size = 16;

  //  Rozmiar fragmentu w kb.
  let fragment_size = 4;

  // Rozmiar pliku do zaadresowania, w kb.
  let file_size = 51;

  // prettier-ignore
  // Początkowa mapa bitowa.
  let bit_map = [
  1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,0
];

  let output = adresowanie(bit_map, block_size, fragment_size, file_size);
  console.log(output);
}
