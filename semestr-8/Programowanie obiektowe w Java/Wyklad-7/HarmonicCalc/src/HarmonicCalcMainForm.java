import javax.swing.*;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import java.util.ArrayList;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;

public class HarmonicCalcMainForm extends javax.swing.JFrame {
    HarmonicService service = new HarmonicService();
    private long Count = 10000000;
    private javax.swing.JButton BtnMulti;
    private javax.swing.JButton BtnSimple;
    private javax.swing.JButton BtnThread;
    private javax.swing.JTextArea TaLog;
    private javax.swing.JScrollPane TaLogScroll;
    private javax.swing.JTextField TfCount;

    public HarmonicCalcMainForm() {
        initComponents();
        DocumentListener listener = new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                SynchCount();
            }

            @Override
            public void removeUpdate(DocumentEvent e) {
                SynchCount();
            }

            @Override
            public void changedUpdate(DocumentEvent e) {
                SynchCount();
            }
        };
        TfCount
                .getDocument()
                .addDocumentListener(listener);
    }

    public static void main(String[] args) {
        java.awt.EventQueue.invokeLater(() -> new HarmonicCalcMainForm().setVisible(true));
    }

    private void SynchCount() {
        boolean ok = true;
        try {
            var countText = TfCount
                    .getText()
                    .trim();
            Count = Long.parseLong(countText);
        } catch (Exception ex) {
            ok = false;
        }
        BtnSimple.setEnabled(ok);
    }

    private void ShowResult(long count, double sum, String method) {
        TaLog.append(String.format("%s: %12d => %.18f", method, count, sum) + System.lineSeparator());
    }

    private double SimpleCalc(long count) {
        return service.SimpleCalc(count);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        TfCount = new javax.swing.JTextField();
        BtnSimple = new javax.swing.JButton();
        TaLogScroll = new javax.swing.JScrollPane();
        TaLog = new javax.swing.JTextArea();
        BtnThread = new javax.swing.JButton();
        BtnMulti = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        TfCount.setHorizontalAlignment(SwingConstants.RIGHT);
        TfCount.setText("10000000");

        BtnSimple.setText("Simple");
        BtnSimple.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnSimpleActionPerformed(evt);
            }
        });

        TaLog.setColumns(20);
        TaLog.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
        TaLog.setRows(5);
        TaLogScroll.setViewportView(TaLog);

        BtnThread.setText("Thread");
        BtnThread.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnThreadActionPerformed(evt);
            }
        });

        BtnMulti.setText("Multi");
        BtnMulti.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnMultiActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(layout
                                          .createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                          .addGroup(layout
                                                            .createSequentialGroup()
                                                            .addContainerGap()
                                                            .addGroup(layout
                                                                              .createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                                              .addComponent(TaLogScroll)
                                                                              .addGroup(layout
                                                                                                .createSequentialGroup()
                                                                                                .addComponent(TfCount,
                                                                                                              javax.swing.GroupLayout.PREFERRED_SIZE,
                                                                                                              97,
                                                                                                              javax.swing.GroupLayout.PREFERRED_SIZE)
                                                                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED,
                                                                                                                 319,
                                                                                                                 Short.MAX_VALUE)
                                                                                                .addComponent(BtnMulti)
                                                                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                                                                .addComponent(BtnThread)
                                                                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                                                                .addComponent(BtnSimple)))
                                                            .addContainerGap()));
        layout.setVerticalGroup(layout
                                        .createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addGroup(layout
                                                          .createSequentialGroup()
                                                          .addContainerGap()
                                                          .addGroup(layout
                                                                            .createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                                                            .addComponent(TfCount,
                                                                                          javax.swing.GroupLayout.PREFERRED_SIZE,
                                                                                          javax.swing.GroupLayout.DEFAULT_SIZE,
                                                                                          javax.swing.GroupLayout.PREFERRED_SIZE)
                                                                            .addComponent(BtnSimple)
                                                                            .addComponent(BtnThread)
                                                                            .addComponent(BtnMulti))
                                                          .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                          .addComponent(TaLogScroll,
                                                                        javax.swing.GroupLayout.DEFAULT_SIZE,
                                                                        317,
                                                                        Short.MAX_VALUE)
                                                          .addContainerGap()));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnSimpleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSimpleActionPerformed
        double sum = SimpleCalc(Count);
        ShowResult(Count, sum, "S");
    }//GEN-LAST:event_BtnSimpleActionPerformed

    private void BtnThreadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnThreadActionPerformed
        new Thread(() -> {
            long count = Count;
            double sum = SimpleCalc(count);
            ShowResult(count, sum, "T");
        }).start();

        // thread where when calculation is done value is returned otside thread

    }//GEN-LAST:event_BtnThreadActionPerformed

    private void BtnMultiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMultiActionPerformed

        double sum = service.getSumMultithreaded(Count);
        ShowResult(Count, sum, "M");


    }//GEN-LAST:event_BtnMultiActionPerformed

    // End of variables declaration//GEN-END:variables
}
