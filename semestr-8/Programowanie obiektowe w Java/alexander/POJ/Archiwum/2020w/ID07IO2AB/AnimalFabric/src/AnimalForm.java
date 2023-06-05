
import javax.swing.DefaultComboBoxModel;

public class AnimalForm extends javax.swing.JFrame
{
   private final DefaultComboBoxModel<String> model=new DefaultComboBoxModel();
   public AnimalForm()
   {
      initComponents();
      //CbKind.removeAllItems();
      //for(String kind:AnimalFactory.keys()) CbKind.addItem(kind);
      for(String kind:AnimalFactory.keys()) model.addElement(kind);
      CbKind.setModel(model);
      CbKind.setSelectedIndex(0);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CbKind = new javax.swing.JComboBox();
      EdName = new javax.swing.JTextField();
      BtnMake = new javax.swing.JButton();
      EdLogAreaScroll = new javax.swing.JScrollPane();
      EdLogArea = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      CbKind.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Kinds" }));

      EdName.setText("Name");

      BtnMake.setText("Make");
      BtnMake.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMakeActionPerformed(evt);
         }
      });

      EdLogArea.setColumns(20);
      EdLogArea.setRows(5);
      EdLogAreaScroll.setViewportView(EdLogArea);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogAreaScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMake)
                  .addGap(0, 137, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnMake))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogAreaScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMakeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMakeActionPerformed
      String kind=CbKind.getSelectedItem().toString();
      Animal animal=AnimalFactory.make(kind,EdName.getText());
      EdLogArea.append(animal.toString()+System.lineSeparator());
   }//GEN-LAST:event_BtnMakeActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new AnimalForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnMake;
   private javax.swing.JComboBox CbKind;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JScrollPane EdLogAreaScroll;
   private javax.swing.JTextField EdName;
   // End of variables declaration//GEN-END:variables
}
