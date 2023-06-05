
import java.io.InputStream;
import java.io.StringReader;
import java.util.Scanner;

public class IterableMatrix extends javax.swing.JFrame {

   public IterableMatrix() 
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      LogScroll = new javax.swing.JScrollPane();
      Log = new javax.swing.JTextArea();
      BtnTest = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      Log.setColumns(20);
      Log.setRows(5);
      LogScroll.setViewportView(Log);

      BtnTest.setText("Test");
      BtnTest.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnTestActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 406, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(BtnTest)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnTest)
                  .addGap(0, 0, Short.MAX_VALUE))
               .addComponent(LogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 278, Short.MAX_VALUE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnTestActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnTestActionPerformed
      Scanner sc=new Scanner(new StringReader(Log.getText()));
      int rows=sc.nextInt(),cols=sc.nextInt();
      Matrix m=new Matrix(rows, cols);
      for(Matrix.Cell i:m) i.set(sc.nextDouble());
      StringBuffer sb=new StringBuffer();
      sb.append(System.lineSeparator()).append(System.lineSeparator());
      for(Matrix.Cell y:m.rows())
      {
         for(Matrix.Cell x:y.cols())
         {
            sb.append(x.get()).append("\t");
         }
         sb.append(System.lineSeparator());
      }
      sb.append(System.lineSeparator()).append(System.lineSeparator());
      for(Matrix.Cell x:m.cols())
      {
         for(Matrix.Cell y:x.rows())
         {
            sb.append(y.get()).append("\t");
         }
         sb.append(System.lineSeparator());
      }
      Log.append(sb.toString());
      /*
      3 4
      10 11 12 13    14 15 16 17   18 19 20 21
      */
   }//GEN-LAST:event_BtnTestActionPerformed

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
         java.util.logging.Logger.getLogger(IterableMatrix.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(IterableMatrix.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(IterableMatrix.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(IterableMatrix.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new IterableMatrix().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnTest;
   private javax.swing.JTextArea Log;
   private javax.swing.JScrollPane LogScroll;
   // End of variables declaration//GEN-END:variables
}
