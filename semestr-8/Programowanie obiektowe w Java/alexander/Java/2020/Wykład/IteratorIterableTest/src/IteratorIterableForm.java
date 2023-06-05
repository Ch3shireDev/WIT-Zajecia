
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
   private void initComponents()
   {

      CbColors = new javax.swing.JComboBox<>();
      EdColumnScroll = new javax.swing.JScrollPane();
      EdColumn = new javax.swing.JTextArea();
      BtnParse = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      CbColors.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

      EdColumn.setColumns(20);
      EdColumn.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdColumn.setRows(5);
      EdColumn.setText("4,08\t0,23\t8,96\n1,51\t0,95\t4,81\n7,96\t0,29\t6,7\n2,42\t4,5\t3,16\n");
      EdColumnScroll.setViewportView(EdColumn);

      BtnParse.setText("Parse");
      BtnParse.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            BtnParseActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setFont(new java.awt.Font("Lucida Console", 1, 14)); // NOI18N
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdColumnScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 263, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdLogScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 246, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(BtnParse)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(CbColors, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnParse))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdColumnScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 259, Short.MAX_VALUE)
               .addComponent(EdLogScroll))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnParseActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_BtnParseActionPerformed
   {//GEN-HEADEREND:event_BtnParseActionPerformed
      double[][] matrix = Matrix.parseMatrix(EdColumn.getText());
      //column = Matrix.multiply(column, 2);
      EdLog.setText(Matrix.MatrixToString(matrix));
   }//GEN-LAST:event_BtnParseActionPerformed

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
   private javax.swing.JButton BtnParse;
   private javax.swing.JComboBox<String> CbColors;
   private javax.swing.JTextArea EdColumn;
   private javax.swing.JScrollPane EdColumnScroll;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   // End of variables declaration//GEN-END:variables
}
