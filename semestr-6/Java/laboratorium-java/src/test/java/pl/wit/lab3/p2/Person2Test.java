package pl.wit.lab3.p2;

import junit.framework.TestCase;
import org.junit.Assert;

import java.util.Calendar;
import java.util.Date;

public class Person2Test extends TestCase {

    public void testTestToString() {
        Person2 person = new Person2("Jan", "Kowalski", new Date(91, Calendar.APRIL, 25));
        Assert.assertEquals("Jan Kowalski, Date of birth: Thu Apr 25 00:00:00 CEST 1991", person.toString());
    }
}