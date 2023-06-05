public class MatrixCalcForm extends javax.swing.JFrame
{
   public MatrixCalcForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      SplVertical = new javax.swing.JSplitPane();
      SplRight = new javax.swing.JSplitPane();
      EdMatrixBScroll = new javax.swing.JScrollPane();
      EdMatrixB = new javax.swing.JTextArea();
      EdMatrixCScroll = new javax.swing.JScrollPane();
      EdMatrixC = new javax.swing.JTextArea();
      SplLeft = new javax.swing.JSplitPane();
      EdMatrixAScroll = new javax.swing.JScrollPane();
      EdMatrixA = new javax.swing.JTextArea();
      PnlButtons = new javax.swing.JPanel();
      BtnGauss = new javax.swing.JButton();
      BtnMultiply = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      SplVertical.setDividerLocation(300);

      SplRight.setDividerLocation(200);
      SplRight.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);
      SplRight.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
         public void propertyChange(java.beans.PropertyChangeEvent evt) {
            SplRightPropertyChange(evt);
         }
      });

      EdMatrixB.setColumns(20);
      EdMatrixB.setRows(5);
      EdMatrixBScroll.setViewportView(EdMatrixB);

      SplRight.setTopComponent(EdMatrixBScroll);

      EdMatrixC.setColumns(20);
      EdMatrixC.setRows(5);
      EdMatrixCScroll.setViewportView(EdMatrixC);

      SplRight.setRightComponent(EdMatrixCScroll);

      SplVertical.setRightComponent(SplRight);

      SplLeft.setDividerLocation(200);
      SplLeft.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);
      SplLeft.setDebugGraphicsOptions(javax.swing.DebugGraphics.NONE_OPTION);
      SplLeft.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
         public void propertyChange(java.beans.PropertyChangeEvent evt) {
            SplLeftPropertyChange(evt);
         }
      });

      EdMatrixA.setColumns(20);
      EdMatrixA.setRows(5);
      EdMatrixAScroll.setViewportView(EdMatrixA);

      SplLeft.setBottomComponent(EdMatrixAScroll);

      BtnGauss.setText("Gauss");
      BtnGauss.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnGaussActionPerformed(evt);
         }
      });

      BtnMultiply.setText("Multiply");
      BtnMultiply.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiplyActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout PnlButtonsLayout = new javax.swing.GroupLayout(PnlButtons);
      PnlButtons.setLayout(PnlButtonsLayout);
      PnlButtonsLayout.setHorizontalGroup(
         PnlButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(PnlButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addGroup(PnlButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(BtnMultiply, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnGauss, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(203, Short.MAX_VALUE))
      );
      PnlButtonsLayout.setVerticalGroup(
         PnlButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(PnlButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addComponent(BtnMultiply)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BtnGauss)
            .addContainerGap(136, Short.MAX_VALUE))
      );

      SplLeft.setTopComponent(PnlButtons);

      SplVertical.setLeftComponent(SplLeft);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(SplVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 581, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(SplVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 372, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMultiplyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiplyActionPerformed
      Matrix A = new Matrix(EdMatrixA.getText());
      Matrix B = new Matrix(EdMatrixB.getText());
      EdMatrixC.setText(Matrix.multiply(A, B).toString());
   }//GEN-LAST:event_BtnMultiplyActionPerformed

   private void BtnGaussActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGaussActionPerformed
      Matrix A = new Matrix(EdMatrixA.getText());
      Matrix C = new Matrix(EdMatrixC.getText());
      EdMatrixB.setText(Matrix.gauss(A, C).toString());
   }//GEN-LAST:event_BtnGaussActionPerformed

   private void SplLeftPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_SplLeftPropertyChange
      SplRight.setDividerLocation(SplLeft.getDividerLocation());
   }//GEN-LAST:event_SplLeftPropertyChange

   private void SplRightPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_SplRightPropertyChange
      SplLeft.setDividerLocation(SplRight.getDividerLocation());
   }//GEN-LAST:event_SplRightPropertyChange

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater(() -> new MatrixCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGauss;
   private javax.swing.JButton BtnMultiply;
   private javax.swing.JTextArea EdMatrixA;
   private javax.swing.JScrollPane EdMatrixAScroll;
   private javax.swing.JTextArea EdMatrixB;
   private javax.swing.JScrollPane EdMatrixBScroll;
   private javax.swing.JTextArea EdMatrixC;
   private javax.swing.JScrollPane EdMatrixCScroll;
   private javax.swing.JPanel PnlButtons;
   private javax.swing.JSplitPane SplLeft;
   private javax.swing.JSplitPane SplRight;
   private javax.swing.JSplitPane SplVertical;
   // End of variables declaration//GEN-END:variables
}
