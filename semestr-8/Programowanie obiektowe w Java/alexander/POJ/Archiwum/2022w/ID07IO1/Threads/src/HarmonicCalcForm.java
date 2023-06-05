
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class HarmonicCalcForm extends javax.swing.JFrame
{
   private long count=3000000000L;
   public HarmonicCalcForm()
   {
      initComponents();
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustCount(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustCount(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustCount(); }
      };
      tfCount.getDocument().addDocumentListener(listener);
      tfCount.setText(Long.toString(count));
   }

   private void adjustCount()
   {
      boolean ok=false;
      try
      {
         count=Long.parseLong(tfCount.getText());
         ok=true;
      }
      catch(Exception ex) {}
      btnCalcSimple.setEnabled(ok);
      btnCalcThread.setEnabled(ok);
      btnCalcMulti.setEnabled(ok);
      btnCalcSmart.setEnabled(ok);
   }

   private void Log(String method,long count,double result)
   {
      taLog.append(String.format("%s: %d => %.18f",method,count,result)+System.lineSeparator());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      tfCount = new javax.swing.JTextField();
      btnCalcSimple = new javax.swing.JButton();
      taLogScroll = new javax.swing.JScrollPane();
      taLog = new javax.swing.JTextArea();
      btnCalcThread = new javax.swing.JButton();
      btnCalcMulti = new javax.swing.JButton();
      btnCalcSmart = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      btnCalcSimple.setText("Simple");
      btnCalcSimple.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnCalcSimpleActionPerformed(evt);
         }
      });

      taLog.setColumns(20);
      taLog.setRows(5);
      taLogScroll.setViewportView(taLog);

      btnCalcThread.setText("Thread");
      btnCalcThread.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnCalcThreadActionPerformed(evt);
         }
      });

      btnCalcMulti.setText("Multi");
      btnCalcMulti.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnCalcMultiActionPerformed(evt);
         }
      });

      btnCalcSmart.setText("Smart");
      btnCalcSmart.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnCalcSmartActionPerformed(evt);
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
                  .addComponent(tfCount, javax.swing.GroupLayout.PREFERRED_SIZE, 139, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 104, Short.MAX_VALUE)
                  .addComponent(btnCalcSmart)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnCalcMulti)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnCalcThread)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnCalcSimple)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(tfCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnCalcSimple)
               .addComponent(btnCalcThread)
               .addComponent(btnCalcMulti)
               .addComponent(btnCalcSmart))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 273, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnCalcSimpleActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnCalcSimpleActionPerformed
   {//GEN-HEADEREND:event_btnCalcSimpleActionPerformed
      new SimpleCalc(count,this::Log);
      //new SimpleCalc(count,(method,count,result) -> Log(method,count,result));
   }//GEN-LAST:event_btnCalcSimpleActionPerformed

   private void btnCalcThreadActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnCalcThreadActionPerformed
   {//GEN-HEADEREND:event_btnCalcThreadActionPerformed
      new ThreadCalc(count,this::Log);
   }//GEN-LAST:event_btnCalcThreadActionPerformed

   private void btnCalcMultiActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnCalcMultiActionPerformed
   {//GEN-HEADEREND:event_btnCalcMultiActionPerformed
      new MultiCalc(count,this::Log);
   }//GEN-LAST:event_btnCalcMultiActionPerformed

   private void btnCalcSmartActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnCalcSmartActionPerformed
   {//GEN-HEADEREND:event_btnCalcSmartActionPerformed
      new SmartCalc(count,this::Log);
   }//GEN-LAST:event_btnCalcSmartActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new HarmonicCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnCalcMulti;
   private javax.swing.JButton btnCalcSimple;
   private javax.swing.JButton btnCalcSmart;
   private javax.swing.JButton btnCalcThread;
   private javax.swing.JTextArea taLog;
   private javax.swing.JScrollPane taLogScroll;
   private javax.swing.JTextField tfCount;
   // End of variables declaration//GEN-END:variables
}
