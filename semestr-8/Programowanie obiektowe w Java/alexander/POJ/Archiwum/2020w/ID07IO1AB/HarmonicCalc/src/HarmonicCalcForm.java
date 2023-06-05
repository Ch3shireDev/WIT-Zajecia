
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
         @Override public void insertUpdate(DocumentEvent e) { dochange(); }
         @Override public void removeUpdate(DocumentEvent e) { dochange(); }
         @Override public void changedUpdate(DocumentEvent e) { dochange(); }
      };
      EdCount.getDocument().addDocumentListener(dl);
      dochange();
      getRootPane().setDefaultButton(BtnCalc);
   }
   private void dochange()
   {
      try
      {
         Count=Long.parseLong(EdCount.getText());
         BtnCalc.setEnabled(true);
      }
      catch(Exception ex)
      {
         BtnCalc.setEnabled(false);
      }
   }

   private void AppendLog(String text)
   {
      EdLogArea.append(text+System.lineSeparator());
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdCount = new javax.swing.JTextField();
      BtnCalc = new javax.swing.JButton();
      EdLogAreaScroll = new javax.swing.JScrollPane();
      EdLogArea = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdCount.setText("10000000");

      BtnCalc.setText("Calc");
      BtnCalc.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnCalcActionPerformed(evt);
         }
      });

      EdLogArea.setColumns(20);
      EdLogArea.setFont(new java.awt.Font("Lucida Console", 0, 14)); // NOI18N
      EdLogArea.setRows(5);
      EdLogAreaScroll.setViewportView(EdLogArea);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdCount, javax.swing.GroupLayout.PREFERRED_SIZE, 129, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 196, Short.MAX_VALUE)
                  .addComponent(BtnCalc))
               .addComponent(EdLogAreaScroll))
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
            .addComponent(EdLogAreaScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void DoneEvent(long Count,double sum)
   {
      AppendLog(String.format("%15d: %21.18f",Count,sum));
   }

   private void BtnCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnCalcActionPerformed
//      new HarmonicCalcSimple(Count,(sum)->DoneEvent(sum)).Sum();
      new HarmonicCalcSimple(Count,this::DoneEvent).Sum();
   }//GEN-LAST:event_BtnCalcActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new HarmonicCalcForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalc;
   private javax.swing.JTextField EdCount;
   private javax.swing.JTextArea EdLogArea;
   private javax.swing.JScrollPane EdLogAreaScroll;
   // End of variables declaration//GEN-END:variables
}
