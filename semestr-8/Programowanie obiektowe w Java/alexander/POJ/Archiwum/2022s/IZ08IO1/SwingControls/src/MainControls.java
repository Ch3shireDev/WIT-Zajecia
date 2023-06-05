
import java.awt.Color;
import javax.swing.JTextField;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class MainControls extends javax.swing.JFrame
{
   public MainControls()
   {
      initComponents();
      DocumentListener listenerA=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e)   { check(tfA); }
         @Override public void removeUpdate(DocumentEvent e)   { check(tfA); }
         @Override public void changedUpdate(DocumentEvent e)  { check(tfA); }
      };
      tfA.getDocument().addDocumentListener(listenerA);
      DocumentListener listenerB=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e)   { check(tfB); }
         @Override public void removeUpdate(DocumentEvent e)   { check(tfB); }
         @Override public void changedUpdate(DocumentEvent e)  { check(tfB); }
      };
      tfB.getDocument().addDocumentListener(listenerB);
      check(tfA);
      check(tfB);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      tfB = new javax.swing.JTextField();
      btnCalculate = new javax.swing.JButton();
      tfA = new javax.swing.JTextField();
      tfResult = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      tfB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfB.setText("0");

      btnCalculate.setText("Policz");
      btnCalculate.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnCalculateActionPerformed(evt);
         }
      });

      tfA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfA.setText("0");

      tfResult.setEditable(false);
      tfResult.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfResult.setText("0");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(tfA, javax.swing.GroupLayout.PREFERRED_SIZE, 73, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 250, Short.MAX_VALUE)
                  .addComponent(btnCalculate))
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(tfB, javax.swing.GroupLayout.PREFERRED_SIZE, 73, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(tfResult, javax.swing.GroupLayout.PREFERRED_SIZE, 73, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnCalculate)
               .addComponent(tfA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(tfB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(tfResult, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap(237, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void check(JTextField tf)
   {
      try
      {
         Double.parseDouble(tf.getText());
         tf.setBackground(Color.white);
      }
      catch(Exception e)
      {
         tf.setBackground(Color.yellow);
      }
      btnCalculate.setEnabled((tfA.getBackground()==Color.white)&&(tfB.getBackground()==Color.white));
   }

   private void btnCalculateActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnCalculateActionPerformed
   {//GEN-HEADEREND:event_btnCalculateActionPerformed
      try
      {
         double a=Double.parseDouble(tfA.getText());
         try
         {
            double b=Double.parseDouble(tfB.getText());
            tfResult.setText(Double.toString(a+b));
         }
         catch(Exception e)
         {
            tfResult.setText("Błąd B");
         }
      }
      catch(Exception e)
      {
         tfResult.setText("Błąd A");
      }
   }//GEN-LAST:event_btnCalculateActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new MainControls().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnCalculate;
   private javax.swing.JTextField tfA;
   private javax.swing.JTextField tfB;
   private javax.swing.JTextField tfResult;
   // End of variables declaration//GEN-END:variables
}
