package pl.wit.lab3.p4;

/**
 * Przykładowa klasa bazowa obrazująca polimorfizm
 * dynamiczny
 *
 * @author Łukasz
 */

public class DynP1 {
    protected String message = null;

    public DynP1(String message) {
        this.message = message;
    }

    public void show() {
        System.out.println("DP1:" + message);
    }

    public String getMessage() {
        return message;
    }
}
