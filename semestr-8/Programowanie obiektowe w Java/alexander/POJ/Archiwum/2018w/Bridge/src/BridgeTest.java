
import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class BridgeTest extends javax.swing.JFrame
{
   private final DefaultComboBoxModel<FigureMaker> fk=new DefaultComboBoxModel<>();
   private final DefaultListModel<Figure> lbm=new DefaultListModel<>();
   private final FigureList figlist=new FigureList();
   private final Screen scrlst,scrxml,scrimg;
   private final BufferedImage img=new BufferedImage(1000,1000,BufferedImage.TYPE_INT_RGB);
   private final PaintCaller painter=(Graphics g) ->
   {
      g.drawImage(img,0,0,Color.white,rootPane);
   };

   public BridgeTest()
   {
      initComponents();
      CbFigureKind.setModel(fk);
      fk.addElement(new CircleMaker());
      fk.addElement(new TriangleMaker());
      fk.addElement(new RectangleMaker());
      LbFigureList.setModel(lbm);
      scrlst=new ScreenListbox(LbFigureList);
      scrxml=new ScreenXml(EdXml);
      scrimg=new ScreenImage(img.getGraphics());
      figlist.Draw(scrimg);
  }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      CbFigureKind = new javax.swing.JComboBox<>();
      EdParams = new javax.swing.JTextField();
      EdXmlScroll = new javax.swing.JScrollPane();
      EdXml = new javax.swing.JTextArea();
      LbFigureListScroll = new javax.swing.JScrollPane();
      LbFigureList = new javax.swing.JList<>();
      BtnAdd = new javax.swing.JButton();
      ImgPanel = new PaintPanel(painter);

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdParams.setText("100, 50, 50,100, 50, 50");

      EdXml.setEditable(false);
      EdXml.setColumns(20);
      EdXml.setRows(5);
      EdXmlScroll.setViewportView(EdXml);

      LbFigureListScroll.setViewportView(LbFigureList);

      BtnAdd.setText("Dodaj");
      BtnAdd.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnAddActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout ImgPanelLayout = new javax.swing.GroupLayout(ImgPanel);
      ImgPanel.setLayout(ImgPanelLayout);
      ImgPanelLayout.setHorizontalGroup(
         ImgPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );
      ImgPanelLayout.setVerticalGroup(
         ImgPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 292, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(CbFigureKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(EdParams, javax.swing.GroupLayout.PREFERRED_SIZE, 142, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(BtnAdd))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdXmlScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 493, Short.MAX_VALUE))
               .addComponent(ImgPanel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(LbFigureListScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 151, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(LbFigureListScroll)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(EdXmlScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 157, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(CbFigureKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdParams, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnAdd)))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(ImgPanel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnAddActionPerformed
   {//GEN-HEADEREND:event_BtnAddActionPerformed
      FigureMaker maker=(FigureMaker)CbFigureKind.getSelectedItem();
      Figure fig=maker.make(EdParams.getText());
      figlist.add(fig);
      figlist.Draw(scrlst);
      figlist.Draw(scrxml);
      figlist.Draw(scrimg);
      ImgPanel.repaint();
   }//GEN-LAST:event_BtnAddActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new BridgeTest().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JComboBox<FigureMaker> CbFigureKind;
   private javax.swing.JTextField EdParams;
   private javax.swing.JTextArea EdXml;
   private javax.swing.JScrollPane EdXmlScroll;
   private javax.swing.JPanel ImgPanel;
   private javax.swing.JList<Figure> LbFigureList;
   private javax.swing.JScrollPane LbFigureListScroll;
   // End of variables declaration//GEN-END:variables
}
