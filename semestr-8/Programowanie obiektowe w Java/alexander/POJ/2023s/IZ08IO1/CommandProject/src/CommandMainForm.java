
import javax.swing.DefaultListModel;

public class CommandMainForm extends javax.swing.JFrame
{
    private DefaultListModel<SportsmenCommand> commands=new DefaultListModel<>();
    private DefaultListModel<SportsmenCommand> trening=new DefaultListModel<>();
            
    public CommandMainForm()
    {
        initComponents();
        //LbCommands.removeAll();
        commands.addElement(new CommandRun());
        commands.addElement(new CommandJump());
        commands.addElement(new CommandSwim());
        LbCommands.setModel(commands);
        LbCommands.setSelectedIndex(0);
        LbTrening.setModel(trening);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        LbCommands = new javax.swing.JList<>();
        jScrollPane2 = new javax.swing.JScrollPane();
        LbTrening = new javax.swing.JList<>();
        BtnAddCommandToTrening = new javax.swing.JButton();
        TbTreningName = new javax.swing.JTextField();
        BtnAddTreningToCommands = new javax.swing.JButton();
        BtnRemoveFromCommands = new javax.swing.JButton();
        BtnRemoveFromTrening = new javax.swing.JButton();
        TbSportsmenName = new javax.swing.JTextField();
        BtnExecuteCommand = new javax.swing.JButton();
        jScrollPane3 = new javax.swing.JScrollPane();
        TaResults = new javax.swing.JTextArea();
        SpCount = new javax.swing.JSpinner();
        BtnAddMultiplyToCommands = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        LbCommands.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        jScrollPane1.setViewportView(LbCommands);

        LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        jScrollPane2.setViewportView(LbTrening);

        BtnAddCommandToTrening.setText("►");
        BtnAddCommandToTrening.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddCommandToTreningActionPerformed(evt);
            }
        });

        BtnAddTreningToCommands.setText("◄");

        BtnRemoveFromCommands.setText("X");

        BtnRemoveFromTrening.setText("X");

        BtnExecuteCommand.setText("Execute");

        TaResults.setColumns(20);
        TaResults.setRows(5);
        jScrollPane3.setViewportView(TaResults);

        SpCount.setModel(new javax.swing.SpinnerNumberModel(2, 2, 9, 1));

        BtnAddMultiplyToCommands.setText("◄");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane3)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 104, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(BtnAddCommandToTrening)
                                .addGap(0, 0, Short.MAX_VALUE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(BtnRemoveFromCommands)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(BtnRemoveFromTrening))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addGap(0, 130, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddMultiplyToCommands)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddTreningToCommands)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(TbTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 104, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(TbSportsmenName)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnExecuteCommand)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnAddCommandToTrening)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(TbTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(BtnAddTreningToCommands))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(BtnAddMultiplyToCommands)))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(BtnRemoveFromCommands)
                                    .addComponent(BtnRemoveFromTrening)))))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnExecuteCommand)
                    .addComponent(TbSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 113, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddCommandToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddCommandToTreningActionPerformed
        
    }//GEN-LAST:event_BtnAddCommandToTreningActionPerformed

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new CommandMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAddCommandToTrening;
    private javax.swing.JButton BtnAddMultiplyToCommands;
    private javax.swing.JButton BtnAddTreningToCommands;
    private javax.swing.JButton BtnExecuteCommand;
    private javax.swing.JButton BtnRemoveFromCommands;
    private javax.swing.JButton BtnRemoveFromTrening;
    private javax.swing.JList<SportsmenCommand> LbCommands;
    private javax.swing.JList<SportsmenCommand> LbTrening;
    private javax.swing.JSpinner SpCount;
    private javax.swing.JTextArea TaResults;
    private javax.swing.JTextField TbSportsmenName;
    private javax.swing.JTextField TbTreningName;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    // End of variables declaration//GEN-END:variables
}
