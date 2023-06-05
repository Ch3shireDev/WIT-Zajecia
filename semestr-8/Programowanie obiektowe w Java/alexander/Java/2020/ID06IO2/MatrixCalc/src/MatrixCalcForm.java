public class MatrixCalcForm extends javax.swing.JFrame
{
   public MatrixCalcForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdMatrixBScroll = new javax.swing.JScrollPane();
      EdMatrixB = new javax.swing.JTextArea();
      EdMatrixAScroll = new javax.swing.JScrollPane();
      EdMatrixA = new javax.swing.JTextArea();
      EdMatrixCScroll = new javax.swing.JScrollPane();
      EdMatrixC = new javax.swing.JTextArea();
      BtnMultiply = new javax.swing.JButton();
      BtnGauss = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdMatrixB.setColumns(20);
      EdMatrixB.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      EdMatrixB.setRows(5);
      EdMatrixB.setText("62,9\t20,7\t28,4\t60,3\n55,5\t4\t60,6\t13,9\n83,2\t45,4\t81,1\t98,8\n35,9\t88,2\t11,1\t68,3\n");
      EdMatrixBScroll.setViewportView(EdMatrixB);

      EdMatrixA.setColumns(20);
      EdMatrixA.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      EdMatrixA.setRows(5);
      EdMatrixA.setText("48,6\t72,1\t25,8\t21,8\n49,8\t22,9\t83,4\t45,7\n6,3\t47,4\t8,2\t42,1\n12,1\t16,6\t99,1\t70,7\n");
      EdMatrixAScroll.setViewportView(EdMatrixA);

      EdMatrixC.setColumns(20);
      EdMatrixC.setRows(5);
      EdMatrixCScroll.setViewportView(EdMatrixC);

      BtnMultiply.setText("Multiply");
      BtnMultiply.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiplyActionPerformed(evt);
         }
      });

      BtnGauss.setText("Gauss");
      BtnGauss.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnGaussActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdMatrixAScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 276, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnMultiply)
               .addComponent(BtnGauss))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdMatrixBScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 299, Short.MAX_VALUE)
               .addComponent(EdMatrixCScroll))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdMatrixBScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 167, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnMultiply)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnGauss)
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(EdMatrixAScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 199, Short.MAX_VALUE)
               .addComponent(EdMatrixCScroll))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMultiplyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiplyActionPerformed
      Matrix A = new Matrix(EdMatrixA.getText());
      Matrix B = new Matrix(EdMatrixB.getText());
      Matrix C = Matrix.Multiply(A, B);
      EdMatrixC.setText(C.toString());
   }//GEN-LAST:event_BtnMultiplyActionPerformed

   private void BtnGaussActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGaussActionPerformed
      Matrix A = new Matrix(EdMatrixA.getText());
      Matrix C = new Matrix(EdMatrixC.getText());
      Matrix B = Matrix.Gauss(A, C);
      EdMatrixB.setText(B.toString());
   }//GEN-LAST:event_BtnGaussActionPerformed

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
   // End of variables declaration//GEN-END:variables
}
