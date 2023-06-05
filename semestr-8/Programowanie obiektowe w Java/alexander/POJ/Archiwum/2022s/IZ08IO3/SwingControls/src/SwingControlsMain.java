
import java.awt.Color;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

interface InterfaceX
{
   public void x(double value);
}

public class SwingControlsMain extends javax.swing.JFrame
{
   private double valueA,valueB;
   public SwingControlsMain()
   {
      initComponents();
      tfValueA.setBackground(Color.white);
      tfValueB.setBackground(Color.white);
      DocumentListener listenerA=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e)  { checkA(); }
         @Override public void removeUpdate(DocumentEvent e)  { checkA(); }
         @Override public void changedUpdate(DocumentEvent e) { checkA(); }
      };
      tfValueA.getDocument().addDocumentListener(listenerA);
      DocumentListener listenerB=new DocumentListener()
      {
         @Override public void insertUpdate(DocumentEvent e)  { checkB(); }
         @Override public void removeUpdate(DocumentEvent e)  { checkB(); }
         @Override public void changedUpdate(DocumentEvent e) { checkB(); }
      };
      tfValueB.getDocument().addDocumentListener(listenerB);
      InterfaceX ixa=this::xx;
      InterfaceX ixb=(v) -> xx(v);
      InterfaceX ixc=new InterfaceX()
      {
         @Override public void x(double value) { xx(value); }
      };
   }

   private void xx(double value)
   {
      tfValueResult.setText(Double.toString(value));
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      tfValueA = new javax.swing.JTextField();
      btnCalculate = new javax.swing.JButton();
      tfValueB = new javax.swing.JTextField();
      tfValueResult = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      tfValueA.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfValueA.setText("0");

      btnCalculate.setText("Policz");
      btnCalculate.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnCalculateActionPerformed(evt);
         }
      });

      tfValueB.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfValueB.setText("0");

      tfValueResult.setEditable(false);
      tfValueResult.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      tfValueResult.setText("0");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(tfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(tfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(btnCalculate)
               .addComponent(tfValueResult, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(441, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(tfValueA, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(tfValueB, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(btnCalculate)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(tfValueResult, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap(263, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void checkA()
   {
      try
      {
         valueA=Double.parseDouble(tfValueA.getText());
         tfValueA.setBackground(Color.white);
      }
      catch(Exception e)
      {
         tfValueA.setBackground(Color.yellow);
      }
      btnCalculate.setEnabled((tfValueA.getBackground()==Color.white) && (tfValueB.getBackground()==Color.white));
   }

   private void checkB()
   {
      try
      {
         valueB=Double.parseDouble(tfValueB.getText());
         tfValueB.setBackground(Color.white);
      }
      catch(Exception e)
      {
         tfValueB.setBackground(Color.yellow);
      }
      btnCalculate.setEnabled((tfValueA.getBackground()==Color.white) && (tfValueB.getBackground()==Color.white));
   }

   private void btnCalculateActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnCalculateActionPerformed
   {//GEN-HEADEREND:event_btnCalculateActionPerformed
      tfValueResult.setText(Double.toString(valueA+valueB));
   }//GEN-LAST:event_btnCalculateActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new SwingControlsMain().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnCalculate;
   private javax.swing.JTextField tfValueA;
   private javax.swing.JTextField tfValueB;
   private javax.swing.JTextField tfValueResult;
   // End of variables declaration//GEN-END:variables
}
