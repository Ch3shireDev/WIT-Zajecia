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
public class SecretaryTest extends TestCase {
    Employee employee;
    Map<String, Pair<Object, Byte>> map;

    @Before
    public void init() {
        employee = new Secretary(
                "Jan",
                "Kowalski",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(3500));

        ((Secretary) employee).addLanguage("angielski");
        ((Secretary) employee).addLanguage("niemiecki");
        ((Secretary) employee).addLanguage("rosyjski");

        map = new HashMap<>();
    }

    @Test
    public void testSearchLanguageEqualsMatches() throws Exception {
        HashSet<String> languages = new HashSet<String>();
        languages.add("angielski");
        languages.add("rosyjski");
        languages.add("niemiecki");
        map.put("languages", new Pair<>(languages, OperatorsConst.EQUALS));
        Assert.assertTrue(employee.search(map));
    }


    @Test
    public void testSearchLanguageEqualsNotMatches() throws Exception {
        HashSet<String> languages = new HashSet<String>();
        languages.add("angielski");
        languages.add("rosyjski");
        map.put("languages", new Pair<>(languages, OperatorsConst.EQUALS));
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


    @Test
    public void testSearchLanguageLikeMatches() throws Exception {
        HashSet<String> languages = new HashSet<String>();
        languages.add("angielski");
        languages.add("rosyjski");
        map.put("languages", new Pair<>(languages, OperatorsConst.ILIKE));
        Assert.assertTrue(employee.search(map));
    }

    @Test
    public void testSearchLanguageLikeNotMatches() throws Exception {
        HashSet<String> languages = new HashSet<String>();
        languages.add("angielski");
        languages.add("francuski");
        map.put("languages", new Pair<>(languages, OperatorsConst.ILIKE));
        Assert.assertFalse(employee.search(map));
    }
}