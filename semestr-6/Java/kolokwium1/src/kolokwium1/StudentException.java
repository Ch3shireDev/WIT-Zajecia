package kolokwium1;

/**
 * Wyjątek rzucany w przypadku rzuceniu studentem.
 * @author Igor Nowicki
 *
 */
public class StudentException extends Exception{

    /**
     * Wyjątek wewnętrzny.
     */
    private  Exception internalException;
    /**
     * Powiadomienie w wyjątku.
     */
    private  String message;
    /**
     * Konstruktor wyjątku.
     */

    public StudentException(String message){
        super(message);
        this.message = message;
    }
    /**
     * Konstruktor wyjątku.
     */
    public StudentException(String message, Exception internalException){
        super(message, internalException);
        this.message = message;
        this.internalException = internalException;
    }
}
