package pl.wit.lab3.p5;

import java.math.BigDecimal;
import java.text.MessageFormat;
import java.util.*;


/**
 * Klasa pochodna przechowująca dane Programisty
 *
 * @author Łukasz
 */
public class Programmer3 extends Employee3 {
    //Mapa znanych języków z oceną umiejęstności
    private Map<String, Short> mapProgrammingLanguages = null;

    public Programmer3(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
        super(firstName, lastName, dateOfBirth, employmentDate, sallary);
        this.mapProgrammingLanguages = new HashMap<String, Short>();
    }

    public String toString() {
        StringBuilder sb = new StringBuilder(super.toString());
        sb.append("mapProgrammingLanguages=").append(mapProgrammingLanguages.toString());

        return sb.toString();
    }

    /**
     * Metoda dodająca kolejny język
     *
     * @param language
     */
    public void addProgrammingLanguage(String language, Short mark) {
        if (mark != null && mark.compareTo((short) 0) > 0 && mark.compareTo((short) 6) <= 0)
            mapProgrammingLanguages.put(language, mark);
    }

    /**
     * Metoda zwraqcająca posortowaną tablice języków obcych
     *
     * @return
     */
    public String getProgrammingLanguageInfo(String language) {
        if (!mapProgrammingLanguages.containsKey(language)) {
            Locale locale = new Locale("pl", "PL");
            ResourceBundle exampleBundle = ResourceBundle.getBundle("resources", locale);
            String textPattern = exampleBundle.getString("no_programming.languages");
            return MessageFormat.format(textPattern, language);

        }
        else {
            String result = language.concat(" ").concat(mapProgrammingLanguages.get(language).toString());
            return result;
        }

    }

    public boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal salaryFrom, BigDecimal salaryTo, HashMap<String, Short> languages) {
        if (!super.matches(firstName, lastName, birthFrom, birthTo, employmentFrom, employmentTo, salaryFrom, salaryTo))
            return false;
        if (languages.size() > this.mapProgrammingLanguages.size()) return false;
        for (String language : languages.keySet()) {
            Short level = languages.get(language);
            if (!this.mapProgrammingLanguages.containsKey(language)) return false;
            if (this.mapProgrammingLanguages.get(language) < level) return false;
        }
        return true;
    }
}
