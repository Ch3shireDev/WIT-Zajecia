package mvc;

import mvc.model.TemperatureModel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

/**
 *
 * @author piotrkowalski
 */
public class FarenheitGUI extends TemperatureGUI {

    public FarenheitGUI(TemperatureModel model, int h, int v) {
        super("Farenheit Temperature", model, h, v);
        setDisplay("" + model.getF());
        addUpListener(new UpListener());
        addDownListener(new DownListener());
        addDisplayListener(new DisplayListener());
    }

    @Override
    public void update(Observable t, Object o) // Called from the Model
    {
        setDisplay("" + model().getF());
    }

    class UpListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            model().setF(model().getF() + 1.0);
        }
    }

    class DownListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            model().setF(model().getF() - 1.0);
        }
    }

    class DisplayListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            double value = getDisplay();
            model().setF(value);
        }
    }
}
