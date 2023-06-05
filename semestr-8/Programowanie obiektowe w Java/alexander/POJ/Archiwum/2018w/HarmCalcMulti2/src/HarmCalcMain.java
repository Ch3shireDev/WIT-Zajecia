import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;


public class HarmCalcMain extends javax.swing.JFrame
{
   private static int UseThreads=3;
   private final Lock sync=new ReentrantLock();
   public HarmCalcMain()
   {
      initComponents();
      getRootPane().setDefaultButton(BtnCalc);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      EdCount = new javax.swing.JTextField();
      BtnCalc = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      EdResult = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdCount.setText("1000000000");

      BtnCalc.setText("Calc");
      BtnCalc.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnCalcActionPerformed(evt);
         }
      });

      EdResult.setEditable(false);
      EdResult.setColumns(20);
      EdResult.setRows(5);
      jScrollPane1.setViewportView(EdResult);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnCalc)
                  .addGap(0, 222, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnCalc))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void AddResult(String text)
   {
      sync.lock();
      try
      {
         EdResult.append(text+System.lineSeparator());
      }
      finally { sync.unlock(); }
   }

   private void BtnCalcActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnCalcActionPerformed
   {//GEN-HEADEREND:event_BtnCalcActionPerformed
      final String inp=EdCount.getText();
      try
      {
         long count=Long.parseLong(inp);
         DoubleSender sender=new DoubleSender()
         {
            public double sum=0;
            private int count=UseThreads;
            private final Lock lock=new ReentrantLock();
            @Override public void done(double part)
            {
               lock.lock();
               try
               {
                  sum+=part;
                  if((--count)==0) AddResult(inp+" -> "+sum);
               }
               finally { lock.unlock(); }
            }
         };
         for(int i=0;i<UseThreads;++i) HarmThread.go(i+1,UseThreads,count,sender);
      }
      catch(NumberFormatException e)
      {
         AddResult(inp+" -> Error");
      }
      EdCount.selectAll();
      EdCount.requestFocus();
   }//GEN-LAST:event_BtnCalcActionPerformed

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
         java.util.logging.Logger.getLogger(HarmCalcMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(HarmCalcMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(HarmCalcMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(HarmCalcMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      java.awt.EventQueue.invokeLater(() -> new HarmCalcMain().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalc;
   private javax.swing.JTextField EdCount;
   private javax.swing.JTextArea EdResult;
   private javax.swing.JScrollPane jScrollPane1;
   // End of variables declaration//GEN-END:variables
}
