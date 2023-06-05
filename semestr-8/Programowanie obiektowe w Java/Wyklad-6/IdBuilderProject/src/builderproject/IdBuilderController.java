package builderproject;

import javax.swing.*;
import java.awt.*;

public class IdBuilderController {

    IdBuilder model;
    IdBuilderView view;

    public IdBuilderController(IdBuilder model, IdBuilderView view) {

        this.model = model;
        this.view = view;

        // java 6
        view.addIdButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        addId();
                    }
                }
        );
        view.removeIdButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        removeId();
                    }
                }
        );
        view.clearIdsButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        clearIds();
                    }
                }
        );
        view.buildIdsButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        buildIds();
                    }
                }
        );
        view.setSeparatorButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        setSeparator();
                    }
                }
        );
        view.resetSeparatorButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        resetSeparator();
                    }
                }
        );
        
        view.resetEmptyStringButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        resetEmptyString();
                    }
                }
        );
       
        view.setEmptyStringButton.addActionListener(
                new java.awt.event.ActionListener() {
                    public void actionPerformed(java.awt.event.ActionEvent e) {
                        setEmptyString();
                    }
                }
        );
        
    }

    public void setEmptyString(){
        String emptyString = view.emptyStringTextField.getText();
        this.model.setEmptyString(emptyString);
    }
    
    public void resetEmptyString(){
        String emptyString = this.model.resetEmptyString();
        view.emptyStringTextField.setText(emptyString);
    }
    
    public void setSeparator() {
        String separator = view.separatorTextField.getText();
        if (separator.isEmpty()) return;
        this.model.setDelimeter(separator);
    }

    public void resetSeparator() {
        String separator = ", ";
        this.model.setDelimeter(separator);
        view.separatorTextField.setText(separator);
    }

    public long getId() {
        try {
            String idText = view.idTextField.getText();
            if(idText.isEmpty()) return 0;
            return Long.parseLong(idText);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(view, "Id musi być liczbą całkowitą.", "Błąd", JOptionPane.ERROR_MESSAGE);
            return 0;
        }
    }

    public void resetIdTextField() {
        view.idTextField.setText("");
    }

    public void resetResultTextArea() {
        view.resultTextArea.setText("");
    }

    public void addId() {
        long id = getId();
        if (id == 0) return;
        this.model.append(getId());
        resetIdTextField();
    }

    public void removeId() {
        long id = getId();
        if (id == 0) return;
        this.model.remove(getId());
        resetIdTextField();
    }

    public void clearIds() {
        this.model.clear();
        resetIdTextField();
        resetResultTextArea();
    }

    public void buildIds() {
        String ids = this.model.build();
        view.resultTextArea.setText(ids);
        resetIdTextField();
        this.model.clear();
    }

    public void centerView() {
        Rectangle bounds = view.getGraphicsConfiguration().getBounds();
        Dimension dimension = bounds.getSize();
        int x = (int) (((dimension.getWidth() - view.getWidth()) / 2) + bounds.getMinX());
        int y = (int) (((dimension.getHeight() - view.getHeight()) / 2) + bounds.getMinY());
        view.setLocation(x, y);
    }

    public void showView() {
        view.setVisible(true);
    }

}
