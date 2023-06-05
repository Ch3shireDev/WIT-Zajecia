public class CommansMainForm extends javax.swing.JFrame
{
   public CommansMainForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      jScrollPane1 = new javax.swing.JScrollPane();
      LbCommands = new javax.swing.JList<>();
      jScrollPane2 = new javax.swing.JScrollPane();
      LbTraining = new javax.swing.JList<>();
      BtnAddToTraining = new javax.swing.JButton();
      BtnRemoveFromTraining = new javax.swing.JButton();
      TfTrainingName = new javax.swing.JTextField();
      BtnAddTreningToCommands = new javax.swing.JButton();
      BtnRemoveFromCommands = new javax.swing.JButton();
      jSpinner1 = new javax.swing.JSpinner();
      BtnAddMultipłyToCommands = new javax.swing.JButton();
      BtnExecute = new javax.swing.JButton();
      TfSportsmenName = new javax.swing.JTextField();
      jScrollPane3 = new javax.swing.JScrollPane();
      TaLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      jScrollPane1.setViewportView(LbCommands);

      jScrollPane2.setViewportView(LbTraining);

      BtnAddToTraining.setText("=>");

      BtnRemoveFromTraining.setText("X");

      TfTrainingName.setText("Base");

      BtnAddTreningToCommands.setText("<=");
      BtnAddTreningToCommands.setToolTipText("Add trainig");

      BtnRemoveFromCommands.setText("X");

      BtnAddMultipłyToCommands.setText("<=");
      BtnAddMultipłyToCommands.setToolTipText("Add multiply");

      BtnExecute.setText("Execute");

      TfSportsmenName.setText("Smith");

      TaLog.setEditable(false);
      TaLog.setColumns(20);
      TaLog.setRows(5);
      jScrollPane3.setViewportView(TaLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane3)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(BtnRemoveFromCommands)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(BtnRemoveFromTraining))
                     .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addComponent(BtnAddToTraining)
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(BtnAddMultipłyToCommands)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(jSpinner1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 0, Short.MAX_VALUE))
                     .addGroup(layout.createSequentialGroup()
                        .addGap(55, 55, 55)
                        .addComponent(BtnAddTreningToCommands)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TfTrainingName, javax.swing.GroupLayout.DEFAULT_SIZE, 236, Short.MAX_VALUE)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
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
               .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(BtnAddToTraining)
                     .addGroup(layout.createSequentialGroup()
                        .addGap(33, 33, 33)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(TfTrainingName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                           .addComponent(BtnAddTreningToCommands))))
                  .addGap(8, 8, 8)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(jSpinner1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(BtnAddMultipłyToCommands))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnRemoveFromTraining)
                     .addComponent(BtnRemoveFromCommands))))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnExecute)
               .addComponent(TfSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 169, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new CommansMainForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddMultipłyToCommands;
   private javax.swing.JButton BtnAddToTraining;
   private javax.swing.JButton BtnAddTreningToCommands;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JButton BtnRemoveFromCommands;
   private javax.swing.JButton BtnRemoveFromTraining;
   private javax.swing.JList<String> LbCommands;
   private javax.swing.JList<String> LbTraining;
   private javax.swing.JTextArea TaLog;
   private javax.swing.JTextField TfSportsmenName;
   private javax.swing.JTextField TfTrainingName;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JScrollPane jScrollPane3;
   private javax.swing.JSpinner jSpinner1;
   // End of variables declaration//GEN-END:variables
}
