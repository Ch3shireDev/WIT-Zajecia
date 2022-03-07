package mvc;

import mvc.model.TemperatureModel;
import java.awt.Canvas;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.Panel;
import java.util.Observable;
import java.util.Observer;

/**
 *
 * @author piotrkowalski
 */
public class GraphGUI extends Frame implements Observer {

    public GraphGUI(TemperatureModel model, int h, int v) {
        super("Temperature Gauge");
        this.model = model;
        _farenheit = new TemperatureGauge(-200, 300);
        Panel Top = new Panel();
        add("North", Top);
        gauges = new TemperatureCanvas(_farenheit);
        gauges.setSize(500, 280);
        add("Center", gauges);
        setSize(280, 320);
        setLocation(h, v);
        setVisible(true);
        model.addObserver(this); // Connect to the model
    }

    @Override
    public void update(Observable obs, Object o) // Respond to changes
    {
        repaint();
    }

    @Override
    public void paint(Graphics g) {
        int farenheit = (int) model.getF(); // Use the current data to paint
        _farenheit.set(farenheit);
        gauges.repaint();
        super.paint(g);
    }
    private TemperatureModel model;
    private Canvas gauges;
    private TemperatureGauge _farenheit;
}
