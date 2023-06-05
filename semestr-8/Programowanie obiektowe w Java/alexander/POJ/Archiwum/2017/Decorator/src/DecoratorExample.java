
import java.util.ArrayList;
import javax.swing.BoxLayout;
import javax.swing.DefaultListModel;
import javax.swing.JCheckBox;

public class DecoratorExample extends javax.swing.JFrame {

   private final DefaultListModel<String> model=new DefaultListModel<String>();
   private final ArrayList<JCheckBox> checkBoxes=new ArrayList<JCheckBox>();

   public DecoratorExample() {
      initComponents();
      for(String name:CarList.names()) Kind.addItem(name);
      final BoxLayout layout=new BoxLayout(CheckBoxPanel, BoxLayout.Y_AXIS);
      CheckBoxPanel.setLayout(layout);
      for(String name:DecoratorList.names()) 
      {
         JCheckBox box=new JCheckBox();
         box.setText(name);
         checkBoxes.add(box);
         CheckBoxPanel.add(box);
      }
      PriceList.setModel(model);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      PriceListScroller = new javax.swing.JScrollPane();
      PriceList = new javax.swing.JList<>();
      Kind = new javax.swing.JComboBox<>();
      BtnDelete = new javax.swing.JButton();
      BtnModify = new javax.swing.JButton();
      BtnAdd = new javax.swing.JButton();
      CheckBoxPanel = new javax.swing.JPanel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      PriceListScroller.setViewportView(PriceList);

      BtnDelete.setText("Delete");
      BtnDelete.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnDeleteActionPerformed(evt);
         }
      });

      BtnModify.setText("Modify");
      BtnModify.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnModifyActionPerformed(evt);
         }
      });

      BtnAdd.setText("Add");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout CheckBoxPanelLayout = new javax.swing.GroupLayout(CheckBoxPanel);
      CheckBoxPanel.setLayout(CheckBoxPanelLayout);
      CheckBoxPanelLayout.setHorizontalGroup(
         CheckBoxPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );
      CheckBoxPanelLayout.setVerticalGroup(
         CheckBoxPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 209, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(PriceListScroller, javax.swing.GroupLayout.DEFAULT_SIZE, 385, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(BtnDelete, javax.swing.GroupLayout.Alignment.TRAILING)
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addComponent(BtnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnModify))
               .addComponent(Kind, javax.swing.GroupLayout.Alignment.TRAILING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(CheckBoxPanel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(Kind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CheckBoxPanel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnModify)
                     .addComponent(BtnAdd))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnDelete))
               .addComponent(PriceListScroller, javax.swing.GroupLayout.DEFAULT_SIZE, 293, Short.MAX_VALUE))
            .addContainerGap())
      );

      BtnDelete.getAccessibleContext().setAccessibleName("BtnDelete");
      BtnModify.getAccessibleContext().setAccessibleName("BtnModify");
      BtnAdd.getAccessibleContext().setAccessibleName("BtnAdd");

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private BaseCar make()
   {
      BaseCar car=CarList.makeByName(Kind.getSelectedItem().toString());
      for(JCheckBox box : checkBoxes)
      {
         if(box.isSelected())
         {
            car=DecoratorList.makeByName(box.getText(), car);
         }
      }
      return car;
   }
   
   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      model.addElement(make().toString());
   }//GEN-LAST:event_BtnAddActionPerformed

   private void BtnModifyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnModifyActionPerformed
      model.setElementAt(make().toString(), PriceList.getSelectedIndex());
   }//GEN-LAST:event_BtnModifyActionPerformed

   private void BtnDeleteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDeleteActionPerformed
      // TODO add your handling code here:
      model.remove(PriceList.getSelectedIndex());
   }//GEN-LAST:event_BtnDeleteActionPerformed

   /**
    * @param args the command line arguments
    */
   public static void main(String args[]) {
      /* Set the Nimbus look and feel */
      //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
      /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
       */
      try {
         for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
            if ("Nimbus".equals(info.getName())) {
               javax.swing.UIManager.setLookAndFeel(info.getClassName());
               break;
            }
         }
      } catch (ClassNotFoundException ex) {
         java.util.logging.Logger.getLogger(DecoratorExample.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(DecoratorExample.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(DecoratorExample.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(DecoratorExample.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new DecoratorExample().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnDelete;
   private javax.swing.JButton BtnModify;
   private javax.swing.JPanel CheckBoxPanel;
   private javax.swing.JComboBox<String> Kind;
   private javax.swing.JList<String> PriceList;
   private javax.swing.JScrollPane PriceListScroller;
   // End of variables declaration//GEN-END:variables
}
