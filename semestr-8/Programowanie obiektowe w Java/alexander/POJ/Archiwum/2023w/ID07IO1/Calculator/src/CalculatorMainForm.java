
import java.awt.Color;
import javax.swing.DefaultComboBoxModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class CalculatorMainForm extends javax.swing.JFrame {

    private CheckerDouble checkA,checkB;
    private final DefaultComboBoxModel<OperationKind>  model=new DefaultComboBoxModel<>();
    public CalculatorMainForm()
    {
        initComponents();
        CbOperation.setModel(model);
        for(OperationKind kind:OperationFactory.keys)
        {
            model.addElement(kind);
        }
        checkA=new CheckerDouble(TfValueA,this::adjustControls);
        checkB=new CheckerDouble(TfValueB,this::adjustControls);
        //checkB=new CheckerDouble(TfValueB,() -> adjustControls());
        /*
        checkB=new CheckerDouble
        (
            TfValueB,
            new Runnable()
            {
                @Override public void run() { adjustControls(); }
            }
        );
        */
    }

    private void adjustControls()
    {
        BtnCalculate.setEnabled((checkA!=null)&&(checkB!=null)&&checkA.isOk()&&checkB.isOk());
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        TfValueA = new javax.swing.JTextField();
        CbOperation = new javax.swing.JComboBox<>();
        TfValueB = new javax.swing.JTextField();
        BtnCalculate = new javax.swing.JButton();
        TfResult = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        TfValueA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        TfValueA.setText("0");

        TfValueB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        TfValueB.setText("0");

        BtnCalculate.setText("Calc");
        BtnCalculate.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnCalculateActionPerformed(evt);
            }
        });

        TfResult.setEditable(false);
        TfResult.setHorizontalAlignment(javax.swing.JTextField.RIGHT);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(TfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, 92, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, 92, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TfResult, javax.swing.GroupLayout.PREFERRED_SIZE, 92, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(BtnCalculate))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(TfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(TfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(TfResult, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(BtnCalculate)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnCalculateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnCalculateActionPerformed
         OperationKind op=(OperationKind)CbOperation.getSelectedItem();
         double c=OperationFactory.calc(op,checkA.getValue(),checkB.getValue());
         TfResult.setText(String.format("%.3f",c));
/*
         String op=CbOperation.getSelectedItem().toString();
         double c=0;
         switch(op)
         {
             case "+": c=checkA.getValue()+checkB.getValue(); break;
             case "-": c=checkA.getValue()-checkB.getValue(); break;
             case "*": c=checkA.getValue()*checkB.getValue(); break;
             case "/": c=checkA.getValue()/checkB.getValue(); break;
         }
         //TfResult.setText(""+c);
         TfResult.setText(String.format("%.3f",c));
*/
    }//GEN-LAST:event_BtnCalculateActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new CalculatorMainForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnCalculate;
    private javax.swing.JComboBox<OperationKind> CbOperation;
    private javax.swing.JTextField TfResult;
    private javax.swing.JTextField TfValueA;
    private javax.swing.JTextField TfValueB;
    // End of variables declaration//GEN-END:variables
}
