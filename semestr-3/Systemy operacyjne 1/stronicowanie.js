// Program generujący rozwiązanie do zadania ze stronicowania procesów.

// Funkcja realizująca algorytm FIFO (First In First Out) dla problemu stronicowania.
function fifo(memory_references, pages_num) {
  // Licznik błędów odwołań do stron.
  let errors = [];

  // Bieżące numery stron załadowanych do pamięci.
  let pages = new Array(pages_num).fill(" ");

  // Historia numerów stron załadowanych do pamięci.
  let history = [];

  // Kolejka numerów kolejnych stron do nadpisania. Na początku postaci 0, 1, ... n-1
  let allocation_queue = [...Array(pages_num)].map((x, i) => i);

  memory_references.forEach((address, i) => {
    // Jeśli na liście załadowanych stron jest bieżący adres, oznacza to że nie ma błędu i możemy iść dalej.
    if (!pages.includes(address)) {
      // Liczba błędów jest powiększana o 1.
      errors.push(i);

      // Strona do nadpisania jest wybierana z kolejki według zasady FIFO - pobieramy najwcześniej zaalokowaną.
      // Pobierany jest pierwszy indeks z listy.
      let index = allocation_queue.shift();

      // Przesuwamy pobrany indeks na koniec kolejki.
      allocation_queue.push(index);

      // Na listę stron dopisywana jest bieżąca strona do odczytu.
      pages[index] = address;
    }

    // Do historii dodawany jest stan bieżącej strony.
    history.push([...pages]);
  });

  return [errors, history];
}

function find_latest_index(pages, list) {
  if (pages.includes(" ")) return pages.indexOf(" ");

  for (let i = 0; i < pages.length; i++) {
    if (!list.includes(pages[i])) return i;
  }

  let tab = new Array(pages.length).fill(null);
  for (let i = 0; i < list.length; i++) {
    if (pages.includes(list[i])) {
      let j = pages.findIndex((x) => x == list[i]);
      if (tab[j] == null) tab[j] = i;
    }
  }
  let max = Math.max(...tab);
  return tab.findIndex((x) => x == max);
}

// Funkcja realizująca algorytm optymalny dla problemu stronicowania procesów.
// Zakładamy że komputer ma możliwość przewidywania do jakich stron będzie odwoływał się w przyszłości.
function optimal(memory_references, pages_num) {
  // Licznik błędów odwołań do stron.
  let errors = [];

  // Bieżące numery stron załadowanych do pamięci.
  let pages = new Array(pages_num).fill(" ");

  // Historia numerów stron załadowanych do pamięci.
  let history = [];

  memory_references.forEach((address, i) => {
    // Jeśli na liście załadowanych stron jest bieżący adres, oznacza to że nie ma błędu i możemy iść dalej.
    if (!pages.includes(address)) {
      // Liczba błędów jest powiększana o 1.
      errors.push(i);

      let index = find_latest_index(
        pages,
        memory_references.slice(i, memory_references.length)
      );

      // Na listę stron dopisywana jest bieżąca strona do odczytu.

      if (index == -1) {
        if (pages.includes(" ")) index = pages.findIndex((x) => x == " ");
        else index = 0;
      }
      pages[index] = address;
    }

    // Do historii dodawany jest stan bieżącej strony.
    history.push([...pages]);
  });

  return [errors, history];
}

// Funkcja realizująca algorym LRU (Least Recently Used),
// wybierająca strony do nadpisania na podstawie tego do której było najwcześniejsze odwołanie.
function lru(memory_references, pages_num) {
  // Licznik błędów odwołań do stron.
  let errors = [];

  // Bieżące numery stron załadowanych do pamięci.
  let pages = new Array(pages_num).fill(" ");

  // Historia numerów stron załadowanych do pamięci.
  let history = [];

  memory_references.forEach((address, i) => {
    // Jeśli na liście załadowanych stron jest bieżący adres, oznacza to że nie ma błędu i możemy iść dalej.
    if (!pages.includes(address)) {
      // Liczba błędów jest powiększana o 1.
      errors.push(i);

      // Strona do nadpisania jest wybierana z kolejki według zasady FIFO - pobieramy najwcześniej zaalokowaną.
      // Pobierany jest pierwszy indeks z listy.
      let reference = [...memory_references];
      reference = reference.slice(0, i);
      reference = reference.reverse();

      let index = find_latest_index(pages, reference);

      // Na listę stron dopisywana jest bieżąca strona do odczytu.
      pages[index] = address;
    }

    // Do historii dodawany jest stan bieżącej strony.
    history.push([...pages]);
  });

  return [errors, history];
}

// Funkcja drukująca wynik działań.
function show(name, memory_references, history, errors, pages_num) {
  let output = "";
  let print = function (arg) {
    if (arg) output += arg + "\n";
    else output += "\n";
  };

  // Drukowana jest nazwa algorytmu.
  print(`${name}:`);

  // Pierwsza linia to odwołania do stron w pamięci.
  print(memory_references.join(" "));
  print();

  if (!history) {
    print("---brak danych!---");
    print();
    return;
  }

  // Drukowane są kolejne wiersze dla każdej ze stron.
  for (let i = 0; i < pages_num; i++) {
    print(history.map((x, j) => (errors.includes(j) ? x[i] : " ")).join(" "));
  }

  print();
  print(`ERRORS: ${errors.length}`);
  print();

  return output;
}

function stronicowanie(address_list, page_size, total_memory) {
  // Obliczanie całkowitej liczby stron dostępnej dla procesu.
  let pages_num = total_memory / page_size;

  // Obliczanie kolejnych numerów stron do których następują odwołania.
  let memory_references = [
    ...address_list.map((x) => Math.floor(x / page_size)),
  ];

  let [fifo_errors, fifo_history] = fifo(memory_references, pages_num);

  let output_fifo = show(
    "FIFO",
    memory_references,
    fifo_history,
    fifo_errors,
    pages_num
  );

  let [optimal_errors, optimal_history] = optimal(memory_references, pages_num);

  let output_optimal = show(
    "OPTIMAL",
    memory_references,
    optimal_history,
    optimal_errors,
    pages_num
  );

  let [lru_errors, lru_history] = lru(memory_references, pages_num);
  let output_lru = show(
    "LRU",
    memory_references,
    lru_history,
    lru_errors,
    pages_num
  );

  return output_fifo + output_optimal + output_lru;
}

function main() {
  // prettier-ignore
  // Adresy komórek w pamięci do których następuje odwołanie.
  let address_list = [ 410, 245, 173, 450, 120, 231, 610, 309, 176, 234, 430, 185, 210, 551, 31, 245, 556, 434, 565, 650, 46, 458];

  // Rozmiar pojedynczej strony w bajtach.
  let page_size = 100;

  // Całkowita ilość pamięci przydzielonej programowi.
  let total_memory = 300;

  stronicowanie(address_list, page_size, total_memory);
}
