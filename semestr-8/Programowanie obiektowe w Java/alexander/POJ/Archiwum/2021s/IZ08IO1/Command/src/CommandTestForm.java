
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;
import javax.swing.JList;

public class CommandTestForm extends javax.swing.JFrame {

   private DefaultListModel<SportsmenCommand> modelCommands=new DefaultListModel<>();
   private DefaultListModel<SportsmenCommand> modelTrening=new DefaultListModel<>();
   private DefaultComboBoxModel<String> modelRun=new DefaultComboBoxModel<>();
   public CommandTestForm()
   {
      initComponents();
      lbCommands.setModel(modelCommands);
      lbTrening.setModel(modelTrening);
      cbStrategyRun.setModel(modelRun);
      modelCommands.addElement(new SportsmenCommandRun());
      modelCommands.addElement(new SportsmenCommandJump());
      modelCommands.addElement(new SportsmenCommandSwim());
      for(String kind: StrategyRunFactory.keys()) modelRun.addElement(kind);
      lbCommands.setSelectedIndex(0);
      AdjustButtons();
   }

   private boolean isUniqueName(String treningName)
   {
      return true;
   }

   private void AdjustButtons()
   {
      String treningName=txtTreningName.getText().trim();//geTtreningName();
      //SportsmenCommand cmd=(SportsmenCommand)lbCommands.getSelectedValue();//getSelectedCommand();

      boolean treningNameNotEmpty=(treningName.length()>0);
      boolean treningListNotEmpty=(modelTrening.size()>0);
      boolean treningNameUnique=isUniqueName(treningName);

      btnAppendTreningToCommands.setEnabled(treningNameNotEmpty && treningListNotEmpty && treningNameUnique);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jScrollPane1 = new javax.swing.JScrollPane();
      lbTrening = new JList<SportsmenCommand>();
      jScrollPane2 = new javax.swing.JScrollPane();
      lbCommands = new JList<SportsmenCommand>();
      txtSportsmenName = new javax.swing.JTextField();
      btnExecute = new javax.swing.JButton();
      jScrollPane3 = new javax.swing.JScrollPane();
      txtLog = new javax.swing.JTextArea();
      btnAppendToTrening = new javax.swing.JButton();
      txtTreningName = new javax.swing.JTextField();
      btnAppendTreningToCommands = new javax.swing.JButton();
      btnRemoveFromCommands = new javax.swing.JButton();
      btnRemoveFromTrening = new javax.swing.JButton();
      spCount = new javax.swing.JSpinner();
      btnAppendMultiplyToCommands = new javax.swing.JButton();
      cbStrategyRun = new javax.swing.JComboBox();
      jComboBox2 = new javax.swing.JComboBox();
      jComboBox3 = new javax.swing.JComboBox();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      jScrollPane1.setViewportView(lbTrening);

      lbCommands.setName(""); // NOI18N
      lbCommands.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
         public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
            lbCommandsValueChanged(evt);
         }
      });
      jScrollPane2.setViewportView(lbCommands);

      txtSportsmenName.setText("Kowalski Jan");

      btnExecute.setText("Execute");
      btnExecute.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnExecuteActionPerformed(evt);
         }
      });

      txtLog.setColumns(20);
      txtLog.setRows(5);
      jScrollPane3.setViewportView(txtLog);

      btnAppendToTrening.setText("=>");
      btnAppendToTrening.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnAppendToTreningActionPerformed(evt);
         }
      });

      txtTreningName.setText("JRS");

      btnAppendTreningToCommands.setText("<=");

      btnRemoveFromCommands.setText("X");

      btnRemoveFromTrening.setText("X");

      btnAppendMultiplyToCommands.setText("<=");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane3)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(jComboBox2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(jComboBox3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(txtSportsmenName)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnExecute))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(btnAppendToTrening)
                        .addGap(0, 0, Short.MAX_VALUE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(btnRemoveFromCommands)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 284, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                              .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                 .addComponent(btnAppendTreningToCommands, javax.swing.GroupLayout.Alignment.TRAILING)
                                 .addComponent(btnAppendMultiplyToCommands, javax.swing.GroupLayout.Alignment.TRAILING))
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                 .addComponent(txtTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, 160, javax.swing.GroupLayout.PREFERRED_SIZE)
                                 .addComponent(spCount, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)))
                           .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                              .addComponent(btnRemoveFromTrening)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)))))
                  .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                  .addGroup(layout.createSequentialGroup()
                     .addComponent(btnAppendToTrening)
                     .addGap(4, 4, 4)
                     .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(txtTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(btnAppendTreningToCommands))
                     .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                     .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(spCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(btnAppendMultiplyToCommands)))
                  .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(btnRemoveFromTrening)
                     .addComponent(btnRemoveFromCommands))
                  .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 173, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 173, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                  .addComponent(cbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addComponent(jComboBox2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addComponent(jComboBox3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addComponent(txtSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addComponent(btnExecute))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 215, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnAppendToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAppendToTreningActionPerformed
      SportsmenCommand cmd=(SportsmenCommand)lbCommands.getSelectedValue();
      modelTrening.addElement(cmd);
      lbTrening.setSelectedIndex(modelTrening.size()-1);
      AdjustButtons();
   }//GEN-LAST:event_btnAppendToTreningActionPerformed

   private void btnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnExecuteActionPerformed
      String SportsmenName=txtSportsmenName.getText().trim();
      SportsmenStrategyRun run=StrategyRunFactory.make(cbStrategyRun.getSelectedItem().toString());
      Sportsmen sportsmen=new Sportsmen(SportsmenName,run);
      SportsmenCommand cmd=(SportsmenCommand)lbCommands.getSelectedValue();
      txtLog.append(sportsmen.execute(cmd)+System.lineSeparator());
      AdjustButtons();
   }//GEN-LAST:event_btnExecuteActionPerformed

   private void lbCommandsValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_lbCommandsValueChanged
      AdjustButtons();
   }//GEN-LAST:event_lbCommandsValueChanged

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
         java.util.logging.Logger.getLogger(CommandTestForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(CommandTestForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(CommandTestForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(CommandTestForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
        //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new CommandTestForm().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAppendMultiplyToCommands;
   private javax.swing.JButton btnAppendToTrening;
   private javax.swing.JButton btnAppendTreningToCommands;
   private javax.swing.JButton btnExecute;
   private javax.swing.JButton btnRemoveFromCommands;
   private javax.swing.JButton btnRemoveFromTrening;
   private javax.swing.JComboBox cbStrategyRun;
   private javax.swing.JComboBox jComboBox2;
   private javax.swing.JComboBox jComboBox3;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JScrollPane jScrollPane3;
   private javax.swing.JList lbCommands;
   private javax.swing.JList lbTrening;
   private javax.swing.JSpinner spCount;
   private javax.swing.JTextArea txtLog;
   private javax.swing.JTextField txtSportsmenName;
   private javax.swing.JTextField txtTreningName;
   // End of variables declaration//GEN-END:variables

}
