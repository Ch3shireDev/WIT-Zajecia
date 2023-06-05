import javafx.scene.control.CheckBox;
import javax.swing.JCheckBox;

public class DecoratorMainForm extends javax.swing.JFrame
{
    public DecoratorMainForm()
    {
        initComponents();
        CbModels.removeAllItems();
        for(String model:CarFactory.models) CbModels.addItem(model);
        CbModels.setSelectedIndex(0);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents()
    {

        CbModels = new javax.swing.JComboBox<>();
        PblDecorators = new javax.swing.JPanel();
        cb = new javax.swing.JCheckBox();
        BtnAdd = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        CbModels.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Models" }));

        cb.setText("Opony zimowe");

        javax.swing.GroupLayout PblDecoratorsLayout = new javax.swing.GroupLayout(PblDecorators);
        PblDecorators.setLayout(PblDecoratorsLayout);
        PblDecoratorsLayout.setHorizontalGroup(
            PblDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(PblDecoratorsLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(cb, javax.swing.GroupLayout.DEFAULT_SIZE, 152, Short.MAX_VALUE)
                .addContainerGap())
        );
        PblDecoratorsLayout.setVerticalGroup(
            PblDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(PblDecoratorsLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(cb)
                .addContainerGap(180, Short.MAX_VALUE))
        );

        BtnAdd.setText("Dodaj");
        BtnAdd.addActionListener(new java.awt.event.ActionListener()
        {
            public void actionPerformed(java.awt.event.ActionEvent evt)
            {
                BtnAddActionPerformed(evt);
            }
        });

        TaResults.setColumns(20);
        TaResults.setFont(new java.awt.Font("Courier New", 0, 12)); // NOI18N
        TaResults.setRows(5);
        jScrollPane1.setViewportView(TaResults);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addComponent(CbModels, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(PblDecorators, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(BtnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 590, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbModels, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(PblDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnAdd)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnAddActionPerformed
    {//GEN-HEADEREND:event_BtnAddActionPerformed
        String model=CbModels.getSelectedItem().toString();
        Car car=CarFactory.make(model);        
        for(JCheckBox c:new JCheckBox[] {cb})
        {
            if(c.isSelected())
            {
                car=new WinterTire(car);
            }
        }
        
        
        String message=String.format("%12s: %s",car.price(),car.info());
        TaResults.append(message+System.lineSeparator());
    }//GEN-LAST:event_BtnAddActionPerformed

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(()-> new DecoratorMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<String> CbModels;
    private javax.swing.JPanel PblDecorators;
    private javax.swing.JTextArea TaResults;
    private javax.swing.JCheckBox cb;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}
