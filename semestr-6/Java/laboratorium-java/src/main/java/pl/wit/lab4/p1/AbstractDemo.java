package pl.wit.lab4.p1;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;

/**
 * Klasa abstrakcyjna demonstracyjna
 *
 * @author Łukasz
 */
public abstract class AbstractDemo implements IDemoLogger {


    protected static final Logger log = LogManager.getLogger(AbstractDemo.class.getName());
    //imię
    private String firstName = null;
    //nazwisko
    private String lastName = null;

    /**
     * Typ osoby
     *
     * @return
     */
    protected abstract EnPersonType getPersonType();

    public AbstractDemo(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public String getStringData() {
        log.trace("get string data");

        String personType = getPersonType().toString();

        return (firstName != null ? firstName : "")
                .concat(" ")
                .concat(lastName != null ? lastName : "")
                .concat(" - ")
                .concat(personType != null ? personType : "");
    }

    public void printData() {
        log.info(getStringData());
    }
}
