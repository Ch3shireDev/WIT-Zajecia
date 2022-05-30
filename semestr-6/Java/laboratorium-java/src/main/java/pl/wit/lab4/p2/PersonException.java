package pl.wit.lab4.p2;

public class PersonException extends Exception {

    public PersonException(String message) {
        super(message);
    }

    public PersonException(String message, Exception innerException) {
        super(message, innerException);
    }
    
}
