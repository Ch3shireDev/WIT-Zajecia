package pl.wit.lab1;

public class Point {
    /**
     * Zmienna klasy do reprezentowania wymiaru X.
     */
    private float x;

    /**
     * Zmienna klasy do reprezentowania wymiaru Y.
     */
    private float y;


    /**
     * Konstruktor parametryczny 2 argumentowy, którym można będzie utworzyć obiekt dla konkretnego punktu o 2 współrzędnych.
     *
     * @param x - Współrzędna x
     * @param y - Współrzędna y
     */
    public Point(float x, float y) {
        this.x = x;
        this.y = y;
    }

    /**
     * Dodaj metodę w klasie Point zwracająca referencję do nowego obiektu po wykonaniu operacji dodania punktów.
     *
     * @param p1 pierwszy punkt
     * @param p2 drugi punkt
     * @return nowy punkt
     */
    public static Point add(Point p1, Point p2) {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public float getX() {
        return x;
    }

    public void setX(float x) {
        this.x = x;
    }

    public float getY() {
        return y;
    }

    public void setY(float y) {
        this.y = y;
    }

    /**
     * Metoda w klasie Point realizująca przesunięcie dla osi X (dodanie do współrzędnej X dowolnej wartości przesunięcia).
     *
     * @param deltaX - wartość przesunięcia x.
     */
    public void translateX(float deltaX) {
        this.x += deltaX;
    }

    /**
     * Metoda w klasie Point realizująca przesunięcie dla osi Y (dodanie do współrzędnej Y dowolnej wartości przesunięcia)
     *
     * @param deltaY - wartość przesunięcia y.
     */
    public void translateY(float deltaY) {
        this.y += deltaY;
    }

    /**
     * Metoda w klasie Point realizująca dodawanie punktów z użyciem dwóch poprzednich metod realizujących przesunięcie
     *
     * @param point
     */
    public void add(Point point) {
        if (point == null) return;
        translateX(point.x);
        translateY(point.y);
    }

    /**
     * Metoda w klasie Point o sygnaturze „ public void substract(Point pt)” realizująca odejmowanie punktów.
     *
     * @param pt
     */
    public void subtract(Point pt) {
        translateX(-pt.x);
        translateY(-pt.y);
    }

    public Point getPoint(){
        return new Point(x, y);
    }
}
