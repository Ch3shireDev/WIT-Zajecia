package pl.wit.lab4.p2;

import org.javatuples.Pair;

import java.math.BigDecimal;
import java.util.*;


public class Employee extends Person {

    // Data zatrudnienia
    private Date employmentDate = null;
    // Wyngrodzenie
    private BigDecimal salary = null;


    /**
     * @param firstName      Imię pracownika.
     * @param lastName       Nazwisko pracownika.
     * @param dateOfBirth    Data urodzin pracownika.
     * @param employmentDate Data zatrudnienia pracownika.
     * @param salary         Zarobki pracownika.
     */
    public Employee(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal salary) {
        super(firstName, lastName, dateOfBirth);
        this.employmentDate = employmentDate;
        this.salary = salary;
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

        // Kluczem mapy conditions jest nazwa zmiennej z postaci łańcucha znaków.
        for (String variable : conditions.keySet()) {

            // Wartością jest obiekt Pair,
            Pair<Object, Byte> value = conditions.get(variable);
            // który jako klucz posiada wartość kryterium
            Object criteria = value.getValue0();
            // a jako wartość operator zakodowany na typie Byte.
            Byte operator = value.getValue1();

            // Należy przeiterować się przez poszczególne elementy mapy i obsłużyć poszczególne warunki.
            // Warunki zbudowane w ten sposób należy połączyć z użyciem koniunkcji warunkowej.

            // Metoda ma zwracać true jeśli koniunkcja warunkowa wyrażeń logicznych zbudowanych dla
            // poszczególnych elementów mapy conditions będzie prawdziwa.
            if (!checkCriteria(variable, criteria, operator)) return false;
            if (!isCriteria(variable)) return false;
        }

        // UWAGA: jeśli mapa conditions będzie pusta to metoda ma zwrócić true.
        // Metoda ta ma za zadanie określać spełnienie warunku dopasowania względem przekazanych warunków.
        // Wykonaj implementację z użyciem metody z klasy bazowej oraz dodatkowo uwzględnij w
        // implementacji obsługę zmiennych składowych klasy Employee.
        return true;
    }


    /**
     * Sprawdza, czy data zatrudnienia spełnia kryterium.
     *
     * @param criteria
     * @param operator
     * @return
     * @throws Exception
     */
    boolean checkEmploymentDate(Object criteria, Byte operator) throws Exception {
        return compareDates((Date) criteria, employmentDate, operator);
    }


    /**
     * Porównuje dwie daty z użyciem operatora.
     *
     * @param date1
     * @param date2
     * @param operator
     * @return
     * @throws Exception
     */
    static boolean compareDates(Date date1, Date date2, Byte operator) throws Exception {
        if (operator.equals(OperatorsConst.EQUALS)) return date1.equals(date2);
        if (operator.equals(OperatorsConst.LESS_EQUALS)) return date1.before(date2) || date1.equals(date2);
        if (operator.equals(OperatorsConst.LESS)) return date1.before(date2);
        if (operator.equals(OperatorsConst.GREATER_EQUALS)) return date1.after(date2) || date1.equals(date2);
        if (operator.equals(OperatorsConst.GREATER)) return date1.after(date2);
        throw new Exception("Nieodpowiedni rodzaj operatora porównania.");
    }


    /**
     * Sprawdza, czy zarobki spełniają kryterium.
     *
     * @param criteria
     * @param operator
     * @return
     * @throws Exception
     */
    boolean checkSalary(Object criteria, Byte operator) throws Exception {
        if (criteria instanceof BigDecimal) return compareBigDecimal((BigDecimal) criteria, salary, operator);
        throw new Exception("Nieodpowiedni rodzaj wartości do sprawdzenia.");
    }

    /**
     * Porównuje wartości typu BigDecimal.
     *
     * @param value1
     * @param value2
     * @param operator
     * @return
     * @throws Exception
     */
    private boolean compareBigDecimal(BigDecimal value1, BigDecimal value2, Byte operator) throws Exception {
        if (operator.equals(OperatorsConst.EQUALS)) return value2.compareTo(value1) == 0;
        if (operator.equals(OperatorsConst.LESS_EQUALS)) return value2.compareTo(value1) <= 0;
        if (operator.equals(OperatorsConst.LESS)) return value2.compareTo(value1) < 0;
        if (operator.equals(OperatorsConst.GREATER_EQUALS)) return value2.compareTo(value1) >= 0;
        if (operator.equals(OperatorsConst.GREATER)) return value2.compareTo(value1) > 0;
        throw new Exception("Nieodpowiedni rodzaj operatora porównania.");
    }

    /**
     * Sprawdza, czy klasa zawiera zmienną o danej nazwie.
     *
     * @param variable
     * @return
     */
    protected boolean isCriteria(String variable) {
        String[] variables = new String[]{"employmentDate", "salary", "firstName", "lastName", "dateOfBirth"};
        Set<String> set = new HashSet<String>(Arrays.asList(variables));
        return set.contains(variable);
    }

