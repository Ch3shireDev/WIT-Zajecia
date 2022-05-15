package pl.wit.lab3.p2;

import junit.framework.TestCase;
import org.junit.Assert;

import java.math.BigDecimal;
import java.util.Calendar;
import java.util.Date;

public class Secretary2Test extends TestCase {

    public void testTestToString() {
        Secretary2 person = new Secretary2("Jan", "Kowalski", new Date(91, Calendar.APRIL, 25), new Date(115, Calendar.APRIL, 25), new BigDecimal("12345"));
        person.addLanguage("rosyjski");
        person.addLanguage("niemiecki");
        Assert.assertEquals("Jan Kowalski, Date of birth: Thu Apr 25 00:00:00 CEST 1991, Date of employment: Sat Apr 25 00:00:00 CEST 2015, salary: 12345, znane języki: rosyjski, niemiecki", person.toString());
    }
}