package pl.wit.lab3.p5;

import java.util.Date;

/**
 * Klasa przechowująca podstawowe dane osobowe
 * używająca konstruktorów przeciążonych
 *
 * @author Łukasz
 */
public class Person3 {
    // Imię
    private String firstName = null;
    // Nazwisko
    private String lastName = null;
    // Data urodzenia
    private Date dateOfBirth = null;

    public Person3(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Person3(String firstName, String lastName, Date dateOfBirth) {
        this(firstName, lastName);
        this.dateOfBirth = dateOfBirth;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("firstName=").append(firstName).append("\n");
        sb.append("lastName=").append(lastName).append("\n");
        sb.append("dateOfBirth=").append(dateOfBirth.toString()).append("\n");
        return sb.toString();
    }

    ///////////////////////////////////////////
    // getters and setters
    ///////////////////////////////////////////
    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public Date getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo) {
        if (firstName != null && firstName != "" && this.firstName.indexOf(firstName) != 0) return false;
        if (lastName != null && lastName != "" && this.lastName.indexOf(lastName) != 0) return false;
        if (birthFrom != null && birthFrom.after(this.dateOfBirth)) return false;
        if (birthTo != null && birthTo.before(this.dateOfBirth)) return false;
        return true;
    }

    public boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, boolean strict){
        boolean result = matches(firstName, lastName, birthFrom, birthTo);
        if(!strict)return result;
        if(!result)return false;
        if(strict && firstName != null && firstName != this.firstName)return false;
        if(strict && lastName != null && lastName != this.lastName)return false;
        return true;
    }

}
