
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
      EdColumnScroll = new javax.swing.JScrollPane();
      EdM = new javax.swing.JTextArea();
      BtnMultiply = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdY = new javax.swing.JTextArea();
      EdColumnScroll1 = new javax.swing.JScrollPane();
      EdX = new javax.swing.JTextArea();
      BtnGauss = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      CbColors.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

      EdM.setColumns(20);
      EdM.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdM.setRows(5);
      EdM.setText("3,4\t1,1\t9,4\t8\n1,5\t4,8\t4,2\t2,9\n4,4\t0\t8,2\t1,3\n5,8\t8,7\t8,6\t8\n");
      EdColumnScroll.setViewportView(EdM);

      BtnMultiply.setText("Multiply");
      BtnMultiply.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMultiplyActionPerformed(evt);
         }
      });

      EdY.setColumns(20);
      EdY.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdY.setRows(5);
      EdLogScroll.setViewportView(EdY);

      EdX.setColumns(20);
      EdX.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdX.setRows(5);
      EdX.setText("2,2\t3,6\t3,7\n1,5\t5\t2,9\n6,4\t7\t4,3\n4,5\t9,2\t3,4\n");
      EdColumnScroll1.setViewportView(EdX);

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
                  .addComponent(EdColumnScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 358, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(EdColumnScroll1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 661, Short.MAX_VALUE)
                     .addComponent(EdLogScroll))))
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
            .addComponent(EdColumnScroll1, javax.swing.GroupLayout.DEFAULT_SIZE, 186, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(EdColumnScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 276, Short.MAX_VALUE)
               .addComponent(EdLogScroll))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMultiplyActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnMultiplyActionPerformed
   {//GEN-HEADEREND:event_BtnMultiplyActionPerformed
      double[][] M = Matrix.parseMatrix(EdM.getText());
      double[][] X = Matrix.parseMatrix(EdX.getText());
      double[][] Y = Matrix.multiply(M,X);
      EdY.setText(Matrix.MatrixToString(Y));
   }//GEN-LAST:event_BtnMultiplyActionPerformed

   private void BtnGaussActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGaussActionPerformed
      double[][] M = Matrix.parseMatrix(EdM.getText());
      double[][] Y = Matrix.parseMatrix(EdY.getText());
      double[][] X = Matrix.gauss(M,Y);
      EdX.setText(Matrix.MatrixToString(X));
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
   private javax.swing.JScrollPane EdColumnScroll;
   private javax.swing.JScrollPane EdColumnScroll1;
   private javax.swing.JScrollPane EdLogScroll;
   private javax.swing.JTextArea EdM;
   private javax.swing.JTextArea EdX;
   private javax.swing.JTextArea EdY;
   // End of variables declaration//GEN-END:variables
}
