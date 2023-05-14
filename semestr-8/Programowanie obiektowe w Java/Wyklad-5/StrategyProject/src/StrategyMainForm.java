
import java.util.ArrayList;
import java.util.Collections;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;


public class StrategyMainForm extends javax.swing.JFrame {

    private DefaultListModel<SportsmanCommand> commands = new DefaultListModel<>();
    private DefaultListModel<SportsmanCommand> trening = new DefaultListModel<>();
    private DefaultComboBoxModel<String> running = new DefaultComboBoxModel<>();
    private DefaultComboBoxModel<String> jumping = new DefaultComboBoxModel<>();
    private DefaultComboBoxModel<String> swimming = new DefaultComboBoxModel<>();
    
    public StrategyMainForm() {
        initComponents();
        commands.addElement(new CommandRun());
        commands.addElement(new CommandJump());
        commands.addElement(new CommandSwim());
        LbCommands.setModel(commands);
        LbTrening.setModel(trening);
        LbCommands.setSelectedIndex(0);
        CbStrategyRun.setModel(running);
        for (String key : StrategyRunFactory.keys) {
            running.addElement(key);
        }
        CbStrategyRun.setSelectedIndex(0);
        CbStrategyJump.setModel(jumping);
        for (String key : StrategyJumpFactory.keys) {
            jumping.addElement(key);
        }
        CbStrategyJump.setSelectedIndex(0);
        CbStrategySwim.setModel(swimming);
        for (String key : StrategySwimFactory.keys) {
            swimming.addElement(key);
        }
        CbStrategySwim.setSelectedIndex(0);
        DocumentListener listener = new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                AdjustButtons();
            }

            @Override
            public void removeUpdate(DocumentEvent e) {
                AdjustButtons();
            }

            @Override
            public void changedUpdate(DocumentEvent e) {
                AdjustButtons();
            }
        };
        
        TbTreningName.getDocument().addDocumentListener(listener);
        AdjustButtons();
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
        String sportsmanName = getSportsmenName();
        // ==================================
        boolean isTreningNameNotEmpty =! treningName.isEmpty();
        boolean isCommandNameUnique = checkCommandNameUnique(treningName);
        boolean isSportsmanNameNotEmpty = ! sportsmanName.isEmpty();
        boolean isSelectedCommandComplex = (selecetedCommand instanceof CommandTrening) || (selecetedCommand instanceof CommandMultiply) ;
        boolean isTreningListNotEmpty = !trening.isEmpty();
        
        // ==================================
        
        BtnAddTreningToCommands.setEnabled(isTreningNameNotEmpty && isCommandNameUnique && isTreningListNotEmpty);
        BtnAddMultiplyToCommands.setEnabled(isTreningNameNotEmpty && isCommandNameUnique);
        BtnRemoveFromCommands.setEnabled(isSelectedCommandComplex);
        BtnRemoveFromTrening.setEnabled(isTreningListNotEmpty);
        BtnExecute.setEnabled(isSportsmanNameNotEmpty); 
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
        CbStrategyRun = new javax.swing.JComboBox<>();
        CbStrategyJump = new javax.swing.JComboBox<>();
        CbStrategySwim = new javax.swing.JComboBox<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        LbCommands.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbCommands.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                LbCommandsValueChanged(evt);
            }
        });
        LbCommandsScroll.setViewportView(LbCommands);

        BtnAddCommandToTrening.setText("=>");
        BtnAddCommandToTrening.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddCommandToTreningActionPerformed(evt);
            }
        });

        LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbTrening.setToolTipText("");
        LbTrening.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                LbTreningValueChanged(evt);
            }
        });
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

        CbStrategyRun.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Run" }));

        CbStrategyJump.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Jump" }));

        CbStrategySwim.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Swim" }));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaResultsScroll)
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
                                .addComponent(BtnRemoveFromTrening, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)))
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
                        .addComponent(TbSporstmenName)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnExecute, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE)))
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
                    .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(TbSporstmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnExecute))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaResultsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 239, Short.MAX_VALUE)
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
        AdjustButtons();
        
    }//GEN-LAST:event_BtnAddMultiplyToCommandsActionPerformed

    private void BtnRemoveFromCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveFromCommandsActionPerformed
        int index = LbCommands.getSelectedIndex();
        commands.removeElementAt(index);
        LbCommands.setSelectedIndex (Math.min(index,commands.getSize()-1));
        AdjustButtons();
    }//GEN-LAST:event_BtnRemoveFromCommandsActionPerformed

    private void BtnRemoveFromTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveFromTreningActionPerformed
        int index = LbTrening.getSelectedIndex();
        trening.removeElementAt(index);
        LbTrening.setSelectedIndex(Math.min(index, trening.getSize()-1));
        AdjustButtons();
    }//GEN-LAST:event_BtnRemoveFromTreningActionPerformed

    private void BtnAddCommandToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddCommandToTreningActionPerformed
        SportsmanCommand command= getSelectedCommand();
        trening.addElement(command);
        LbTrening.setSelectedIndex(trening.getSize()-1);
        AdjustButtons();
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
        AdjustButtons();
    }//GEN-LAST:event_BtnAddTreningToCommandsActionPerformed

    private void BtnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnExecuteActionPerformed
        // Sportsman(String name)
        
        String name = TbSporstmenName.getText().trim();

        String run= CbStrategyRun.getSelectedItem().toString();
        String swim= CbStrategySwim.getSelectedItem().toString();
        String jump= CbStrategyJump.getSelectedItem().toString();
        Sportsman sportsman = new Sportsman(run, swim, jump,name);
        
        SportsmanCommand command = getSelectedCommand();
        
        TaResults.append(sportsman.execute(command) + System.lineSeparator()); 
    }//GEN-LAST:event_BtnExecuteActionPerformed

    private void LbCommandsValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_LbCommandsValueChanged
        AdjustButtons();
    }//GEN-LAST:event_LbCommandsValueChanged

    private void LbTreningValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_LbTreningValueChanged
        AdjustButtons();
    }//GEN-LAST:event_LbTreningValueChanged

    
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new StrategyMainForm().setVisible(true);
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
    private javax.swing.JComboBox<String> CbStrategyJump;
    private javax.swing.JComboBox<String> CbStrategyRun;
    private javax.swing.JComboBox<String> CbStrategySwim;
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
