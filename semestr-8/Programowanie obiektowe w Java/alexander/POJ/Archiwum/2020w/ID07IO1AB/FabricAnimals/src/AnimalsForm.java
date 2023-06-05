
import javax.swing.DefaultComboBoxModel;

public class AnimalsForm extends javax.swing.JFrame
{
   private final DefaultComboBoxModel<String> model=new DefaultComboBoxModel<>();
   public AnimalsForm()
   {
      initComponents();
      CbAnimalKind.setModel(model);
      for(String kind:AnimalFabric.keys())
      {
         model.addElement(kind);
      }
      CbAnimalKind.setSelectedIndex(0);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CbAnimalKind = new javax.swing.JComboBox();
      EdName = new javax.swing.JTextField();
      BtnMake = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdName.setText("name");

      BtnMake.setText("Make");
      BtnMake.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMakeActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbAnimalKind, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMake)
                  .addContainerGap(107, Short.MAX_VALUE))
               .addComponent(EdLogScroll, javax.swing.GroupLayout.Alignment.TRAILING)))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbAnimalKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnMake))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMakeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMakeActionPerformed
      String kind=CbAnimalKind.getSelectedItem().toString();
      Animal animal=AnimalFabric.make(kind,EdName.getText());
      EdLog.append(animal.toString()+System.lineSeparator());
   }//GEN-LAST:event_BtnMakeActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new AnimalsForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnMake;
   private javax.swing.JComboBox CbAnimalKind;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   private javax.swing.JTextField EdName;
   // End of variables declaration//GEN-END:variables
}
