
import java.awt.image.BufferedImage;

public class MandelbrottTest extends javax.swing.JFrame
{
   private static final MandelbrottTheme theme=new MandelbrottThemeStandard();

   public MandelbrottTest()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      PnButtons = new javax.swing.JPanel();
      EdStartRe = new javax.swing.JTextField();
      EdStartIm = new javax.swing.JTextField();
      EdZoom = new javax.swing.JTextField();
      BtnDraw = new javax.swing.JButton();
      PnImage = new ImagePanel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdStartRe.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdStartRe.setText("-2");
      EdStartRe.setMinimumSize(new java.awt.Dimension(150, 20));
      EdStartRe.setPreferredSize(new java.awt.Dimension(150, 20));

      EdStartIm.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdStartIm.setText("1");
      EdStartIm.setMinimumSize(new java.awt.Dimension(150, 20));
      EdStartIm.setPreferredSize(new java.awt.Dimension(150, 20));
      EdStartIm.setRequestFocusEnabled(false);

      EdZoom.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdZoom.setText("1");

      BtnDraw.setText("Draw");
      BtnDraw.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnDrawActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout PnButtonsLayout = new javax.swing.GroupLayout(PnButtons);
      PnButtons.setLayout(PnButtonsLayout);
      PnButtonsLayout.setHorizontalGroup(
         PnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(PnButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addComponent(EdStartRe, javax.swing.GroupLayout.PREFERRED_SIZE, 140, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdStartIm, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdZoom, javax.swing.GroupLayout.PREFERRED_SIZE, 127, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 219, Short.MAX_VALUE)
            .addComponent(BtnDraw)
            .addContainerGap())
      );
      PnButtonsLayout.setVerticalGroup(
         PnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(PnButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addGroup(PnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdStartRe, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(EdStartIm, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(EdZoom, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDraw))
            .addGap(8, 8, 8))
      );

      javax.swing.GroupLayout PnImageLayout = new javax.swing.GroupLayout(PnImage);
      PnImage.setLayout(PnImageLayout);
      PnImageLayout.setHorizontalGroup(
         PnImageLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 683, Short.MAX_VALUE)
      );
      PnImageLayout.setVerticalGroup(
         PnImageLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 423, Short.MAX_VALUE)
      );

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(PnButtons, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
         .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
               .addContainerGap()
               .addComponent(PnImage, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addContainerGap()))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addComponent(PnButtons, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap(444, Short.MAX_VALUE))
         .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
               .addContainerGap(52, Short.MAX_VALUE)
               .addComponent(PnImage, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addContainerGap()))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnDrawActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDrawActionPerformed
      int height=PnImage.getHeight();
      int width=PnImage.getWidth();
      double Si=Double.parseDouble(EdStartIm.getText());
      double Sr=Double.parseDouble(EdStartRe.getText());
      double scale=3/(width*Double.parseDouble(EdZoom.getText()));
      BufferedImage img=MandelbrottFragment.makeImage(theme,width,height,Si,Sr,scale);
      ((ImagePanel)PnImage).setImage(img);
   }//GEN-LAST:event_BtnDrawActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(()->new MandelbrottTest().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnDraw;
   private javax.swing.JTextField EdStartIm;
   private javax.swing.JTextField EdStartRe;
   private javax.swing.JTextField EdZoom;
   private javax.swing.JPanel PnButtons;
   private ImagePanel PnImage;
   // End of variables declaration//GEN-END:variables
}
