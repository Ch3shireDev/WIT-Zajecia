
void euclid(int &x, int &y)
{
    int a = x;
    int b = y;

    while (a != b)
    {
        if (a < b)
        {
            b = b - a;
        }
        else
        {
            a = a - b;
        }
    }

    //nwd
    int nwd = a;
    //nww
    int nww = x * y / nwd;

    x = nwd;
    y = nww;
}
