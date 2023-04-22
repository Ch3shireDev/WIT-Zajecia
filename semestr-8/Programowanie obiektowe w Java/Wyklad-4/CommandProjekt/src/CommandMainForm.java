
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import javax.swing.DefaultListModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;


public class CommandMainForm extends javax.swing.JFrame {

    private DefaultListModel<SportsmanCommand> commands = new DefaultListModel<>();
    private DefaultListModel<SportsmanCommand> trening = new DefaultListModel<>();
    
    public CommandMainForm() {
        initComponents();
        commands.addElement(new CommandRun());
        commands.addElement(new CommandJump());
        commands.addElement(new CommandSwim());
        LbCommands.setModel(commands);
        LbTrening.setModel(trening);
        LbCommands.setSelectedIndex(0);
        

        
    }
    
    private String getTreningName(){
        return TbTreningName.getText().trim();
    }
    
    private boolean checkCommandNameUnique(String commandName){
        return Collections.list(commands.elements()).stream().noneMatch(c -> c.toString().equals(commandName));
    }
    
    private String getSportsmenName(){
        return TbSporstmenName.getText().trim();
    }
    
    private SportsmanCommand getSelectedCommand(){
        return LbCommands.getSelectedValue();
    }
    
    
    private void AdjustButtons(){
        
        String treningName = getTreningName();
        SportsmanCommand selecetedCommand = getSelectedCommand();
        // ==================================
        boolean isTreningNameNotEmpty =! treningName.isEmpty();
        boolean isCommandNameUnique = checkCommandNameUnique(treningName);
        
        boolean isSelectedCommandComplex = (selecetedCommand instanceof CommandTrening) || (selecetedCommand instanceof CommandMultiply) ;
        
        // ==================================
        
        BtnAddTreningToCommands.setEnabled(isTreningNameNotEmpty && isCommandNameUnique);
        BtnAddMultiplyToCommands.setEnabled(isTreningNameNotEmpty && isCommandNameUnique);
        BtnRemoveFromCommands.setEnabled(isSelectedCommandComplex);

        
        
    }
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        LbCommandsScroll = new javax.swing.JScrollPane();
        LbCommands = new javax.swing.JList<>();
        BtnAddCommandToTrening = new javax.swing.JButton();
        LbTreningScroll = new javax.swing.JScrollPane();
        LbTrening = new javax.swing.JList<>();
        BtnAddTreningToCommands = new javax.swing.JButton();
        TbTreningName = new javax.swing.JTextField();
        SpCount = new javax.swing.JSpinner();
        BtnAddMultiplyToCommands = new javax.swing.JButton();
        BtnRemoveFromCommands = new javax.swing.JButton();
        BtnRemoveFromTrening = new javax.swing.JButton();
        TbSporstmenName = new javax.swing.JTextField();
        BtnExecute = new javax.swing.JButton();
        TaResultsScroll = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        LbCommands.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbCommandsScroll.setViewportView(LbCommands);

