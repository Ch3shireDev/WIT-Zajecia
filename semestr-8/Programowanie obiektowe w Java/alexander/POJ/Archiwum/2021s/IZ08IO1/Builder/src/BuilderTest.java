
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class BuilderTest extends javax.swing.JFrame
{
   private final IdBuilder ib=new IdBuilder();
   public BuilderTest()
   {
      initComponents();
      txtLog.setText(ib.toString());
      DocumentListener listener=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { delimetrChange(); }
         @Override public void removeUpdate(DocumentEvent e) { delimetrChange(); }
         @Override public void changedUpdate(DocumentEvent e) { delimetrChange(); }
      };
      txtDelimetr.getDocument().addDocumentListener(listener);
   }
   private void delimetrChange()
   {
      ib.setDelimeter(txtDelimetr.getText());
      txtLog.setText(ib.toString());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      txtId = new javax.swing.JTextField();
      txtDelimetr = new javax.swing.JTextField();
      txtIfEmpty = new javax.swing.JTextField();
      btnAppend = new javax.swing.JButton();
      btnClear = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      txtLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      txtId.setText("0");
      txtId.setPreferredSize(new java.awt.Dimension(102, 21));

      txtDelimetr.setText(", ");
      txtDelimetr.setPreferredSize(new java.awt.Dimension(102, 21));

      txtIfEmpty.setText("null");
      txtIfEmpty.setPreferredSize(new java.awt.Dimension(102, 21));

      btnAppend.setText("Append");
      btnAppend.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnAppendActionPerformed(evt);
         }
      });

      btnClear.setText("Clear");
      btnClear.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnClearActionPerformed(evt);
         }
      });

      txtLog.setColumns(20);
      txtLog.setRows(5);
      txtLog.setPreferredSize(new java.awt.Dimension(102, 21));
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
                  .addComponent(txtId, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(txtDelimetr, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(txtIfEmpty, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 106, Short.MAX_VALUE)
                  .addComponent(btnClear)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnAppend)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(txtId, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(txtDelimetr, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(txtIfEmpty, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnAppend)
               .addComponent(btnClear))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 326, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnAppendActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAppendActionPerformed
      long id=Long.parseLong(txtId.getText());
      ib.append(id);
      txtLog.setText(ib.toString());
   }//GEN-LAST:event_btnAppendActionPerformed

   private void btnClearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnClearActionPerformed
      ib.clear();
      txtLog.setText(ib.toString());
   }//GEN-LAST:event_btnClearActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new BuilderTest().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAppend;
   private javax.swing.JButton btnClear;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JTextField txtDelimetr;
   private javax.swing.JTextField txtId;
   private javax.swing.JTextField txtIfEmpty;
   private javax.swing.JTextArea txtLog;
   // End of variables declaration//GEN-END:variables
}
