package pl.wit.lab4.p1;

import junit.framework.TestCase;
import org.apache.log4j.BasicConfigurator;
import org.apache.log4j.Level;
import org.apache.log4j.Logger;
import org.junit.Assert;
import org.junit.BeforeClass;
import org.junit.Test;
import pl.wit.lab4.p1.AbstractDemo;
import pl.wit.lab4.p1.StudentDemo;
import pl.wit.lab4.p1.TeacherDemo;

public class AbstractDemoTest extends TestCase {
    @BeforeClass
    public static void setUpBeforeClass() throws Exception {
        BasicConfigurator.configure();
        Logger.getRootLogger().setLevel(Level.TRACE);
    }

    @Test
    public void testGetPersonType() {
        AbstractDemo student = new StudentDemo("Jan", "Kowalski");
        Assert.assertEquals("Jan Kowalski - student", student.getStringData());
        AbstractDemo teacher = new TeacherDemo("Jan", "Kowalski");
        Assert.assertEquals("Jan Kowalski - nauczyciel", teacher.getStringData());
    }

}