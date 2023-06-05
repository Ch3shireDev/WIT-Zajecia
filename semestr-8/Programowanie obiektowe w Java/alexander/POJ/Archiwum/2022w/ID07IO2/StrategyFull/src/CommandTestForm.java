
import java.util.ArrayList;
import java.util.List;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.ListModel;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.ListDataEvent;
import javax.swing.event.ListDataListener;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;


public class CommandTestForm extends javax.swing.JFrame {
    
    private final DefaultListModel commandListModel = new DefaultListModel();
    private final DefaultListModel trainingListModel = new DefaultListModel();
    public CommandTestForm() {
        initComponents();
        lbCommandList.setModel(commandListModel);
        commandListModel.addElement(new SportsmanCommandRun());
        commandListModel.addElement(new SportsmanCommandJump());
        commandListModel.addElement(new SportsmanCommandSwim()); 
        lbCommandList.setSelectedIndex(0);
        
        cbStrategySwim.removeAllItems();
        for(String kind : SportsmanStrategySwim.keys)
        {
            cbStrategySwim.addItem(kind);
        }        
        cbStrategySwim.setSelectedIndex(0);
        
        cbStrategyRun.removeAllItems();
        for(String kind : SportsmanStrategyRun.keys)
        {
            cbStrategyRun.addItem(kind);
        }       
        cbStrategyRun.setSelectedIndex(0);
        
        cbStrategyJump.removeAllItems();
        for(String kind : SportsmanStrategyJump.keys)
        {
            cbStrategyJump.addItem(kind);
        }       
        cbStrategyJump.setSelectedIndex(0);
        
        lbTrainingList.setModel(trainingListModel);
        
        DocumentListener listener = new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                adjustButtons();
            }

            @Override
            public void removeUpdate(DocumentEvent e) {
                adjustButtons();
            }

