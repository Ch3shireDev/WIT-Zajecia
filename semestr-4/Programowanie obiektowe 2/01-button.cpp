#include <iostream>

using namespace std;

class Button
{

    bool is_on;

public:
    bool on() const
    {
        return is_on;
    }

    virtual bool press()
    {
        is_on = true;
    }

    virtual bool release()
    {
        is_on = false;
    }
};

int main()
{
}