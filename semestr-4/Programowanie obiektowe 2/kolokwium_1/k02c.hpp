#include <string>

class Parent {
public:
  virtual std::string method1() const { return "parent1"; }
  std::string method2() const { return "parent2"; }
  virtual std::string method3() const { return "child3"; }
};
