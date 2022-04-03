package pl.wit.lab3.p1;

import java.util.Date;

/**
 * Klasa bazowa przetwarzająca podstawowe dane osobowe
 * @author Łukasz
 *
 */
public class Person1 {
	// Imię
	private String firstName = null;
	// Nazwisko
	private String lastName = null;
	// Data urodzenia
	private Date dateOfBirth = null;

	/////////////////////////////////
	// getters and setters
	/////////////////////////////////
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
