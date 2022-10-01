package kolokwium1;

import java.util.LinkedHashSet;
import java.util.Set;

/**
 * Baza danych studentów.
 * @author Igor Nowicki
 *
 */
public class StudentsDatabase {

	/**
	 *  Zbiór studentów.
	 */
	private Set<Student> setStudents = null;


	/**
	 * Konstruktor bazy danych studentów.
	 */
	public StudentsDatabase() {
		setStudents = new LinkedHashSet<Student>();
	}


	/**
	 * Operator dodania nowego studenta.
	 */
	public void addStudent(Student st) throws StudentException{
		if(st==null)throw  new StudentException("Wartość student nie może być null");
		if(setStudents==null)new StudentException("Brak zdefiniowanego zbioru setStudents");
		setStudents.add(st);
	}

	/**
	 * Wyszukiwarka studentów.
	 */
	public Set<Student> searchStudents(String name, String lastName, String groupCode, Integer atLeastPoints){
		Set<Student> setResults = new LinkedHashSet<Student>();

		for(Student student: setStudents){

			// TODO: Uzupełnić wyszukiwarkę.
//			if(name!=null && student.n)


		}


		return setResults;
	}

	public Set<Student> getSetStudents() {
		return setStudents;
	}
}
