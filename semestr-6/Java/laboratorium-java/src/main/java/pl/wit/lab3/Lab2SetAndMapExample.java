package pl.wit.lab3;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;

import java.util.*;

public class Lab2SetAndMapExample {

    protected static final Logger log =
            LogManager.getLogger(Lab2SetAndMapExample.class.getName());
    private Set<String> setCars = null;
    private Map<String, Integer> mapCarPower = null;

    public Lab2SetAndMapExample() {
        setCars = new HashSet<String>();
        mapCarPower = new HashMap<String, Integer>();
    }

    public Set<String> getSetCars() {
        return setCars;
    }

    public void setSetCars(Set<String> setCars) {
        this.setCars = setCars;
    }

    public Map<String, Integer> getMapCarPower() {
        return mapCarPower;
    }

    public void setMapCarPower(Map<String, Integer> mapCarPower) {
        this.mapCarPower = mapCarPower;
    }

    public void printSetToLog() {
        if (setCars == null) return;
        log.info(String.join(", ", this.setCars));
    }

    public void printMapToLog() {
        if (mapCarPower == null) return;
        List<String> carPowers = new ArrayList<String>();
        for (String car : mapCarPower.keySet()) {
            int power = mapCarPower.get(car);
            carPowers.add(String.format("%s: %d", car, power));
        }

        log.info(String.join(", ", carPowers));
    }

    public void addElement(String element) {
        if (setCars == null) return;
        setCars.add(element);
    }

    public void addElement(String key, int value) {
        if (mapCarPower == null) return;
        mapCarPower.put(key, value);
    }

    public int getMapValue(String key) {
        if (mapCarPower == null) return -1;
        if(!mapCarPower.containsKey(key))return -1;
        return mapCarPower.get(key);
    }

    public boolean isSetContains(String element) {
        if (setCars == null) return false;
        return setCars.contains(element);
    }
}
