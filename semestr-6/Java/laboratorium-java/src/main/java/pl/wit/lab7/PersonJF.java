package pl.wit.lab7;

import net.miginfocom.layout.AC;
import net.miginfocom.layout.LC;
import net.miginfocom.swing.MigLayout;
import org.apache.commons.lang3.math.NumberUtils;
import org.junit.platform.commons.util.StringUtils;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;

/**
 * Klasa okna.
 */
public class PersonJF extends JFrame {

    /**
     * Szerokość okna.
     */
    int width = 600;
    /**
     * Wysokość okna.
     */
    int height = 400;
    /**
     * Pole imienia.
     */
    JTextField firstNameField;
    /**
     * Pole nazwiska.
     */
    JTextField lastNameField;
    /**
     * Pole wieku.
     */
    JTextField ageField;
    /**
     * Pole płci.
     */
    ButtonGroup sexField;
    /**
     * Pole opisu.
     */
    JTextArea descriptionField;

    /**
     * Konstruktor klasy.
     */
    public PersonJF() {
        setLayout(getMigLayout());
        firstNameField = addFirstNameField();
        lastNameField = addLastNameField();
        ageField = addAgeField();
        sexField = addSexField();
        descriptionField = addDescriptionField();
        addSaveButton();
        setWindowParameters();
    }

    /**
     * Funkcja główna.
     *
     * @param args Argumenty funkcji.
     */
    public static void main(String[] args) {
        PersonJF frame = new PersonJF();
        frame.setVisible(true);
    }

    /**
     * @return Imię.
     */
    String getFirstName() {
        return firstNameField.getText();
    }

    /**
     * @return Nazwisko.
     */
    String getLastName() {
        return lastNameField.getText();
    }

    /**
     * @return Łańcuch znaków wieku.
     */
    String getAgeStr() {
        return ageField.getText();
    }

    /**
     * @return Płeć.
     */
    String getSex() {
        var buttons = sexField.getElements();
        var femaleButton = buttons.nextElement();
        if (femaleButton.isSelected()) return "Kobieta";
        var maleButton = buttons.nextElement();
        if (maleButton.isSelected()) return "Mężczyzna";
        return "";
    }

    /**
     * @return Opis.
     */
    String getDescription() {
        return descriptionField.getText();
    }

