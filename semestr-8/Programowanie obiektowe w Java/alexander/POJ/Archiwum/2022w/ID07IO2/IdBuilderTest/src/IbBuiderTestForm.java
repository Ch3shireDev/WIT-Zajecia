
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class IbBuiderTestForm extends javax.swing.JFrame
{
   private long id=0;
   private final IdBuilder ib=new IdBuilder();
   public IbBuiderTestForm()
   {
      initComponents();
      DocumentListener dl=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { tfIdChanged(); }
         @Override public void removeUpdate(DocumentEvent e) { tfIdChanged(); }
         @Override public void changedUpdate(DocumentEvent e) { tfIdChanged(); }
      };
      tfId.getDocument().addDocumentListener(dl);
      tfId.setText(""+id);
   }

   private void tfIdChanged()
   {
      try
      {
         id=Long.parseLong(tfId.getText());
         btnAdd.setEnabled(true);
         btnRemove.setEnabled(true);
      }
      catch(Exception e)
      {
         btnAdd.setEnabled(false);
         btnRemove.setEnabled(false);
      }
   }

   private void appendIb()
   {

      taLog.append("LIST: "+ib.toString()+System.lineSeparator());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      tfId = new javax.swing.JTextField();
      btnclear = new javax.swing.JButton();
      btnRemove = new javax.swing.JButton();
      btnAdd = new javax.swing.JButton();
      taLogScroll = new javax.swing.JScrollPane();
      taLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      btnclear.setText("Clear");
      btnclear.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnclearActionPerformed(evt);
         }
      });

      btnRemove.setText("Remove");
      btnRemove.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnRemoveActionPerformed(evt);
         }
      });

      btnAdd.setText("Add");
      btnAdd.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnAddActionPerformed(evt);
         }
      });

      taLog.setColumns(20);
      taLog.setRows(5);
      taLogScroll.setViewportView(taLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(taLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(tfId, javax.swing.GroupLayout.PREFERRED_SIZE, 171, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 104, Short.MAX_VALUE)
                  .addComponent(btnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnRemove)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnclear)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(tfId, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnclear)
               .addComponent(btnRemove)
               .addComponent(btnAdd))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 325, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnAddActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnAddActionPerformed
   {//GEN-HEADEREND:event_btnAddActionPerformed
      ib.add(id);
      appendIb();
   }//GEN-LAST:event_btnAddActionPerformed

   private void btnRemoveActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnRemoveActionPerformed
   {//GEN-HEADEREND:event_btnRemoveActionPerformed
      ib.remove(id);
      appendIb();
   }//GEN-LAST:event_btnRemoveActionPerformed

   private void btnclearActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnclearActionPerformed
   {//GEN-HEADEREND:event_btnclearActionPerformed
      ib.clear();
      appendIb();
   }//GEN-LAST:event_btnclearActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new IbBuiderTestForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAdd;
   private javax.swing.JButton btnRemove;
   private javax.swing.JButton btnclear;
   private javax.swing.JTextArea taLog;
   private javax.swing.JScrollPane taLogScroll;
   private javax.swing.JTextField tfId;
   // End of variables declaration//GEN-END:variables
}
