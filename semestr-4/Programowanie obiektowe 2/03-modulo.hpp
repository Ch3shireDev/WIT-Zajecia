
template <int n>
class Modulo
{

    int value;

    void normalize()
    {
        while(value<0)value += n;
        value %= n;
    }

public:
    Modulo<n>() { value = 0; }

    Modulo<n> &operator++()
    {
        value = (value + 1);
        normalize();
        return *this;
    }

    Modulo<n> &operator++(int x)
    {
        Modulo<n> *m = new Modulo<n>();
        m->value = value;
        value = (value + 1);
        normalize();
        return *m;
    }

    friend std::ostream &operator<<(std::ostream &os, const Modulo<n> &rhs)
    {
        os << rhs.value;
        return os;
    }

    friend std::istream &operator>>(std::istream &is, Modulo<n> &rhs)
    {
        is >> rhs.value;
        rhs.normalize();
        return is;
    }

    Modulo<n>& operator+(const Modulo<n> &rhd)
    {
        Modulo<n> *m = new Modulo<n>();
        m->value = value + rhd.value;
        m->normalize();
        return *m;
    }
    Modulo<n>& operator-(const Modulo<n> &rhd)
    {
        Modulo<n> *m = new Modulo<n>();
        m->value = value - rhd.value;
        m->normalize();
        return *m;
    }
    Modulo<n>& operator*(const Modulo<n> &rhd)
    {
        Modulo<n> *m = new Modulo<n>();
        m->value = value * rhd.value;
        m->normalize();
        return *m;
    }
};
