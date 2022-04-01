package pl.wit.lab2;

import junit.framework.TestCase;
import org.junit.Assert;

import java.util.Arrays;

public class Lab2ArraysExampleTest extends TestCase {

    public void testAddElement() {
        Lab2ArraysExample arrEx = new Lab2ArraysExample(1);
        Assert.assertArrayEquals(new int[]{1}, arrEx.getIntNumbers());
        arrEx.addElement(true);
        Assert.assertEquals(Arrays.toString(new boolean[]{true}),
                Arrays.toString(arrEx.getBoolElements()));
        arrEx.addElement("Test");
        Assert.assertArrayEquals(new String[]{"Test"}, arrEx.getStringElements());
    }

    public void testGetIntArraySize() {
        Lab2ArraysExample arr = new Lab2ArraysExample(1);
        arr.addElement(2);
        arr.addElement(3);
        Assert.assertEquals(3, arr.getIntArraySize());
    }

    public void testGetStringArraySize() {
        Lab2ArraysExample arr = new Lab2ArraysExample("abc");
        arr.addElement("cde");
        arr.addElement("efg");
        Assert.assertEquals(3, arr.getStringArraySize());
    }

    public void testGetBooleanArraySize() {
        Lab2ArraysExample arr = new Lab2ArraysExample(true);
        arr.addElement(true);
        arr.addElement(false);
        Assert.assertEquals(3, arr.getBooleanArraySize());
    }

    public void testGetIntArrayElement() {
        Lab2ArraysExample arr = new Lab2ArraysExample(1);
        arr.addElement(2);
        arr.addElement(3);
        Assert.assertEquals(2, arr.getIntArrayElement(1));
    }

    public void testGetStringArrayElement() {
        Lab2ArraysExample arr = new Lab2ArraysExample("abc");
        arr.addElement("cde");
        arr.addElement("efg");
        Assert.assertEquals("cde", arr.getStringArrayElement(1));
    }

    public void testGetBooleanArrayElement() {
        Lab2ArraysExample arr = new Lab2ArraysExample(true);
        arr.addElement(true);
        arr.addElement(false);
        Assert.assertEquals(true, arr.getBooleanArrayElement(1));
    }
}