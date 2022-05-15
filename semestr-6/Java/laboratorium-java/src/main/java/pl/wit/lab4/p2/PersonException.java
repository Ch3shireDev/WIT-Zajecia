package pl.wit.lab4.p2;

public class PersonException extends Exception {

    String message;
    Exception innerException;

    public PersonException(String message) {
        this.message = message;
    }

    public PersonException(String message, Exception innerException) {
        this.message = message;
        this.innerException = innerException;
    }


}
