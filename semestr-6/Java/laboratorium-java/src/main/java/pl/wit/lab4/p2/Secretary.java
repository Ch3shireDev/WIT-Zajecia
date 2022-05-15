package pl.wit.lab4.p2;

import org.javatuples.Pair;

import java.math.BigDecimal;
import java.util.*;
import java.util.stream.Collectors;


public class Secretary extends Employee {

    //Zbiór znanych języków obcych
    private Set<String> setLanguages = null;

    public Secretary(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
        super(firstName, lastName, dateOfBirth, employmentDate, sallary);
        this.setLanguages = new HashSet<String>();
    }

    @Override
    protected boolean isCriteria(String variable) {
        if (super.isCriteria(variable)) return true;
        return variable == "languages";
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
    protected boolean checkCriteria(String variable, Object criteria, Byte operator) throws Exception {
        if (!super.checkCriteria(variable, criteria, operator)) return false;

        switch (variable) {
            case "languages":
                return checkLanguages(criteria, operator);
        }
        return true;
    }

    private boolean checkLanguages(Object criteria, Byte operator) throws Exception {
        if (!Collection.class.isAssignableFrom(criteria.getClass()) && !criteria.getClass().isArray()) {
            throw new Exception("Nieprawidłowy argument.");
        }
        Collection<String> collection;
        if (Collection.class.isAssignableFrom(criteria.getClass())) {
            collection = (Collection<String>) criteria;
        }
        else {
            collection = Arrays.asList((String[]) criteria);
        }
        if (operator.equals(OperatorsConst.EQUALS)) {
            return areEqual(setLanguages, collection);
        }
        if (operator.equals(OperatorsConst.ILIKE)) {
            return setLanguages.containsAll(collection);
        }
        throw new Exception("Niepoprawny rodzaj operatora.");
    }

    private boolean areEqual(Collection<String> c1, Collection<String> c2) {
        if (c1.size() != c2.size()) return false;
        Object[] arr1 = c1.toArray();
        Object[] arr2 = c2.toArray();
        Arrays.sort(arr1);
        Arrays.sort(arr2);
        for (int i = 0; i < arr1.length; i++) {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder(super.toString());
        sb.append("setLanguages=").append(setLanguages.stream().collect(Collectors.joining(",", "{", "}")));
        return sb.toString();
    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal sallaryFrom, BigDecimal sallaryTo, Set<String> setLanguages, boolean strict) {
        return super.matches(firstName, lastName, birthFrom, birthTo, employmentFrom, employmentTo, sallaryFrom, sallaryTo, strict)
                && matchesLanguages(setLanguages);

    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal sallaryFrom, BigDecimal sallaryTo, Set<String> setLanguages) {
        return matches(firstName, lastName, birthFrom, birthTo, employmentFrom, employmentTo, sallaryFrom, sallaryTo, setLanguages, false);

    }

    private boolean matchesLanguages(Set<String> setLanguages) {
        if (setLanguages != null) {
            if (this.setLanguages != null) {
                Set<String> result = new HashSet<>(this.setLanguages);
                return (result.size() == setLanguages.size());
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
