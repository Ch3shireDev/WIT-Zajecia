public class MatrixCalcForm extends javax.swing.JFrame 
{
   public MatrixCalcForm() 
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jScrollPane1 = new javax.swing.JScrollPane();
      EdMatrixA = new javax.swing.JTextArea();
      jScrollPane2 = new javax.swing.JScrollPane();
      EdMatrixB = new javax.swing.JTextArea();
      jScrollPane3 = new javax.swing.JScrollPane();
      EdMatrixC = new javax.swing.JTextArea();
      BtnMultiply = new javax.swing.JButton();
      BtnGauss = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdMatrixA.setColumns(20);
      EdMatrixA.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      EdMatrixA.setRows(5);
      EdMatrixA.setText("2\t9\t5\t1\t0\n2\t9\t4\t8\t10\n9\t10\t3\t4\t7\n6\t1\t9\t4\t9\n");
      jScrollPane1.setViewportView(EdMatrixA);

      EdMatrixB.setColumns(20);
      EdMatrixB.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      EdMatrixB.setRows(5);
      EdMatrixB.setText("3\t0\t5\t1\t4\t4\n7\t7\t0\t1\t0\t3\n2\t7\t2\t4\t1\t9\n3\t7\t5\t10\t3\t5\n5\t7\t2\t7\t2\t1\n");
      jScrollPane2.setViewportView(EdMatrixB);

      EdMatrixC.setColumns(20);
      EdMatrixC.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      EdMatrixC.setRows(5);
      jScrollPane3.setViewportView(EdMatrixC);

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
               .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 295, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnMultiply)
               .addComponent(BtnGauss))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 395, Short.MAX_VALUE)
               .addComponent(jScrollPane3))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 135, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnMultiply)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnGauss)
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 200, Short.MAX_VALUE)
               .addComponent(jScrollPane3))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMultiplyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiplyActionPerformed
      Matrix a=Matrix.parseMatrix(EdMatrixA.getText());
      Matrix b=Matrix.parseMatrix(EdMatrixB.getText());
      Matrix c=Matrix.multiply(a, b);
      EdMatrixC.setText(c.toString());
   }//GEN-LAST:event_BtnMultiplyActionPerformed

   private void BtnGaussActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGaussActionPerformed
      Matrix a=Matrix.parseMatrix(EdMatrixA.getText());
      Matrix c=Matrix.parseMatrix(EdMatrixC.getText());
      Matrix b=Matrix.gauss(a, c);
      EdMatrixB.setText(b.toString());
   }//GEN-LAST:event_BtnGaussActionPerformed

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater(() -> new MatrixCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGauss;
   private javax.swing.JButton BtnMultiply;
   private javax.swing.JTextArea EdMatrixA;
   private javax.swing.JTextArea EdMatrixB;
   private javax.swing.JTextArea EdMatrixC;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JScrollPane jScrollPane3;
   // End of variables declaration//GEN-END:variables
}
