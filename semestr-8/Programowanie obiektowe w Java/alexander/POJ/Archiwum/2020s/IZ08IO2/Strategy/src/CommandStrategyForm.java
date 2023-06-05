
import java.util.ArrayList;
import javax.swing.DefaultListModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class CommandStrategyForm extends javax.swing.JFrame 
{
    private final DefaultListModel<Command> commandmodel=new DefaultListModel<>();
    private final DefaultListModel<Command> treningmodel=new DefaultListModel<>();
    public CommandStrategyForm()
    {
        initComponents();
        LbCommands.setModel(commandmodel);
        commandmodel.addElement(new CommandJump());
        commandmodel.addElement(new CommandRun());
        commandmodel.addElement(new CommandSwim());
        LbCommands.setSelectedIndex(0);
        LbTrening.setModel(treningmodel);
        for(String item:StrategyRunFabric.Keys()) CbRun.addItem(item);
        for(String item:StrategyJumpFabric.Keys()) CbJump.addItem(item);
        for(String item:StrategySwimFabric.Keys()) CbSwim.addItem(item);
        final DocumentListener dl=new DocumentListener()
        {
            @Override public void insertUpdate(DocumentEvent e) { AdjustButtons(); }
            @Override public void removeUpdate(DocumentEvent e) { AdjustButtons(); }
            @Override public void changedUpdate(DocumentEvent e) { AdjustButtons(); }
        };
        EdSportsmenName.getDocument().addDocumentListener(dl);
        EdTreningName.getDocument().addDocumentListener(dl);
        getRootPane().setDefaultButton(BtnExecute);
        AdjustButtons();
    }

    private void AdjustButtons()
    {
        final String TreningName=EdTreningName.getText().trim();
        boolean TreningNameExists=(TreningName.length()>0);
        boolean SportsmenNameExists=(EdSportsmenName.getText().length()>0);
        boolean IsTreningSelected=(LbCommands.getSelectedValue() instanceof CommandTrening);
        boolean IsSomethingSelected=(LbTrening.getSelectedValue()!=null);
        boolean TreningNameUnique=true;
        for(int i=0;i<commandmodel.size();++i) if(TreningName.equals(commandmodel.get(i).toString())) TreningNameUnique=false;
        BtnExecute.setEnabled(SportsmenNameExists);
        BtnDeleteFromCommands.setEnabled(IsTreningSelected);
        BtnDeleteFromTrening.setEnabled(IsSomethingSelected);
        BtnAddTrening.setEnabled(TreningNameExists && TreningNameUnique && IsSomethingSelected);
    }

    @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jButton1 = new javax.swing.JButton();
      LbCommandsScroll = new javax.swing.JScrollPane();
      LbCommands = new javax.swing.JList<Command>();
      jScrollPane1 = new javax.swing.JScrollPane();
      LbTrening = new javax.swing.JList<Command>();
      BtnAddToTrening = new javax.swing.JButton();
      BtnAddTrening = new javax.swing.JButton();
      EdTreningName = new javax.swing.JTextField();
      BtnDeleteFromCommands = new javax.swing.JButton();
      BtnDeleteFromTrening = new javax.swing.JButton();
      EdSportsmenName = new javax.swing.JTextField();
      BtnExecute = new javax.swing.JButton();
      jScrollPane2 = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();
      CbRun = new javax.swing.JComboBox();
      CbJump = new javax.swing.JComboBox();
      CbSwim = new javax.swing.JComboBox();

      jButton1.setText("jButton1");

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Command and Strategy");

      LbCommands.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
      LbCommands.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
         public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
            LbValueChanged(evt);
         }
      });
      LbCommandsScroll.setViewportView(LbCommands);

      LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
      LbTrening.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
         public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
            LbValueChanged(evt);
         }
      });
      jScrollPane1.setViewportView(LbTrening);

      BtnAddToTrening.setText("==>");
      BtnAddToTrening.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddToTreningActionPerformed(evt);
         }
      });

      BtnAddTrening.setText("<==");
      BtnAddTrening.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddTreningActionPerformed(evt);
         }
      });

      EdTreningName.setText("Nazwa");

      BtnDeleteFromCommands.setText("X");
      BtnDeleteFromCommands.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnDeleteFromCommandsActionPerformed(evt);
         }
      });

      BtnDeleteFromTrening.setText("X");
      BtnDeleteFromTrening.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnDeleteFromTreningActionPerformed(evt);
         }
      });

      EdSportsmenName.setText("Kowalski Jan");

      BtnExecute.setText("Execute");
      BtnExecute.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnExecuteActionPerformed(evt);
         }
      });

      EdLog.setEditable(false);
      EdLog.setColumns(20);
      EdLog.setRows(5);
      jScrollPane2.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane2)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(BtnAddToTrening))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnAddTrening)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdTreningName, javax.swing.GroupLayout.DEFAULT_SIZE, 310, Short.MAX_VALUE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnDeleteFromCommands)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(BtnDeleteFromTrening)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 116, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(CbRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbSwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE))
                     .addComponent(EdSportsmenName))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnExecute)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnAddToTrening)
                  .addGap(12, 12, 12)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnAddTrening)
                     .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnDeleteFromCommands)
                     .addComponent(BtnDeleteFromTrening)))
               .addComponent(LbCommandsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 173, Short.MAX_VALUE)
               .addComponent(jScrollPane1))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 96, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbSwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnExecute))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

    private void BtnAddToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddToTreningActionPerformed
        int pos=treningmodel.size();
        treningmodel.addElement(LbCommands.getSelectedValue());
        LbTrening.setSelectedIndex(pos);
        AdjustButtons();
    }//GEN-LAST:event_BtnAddToTreningActionPerformed

    private void BtnAddTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddTreningActionPerformed
        final ArrayList<Command> lst=new ArrayList<>();
        for(int i=0;i<treningmodel.size();++i) lst.add(treningmodel.get(i));
        final Command cmd=new CommandTrening(EdTreningName.getText(), lst.toArray(new Command[0]));
        int pos=commandmodel.size();
        commandmodel.addElement(cmd);
        LbCommands.setSelectedIndex(pos);
        EdTreningName.selectAll();
        treningmodel.clear();
        AdjustButtons();        
    }//GEN-LAST:event_BtnAddTreningActionPerformed

    private void BtnDeleteFromCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDeleteFromCommandsActionPerformed
        int pos=LbCommands.getSelectedIndex();
        commandmodel.removeElementAt(pos);
        LbCommands.setSelectedIndex(Math.min(pos,commandmodel.size()-1));
        AdjustButtons();
    }//GEN-LAST:event_BtnDeleteFromCommandsActionPerformed

    private void BtnDeleteFromTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDeleteFromTreningActionPerformed
        int pos=LbTrening.getSelectedIndex();
        treningmodel.removeElementAt(pos);
        LbTrening.setSelectedIndex(Math.min(pos,treningmodel.size()-1));
        AdjustButtons();
    }//GEN-LAST:event_BtnDeleteFromTreningActionPerformed

    private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnExecuteActionPerformed
      final StrategyRun Run=StrategyRunFabric.Make(CbRun.getSelectedItem().toString());
      final StrategyJump Jump=StrategyJumpFabric.Make(CbJump.getSelectedItem().toString());
      final StrategySwim Swim=StrategySwimFabric.Make(CbSwim.getSelectedItem().toString());
      final Sportsmen s=new Sportsmen(EdSportsmenName.getText(),Run,Jump,Swim);
      final Command cmd=LbCommands.getSelectedValue();
      EdLog.append(s.execute(cmd)+System.lineSeparator());
      //EdLog.append(s+": "+cmd.execute(s)+System.lineSeparator());
      EdSportsmenName.selectAll();
      AdjustButtons();
    }//GEN-LAST:event_BtnExecuteActionPerformed

    private void LbValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_LbValueChanged
        AdjustButtons();
    }//GEN-LAST:event_LbValueChanged

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new CommandStrategyForm().setVisible(true));
    }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddToTrening;
   private javax.swing.JButton BtnAddTrening;
   private javax.swing.JButton BtnDeleteFromCommands;
   private javax.swing.JButton BtnDeleteFromTrening;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JComboBox CbJump;
   private javax.swing.JComboBox CbRun;
   private javax.swing.JComboBox CbSwim;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JTextField EdSportsmenName;
   private javax.swing.JTextField EdTreningName;
   private javax.swing.JList<Command> LbCommands;
   private javax.swing.JScrollPane LbCommandsScroll;
   private javax.swing.JList<Command> LbTrening;
   private javax.swing.JButton jButton1;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   // End of variables declaration//GEN-END:variables
}