    /**
     * Sprawdza czy kryterium o danej nazwie jest spełnione. W przypadku braku znalezionej wartości zwracana jest prawda.
     *
     * @param variable
     * @param criteria
     * @param operator
     * @return
     * @throws Exception
     */
    protected boolean checkCriteria(String variable, Object criteria, Byte operator) throws Exception {

        switch (variable) {
            case "employmentDate":
                return checkEmploymentDate(criteria, operator);
            case "salary":
                return checkSalary(criteria, operator);
            case "firstName":
                return checkFirstName(criteria, operator);
            case "lastName":
                return checkLastName(criteria, operator);
            case "dateOfBirth":
                return checkDateOfBirth(criteria, operator);
            default:
                return true;
        }
    }

    /**
     * Sprawdza czy data urodzin jest spełniona.
     *
     * @param criteria
     * @param operator
     * @return
     * @throws Exception
     */
    private boolean checkDateOfBirth(Object criteria, Byte operator) throws Exception {
        if (criteria instanceof Date) return compareDates((Date) criteria, getDateOfBirth(), operator);
        throw new Exception("Nieodpowiedni rodzaj wartości do sprawdzenia.");
    }

    /**
     * Porównuje dwa ciągi znaków według zadanego kryterium, lub zwraca błąd jeśli operator jest nieprawidłowy.
     *
     * @param str1
     * @param str2
     * @param operator
     * @return
     * @throws Exception
     */
    static boolean compareStrings(String str1, String str2, Byte operator) throws Exception {
        if (operator.equals(OperatorsConst.EQUALS)) return str1 == str2;
        if (operator.equals(OperatorsConst.ILIKE)) return str2.indexOf(str1) >= 0;
        throw new Exception("Nieodpowiedni operator porównania dla operacji porównywania łańcuchów znaków.");
    }


    /**
     * Sprawdza czy nazwisko spełnia kryterium.
     *
     * @param criteria
     * @param operator
     * @return
     * @throws Exception
     */
    private boolean checkLastName(Object criteria, Byte operator) throws Exception {
        if (criteria instanceof String) return compareStrings((String) criteria, getLastName(), operator);

        throw new Exception("Nieodpowiedni rodzaj wartości do sprawdzenia.");
    }

    /**
     * Sprawdza czy imię spełnia kryterium.
     *
     * @param criteria
     * @param operator
     * @return
     * @throws Exception
     */
    private boolean checkFirstName(Object criteria, Byte operator) throws Exception {
        if (criteria instanceof String) return compareStrings((String) criteria, getFirstName(), operator);
        throw new Exception("Nieodpowiedni rodzaj wartości do sprawdzenia.");
    }

    /**
     * Sprawdza czy operator jest operatorem porównywania stringów.
     *
     * @param operator
     * @return
     */
    private boolean isStringOperator(Byte operator) {
        return operator == OperatorsConst.EQUALS || operator == OperatorsConst.ILIKE;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder(super.toString());
        sb.append("employmentDate=").append(employmentDate.toString()).append("\n");
        sb.append("sallary=").append(salary.toString()).append("\n");
        return sb.toString();
    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal sallaryFrom, BigDecimal sallaryTo) {
        return super.matches(firstName, lastName, birthFrom, birthTo)
                && matchesEmployment(employmentFrom, employmentTo)
                && matchesSalary(sallaryFrom, sallaryTo);
    }

    protected boolean matches(String firstName, String lastName, Date birthFrom, Date birthTo, Date employmentFrom, Date employmentTo, BigDecimal sallaryFrom, BigDecimal sallaryTo, boolean strict) {
        return super.matches(firstName, lastName, birthFrom, birthTo, strict)
                && matchesEmployment(employmentFrom, employmentTo)
                && matchesSalary(sallaryFrom, sallaryTo);
    }

    private boolean matchesEmployment(Date employmentFrom, Date employmentTo) {
        if (employmentFrom != null) {
            if (this.employmentDate != null) {
                return (this.employmentDate.after(employmentFrom) || this.employmentDate.equals(employmentFrom));
            }
            else
                return false;
        }
        if (employmentTo != null) {
            if (this.employmentDate != null) {
                return (this.employmentDate.before(employmentTo) || this.employmentDate.equals(employmentTo));
            }
            else
                return false;
        }

        return true;
    }

    private boolean matchesSalary(BigDecimal salaryFrom, BigDecimal salaryTo) {
        if (salaryFrom != null) {
            if (this.salary != null) {
                return (this.salary.compareTo(salaryFrom) <= 0);
            }
            else
                return false;
        }
        if (salaryTo != null) {
            if (this.salary != null) {
                return (this.salary.compareTo(salaryTo) >= 0);
            }
            else
                return false;
        }

        return true;
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
}