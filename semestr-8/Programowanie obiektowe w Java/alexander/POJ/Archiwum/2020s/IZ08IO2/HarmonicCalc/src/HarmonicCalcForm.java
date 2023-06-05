public class HarmonicCalcForm extends javax.swing.JFrame
{
   private static final int MaxThreadCount=4;
   public HarmonicCalcForm()
   {
      initComponents();
   }
   
   private void appendText(String text)
   {
      EdLog.append(text + System.lineSeparator());
   }
   
   private void appendResult(String method,long count, double sum)
   {
      appendText(String.format("%s %d %.18f", method, count, sum));
   }
   
   private double calc(long count) //  1/1 1/2 1/3 ... 1/count
   {
      double sum=0;
      for(long i=1;i<=count;++i) sum+=1D/i;
      return sum;
   }
   
   private double calcPart(int start,long count) //  1/1 1/2 1/3 ... 1/count
   {
      double sum=0;
      for(long i=start+1;i<=count;i+=MaxThreadCount) sum+=1D/i;
      return sum;
   }
   
   private void calcAndShow(String method)
   {
      try
      {
         long count=Long.parseLong(EdCount.getText());
         appendResult(method, count, calc(count));
      }
      catch(Exception e)
      {
         appendText(e.getMessage());
      }
   }

   private void multiCalcAndShow()
   {
      try
      {
         long count=Long.parseLong(EdCount.getText());
         Thread[] threads=new Thread[MaxThreadCount];
         double[] parts=new double[MaxThreadCount];
         for(int i=0;i<MaxThreadCount;++i)
         {
            final int start=i;
            threads[i]=new Thread(() -> parts[start]=calcPart(start, count));
         }
         for(Thread thread:threads) thread.start();
         for(Thread thread:threads) thread.join();
         double sum=0;
         for(double part:parts) sum+=part;
         appendResult("m", count, sum);
      }
      catch(Exception e)
      {
         appendText(e.getMessage());
      }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdCount = new javax.swing.JTextField();
      BtnCalc = new javax.swing.JButton();
      BtnThreadCalc = new javax.swing.JButton();
      BtnMultiThreadCalc = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdCount.setText("100000000");

      BtnCalc.setText("Calc");
      BtnCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnCalcActionPerformed(evt);
         }
      });

      BtnThreadCalc.setText("Thread Calc");
      BtnThreadCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnThreadCalcActionPerformed(evt);
         }
      });

      BtnMultiThreadCalc.setText("Multi Thread Calc");
      BtnMultiThreadCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiThreadCalcActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setFont(new java.awt.Font("Lucida Console", 1, 12)); // NOI18N
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 24, Short.MAX_VALUE)
                  .addComponent(BtnMultiThreadCalc)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnThreadCalc)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnCalc)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnCalc)
               .addComponent(BtnThreadCalc)
               .addComponent(BtnMultiThreadCalc))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnCalcActionPerformed
      calcAndShow("s");
   }//GEN-LAST:event_BtnCalcActionPerformed

   private void BtnThreadCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnThreadCalcActionPerformed
      new Thread(() -> calcAndShow("t")).start();
   }//GEN-LAST:event_BtnThreadCalcActionPerformed

   private void BtnMultiThreadCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiThreadCalcActionPerformed
      new Thread(() -> multiCalcAndShow()).start();
   }//GEN-LAST:event_BtnMultiThreadCalcActionPerformed

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater(() -> new HarmonicCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalc;
   private javax.swing.JButton BtnMultiThreadCalc;
   private javax.swing.JButton BtnThreadCalc;
   private javax.swing.JTextField EdCount;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   // End of variables declaration//GEN-END:variables
}
