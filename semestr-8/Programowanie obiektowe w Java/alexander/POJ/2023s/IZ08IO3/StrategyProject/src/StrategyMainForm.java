
import javax.swing.DefaultListModel;
import javax.swing.ListModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class StrategyMainForm extends javax.swing.JFrame
{

    private final DefaultListModel<SportsmenCommand> comandsModel=new DefaultListModel<>();
    private final DefaultListModel<SportsmenCommand> treningModel=new DefaultListModel<>();

    public StrategyMainForm()
    {
        initComponents();
        LbTrening.setModel(treningModel);
        LbCommands.setModel(comandsModel);
        comandsModel.addElement(new SportsmenCommandJump());
        comandsModel.addElement(new SportsmenCommandRun());
        comandsModel.addElement(new SportsmenCommandSwim());
        LbCommands.setSelectedIndex(0);
        AdjustButtons();
        DocumentListener listener=new DocumentListener()
        {
            @Override public void insertUpdate(DocumentEvent e)  { AdjustButtons(); }
            @Override public void removeUpdate(DocumentEvent e)  { AdjustButtons(); }
            @Override public void changedUpdate(DocumentEvent e) { AdjustButtons(); }
        };
        TfTreningTitle.getDocument().addDocumentListener(listener);
        TfSportsmenName.getDocument().addDocumentListener(listener);
    }
    
    private String getSportsmenName() { return TfSportsmenName.getText().trim(); }
    private String getTreningTitle() { return TfTreningTitle.getText().trim(); }
    
    private void AdjustButtons()
    {
        String SportsmenName=getSportsmenName();
        String TreningTitle=getTreningTitle();
        
        boolean SportsmenNameNotEmpty=(!SportsmenName.isEmpty());
        
        BtnAddNewTreningToCommands.setEnabled(SportsmenNameNotEmpty);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        LbCommandsScroll = new javax.swing.JScrollPane();
        LbCommands = new javax.swing.JList<>();
        LbTreningScroll = new javax.swing.JScrollPane();
        LbTrening = new javax.swing.JList<>();
        BtnAddSelectedCommandToTrening = new javax.swing.JButton();
        TfTreningTitle = new javax.swing.JTextField();
        BtnAddNewTreningToCommands = new javax.swing.JButton();
        BtnAddNewMultiplyToCommands = new javax.swing.JButton();
        SpCount = new javax.swing.JSpinner();
        BtnRemoveSelectedFromCommands = new javax.swing.JButton();
        BtnRemoveSelectedFromTrening = new javax.swing.JButton();
        BtnExecuteSelectedCommand = new javax.swing.JButton();
        TfSportsmenName = new javax.swing.JTextField();
        TaLogScroll = new javax.swing.JScrollPane();
        TaLog = new javax.swing.JTextArea();
        CbRun = new javax.swing.JComboBox<>();
        CbJump = new javax.swing.JComboBox<>();
        CbSwim = new javax.swing.JComboBox<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        LbCommands.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbCommands.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                LbCommandsValueChanged(evt);
            }
        });
        LbCommandsScroll.setViewportView(LbCommands);

        LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbTreningScroll.setViewportView(LbTrening);

        BtnAddSelectedCommandToTrening.setText("►");
        BtnAddSelectedCommandToTrening.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddSelectedCommandToTreningActionPerformed(evt);
            }
        });

        BtnAddNewTreningToCommands.setText("◄");
        BtnAddNewTreningToCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddNewTreningToCommandsActionPerformed(evt);
            }
        });

        BtnAddNewMultiplyToCommands.setText("◄");
        BtnAddNewMultiplyToCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddNewMultiplyToCommandsActionPerformed(evt);
            }
        });

        BtnRemoveSelectedFromCommands.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        BtnRemoveSelectedFromCommands.setText("X");
        BtnRemoveSelectedFromCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnRemoveSelectedFromCommandsActionPerformed(evt);
            }
        });

        BtnRemoveSelectedFromTrening.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        BtnRemoveSelectedFromTrening.setText("X");
        BtnRemoveSelectedFromTrening.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnRemoveSelectedFromTreningActionPerformed(evt);
            }
        });

        BtnExecuteSelectedCommand.setText("Execute");

        TaLog.setColumns(20);
        TaLog.setRows(5);
        TaLogScroll.setViewportView(TaLog);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(56, 56, 56)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddNewMultiplyToCommands)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(0, 266, Short.MAX_VALUE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddNewTreningToCommands)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(TfTreningTitle))))
                            .addGroup(layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddSelectedCommandToTrening)
                                        .addGap(0, 0, Short.MAX_VALUE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnRemoveSelectedFromCommands)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(BtnRemoveSelectedFromTrening)))))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(TfSportsmenName)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnExecuteSelectedCommand))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(CbSwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnAddSelectedCommandToTrening)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnAddNewTreningToCommands)
                            .addComponent(TfTreningTitle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnAddNewMultiplyToCommands)
                            .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnRemoveSelectedFromCommands)
                            .addComponent(BtnRemoveSelectedFromTrening)))
                    .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 151, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 151, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(CbRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbSwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnExecuteSelectedCommand)
                    .addComponent(TfSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 98, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddSelectedCommandToTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddSelectedCommandToTreningActionPerformed
        AdjustButtons();
    }//GEN-LAST:event_BtnAddSelectedCommandToTreningActionPerformed

    private void BtnAddNewTreningToCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddNewTreningToCommandsActionPerformed
        AdjustButtons();
    }//GEN-LAST:event_BtnAddNewTreningToCommandsActionPerformed

    private void BtnAddNewMultiplyToCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddNewMultiplyToCommandsActionPerformed
        AdjustButtons();
    }//GEN-LAST:event_BtnAddNewMultiplyToCommandsActionPerformed

    private void BtnRemoveSelectedFromCommandsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveSelectedFromCommandsActionPerformed
        AdjustButtons();
    }//GEN-LAST:event_BtnRemoveSelectedFromCommandsActionPerformed

    private void BtnRemoveSelectedFromTreningActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveSelectedFromTreningActionPerformed
        AdjustButtons();
    }//GEN-LAST:event_BtnRemoveSelectedFromTreningActionPerformed

    private void LbCommandsValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_LbCommandsValueChanged
        AdjustButtons();
    }//GEN-LAST:event_LbCommandsValueChanged

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new StrategyMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAddNewMultiplyToCommands;
    private javax.swing.JButton BtnAddNewTreningToCommands;
    private javax.swing.JButton BtnAddSelectedCommandToTrening;
    private javax.swing.JButton BtnExecuteSelectedCommand;
    private javax.swing.JButton BtnRemoveSelectedFromCommands;
    private javax.swing.JButton BtnRemoveSelectedFromTrening;
    private javax.swing.JComboBox<String> CbJump;
    private javax.swing.JComboBox<String> CbRun;
    private javax.swing.JComboBox<String> CbSwim;
    private javax.swing.JList<SportsmenCommand> LbCommands;
    private javax.swing.JScrollPane LbCommandsScroll;
    private javax.swing.JList<SportsmenCommand> LbTrening;
    private javax.swing.JScrollPane LbTreningScroll;
    private javax.swing.JSpinner SpCount;
    private javax.swing.JTextArea TaLog;
    private javax.swing.JScrollPane TaLogScroll;
    private javax.swing.JTextField TfSportsmenName;
    private javax.swing.JTextField TfTreningTitle;
    // End of variables declaration//GEN-END:variables
}
