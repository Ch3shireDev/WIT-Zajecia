
import java.awt.Color;
import java.awt.SystemColor;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public class CalcutorMain extends javax.swing.JFrame
{
   public CalcutorMain()
   {
      initComponents();
      DocumentListener listenerA=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { CheckValueA(); }
         @Override public void removeUpdate(DocumentEvent e) { CheckValueA(); }
         @Override public void changedUpdate(DocumentEvent e) { CheckValueA(); }
      };
      TfValueA.getDocument().addDocumentListener(listenerA);
      DocumentListener listenerB=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e) { CheckValueB(); }
         @Override public void removeUpdate(DocumentEvent e) { CheckValueB(); }
         @Override public void changedUpdate(DocumentEvent e) { CheckValueB(); }
      };
      TfValueB.getDocument().addDocumentListener(listenerB);
   }

   private void AdjustButton()
   {
      BtnCalculate.setEnabled
      (
         (TfValueA.getBackground()==SystemColor.window)
         &&
         (TfValueB.getBackground()==SystemColor.window)
      );
   }

   private void CheckValueA()
   {
      try
      {
         Double.parseDouble(TfValueA.getText());
         TfValueA.setBackground(SystemColor.window);
      }
      catch(Exception ex)
      {
         TfValueA.setBackground(Color.yellow);
      }
      AdjustButton();
   }

   private void CheckValueB()
   {
      try
      {
         Double.parseDouble(TfValueB.getText());
         TfValueB.setBackground(SystemColor.window);
      }
      catch(Exception ex)
      {
         TfValueB.setBackground(Color.yellow);
      }
      AdjustButton();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      TfValueA = new javax.swing.JTextField();
      TfResult = new javax.swing.JTextField();
      BtnCalculate = new javax.swing.JButton();
      TfValueB = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      TfValueA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TfValueA.setText("16");

      TfResult.setEditable(false);
      TfResult.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TfResult.setText("0");

      BtnCalculate.setText("Calc");
      BtnCalculate.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnCalculateActionPerformed(evt);
         }
      });

      TfValueB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TfValueB.setText("2");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(20, 20, 20)
            .addComponent(TfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(TfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 172, Short.MAX_VALUE)
            .addComponent(BtnCalculate)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(TfResult, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(20, 20, 20)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(TfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(TfResult, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnCalculate)
               .addComponent(TfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(64, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnCalculateActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnCalculateActionPerformed
   {//GEN-HEADEREND:event_BtnCalculateActionPerformed
      double a=Double.parseDouble(TfValueA.getText());
      double b=Double.parseDouble(TfValueB.getText());
      TfResult.setText(Double.toString(a+b));
   }//GEN-LAST:event_BtnCalculateActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new CalcutorMain().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnCalculate;
   private javax.swing.JTextField TfResult;
   private javax.swing.JTextField TfValueA;
   private javax.swing.JTextField TfValueB;
   // End of variables declaration//GEN-END:variables
}
