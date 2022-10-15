package pl.wit.lab3.p1;

import java.math.BigDecimal;
import java.util.Date;
/**
 * Klasa pochodna dla przetwrzania danych pracownika
 * @author Łukasz
 *
 */
public class Employee1 extends pl.wit.lab3.p1.Person1 {
	//Data zatrudnienia
	private Date employmentDate = null;
	//Wyngrodzenie
	private BigDecimal salary = null;
	
	///////////////////////////////////
	// getters and setters
	///////////////////////////////////
	
	public Date getEmploymentDate() {
		return employmentDate;
	}
	public void setEmploymentDate(Date employmentDate) {
		this.employmentDate = employmentDate;
	}
	public BigDecimal getSalary() {
		return salary;
	}
	public void setSalary(BigDecimal salary) {
		this.salary = salary;
	}
}
