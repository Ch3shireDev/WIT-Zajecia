package pl.wit.lab3.p5;

import java.math.BigDecimal;
import java.util.Date;
/**
 * Klasa pracownika
 * wykonana z użyciem wywołania konstruktora
 * klasy bazowej
 * @author Łukasz
 *
 */
public class Employee3 extends Person3{
	//Data zatrudnienia
	private Date employmentDate = null;
	//Wyngrodzenie
	private BigDecimal sallary = null;
	
	public Employee3(String firstName, String lastName, Date dateOfBirth,Date employmentDate, BigDecimal sallary ) {
		super(firstName, lastName, dateOfBirth);
		this.employmentDate = employmentDate;
		this.sallary = sallary;
	}
	
	public String toString() {
		StringBuilder sb = new StringBuilder(super.toString());
		sb.append("employmentDate=").append(employmentDate.toString()).append("\n");
		sb.append("sallary=").append(sallary.toString()).append("\n");
		return sb.toString();
	}
	////////////////////////////////////////
	//	getters and setters
	////////////////////////////////////////
	
	public Date getEmploymentDate() {
		return employmentDate;
	}

	public BigDecimal getSallary() {
		return sallary;
	}
}