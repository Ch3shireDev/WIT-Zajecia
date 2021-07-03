
class Object {


public:
    static int N;

    Object() {
        N += 1;
    }

    Object(const Object& object) {
        N+=1;
    }

    ~Object() {
        N -= 1;
    }

    static int count() {
        return N;
    }

};

int Object::N = 0;


#include <iostream>
using namespace std;
// Przykładowy program
int main() {
    Object object1;
    {
        Object object2(object1);
        std::cout << Object::count() << " "; }
    std::cout << Object::count() << std::endl;
}
// Wykonanie
// Out: 2 1