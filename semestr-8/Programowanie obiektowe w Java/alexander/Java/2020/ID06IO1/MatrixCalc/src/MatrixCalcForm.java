public class MatrixCalcForm extends javax.swing.JFrame 
{

   public MatrixCalcForm() 
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      MatrixAScroll = new javax.swing.JScrollPane();
      MatrixA = new javax.swing.JTextArea();
      MatrixBScroll = new javax.swing.JScrollPane();
      MatrixB = new javax.swing.JTextArea();
      MatrixCScroll = new javax.swing.JScrollPane();
      MatrixC = new javax.swing.JTextArea();
      BtnTest = new javax.swing.JButton();
      BtnMultiply = new javax.swing.JButton();
      BtnGauss = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      MatrixA.setColumns(20);
      MatrixA.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixA.setRows(5);
      MatrixA.setText("8\t6\t5\t2\t8\t4\n2\t2\t1\t5\t1\t8\n10\t1\t2\t9\t1\t4\n9\t8\t5\t0\t5\t5\n7\t9\t5\t8\t6\t5\n7\t6\t3\t4\t8\t2\n");
      MatrixAScroll.setViewportView(MatrixA);

      MatrixB.setColumns(20);
      MatrixB.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixB.setRows(5);
      MatrixB.setText("7\t2\t9\t5\t7\t8\n7\t6\t9\t3\t3\t5\n10\t9\t4\t5\t3\t0\n8\t7\t10\t9\t1\t3\n5\t8\t0\t5\t10\t6\n7\t7\t8\t6\t6\t3\n");
      MatrixBScroll.setViewportView(MatrixB);

      MatrixC.setColumns(20);
      MatrixC.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      MatrixC.setRows(5);
      MatrixCScroll.setViewportView(MatrixC);

      BtnTest.setText("Test");
      BtnTest.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnTestActionPerformed(evt);
         }
      });

      BtnMultiply.setText("Multiply");
      BtnMultiply.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiplyActionPerformed(evt);
         }
      });

      BtnGauss.setText("Gaus");
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
               .addComponent(BtnTest)
               .addComponent(BtnMultiply)
               .addComponent(BtnGauss)
               .addComponent(MatrixAScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 344, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(MatrixCScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 426, Short.MAX_VALUE)
               .addComponent(MatrixBScroll))
            .addGap(18, 18, 18))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(MatrixBScroll)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnTest)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMultiply)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnGauss)
                  .addGap(94, 94, 94)))
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(MatrixCScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 152, Short.MAX_VALUE)
               .addComponent(MatrixAScroll))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnTestActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnTestActionPerformed
      MatrixC.setText(Matrix.parseMatrix(MatrixA.getText()).toString());
   }//GEN-LAST:event_BtnTestActionPerformed

   private void BtnMultiplyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiplyActionPerformed
      Matrix a=Matrix.parseMatrix(MatrixA.getText());
      Matrix b=Matrix.parseMatrix(MatrixB.getText());
      Matrix c=Matrix.multiply(a, b);
      MatrixC.setText(c.toString());
   }//GEN-LAST:event_BtnMultiplyActionPerformed

   private void BtnGaussActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGaussActionPerformed
      Matrix a=Matrix.parseMatrix(MatrixA.getText());
      Matrix c=Matrix.parseMatrix(MatrixC.getText());
      Matrix b=Matrix.gauss(a, c);
      MatrixB.setText(b.toString());
   }//GEN-LAST:event_BtnGaussActionPerformed

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater(() -> new MatrixCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGauss;
   private javax.swing.JButton BtnMultiply;
   private javax.swing.JButton BtnTest;
   private javax.swing.JTextArea MatrixA;
   private javax.swing.JScrollPane MatrixAScroll;
   private javax.swing.JTextArea MatrixB;
   private javax.swing.JScrollPane MatrixBScroll;
   private javax.swing.JTextArea MatrixC;
   private javax.swing.JScrollPane MatrixCScroll;
   // End of variables declaration//GEN-END:variables
}
