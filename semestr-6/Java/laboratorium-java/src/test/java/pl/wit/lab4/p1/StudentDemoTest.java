package pl.wit.lab4.p1;
import junit.framework.TestCase;
import org.apache.log4j.BasicConfigurator;
import org.apache.log4j.Level;
import org.apache.log4j.Logger;
import org.junit.Assert;
import org.junit.BeforeClass;
import pl.wit.lab4.p1.StudentDemo;
import pl.wit.lab4.p2.PersonException;

import java.util.Map;

public class StudentDemoTest extends TestCase {
    @BeforeClass
    public static void setUpBeforeClass() throws Exception {
        BasicConfigurator.configure();
        Logger.getRootLogger().setLevel(Level.TRACE);
    }

    public void testGetPersonType() {
        StudentDemo student = new StudentDemo("Jan", "Kowalski");
        String data = student.getStringData();
        Assert.assertEquals("Jan Kowalski - student", data);
    }

    public void testAddPoints() throws PersonException {
        StudentDemo student = new StudentDemo("Jan", "Kowalski");
        student.addPoints("Język Java", (byte) 66);
        student.addPoints("Wstęp do kryptologii", (byte) 50);
        student.addPoints("Przetwarzanie obrazów", (byte) 30);

        Map<String, Byte> points = student.getMapPoints();
        Assert.assertEquals(3, points.keySet().size());
        Assert.assertEquals((byte) 66, (byte) points.get("Język Java"));
        Assert.assertEquals((byte) 50, (byte) points.get("Wstęp do kryptologii"));
        Assert.assertEquals((byte) 30, (byte) points.get("Przetwarzanie obrazów"));
    }

    public void testIncorrectPoints() {
        StudentDemo student = new StudentDemo("Jan", "Kowalski");
        try {
            student.addPoints("Matematyka dyskretna", (byte) -100);
            Assert.fail();
        }
        catch (PersonException e) {
            //
        }
    }

    public void testIncorrectCriteriaEmptyString() {
        StudentDemo student = new StudentDemo("Jan", "Kowalski");
        try {
            student.addPoints("", (byte) 100);
            Assert.fail();
        }
        catch (PersonException e) {
            //
        }
    }

    public void testIncorrectCriteriaNullString() {
        StudentDemo student = new StudentDemo("Jan", "Kowalski");
        try {
            student.addPoints(null, (byte) 100);
            Assert.fail();
        }
        catch (PersonException e) {
            //
        }
    }
}
