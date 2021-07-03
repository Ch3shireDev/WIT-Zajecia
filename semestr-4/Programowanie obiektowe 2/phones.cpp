#include <fstream>
#include <iostream>
#include <list>
#include <string>

using namespace std;

class Record {

  string number;
  string first_name;
  string last_name;

public:
  string get_number() const { return number; }

  string get_first_name() const { return first_name; }

  string get_last_name() const { return last_name; }

  bool is_number_match(string str) { return true; }

  ostream &operator<<(ostream &ost) {
    ost << number << ", " << first_name << ", " << last_name;
    return ost;
  }

  Record(string line) {
    
  }
};

bool is_blank_line(string line) {
  for (int i = 0; i < line.size(); i++) {
    if (line[i] != ' ' && line[i] != '\t')
      return false;
  }
  return true;
}

int main() {

  list<Record *> records = list<Record *>();

  fstream file("phones.txt");

  for (string line; getline(file, line);) {
    if (is_blank_line(line))
      continue;
    records.push_back(new Record(line));
  }



}