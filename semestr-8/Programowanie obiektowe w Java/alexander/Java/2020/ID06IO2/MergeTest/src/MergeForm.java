public class MergeForm extends javax.swing.JFrame
{
   public MergeForm() 
   {
      initComponents();
   }
   
   private static double[] ParseTable(String text)
   {
      String[] items=text.split("[\\s\t\r\n]+");
      double[] ret=new double[items.length];
      for(int i=0;i<ret.length;++i) ret[i]=Double.parseDouble(items[i].replace(',','.'));
      return ret;
   }
   
   private static String MergeTable(double[] tb)
   {
      StringBuilder sb=new StringBuilder();
      for(int i=0;i<tb.length;++i) sb.append(tb[i]).append(System.lineSeparator());
      return sb.toString();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      EdSourceScroll = new javax.swing.JScrollPane();
      EdSource = new javax.swing.JTextArea();
      EdResultScroll = new javax.swing.JScrollPane();
      EdResult = new javax.swing.JTextArea();
      BtnSort = new javax.swing.JButton();
      BtnGenerate = new javax.swing.JButton();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdSource.setColumns(20);
      EdSource.setRows(5);
      EdSource.setText("60,1\n18,9\n48,7\n12,9\n83,6\n67,2\n87,2\n14,8\n48,4\n73,4\n7,5\n79,1\n1,5\n11,6\n77,7\n33,3\n55,3\n68,9\n46,9\n55,8\n89,4\n39,9\n45,3\n90,2\n74,4\n79,7\n53,6\n49,8\n67,3\n39,2\n65,5\n22,3\n31,5\n");
      EdSourceScroll.setViewportView(EdSource);

      EdResult.setColumns(20);
      EdResult.setRows(5);
      EdResultScroll.setViewportView(EdResult);

      BtnSort.setText("Sort");
      BtnSort.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnSortActionPerformed(evt);
         }
      });

      BtnGenerate.setText("Generate");
      BtnGenerate.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnGenerateActionPerformed(evt);
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
                  .addComponent(EdSourceScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 91, Short.MAX_VALUE)
                  .addComponent(EdResultScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 141, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnGenerate)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(BtnSort)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdSourceScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 249, Short.MAX_VALUE)
               .addComponent(EdResultScroll))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnSort)
               .addComponent(BtnGenerate))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnGenerateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnGenerateActionPerformed
      // TODO add your handling code here:
   }//GEN-LAST:event_BtnGenerateActionPerformed

   private void BtnSortActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnSortActionPerformed
      EdResult.setText(MergeTable(Merge.Sort(ParseTable(EdSource.getText()))));
   }//GEN-LAST:event_BtnSortActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new MergeForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnGenerate;
   private javax.swing.JButton BtnSort;
   private javax.swing.JTextArea EdResult;
   private javax.swing.JScrollPane EdResultScroll;
   private javax.swing.JTextArea EdSource;
   private javax.swing.JScrollPane EdSourceScroll;
   // End of variables declaration//GEN-END:variables
}
