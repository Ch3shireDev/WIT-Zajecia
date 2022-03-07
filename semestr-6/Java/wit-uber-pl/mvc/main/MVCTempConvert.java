package mvc.main;

import mvc.CelsiusGUI;
import mvc.CitySelectorGUI;
import mvc.FarenheitGUI;
import mvc.GraphGUI;
import mvc.SliderGUI;
import mvc.model.TemperatureModel;

/**
 *
 * @author piotrkowalski
 */
public class MVCTempConvert {

    public static void main(String args[]) {
        TemperatureModel temperature = new TemperatureModel();
        new FarenheitGUI(temperature, 100, 100);
        new CelsiusGUI(temperature, 100, 250);
        //new CelsiusGUI(temperature,100, 400);
        new GraphGUI(temperature, 400, 200);
        new SliderGUI(temperature, 400, 100);
        new CitySelectorGUI(temperature, 700, 100);
    }
}
