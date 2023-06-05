package matrixoperation;

public class MatrixOperation extends javax.swing.JFrame {

   public MatrixOperation() {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jScrollPane1 = new javax.swing.JScrollPane();
      TbC = new javax.swing.JTextArea();
      jScrollPane2 = new javax.swing.JScrollPane();
      TbB = new javax.swing.JTextArea();
      jScrollPane3 = new javax.swing.JScrollPane();
      TbA = new javax.swing.JTextArea();
      BtnInv = new javax.swing.JButton();
      BtnAdd = new javax.swing.JButton();
      BtnSub = new javax.swing.JButton();
      BtnMul = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      TbC.setColumns(20);
      TbC.setRows(5);
      jScrollPane1.setViewportView(TbC);

      TbB.setColumns(20);
      TbB.setRows(5);
      jScrollPane2.setViewportView(TbB);

      TbA.setColumns(20);
      TbA.setRows(5);
      jScrollPane3.setViewportView(TbA);

      BtnInv.setText("inv");
      BtnInv.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnInvActionPerformed(evt);
         }
      });

      BtnAdd.setText("add");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      BtnSub.setText("sub");
      BtnSub.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSubActionPerformed(evt);
         }
      });

      BtnMul.setText("mul");
      BtnMul.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMulActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 254, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 269, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 253, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(BtnInv)
                     .addComponent(BtnAdd)
                     .addComponent(BtnSub)
                     .addComponent(BtnMul))))
            .addContainerGap(18, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 206, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 207, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 206, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnInv)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnSub)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMul)))
            .addContainerGap(22, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnInvActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnInvActionPerformed
      TbC.setText(Matrix.toString(Matrix.inv(Matrix.fromString(TbA.getText()))));
   }//GEN-LAST:event_BtnInvActionPerformed

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      TbC.setText(Matrix.toString(Matrix.add(Matrix.fromString(TbA.getText()),Matrix.fromString(TbB.getText()))));
   }//GEN-LAST:event_BtnAddActionPerformed

   private void BtnSubActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSubActionPerformed
      TbC.setText(Matrix.toString(Matrix.sub(Matrix.fromString(TbA.getText()),Matrix.fromString(TbB.getText()))));
   }//GEN-LAST:event_BtnSubActionPerformed

   private void BtnMulActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMulActionPerformed
      TbC.setText(Matrix.toString(Matrix.mul(Matrix.fromString(TbA.getText()),Matrix.fromString(TbB.getText()))));
   }//GEN-LAST:event_BtnMulActionPerformed

   public static void main(String args[]) {
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new MatrixOperation().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnInv;
   private javax.swing.JButton BtnMul;
   private javax.swing.JButton BtnSub;
   private javax.swing.JTextArea TbA;
   private javax.swing.JTextArea TbB;
   private javax.swing.JTextArea TbC;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JScrollPane jScrollPane3;
   // End of variables declaration//GEN-END:variables
}
