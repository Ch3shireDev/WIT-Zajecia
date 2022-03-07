package mvc.model;

/**
 *
 * @author piotrkowalski
 */
public class City {

    private String cityName;
    private double temperatureF = 32;

    public City(String name) {
        this.cityName = name;
    }

    public String getCityName() {
        return cityName;
    }

    private double getTemperatureF() {
        return temperatureF;
    }

    public void setTemperatureF(double temperatureF) {
        this.temperatureF = temperatureF;
    }

}
