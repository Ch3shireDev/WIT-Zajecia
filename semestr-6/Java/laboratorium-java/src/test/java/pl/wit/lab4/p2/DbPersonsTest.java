package pl.wit.lab4.p2;

import junit.framework.TestCase;
import org.javatuples.Pair;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.JUnit4;

import java.math.BigDecimal;
import java.util.*;


@RunWith(JUnit4.class)
public class DbPersonsTest extends TestCase {
    DbPersons dbPersons;
    Map<String, Pair<Object, Byte>> map;

    @Before
    public void init() {
        dbPersons = new DbPersons();

        dbPersons.addPerson(new Employee(
                "Jan",
                "Kowalski",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(3500)));
        dbPersons.addPerson(new Employee(
                "John",
                "Smith",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(3500)));
        dbPersons.addPerson(new Employee(
                "Mario",
                "Rossi",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(4500)));

        Secretary secretary = new Secretary("Israel",  "Israeli",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(5500)
        );

        secretary.addLanguage("angielski");
        secretary.addLanguage("rosyjski");

        dbPersons.addPerson(secretary);

        Programmer programmer = new Programmer("Israel",  "Israeli",
                new GregorianCalendar(1991, 01, 01).getTime(),
                new GregorianCalendar(2010, 05, 01).getTime(),
                new BigDecimal(6500)
        );

        programmer.addProgrammingLanguage("C++", (short) 4);
        programmer.addProgrammingLanguage("Python", (short) 5);

        dbPersons.addPerson(programmer);

        map = new HashMap<>();
    }

    @Test
    public void testSearchEqualsFirstName() throws Exception {
        map.put("firstName", new Pair<>("John", OperatorsConst.EQUALS));
        List<Person> persons = dbPersons.search(map);
        Assert.assertEquals(1, persons.size());
        Person person = persons.get(0);
        Assert.assertEquals("John", person.getFirstName());
        Assert.assertEquals("Smith", person.getLastName());
    }

    @Test
    public void testSearchEqualsSalary() throws Exception {
        map.put("salary", new Pair<>(new BigDecimal(3500), OperatorsConst.EQUALS));
        List<Person> persons = dbPersons.search(map);
        Assert.assertEquals(2, persons.size());
        Person person0 = persons.get(0);
        Person person1 = persons.get(1);
        Assert.assertEquals("Jan", person0.getFirstName());
        Assert.assertEquals("John", person1.getFirstName());
    }

    @Test
    public void testSearchLanguages() throws Exception{
        String[] languages = new String[]{ "angielski", "rosyjski" };
        map.put("languages", new Pair<>(languages, OperatorsConst.EQUALS));
        Assert.assertEquals(1, dbPersons.search(map).size());
    }

    @Test
    public void testSearchProgrammingLanguages() throws Exception{
        Map<String,Short> languages = new HashMap<>();
        languages.put("C++", (short)4);
        languages.put("Python", (short)5);
        map.put("programmingLanguages", new Pair<>(languages, OperatorsConst.EQUALS));
        Assert.assertEquals(1, dbPersons.search(map).size());
    }

    @Test
    public void testSearchSalaryLowerEqualThan() throws Exception{
        // Wyszukujemy wszystkich pracowników którzy mają mniej lub równo 5500 zarobków.
        map.put("salary", new Pair<>(new BigDecimal(5500), OperatorsConst.LESS_EQUALS));
        Assert.assertEquals(4, dbPersons.search(map).size());
    }

    @Test
    public void testSearchSalaryLowerThan() throws Exception{
        // Wyszukujemy wszystkich pracowników którzy mają mniej niż 5500 zarobków.
        map.put("salary", new Pair<>(new BigDecimal(5500), OperatorsConst.LESS));
        Assert.assertEquals(3, dbPersons.search(map).size());
    }

}