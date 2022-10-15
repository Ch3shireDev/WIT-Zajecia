package pl.wit.lab2;

import junit.framework.TestCase;
import org.junit.Assert;

import java.time.LocalDate;

public class PresentationTest extends TestCase {

    public void testGetFullName() {
        Presentation presentation = new Presentation("Igor", "Nowicki");
        Assert.assertEquals("Igor Nowicki", presentation.getFullName());
    }

    public void testGetBirthdayDateAsString() {
        Presentation presentation = new Presentation("Igor", "Nowicki", 25, 1, 91);
        Assert.assertEquals("25.01.91", presentation.getBirthdayDateAsString());
    }

    public void testGetAge() {
        Presentation presentation = new Presentation("Igor", "Nowicki", 25, 1, 91);
        Assert.assertEquals(31, presentation.getAge(LocalDate.of(2022, 4, 1)));

    }

    public void testGetPresentationStoryNoFriends() {
        Presentation p1 = new Presentation("Igor", "Nowicki", 25, 1, 91);
        Assert.assertEquals("Igor Nowicki, Data urodzenia: 25.01.91, Liczba znajomych na Facebooku: brak.", p1.getPresentationStory());

    }

    public void testGetPresentationStoryFriends() {
        Presentation p1 = new Presentation("Igor", "Nowicki", 25, 1, 91);
        p1.setFacebookFriendsQuantity((short) 5);
        Assert.assertEquals("Igor Nowicki, Data urodzenia: 25.01.91, Liczba znajomych na Facebooku: 5.", p1.getPresentationStory());
        System.out.println(p1.getPresentationStory());
    }

    public void testGetPresentationStoryCountries() {
        Presentation p1 = new Presentation("Igor", "Nowicki", 25, 1, 91);
        p1.setFacebookFriendsQuantity((short) 5);
        p1.setVisitedPlaces(new String[]{"Australia", "Belgia", "Chile", "Dania", "Egipt"});
        Assert.assertEquals("Igor Nowicki, Data urodzenia: 25.01.91, Liczba znajomych na Facebooku: 5. Odwiedzone miejsca: Australia, Belgia, Chile, Dania, Egipt.", p1.getPresentationStory());
        System.out.println(p1.getPresentationStory());
    }

    public void testGetPresentationStoryExplorer() {
        Presentation p1 = new Presentation("Igor", "Nowicki", 25, 1, 91);
        p1.setFacebookFriendsQuantity((short) 5);
        p1.setVisitedPlaces(new String[]{"Australia", "Belgia", "Chile", "Dania", "Egipt", "Finlandia"});
        Assert.assertEquals("Igor Nowicki, Data urodzenia: 25.01.91, Liczba znajomych na Facebooku: 5. Odwiedzone miejsca: Australia, Belgia, Chile, Dania, Egipt, Finlandia. Ta osoba uwielbia podróżować!", p1.getPresentationStory());
        System.out.println(p1.getPresentationStory());
    }
}