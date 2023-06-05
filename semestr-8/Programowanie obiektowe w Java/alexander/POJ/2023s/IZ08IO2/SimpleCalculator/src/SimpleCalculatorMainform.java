public class SimpleCalculatorMainform extends javax.swing.JFrame
{
    public SimpleCalculatorMainform()
    {
        initComponents();
        CbOperation.removeAllItems();
        for(String op: OperationFactory.keys) CbOperation.addItem(op);
        CbOperation.setSelectedIndex(0);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        TfOperandA = new javax.swing.JTextField();
        CbOperation = new javax.swing.JComboBox<>();
        TfOperandB = new javax.swing.JTextField();
        BtnCalculate = new javax.swing.JButton();
        TaResultsScroll = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        TfOperandA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        TfOperandA.setText("0");

        CbOperation.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "opr" }));

        TfOperandB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        TfOperandB.setText("0");

        BtnCalculate.setText("Oblicz");
        BtnCalculate.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnCalculateActionPerformed(evt);
            }
        });

        TaResults.setColumns(20);
        TaResults.setRows(5);
        TaResultsScroll.setViewportView(TaResults);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaResultsScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(TfOperandA, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TfOperandB, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 208, Short.MAX_VALUE)
                        .addComponent(BtnCalculate)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(TfOperandA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(TfOperandB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnCalculate))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 426, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnCalculateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnCalculateActionPerformed
        double a=Double.parseDouble(TfOperandA.getText());
        double b=Double.parseDouble(TfOperandB.getText());
        String op=CbOperation.getSelectedItem().toString();
        double result=OperationFactory.calculate(a, op, b);
        TaResults.append(String.format("%.3f %s %.3f = %.3f",a,op,b,result)+System.lineSeparator());
    }//GEN-LAST:event_BtnCalculateActionPerformed

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new SimpleCalculatorMainform().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnCalculate;
    private javax.swing.JComboBox<String> CbOperation;
    private javax.swing.JTextArea TaResults;
    private javax.swing.JScrollPane TaResultsScroll;
    private javax.swing.JTextField TfOperandA;
    private javax.swing.JTextField TfOperandB;
    // End of variables declaration//GEN-END:variables
}
