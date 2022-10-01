package kolokwium1;


import java.util.HashMap;
import java.util.Map;

/**
 * Klasa opisująca studenta.
 * @author Igor Nowicki
 *
 */
public class Student extends AbstractPerson {


	/**
	 * Grupa do której należy student.
	 */
	private AbstractGroup group = null;

	/**
	 * Numer indeksu studenta.
	 */
	private String indexNumber = null;


	/**
	 * Mapa punktów z przedmiotów.
	 */
	private Map<String,Byte> mapPoints = null;


	/**
	 * Konstruktor studenta.
	 */
	public Student(String firstName, String lastName) {
		super(firstName, lastName);
		mapPoints = new HashMap<String, Byte>();
	}
	/**
	 * Konstruktor studenta.
	 */

	public Student(String firstName, String lastName, AbstractGroup group, String indexNumber){
		super(firstName, lastName);
		mapPoints = new HashMap<String, Byte>();
		this.group = group;
		this.indexNumber = indexNumber;
	}

	public String getStudentData() {
		StringBuilder sb = new StringBuilder();
		sb.append(lastName);
		sb.append(", ");
		sb.append(firstName);
		sb.append(", ");
		sb.append(indexNumber);
		sb.append(", ");
		if(group!=null)sb.append(group.groupCode);
		else sb.append("-brak-");
		sb.append(", ");
		//sb.append(group.)
		return sb.toString();
	}

}
