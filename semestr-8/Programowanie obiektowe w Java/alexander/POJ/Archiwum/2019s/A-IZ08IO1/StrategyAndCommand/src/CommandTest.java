
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;
import javax.swing.SpinnerNumberModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class CommandTest extends javax.swing.JFrame
{
   private final DefaultListModel<SportsmanCommand> CommandModel=new DefaultListModel<>();
   private final DefaultListModel<SportsmanCommand> TreningModel=new DefaultListModel<>();
   private final SpinnerNumberModel SpinerModel=new SpinnerNumberModel(3,2,20,1);
   private final DefaultComboBoxModel<SportsmanStrategyRunClass> CbRunModel=new DefaultComboBoxModel<>();
   private final DefaultComboBoxModel<SportsmanStrategyJumpClass> CbJumpModel=new DefaultComboBoxModel<>();
   private final DefaultComboBoxModel<SportsmanStrategySwimClass> CbSwimModel=new DefaultComboBoxModel<>();

   public CommandTest()
   {
      initComponents();
      getRootPane().setDefaultButton(BtnExecute);
      LbCommand.setModel(CommandModel);
      LbTrening.setModel(TreningModel);
      EdCount.setModel(SpinerModel);
      CommandModel.addElement(new SportsmanRun());
      CommandModel.addElement(new SportsmanJump());
      CommandModel.addElement(new SportsmanSwim());
      LbCommand.setSelectedIndex(0);
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustButtons(); }
      };
      EdTreningName.getDocument().addDocumentListener(listener);
      EdSportsmanName.getDocument().addDocumentListener(listener);
      CbRunModel.addElement(new SportsmanStrategySprint());
      CbRunModel.addElement(new SportsmanStrategyJustRun());
      CbRunModel.addElement(new SportsmanStrategyMaraton());
      CbJumpModel.addElement(new SportsmanStrategyLong());
      CbJumpModel.addElement(new SportsmanStrategyJustJump());
      CbJumpModel.addElement(new SportsmanStrategyHigh());
      CbSwimModel.addElement(new SportsmanStrategyFrog());
      CbSwimModel.addElement(new SportsmanStrategyCrawl());
      CbSwimModel.addElement(new SportsmanStrategyButterfly());
      CbStrategyRun.setModel(CbRunModel);
      CbStrategyJump.setModel(CbJumpModel);
      CbStrategySwim.setModel(CbSwimModel);
      CbStrategyRun.setSelectedIndex(0);
      CbStrategyJump.setSelectedIndex(0);
      CbStrategySwim.setSelectedIndex(0);
      adjustButtons();
   }

   public String getTreningName() { return EdTreningName.getText().trim(); }
   public String getSportsmanName() { return EdSportsmanName.getText().trim(); }

   public boolean uniqueName(String name)
   {
      for(int i=0;i<CommandModel.getSize();++i)
      {
         if(name.equals(CommandModel.getElementAt(i).toString())) return false;
      }
      return true;
   }

   public void adjustButtons()
   {
      String TreningName=getTreningName();
      boolean haveTreningName=(TreningName.length()>0);
      boolean haveSportsmanName=(getSportsmanName().length()>0);
      boolean selectedTrening=(LbCommand.getSelectedValue() instanceof SportsmanComposite);
      boolean notEmptyList=(!TreningModel.isEmpty());
      boolean isUniqueName=uniqueName(TreningName);
      BtnRemoveFromCommand.setEnabled(selectedTrening);
      BtnRemoveFromTrening.setEnabled(notEmptyList);
      BtnAddMacro.setEnabled(haveTreningName && isUniqueName && notEmptyList);
      BtnAddMultiply.setEnabled(haveTreningName && isUniqueName);
      BtnExecute.setEnabled(haveSportsmanName);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      LbCommandScroll = new javax.swing.JScrollPane();
      LbCommand = new javax.swing.JList<>();
      BtnAddToTrening = new javax.swing.JButton();
      BtnRemoveFromCommand = new javax.swing.JButton();
      BtnRemoveFromTrening = new javax.swing.JButton();
      BtnAddMacro = new javax.swing.JButton();
      EdTreningName = new javax.swing.JTextField();
      LbTreningScroll = new javax.swing.JScrollPane();
      LbTrening = new javax.swing.JList<>();
      EdSportsmanName = new javax.swing.JTextField();
      BtnExecute = new javax.swing.JButton();
      BtnAddMultiply = new javax.swing.JButton();
      EdCount = new javax.swing.JSpinner();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();
      CbStrategySwim = new javax.swing.JComboBox<>();
      CbStrategyJump = new javax.swing.JComboBox<>();
      CbStrategyRun = new javax.swing.JComboBox<>();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setMinimumSize(new java.awt.Dimension(615, 314));

      LbCommand.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
      LbCommand.addListSelectionListener(new javax.swing.event.ListSelectionListener()
      {
         public void valueChanged(javax.swing.event.ListSelectionEvent evt)
         {
            LbCommandValueChanged(evt);
         }
      });
      LbCommandScroll.setViewportView(LbCommand);

      BtnAddToTrening.setText(">>");
      BtnAddToTrening.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnAddToTreningActionPerformed(evt);
         }
      });

      BtnRemoveFromCommand.setText("-");
      BtnRemoveFromCommand.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnRemoveFromCommandActionPerformed(evt);
         }
      });

      BtnRemoveFromTrening.setText("-");
      BtnRemoveFromTrening.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnRemoveFromTreningActionPerformed(evt);
         }
      });

      BtnAddMacro.setText("<<");
      BtnAddMacro.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnAddMacroActionPerformed(evt);
         }
      });

      LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
      LbTreningScroll.setViewportView(LbTrening);

      BtnExecute.setText("Wykonaj");
      BtnExecute.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnExecuteActionPerformed(evt);
         }
      });

      BtnAddMultiply.setText("<<");
      BtnAddMultiply.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnAddMultiplyActionPerformed(evt);
         }
      });

      EdCount.setVerifyInputWhenFocusTarget(false);

      EdLog.setEditable(false);
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
               .addComponent(EdLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LbCommandScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(69, 69, 69)
                        .addComponent(BtnAddMultiply)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 105, Short.MAX_VALUE))
                     .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addGroup(layout.createSequentialGroup()
                              .addGap(69, 69, 69)
                              .addComponent(BtnAddMacro)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(EdTreningName))
                           .addComponent(BtnAddToTrening)
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(BtnRemoveFromCommand)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                              .addComponent(BtnRemoveFromTrening)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)))
                  .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 165, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addComponent(EdSportsmanName)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnExecute)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnAddToTrening)
                  .addGap(8, 8, 8)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnRemoveFromCommand)
                     .addComponent(BtnRemoveFromTrening))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(BtnAddMultiply))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnAddMacro)
                     .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
               .addComponent(LbTreningScroll)
               .addComponent(LbCommandScroll))
            .addGap(18, 18, 18)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdSportsmanName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnExecute)
               .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 115, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddToTreningActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnAddToTreningActionPerformed
   {//GEN-HEADEREND:event_BtnAddToTreningActionPerformed
      TreningModel.addElement(LbCommand.getSelectedValue());
      LbTrening.setSelectedIndex(TreningModel.getSize()-1);
      LbCommand.requestFocus();
      adjustButtons();
   }//GEN-LAST:event_BtnAddToTreningActionPerformed

   private void BtnRemoveFromCommandActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnRemoveFromCommandActionPerformed
   {//GEN-HEADEREND:event_BtnRemoveFromCommandActionPerformed
      int pos=LbCommand.getSelectedIndex();
      CommandModel.removeElementAt(pos);
      LbCommand.setSelectedIndex(Math.min(pos,CommandModel.getSize()-1));
      LbCommand.requestFocus();
      adjustButtons();
   }//GEN-LAST:event_BtnRemoveFromCommandActionPerformed

   private void BtnRemoveFromTreningActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnRemoveFromTreningActionPerformed
   {//GEN-HEADEREND:event_BtnRemoveFromTreningActionPerformed
      int pos=LbTrening.getSelectedIndex();
      TreningModel.removeElementAt(pos);
      LbTrening.setSelectedIndex(Math.min(pos,TreningModel.getSize()-1));
      LbTrening.requestFocus();
      adjustButtons();
   }//GEN-LAST:event_BtnRemoveFromTreningActionPerformed

   private void BtnAddMultiplyActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnAddMultiplyActionPerformed
   {//GEN-HEADEREND:event_BtnAddMultiplyActionPerformed
      int count=(int)EdCount.getValue();
      SportsmanCommand base=LbCommand.getSelectedValue();
      SportsmanCommand cmd=new SportsmanMultiply(getTreningName(),count,base);
      CommandModel.addElement(cmd);
      LbCommand.setSelectedIndex(CommandModel.getSize()-1);
      EdTreningName.selectAll();
      LbTrening.requestFocus();
      adjustButtons();
   }//GEN-LAST:event_BtnAddMultiplyActionPerformed

   private void BtnAddMacroActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnAddMacroActionPerformed
   {//GEN-HEADEREND:event_BtnAddMacroActionPerformed
      int count=TreningModel.getSize();
      SportsmanCommand[] list=new SportsmanCommand[count];
      for(int i=0;i<count;++i) list[i]=TreningModel.getElementAt(i);
      SportsmanCommand cmd=new SportsmanTrening(getTreningName(),list);
      CommandModel.addElement(cmd);
      LbCommand.setSelectedIndex(CommandModel.getSize()-1);
      TreningModel.clear();
      EdTreningName.selectAll();
      LbTrening.requestFocus();
      adjustButtons();
   }//GEN-LAST:event_BtnAddMacroActionPerformed

   private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnExecuteActionPerformed
   {//GEN-HEADEREND:event_BtnExecuteActionPerformed
      SportsmanStrategyRun run=(SportsmanStrategyRun)CbStrategyRun.getSelectedItem();
      SportsmanStrategyJump jump=(SportsmanStrategyJump)CbStrategyJump.getSelectedItem();
      SportsmanStrategySwim swim=(SportsmanStrategySwim)CbStrategySwim.getSelectedItem();
      Sportsman s=new Sportsman(getSportsmanName(),run,jump,swim);
      SportsmanCommand cmd=LbCommand.getSelectedValue();
      EdLog.append(s.execute(cmd)+System.lineSeparator());
      EdSportsmanName.selectAll();
      LbTrening.requestFocus();
      adjustButtons();
   }//GEN-LAST:event_BtnExecuteActionPerformed

   private void LbCommandValueChanged(javax.swing.event.ListSelectionEvent evt)//GEN-FIRST:event_LbCommandValueChanged
   {//GEN-HEADEREND:event_LbCommandValueChanged
      adjustButtons();
   }//GEN-LAST:event_LbCommandValueChanged

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new CommandTest().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddMacro;
   private javax.swing.JButton BtnAddMultiply;
   private javax.swing.JButton BtnAddToTrening;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JButton BtnRemoveFromCommand;
   private javax.swing.JButton BtnRemoveFromTrening;
   private javax.swing.JComboBox<SportsmanStrategyJumpClass> CbStrategyJump;
   private javax.swing.JComboBox<SportsmanStrategyRunClass> CbStrategyRun;
   private javax.swing.JComboBox<SportsmanStrategySwimClass> CbStrategySwim;
   private javax.swing.JSpinner EdCount;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   private javax.swing.JTextField EdSportsmanName;
   private javax.swing.JTextField EdTreningName;
   private javax.swing.JList<SportsmanCommand> LbCommand;
   private javax.swing.JScrollPane LbCommandScroll;
   private javax.swing.JList<SportsmanCommand> LbTrening;
   private javax.swing.JScrollPane LbTreningScroll;
   // End of variables declaration//GEN-END:variables
}
