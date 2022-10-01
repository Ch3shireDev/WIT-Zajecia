package kolokwium1;

/**
 * Grupa WIT, dziedzicząca z klasy abstrakcyjnej AbstractGroup.
 * @author Igor Nowicki
 *
 */
public class WITGroup extends AbstractGroup{
    public WITGroup(String groupCode) {
        super(groupCode);
    }

    @Override
    public String getGroupCode() {
        return groupCode;
    }

    @Override
    public String toString() {
        return groupCode;
    }
}
