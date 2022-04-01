package pl.wit.lab2;

import java.time.LocalDate;
import java.time.Period;

/**
 * Klasa prezentacji osoby.
 *
 * @author Igor Nowicki
 */
public class Presentation {

    // Imię osoby.
    private String firstName;
    // Nazwisko osoby.
    private String lastName;
    // Dzień, miesiąc i rok urodzin osoby.
    private byte birthdayDay, birthdayMonth, birthdayYear;
    // Miejsce urodzenia osoby.
    private String placeOfBirth;
    // Liczba przyjaciół na Facebooku.
    private short facebookFriendsQuantity;
    // Lista odwiedzonych miejsc.
    private String visitedPlaces[];

    public Presentation(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Presentation(String firstName, String lastName, int birthdayDay, int birthdayMonth, int birthdayYear) {
        this(firstName, lastName);
        this.birthdayDay = (byte) birthdayDay;
        this.birthdayMonth = (byte) birthdayMonth;
        this.birthdayYear = (byte) birthdayYear;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public byte getBirthdayDay() {
        return birthdayDay;
    }

    public void setBirthdayDay(byte birthdayDay) {
        this.birthdayDay = birthdayDay;
    }

    public byte getBirthdayMonth() {
        return birthdayMonth;
    }

    public void setBirthdayMonth(byte birthdayMonth) {
        this.birthdayMonth = birthdayMonth;
    }

    public byte getBirthdayYear() {
        return birthdayYear;
    }

    public void setBirthdayYear(byte birthdayYear) {
        this.birthdayYear = birthdayYear;
    }

    public String getPlaceOfBirth() {
        return placeOfBirth;
    }

    public void setPlaceOfBirth(String placeOfBirth) {
        this.placeOfBirth = placeOfBirth;
    }

    public short getFacebookFriendsQuantity() {
        return facebookFriendsQuantity;
    }

    public void setFacebookFriendsQuantity(short facebookFriendsQuantity) {
        this.facebookFriendsQuantity = facebookFriendsQuantity;
    }

    public String[] getVisitedPlaces() {
        return visitedPlaces;
    }

    public void setVisitedPlaces(String[] visitedPlaces) {
        this.visitedPlaces = visitedPlaces;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getFullName() {
        //Zwrócenie połączonej wartości imienia i nazwiska ze spacją pomiędzy
        return String.format("%s %s", firstName, lastName);
    }

    public String getBirthdayDateAsString() {
        return String.format("%02d.%02d.%02d", birthdayDay, birthdayMonth, birthdayYear);
    }

    public byte getAge() {
        LocalDate now = LocalDate.now();
        now.getYear();
        LocalDate dateTo = LocalDate.now();
        return getAge(dateTo);
    }

    public byte getAge(LocalDate dateTo) {
        LocalDate dateFrom = LocalDate.of(1900 + birthdayYear, birthdayMonth, birthdayDay);
        Period intervalPeriod = Period.between(dateFrom, dateTo);
        return (byte) intervalPeriod.getYears();
    }

    public String getPresentationStory() {
        StringBuilder sb = new StringBuilder();
        sb.append(getFullName());
        sb.append(", Data urodzenia: ");
        sb.append(getBirthdayDateAsString());
        sb.append(", Liczba znajomych na Facebooku: ");
        if (facebookFriendsQuantity <= 0) {
            sb.append("brak.");
        }
        else if (facebookFriendsQuantity < 5000) {
            sb.append(facebookFriendsQuantity);
            sb.append(".");
        }
        else {
            sb.append("duuużo znajomych.");
        }

        if (visitedPlaces != null && visitedPlaces.length > 0) {
            sb.append(" Odwiedzone miejsca: ");
            sb.append(String.join(", ", visitedPlaces));
            sb.append(".");

            if (visitedPlaces.length > 5) {
                sb.append(" Ta osoba uwielbia podróżować!");
            }
        }

        return sb.toString();
    }


}
