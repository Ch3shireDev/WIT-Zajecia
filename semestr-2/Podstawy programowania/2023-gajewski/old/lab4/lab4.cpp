#include <iostream>
#include <cmath>


// typ zwracany /int/
// nazwa funkcji /euclid/
// argumenty funkcji podejemy w () rozdzielajac ,
// tutaj argumentami sa /int a/ oraz /int b/
int euclid(int a, int b) {
  while (b) {
    int tmp = a % b;
    a = b;
    b = tmp;
  }
  
  return a;
}


// x1 i x2 przekazane sa przez referencje
// dzieki czemu mozemy zmieniac wartosc zmiennej
// w ciele funkcji
double quadratic(double a, double b, double c, double &x1, double &x2) {
  double delta = b * b - 4 * a * c;
  
  if (delta > 0) {
    x1 = (-b - std::sqrt(delta)) / a / 2;
    x2 = (-b + std::sqrt(delta)) / a / 2;
  } else if (delta == 0) {
    x1 = (-b - std::sqrt(delta)) / a / 2;
  }

  return delta;
}


// small i large jako referencja j.w.
void clock(int hour, int minute, double &large, double &small) {
  // liczymy od pionowej pozycji 0:00 / 12:00 / 24:00 
  // cala tarcza ma 360 stopni 
  // 
  // według początkowego warunku liczba godzin jaka nas interesuje 
  // zamyka się w 12 wartościach
  //
  // przy takim podejściu interesuje nas czas 12 godzinny stad % 12
  // następnie mnożymy przez 30 bo jedna godzina to 30 stopni ( 360 stopni / 12 wartości )
  // trzeba jeszcze pamiętać że wychylenie dużej wskazówki ma też miejsce wraz z 
  // zmiana ilości minut 
  // w ciagu godziny duza wskazowka przechodzi do wartosci kolejnej czyli 30 stopni
  // czyli przesuwa się o stopień na dwie minuty dlatego dodajemy
  // liczbę minut dzielona na dwa
  //
  // z mala juz jest latwiej poniewaz 360 stopni przez 60 minut
  // daje nam 6 stopni na minutę więc tylko mnożymy
  // liczbę minut przez 6
  
  large = (hour % 12) * 30. + minute / 2.;
  small = minute * 6.;
}

int main() {

  {
    std::cout << "Euclidean algorithm: " << std::endl;
    int a = 0;
    for (int b = 0; std::cin >> b;) {
     a = euclid(a, b);
    }
    std::cout << a << std::endl;
  
    // remove errors from cin
    std::cin.clear();
    std::cin.ignore(10000,'\n');
 
  }

  {
    std::cout << "Quadratic equation: " << std::endl;
    double a, b, c;
    std::cin >> a >> b >> c;
    double x1, x2;
    double delta = quadratic(a, b, c, x1, x2);
    std::cout << delta << std::endl;
    if (delta > 0) {
      std::cout << x1 << " " << x2 << std::endl;
    } else if (delta == 0) {
      std::cout << x1 << std::endl;
    }

    // remove errors from cin
    std::cin.clear();
    std::cin.ignore(10000,'\n');
  }

  {
    std::cout << "Clock angles: " << std::endl;
    int hour, minute;
    std::cin >> hour >> minute;
    double large, small;
    clock(hour, minute, large, small);
    std::cout << large << " " << small << std::endl; 
    
    // remove errors from cin
    std::cin.clear();
    std::cin.ignore(10000,'\n');
 }

  return 0;
}
