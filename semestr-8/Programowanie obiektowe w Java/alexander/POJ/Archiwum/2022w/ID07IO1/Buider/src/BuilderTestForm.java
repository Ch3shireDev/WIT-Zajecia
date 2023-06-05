
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class BuilderTestForm extends javax.swing.JFrame
{
   private long Id;
   private final IdBuilder ib=new IdBuilder();
   public BuilderTestForm()
   {
      initComponents();
      ActionListener al=new ActionListener()
      {
         @Override public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnAddActionPerformed(evt);
         }
      };
      btnAdd.addActionListener(al);
      DocumentListener dl=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { tfIdTextChanged(); }
         @Override public void removeUpdate(DocumentEvent e) { tfIdTextChanged(); }
         @Override public void changedUpdate(DocumentEvent e) { tfIdTextChanged(); }
      };
      tfId.getDocument().addDocumentListener(dl);
      tfId.setText("0");
   }

   private void tfIdTextChanged()
   {
      try
      {
         Id=Long.parseLong(tfId.getText());
         btnAdd.setEnabled(true);
      }
      catch(Exception ex)
      {
         btnAdd.setEnabled(false);
      }
   }

   private void showIb()
   {
      taLog.append("LIST: "+ib.toString()+System.lineSeparator());
   }

   private void btnAddActionPerformed(ActionEvent evt)
   {
      ib.add(Id);
      showIb();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      tfId = new javax.swing.JTextField();
      btnAdd = new javax.swing.JButton();
      taLogScroll = new javax.swing.JScrollPane();
      taLog = new javax.swing.JTextArea();
      btnClear = new javax.swing.JButton();
      btnRemove = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      btnAdd.setText("Dodaj");

      taLog.setColumns(20);
      taLog.setRows(5);
      taLogScroll.setViewportView(taLog);

      btnClear.setText("Wyczyść");
      btnClear.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnClearActionPerformed(evt);
         }
      });

      btnRemove.setText("Usuń");
      btnRemove.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnRemoveActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 543, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(tfId, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnRemove)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnClear)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(tfId, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnAdd)
               .addComponent(btnClear)
               .addComponent(btnRemove))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(taLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 323, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnClearActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnClearActionPerformed
   {//GEN-HEADEREND:event_btnClearActionPerformed
      ib.clear();
      showIb();
   }//GEN-LAST:event_btnClearActionPerformed

   private void btnRemoveActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnRemoveActionPerformed
   {//GEN-HEADEREND:event_btnRemoveActionPerformed
      ib.remove(Id);
      showIb();
   }//GEN-LAST:event_btnRemoveActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new BuilderTestForm().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAdd;
   private javax.swing.JButton btnClear;
   private javax.swing.JButton btnRemove;
   private javax.swing.JTextArea taLog;
   private javax.swing.JScrollPane taLogScroll;
   private javax.swing.JTextField tfId;
   // End of variables declaration//GEN-END:variables
}
