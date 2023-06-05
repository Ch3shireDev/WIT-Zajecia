
import java.util.ArrayList;
import javax.swing.DefaultListModel;

public class BridgeForm extends javax.swing.JFrame
{
   private final ArrayList<Figure> list=new ArrayList<>();
   private final FigureBridgePanel bridgePanel;
   private final FigureBridge[] briges;
   public BridgeForm()
   {
      initComponents();
      LbFigures.setModel(new DefaultListModel());
      for(String kind : FigureFabric.getKeys()) CbFigKinds.addItem(kind);
      bridgePanel = new FigureBridgePanel(PnlFigures);
      briges = new FigureBridge[]
      {
         bridgePanel,
         new FigureBridgeListbox(LbFigures),
      };
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CbFigKinds = new javax.swing.JComboBox();
      EdParameters = new javax.swing.JTextField();
      BtnAdd = new javax.swing.JButton();
      LbFiguresScroll = new javax.swing.JScrollPane();
      LbFigures = new javax.swing.JList();
      PnlFigures = new javax.swing.JPanel();
      EdJsonScroll = new javax.swing.JScrollPane();
      EdJson = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      BtnAdd.setText("Add");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      LbFiguresScroll.setViewportView(LbFigures);

      PnlFigures.addComponentListener(new java.awt.event.ComponentAdapter() {
         public void componentResized(java.awt.event.ComponentEvent evt) {
            PnlFiguresComponentResized(evt);
         }
      });

      javax.swing.GroupLayout PnlFiguresLayout = new javax.swing.GroupLayout(PnlFigures);
      PnlFigures.setLayout(PnlFiguresLayout);
      PnlFiguresLayout.setHorizontalGroup(
         PnlFiguresLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 612, Short.MAX_VALUE)
      );
      PnlFiguresLayout.setVerticalGroup(
         PnlFiguresLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      EdJson.setColumns(20);
      EdJson.setRows(5);
      EdJsonScroll.setViewportView(EdJson);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdJsonScroll)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                     .addComponent(LbFiguresScroll)
                     .addComponent(CbFigKinds, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                     .addComponent(EdParameters, javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(BtnAdd, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(PnlFigures, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbFigKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(LbFiguresScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 303, Short.MAX_VALUE))
               .addComponent(PnlFigures, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addComponent(EdJsonScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 185, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      Figure fig=FigureFabric.make(CbFigKinds.getSelectedItem().toString(),EdParameters.getText());
      list.add(fig);
      for(FigureBridge brige:briges) brige.proceed(list);
   }//GEN-LAST:event_BtnAddActionPerformed

   private void PnlFiguresComponentResized(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_PnlFiguresComponentResized
      bridgePanel.proceed(list);
   }//GEN-LAST:event_PnlFiguresComponentResized

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new BridgeForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JComboBox CbFigKinds;
   private javax.swing.JTextArea EdJson;
   private javax.swing.JScrollPane EdJsonScroll;
   private javax.swing.JTextField EdParameters;
   private javax.swing.JList LbFigures;
   private javax.swing.JScrollPane LbFiguresScroll;
   private javax.swing.JPanel PnlFigures;
   // End of variables declaration//GEN-END:variables
}
