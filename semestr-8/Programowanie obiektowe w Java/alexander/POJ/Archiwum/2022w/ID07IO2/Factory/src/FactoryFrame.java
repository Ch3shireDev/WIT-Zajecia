
import java.awt.Color;
import javax.swing.BoxLayout;
import javax.swing.JCheckBox;

public class FactoryFrame extends javax.swing.JFrame
{
   public FactoryFrame()
   {
      initComponents();
      pColors.setLayout(new BoxLayout(pColors,BoxLayout.Y_AXIS));
      cbColors.removeAllItems();
      for(String name:ColorFactory.getKeys())
      {
         JCheckBox cb=new JCheckBox();
         cb.setText(name);
         pColors.add(cb);
         cbColors.addItem(name);
      }
      cbColors.setSelectedIndex(0);
      lbCat.setText(new Cat("Pushek").toString());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      cbColors = new javax.swing.JComboBox<>();
      btnOk = new javax.swing.JButton();
      pOfColor = new javax.swing.JPanel();
      pColors = new javax.swing.JPanel();
      lbCat = new javax.swing.JLabel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      cbColors.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

      btnOk.setText("Ok");
      btnOk.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnOkActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout pOfColorLayout = new javax.swing.GroupLayout(pOfColor);
      pOfColor.setLayout(pOfColorLayout);
      pOfColorLayout.setHorizontalGroup(
         pOfColorLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );
      pOfColorLayout.setVerticalGroup(
         pOfColorLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout pColorsLayout = new javax.swing.GroupLayout(pColors);
      pColors.setLayout(pColorsLayout);
      pColorsLayout.setHorizontalGroup(
         pColorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 142, Short.MAX_VALUE)
      );
      pColorsLayout.setVerticalGroup(
         pColorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 249, Short.MAX_VALUE)
      );

      lbCat.setText("Cat");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnOk))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(pColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(0, 128, Short.MAX_VALUE)
                        .addComponent(pOfColor, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(lbCat)
                        .addGap(0, 0, Short.MAX_VALUE)))))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(cbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnOk))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(pOfColor, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(lbCat))
               .addComponent(pColors, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnOkActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnOkActionPerformed
   {//GEN-HEADEREND:event_btnOkActionPerformed
      String name=cbColors.getSelectedItem().toString();
      Color clr=ColorFactory.getValue(name,0);
      pOfColor.setBackground(clr);
      //pOfColor.setBackground(ColorFactory.getValue(cbColors.getSelectedItem().toString()));
   }//GEN-LAST:event_btnOkActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new FactoryFrame().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnOk;
   private javax.swing.JComboBox<String> cbColors;
   private javax.swing.JLabel lbCat;
   private javax.swing.JPanel pColors;
   private javax.swing.JPanel pOfColor;
   // End of variables declaration//GEN-END:variables
}
