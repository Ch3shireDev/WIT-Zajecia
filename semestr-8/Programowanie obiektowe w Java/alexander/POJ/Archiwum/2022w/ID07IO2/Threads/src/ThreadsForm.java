
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class ThreadsForm extends javax.swing.JFrame
{
   private long count=1000000000L;
   public ThreadsForm()
   {
      initComponents();
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustButtons(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustButtons(); }
      };
      tfCount.getDocument().addDocumentListener(listener);
      tfCount.setText(Long.toString(count)); // ""+count
   }

   private void adjustButtons()
   {
      boolean ok=false;
      try
      {
         count=Long.parseLong(tfCount.getText());
         ok=true;
      }
      catch(Exception ex) {}
      btnSimple.setEnabled(ok);
   }

   private void appendLog(String method,long count,double result)
   {
      taLog.append(String.format("%s: %d -> %.18f%s",method,count,result,System.lineSeparator()));
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      tfCount = new javax.swing.JTextField();
      btnSimple = new javax.swing.JButton();
      taLogScroll = new javax.swing.JScrollPane();
      taLog = new javax.swing.JTextArea();
      btnThread = new javax.swing.JButton();
      btnMulti = new javax.swing.JButton();
      btnSmart = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      tfCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfCount.setText("0");

      btnSimple.setText("Simple");
      btnSimple.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnSimpleActionPerformed(evt);
         }
      });

      taLog.setColumns(20);
      taLog.setRows(5);
      taLogScroll.setViewportView(taLog);

      btnThread.setText("Thread");
      btnThread.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnThreadActionPerformed(evt);
         }
      });

      btnMulti.setText("Multi");
      btnMulti.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnMultiActionPerformed(evt);
         }
      });

      btnSmart.setText("Smart");
      btnSmart.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnSmartActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(taLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(tfCount, javax.swing.GroupLayout.PREFERRED_SIZE, 113, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 219, Short.MAX_VALUE)
                  .addComponent(btnSmart)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnMulti)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnThread)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnSimple)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(tfCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnSimple)
               .addComponent(btnThread)
               .addComponent(btnMulti)
               .addComponent(btnSmart))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 286, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnSimpleActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnSimpleActionPerformed
   {//GEN-HEADEREND:event_btnSimpleActionPerformed
      new SimpleCalc(count,this::appendLog);
      //new SimpleCalc(count,(method,count,result) -> appendLog(method,count,result));
   }//GEN-LAST:event_btnSimpleActionPerformed

   private void btnThreadActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnThreadActionPerformed
   {//GEN-HEADEREND:event_btnThreadActionPerformed
      new ThreadCalc(count,this::appendLog);
   }//GEN-LAST:event_btnThreadActionPerformed

   private void btnMultiActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnMultiActionPerformed
   {//GEN-HEADEREND:event_btnMultiActionPerformed
      new MultiCalc(count,this::appendLog);
   }//GEN-LAST:event_btnMultiActionPerformed

   private void btnSmartActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnSmartActionPerformed
   {//GEN-HEADEREND:event_btnSmartActionPerformed
      new SmartCalc(count,this::appendLog);
   }//GEN-LAST:event_btnSmartActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new ThreadsForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnMulti;
   private javax.swing.JButton btnSimple;
   private javax.swing.JButton btnSmart;
   private javax.swing.JButton btnThread;
   private javax.swing.JTextArea taLog;
   private javax.swing.JScrollPane taLogScroll;
   private javax.swing.JTextField tfCount;
   // End of variables declaration//GEN-END:variables
}
