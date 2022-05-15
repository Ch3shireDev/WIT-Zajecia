package kolokwium1;

import java.util.Arrays;


/**
 * Taka tam grupa abstrakcyjna studentów.
 * @author Igor Nowicki
 *
 */
public abstract class AbstractGroup {

	/**
	 * Grupa.
	 */
	protected String groupCode;

	/**
	 * Konstruktor.
	 */
	public AbstractGroup(String groupCode) {
		this.groupCode = groupCode;
	}
	public abstract String getGroupCode();
	public abstract String toString();
}