    /**
     * Metoda ustawia parametry okna.
     */
    private void setWindowParameters() {
        setSize(width, height);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    /**
     * Metoda dodaje przycisk zapisu.
     */
    private void addSaveButton() {
        var saveButton = new Button("Zapisz");
        add(saveButton, "newline, skip 1, width ::100");
        saveButton.addActionListener(this::validateAndSave);
    }

    /**
     * Walidacja i zapis danych.
     *
     * @param actionEvent Zdarzenie.
     */
    private void validateAndSave(ActionEvent actionEvent) {
        try {
            var firstName = getFirstNameValidated();
            var lastName = getLastNameValidated();
            var age = getAgeValidated();
            var sex = getSexValidated();
            var description = getDescriptionValidated();

            save(firstName, lastName, age, sex, description);
        }
        catch (Exception e) {
            JOptionPane.showMessageDialog(this, e.getMessage(), "Warning", JOptionPane.WARNING_MESSAGE);
        }
    }

    /**
     * Operacja zapisu danych. Dane są zapisywane na ekran konsoli.
     *
     * @param firstName   Imię.
     * @param lastName    Nazwisko.
     * @param age         Wiek.
     * @param sex         Płeć.
     * @param description Opis.
     */
    private void save(String firstName, String lastName, Integer age, String sex, String description) {

        System.out.printf("imię: %s\n", firstName);
        System.out.printf("nazwisko: %s\n", lastName);
        System.out.printf("wiek: %d\n", age);
        System.out.printf("płeć: %s\n", sex);
        System.out.printf("opis: %s\n", description);

    }

    /**
     * Walidacja opisu.
     *
     * @return Opis, jeśli nie jest pusty.
     * @throws Exception Wyjątek w przypadku pustego opisu.
     */
    private String getDescriptionValidated() throws Exception {
        var description = getDescription();
        if (StringUtils.isBlank(description)) throw new Exception("Opis musi być uzupełniony.");
        return description;
    }

    /**
     * Walidacja płci.
     *
     * @return Płeć, jeśli została podana.
     * @throws Exception Wyjątek w przypadku braku podanej płci.
     */
    private String getSexValidated() throws Exception {
        var sex = getSex();
        if (StringUtils.isBlank(sex)) throw new Exception("Płeć musi być podana.");
        return sex;
    }

    /**
     * Walidacja wieku.
     *
     * @return Wiek, jeśli został podany jako nieujemna liczba.
     * @throws Exception Wyjątek w przypadku niepoprawnie podanego wieku.
     */
    private Integer getAgeValidated() throws Exception {
        var ageStr = getAgeStr();
        if (!NumberUtils.isCreatable(ageStr)) throw new Exception("Wiek musi być poprawną liczbą.");
        var age = Integer.parseInt(ageStr);
        if (age < 0) throw new Exception("Wiek musi być liczbą nieujemną.");
        return age;
    }

    /**
     * Walidacja nazwiska.
     *
     * @return Nazwisko, jeśli zostało podane.
     * @throws Exception Wyjątek w przypadku braku nazwiska.
     */
    private String getLastNameValidated() throws Exception {
        var lastName = getLastName();
        if (StringUtils.isBlank(lastName)) throw new Exception("Nazwisko nie zostało uzupełnione.");
        return lastName;
    }

    /**
     * Walidacja imienia.
     *
     * @return Imię, jeśli zostało podane.
     * @throws Exception Wyjątek w przypadku braku imienia.
     */
    private String getFirstNameValidated() throws Exception {
        var firstName = getFirstName();
        if (StringUtils.isBlank(firstName)) throw new Exception("Imię nie zostało uzupełnione.");
        return firstName;
    }

    /**
     * Dodaje pole opisu do formatki.
     *
     * @return Wskaźnik na pole opisu.
     */
    private JTextArea addDescriptionField() {
        var descriptionField = new JTextArea();
        add(new JLabel("Opis"), "push 100, newline");
        add(descriptionField, "push 100, grow 100 100, span");
        return descriptionField;
    }

    /**
     * Dodaje pole płci do formatki.
     *
     * @return Wskaźnik na grupę pola płci.
     */
    private ButtonGroup addSexField() {
        add(new JLabel("Płeć"), "cell 0 4, newline");

        var group = new ButtonGroup();
        var femaleButton = new JRadioButton("Kobieta");
        var maleButton = new JRadioButton("Mężczyzna");
        group.add(femaleButton);
        group.add(maleButton);

        add(femaleButton, "width ::80, cell 1 4");
        add(maleButton, "cell 1 4");

        return group;
    }

    /**
     * Dodaje pole wieku do formatki.
     *
     * @return Wskaźnik na pole wieku.
     */
    private JTextField addAgeField() {
        var ageField = new JTextField();
        add(new JLabel("Wiek"), "newline");
        add(ageField, "span, grow");
        return ageField;
    }

    /**
     * Dodaje pole nazwiska do formatki.
     *
     * @return Wskaźnik na pole nazwiska.
     */
    private JTextField addLastNameField() {
        var lastNameField = new JTextField();
        add(new JLabel("Nazwisko"), "newline");
        add(lastNameField, "span, grow");
        return lastNameField;
    }

    /**
     * Dodaje pole imienia do formatki.
     *
     * @return Wskaźnik na pole imienia.
     */
    private JTextField addFirstNameField() {
        add(new JLabel("Imię"));
        var firstNameField = new JTextField();
        add(firstNameField, "width ::150");
        return firstNameField;
    }

    /**
     * Zwraca wskaźnik na obiekt Layout.
     *
     * @return Wskaźnik na obiekt Layout.
     */
    private MigLayout getMigLayout() {
        return new MigLayout(
                new LC().fillX(),
                new AC().align("right").gap("rel").grow().fill(),
                new AC().gap("10")
        );
    }

}
