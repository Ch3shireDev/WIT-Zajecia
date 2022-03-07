package mvc;

import mvc.model.TemperatureModel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Observable;

/**
 *
 * @author piotrkowalski
 */
public class CelsiusGUI extends TemperatureGUI {

    public CelsiusGUI(TemperatureModel model, int h, int v) {
        super("Celsius Temperature", model, h, v);
        setDisplay("" + model.getC());
        addUpListener(new UpListener());
        addDownListener(new DownListener());
        addDisplayListener(new DisplayListener());
    }

    @Override
    public void update(Observable t, Object o) // Called from the Model
    {
        setDisplay("" + model().getC());
    }

    class UpListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            model().setC(model().getC() + 1.0);
        }
    }

    class DownListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            model().setC(model().getC() - 1.0);
        }
    }

    class DisplayListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            double value = getDisplay();
            model().setC(value);
        }
    }
}
