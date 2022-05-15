package pl.wit.lab4.p2;

import junit.framework.TestCase;
import org.javatuples.Pair;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.JUnit4;

import java.math.BigDecimal;
import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.Map;

@RunWith(JUnit4.class)
public class EmployeeTest extends TestCase {

    Employee employee;
    Map<String, Pair<Object, Byte>> map;

    @Before
    public void init() {
        employee = new Employee(
                "Jan",
                "Kowalski",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(3500));
        map = new HashMap<>();
    }

    @Test
    public void testSearchFirstNameEquals() throws Exception {
        map.put("firstName", new Pair<>("Jan", OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSearchFirstNameLike() throws Exception {
        map.put("firstName", new Pair<>("Ja", OperatorsConst.ILIKE));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSearchFirstNameIncorrect() throws Exception {
        map.put("firstName", new Pair<>("Ig", OperatorsConst.ILIKE));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testSearchFirstLastNameCorrect() throws Exception {
        map.put("firstName", new Pair<>("Jan", OperatorsConst.EQUALS));
        map.put("lastName", new Pair<>("Kowalski", OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSearchFirstLastNameIncorrect() throws Exception {
        map.put("firstName", new Pair<>("Jan", OperatorsConst.EQUALS));
        map.put("lastName", new Pair<>("Zamachowski", OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testEmploymentDateEqualsCorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 05, 01).getTime(), OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testEmploymentDateGreaterEqualsCorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 05, 01).getTime(), OperatorsConst.GREATER_EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testEmploymentDateLessEqualsCorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 05, 01).getTime(), OperatorsConst.LESS_EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testEmploymentDateEqualsIncorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 05, 02).getTime(), OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testEmploymentDateLessCorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 04, 01).getTime(), OperatorsConst.LESS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testEmploymentDateLessIncorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 06, 01).getTime(), OperatorsConst.LESS));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testEmploymentDateGreaterCorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 06, 01).getTime(), OperatorsConst.GREATER));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testEmploymentDateGreaterIncorrect() throws Exception {
        map.put("employmentDate", new Pair<>(new GregorianCalendar(2010, 04, 01).getTime(), OperatorsConst.GREATER));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testDateOfBirthEqualsCorrect() throws Exception {
        map.put("dateOfBirth", new Pair<>(new GregorianCalendar(1991, 01, 01).getTime(), OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testDateOfBirthEqualsIncorrect() throws Exception {
        map.put("dateOfBirth", new Pair<>(new GregorianCalendar(1991, 01, 02).getTime(), OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testNoArgumentsCorrect() throws Exception {
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSalaryEqualsCorrect() throws Exception {
        map.put("salary", new Pair<>(new BigDecimal(3500), OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSalaryEqualsIncorrect() throws Exception {
        map.put("salary", new Pair<>(new BigDecimal(3600), OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void testSalaryLessCorrect() throws Exception {
        // Czy pracownik ma mniej niż 3600 zarobków? Powinna wyjść prawda.
        map.put("salary", new Pair<>(new BigDecimal(3600), OperatorsConst.LESS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSalaryLessIncorrect() throws Exception {
        // Czy pracownik ma mniej niż 3400 zarobków? Powinien wyjść fałsz.
        map.put("salary", new Pair<>(new BigDecimal(3400), OperatorsConst.LESS));
        Assert.assertFalse(employee.search(map));
    }
    @Test
    public void testSalaryGreaterCorrect() throws Exception {
        // Czy pracownik ma więcej niż 3400 zarobków? Powinna wyjść prawda.
        map.put("salary", new Pair<>(new BigDecimal(3400), OperatorsConst.GREATER));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSalaryGreaterIncorrect() throws Exception {
        // Czy pracownik ma więcej niż 3600 zarobków? Powinien wyjść fałsz.
        map.put("salary", new Pair<>(new BigDecimal(3600), OperatorsConst.GREATER));
        Assert.assertFalse(employee.search(map));
    }
}