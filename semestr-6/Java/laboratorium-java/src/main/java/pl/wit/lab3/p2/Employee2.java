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
	private BigDecimal salary = null;

	public Employee2(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal salary) {
		super(firstName, lastName, dateOfBirth);
		this.employmentDate = employmentDate;
		this.salary = salary;
	}

	////////////////////////////////////////
	// getters and setters
	////////////////////////////////////////

	public Date getEmploymentDate() {
		return employmentDate;
	}

	public BigDecimal getSalary() {
		return salary;
	}

	public String toString(){
		StringBuilder sb = new StringBuilder();
		sb.append(super.toString());
		sb.append(", Date of employment: ");
		sb.append(getEmploymentDate());
		sb.append(", salary: ");
		sb.append(getSalary());
		return sb.toString();
	}
}
