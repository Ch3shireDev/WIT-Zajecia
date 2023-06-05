
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;

public class IteratorIterableForm extends javax.swing.JFrame
{
   private final SpecialComboBoxModel<String> model=new SpecialComboBoxModel<>();
   public IteratorIterableForm()
   {
      initComponents();
      String[] tbl=new String[]
      {
         "Blue",
         "Green",
         "Red",
         "Yellow",
      };
      model.addAll(tbl); // zrealizowano
      ArrayList<String> lst=new ArrayList<>();
      for(String s:tbl) lst.add(s);
      CbColors.setModel(model);
      //model.addAll(lst); // zrealizowano
      //while(x.hasNext())  { x.getNext(); }
      ArrayList<String> lst2=new ArrayList<>();
      lst2.addAll(model);
      for(String s:model) lst2.add(s); // zrealizowano
      CbColors.setSelectedIndex(0);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CbColors = new javax.swing.JComboBox<String>();
      EdMatrixAScroll = new javax.swing.JScrollPane();
      EdMatrixA = new javax.swing.JTextArea();
      BtnMultiply = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();
      EdMatrixBScroll = new javax.swing.JScrollPane();
      EdMatrixB = new javax.swing.JTextArea();
      BtnGauss = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      CbColors.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

      EdMatrixA.setColumns(20);
      EdMatrixA.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdMatrixA.setRows(5);
      EdMatrixA.setText("5,57\t0,07\t3,35\t6,88\n1,61\t8,34\t8,04\t9,97\n4,16\t7,4\t9,67\t6,88\n9,34\t0,81\t4,03\t9,08\n");
      EdMatrixAScroll.setViewportView(EdMatrixA);

      BtnMultiply.setText("Multiply");
      BtnMultiply.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiplyActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      EdMatrixB.setColumns(20);
      EdMatrixB.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdMatrixB.setRows(5);
      EdMatrixB.setText("4,55\t5,66\t6,33\n8,03\t8,11\t7,08\n0,54\t8,34\t4,8\n3,63\t0,77\t3,5\n");
      EdMatrixBScroll.setViewportView(EdMatrixB);

      BtnGauss.setText("Gauss");
      BtnGauss.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnGaussActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(BtnGauss)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMultiply))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdMatrixAScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 351, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 583, Short.MAX_VALUE)
                     .addComponent(EdMatrixBScroll))))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnMultiply)
               .addComponent(BtnGauss))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdMatrixBScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 181, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdMatrixAScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 241, Short.MAX_VALUE)
               .addComponent(EdLogScroll))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMultiplyActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnMultiplyActionPerformed
   {//GEN-HEADEREND:event_BtnMultiplyActionPerformed
      double[][] A = Matrix.parseMatrix(EdMatrixA.getText());
      double[][] B = Matrix.parseMatrix(EdMatrixB.getText());
      //column = Matrix.multiply(column, 2);
      double[][] C = Matrix.multiply(A,B);
      EdLog.setText(Matrix.MatrixToString(C));
   }//GEN-LAST:event_BtnMultiplyActionPerformed

   private void BtnGaussActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGaussActionPerformed
      double[][] M = Matrix.parseMatrix(EdMatrixA.getText());
      double[][] Y = Matrix.parseMatrix(EdLog.getText());
      //column = Matrix.multiply(column, 2);
      double[][] X = Matrix.gauss(M,Y);
      EdMatrixB.setText(Matrix.MatrixToString(X));
   }//GEN-LAST:event_BtnGaussActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new IteratorIterableForm().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGauss;
   private javax.swing.JButton BtnMultiply;
   private javax.swing.JComboBox<String> CbColors;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   private javax.swing.JTextArea EdMatrixA;
   private javax.swing.JScrollPane EdMatrixAScroll;
   private javax.swing.JTextArea EdMatrixB;
   private javax.swing.JScrollPane EdMatrixBScroll;
   // End of variables declaration//GEN-END:variables
}
