package pl.wit.lab3.p2;

import junit.framework.TestCase;
import org.junit.Assert;

import java.math.BigDecimal;
import java.util.Calendar;
import java.util.Date;

public class Employee2Test extends TestCase {

    public void testTestToString() {
        Employee2 employee = new Employee2("Jan", "Kowalski", new Date(91, Calendar.FEBRUARY, 22), new Date(115, Calendar.FEBRUARY, 22), new BigDecimal("1234.56"));

        Assert.assertEquals("Jan Kowalski, Date of birth: Fri Feb 22 00:00:00 CET 1991, Date of employment: Sun Feb 22 00:00:00 CET 2015, salary: 1234.56", employee.toString());
    }
}