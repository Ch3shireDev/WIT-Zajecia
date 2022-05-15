package pl.wit.lab3.p1;

import java.math.BigDecimal;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;

/**
 * Klasa pochodna przetwarzające dane Pracownika na stanowisku sekretarka
 *
 * @author Łukasz
 */
public class Secretary1 extends Employee1 {
    //Zbiór znanych języków obcych
    private Set<String> setLanguages = null;

    public Secretary1(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal salary) {
        setFirstName(firstName);
        setLastName(lastName);
        setDateOfBirth(dateOfBirth);
        setEmploymentDate(employmentDate);
        setSalary(salary);
        this.setLanguages = new HashSet<String>();
    }

    /**
     * Metoda dodająca kolejny język
     *
     * @param language
     */
    public void addLanguage(String language) {
        setLanguages.add(language);
    }

    /**
     * Metoda zwracająca posortowaną tablice języków obcych
     *
     * @return
     */
    public Set<String> getLanguages() {
        return setLanguages;
    }
}
