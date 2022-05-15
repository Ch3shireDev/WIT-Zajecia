package pl.wit.lab3.p5;

import junit.framework.TestCase;
import org.junit.Assert;

import java.util.Calendar;
import java.util.Date;

public class Person3Test extends TestCase {

    public void testMatches() {
        Person3 person = new Person3("Jan", "Kowalski", new Date(91, Calendar.JANUARY, 25));
        Assert.assertEquals(true, person.matches("Jan", null, null, null));
        Assert.assertEquals(true, person.matches("Jan", null, null, null, true));
        Assert.assertEquals(true, person.matches("Ja", null, null, null));
        Assert.assertEquals(false, person.matches("Ja", null, null, null, true));
        Assert.assertEquals(false, person.matches("Adam", null, null, null));

        Assert.assertEquals(true, person.matches("Jan", "Kowalski", null, null));
        Assert.assertEquals(true, person.matches("Jan", "Kowalski", null, null, true));
        Assert.assertEquals(true, person.matches("Jan", "Kowal", null, null));
        Assert.assertEquals(false, person.matches("Jan", "Kowal", null, null, true));
        Assert.assertEquals(false, person.matches("Jan", "Adamowicz", null, null));

        Assert.assertEquals(true, person.matches("Jan", "Kowalski", new Date(90, Calendar.JANUARY, 25), null));
        Assert.assertEquals(true, person.matches("Jan", "Kowalski", new Date(91, Calendar.JANUARY, 25), null));
        Assert.assertEquals(false, person.matches("Jan", "Kowalski", new Date(92, Calendar.JANUARY, 25), null));

        Assert.assertEquals(true, person.matches("Jan", "Kowalski", new Date(90, Calendar.JANUARY, 25), new Date(92, Calendar.JANUARY, 25)));
        Assert.assertEquals(false, person.matches("Jan", "Kowalski", new Date(90, Calendar.JANUARY, 25), new Date(90, Calendar.APRIL, 25)));

    }
}