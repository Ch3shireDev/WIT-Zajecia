package pl.wit.lab3.p1;

import junit.framework.TestCase;
import org.junit.Assert;

import java.text.DateFormat;
import java.util.Calendar;
import java.util.Date;

public class Person1Test extends TestCase {

    public void testGetSetFirstName() {
        Person1 person = new Person1();
        person.setFirstName("Igor");
        Assert.assertEquals("Igor", person.getFirstName());
    }

    public void testGetSetLastName() {
        Person1 person = new Person1();
        person.setLastName("Nowicki");
        Assert.assertEquals("Nowicki", person.getLastName());
    }

    public void testGetSetDateOfBirth() {
        Person1 person = new Person1();
        person.setDateOfBirth(new Date(25,01,1991));
        Assert.assertEquals(new Date(25,01,1991), person.getDateOfBirth());
    }

}