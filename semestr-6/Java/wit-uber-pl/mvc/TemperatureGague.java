package mvc;

/**
 *
 * @author piotrkowalski
 */
class TemperatureGauge {

    public TemperatureGauge(int min, int max) {
        Min = min;
        Max = max;
    }

    public void set(int level) {
        current = level;
    }

    public int get() {
        return current;
    }

    public int getMax() {
        return Max;
    }

    public int getMin() {
        return Min;
    }
    private int Max, Min, current;
}