        BtnAddCommandToTrening.setText("=>");
        BtnAddCommandToTrening.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddCommandToTreningActionPerformed(evt);
            }
        });

        LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbTrening.setToolTipText("");
        LbTreningScroll.setViewportView(LbTrening);

        BtnAddTreningToCommands.setText("<=");
        BtnAddTreningToCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddTreningToCommandsActionPerformed(evt);
            }
        });

        SpCount.setModel(new javax.swing.SpinnerNumberModel(2, 2, 9, 1));

        BtnAddMultiplyToCommands.setText("<=");
        BtnAddMultiplyToCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddMultiplyToCommandsActionPerformed(evt);
            }
        });

        BtnRemoveFromCommands.setText("X");
        BtnRemoveFromCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnRemoveFromCommandsActionPerformed(evt);
            }
        });

        BtnRemoveFromTrening.setText("X");
        BtnRemoveFromTrening.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnRemoveFromTreningActionPerformed(evt);
            }
        });

        BtnExecute.setText("Execute");
        BtnExecute.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnExecuteActionPerformed(evt);
            }
        });

        TaResults.setColumns(20);
        TaResults.setRows(5);
        TaResultsScroll.setViewportView(TaResults);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaResultsScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(TbSporstmenName)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                        .addGap(0, 219, Short.MAX_VALUE)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(BtnAddTreningToCommands)
                                            .addComponent(BtnAddMultiplyToCommands))
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(TbTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, 137, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddCommandToTrening)
                                        .addGap(0, 0, Short.MAX_VALUE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnRemoveFromCommands, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(BtnRemoveFromTrening, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                            .addComponent(BtnExecute, javax.swing.GroupLayout.DEFAULT_SIZE, 157, Short.MAX_VALUE))))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(LbTreningScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 177, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnAddCommandToTrening)
                        .addGap(28, 28, 28)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(TbTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(BtnAddTreningToCommands))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(BtnAddMultiplyToCommands))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnRemoveFromCommands, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(BtnRemoveFromTrening, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(LbCommandsScroll))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(TbSporstmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnExecute))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 174, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddMultiplyToCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddMultiplyToCommandsActionPerformed
        // CommandMultiply(String title, SportsmanCommand command, int count)
        String title = getTreningName();
        SportsmanCommand command = LbCommands.getSelectedValue();

        int count = (int)SpCount.getValue();

        CommandMultiply multiply = new CommandMultiply(title, command, count);
        commands.addElement(multiply);
        
        LbCommands.setSelectedIndex(commands.getSize()-1);
        
    }//GEN-LAST:event_BtnAddMultiplyToCommandsActionPerformed

    private void BtnRemoveFromCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveFromCommandsActionPerformed
        int index = LbCommands.getSelectedIndex();
        commands.removeElementAt(index);
        LbCommands.setSelectedIndex (Math.min(index,commands.getSize()-1));
    }//GEN-LAST:event_BtnRemoveFromCommandsActionPerformed

    private void BtnRemoveFromTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveFromTreningActionPerformed
        int index = LbTrening.getSelectedIndex();
        trening.removeElementAt(index);
        LbTrening.setSelectedIndex(Math.min(index, trening.getSize()));
    }//GEN-LAST:event_BtnRemoveFromTreningActionPerformed

    private void BtnAddCommandToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddCommandToTreningActionPerformed
        SportsmanCommand command= getSelectedCommand();
        trening.addElement(command);
        LbTrening.setSelectedIndex(trening.getSize()-1);
    }//GEN-LAST:event_BtnAddCommandToTreningActionPerformed

    private void BtnAddTreningToCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddTreningToCommandsActionPerformed
        // CommandTrening(String title, List<SportsmanCommand> commands)
        
        String title = getTreningName();
        ArrayList<SportsmanCommand> commands = new ArrayList<>(); // trening.elements().
        
        for(int i=0; i<trening.getSize(); i++){
            commands.add( trening.elementAt(i) );
        }
        
        CommandTrening commandTrening = new CommandTrening(title, commands);
        
        this.commands.addElement(commandTrening);
        LbCommands.setSelectedIndex(this.commands.getSize()-1);
    }//GEN-LAST:event_BtnAddTreningToCommandsActionPerformed

    private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnExecuteActionPerformed
        // Sportsman(String name)
        
        String name = TbSporstmenName.getText().trim();
        Sportsman sportsman = new Sportsman(name);
        
        SportsmanCommand command = getSelectedCommand();
        
        TaResults.append(sportsman.execute(command) + System.lineSeparator()); 
        
    }//GEN-LAST:event_BtnExecuteActionPerformed

    
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new CommandMainForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAddCommandToTrening;
    private javax.swing.JButton BtnAddMultiplyToCommands;
    private javax.swing.JButton BtnAddTreningToCommands;
    private javax.swing.JButton BtnExecute;
    private javax.swing.JButton BtnRemoveFromCommands;
    private javax.swing.JButton BtnRemoveFromTrening;
    private javax.swing.JList<SportsmanCommand> LbCommands;
    private javax.swing.JScrollPane LbCommandsScroll;
    private javax.swing.JList<SportsmanCommand> LbTrening;
    private javax.swing.JScrollPane LbTreningScroll;
    private javax.swing.JSpinner SpCount;
    private javax.swing.JTextArea TaResults;
    private javax.swing.JScrollPane TaResultsScroll;
    private javax.swing.JTextField TbSporstmenName;
    private javax.swing.JTextField TbTreningName;
    // End of variables declaration//GEN-END:variables
}
