
import javax.swing.DefaultComboBoxModel;

public class CommandForm extends javax.swing.JFrame
{
   private final DefaultComboBoxModel<SportsmenStrategyRun> modelRun=new DefaultComboBoxModel<>();
   public CommandForm()
   {
      initComponents();
      CbStrategyRun.setModel(modelRun);
      modelRun.addElement(new SportsmenStrategyRunMaraton());
      modelRun.addElement(new SportsmenStrategyRunSprint());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      LbCommandListScroll = new javax.swing.JScrollPane();
      LbCommandList = new javax.swing.JList();
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
      CbStrategyRun = new javax.swing.JComboBox<SportsmenStrategyRun>();
      CbStrategyJump = new javax.swing.JComboBox<SportsmenStrategyJump>();
      CbStrategySwim = new javax.swing.JComboBox<SportsmenStrategySwim>();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      LbCommandList.setModel(new javax.swing.AbstractListModel() {
         String[] strings = { "CommandList" };
         public int getSize() { return strings.length; }
         public Object getElementAt(int i) { return strings[i]; }
      });
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
                  .addComponent(EdSportsmenName)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnExecute))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LbCommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 119, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                              .addComponent(BtnAddTreningToList)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, 183, javax.swing.GroupLayout.PREFERRED_SIZE))
                           .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                              .addComponent(BtnAddLoopToList)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                              .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE))))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnAddToTrening)
                        .addGap(0, 0, Short.MAX_VALUE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnRemoveFromList)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(BtnRemoveFromTrening)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LbTrenigListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
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
                           .addComponent(EdTreningName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                           .addComponent(BtnAddTreningToList))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                           .addComponent(BtnAddLoopToList)))
                     .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                           .addComponent(BtnRemoveFromList)
                           .addComponent(BtnRemoveFromTrening)))))
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                  .addComponent(LbTrenigListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addComponent(LbCommandListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbStrategyRun, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbStrategyJump, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(CbStrategySwim, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdSportsmenName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnExecute))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogAreaScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 143, Short.MAX_VALUE)
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
   private javax.swing.JComboBox<SportsmenStrategyJump> CbStrategyJump;
   private javax.swing.JComboBox<SportsmenStrategyRun> CbStrategyRun;
   private javax.swing.JComboBox<SportsmenStrategySwim> CbStrategySwim;
   private javax.swing.JSpinner EdCount;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JScrollPane EdLogAreaScroll;
   private javax.swing.JTextField EdSportsmenName;
   private javax.swing.JTextField EdTreningName;
   private javax.swing.JList LbCommandList;
   private javax.swing.JScrollPane LbCommandListScroll;
   private javax.swing.JList LbTrenigList;
   private javax.swing.JScrollPane LbTrenigListScroll;
   // End of variables declaration//GEN-END:variables
}