            @Override
            public void changedUpdate(DocumentEvent e) {
                adjustButtons();
            }
        };
        tfTrainingName.getDocument().addDocumentListener(listener);
        tfSportsmanName.getDocument().addDocumentListener(listener);
        ListSelectionListener listListener = new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                adjustButtons();
            }
        };
        lbCommandList.addListSelectionListener(listListener);
        ListDataListener  dataListener = new ListDataListener() {
            @Override
            public void intervalAdded(ListDataEvent arg0) {
                adjustButtons(); 
            }

            @Override
            public void intervalRemoved(ListDataEvent arg0) {
              adjustButtons();
            }

            @Override
            public void contentsChanged(ListDataEvent arg0) {
                adjustButtons();
            }
        };
        trainingListModel.addListDataListener(dataListener);
        commandListModel.addListDataListener(dataListener);
                
        adjustButtons();
        
    }
    private String getTrainingName(){
        return tfTrainingName.getText().trim();
    }
    
      private String getSportsmanName(){
        return tfSportsmanName.getText().trim();
    }
    
    private boolean isUniqueCommandName(String commandName){
        for(int i = 0; i < commandListModel.size(); ++i){
            if(commandListModel.get(i).toString().equals(commandName)){
                return false;
            }
        }
        return true;
    }
    
    private void adjustButtons(){
        String trainingName = getTrainingName();
        String sportsmanName = getSportsmanName();
        SportsmanCommand selectedCommand = getSelectedCommand();
        
        boolean trainingNameNotEmpty = !trainingName.isEmpty();
        boolean trainingListNotEmpty = !trainingListModel.isEmpty();
        boolean uniqueCommandName = isUniqueCommandName(trainingName);
        boolean sportsmanNameNotEmpty = !sportsmanName.isEmpty();
        boolean selectedCommandIsComplex = selectedCommand instanceof SportsmanCommandComplex;
                
        btnAddTraining.setEnabled(trainingNameNotEmpty && trainingListNotEmpty && uniqueCommandName);
        btnExecute.setEnabled(sportsmanNameNotEmpty);
        btnAddMultiply.setEnabled(trainingNameNotEmpty && uniqueCommandName);
        btnRemoveFromTrainingList.setEnabled(trainingListNotEmpty);
        btnRemoveFromCommands.setEnabled(selectedCommandIsComplex);
    }
        
    private static void RemoveIndexFromListbox(JList<SportsmanCommand> listbox){
        DefaultListModel<SportsmanCommand> model = (DefaultListModel<SportsmanCommand>) listbox.getModel();
        int index = listbox.getSelectedIndex();
        model.removeElementAt(index);
        int size = model.size();
        listbox.setSelectedIndex(size > index ? index : size - 1);
    }
 
 
    private SportsmanCommand getSelectedCommand(){
        return lbCommandList.getSelectedValue();
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lbCommandListScroll = new javax.swing.JScrollPane();
        lbCommandList = new javax.swing.JList<>();
        lbTrainingListScroll = new javax.swing.JScrollPane();
        lbTrainingList = new javax.swing.JList<>();
        btnAddToTrainingList = new javax.swing.JButton();
        tfTrainingName = new javax.swing.JTextField();
        btnAddTraining = new javax.swing.JButton();
        spCount = new javax.swing.JSpinner();
        btnAddMultiply = new javax.swing.JButton();
        btnRemoveFromTrainingList = new javax.swing.JButton();
        btnRemoveFromCommands = new javax.swing.JButton();
        tfSportsmanName = new javax.swing.JTextField();
        btnExecute = new javax.swing.JButton();
        taLogScroll = new javax.swing.JScrollPane();
        taLog = new javax.swing.JTextArea();
        cbStrategyRun = new javax.swing.JComboBox<>();
        cbStrategyJump = new javax.swing.JComboBox<>();
        cbStrategySwim = new javax.swing.JComboBox<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        lbCommandList.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        lbCommandListScroll.setViewportView(lbCommandList);

        lbTrainingList.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        lbTrainingListScroll.setViewportView(lbTrainingList);

        btnAddToTrainingList.setText("=>");
        btnAddToTrainingList.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAddToTrainingListActionPerformed(evt);
            }
        });

        btnAddTraining.setText("<=");
        btnAddTraining.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAddTrainingActionPerformed(evt);
            }
        });

        spCount.setModel(new javax.swing.SpinnerNumberModel(3, 2, 10, 1));

        btnAddMultiply.setText("<=");
        btnAddMultiply.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAddMultiplyActionPerformed(evt);
            }
        });

        btnRemoveFromTrainingList.setText("X");
        btnRemoveFromTrainingList.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRemoveFromTrainingListActionPerformed(evt);
            }
        });

        btnRemoveFromCommands.setText("X");
        btnRemoveFromCommands.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRemoveFromCommandsActionPerformed(evt);
            }
        });

        btnExecute.setText("Wykonaj");
        btnExecute.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnExecuteActionPerformed(evt);
            }
        });

        taLog.setColumns(20);
        taLog.setRows(5);
        taLogScroll.setViewportView(taLog);

        cbStrategyRun.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Run" }));

        cbStrategyJump.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Jump" }));

        cbStrategySwim.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Swim" }));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(taLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lbCommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 154, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                        .addComponent(btnRemoveFromCommands, javax.swing.GroupLayout.DEFAULT_SIZE, 72, Short.MAX_VALUE)
                                        .addGap(316, 316, 316)
                                        .addComponent(btnRemoveFromTrainingList, javax.swing.GroupLayout.PREFERRED_SIZE, 72, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(btnAddToTrainingList)
                                            .addGroup(layout.createSequentialGroup()
                                                .addComponent(btnAddMultiply)
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                    .addComponent(spCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                                    .addGroup(layout.createSequentialGroup()
                                                        .addComponent(btnAddTraining)
                                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                        .addComponent(tfTrainingName, javax.swing.GroupLayout.PREFERRED_SIZE, 206, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                                        .addGap(0, 0, Short.MAX_VALUE))))
                            .addComponent(tfSportsmanName))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnExecute, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lbTrainingListScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 154, Short.MAX_VALUE)))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(cbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(cbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(cbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btnAddToTrainingList)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(7, 7, 7)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(tfTrainingName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnAddTraining))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(spCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnAddMultiply)))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(btnRemoveFromTrainingList)
                                    .addComponent(btnRemoveFromCommands)))))
                    .addComponent(lbTrainingListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 220, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbCommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 220, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnExecute)
                    .addComponent(tfSportsmanName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 179, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnAddToTrainingListActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAddToTrainingListActionPerformed
        SportsmanCommand cmd = getSelectedCommand();
        trainingListModel.addElement(cmd);
        lbTrainingList.setSelectedIndex(trainingListModel.size()-1);
    }//GEN-LAST:event_btnAddToTrainingListActionPerformed

    
    private void btnAddTrainingActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAddTrainingActionPerformed
        String trainingName = getTrainingName();
        List<SportsmanCommand> comandsList = new ArrayList<>();
        for( int i = 0; i <trainingListModel.size(); ++i)
        {
            comandsList.add((SportsmanCommand)trainingListModel.get(i));
        }
        SportsmanCommand complex = new SportsmanCommandTrening(trainingName, comandsList);
        commandListModel.addElement(complex);
        lbCommandList.setSelectedIndex(commandListModel.size()-1);
        
    }//GEN-LAST:event_btnAddTrainingActionPerformed

    private void btnAddMultiplyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAddMultiplyActionPerformed
       String trainingName = getTrainingName();
       SportsmanCommand cmd = getSelectedCommand();
       int count = (int) spCount.getValue();
       SportsmanCommand complex = new SportsmanCommandMultiply(trainingName, cmd, count);
        commandListModel.addElement(complex);
        lbCommandList.setSelectedIndex(commandListModel.size()-1);
    }//GEN-LAST:event_btnAddMultiplyActionPerformed

    private void btnRemoveFromCommandsActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnRemoveFromCommandsActionPerformed
    {//GEN-HEADEREND:event_btnRemoveFromCommandsActionPerformed
        RemoveIndexFromListbox(lbCommandList);
    }//GEN-LAST:event_btnRemoveFromCommandsActionPerformed

    private void btnRemoveFromTrainingListActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRemoveFromTrainingListActionPerformed
        RemoveIndexFromListbox(lbTrainingList);
    }//GEN-LAST:event_btnRemoveFromTrainingListActionPerformed

    private void btnExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnExecuteActionPerformed
        String sportsmanName = tfSportsmanName.getText();
        SportsmanStrategyRun strategyRun = SportsmanStrategyRun.make(cbStrategyRun.getSelectedItem().toString());
        SportsmanStrategySwim strategySwim = SportsmanStrategySwim.make(cbStrategySwim.getSelectedItem().toString());
        SportsmanStrategyJump strategyJump = SportsmanStrategyJump.make(cbStrategyJump.getSelectedItem().toString());
        Sportsman sportsman = new Sportsman(sportsmanName, strategyRun, strategySwim, strategyJump);
        SportsmanCommand cmd = getSelectedCommand();
        taLog.append(sportsman.execute(cmd) + System.lineSeparator());
    }//GEN-LAST:event_btnExecuteActionPerformed

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new CommandTestForm().setVisible(true);
            }
        });
    }
    

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAddMultiply;
    private javax.swing.JButton btnAddToTrainingList;
    private javax.swing.JButton btnAddTraining;
    private javax.swing.JButton btnExecute;
    private javax.swing.JButton btnRemoveFromCommands;
    private javax.swing.JButton btnRemoveFromTrainingList;
    private javax.swing.JComboBox<String> cbStrategyJump;
    private javax.swing.JComboBox<String> cbStrategyRun;
    private javax.swing.JComboBox<String> cbStrategySwim;
    private javax.swing.JList<SportsmanCommand> lbCommandList;
    private javax.swing.JScrollPane lbCommandListScroll;
    private javax.swing.JList<SportsmanCommand> lbTrainingList;
    private javax.swing.JScrollPane lbTrainingListScroll;
    private javax.swing.JSpinner spCount;
    private javax.swing.JTextArea taLog;
    private javax.swing.JScrollPane taLogScroll;
    private javax.swing.JTextField tfSportsmanName;
    private javax.swing.JTextField tfTrainingName;
    // End of variables declaration//GEN-END:variables
}
