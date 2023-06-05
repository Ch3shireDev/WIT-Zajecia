
import javax.swing.DefaultListModel;
import javax.swing.ListModel;

public class CommandProjectMainForm extends javax.swing.JFrame
{
    private DefaultListModel<SportsmenCommand> commandsModel=new DefaultListModel<>();
    private DefaultListModel<SportsmenCommand> treningModel=new DefaultListModel<>();

    public CommandProjectMainForm() 
    {
        initComponents();
        LbTrening.setModel(treningModel);
        LbCommands.setModel(commandsModel);
        commandsModel.addElement(new SportsmenCommandJump());
        commandsModel.addElement(new SportsmenCommandRun());
        commandsModel.addElement(new SportsmenCommandSwim());
        LbCommands.setSelectedIndex(0);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        LbCommandsScroll = new javax.swing.JScrollPane();
        LbCommands = new javax.swing.JList<>();
        LbTreningScroll = new javax.swing.JScrollPane();
        LbTrening = new javax.swing.JList<>();
        BtnAddCommandToTrening = new javax.swing.JButton();
        BtnAddTreanigToCommands = new javax.swing.JButton();
        TfTreningName = new javax.swing.JTextField();
        BtnAddMultiplyToCommands = new javax.swing.JButton();
        SpCount = new javax.swing.JSpinner();
        BtnRemoveFromCommands = new javax.swing.JButton();
        BtnRemoveFromTrening = new javax.swing.JButton();
        BtnExecute = new javax.swing.JButton();
        TfSportsmenName = new javax.swing.JTextField();
        TaLogScroll = new javax.swing.JScrollPane();
        TaLog = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMinimumSize(new java.awt.Dimension(500, 300));

        LbCommands.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbCommandsScroll.setViewportView(LbCommands);

        LbTrening.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        LbTreningScroll.setViewportView(LbTrening);

        BtnAddCommandToTrening.setText("►");

        BtnAddTreanigToCommands.setText("◄");

        BtnAddMultiplyToCommands.setText("◄");

        BtnRemoveFromCommands.setText("Ⓧ");

        BtnRemoveFromTrening.setText("Ⓧ");

        BtnExecute.setText("Execute");

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
                        .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(56, 56, 56)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(BtnAddMultiplyToCommands)
                                    .addComponent(BtnAddTreanigToCommands))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(TfTreningName)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(0, 201, Short.MAX_VALUE))))
                            .addGroup(layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnAddCommandToTrening)
                                        .addGap(0, 0, Short.MAX_VALUE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnRemoveFromCommands)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(BtnRemoveFromTrening)))))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(TfSportsmenName)
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
                        .addComponent(BtnAddCommandToTrening)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnAddTreanigToCommands)
                            .addComponent(TfTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnAddMultiplyToCommands)
                            .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnRemoveFromCommands)
                            .addComponent(BtnRemoveFromTrening)))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                        .addComponent(LbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(LbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnExecute)
                    .addComponent(TfSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(TaLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 151, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new CommandProjectMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAddCommandToTrening;
    private javax.swing.JButton BtnAddMultiplyToCommands;
    private javax.swing.JButton BtnAddTreanigToCommands;
    private javax.swing.JButton BtnExecute;
    private javax.swing.JButton BtnRemoveFromCommands;
    private javax.swing.JButton BtnRemoveFromTrening;
    private javax.swing.JList<SportsmenCommand> LbCommands;
    private javax.swing.JScrollPane LbCommandsScroll;
    private javax.swing.JList<SportsmenCommand> LbTrening;
    private javax.swing.JScrollPane LbTreningScroll;
    private javax.swing.JSpinner SpCount;
    private javax.swing.JTextArea TaLog;
    private javax.swing.JScrollPane TaLogScroll;
    private javax.swing.JTextField TfSportsmenName;
    private javax.swing.JTextField TfTreningName;
    // End of variables declaration//GEN-END:variables
}
