
import javax.swing.JSplitPane;

public class MatrixForm extends javax.swing.JFrame
{
   public MatrixForm()
   {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      spVertical = new javax.swing.JSplitPane();
      spLeft = new javax.swing.JSplitPane();
      pnButtons = new javax.swing.JPanel();
      btnAdd = new javax.swing.JButton();
      btnMul = new javax.swing.JButton();
      btnSolve = new javax.swing.JButton();
      btnInvert = new javax.swing.JButton();
      taMatrixBScroll = new javax.swing.JScrollPane();
      taMatrixA = new javax.swing.JTextArea();
      spRight = new javax.swing.JSplitPane();
      taMatrixAScroll = new javax.swing.JScrollPane();
      taMatrixB = new javax.swing.JTextArea();
      taMatrixCScroll = new javax.swing.JScrollPane();
      taMatrixC = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      spVertical.setDividerLocation(350);
      spVertical.setDividerSize(8);

      spLeft.setDividerLocation(200);
      spLeft.setDividerSize(8);
      spLeft.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);
      spLeft.addPropertyChangeListener(new java.beans.PropertyChangeListener()
      {
         public void propertyChange(java.beans.PropertyChangeEvent evt)
         {
            spHorizontalSpliterPropertyChange(evt);
         }
      });

      btnAdd.setText("Add");
      btnAdd.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            btnAddActionPerformed(evt);
         }
      });

      btnMul.setText("Mul");

      btnSolve.setText("Solve");

      btnInvert.setText("Invert");

      javax.swing.GroupLayout pnButtonsLayout = new javax.swing.GroupLayout(pnButtons);
      pnButtons.setLayout(pnButtonsLayout);
      pnButtonsLayout.setHorizontalGroup(
         pnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(pnButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addGroup(pnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(pnButtonsLayout.createSequentialGroup()
                  .addComponent(btnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnSolve))
               .addGroup(pnButtonsLayout.createSequentialGroup()
                  .addComponent(btnMul)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnInvert)))
            .addContainerGap(219, Short.MAX_VALUE))
      );
      pnButtonsLayout.setVerticalGroup(
         pnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(pnButtonsLayout.createSequentialGroup()
            .addContainerGap()
            .addGroup(pnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnAdd)
               .addComponent(btnSolve))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(pnButtonsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(btnMul)
               .addComponent(btnInvert))
            .addContainerGap(136, Short.MAX_VALUE))
      );

      spLeft.setTopComponent(pnButtons);

      taMatrixA.setColumns(20);
      taMatrixA.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
      taMatrixA.setRows(5);
      taMatrixA.setText("1.4\t5.4\t6.1\t3.8\n9.4\t8.3\t2.3\t2.1\n3.1\t7.5\t7.7\t9.3\n0.8\t7.4\t1.7\t6.6\n");
      taMatrixBScroll.setViewportView(taMatrixA);

      spLeft.setRightComponent(taMatrixBScroll);

      spVertical.setLeftComponent(spLeft);

      spRight.setDividerLocation(200);
      spRight.setDividerSize(8);
      spRight.setOrientation(javax.swing.JSplitPane.VERTICAL_SPLIT);
      spRight.addPropertyChangeListener(new java.beans.PropertyChangeListener()
      {
         public void propertyChange(java.beans.PropertyChangeEvent evt)
         {
            spHorizontalSpliterPropertyChange(evt);
         }
      });

      taMatrixB.setColumns(20);
      taMatrixB.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
      taMatrixB.setRows(5);
      taMatrixB.setText("-0.171\t0.098\t0.133\t-0.120\n0.210\t0.024\t-0.211\t0.169\n0.180\t-0.023\t0.023\t-0.128\n-0.262\t-0.033\t0.215\t0.010\n");
      taMatrixAScroll.setViewportView(taMatrixB);

      spRight.setTopComponent(taMatrixAScroll);

      taMatrixC.setColumns(20);
      taMatrixC.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
      taMatrixC.setRows(5);
      taMatrixCScroll.setViewportView(taMatrixC);

      spRight.setRightComponent(taMatrixCScroll);

      spVertical.setRightComponent(spRight);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(spVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 715, Short.MAX_VALUE)
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addComponent(spVertical, javax.swing.GroupLayout.DEFAULT_SIZE, 475, Short.MAX_VALUE)
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnAddActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_btnAddActionPerformed
   {//GEN-HEADEREND:event_btnAddActionPerformed
      Matrix a=Matrix.parseMatrix(taMatrixA.getText());
      Matrix b=Matrix.parseMatrix(taMatrixB.getText());
      taMatrixC.setText(Matrix.add(a,b).toString());
   }//GEN-LAST:event_btnAddActionPerformed

   private void spHorizontalSpliterPropertyChange(java.beans.PropertyChangeEvent evt)//GEN-FIRST:event_spHorizontalSpliterPropertyChange
   {//GEN-HEADEREND:event_spHorizontalSpliterPropertyChange
      JSplitPane sp=(JSplitPane)evt.getSource();
      int location=sp.getDividerLocation();
      spLeft.setDividerLocation(location);
      spRight.setDividerLocation(location);
   }//GEN-LAST:event_spHorizontalSpliterPropertyChange

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MatrixForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAdd;
   private javax.swing.JButton btnInvert;
   private javax.swing.JButton btnMul;
   private javax.swing.JButton btnSolve;
   private javax.swing.JPanel pnButtons;
   private javax.swing.JSplitPane spLeft;
   private javax.swing.JSplitPane spRight;
   private javax.swing.JSplitPane spVertical;
   private javax.swing.JTextArea taMatrixA;
   private javax.swing.JScrollPane taMatrixAScroll;
   private javax.swing.JTextArea taMatrixB;
   private javax.swing.JScrollPane taMatrixBScroll;
   private javax.swing.JTextArea taMatrixC;
   private javax.swing.JScrollPane taMatrixCScroll;
   // End of variables declaration//GEN-END:variables
}
