package pl.wit.lab3.p5;

import java.math.BigDecimal;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;
import java.util.stream.Collectors;

/**
 * Klasa pochodna przetwarzające dane Pracownika na stanowisku sekretarka
 *
 * @author Łukasz
 */
public class Secretary3 extends Employee3 {
    //Zbiór znanych języków obcych
    private Set<String> setLanguages = null;

    public Secretary3(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
        super(firstName, lastName, dateOfBirth, employmentDate, sallary);
        this.setLanguages = new HashSet<String>();
    }

    public String toString() {
        StringBuilder sb = new StringBuilder(super.toString());
        sb.append("setLanguages=").append(setLanguages.stream().collect(Collectors.joining(",", "{", "}")));
        return sb.toString();
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

    public boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom,
                           Date employmentTo, BigDecimal salaryFrom, BigDecimal salaryTo, Set<String> languages) {
        if (!super.matches(firstName, lastName, birthFrom, birthTo, employmentFrom, employmentTo, salaryFrom, salaryTo))
            return false;
        if (languages.size() > this.setLanguages.size()) return false;
        for (String language : languages) {
            if (!this.setLanguages.contains(language)) return false;
        }
        return true;
    }

}
