import java.awt.SystemColor;
import javax.swing.DefaultComboBoxModel;

public class CalcutorMain extends javax.swing.JFrame {

    private DoubleFieldManager managerA;
    private DoubleFieldManager managerB;
    private DefaultComboBoxModel<String> cbm=new DefaultComboBoxModel<String>();

    public CalcutorMain() {
        initComponents();

        managerA = new DoubleFieldManager(16, TfValueA, this::AdjustButton);
        managerB = new DoubleFieldManager(2, TfValueB, this::AdjustButton);

        //CbOperation.removeAllItems();

        for (String key: OperationFactory.keys) {
           cbm.addElement(key);
        }
        CbOperation.setModel(cbm);
        //CbOperation.setSelectedIndex(0);
    }

    private void AdjustButton() {
        BtnCalculate.setEnabled(
                (TfValueA.getBackground() == SystemColor.window)
                &&
                (TfValueB.getBackground() == SystemColor.window)
        );
    }

    @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      TfValueA = new javax.swing.JTextField();
      TfResult = new javax.swing.JTextField();
      BtnCalculate = new javax.swing.JButton();
      TfValueB = new javax.swing.JTextField();
      CbOperation = new javax.swing.JComboBox<>();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      TfValueA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TfValueA.setText("16");

      TfResult.setEditable(false);
      TfResult.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TfResult.setText("0");

      BtnCalculate.setText("Calc");
      BtnCalculate.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnCalculateActionPerformed(evt);
         }
      });

      TfValueB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TfValueB.setText("2");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(20, 20, 20)
            .addComponent(TfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(CbOperation, 0, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(TfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 103, Short.MAX_VALUE)
            .addComponent(BtnCalculate)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(TfResult, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(20, 20, 20)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(TfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(TfResult, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnCalculate)
               .addComponent(TfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(64, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnCalculateActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnCalculateActionPerformed
   {//GEN-HEADEREND:event_BtnCalculateActionPerformed
       String operation = CbOperation.getSelectedItem().toString();
       double a = managerA.getInput();
       double b = managerB.getInput();
       double result = OperationFactory.Calculate(a, operation, b);
       TfResult.setText(Double.toString(result));
   }//GEN-LAST:event_BtnCalculateActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new CalcutorMain().setVisible(true);
            }
        });
    }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalculate;
   private javax.swing.JComboBox<String> CbOperation;
   private javax.swing.JTextField TfResult;
   private javax.swing.JTextField TfValueA;
   private javax.swing.JTextField TfValueB;
   // End of variables declaration//GEN-END:variables
}
