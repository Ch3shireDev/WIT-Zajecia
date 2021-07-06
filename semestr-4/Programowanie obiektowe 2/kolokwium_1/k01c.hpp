#include <map>

void function(std::map<int, int> &map, int x) {
  std::map<int, int> map2 = std::map<int, int>();
  for (auto pair : map) {
    if (pair.second < x)
      map2.insert(pair);
  }
  map = map2;
}
