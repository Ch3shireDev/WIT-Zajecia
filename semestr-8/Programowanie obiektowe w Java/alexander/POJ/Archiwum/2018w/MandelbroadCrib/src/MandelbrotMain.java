
import com.sun.glass.events.MouseEvent;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;
import java.awt.image.BandedSampleModel;
import java.awt.image.BufferedImage;
import java.awt.image.ColorModel;
import java.awt.image.DataBuffer;
import java.awt.image.DataBufferByte;
import java.awt.image.MultiPixelPackedSampleModel;
import java.awt.image.Raster;
import java.awt.image.SampleModel;
import java.awt.image.SinglePixelPackedSampleModel;
import java.awt.image.WritableRaster;
import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.JFileChooser;

public class MandelbrotMain extends javax.swing.JFrame
{
   private BufferedImage img;
   private double zoom=1,lf=-2,tp=1;
   private double pressPi=0,pressPr=0;
   private boolean notmoved=false,pressed=false;

   private final PaintCaller painter=(Graphics g) ->
   {
      if(img!=null) g.drawImage(img,0,0,Color.white,rootPane);
   };

   public MandelbrotMain()
   {
      initComponents();
      setData(-2,1,1);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      Box = new PaintPanel(painter);
      EdLf = new javax.swing.JTextField();
      LbLf = new javax.swing.JLabel();
      LbTp = new javax.swing.JLabel();
      EdTp = new javax.swing.JTextField();
      LbZoom = new javax.swing.JLabel();
      EdZoom = new javax.swing.JTextField();
      BtnCalc = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      Box.addMouseMotionListener(new java.awt.event.MouseMotionAdapter()
      {
         public void mouseDragged(java.awt.event.MouseEvent evt)
         {
            BoxMouseDragged(evt);
         }
      });
      Box.addMouseListener(new java.awt.event.MouseAdapter()
      {
         public void mousePressed(java.awt.event.MouseEvent evt)
         {
            BoxMousePressed(evt);
         }
         public void mouseReleased(java.awt.event.MouseEvent evt)
         {
            BoxMouseReleased(evt);
         }
      });
      Box.addComponentListener(new java.awt.event.ComponentAdapter()
      {
         public void componentResized(java.awt.event.ComponentEvent evt)
         {
            BoxComponentResized(evt);
         }
      });

      javax.swing.GroupLayout BoxLayout = new javax.swing.GroupLayout(Box);
      Box.setLayout(BoxLayout);
      BoxLayout.setHorizontalGroup(
         BoxLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );
      BoxLayout.setVerticalGroup(
         BoxLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 354, Short.MAX_VALUE)
      );

      EdLf.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdLf.setText("-2");

      LbLf.setText("   X:");

      LbTp.setText("   Y:");

      EdTp.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdTp.setText("1");

      LbZoom.setText("   Zoom:");

      EdZoom.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdZoom.setText("0,75");

