
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.awt.image.BufferedImage;
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class BridgeMain extends javax.swing.JFrame 
{
   private final DefaultListModel<Figure> lbm=new DefaultListModel<>();
   private final DefaultComboBoxModel<String> cbm=new DefaultComboBoxModel<>();
   private final ArrayList<Figure> lst=new ArrayList<>();
   private final BridgeList brList;
   private final BridgeImage brImage;
   
   public BridgeMain() 
   {
      initComponents();
      LbList.setModel(lbm);
      cbFigure.setModel(cbm);
      Figure.keys().forEach((String kind) -> cbm.addElement(kind));
      cbFigure.setSelectedIndex(0);
      brList = new BridgeList(LbList);
      brImage = new BridgeImage((ImagePaintBox)ImgBox);
      final ComponentAdapter adp = new ComponentAdapter() 
      {  
         public void componentResized(ComponentEvent evt)
         {
            ((ImagePaintBox)ImgBox).resizeImage();
            brImage.draw(lst);
         }
      };
      ImgBox.addComponentListener(adp);      
      adp.componentResized(null);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      ImgBox = new ImagePaintBox();
      LbListScroller = new javax.swing.JScrollPane();
      LbList = new javax.swing.JList<>();
      cbFigure = new javax.swing.JComboBox<>();
      edParams = new javax.swing.JTextField();
      BtnAdd = new javax.swing.JButton();
      BtnRemove = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      javax.swing.GroupLayout ImgBoxLayout = new javax.swing.GroupLayout(ImgBox);
      ImgBox.setLayout(ImgBoxLayout);
      ImgBoxLayout.setHorizontalGroup(
         ImgBoxLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 481, Short.MAX_VALUE)
      );
      ImgBoxLayout.setVerticalGroup(
         ImgBoxLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      LbListScroller.setViewportView(LbList);

      edParams.setText("100 100 300 300");

      BtnAdd.setText("Dodaj");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      BtnRemove.setText("Usuń");
      BtnRemove.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnRemoveActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                  .addComponent(BtnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addGap(18, 18, 18)
                  .addComponent(BtnRemove, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addComponent(edParams, javax.swing.GroupLayout.DEFAULT_SIZE, 197, Short.MAX_VALUE)
               .addComponent(cbFigure, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(LbListScroller, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(ImgBox, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(ImgBox, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LbListScroller, javax.swing.GroupLayout.DEFAULT_SIZE, 322, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(cbFigure, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(edParams, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnAdd)
                     .addComponent(BtnRemove))))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      String kind = (String)cbFigure.getSelectedItem();
      String params = edParams.getText();
      final Figure fig=Figure.make(kind, params);
      lst.add(fig);
      brList.draw(lst);
      brImage.draw(lst);   
   }//GEN-LAST:event_BtnAddActionPerformed

   private void BtnRemoveActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnRemoveActionPerformed
      // TODO add your handling code here:
      final Figure fig=LbList.getSelectedValue();
      lst.remove(fig);
      brList.draw(lst);
      brImage.draw(lst);   
   }//GEN-LAST:event_BtnRemoveActionPerformed

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater
      (
         new Runnable() 
         {
            @Override public void run() 
            {
               new BridgeMain().setVisible(true);
            }
         }
      );
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnRemove;
   private javax.swing.JPanel ImgBox;
   private javax.swing.JList<Figure> LbList;
   private javax.swing.JScrollPane LbListScroller;
   private javax.swing.JComboBox<String> cbFigure;
   private javax.swing.JTextField edParams;
   // End of variables declaration//GEN-END:variables
}
