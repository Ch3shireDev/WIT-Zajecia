import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MainWindow extends JFrame {
    private JPanel panel;
    private JTextField firstValue;
    private JComboBox<String> operation;
    private JTextField secondValue;
    private JButton calculate;
    private JTextArea Result;

    public MainWindow() {

        operation.addItem("dodaj");
        operation.addItem("odejmij");
        operation.addItem("mnóż");
        operation.addItem("dziel");
        // Set up the frame
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setTitle("Simple Calculator");
        setSize(800, 600);
        setLocationRelativeTo(null);
        setContentPane(panel);
        setVisible(true);
        calculate.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calculateCommand(e);
            }
        });
    }

    public double GetValue(String value) {
        return Double.parseDouble(value);
    }

    public void calculateCommand(ActionEvent e) {
        var selectedOperation = operation.getSelectedItem();
        var leftValue = GetValue(firstValue.getText());
        var rightValue = GetValue(secondValue.getText());
        double result = 0;
        String op;
        if (selectedOperation == "dodaj") {
            result = leftValue + rightValue;
            op = "+";
        } else if (selectedOperation == "odejmij") {
            result = leftValue - rightValue;
            op = "-";
        } else if (selectedOperation == "mnóż") {
            result = leftValue * rightValue;
            op = "*";
        } else if (selectedOperation == "dziel") {
            result = leftValue / rightValue;
            op = "/";
        }
        else return;

        Result.setText(String.format("%f %s %f = %f",leftValue, op, rightValue, result));
    }
}
