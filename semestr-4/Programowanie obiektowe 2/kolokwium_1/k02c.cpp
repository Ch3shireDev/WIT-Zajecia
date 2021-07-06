// Zadanie K02C
// Napisz taką klasę Parent, aby poniższy program działał jak wskazano. Klasa
// korzysta tylko z pliku nagłówkowego string. Przykładowy program

#include <iostream>
#include "k02c.hpp"

struct Child : Parent {
  std::string method1() const { return "child1"; }
  std::string method2() const { return "child2"; }
};

int main() {
  const Parent &parent = Parent();
  std::cout << parent.method1() << std::endl;
  const Parent &child = Child();
  std::cout << child.method1() << " " << child.method2() << " "
            << child.method3() << std::endl;
}

// Wykonanie

// Out: parent1
// Out: child1 parent2 child3
