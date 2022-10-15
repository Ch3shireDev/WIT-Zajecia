package pl.wit.lab4.p1;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;

/**
 * Klasa pochodna - nauczyciel
 *
 * @author Łukasz
 */
public class TeacherDemo extends AbstractDemo {

    protected static final Logger log = LogManager.getLogger(StudentDemo.class.getName());

    public TeacherDemo(String firstName, String lastName) {
        super(firstName, lastName);
    }

    @Override
    protected EnPersonType getPersonType() {
        return EnPersonType.teacher;
    }

    @Override
    public Logger getLogger() {
        return null;
    }

    @Override
    public String getAdditionalInfo() {
        return getStringData();
    }
}
