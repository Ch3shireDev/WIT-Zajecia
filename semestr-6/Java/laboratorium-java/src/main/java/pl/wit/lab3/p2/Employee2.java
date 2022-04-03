package pl.wit.lab3.p2;

import java.math.BigDecimal;
import java.util.Date;

/**
 * Klasa pracownika
 * wykonana z użyciem wywołania konstruktora
 * klasy bazowej
 * @author Łukasz
 *
 */
public class Employee2 extends Person2{
	// Data zatrudnienia
	private Date employmentDate = null;
	// Wyngrodzenie
	private BigDecimal sallary = null;

	public Employee2(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
		super(firstName, lastName, dateOfBirth);
		this.employmentDate = employmentDate;
		this.sallary = sallary;
	}

	////////////////////////////////////////
	// getters and setters
	////////////////////////////////////////

	public Date getEmploymentDate() {
		return employmentDate;
	}

	public BigDecimal getSallary() {
		return sallary;
	}
}
