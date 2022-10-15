package pl.wit.lab3;

import junit.framework.TestCase;
import org.junit.Assert;

public class Lab2SetAndMapExampleTest extends TestCase {

    public void testAddElementSet() {
        Lab2SetAndMapExample example = new Lab2SetAndMapExample();
        Assert.assertEquals(0, example.getSetCars().stream().count());
        example.addElement("aaa");
        Assert.assertEquals(1, example.getSetCars().stream().count());
    }

    public void testAddElementMap() {
        Lab2SetAndMapExample example = new Lab2SetAndMapExample();
        Assert.assertEquals(-1, example.getMapValue("aaa"));
        Assert.assertEquals(0, example.getMapCarPower().keySet().stream().count());
        example.addElement("aaa", 15);
        Assert.assertEquals(1, example.getMapCarPower().keySet().stream().count());
    }

    public void testGetMapValue() {
        Lab2SetAndMapExample example = new Lab2SetAndMapExample();
        Assert.assertEquals(false, example.isSetContains("aaa"));
        example.addElement("aaa");
        Assert.assertEquals(true, example.isSetContains("aaa"));
    }

    public void testIsSetContains() {
        Lab2SetAndMapExample example = new Lab2SetAndMapExample();
        Assert.assertEquals(-1, example.getMapValue("aaa"));
        example.addElement("aaa", 15);
        Assert.assertEquals(15, example.getMapValue("aaa"));
    }
}