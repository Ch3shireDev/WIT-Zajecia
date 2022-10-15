package pl.wit.lab4.p2;

import org.javatuples.Pair;

import java.math.BigDecimal;
import java.text.MessageFormat;
import java.util.*;


public class Programmer extends Employee {


    //Mapa znanych języków z oceną umiejętności
    private Map<String, Short> mapProgrammingLanguages = null;

    public Programmer(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
        super(firstName, lastName, dateOfBirth, employmentDate, sallary);
        this.mapProgrammingLanguages = new HashMap<String, Short>();
    }

    /**
     * Sprawdza czy obiekt spełnia listę warunków zawartą w conditions. Puste conditions oznacza spełnione warunki.
     * Jeśli dany argument w conditions (nazwa pod kluczem) nie występuje w klasie obiektu, traktowane jest to jako
     * niespełnienie warunków.
     *
     * @param conditions
     * @return
     * @throws Exception
     */
    @Override
    public boolean search(Map<String, Pair<Object, Byte>> conditions) throws Exception {
        for (String variable : conditions.keySet()) {
            Pair<Object, Byte> value = conditions.get(variable);
            Object criteria = value.getValue0();
            Byte operator = value.getValue1();
            if (!checkCriteria(variable, criteria, operator)) return false;
            if (!isCriteria(variable)) return false;
        }
        return true;
    }

    @Override
    protected boolean isCriteria(String variable) {
        if (super.isCriteria(variable)) return true;
        return variable == "programmingLanguages";
    }

    @Override
    protected boolean checkCriteria(String variable, Object criteria, Byte operator) throws Exception {
        if (!super.checkCriteria(variable, criteria, operator)) return false;

        switch (variable) {
            case "programmingLanguages":
                return checkLanguages(criteria, operator);
        }
        return true;
    }

    private boolean checkLanguages(Object criteria, Byte operator) throws Exception {
        Map<String, Short> collection = (Map<String, Short>) criteria;
        if (operator.equals(OperatorsConst.EQUALS)) {
            return areEqual(mapProgrammingLanguages, collection);
        }
        if (operator.equals(OperatorsConst.ILIKE)) {
            return contains(mapProgrammingLanguages, collection);
        }
        throw new Exception("Niepoprawny rodzaj operatora.");
    }

    private boolean areEqual(Map<String, Short> c1, Map<String, Short> c2) {
        if (c1.size() != c2.size()) return false;
        return contains(c1, c2);
    }

    private boolean contains(Map<String, Short> c1, Map<String, Short> c2) {

        for (String key : c2.keySet()) {
            if (!c1.containsKey(key)) return false;
            Short value = c2.get(key);
            if (c1.get(key) != value) return false;
        }
        return true;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder(super.toString());
        sb.append("mapProgrammingLanguages=").append(mapProgrammingLanguages.toString());

        return sb.toString();
    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal sallaryFrom, BigDecimal sallaryTo, Map<String, Short> mapProgrammingLanguages) {
        return matches(firstName, lastName, birthFrom, birthTo, employmentFrom, employmentTo, sallaryFrom, sallaryTo, mapProgrammingLanguages, false);

    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal sallaryFrom, BigDecimal sallaryTo, Map<String, Short> mapProgrammingLanguages, boolean strict) {
        return super.matches(firstName, lastName, birthFrom, birthTo, employmentFrom, employmentTo, sallaryFrom, sallaryTo, strict)
                && matchesProgLanguages(mapProgrammingLanguages);

    }

    private boolean matchesProgLanguages(Map<String, Short> mapProgrammingLanguages) {
        if (mapProgrammingLanguages != null) {
            Short markQuery = null;
            Short mark = null;
            if (this.mapProgrammingLanguages != null) {
                for (String progLang : mapProgrammingLanguages.keySet()) {
                    //Po napotkaniu pierwszego niezgodnego zwracamy false
                    if (!this.mapProgrammingLanguages.containsKey(progLang))
                        return false;
                    else {
                        markQuery = mapProgrammingLanguages.get(progLang);
                        mark = this.mapProgrammingLanguages.get(progLang);
                        if (markQuery != null && mark != null && markQuery.compareTo(mark) > 0)
                            return false;
                    }
                }
            }
            else {
                return false;
            }
        }
        return true;
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
}
