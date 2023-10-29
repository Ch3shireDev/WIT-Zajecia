// Igor Nowicki
// 18608


#include <iostream>

int main (int argc, char *argv[])
{
  int liczba, liczba2;
  std::cin >> liczba >> liczba2;
  double wynik = (double)liczba / liczba2;
  std::cout << wynik << std::endl;

  return 0;
}