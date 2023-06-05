
import java.util.ArrayList;
import javax.swing.DefaultListModel;

public class BridgeForm extends javax.swing.JFrame
{
   private final ArrayList<Figure> list=new ArrayList<>();
   private final FigureBridgeListbox LbBridge;
   public BridgeForm()
   {
      initComponents();
      LbFigures.setModel(new DefaultListModel<Figure>());
      LbBridge = new FigureBridgeListbox(LbFigures);
      for(String kind : FigureFabric.keys()) CbFigKinds.addItem(kind);
      CbFigKinds.setSelectedIndex(2);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CbFigKinds = new javax.swing.JComboBox();
      EdParameters = new javax.swing.JTextField();
      LbFiguresScroll = new javax.swing.JScrollPane();
      LbFigures = new javax.swing.JList<Figure>();
      BtnAdd = new javax.swing.JButton();
      PnlLbFigures = new javax.swing.JPanel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdParameters.setText("200 200 100 400 300 400");

      LbFiguresScroll.setViewportView(LbFigures);

      BtnAdd.setText("Add");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout PnlLbFiguresLayout = new javax.swing.GroupLayout(PnlLbFigures);
      PnlLbFigures.setLayout(PnlLbFiguresLayout);
      PnlLbFiguresLayout.setHorizontalGroup(
         PnlLbFiguresLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 258, Short.MAX_VALUE)
      );
      PnlLbFiguresLayout.setVerticalGroup(
         PnlLbFiguresLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
               .addComponent(EdParameters, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 177, Short.MAX_VALUE)
               .addComponent(BtnAdd, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(LbFiguresScroll, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
               .addComponent(CbFigKinds, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(PnlLbFigures, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(PnlLbFigures, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbFigKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnAdd)
                  .addGap(9, 9, 9)
                  .addComponent(LbFiguresScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 294, Short.MAX_VALUE)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      Figure fig=FigureFabric.make(CbFigKinds.getSelectedItem().toString(),EdParameters.getText());
      list.add(fig);
      LbBridge.proceed(list);
   }//GEN-LAST:event_BtnAddActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new BridgeForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JComboBox CbFigKinds;
   private javax.swing.JTextField EdParameters;
   private javax.swing.JList<Figure> LbFigures;
   private javax.swing.JScrollPane LbFiguresScroll;
   private javax.swing.JPanel PnlLbFigures;
   // End of variables declaration//GEN-END:variables
}
