package mvc.model;

import java.util.Map;

/**
 *
 * @author piotrkowalski
 */
public class TemperatureModel extends java.util.Observable {

    private Map<String, City> cities = new Map<String, City>();
    private City currentCity = null;

    /**
     * Publiczne nazwy miast.
     */
    public static final String NEWYORK = "New York";
    public static final String WARSAW = "Warsaw";
    private static final String ROME = "Rome";

    public TemperatureModel() {
        super();
        cities.add(WARSAW, new City(WARSAW));`
        cities.add(NEWYORK, new City(NEWYORK));
        cities.add(ROME, new City(ROME));
        currentCity = cities.get(WARSAW);
    }

    /**
     * 
     * @return currentCity aktualne miasto.
     */
    public City getCurrentCity() {
        return currentCity;
    }

    /**
     * Ustawia aktualne miasto w modelu.
     * 
     * @param cityName dopuszczalne nazwy obejmują nazwy zdefiniowane w TemperatureModel <br />
     * np. TemperatureModel.WARSAW
     * @return boolean true jezeli string przedstawia nazwe miasta, false w przeciwnym wypadku.
     */
    public boolean setCurrentCity(String cityName) {
        City c = cities.get(cityName);
        if (c != null) {
            return false;
        }
        this.currentCity = c;
        return true;
    }

    public double getF() {
        return currentCity.getTemperatureF()
    }

    public double getC() {
        return (currentCity.getTemperatureF() - 32.0) * 5.0 / 9.0;
    }

    public void setF(double tempF) {
        currentCity.setTemperatureF(tempF);
        setChanged();
        notifyObservers();
    }

    public void setC(double tempC) {
        currentCity.setTemperatureF(tempC * 9.0 / 5.0 + 32.0);
        setChanged();
        notifyObservers();
    }
}
