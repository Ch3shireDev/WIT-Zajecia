package decoratortest;

import javax.swing.DefaultComboBoxModel;
import javax.swing.JCheckBox;

public class DecoratorForm extends javax.swing.JFrame
{
   private DefaultComboBoxModel<String> cbm=new DefaultComboBoxModel<>();
   public DecoratorForm()
   {
      initComponents();
      CbCarType.setModel(cbm);
      for(String name:CarFabric.Keys()) cbm.addElement(name);
      CheckBoxList cbl=CbList();
      for(String name:CarDecoratorFabric.Keys()) cbl.add(name);
   }

   private CheckBoxList CbList() { return (CheckBoxList)LbDecorations; }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      CbCarType = new javax.swing.JComboBox<>();
      EdResultScroll = new javax.swing.JScrollPane();
      EdResult = new javax.swing.JTextArea();
      BtnMake = new javax.swing.JButton();
      LbDecorationsScrol = new javax.swing.JScrollPane();
      LbDecorations = new CheckBoxList();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdResult.setEditable(false);
      EdResult.setColumns(20);
      EdResult.setRows(5);
      EdResultScroll.setViewportView(EdResult);

      BtnMake.setText("Dodaj");
      BtnMake.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnMakeActionPerformed(evt);
         }
      });

      LbDecorations.setName(""); // NOI18N
      LbDecorationsScrol.setViewportView(LbDecorations);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(LbDecorationsScrol)
               .addComponent(BtnMake, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(CbCarType, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdResultScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 169, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdResultScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 292, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbCarType, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LbDecorationsScrol)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMake)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMakeActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnMakeActionPerformed
   {//GEN-HEADEREND:event_BtnMakeActionPerformed
      Car car=CarFabric.Make(CbCarType.getSelectedItem().toString());
      CheckBoxList cbl=CbList();
      for(int i=0;i<cbl.getModel().getSize();++i)
      {
         final JCheckBox cb=cbl.item(i);
         if(cb.isSelected())
         {
            car=CarDecoratorFabric.Make(car,cb.getText());
         }
      }
      final String text=String.format("%s => %.0f",car.Info(),car.Price());
      EdResult.append(text+System.lineSeparator());
   }//GEN-LAST:event_BtnMakeActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() ->  new DecoratorForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnMake;
   private javax.swing.JComboBox<String> CbCarType;
   private javax.swing.JTextArea EdResult;
   private javax.swing.JScrollPane EdResultScroll;
   private javax.swing.JList<JCheckBox> LbDecorations;
   private javax.swing.JScrollPane LbDecorationsScrol;
   // End of variables declaration//GEN-END:variables
}
