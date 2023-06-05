
import com.sun.xml.internal.txw2.Document;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class BuilderTest extends javax.swing.JFrame 
{
   private final IdBuilder ib=new IdBuilder();
   private long value=0;
   public BuilderTest() 
   {
      initComponents();
      final DocumentListener dl=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { ValueChanged(); }
         @Override public void removeUpdate(DocumentEvent e) { ValueChanged(); }
         @Override public void changedUpdate(DocumentEvent e) { ValueChanged(); }
      };
      IdValue.getDocument().addDocumentListener(dl);
      getRootPane().setDefaultButton(BtnAdd);
      ValueFocus();
   }
   
   private void ValueChanged()
   {
      boolean enabled=false;
      try
      {
         value=Long.parseLong(IdValue.getText());
         enabled=true;
      }
      catch(NumberFormatException e)
      {
      }
      BtnAdd.setEnabled(enabled);
   }
   
   private void ValueFocus()
   {
      IdValue.requestFocus();
      IdValue.selectAll();
   }
   
   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      LogScroll = new javax.swing.JScrollPane();
      Log = new javax.swing.JTextArea();
      IdValue = new javax.swing.JTextField();
      BtnAdd = new javax.swing.JButton();
      BtnClear = new javax.swing.JButton();
      BtnBuild = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      Log.setEditable(false);
      Log.setColumns(20);
      Log.setRows(5);
      LogScroll.setViewportView(Log);

      IdValue.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      IdValue.setText("0");

      BtnAdd.setText("Dodaj");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      BtnClear.setText("Czyść");
      BtnClear.setToolTipText("");
      BtnClear.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnClearActionPerformed(evt);
         }
      });

      BtnBuild.setText("Buduj");
      BtnBuild.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnBuildActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 566, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(BtnAdd, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(BtnClear, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(BtnBuild, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(IdValue, javax.swing.GroupLayout.Alignment.TRAILING))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(LogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(IdValue, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnClear)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnBuild)
                  .addGap(0, 252, Short.MAX_VALUE)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      ib.add(value);
      ValueFocus();
   }//GEN-LAST:event_BtnAddActionPerformed

   private void BtnClearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnClearActionPerformed
      ib.clear();
      ValueFocus();
   }//GEN-LAST:event_BtnClearActionPerformed

   private void BtnBuildActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnBuildActionPerformed
      Log.append(ib.toString()+System.lineSeparator());
      ValueFocus();
   }//GEN-LAST:event_BtnBuildActionPerformed
   
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
         java.util.logging.Logger.getLogger(BuilderTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(BuilderTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(BuilderTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(BuilderTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new BuilderTest().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnBuild;
   private javax.swing.JButton BtnClear;
   private javax.swing.JTextField IdValue;
   private javax.swing.JTextArea Log;
   private javax.swing.JScrollPane LogScroll;
   // End of variables declaration//GEN-END:variables
}
