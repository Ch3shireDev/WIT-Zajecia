
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class CommandTest extends javax.swing.JFrame {

   private final DefaultListModel<NamedCommand> CommandListModel=new DefaultListModel<>();
   private final DefaultListModel<NamedCommand> TrainingListModel=new DefaultListModel<>();
   public CommandTest() 
   {
      initComponents();
      CommandListModel.addElement(new NamedCommand(new Run(), "run"));
      CommandListModel.addElement(new NamedCommand(new Jump(), "jump"));      
      CommandListModel.addElement(new NamedCommand(new Swim(), "swim"));      
      CommandList.setModel(CommandListModel);
      TrainingList.setModel(TrainingListModel);
      RunStrategy.setModel(new DefaultComboBoxModel<>(RunStrategyList.names()));
      JumpStrategy.setModel(new DefaultComboBoxModel<>(JumpStrategyList.names()));
      SwimStrategy.setModel(new DefaultComboBoxModel<>(SwimStrategyList.names()));
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      TrainingListButtons = new javax.swing.ButtonGroup();
      CommandListScroll = new javax.swing.JScrollPane();
      CommandList = new javax.swing.JList<>();
      TrainingListScroll = new javax.swing.JScrollPane();
      TrainingList = new javax.swing.JList<>();
      BtnAddItem = new javax.swing.JButton();
      BtnRemoveItem = new javax.swing.JButton();
      BtnExecute = new javax.swing.JButton();
      EdTrainingName = new javax.swing.JTextField();
      BtnMakeNewItem = new javax.swing.JButton();
      LogScroll = new javax.swing.JScrollPane();
      Log = new javax.swing.JTextArea();
      RunStrategy = new javax.swing.JComboBox<>();
      JumpStrategy = new javax.swing.JComboBox<>();
      SwimStrategy = new javax.swing.JComboBox<>();
      SportsmanName = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Command + Strategy test ...");

      CommandList.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
      CommandList.setSelectedIndex(0);
      CommandListScroll.setViewportView(CommandList);

      TrainingList.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
      TrainingListScroll.setViewportView(TrainingList);

      BtnAddItem.setText("Dodaj >>");
      BtnAddItem.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddItemActionPerformed(evt);
         }
      });

      BtnRemoveItem.setLabel("Usun");
      BtnRemoveItem.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnRemoveItemActionPerformed(evt);
         }
      });

      BtnExecute.setText("Wykonaj");
      BtnExecute.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnExecuteActionPerformed(evt);
         }
      });

      EdTrainingName.setText("Trening");

      BtnMakeNewItem.setText("<< Nowy");
      BtnMakeNewItem.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMakeNewItemActionPerformed(evt);
         }
      });

      Log.setEditable(false);
      Log.setColumns(20);
      Log.setRows(5);
      LogScroll.setViewportView(Log);

      SportsmanName.setText("Kowalski");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(CommandListScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 145, Short.MAX_VALUE)
               .addComponent(SportsmanName)
               .addComponent(RunStrategy, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(JumpStrategy, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(SwimStrategy, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnMakeNewItem)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdTrainingName))
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(BtnAddItem))
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(BtnExecute)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 222, Short.MAX_VALUE)
                        .addComponent(BtnRemoveItem, javax.swing.GroupLayout.PREFERRED_SIZE, 59, javax.swing.GroupLayout.PREFERRED_SIZE)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(TrainingListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 145, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addComponent(LogScroll))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(TrainingListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 147, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 147, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnAddItem)
                  .addGap(35, 35, 35)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(EdTrainingName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(BtnMakeNewItem))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnExecute)
                     .addComponent(BtnRemoveItem))))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(LogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(RunStrategy, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(JumpStrategy, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(SwimStrategy, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(SportsmanName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 198, Short.MAX_VALUE)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnExecuteActionPerformed
      final Sportsman s=new Sportsman
      (
         SportsmanName.getText(),
         RunStrategyList.byName((String)RunStrategy.getSelectedItem()),
         JumpStrategyList.byName((String)JumpStrategy.getSelectedItem()),
         SwimStrategyList.byName((String)SwimStrategy.getSelectedItem())
      );
      Log.append(CommandList.getSelectedValue().getCmd().Execute(s)+"\n");
   }//GEN-LAST:event_BtnExecuteActionPerformed

   private void BtnAddItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddItemActionPerformed
      TrainingListModel.addElement(CommandList.getSelectedValue());
   }//GEN-LAST:event_BtnAddItemActionPerformed

   private void BtnRemoveItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveItemActionPerformed
      TrainingListModel.removeElement(TrainingList.getSelectedValue());
   }//GEN-LAST:event_BtnRemoveItemActionPerformed

   private void BtnMakeNewItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMakeNewItemActionPerformed
      final ArrayList<Command> lst=new ArrayList<>();
      for(int i=0;i<TrainingListModel.getSize();++i)
      {
         lst.add(TrainingListModel.get(i).getCmd());
      }
      final Command[] tbl=new Command[lst.size()];
      final Trening cmd=new Trening(lst.toArray(tbl));
      CommandListModel.addElement(new NamedCommand(cmd, EdTrainingName.getText()));
   }//GEN-LAST:event_BtnMakeNewItemActionPerformed

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
         java.util.logging.Logger.getLogger(CommandTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(CommandTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(CommandTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(CommandTest.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new CommandTest().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddItem;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JButton BtnMakeNewItem;
   private javax.swing.JButton BtnRemoveItem;
   private javax.swing.JList<NamedCommand> CommandList;
   private javax.swing.JScrollPane CommandListScroll;
   private javax.swing.JTextField EdTrainingName;
   private javax.swing.JComboBox<Object> JumpStrategy;
   private javax.swing.JTextArea Log;
   private javax.swing.JScrollPane LogScroll;
   private javax.swing.JComboBox<Object> RunStrategy;
   private javax.swing.JTextField SportsmanName;
   private javax.swing.JComboBox<Object> SwimStrategy;
   private javax.swing.JList<NamedCommand> TrainingList;
   private javax.swing.ButtonGroup TrainingListButtons;
   private javax.swing.JScrollPane TrainingListScroll;
   // End of variables declaration//GEN-END:variables
}
