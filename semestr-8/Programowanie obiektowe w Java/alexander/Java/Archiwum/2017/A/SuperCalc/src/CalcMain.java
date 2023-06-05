import javax.swing.JButton;


public class CalcMain extends javax.swing.JFrame {

   public CalcMain() {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      txtDisplay = new javax.swing.JTextField();
      btnClear = new javax.swing.JButton();
      btnBackspace = new javax.swing.JButton();
      btnDigit7 = new javax.swing.JButton();
      btnDigit8 = new javax.swing.JButton();
      btnDigit9 = new javax.swing.JButton();
      btnOpAdd = new javax.swing.JButton();
      btnDigit4 = new javax.swing.JButton();
      btnDigit5 = new javax.swing.JButton();
      btnDigit6 = new javax.swing.JButton();
      btnOpSub = new javax.swing.JButton();
      btnDigit1 = new javax.swing.JButton();
      btnDigit2 = new javax.swing.JButton();
      btnDigit3 = new javax.swing.JButton();
      btnOpMul = new javax.swing.JButton();
      btnDigit0 = new javax.swing.JButton();
      btnPoint = new javax.swing.JButton();
      btnEq = new javax.swing.JButton();
      btnOpDiv = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Kalkulatorek");

      txtDisplay.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      txtDisplay.setText("0");

      btnClear.setText("C");
      btnClear.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnClearActionPerformed(evt);
         }
      });

      btnBackspace.setText("CE");
      btnBackspace.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnBackspaceActionPerformed(evt);
         }
      });

      btnDigit7.setText("7");
      btnDigit7.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnDigit8.setText("8");
      btnDigit8.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnDigit9.setText("9");
      btnDigit9.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnOpAdd.setText("+");
      btnOpAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnOpActionPerformed(evt);
         }
      });

      btnDigit4.setText("4");
      btnDigit4.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnDigit5.setText("5");
      btnDigit5.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnDigit6.setText("6");
      btnDigit6.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnOpSub.setText("-");
      btnOpSub.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnOpActionPerformed(evt);
         }
      });

      btnDigit1.setText("1");
      btnDigit1.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnDigit2.setText("2");
      btnDigit2.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnDigit3.setText("3");
      btnDigit3.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnOpMul.setText("*");
      btnOpMul.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnOpActionPerformed(evt);
         }
      });

      btnDigit0.setText("0");
      btnDigit0.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnDigitActionPerformed(evt);
         }
      });

      btnPoint.setText(".");
      btnPoint.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnPointActionPerformed(evt);
         }
      });

      btnEq.setText("=");
      btnEq.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnOpActionPerformed(evt);
         }
      });

      btnOpDiv.setText("/");
      btnOpDiv.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnOpActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                  .addGroup(layout.createSequentialGroup()
                     .addComponent(btnClear, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                     .addComponent(btnBackspace, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(btnDigit7, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDigit8, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDigit9, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnOpAdd, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(btnDigit4, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDigit5, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDigit6, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnOpSub, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(btnDigit1, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDigit2, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDigit3, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnOpMul, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(btnDigit0, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnPoint, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnEq, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnOpDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))))
               .addComponent(txtDisplay))
            .addContainerGap(155, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(txtDisplay, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnClear)
               .addComponent(btnBackspace))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnDigit7)
               .addComponent(btnDigit8)
               .addComponent(btnDigit9)
               .addComponent(btnOpAdd))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnDigit4)
               .addComponent(btnDigit5)
               .addComponent(btnDigit6)
               .addComponent(btnOpSub))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnDigit1)
               .addComponent(btnDigit2)
               .addComponent(btnDigit3)
               .addComponent(btnOpMul))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnDigit0)
               .addComponent(btnPoint)
               .addComponent(btnEq)
               .addComponent(btnOpDiv))
            .addContainerGap(14, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnDigitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDigitActionPerformed
      JButton btn=(JButton)evt.getSource();
      String txt=btn.getText();
      if(!NeedClear) txt = txtDisplay.getText()+txt;
      txtDisplay.setText(txt);
      NeedClear = false;
   }//GEN-LAST:event_btnDigitActionPerformed

   private void btnOpActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOpActionPerformed
      JButton btn=(JButton)evt.getSource();
      double Value=Double.parseDouble(txtDisplay.getText());
      switch(Operation)
      {
         case "+": Value=SaveValue+Value; break;
         case "-": Value=SaveValue-Value; break;
         case "*": Value=SaveValue*Value; break;
         case "/": Value=SaveValue/Value; break;
      }
      SaveValue=Value;
      txtDisplay.setText(String.format("%s",SaveValue));
      NeedClear = true;
      Operation=btn.getText();
   }//GEN-LAST:event_btnOpActionPerformed

   private void btnPointActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPointActionPerformed
      String txt;
      if(NeedClear) txt = "0.";
      else if(!txtDisplay.getText().contains(".")) txt=txtDisplay.getText()+".";
      else return;
      txtDisplay.setText(txt);
      NeedClear = false;
   }//GEN-LAST:event_btnPointActionPerformed

   private void btnClearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnClearActionPerformed
      txtDisplay.setText("0");
      NeedClear = true;
   }//GEN-LAST:event_btnClearActionPerformed

   private void btnBackspaceActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBackspaceActionPerformed
      String txt=txtDisplay.getText();
      if(txt.length()>0) txt=txt.substring(0,txt.length()-1);
      if(txt.length()<=0) txt="0";
      txtDisplay.setText(txt);
      NeedClear = true;
   }//GEN-LAST:event_btnBackspaceActionPerformed

   public static void main(String args[]) {
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new CalcMain().setVisible(true);
         }
      });
   }
   
   private boolean NeedClear = true;
   private String Operation = "=";
   private double SaveValue=0;
   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnBackspace;
   private javax.swing.JButton btnClear;
   private javax.swing.JButton btnDigit0;
   private javax.swing.JButton btnDigit1;
   private javax.swing.JButton btnDigit2;
   private javax.swing.JButton btnDigit3;
   private javax.swing.JButton btnDigit4;
   private javax.swing.JButton btnDigit5;
   private javax.swing.JButton btnDigit6;
   private javax.swing.JButton btnDigit7;
   private javax.swing.JButton btnDigit8;
   private javax.swing.JButton btnDigit9;
   private javax.swing.JButton btnEq;
   private javax.swing.JButton btnOpAdd;
   private javax.swing.JButton btnOpDiv;
   private javax.swing.JButton btnOpMul;
   private javax.swing.JButton btnOpSub;
   private javax.swing.JButton btnPoint;
   private javax.swing.JTextField txtDisplay;
   // End of variables declaration//GEN-END:variables
}
