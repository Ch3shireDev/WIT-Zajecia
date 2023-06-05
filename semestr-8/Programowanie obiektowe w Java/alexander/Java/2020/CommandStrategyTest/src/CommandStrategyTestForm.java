
import java.util.ArrayList;
import javax.swing.DefaultListModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class CommandStrategyTestForm extends javax.swing.JFrame 
{
   private final DefaultListModel<SportsmenCommand> CommandModel=new  DefaultListModel<>(); // model dla listy komend
   private final DefaultListModel<SportsmenCommand> TreningModel=new  DefaultListModel<>(); // model dla skladu treningu
   public CommandStrategyTestForm() 
   {
      initComponents();
      LbCommands.setModel(CommandModel); // przypisanie modeluu do listy komend
      CommandModel.addElement(new SportsmenRun()); // dodanie komendy do listy komend
      CommandModel.addElement(new SportsmenJump()); // j.w.
      CommandModel.addElement(new SportsmenSwim()); // j.w.
      LbTrening.setModel(TreningModel); // przypisanie modeluu do skladu treningu
      DocumentListener dl=new DocumentListener() // stworzenie obserwatora
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustButtons(); }
      };
      EdSportsmenName.getDocument().addDocumentListener(dl); // dodajemy obserwator do nazwy sportowca
      EdTreningName.getDocument().addDocumentListener(dl); // dodajemy obserwator do nazwy treningu
      for(String kind:SportsmenStrategyRunFabric.keys()) CbStrategyRun.addItem(kind); // wypelnenie comboboxu nazwami strategii biegu
      for(String kind:SportsmenStrategyJumpFabric.keys()) CbStrategyJump.addItem(kind); // j.w.
      for(String kind:SportsmenStrategySwimFabric.keys()) CbStrategySwim.addItem(kind); // j.w.
      adjustButtons();
   }
   
   private void adjustButtons()
   {
      boolean sportsmeNameExists=EdSportsmenName.getText().trim().length()>0;
      boolean treningNotEmpty=TreningModel.size()>0;
      
      BtnExecute.setEnabled(sportsmeNameExists);
      BtnDeleteFromTrening.setEnabled(treningNotEmpty);
   }   

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      LbCommandsScroll = new javax.swing.JScrollPane();
      LbCommands = new javax.swing.JList();
      EdSportsmenName = new javax.swing.JTextField();
      BtnExecute = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();
      LbTreningScroll = new javax.swing.JScrollPane();
      LbTrening = new javax.swing.JList();
      BtnAddToTrening = new javax.swing.JButton();
      EdTreningName = new javax.swing.JTextField();
      BtnAddTocommand = new javax.swing.JButton();
      BtnDeleteFromCommands = new javax.swing.JButton();
      BtnDeleteFromTrening = new javax.swing.JButton();
      CbStrategyRun = new javax.swing.JComboBox();
      CbStrategyJump = new javax.swing.JComboBox();
      CbStrategySwim = new javax.swing.JComboBox();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      LbCommandsScroll.setViewportView(LbCommands);

      EdSportsmenName.setText("Jan Kowalski");

      BtnExecute.setText("Execute");
      BtnExecute.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnExecuteActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      LbTreningScroll.setViewportView(LbTrening);

      BtnAddToTrening.setText("==>");
      BtnAddToTrening.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddToTreningActionPerformed(evt);
         }
      });

      EdTreningName.setText("Trening");

      BtnAddTocommand.setText("<==");
      BtnAddTocommand.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddTocommandActionPerformed(evt);
         }
      });

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

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 170, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(BtnAddToTrening))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnAddTocommand)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdTreningName, javax.swing.GroupLayout.DEFAULT_SIZE, 328, Short.MAX_VALUE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnDeleteFromCommands)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(BtnDeleteFromTrening)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 0, Short.MAX_VALUE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdSportsmenName)
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
                  .addGap(4, 4, 4)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnAddTocommand)
                     .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnDeleteFromCommands)
                     .addComponent(BtnDeleteFromTrening)))
               .addComponent(LbCommandsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 179, Short.MAX_VALUE)
               .addComponent(LbTreningScroll))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnExecute))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 170, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   // wykonanie komendy
   private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnExecuteActionPerformed
      // pobieramy wybrane strategii za pośrednictwem fabrik
      final SportsmenStrategyRun run=SportsmenStrategyRunFabric.make(CbStrategyRun.getSelectedItem().toString());
      final SportsmenStrategyJump jump=SportsmenStrategyJumpFabric.make(CbStrategyJump.getSelectedItem().toString());
      final SportsmenStrategySwim swim=SportsmenStrategySwimFabric.make(CbStrategySwim.getSelectedItem().toString());
       // tworzymy sportowca
      final Sportsmen sp=new Sportsmen(EdSportsmenName.getText(),run,jump,swim);
      final SportsmenCommand cmd=(SportsmenCommand)LbCommands.getSelectedValue(); // pobieramy zaznaczoną komende z listy
      EdLog.append(sp.execute(cmd)+System.lineSeparator()); // wypisujemy raport wykonania
   }//GEN-LAST:event_BtnExecuteActionPerformed

   // dodajemy zaznaczoną komende do treningu
   private void BtnAddToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddToTreningActionPerformed
      final SportsmenCommand cmd=(SportsmenCommand)LbCommands.getSelectedValue(); // pobieramy zaznaczoną komende z listy
      TreningModel.addElement(cmd); // dodajemy pobraną wyżej koemde do treaningu
      LbTrening.setSelectedValue(cmd,true); // zazanaczamy dodaną komendę
      adjustButtons();
   }//GEN-LAST:event_BtnAddToTreningActionPerformed

   private void BtnAddTocommandActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddTocommandActionPerformed
      ArrayList<SportsmenCommand> cmds=new ArrayList<>();
      for(int i=0;i<TreningModel.size();++i) cmds.add(TreningModel.getElementAt(i));
      SportsmenCommand[] cmdsa=cmds.toArray(new SportsmenCommand[0]);
      SportsmenCommand cmd=new SportsmenTrening(EdTreningName.getText(),cmdsa);
      TreningModel.clear();
      CommandModel.addElement(cmd);
      adjustButtons();
   }//GEN-LAST:event_BtnAddTocommandActionPerformed

   private void BtnDeleteFromCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDeleteFromCommandsActionPerformed
      SportsmenCommand cmd=(SportsmenCommand)LbCommands.getSelectedValue();
      if (cmd instanceof SportsmenTrening)
      {
         int pos=LbCommands.getSelectedIndex();
         CommandModel.removeElement(cmd);
         LbCommands.setSelectedIndex(Math.min(pos,CommandModel.size()-1));
      }
      adjustButtons();
   }//GEN-LAST:event_BtnDeleteFromCommandsActionPerformed

   private void BtnDeleteFromTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDeleteFromTreningActionPerformed
      SportsmenCommand cmd=(SportsmenCommand)LbTrening.getSelectedValue();
      int pos=LbTrening.getSelectedIndex();
      TreningModel.removeElement(cmd);
      LbTrening.setSelectedIndex(Math.min(pos,TreningModel.size()-1));
      adjustButtons();
   }//GEN-LAST:event_BtnDeleteFromTreningActionPerformed

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater(() -> new CommandStrategyTestForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddToTrening;
   private javax.swing.JButton BtnAddTocommand;
   private javax.swing.JButton BtnDeleteFromCommands;
   private javax.swing.JButton BtnDeleteFromTrening;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JComboBox CbStrategyJump;
   private javax.swing.JComboBox CbStrategyRun;
   private javax.swing.JComboBox CbStrategySwim;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   private javax.swing.JTextField EdSportsmenName;
   private javax.swing.JTextField EdTreningName;
   private javax.swing.JList LbCommands;
   private javax.swing.JScrollPane LbCommandsScroll;
   private javax.swing.JList LbTrening;
   private javax.swing.JScrollPane LbTreningScroll;
   // End of variables declaration//GEN-END:variables
}
