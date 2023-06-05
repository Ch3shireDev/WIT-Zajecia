
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class CommandForm extends javax.swing.JFrame
{
   private final DefaultListModel<SportsmenCommand> commandModel=new DefaultListModel<>();
   private final DefaultComboBoxModel<SportsmenStrategySwim> smimModel=new DefaultComboBoxModel<>();
   public CommandForm()
   {
      initComponents();
      LbCommandList.setModel(commandModel);
      commandModel.addElement(new SportsmenCommandRun());
      commandModel.addElement(new SportsmenCommandJump());
      commandModel.addElement(new SportsmenCommandSwim());
      smimModel.addElement(new SportsmenStrategySwimCrawl());
      smimModel.addElement(new SportsmenStrategySwimFrog());
      smimModel.addElement(new SportsmenStrategySwimButterfly());
      CbStrategySwim.setModel(smimModel);
   }

   public void setSporstmenName(String name)
   {
      EdSportsmenName.setText(name);
   }

   public void AddCommandToList(SportsmenCommand cmd)
   {
      commandModel.addElement(cmd);
      LbCommandList.setSelectedIndex(commandModel.size()-1);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      LbCommandListScroll = new javax.swing.JScrollPane();
      LbCommandList = new javax.swing.JList<SportsmenCommand>();
      LbTrenigListScroll = new javax.swing.JScrollPane();
      LbTrenigList = new javax.swing.JList();
      BtnAddToTrening = new javax.swing.JButton();
      EdTreningName = new javax.swing.JTextField();
      BtnAddTreningToList = new javax.swing.JButton();
      EdCount = new javax.swing.JSpinner();
      BtnAddLoopToList = new javax.swing.JButton();
      EdSportsmenName = new javax.swing.JTextField();
      BtnExecute = new javax.swing.JButton();
      EdLogAreaScroll = new javax.swing.JScrollPane();
      EdLogArea = new javax.swing.JTextArea();
      BtnRemoveFromList = new javax.swing.JButton();
      BtnRemoveFromTrening = new javax.swing.JButton();
      CbStrategySwim = new javax.swing.JComboBox();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      LbCommandListScroll.setViewportView(LbCommandList);

      LbTrenigList.setModel(new javax.swing.AbstractListModel() {
         String[] strings = { "TreningList" };
         public int getSize() { return strings.length; }
         public Object getElementAt(int i) { return strings[i]; }
      });
      LbTrenigListScroll.setViewportView(LbTrenigList);

      BtnAddToTrening.setText("=>");

      EdTreningName.setText("TreningName");

      BtnAddTreningToList.setText("<=");

      EdCount.setModel(new javax.swing.SpinnerNumberModel(2, 2, 9, 1));

      BtnAddLoopToList.setText("<=");

      EdSportsmenName.setText("Kowalski");

      BtnExecute.setText("Execute");

      EdLogArea.setColumns(20);
      EdLogArea.setRows(5);
      EdLogAreaScroll.setViewportView(EdLogArea);

      BtnRemoveFromList.setText("X");

      BtnRemoveFromTrening.setText("X");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogAreaScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LbCommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnRemoveFromList)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(BtnRemoveFromTrening))
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 99, Short.MAX_VALUE)
                        .addComponent(BtnAddTreningToList)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, 183, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addComponent(BtnAddToTrening)
                           .addGroup(layout.createSequentialGroup()
                              .addGap(97, 97, 97)
                              .addComponent(BtnAddLoopToList)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 0, Short.MAX_VALUE)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LbTrenigListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
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
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                           .addComponent(BtnAddTreningToList))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                           .addComponent(BtnAddLoopToList))
                        .addGap(5, 5, 5))
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(BtnRemoveFromList)
                           .addComponent(BtnRemoveFromTrening)))))
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                  .addComponent(LbTrenigListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addComponent(LbCommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnExecute)
               .addComponent(EdSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogAreaScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 161, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new CommandForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAddLoopToList;
   private javax.swing.JButton BtnAddToTrening;
   private javax.swing.JButton BtnAddTreningToList;
   private javax.swing.JButton BtnExecute;
   private javax.swing.JButton BtnRemoveFromList;
   private javax.swing.JButton BtnRemoveFromTrening;
   private javax.swing.JComboBox CbStrategySwim;
   private javax.swing.JSpinner EdCount;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JScrollPane EdLogAreaScroll;
   private javax.swing.JTextField EdSportsmenName;
   private javax.swing.JTextField EdTreningName;
   private javax.swing.JList<SportsmenCommand> LbCommandList;
   private javax.swing.JScrollPane LbCommandListScroll;
   private javax.swing.JList LbTrenigList;
   private javax.swing.JScrollPane LbTrenigListScroll;
   // End of variables declaration//GEN-END:variables
}
