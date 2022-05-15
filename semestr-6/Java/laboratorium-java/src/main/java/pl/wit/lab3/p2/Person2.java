package pl.wit.lab3.p2;

import java.util.Date;
/**
 * Klasa przechowująca podstawowe dane osobowe
 * używająca konstruktorów przeciążonych
 * @author Łukasz
 *
 */
public class Person2 {
	// Imię
	private String firstName = null;
	// Nazwisko
	private String lastName = null;
	// Data urodzenia
	private Date dateOfBirth = null;

	public Person2(String firstName, String lastName) {
		this.firstName = firstName;
		this.lastName = lastName;
	}

	public Person2(String firstName, String lastName, Date dateOfBirth) {
		this(firstName, lastName);
		this.dateOfBirth = dateOfBirth;
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

	public String toString(){
		StringBuilder sb = new StringBuilder();
		sb.append(getFirstName());
		sb.append(" ");
		sb.append(getLastName());
		sb.append(", Date of birth: ");
		sb.append(getDateOfBirth());
		return sb.toString();
	}
}
