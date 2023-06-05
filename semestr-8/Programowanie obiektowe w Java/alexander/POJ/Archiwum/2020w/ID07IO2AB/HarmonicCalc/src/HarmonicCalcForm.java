
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class HarmonicCalcForm extends javax.swing.JFrame
{
   private long Count;
   public HarmonicCalcForm()
   {
      initComponents();
      DocumentListener dl=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { CountChanged(); }
         @Override public void removeUpdate(DocumentEvent e) { CountChanged(); }
         @Override public void changedUpdate(DocumentEvent e) { CountChanged(); }
      };
      EdCount.getDocument().addDocumentListener(dl);
      CountChanged();
   }

   private void CountChanged()
   {
      boolean ok=false;
      try
      {
         Count=Long.parseLong(EdCount.getText());
         ok=true;
      }
      catch(Exception ex) {}
      BtnSimple.setEnabled(ok);
      BtnThread.setEnabled(ok);
      BtnMulti.setEnabled(ok);
   }
   private void Done(long count,double sum,String method)
   {
      EdLogArea.append(String.format("%15d %21.18f %s",count,sum,method)+System.lineSeparator());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdCount = new javax.swing.JTextField();
      BtnSimple = new javax.swing.JButton();
      BtnMulti = new javax.swing.JButton();
      BtnThread = new javax.swing.JButton();
      EdLogAreaScroll = new javax.swing.JScrollPane();
      EdLogArea = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdCount.setText("10000000000");

      BtnSimple.setText("Simple");
      BtnSimple.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSimpleActionPerformed(evt);
         }
      });

      BtnMulti.setText("Multi");

      BtnThread.setText("Thread");

      EdLogArea.setColumns(20);
      EdLogArea.setRows(5);
      EdLogAreaScroll.setViewportView(EdLogArea);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogAreaScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 102, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 211, Short.MAX_VALUE)
                  .addComponent(BtnMulti)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnThread)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnSimple)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnSimple)
               .addComponent(BtnMulti)
               .addComponent(BtnThread))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogAreaScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnSimpleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSimpleActionPerformed
      new HarmonicCalcSimple(Count,this::Done).sum();
      //new HarmonicCalcSimple(Count,(count,sum,method) -> Done(count,sum,method)).sum();
   }//GEN-LAST:event_BtnSimpleActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new HarmonicCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnMulti;
   private javax.swing.JButton BtnSimple;
   private javax.swing.JButton BtnThread;
   private javax.swing.JTextField EdCount;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JScrollPane EdLogAreaScroll;
   // End of variables declaration//GEN-END:variables
}
