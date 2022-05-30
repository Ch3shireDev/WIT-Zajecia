package pl.wit.lab4.p1;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;
import pl.wit.lab4.p2.PersonException;

import java.util.LinkedHashMap;
import java.util.Map;

/**
 * Klasa pochodna - Student
 *
 * @author Łukasz
 */
public class StudentDemo extends AbstractDemo {
    protected static final Logger log = LogManager.getLogger(StudentDemo.class.getName());


    Map<String, Byte> mapPoints = null;

    public StudentDemo(String firstName, String lastName) {
        super(firstName, lastName);
        mapPoints = new LinkedHashMap<String, Byte>();
    }

    @Override
    protected EnPersonType getPersonType() {
        return EnPersonType.student;
    }

    public void addPoints(String criteria, Byte points) throws PersonException {
        if (criteria == null || criteria.isEmpty())
            throw new PersonException("Metoda addPoints nie dopuszcza pustej wartości zmiennej criteria.");
        if (points < 0) throw new PersonException("Metoda addPoints nie dopuszcza ujemnej liczby punktów.");
        mapPoints.put(criteria, points);
    }

    public Map<String, Byte> getMapPoints() {
        return mapPoints;
    }

    @Override
    public Logger getLogger() {
        return log;
    }

    @Override
    public String getAdditionalInfo() {
        return getStringData();
    }
}
