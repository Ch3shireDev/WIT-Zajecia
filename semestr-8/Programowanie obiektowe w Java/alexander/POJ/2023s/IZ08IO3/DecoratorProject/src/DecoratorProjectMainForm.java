public class DecoratorProjectMainForm extends javax.swing.JFrame
{
    public DecoratorProjectMainForm()
    {
        initComponents();
        cbModels.removeAllItems();
        for(String model:CarFactory.models) cbModels.addItem(model);
        cbModels.setSelectedIndex(0);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents()
    {

        cbModels = new javax.swing.JComboBox<>();
        pnDecorators = new javax.swing.JPanel();
        cb = new javax.swing.JCheckBox();
        btnAdd = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        cbModels.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "models" }));

        cb.setText("decorator");

        javax.swing.GroupLayout pnDecoratorsLayout = new javax.swing.GroupLayout(pnDecorators);
        pnDecorators.setLayout(pnDecoratorsLayout);
        pnDecoratorsLayout.setHorizontalGroup(
            pnDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnDecoratorsLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(cb)
                .addContainerGap(71, Short.MAX_VALUE))
        );
        pnDecoratorsLayout.setVerticalGroup(
            pnDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnDecoratorsLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(cb)
                .addContainerGap(168, Short.MAX_VALUE))
        );

        btnAdd.setText("Add");
        btnAdd.addActionListener(new java.awt.event.ActionListener()
        {
            public void actionPerformed(java.awt.event.ActionEvent evt)
            {
                btnAddActionPerformed(evt);
            }
        });

        TaResults.setColumns(20);
        TaResults.setRows(5);
        jScrollPane1.setViewportView(TaResults);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pnDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(cbModels, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(btnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 505, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(cbModels, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(pnDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnAdd)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnAddActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnAddActionPerformed
    {//GEN-HEADEREND:event_btnAddActionPerformed
        String model=cbModels.getSelectedItem().toString();
        Car car=CarFactory.make(model);
        
        String str=String.format("%13d: %s",car.price(),car.info());
        TaResults.append(str+System.lineSeparator());
    }//GEN-LAST:event_btnAddActionPerformed

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new DecoratorProjectMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextArea TaResults;
    private javax.swing.JButton btnAdd;
    private javax.swing.JCheckBox cb;
    private javax.swing.JComboBox<String> cbModels;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JPanel pnDecorators;
    // End of variables declaration//GEN-END:variables
}
