package pl.wit.lab1;

import org.junit.Assert;
import org.junit.Test;

import static org.junit.Assert.*;

public class PointTest {
    @Test
    public void TranslateXTest() {
        Point point = new Point(5f,3f);
        point.translateX(7f);
        assertEquals(12f, point.getX(), 0.001f);
    }

    @Test
    public void TranslateYTest() {
        Point point = new Point(5f,3f);
        point.translateY(7f);
        assertEquals(10f, point.getY(), 0.001f);
    }

    @Test
    public void AddTest()
    {
     Point p1 = new Point(3,5);
     Point p2 = new Point(5,7);
    p1.add(p2);
    assertEquals(8f, p1.getX(), 0.001f);
    assertEquals(12f, p1.getY(),0.001f);
    }

    @Test
    public void Add2PointsTest()
    {
        Point p1 = new Point(3,5);
        Point p2 = new Point(5,7);
        Point p3 = Point.add(p1, p2);
        assertEquals(8f, p3.getX(), 0.001f);
        assertEquals(12f, p3.getY(), 0.001f);

    }

    @Test
    public void SubtractTest()
    {
        Point p1 = new Point(3,5);
        Point p2 = new Point(5,8);
        p1.subtract(p2);
        assertEquals(-2f, p1.getX(), 0.001f);
        assertEquals(-3f, p1.getY(), 0.001f);
    }

    @Test
    public void GetNewPointTest(){
        Point p1 = new Point(3,5);
        Point p2 = p1.getPoint();

        p1.setX(7);
        p1.setY(9);

        Assert.assertEquals(7f,p1.getX(), 0.001f);
        Assert.assertEquals(9f,p1.getY(), 0.001f);
        Assert.assertEquals(3f,p2.getX(), 0.001f);
        Assert.assertEquals(5f,p2.getY(), 0.001f);
    }
}