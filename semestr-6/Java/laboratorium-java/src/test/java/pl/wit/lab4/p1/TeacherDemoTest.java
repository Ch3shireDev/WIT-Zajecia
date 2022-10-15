package pl.wit.lab4.p1;

import junit.framework.TestCase;
import org.apache.log4j.BasicConfigurator;
import org.apache.log4j.Level;
import org.apache.log4j.Logger;
import org.junit.Assert;
import org.junit.BeforeClass;
import org.junit.Test;

public class TeacherDemoTest extends TestCase {
    @BeforeClass
    public static void setUpBeforeClass() throws Exception {
        BasicConfigurator.configure();
        Logger.getRootLogger().setLevel(Level.TRACE);
    }

    @Test
    public void testGetPersonType() {
        TeacherDemo teacher = new TeacherDemo("Jan", "Kowalski");
        String data = teacher.getStringData();
        Assert.assertEquals("Jan Kowalski - nauczyciel", data);
    }
}
