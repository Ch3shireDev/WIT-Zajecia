

public class MatrixForm extends javax.swing.JFrame {

   public MatrixForm() {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jScrollPane1 = new javax.swing.JScrollPane();
      MatrixA = new javax.swing.JTextArea();
      jScrollPane2 = new javax.swing.JScrollPane();
      MatrixC = new javax.swing.JTextArea();
      jScrollPane3 = new javax.swing.JScrollPane();
      MatrixB = new javax.swing.JTextArea();
      BtnAdd = new javax.swing.JButton();
      BtnSub = new javax.swing.JButton();
      BtnMul = new javax.swing.JButton();
      BtnSolve = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      MatrixA.setColumns(20);
      MatrixA.setFont(new java.awt.Font("Lucida Console", 0, 10)); // NOI18N
      MatrixA.setRows(5);
      jScrollPane1.setViewportView(MatrixA);

      MatrixC.setColumns(20);
      MatrixC.setFont(new java.awt.Font("Lucida Console", 0, 10)); // NOI18N
      MatrixC.setRows(5);
      jScrollPane2.setViewportView(MatrixC);

      MatrixB.setColumns(20);
      MatrixB.setFont(new java.awt.Font("Lucida Console", 0, 10)); // NOI18N
      MatrixB.setRows(5);
      jScrollPane3.setViewportView(MatrixB);

      BtnAdd.setText("Add");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      BtnSub.setText("Sub");
      BtnSub.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSubActionPerformed(evt);
         }
      });

      BtnMul.setText("Mul");
      BtnMul.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMulActionPerformed(evt);
         }
      });

      BtnSolve.setText("Slove");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 376, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnSub))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnMul)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnSolve)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 368, Short.MAX_VALUE)
               .addComponent(jScrollPane2))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnAdd)
                     .addComponent(BtnSub))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                     .addComponent(BtnMul)
                     .addComponent(BtnSolve))
                  .addGap(0, 0, Short.MAX_VALUE))
               .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 175, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
               .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 225, Short.MAX_VALUE)
               .addComponent(jScrollPane1))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      try
      {
         Matrix a=Matrix.parseMatrix(MatrixA.getText());
         Matrix b=Matrix.parseMatrix(MatrixB.getText());
         MatrixC.setText(Matrix.add(a,b).toString());
      }
      catch(Exception ex)
      {
         MatrixC.setText(ex.getMessage());
      }
   }//GEN-LAST:event_BtnAddActionPerformed

   private void BtnSubActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSubActionPerformed
      try
      {
         Matrix a=Matrix.parseMatrix(MatrixA.getText());
         Matrix b=Matrix.parseMatrix(MatrixB.getText());
         MatrixC.setText(Matrix.sub(a,b).toString());
      }
      catch(Exception ex)
      {
         MatrixC.setText(ex.getMessage());
      }
   }//GEN-LAST:event_BtnSubActionPerformed

   private void BtnMulActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMulActionPerformed
      try
      {
         Matrix a=Matrix.parseMatrix(MatrixA.getText());
         Matrix b=Matrix.parseMatrix(MatrixB.getText());
         MatrixC.setText(Matrix.mul(a,b).toString());
      }
      catch(Exception ex)
      {
         MatrixC.setText(ex.getMessage());
      }
   }//GEN-LAST:event_BtnMulActionPerformed

   public static void main(String args[]) {
      java.awt.EventQueue.invokeLater(() -> new MatrixForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnMul;
   private javax.swing.JButton BtnSolve;
   private javax.swing.JButton BtnSub;
   private javax.swing.JTextArea MatrixA;
   private javax.swing.JTextArea MatrixB;
   private javax.swing.JTextArea MatrixC;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JScrollPane jScrollPane3;
   // End of variables declaration//GEN-END:variables
}
