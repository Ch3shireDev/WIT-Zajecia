
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class HarmonicCalcForm extends javax.swing.JFrame
{
   private long count=100000000;
   public HarmonicCalcForm()
   {
      initComponents();
      txtCount.setText(""+count);
      DocumentListener dl=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { adjustButton(); }
         @Override public void removeUpdate(DocumentEvent e) { adjustButton(); }
         @Override public void changedUpdate(DocumentEvent e) { adjustButton(); }
      };
      txtCount.getDocument().addDocumentListener(dl);
   }

   public void adjustButton()
   {
      boolean goodValue=false;
      try
      {
         count=Long.parseLong(txtCount.getText());
         goodValue=true;
      }
      catch(Exception ex) {}
      btnCalc.setEnabled(goodValue);
   }

   public void appendLog(String method,long count,double sum)
   {
      txtLog.append(String.format("%s => %9d: %.18f", method,count,sum)+System.lineSeparator());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      cbMethod = new javax.swing.JComboBox();
      txtCount = new javax.swing.JTextField();
      btnCalc = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      txtLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      btnCalc.setText("Calc");
      btnCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnCalcActionPerformed(evt);
         }
      });

      txtLog.setColumns(20);
      txtLog.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
      txtLog.setRows(5);
      jScrollPane1.setViewportView(txtLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbMethod, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(txtCount, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 501, Short.MAX_VALUE)
                  .addComponent(btnCalc)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(cbMethod, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(txtCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnCalc))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCalcActionPerformed
      new HarmonicCalcSimple(count,this::appendLog).calc();
      new HarmonicCalcThread(count,this::appendLog).calc();
      new HarmonicCalcMulti(count,this::appendLog).calc();
      new HarmonicCalcAsync(count,this::appendLog).calc();
   }//GEN-LAST:event_btnCalcActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new HarmonicCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnCalc;
   private javax.swing.JComboBox cbMethod;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JTextField txtCount;
   private javax.swing.JTextArea txtLog;
   // End of variables declaration//GEN-END:variables
}