      BtnCalc.setText("Calc");
      BtnCalc.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnCalcActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(8, 8, 8)
            .addComponent(Box, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGap(8, 8, 8))
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LbLf)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addComponent(EdLf, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(LbTp)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addComponent(EdTp, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(LbZoom)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addComponent(EdZoom, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BtnCalc)
            .addContainerGap(45, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdLf, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(LbLf)
               .addComponent(EdTp, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(LbTp)
               .addComponent(EdZoom, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(LbZoom)
               .addComponent(BtnCalc))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(Box, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void remakeImg()
   {
      int W=Box.getWidth();
      int H=Box.getHeight();
      img=new BufferedImage(W,H,BufferedImage.TYPE_INT_RGB);
   }

   private void boxrepaint(BufferedImage im)
   {
      if(im==img) Box.repaint();
   }

   private void redrawBox()
   {
      //MandelbroatImager mi=new MandelbroatSimple();
      //MandelbroatImager mi=new MandelbroatOneThread();
      MandelbroatImager mi=new MandelbroatMultiThread();
      mi.execute(tp,lf,zoom,img,this::boxrepaint);
      //mi.execute(tp,lf,zoom,img,(im)->boxrepaint(im));
      /*
      mi.execute
      (
         tp,lf,zoom,img,
         new MandelbroatDone()
         {
            @Override public void finished(BufferedImage img)
            {
               boxrepaint(img);
            }
         }
      );
      */
   }

   public void recalc()
   {
      try
      {
         lf=Double.parseDouble(EdLf.getText());
         tp=Double.parseDouble(EdTp.getText());
         zoom=Double.parseDouble(EdZoom.getText());
         remakeImg();
         redrawBox();
      }
      catch(Exception e) {}
   }

   private void setData(double lf,double tp,double zoom)
   {
      EdLf.setText(""+lf);
      EdTp.setText(""+tp);
      EdZoom.setText(""+zoom);
      this.lf=lf;
      this.tp=tp;
      this.zoom=zoom;
      recalc();
   }

   private void BtnCalcActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnCalcActionPerformed
   {//GEN-HEADEREND:event_BtnCalcActionPerformed
      recalc();
   }//GEN-LAST:event_BtnCalcActionPerformed

   private void BoxComponentResized(java.awt.event.ComponentEvent evt)//GEN-FIRST:event_BoxComponentResized
   {//GEN-HEADEREND:event_BoxComponentResized
      recalc();
   }//GEN-LAST:event_BoxComponentResized

   private void BoxMousePressed(java.awt.event.MouseEvent evt)//GEN-FIRST:event_BoxMousePressed
   {//GEN-HEADEREND:event_BoxMousePressed
      int W=img.getWidth();
      int H=img.getHeight();
      double mul=MabdelbroadProc.zoom2mul(zoom,W);
      pressPi=MabdelbroadProc.py2im(mul,tp,evt.getY());
      pressPr=MabdelbroadProc.px2re(mul,lf,evt.getX());
      notmoved=pressed=true;
   }//GEN-LAST:event_BoxMousePressed

   private void BoxMouseReleased(java.awt.event.MouseEvent evt)//GEN-FIRST:event_BoxMouseReleased
   {//GEN-HEADEREND:event_BoxMouseReleased
      if((pressed)&&(notmoved))
      {
         int W=img.getWidth();
         int H=img.getHeight();
         double mul=MabdelbroadProc.zoom2mul(zoom,W);
         double Pi=MabdelbroadProc.py2im(mul,tp,evt.getY());
         double Pr=MabdelbroadProc.px2re(mul,lf,evt.getX());
         double new_zoom=zoom;
         if(evt.getButton()==1) new_zoom*=2;
         else if(evt.getButton()==3) new_zoom/=2;
         double new_mul=MabdelbroadProc.zoom2mul(new_zoom,W);
         double new_tp=MabdelbroadProc.py2im(new_mul,Pi,-H/2);
         double new_lf=MabdelbroadProc.px2re(new_mul,Pr,-W/2);
         setData(new_lf,new_tp,new_zoom);
      }
      pressed=notmoved=false;
   }//GEN-LAST:event_BoxMouseReleased

   private void BoxMouseDragged(java.awt.event.MouseEvent evt)//GEN-FIRST:event_BoxMouseDragged
   {//GEN-HEADEREND:event_BoxMouseDragged
      if(pressed)
      {
         int W=img.getWidth();
         int H=img.getHeight();
         double mul=MabdelbroadProc.zoom2mul(zoom,W);
         double new_tp=tp-MabdelbroadProc.py2im(mul,tp,evt.getY())+pressPi;
         double new_lf=lf-MabdelbroadProc.px2re(mul,lf,evt.getX())+pressPr;
         setData(new_lf,new_tp,zoom);
      }
      notmoved=false;
   }//GEN-LAST:event_BoxMouseDragged

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MandelbrotMain().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JPanel Box;
   private javax.swing.JButton BtnCalc;
   private javax.swing.JTextField EdLf;
   private javax.swing.JTextField EdTp;
   private javax.swing.JTextField EdZoom;
   private javax.swing.JLabel LbLf;
   private javax.swing.JLabel LbTp;
   private javax.swing.JLabel LbZoom;
   // End of variables declaration//GEN-END:variables

}
