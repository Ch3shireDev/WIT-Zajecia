package pl.wit.lab6;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;
import java.util.Set;

public class CollectionsTutorialTest {
    CollectionsTutorial ct;

    @BeforeEach
    void SetUp() {

        ct = new CollectionsTutorial();
    }

    @Test
    void getSet() {
        Assertions.assertEquals(10000, ct.getSet().stream().count());
    }

    @Test
    void getOnlyEvenItems() {
        List<String> c = ct.getOnlyEvenItems();

        Assertions.assertTrue(c.contains("item_0"));
        Assertions.assertTrue(c.contains("item_2"));
        Assertions.assertTrue(c.contains("item_4"));

        Assertions.assertFalse(c.contains("item_1"));
        Assertions.assertFalse(c.contains("item_3"));
        Assertions.assertFalse(c.contains("item_5"));
    }

    @Test
    void getSetWithOrderWithNoLessThan100() {
        Set<String> set = ct.getSetWithOrderWithNoLessThan100();
        Assertions.assertTrue(set.contains("item_0"));
        Assertions.assertTrue(set.contains("item_1"));
        Assertions.assertTrue(set.contains("item_2"));
        Assertions.assertTrue(set.contains("item_99"));
        Assertions.assertTrue(set.contains("item_100"));
        Assertions.assertFalse(set.contains("item_101"));
    }

    @Test
    void getEvery3ElementAsSortedSet() {
        Set<String> set = ct.getEvery3ElementAsSortedSet();
        Assertions.assertNotNull(set);
        Assertions.assertNotEquals(0, set.size());
    }
}
