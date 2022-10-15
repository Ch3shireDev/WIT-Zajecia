package pl.wit.lab4.p2;

import org.javatuples.Pair;

import java.util.Collection;
import java.util.Date;
import java.util.Map;

/**
 * Klasa przechowująca podstawowe dane osobowe
 * używająca konstruktorów przeciążonych
 *
 * @author Łukasz
 */
public abstract class Person {

    public abstract boolean search(Map<String, Pair<Object, Byte>> map) throws Exception;

    // Imię
    private String firstName = null;
    // Nazwisko
    private String lastName = null;
    // Data urodzenia
    private Date dateOfBirth = null;

    public Person(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Person(String firstName, String lastName, Date dateOfBirth) {
        this(firstName, lastName);
        this.dateOfBirth = dateOfBirth;
    }

    protected boolean isEnumerable(Object criteria) {
        return Collection.class.isAssignableFrom(criteria.getClass()) || criteria.getClass().isArray();
    }

    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("firstName=").append(firstName).append("\n");
        sb.append("lastName=").append(lastName).append("\n");
        sb.append("dateOfBirth=").append(dateOfBirth.toString()).append("\n");
        return sb.toString();
    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo) {
        return matchesFirstName(firstName, false) && matchesLastName(lastName, false)
                && matchesDateOfBirth(birthFrom, birthTo);

    }

    public boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, boolean strict) {
        return matchesFirstName(firstName, strict) && matchesLastName(lastName, strict)
                && matchesDateOfBirth(birthFrom, birthTo);

    }

    private boolean matchesFirstName(String firstName, boolean strict) {
        if (firstName != null) {
            if (this.firstName != null) {
                if (!strict)
                    return this.firstName.startsWith(firstName);
                else
                    return this.firstName.equalsIgnoreCase(firstName);
            }
            else
                return false;
        }
        return true;
    }

    private boolean matchesLastName(String lastName, boolean strict) {
        if (lastName != null) {
            if (this.lastName != null) {
                if (!strict)
                    return this.lastName.startsWith(lastName);
                else
                    return this.lastName.equalsIgnoreCase(lastName);
            }
            else
                return false;
        }
        return true;
    }

    private boolean matchesDateOfBirth(Date birthFrom, Date birthTo) {

        if (birthFrom != null) {
            if (this.dateOfBirth != null) {
                if (!(this.dateOfBirth.after(birthFrom) || this.dateOfBirth.equals(birthFrom)))
                    return false;
            }
            else
                return false;
        }
        if (birthTo != null) {
            if (this.dateOfBirth != null) {
				return this.dateOfBirth.before(birthTo) || this.dateOfBirth.equals(birthTo);
            }
            else
                return false;
        }

        return true;
    }

    ///////////////////////////////////////////
    // getters and setters
    ///////////////////////////////////////////
    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public Date getDateOfBirth() {
        return dateOfBirth;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }
}