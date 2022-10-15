package pl.wit.lab3.p2;

import java.math.BigDecimal;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;

/**
 * Klasa pochodna przetwarzające dane Pracownika na stanowisku sekretarka
 * @author Łukasz
 *
 */
public class Secretary2 extends Employee2 {
	//Zbiór znanych języków obcych
	private Set<String> setLanguages = null;
	
	public Secretary2(String firstName, String lastName, Date dateOfBirth, Date employmentDate, BigDecimal sallary) {
		super(firstName, lastName, dateOfBirth, employmentDate,sallary);
		this.setLanguages = new HashSet<String>();
	}
	
	/**
	 * Metoda dodająca kolejny język
	 * @param language
	 */
	public void addLanguage(String language) {
		setLanguages.add(language);
	}
	/**
	 * Metoda zwracająca posortowaną tablice języków obcych
	 * @return
	 */
	public Set<String> getLanguages() {
		return setLanguages;
	}

	public String toString(){
		StringBuilder sb = new StringBuilder();
		sb.append(super.toString());
		sb.append(", znane języki: ");
		sb.append(String.join(", ", getLanguages()));
		return sb.toString();
	}
}
