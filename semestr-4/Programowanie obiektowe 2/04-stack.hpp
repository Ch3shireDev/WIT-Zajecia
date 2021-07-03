
template <class T>
class Element
{
    Element *last;
    T value;

public:
    Element<T>(const T value, Element<T> *last) : value(value), last(last) {}
    Element<T> *get_before() { return last; }
    T get_value() { return value; }
};

template <class T>
class Stack
{

    Element<T> *last;

public:
    Stack<T>()
    {
        last = nullptr;
    }

    ~Stack<T>()
    {
        while (last != nullptr)
        {
            pop();
        }
    }

    void push(const T &value)
    {
        last = new Element<T>(value, last);
    }

    bool empty() const
    {
        return last == nullptr;
    }

    T pop()
    {
        T value;
        if (last != nullptr)
        {
            Element<T> *element = last;
            last = element->get_before();
            value = element->get_value();
            delete element;
        }
        return value;
    }
};
