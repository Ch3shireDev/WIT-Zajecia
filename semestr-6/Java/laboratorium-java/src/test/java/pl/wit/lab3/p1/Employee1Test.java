package pl.wit.lab3.p1;

import junit.framework.TestCase;
import org.junit.Assert;

import java.math.BigDecimal;
import java.util.Calendar;
import java.util.Date;

public class Employee1Test extends TestCase {

    public void testGetSetEmploymentDate() {
        Employee1 employee = new Employee1();
        employee.setEmploymentDate(new Date(2021, Calendar.JANUARY,05));
        Assert.assertEquals(new Date(2021,Calendar.JANUARY,05), employee.getEmploymentDate());
    }


    public void testGetSetSalary() {
        Employee1 employee1 = new Employee1();
        employee1.setSalary(new BigDecimal("20123.45"));
        Assert.assertEquals(new BigDecimal("20123.45"), employee1.getSalary());
    }

}