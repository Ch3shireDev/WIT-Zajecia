package calculator;

import java.util.HashMap;
import javax.swing.JButton;
import java.text.DecimalFormat;

public class CalculatorForm extends javax.swing.JFrame {

   private static final String NOP="=";
   private static final DecimalFormat df=new DecimalFormat("#.##################");
   private boolean NeedReset=true;
   private double SaveValue=0,OldValue=0;
   private String Operation=NOP,OldOperation=NOP;
   private final HashMap<String,JButton> buttonmap=new HashMap<>();
   private static final HashMap<String,OperationProc> map=mapmake();
   private static HashMap<String,OperationProc> mapmake()
   {
      final HashMap<String,OperationProc> tmp=new HashMap<>();
      tmp.put("+", (double a,double b) -> { return a+b; } );
      tmp.put("-", (double a,double b) -> { return a-b; } );
      tmp.put("*", (double a,double b) -> { return a*b; } );
      tmp.put("/", new OperationProc() { public @Override double proc(double a,double b) { return a/b; } } );
      return tmp;
   }
   private static boolean isNOP(String str) { return str.equals(NOP); }
   
   public CalculatorForm() {
      initComponents();
      buttonmap.put("+", BtnOprAdd);
      buttonmap.put("-", BtnOprSub);
      buttonmap.put("*", BtnOprMul);
      buttonmap.put("/", BtnOprDiv);
      buttonmap.put("0", BtnDig0);
      buttonmap.put("1", BtnDig1);
      buttonmap.put("2", BtnDig2);
      buttonmap.put("3", BtnDig3);
      buttonmap.put("4", BtnDig4);
      buttonmap.put("5", BtnDig5);
      buttonmap.put("6", BtnDig6);
      buttonmap.put("7", BtnDig7);
      buttonmap.put("8", BtnDig8);
      buttonmap.put("9", BtnDig9);
      buttonmap.put(".", BtnPoint);
      buttonmap.put(",", BtnPoint);
      buttonmap.put("\b", BtnBackspace);
      buttonmap.put("\377", BtnReset);
      buttonmap.put("=", BtnOprReturn);
      buttonmap.put("\n", BtnOprReturn);
      buttonmap.put("(", BtnParOp);
      buttonmap.put(")", BtnParCl);
      Display.requestFocus();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      Display = new javax.swing.JTextField();
      BtnDig7 = new javax.swing.JButton();
      BtnDig8 = new javax.swing.JButton();
      BtnDig9 = new javax.swing.JButton();
      BtnBackspace = new javax.swing.JButton();
      BtnReset = new javax.swing.JButton();
      BtnDig4 = new javax.swing.JButton();
      BtnDig5 = new javax.swing.JButton();
      BtnDig6 = new javax.swing.JButton();
      BtnOprAdd = new javax.swing.JButton();
      BtnOprSub = new javax.swing.JButton();
      BtnDig1 = new javax.swing.JButton();
      BtnDig2 = new javax.swing.JButton();
      BtnDig3 = new javax.swing.JButton();
      BtnOprMul = new javax.swing.JButton();
      BtnOprDiv = new javax.swing.JButton();
      BtnPoint = new javax.swing.JButton();
      BtnDig0 = new javax.swing.JButton();
      BtnOprReturn = new javax.swing.JButton();
      BtnParOp = new javax.swing.JButton();
      BtnParCl = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Kalkulator ...");
      setLocation(new java.awt.Point(0, 0));
      setLocationByPlatform(true);
      setResizable(false);

      Display.setEditable(false);
      Display.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      Display.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      Display.setText("0");
      Display.addKeyListener(new java.awt.event.KeyAdapter() {
         public void keyPressed(java.awt.event.KeyEvent evt) {
            DisplayKeyPressed(evt);
         }
      });

      BtnDig7.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig7.setText("7");
      BtnDig7.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnDig8.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig8.setText("8");
      BtnDig8.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnDig9.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig9.setText("9");
      BtnDig9.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnBackspace.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnBackspace.setText("<=");
      BtnBackspace.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnBackspaceActionPerformed(evt);
         }
      });

      BtnReset.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnReset.setText("C");
      BtnReset.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnResetActionPerformed(evt);
         }
      });

      BtnDig4.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig4.setText("4");
      BtnDig4.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnDig5.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig5.setText("5");
      BtnDig5.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnDig6.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig6.setText("6");
      BtnDig6.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnOprAdd.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnOprAdd.setText("+");
      BtnOprAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnOprActionPerformed(evt);
         }
      });

      BtnOprSub.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnOprSub.setText("-");
      BtnOprSub.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnOprActionPerformed(evt);
         }
      });

      BtnDig1.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig1.setText("1");
      BtnDig1.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnDig2.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig2.setText("2");
      BtnDig2.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnDig3.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig3.setText("3");
      BtnDig3.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnOprMul.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnOprMul.setText("*");
      BtnOprMul.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnOprActionPerformed(evt);
         }
      });

      BtnOprDiv.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnOprDiv.setText("/");
      BtnOprDiv.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnOprActionPerformed(evt);
         }
      });

      BtnPoint.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnPoint.setText(".");
      BtnPoint.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnPointActionPerformed(evt);
         }
      });

      BtnDig0.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnDig0.setText("0");
      BtnDig0.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtbDigActionPerformed(evt);
         }
      });

      BtnOprReturn.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnOprReturn.setText("=");
      BtnOprReturn.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnOprActionPerformed(evt);
         }
      });

      BtnParOp.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnParOp.setText("(");

      BtnParCl.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
      BtnParCl.setText(")");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(Display)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnDig7, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig8, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig9, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnBackspace, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnReset, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnDig1, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig2, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig3, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnOprMul, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnOprDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnPoint, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig0, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnOprReturn, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnParOp, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnParCl, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(BtnDig4, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig5, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnDig6, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnOprAdd, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnOprSub, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)))
                  .addGap(0, 0, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(Display, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnDig7, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig8, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig9, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnBackspace, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnReset, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnDig4, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig5, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig6, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnOprAdd, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnOprSub, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnDig1, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig2, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig3, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnOprMul, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnOprDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnPoint, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnDig0, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnOprReturn, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnParOp, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnParCl, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtbDigActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtbDigActionPerformed
      JButton btn=(JButton)evt.getSource();
      String text=Display.getText();
      String digit=btn.getText();
      Display.setText(((NeedReset || text.equals("0"))?"":text)+digit);
      NeedReset=false;
      Display.requestFocus();
   }//GEN-LAST:event_BtbDigActionPerformed

   private void BtnOprActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnOprActionPerformed
      JButton btn=(JButton)evt.getSource();
      String CurrOperation=btn.getText();
      double CurrValue;
      if(NeedReset&&(isNOP(CurrOperation))) CurrValue=OldValue;
      else CurrValue=Double.parseDouble(Display.getText());
      if((isNOP(Operation))&&(isNOP(CurrOperation))) Operation=OldOperation;
      if(map.containsKey(Operation))
      {
         OldValue=CurrValue;
         CurrValue=map.get(Operation).proc(SaveValue, CurrValue);
         Display.setText(df.format(CurrValue).replace(",","."));
      }
      NeedReset=true;
      SaveValue=CurrValue;
      Operation=CurrOperation;
      if(!isNOP(Operation)) OldOperation=Operation;
      Display.requestFocus();
   }//GEN-LAST:event_BtnOprActionPerformed

   private void BtnResetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnResetActionPerformed
      NeedReset=true;
      SaveValue=OldValue=0;
      Operation=OldOperation="=";
      Display.setText("0");
      Display.requestFocus();
   }//GEN-LAST:event_BtnResetActionPerformed

   private void BtnBackspaceActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnBackspaceActionPerformed
      if(!NeedReset)
      {
         String text=Display.getText();
         int len=text.length();
         if(len>1) Display.setText(text.substring(0,len-1));
         else Display.setText("0");
      }
      Display.requestFocus();
   }//GEN-LAST:event_BtnBackspaceActionPerformed

   private void DisplayKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_DisplayKeyPressed
      String key=""+evt.getKeyChar();
      if(buttonmap.containsKey(key))
      {
         buttonmap.get(key).doClick(100);
      }
   }//GEN-LAST:event_DisplayKeyPressed

   private void BtnPointActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnPointActionPerformed
      String text=Display.getText();
      Display.setText((NeedReset?"0":text.replace(".", ""))+".");
      NeedReset=false;
      Display.requestFocus();
   }//GEN-LAST:event_BtnPointActionPerformed

   /**
    * @param args the command line arguments
    */
   public static void main(String args[]) {
      /* Set the Nimbus look and feel */
      //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
      /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
       */
      try {
         for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
            if ("Nimbus".equals(info.getName())) {
               javax.swing.UIManager.setLookAndFeel(info.getClassName());
               break;
            }
         }
      } catch (ClassNotFoundException ex) {
         java.util.logging.Logger.getLogger(CalculatorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(CalculatorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(CalculatorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(CalculatorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new CalculatorForm().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnBackspace;
   private javax.swing.JButton BtnDig0;
   private javax.swing.JButton BtnDig1;
   private javax.swing.JButton BtnDig2;
   private javax.swing.JButton BtnDig3;
   private javax.swing.JButton BtnDig4;
   private javax.swing.JButton BtnDig5;
   private javax.swing.JButton BtnDig6;
   private javax.swing.JButton BtnDig7;
   private javax.swing.JButton BtnDig8;
   private javax.swing.JButton BtnDig9;
   private javax.swing.JButton BtnOprAdd;
   private javax.swing.JButton BtnOprDiv;
   private javax.swing.JButton BtnOprMul;
   private javax.swing.JButton BtnOprReturn;
   private javax.swing.JButton BtnOprSub;
   private javax.swing.JButton BtnParCl;
   private javax.swing.JButton BtnParOp;
   private javax.swing.JButton BtnPoint;
   private javax.swing.JButton BtnReset;
   private javax.swing.JTextField Display;
   // End of variables declaration//GEN-END:variables
}

interface OperationProc
{
   double proc(double a,double b);
}