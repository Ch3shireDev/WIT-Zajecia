package pl.wit.lab3.p1;

import junit.framework.TestCase;
import org.junit.Assert;

import java.math.BigDecimal;
import java.util.Calendar;
import java.util.Date;

public class Programmer1Test extends TestCase {

    public void testGetProgrammingLanguageInfo() {
        Programmer1 programmer = new Programmer1(
                "Jan",
                "Kowalski",
                new Date(1995, Calendar.JANUARY, 25),
                new Date(2020, Calendar.APRIL, 01),
                new BigDecimal("6432.25")
                );

        programmer.addProgrammingLanguage("Python", (short)4);
        programmer.addProgrammingLanguage("C#", (short)6);
        programmer.addProgrammingLanguage("Java", (short)0);

        Assert.assertEquals("Python 4", programmer.getProgrammingLanguageInfo("Python"));
        Assert.assertEquals("C# 6", programmer.getProgrammingLanguageInfo("C#"));
        Assert.assertEquals("Brak znajomości języka Java.", programmer.getProgrammingLanguageInfo("Java"));
        Assert.assertEquals("Brak znajomości języka Go.", programmer.getProgrammingLanguageInfo("Go"));
    }

}