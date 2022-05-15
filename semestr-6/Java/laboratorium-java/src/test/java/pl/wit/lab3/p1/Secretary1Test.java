package pl.wit.lab3.p1;

import junit.framework.TestCase;
import org.junit.Assert;

import java.math.BigDecimal;
import java.util.Calendar;
import java.util.Date;
import java.util.Set;

public class Secretary1Test extends TestCase {

    public void testAddGetLanguages() {
        Secretary1 secretary = new Secretary1(
                "Jan",
                "Kowalski",
                new Date(1985, Calendar.APRIL, 11),
                new Date(2005, Calendar.APRIL, 11),
                new BigDecimal("1233.23")
                );
        secretary.addLanguage("english");
        secretary.addLanguage("german");

        Set<String> languages = secretary.getLanguages();
        Assert.assertEquals(true, languages.contains("english"));
        Assert.assertEquals(true, languages.contains("german"));
        Assert.assertEquals(false, languages.contains("polish"));
    }

}