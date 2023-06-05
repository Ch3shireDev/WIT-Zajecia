public class MatrixOperationForm extends javax.swing.JFrame
{
   public MatrixOperationForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      VerticalSplit = new javax.swing.JSplitPane();
      LeftSplit = new javax.swing.JSplitPane();
      EdMatrixAScroll = new javax.swing.JScrollPane();
      EdMatrixA = new javax.swing.JTextArea();
      PnlButtons = new javax.swing.JPanel();
      BtnTest = new javax.swing.JButton();
      BtnMultiply = new javax.swing.JButton();
      BtnGauss = new javax.swing.JButton();
      RightSplit = new javax.swing.JSplitPane();
      EdMatrixBScroll = new javax.swing.JScrollPane();
      EdMatrixB = new javax.swing.JTextArea();
      EdMatrixCScroll = new javax.swing.JScrollPane();
      EdMatrixC = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      VerticalSplit.setDividerLocation(350);

      LeftSplit.setDividerLocation(222);
      LeftSplit.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);
      LeftSplit.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
         public void propertyChange(java.beans.PropertyChangeEvent evt) {
            LeftSplitPropertyChange(evt);
         }
      });

      EdMatrixA.setColumns(20);
      EdMatrixA.setRows(5);
      EdMatrixAScroll.setViewportView(EdMatrixA);

      LeftSplit.setBottomComponent(EdMatrixAScroll);

      BtnTest.setText("Test");

      BtnMultiply.setText("Multiply");

      BtnGauss.setText("Gauss");

      javax.swing.GroupLayout PnlButtonsLayout = new javax.swing.GroupLayout(PnlButtons);
      PnlButtons.setLayout(PnlButtonsLayout);
      PnlButtonsLayout.setHorizontalGroup(
         PnlButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(PnlButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addGroup(PnlButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(BtnMultiply, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(BtnGauss, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(BtnTest, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addContainerGap(266, Short.MAX_VALUE))
      );
      PnlButtonsLayout.setVerticalGroup(
         PnlButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(PnlButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addComponent(BtnTest)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BtnMultiply)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BtnGauss)
            .addContainerGap(129, Short.MAX_VALUE))
      );

      LeftSplit.setLeftComponent(PnlButtons);

      VerticalSplit.setLeftComponent(LeftSplit);

      RightSplit.setDividerLocation(222);
      RightSplit.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);
      RightSplit.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
         public void propertyChange(java.beans.PropertyChangeEvent evt) {
            RightSplitPropertyChange(evt);
         }
      });

      EdMatrixB.setColumns(20);
      EdMatrixB.setRows(5);
      EdMatrixBScroll.setViewportView(EdMatrixB);

      RightSplit.setTopComponent(EdMatrixBScroll);

      EdMatrixC.setColumns(20);
      EdMatrixC.setRows(5);
      EdMatrixCScroll.setViewportView(EdMatrixC);

      RightSplit.setRightComponent(EdMatrixCScroll);

      VerticalSplit.setRightComponent(RightSplit);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addComponent(VerticalSplit, javax.swing.GroupLayout.PREFERRED_SIZE, 737, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGap(0, 0, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addComponent(VerticalSplit, javax.swing.GroupLayout.PREFERRED_SIZE, 480, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGap(0, 0, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void LeftSplitPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_LeftSplitPropertyChange
      RightSplit.setDividerLocation(LeftSplit.getDividerLocation());
   }//GEN-LAST:event_LeftSplitPropertyChange

   private void RightSplitPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_RightSplitPropertyChange
      LeftSplit.setDividerLocation(RightSplit.getDividerLocation());
   }//GEN-LAST:event_RightSplitPropertyChange

   /**
    * @param args the command line arguments
    */
   public static void main(String args[]) {
      /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
       * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
       */
      try {
         for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
            if ("Nimbus".equals(info.getName())) {
               javax.swing.UIManager.setLookAndFeel(info.getClassName());
               break;
            }
         }
      } catch (ClassNotFoundException ex) {
         java.util.logging.Logger.getLogger(MatrixOperationForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(MatrixOperationForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(MatrixOperationForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(MatrixOperationForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
        //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new MatrixOperationForm().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGauss;
   private javax.swing.JButton BtnMultiply;
   private javax.swing.JButton BtnTest;
   private javax.swing.JTextArea EdMatrixA;
   private javax.swing.JScrollPane EdMatrixAScroll;
   private javax.swing.JTextArea EdMatrixB;
   private javax.swing.JScrollPane EdMatrixBScroll;
   private javax.swing.JTextArea EdMatrixC;
   private javax.swing.JScrollPane EdMatrixCScroll;
   private javax.swing.JSplitPane LeftSplit;
   private javax.swing.JPanel PnlButtons;
   private javax.swing.JSplitPane RightSplit;
   private javax.swing.JSplitPane VerticalSplit;
   // End of variables declaration//GEN-END:variables
}
