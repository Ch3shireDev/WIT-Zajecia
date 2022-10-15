package pl.wit.lab4.p2;

import org.javatuples.Pair;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Map;


/**
 * Klasa bazy danych osób
 *
 * @author Łukasz
 */
public class DbPersons {
    private Person[] persons = null;

    public DbPersons() {
        this.persons = new Person[0];
    }


    /**
     * Dodaje nową osobę do bazy DbPersons.
     *
     * @param person
     */
    public void addPerson(Person person) {
        persons = Arrays.copyOf(persons, persons.length + 1);
        persons[persons.length - 1] = person;
    }

    /**
     * Wyszukuje z bazy danych wszystkie osoby które spełniają dany szereg warunków.
     *
     * @param conditions Mapa warunków. Sprawdzany jest argument o nazwie klucza czy spełnia porównanie z parą w postaci:
     *                   pierwszy argument - wartość, drugi argument - rodzaj porównania z OperatorsConst.
     *                   Jeśli obiekt nie posiada danego argumentu, to nie jest zawierany w wynikach.
     * @return
     * @throws Exception
     */
    public List<Person> search(Map<String, Pair<Object, Byte>> conditions) throws Exception {
        List<Person> output = new ArrayList<Person>();
        for (Person person : persons) {
            if (!person.search(conditions)) continue;
            output.add(person);
        }
        return output;
    }

}
