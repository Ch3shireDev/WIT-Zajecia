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
import java.util.HashSet;
import java.util.Map;

@RunWith(JUnit4.class)
public class ProgrammerTest extends TestCase {

    Employee employee;
    Map<String, Pair<Object, Byte>> map;

    @Before
    public void init() {
        employee = new Programmer(
                "Jan",
                "Kowalski",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(3500));

        ((Programmer) employee).addProgrammingLanguage("Python",(short) 5);
        ((Programmer) employee).addProgrammingLanguage("C++", (short) 3);
        ((Programmer) employee).addProgrammingLanguage("Java",(short) 1);

        map = new HashMap<>();
    }

    @Test
    public void TestProgrammingLanguageEquals() throws Exception {
        Map<String, Short> languages = new HashMap<String,Short>();
        languages.put("Python", (short)5);
        languages.put("C++", (short)3);
        languages.put("Java", (short)1);
        map.put("programmingLanguages", new Pair<>(languages, OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void TestProgrammingLanguageNotEquals() throws Exception {
        Map<String, Short> languages = new HashMap<String,Short>();
        languages.put("Python", (short)5);
        languages.put("Java", (short)1);
        map.put("programmingLanguages", new Pair<>(languages, OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }

    @Test
    public void TestProgrammingLanguageLike() throws Exception {
        Map<String, Short> languages = new HashMap<String,Short>();
        languages.put("Python", (short)5);
        languages.put("Java", (short)1);
        map.put("programmingLanguages", new Pair<>(languages, OperatorsConst.ILIKE));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void TestProgrammingLanguageNotEquals2() throws Exception {
        Map<String, Short> languages = new HashMap<String,Short>();
        languages.put("Python", (short)5);
        languages.put("C++", (short)4);
        languages.put("Java", (short)1);
        map.put("programmingLanguages", new Pair<>(languages, OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }
    @Test
    public void TestProgrammingLanguageNotLike() throws Exception {
        Map<String, Short> languages = new HashMap<String,Short>();
        languages.put("Python", (short)5);
        languages.put("Java", (short)1);
        languages.put("Go", (short)5);
        map.put("programmingLanguages", new Pair<>(languages, OperatorsConst.ILIKE));
        Assert.assertFalse(employee.search(map));
    }


    @Test
    public void testFirstName() throws Exception {
        map.put("firstName", new Pair<>("Jan", OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testFirstNameFalse() throws Exception {
        map.put("firstName", new Pair<>("Piotr", OperatorsConst.EQUALS));
        Assert.assertFalse(employee.search(map));
    }

}