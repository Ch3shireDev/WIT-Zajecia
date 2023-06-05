
import javax.swing.DefaultComboBoxModel;

public class CommandMainForm extends javax.swing.JFrame
{
   private final DefaultComboBoxModel<SportsmenCommand> CbCommandsModel=new DefaultComboBoxModel<>();
   private final DefaultComboBoxModel<SportsmenCommand> CbTreningModel=new DefaultComboBoxModel<>();
   public CommandMainForm()
   {
      initComponents();
      CbCommands.setModel(CbCommandsModel);
      CbTrening.setModel(CbTreningModel);
      CbCommandsModel.addElement(new SportsmenRun());
      CbCommandsModel.addElement(new SportsmenJump());
      CbCommandsModel.addElement(new SportsmenSwim());
      CbCommands.setSelectedIndex(0);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      CbCommandsScroll = new javax.swing.JScrollPane();
      CbTrening = new javax.swing.JList<>();
      CbTreningScroll = new javax.swing.JScrollPane();
      CbCommands = new javax.swing.JList<>();
      BtnAddToTrening = new javax.swing.JButton();
      TfTrenigName = new javax.swing.JTextField();
      BtnAddTrenigToComands = new javax.swing.JButton();
      BtnAddMultiplyToComands = new javax.swing.JButton();
      SpCount = new javax.swing.JSpinner();
      BtnRemoveFromCommands = new javax.swing.JButton();
      BtnRemoveFromTrening = new javax.swing.JButton();
      TfSportsmenName = new javax.swing.JTextField();
      BtnExecute = new javax.swing.JButton();
      TaLogScroll = new javax.swing.JScrollPane();
      TaLog = new javax.swing.JTextArea();
      CbSwim = new javax.swing.JComboBox<>();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      CbCommandsScroll.setViewportView(CbTrening);

      CbTreningScroll.setViewportView(CbCommands);

      BtnAddToTrening.setText("=>");

      BtnAddTrenigToComands.setText("<=");

      BtnAddMultiplyToComands.setText("<=");

      SpCount.setModel(new javax.swing.SpinnerNumberModel(3, 2, 9, 1));

      BtnRemoveFromCommands.setText("X");

      BtnRemoveFromTrening.setText("X");

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
                  .addComponent(TfSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, 615, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 15, Short.MAX_VALUE)
                  .addComponent(BtnExecute))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 108, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(97, 97, 97)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(BtnAddMultiplyToComands)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                              .addGap(0, 0, Short.MAX_VALUE))
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(BtnAddTrenigToComands)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(TfTrenigName))))
                     .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(BtnAddToTrening)
                              .addGap(0, 0, Short.MAX_VALUE))
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(BtnRemoveFromCommands)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                              .addComponent(BtnRemoveFromTrening)))))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 108, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
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
                  .addComponent(BtnAddToTrening)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(TfTrenigName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                           .addComponent(BtnAddTrenigToComands))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(BtnAddMultiplyToComands)
                           .addComponent(SpCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(BtnRemoveFromCommands)
                           .addComponent(BtnRemoveFromTrening)))))
               .addComponent(CbTreningScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbCommandsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(CbSwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 54, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(TfSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnExecute))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(TaLogScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new CommandMainForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddMultiplyToComands;
   private javax.swing.JButton BtnAddToTrening;
   private javax.swing.JButton BtnAddTrenigToComands;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JButton BtnRemoveFromCommands;
   private javax.swing.JButton BtnRemoveFromTrening;
   private javax.swing.JList<SportsmenCommand> CbCommands;
   private javax.swing.JScrollPane CbCommandsScroll;
   private javax.swing.JComboBox<SportsmenSwimStrategy> CbSwim;
   private javax.swing.JList<SportsmenCommand> CbTrening;
   private javax.swing.JScrollPane CbTreningScroll;
   private javax.swing.JSpinner SpCount;
   private javax.swing.JTextArea TaLog;
   private javax.swing.JScrollPane TaLogScroll;
   private javax.swing.JTextField TfSportsmenName;
   private javax.swing.JTextField TfTrenigName;
   // End of variables declaration//GEN-END:variables
}
