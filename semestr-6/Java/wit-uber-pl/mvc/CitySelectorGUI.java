package mvc;

import java.awt.Choice;
import java.awt.Frame;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import java.util.Observable;
import java.util.Observer;
import mvc.model.TemperatureModel;

/**
 *
 * @author piotrkowalski
 */
public class CitySelectorGUI implements Observer, ItemListener{

    private TemperatureModel model = null;
    private Frame citySelectorFrame = new Frame("City Selector");
    private Choice cityChoice = new Choice();

    public CitySelectorGUI(TemperatureModel m, int h, int v) {
        this.model = m;
        cityChoice.add(TemperatureModel.NEWYORK);
        cityChoice.add(TemperatureModel.WARSAW);
        cityChoice.add(TemperatureModel.ROME);

        //cityChoice.select(model.getCurrentCity());

        cityChoice.addItemListener(this);

        citySelectorFrame.add(cityChoice);

        citySelectorFrame.setSize(250, 80);
        citySelectorFrame.setLocation(h, v);
        citySelectorFrame.setVisible(true);
        citySelectorFrame.addWindowListener(new TemperatureGUI.CloseListener());
        
        model.addObserver(this); //Observe the temperature model

    }

    @Override
    public void update(Observable o, Object arg) {
    }

    @Override
    public void itemStateChanged(ItemEvent e) {
        model.setCurrentCity(cityChoice.getSelectedItem());
    }
}

