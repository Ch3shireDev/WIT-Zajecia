package main;

import java.awt.Component;
import javax.swing.JButton;

public class MainForm extends javax.swing.JFrame {

    private double SavedValue;
    private boolean NeedClear;
    private String Operation;
    private static final int DisplaySize=17;
    
    public MainForm() {
        initComponents();
        setTitle("Kalkulator");
        setResizable(false);
        Panel.requestFocusInWindow();
        SavedValue=0;
        NeedClear=true;
        Operation="";
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        BtnDigit7 = new javax.swing.JButton();
        BtnDigit8 = new javax.swing.JButton();
        BtnDigit9 = new javax.swing.JButton();
        BtnOpDiv = new javax.swing.JButton();
        BtnBack = new javax.swing.JButton();
        BtnDigit4 = new javax.swing.JButton();
        BtnDigit5 = new javax.swing.JButton();
        BtnDigit6 = new javax.swing.JButton();
        BtnOpMul = new javax.swing.JButton();
        BtnClear = new javax.swing.JButton();
        BtnDigit1 = new javax.swing.JButton();
        BtnDigit2 = new javax.swing.JButton();
        BtnDigit3 = new javax.swing.JButton();
        BtnOpSub = new javax.swing.JButton();
        BtnDigit0 = new javax.swing.JButton();
        BtnPoint = new javax.swing.JButton();
        BtnOpAdd = new javax.swing.JButton();
        BtnEnter = new javax.swing.JButton();
        Panel = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                formKeyTyped(evt);
            }
        });

        BtnDigit7.setText("7");
        BtnDigit7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnDigit8.setText("8");
        BtnDigit8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnDigit9.setText("9");
        BtnDigit9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnOpDiv.setText("/");
        BtnOpDiv.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnOperationActionPerformed(evt);
            }
        });

        BtnBack.setText("<=");
        BtnBack.setMargin(new java.awt.Insets(2, 2, 2, 2));
        BtnBack.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnBackActionPerformed(evt);
            }
        });

        BtnDigit4.setText("4");
        BtnDigit4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnDigit5.setText("5");
        BtnDigit5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnDigit6.setText("6");
        BtnDigit6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnOpMul.setText("*");
        BtnOpMul.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnOperationActionPerformed(evt);
            }
        });

        BtnClear.setText("C");
        BtnClear.setMargin(new java.awt.Insets(2, 2, 2, 2));
        BtnClear.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnClearActionPerformed(evt);
            }
        });

        BtnDigit1.setText("1");
        BtnDigit1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnDigit2.setText("2");
        BtnDigit2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnDigit3.setText("3");
        BtnDigit3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnOpSub.setText("-");
        BtnOpSub.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnOperationActionPerformed(evt);
            }
        });

        BtnDigit0.setText("0");
        BtnDigit0.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnDigitActionPerformed(evt);
            }
        });

        BtnPoint.setText(",");
        BtnPoint.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnPointActionPerformed(evt);
            }
        });

        BtnOpAdd.setText("+");
        BtnOpAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnOperationActionPerformed(evt);
            }
        });

        BtnEnter.setText("=");
        BtnEnter.setMargin(new java.awt.Insets(2, 2, 2, 2));
        BtnEnter.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnOperationActionPerformed(evt);
            }
        });

        Panel.setEditable(false);
        Panel.setFont(new java.awt.Font("Courier New", 1, 24)); // NOI18N
        Panel.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        Panel.setText("0");
        Panel.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                formKeyTyped(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(Panel)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(BtnDigit7, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnDigit8, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnDigit9, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnOpDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnBack, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(BtnDigit4, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnDigit5, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnDigit6, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnOpMul, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnClear, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnDigit1, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(BtnDigit2, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(BtnDigit3, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(BtnOpSub, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(BtnDigit0, javax.swing.GroupLayout.PREFERRED_SIZE, 98, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(BtnPoint, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(BtnOpAdd, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(BtnEnter, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(Panel, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnDigit7, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnDigit8, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnDigit9, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnOpDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnBack, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnDigit4, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnDigit5, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnDigit6, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnOpMul, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnClear, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(BtnDigit1, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(BtnDigit2, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(BtnDigit3, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(BtnOpSub, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(BtnDigit0, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                .addComponent(BtnPoint, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(BtnOpAdd, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addComponent(BtnEnter, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnPointActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnPointActionPerformed
        if(NeedClear) Panel.setText("0");
        if(!Panel.getText().contains(".")) {
            if(Panel.getText().length()>=DisplaySize) return;
            Panel.setText(Panel.getText()+".");
        }
        NeedClear=false;
        Panel.requestFocusInWindow();
    }//GEN-LAST:event_BtnPointActionPerformed

    private void BtnOperationActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnOperationActionPerformed
        if(!NeedClear) {
            double NextValue=Double.parseDouble(Panel.getText());
            switch(Operation) {
                case "+": SavedValue+=NextValue; break;
                case "-": SavedValue-=NextValue; break;
                case "*": SavedValue*=NextValue; break;
                case "/": SavedValue/=NextValue; break;
                default:  SavedValue=NextValue;  break;
            }
            String str=String.valueOf(SavedValue);
            Panel.setText(str.substring(0, Math.min(str.length(), DisplaySize)));
        }
        JButton btn=(JButton)evt.getSource();
        Operation=btn.getText();
        NeedClear=true;
        Panel.requestFocusInWindow();
    }//GEN-LAST:event_BtnOperationActionPerformed

    private void formKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyTyped
        String Key=Character.toString(evt.getKeyChar());
        switch (Key) {
            case "\n": Key="=";  break;
            case "\b": Key="<="; break;
            case ".":  Key=",";  break;
        }
        for(Component btn:getContentPane().getComponents()) {
            if((btn instanceof JButton)&&(((JButton)btn).getText().equals(Key))) {
                ((JButton)btn).doClick(150);
                break;
            }   
        }
    }//GEN-LAST:event_formKeyTyped

    private void BtnBackActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnBackActionPerformed
        String text=Panel.getText();
        int len=text.length();
        if(len>1) Panel.setText(text.substring(0,len-1));
        else {
            Panel.setText("0");
            NeedClear=true;
        }
        Panel.requestFocusInWindow();
    }//GEN-LAST:event_BtnBackActionPerformed

    private void BtnDigitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDigitActionPerformed
        if(NeedClear) Panel.setText("");
        if(Panel.getText().length()>=DisplaySize) return;
        JButton btn=(JButton)evt.getSource();
        Panel.setText(Panel.getText()+btn.getText());
        NeedClear=false;
        Panel.requestFocusInWindow();
    }//GEN-LAST:event_BtnDigitActionPerformed

    private void BtnClearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnClearActionPerformed
        SavedValue=0;
        NeedClear=true;
        Operation="";
        Panel.setText("0");
        Panel.requestFocusInWindow();
    }//GEN-LAST:event_BtnClearActionPerformed

    public static void main(String args[]) {
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                new MainForm().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnBack;
    private javax.swing.JButton BtnClear;
    private javax.swing.JButton BtnDigit0;
    private javax.swing.JButton BtnDigit1;
    private javax.swing.JButton BtnDigit2;
    private javax.swing.JButton BtnDigit3;
    private javax.swing.JButton BtnDigit4;
    private javax.swing.JButton BtnDigit5;
    private javax.swing.JButton BtnDigit6;
    private javax.swing.JButton BtnDigit7;
    private javax.swing.JButton BtnDigit8;
    private javax.swing.JButton BtnDigit9;
    private javax.swing.JButton BtnEnter;
    private javax.swing.JButton BtnOpAdd;
    private javax.swing.JButton BtnOpDiv;
    private javax.swing.JButton BtnOpMul;
    private javax.swing.JButton BtnOpSub;
    private javax.swing.JButton BtnPoint;
    private javax.swing.JTextField Panel;
    // End of variables declaration//GEN-END:variables
}
