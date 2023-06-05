public class HarmonicCalcForm extends javax.swing.JFrame 
{
   static final int ThreadCount=4;
   public HarmonicCalcForm() 
   {
      initComponents();
   }
   
   private void AppendText(String text)
   {
      EdLog.append(text + System.lineSeparator());
   }
   
   private void AppendResult(String method, long tm, long count,double result)
   {
      AppendText(String.format("%s %d: %.18f (%.0fms)", method, count, result, (System.nanoTime()-tm)/1000000.0));
   }
   
   private double BaseCalc(long count)
   {
      double sum=0;
      for(long i=1;i<=count;++i) sum+=1.0/i;
      return sum;
   }
   
   private void SimpleCalc(String method)
   {
      try
      {
         long count=Long.parseLong(EdCount.getText());
         AppendResult(method,System.nanoTime(),count,BaseCalc(count));
      }
      catch(Exception e) { AppendText(e.getMessage()); }
   }
   
   private double PartCalc(int start,long count)
   {
      double sum=0;
      for(long i=start+1;i<=count;i+=ThreadCount) sum+=1.0/i;
      return sum;
   }
   
   private double ThreadCalc(long count)
   {
      Thread[] th=new Thread[ThreadCount];
      double[] tb=new double[ThreadCount];
      for(int i=0;i<ThreadCount;++i)
      {
         int start=i; // Zabieg konieczny, lambda nie przyjmie "i"
         th[i]=new Thread(() -> tb[start]=PartCalc(start,count));
         th[i].start();
      }
      for(Thread thread:th) try { thread.join(); } catch(Exception e) {}
      double sum=0;
      for(double part:tb) sum+=part;
      return sum;
   }
   
   private void MultiCalc()
   {
      try
      {
         long count=Long.parseLong(EdCount.getText());
         AppendResult("m",System.nanoTime(),count,ThreadCalc(count));
      }
      catch(Exception e) { AppendText(e.getMessage()); }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdCount = new javax.swing.JTextField();
      BtnMultiThreadCalc = new javax.swing.JButton();
      BtnThreadCalc = new javax.swing.JButton();
      BtnCalc = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Harmoni Sequence Sum ...");

      EdCount.setText("100000000");

      BtnMultiThreadCalc.setText("Multi Thread Calc");
      BtnMultiThreadCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiThreadCalcActionPerformed(evt);
         }
      });

      BtnThreadCalc.setText("Thread Calc");
      BtnThreadCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnThreadCalcActionPerformed(evt);
         }
      });

      BtnCalc.setText("Calc");
      BtnCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnCalcActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdLog.setRows(5);
      jScrollPane1.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 143, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 151, Short.MAX_VALUE)
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
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 289, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMultiThreadCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiThreadCalcActionPerformed
      MultiCalc();
   }//GEN-LAST:event_BtnMultiThreadCalcActionPerformed

   private void BtnThreadCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnThreadCalcActionPerformed
      new Thread(() -> SimpleCalc("t")).start();
   }//GEN-LAST:event_BtnThreadCalcActionPerformed

   private void BtnCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnCalcActionPerformed
      SimpleCalc("s");
   }//GEN-LAST:event_BtnCalcActionPerformed

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
   private javax.swing.JScrollPane jScrollPane1;
   // End of variables declaration//GEN-END:variables
}
