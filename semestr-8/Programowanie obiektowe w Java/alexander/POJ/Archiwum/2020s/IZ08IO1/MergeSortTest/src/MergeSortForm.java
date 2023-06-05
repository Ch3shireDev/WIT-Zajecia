public class MergeSortForm extends javax.swing.JFrame 
{
   public MergeSortForm() 
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdSourceScroll = new javax.swing.JScrollPane();
      EdSource = new javax.swing.JTextArea();
      EdResultScroll = new javax.swing.JScrollPane();
      EdResult = new javax.swing.JTextArea();
      BtnGenerate = new javax.swing.JButton();
      BtnSort = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdSource.setColumns(20);
      EdSource.setRows(5);
      EdSourceScroll.setViewportView(EdSource);

      EdResult.setColumns(20);
      EdResult.setRows(5);
      EdResultScroll.setViewportView(EdResult);

      BtnGenerate.setText("Generate");
      BtnGenerate.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnGenerateActionPerformed(evt);
         }
      });

      BtnSort.setText("Sort");
      BtnSort.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSortActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(EdResultScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 156, Short.MAX_VALUE)
               .addComponent(BtnGenerate, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 219, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(BtnSort, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(EdSourceScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 156, Short.MAX_VALUE))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(EdResultScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 450, Short.MAX_VALUE)
               .addComponent(EdSourceScroll))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnGenerate)
               .addComponent(BtnSort))
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnGenerateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGenerateActionPerformed
      // TODO add your handling code here:
   }//GEN-LAST:event_BtnGenerateActionPerformed

   private void BtnSortActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSortActionPerformed
      // TODO add your handling code here:
   }//GEN-LAST:event_BtnSortActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MergeSortForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGenerate;
   private javax.swing.JButton BtnSort;
   private javax.swing.JTextArea EdResult;
   private javax.swing.JScrollPane EdResultScroll;
   private javax.swing.JTextArea EdSource;
   private javax.swing.JScrollPane EdSourceScroll;
   // End of variables declaration//GEN-END:variables
}
