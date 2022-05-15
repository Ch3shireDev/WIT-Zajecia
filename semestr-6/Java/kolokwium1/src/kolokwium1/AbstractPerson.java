package kolokwium1;

/**
 * Klasa abstrakcyjna przechowująca
 * podstawowe dane osobowe
 * @author Lukasz
 *
 */
public abstract class AbstractPerson {


	/**
	 * Imię osoby.
	 */
	protected String firstName=null;

	/**
	 * Nazwisko osoby.
	 */
	protected String lastName=null;

	/**
	 * Konstruktor osoby.
	 */
	public AbstractPerson(String firstName,String lastName) {
		this.firstName = firstName;
		this.lastName = lastName;
	}
	
	///////////////////////////////////////
	// getters and setters
	///////////////////////////////////////


	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
}
