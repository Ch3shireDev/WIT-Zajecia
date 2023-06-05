
import java.awt.Color;
import javax.swing.BoxLayout;
import javax.swing.JCheckBox;

public class FabriTestForm extends javax.swing.JFrame
{
   public FabriTestForm()
   {
      initComponents();
      cbColors.removeAllItems();
      pnCheckboxes.setLayout(new BoxLayout(pnCheckboxes,BoxLayout.Y_AXIS));
      for(String name:ColorFactory.getKeys())
      {
         cbColors.addItem(name);
         JCheckBox chb=new JCheckBox();
         chb.setText(name);
         pnCheckboxes.add(chb);
      }
      cbColors.setSelectedIndex(0);
      tfFly.setText(new Fly("Bzzz").toString());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      cbColors = new javax.swing.JComboBox<>();
      pnShowColor = new javax.swing.JPanel();
      pnCheckboxes = new javax.swing.JPanel();
      tfFly = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      cbColors.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Colors" }));
      cbColors.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            cbColorsActionPerformed(evt);
         }
      });
      cbColors.addPropertyChangeListener(new java.beans.PropertyChangeListener()
      {
         public void propertyChange(java.beans.PropertyChangeEvent evt)
         {
            cbColorsPropertyChange(evt);
         }
      });

      pnShowColor.setBackground(new java.awt.Color(255, 255, 255));

      javax.swing.GroupLayout pnShowColorLayout = new javax.swing.GroupLayout(pnShowColor);
      pnShowColor.setLayout(pnShowColorLayout);
      pnShowColorLayout.setHorizontalGroup(
         pnShowColorLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );
      pnShowColorLayout.setVerticalGroup(
         pnShowColorLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout pnCheckboxesLayout = new javax.swing.GroupLayout(pnCheckboxes);
      pnCheckboxes.setLayout(pnCheckboxesLayout);
      pnCheckboxesLayout.setHorizontalGroup(
         pnCheckboxesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );
      pnCheckboxesLayout.setVerticalGroup(
         pnCheckboxesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(cbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(pnShowColor, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 180, Short.MAX_VALUE)
                  .addComponent(pnCheckboxes, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(tfFly, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(pnCheckboxes, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(pnShowColor, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 132, Short.MAX_VALUE)
            .addComponent(tfFly, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void cbColorsActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_cbColorsActionPerformed
   {//GEN-HEADEREND:event_cbColorsActionPerformed
      Object name=cbColors.getSelectedItem();
      if(name==null) return;
      Color clr=ColorFactory.make(name.toString());
      pnShowColor.setBackground(clr);

      //pnShowColor.setBackground(ColorFactory.make(cbColors.getSelectedItem().toString()));
   }//GEN-LAST:event_cbColorsActionPerformed

   private void cbColorsPropertyChange(java.beans.PropertyChangeEvent evt)//GEN-FIRST:event_cbColorsPropertyChange
   {//GEN-HEADEREND:event_cbColorsPropertyChange
   }//GEN-LAST:event_cbColorsPropertyChange

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(()->new FabriTestForm().setVisible(true));
      /*
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new FabriTestForm().setVisible(true);
         }
      });
      */
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JComboBox<String> cbColors;
   private javax.swing.JPanel pnCheckboxes;
   private javax.swing.JPanel pnShowColor;
   private javax.swing.JTextField tfFly;
   // End of variables declaration//GEN-END:variables
}
