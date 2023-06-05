public class SimpleCalcMainForm extends javax.swing.JFrame
{
    public SimpleCalcMainForm()
    {
        initComponents();
        CbOperation.removeAllItems();
        for(String op:OperationFactory.keys) CbOperation.addItem(op);
        CbOperation.setSelectedIndex(0);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        TaValueA = new javax.swing.JTextField();
        TaValueB = new javax.swing.JTextField();
        CbOperation = new javax.swing.JComboBox<>();
        TaResultsScroll = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();
        BtnExecute = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        TaValueA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        TaValueA.setText("0");

        TaValueB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        TaValueB.setText("0");

        CbOperation.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "operation" }));

        TaResults.setColumns(20);
        TaResults.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
        TaResults.setRows(5);
        TaResultsScroll.setViewportView(TaResults);

        BtnExecute.setText("Oblicz");
        BtnExecute.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnExecuteActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaResultsScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(TaValueA, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TaValueB, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 127, Short.MAX_VALUE)
                        .addComponent(BtnExecute)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(TaValueA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(TaValueB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbOperation, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnExecute))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 222, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnExecuteActionPerformed
        String op=CbOperation.getSelectedItem().toString();
        double a=Double.parseDouble(TaValueA.getText());
        double b=Double.parseDouble(TaValueB.getText());
        double result=OperationFactory.calculate(a,b,op);
        TaResults.append(String.format("%.3f %s %.3f = %.3f",a,op,b,result));
    }//GEN-LAST:event_BtnExecuteActionPerformed

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new SimpleCalcMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnExecute;
    private javax.swing.JComboBox<String> CbOperation;
    private javax.swing.JTextArea TaResults;
    private javax.swing.JScrollPane TaResultsScroll;
    private javax.swing.JTextField TaValueA;
    private javax.swing.JTextField TaValueB;
    // End of variables declaration//GEN-END:variables
}
