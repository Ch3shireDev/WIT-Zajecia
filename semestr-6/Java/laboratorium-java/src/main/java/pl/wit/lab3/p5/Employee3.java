package pl.wit.lab3.p5;

import java.math.BigDecimal;
import java.util.Date;

/**
 * Klasa pracownika
 * wykonana z użyciem wywołania konstruktora
 * klasy bazowej
 *
 * @author Łukasz
 */
public class Employee3 extends Person3 {
    //Data zatrudnienia
    private Date employmentDate = null;
    //Wyngrodzenie
    private BigDecimal salary = null;

    public Employee3(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
        super(firstName, lastName, dateOfBirth);
        this.employmentDate = employmentDate;
        this.salary = sallary;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder(super.toString());
        sb.append("employmentDate=").append(employmentDate.toString()).append("\n");
        sb.append("sallary=").append(salary.toString()).append("\n");
        return sb.toString();
    }
    ////////////////////////////////////////
    //	getters and setters
    ////////////////////////////////////////

    public Date getEmploymentDate() {
        return employmentDate;
    }

    public BigDecimal getSalary() {
        return salary;
    }

    public boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal salaryFrom, BigDecimal salaryTo) {
        if (!super.matches(firstName, lastName, birthFrom, birthTo)) return false;
        if (employmentFrom != null && employmentFrom.after(this.employmentDate)) return false;
        if (employmentTo != null && employmentTo.before(this.employmentDate)) return false;
        if (salaryFrom != null && salaryFrom.compareTo(this.salary) == 1) return false;
        if (salaryTo != null && salaryTo.compareTo(this.salary) == -1) return false;
        return true;
    }
}