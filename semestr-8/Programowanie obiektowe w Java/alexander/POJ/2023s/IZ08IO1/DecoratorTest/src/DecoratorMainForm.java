import java.util.ArrayList;
import java.util.List;
import javax.swing.BoxLayout;
import javax.swing.JCheckBox;

public class DecoratorMainForm extends javax.swing.JFrame
{
    private List<JCheckBox> CheckBoxes=new ArrayList<>();
    public DecoratorMainForm()
    {
        initComponents();
        CbModels.removeAllItems();
        for(String model:CarFactory.models) CbModels.addItem(model);
        CbModels.setSelectedIndex(0);
        PnlDecorators.setLayout(new BoxLayout(PnlDecorators,BoxLayout.Y_AXIS));
        for(String decorator:CarDecoratorFactory.decorators)
        {
            JCheckBox CbDecorator = new JCheckBox();
            CbDecorator.setText(decorator);
            PnlDecorators.add(CbDecorator);
            CheckBoxes.add(CbDecorator);
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents()
    {

        CbModels = new javax.swing.JComboBox<>();
        PnlDecorators = new javax.swing.JPanel();
        BtnAdd = new javax.swing.JButton();
        TaResultsScroll = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        CbModels.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Model" }));

        javax.swing.GroupLayout PnlDecoratorsLayout = new javax.swing.GroupLayout(PnlDecorators);
        PnlDecorators.setLayout(PnlDecoratorsLayout);
        PnlDecoratorsLayout.setHorizontalGroup(
            PnlDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 125, Short.MAX_VALUE)
        );
        PnlDecoratorsLayout.setVerticalGroup(
            PnlDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 223, Short.MAX_VALUE)
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
        TaResults.setRows(5);
        TaResultsScroll.setViewportView(TaResults);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(PnlDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(BtnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(CbModels, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 522, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaResultsScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbModels, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(PnlDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
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
        for(JCheckBox cb:CheckBoxes)
        {
            if(cb.isSelected())
            {
                //car=CarDecoratorFactory.make(cb.getText(),car);
            }
        }
        String text=String.format("%12d: %s",car.price(),car.info());
        TaResults.append(text+System.lineSeparator());
    }//GEN-LAST:event_BtnAddActionPerformed

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new DecoratorMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<String> CbModels;
    private javax.swing.JPanel PnlDecorators;
    private javax.swing.JTextArea TaResults;
    private javax.swing.JScrollPane TaResultsScroll;
    // End of variables declaration//GEN-END:variables
}
