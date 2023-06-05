
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import javax.swing.event.ListDataEvent;
import javax.swing.event.ListDataListener;


public class BuyList extends javax.swing.JFrame {

   private final IterableListModel<Food> model = new IterableListModel<>();
   
   public BuyList() 
   {
      initComponents();
      Box.setModel(model);
      getRootPane().setDefaultButton(BtnAdd);
      KeyListener kb=new KeyListener()
      {
         @Override public void keyPressed(KeyEvent e) { formKeyPressed(e); }
         @Override public void keyReleased(KeyEvent e) {}
         @Override public void keyTyped(KeyEvent e) {}
      };
      Box.addKeyListener(kb);
      TxtName.addKeyListener(kb);
      BtnAdd.addKeyListener(kb);
      BtnDel.addKeyListener(kb);
      TxtName.requestFocus();
      ListDataListener lister=new ListDataListener()
      {
         @Override public void intervalAdded(ListDataEvent e) { calcSum(); }
         @Override public void intervalRemoved(ListDataEvent e) { calcSum(); }
         @Override public void contentsChanged(ListDataEvent e) { calcSum(); }
      };
      model.addListDataListener(lister);
   }
   
   private void calcSum()
   {
      long sum=0;
      /*// Poczatek alternatywnego bloku
      for(int i=0;i<model.size();++i) sum+=model.get(i).getValue();
      /*/// alternatywne rozwiazanie
      for(Food food : model) sum+=food.getValue();
      //*/// Koniec alternatywnego bloku
      TxtSum.setText(Food.toDoubleStr(2, sum));
   }
   
   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jScrollPane1 = new javax.swing.JScrollPane();
      Box = new javax.swing.JList<>();
      TxtName = new javax.swing.JTextField();
      BtnAdd = new javax.swing.JButton();
      BtnDel = new javax.swing.JButton();
      TxtCount = new javax.swing.JTextField();
      TxtPrice = new javax.swing.JTextField();
      TxtSum = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      addKeyListener(new java.awt.event.KeyAdapter() {
         public void keyPressed(java.awt.event.KeyEvent evt) {
            formKeyPressed(evt);
         }
      });

      Box.setToolTipText("");
      Box.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            BoxMouseClicked(evt);
         }
      });
      jScrollPane1.setViewportView(Box);

      BtnAdd.setText("Add");
      BtnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnAddActionPerformed(evt);
         }
      });

      BtnDel.setText("Delete");
      BtnDel.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnDelActionPerformed(evt);
         }
      });

      TxtCount.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TxtCount.setText("0");
      TxtCount.setPreferredSize(new java.awt.Dimension(60, 20));

      TxtPrice.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TxtPrice.setText("0");
      TxtPrice.setPreferredSize(new java.awt.Dimension(60, 20));

      TxtSum.setEditable(false);
      TxtSum.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      TxtSum.setText("0");
      TxtSum.setPreferredSize(new java.awt.Dimension(60, 20));

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 422, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnAdd)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnDel)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(TxtSum, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(TxtName)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(TxtCount, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(TxtPrice, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 259, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(TxtName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(TxtCount, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(TxtPrice, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(BtnAdd)
               .addComponent(BtnDel)
               .addComponent(TxtSum, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnDelActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnDelActionPerformed
      int index=Box.getSelectedIndex();
      if(index>=0) model.remove(index);
      index=Box.getLeadSelectionIndex();
      if(index>=0) Box.setSelectedIndex(index);
      Box.requestFocus();
   }//GEN-LAST:event_BtnDelActionPerformed

   private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
      String Name=TxtName.getText().trim();
      double Count=Double.parseDouble(TxtCount.getText().trim().replace(",","."));
      double Price=Double.parseDouble(TxtPrice.getText().trim().replace(",","."));
      if(Name.length()>0)
      {
         model.addElement(new Food(Name,Count,Price));
         Box.setSelectedIndex(model.size()-1);
      }
      TxtName.selectAll();
      TxtName.requestFocus();
   }//GEN-LAST:event_BtnAddActionPerformed

   private void formKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyPressed
      if(evt.getKeyCode()==KeyEvent.VK_DELETE && (evt.isControlDown() || Box.isFocusOwner() ))
      {
         BtnDel.doClick();
      }
   }//GEN-LAST:event_formKeyPressed

   private void BoxMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_BoxMouseClicked
      if(evt.getClickCount()==2)
      {
         int index=Box.getSelectedIndex();
         if(index>=0)
         {
            Food food=model.get(index);
            TxtName.setText(food.getName());
            TxtCount.setText(food.getCountAsString());
            TxtPrice.setText(food.getPriceAsString());
            TxtName.selectAll();
            TxtName.requestFocus();
         }
      }
   }//GEN-LAST:event_BoxMouseClicked

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
         java.util.logging.Logger.getLogger(BuyList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (InstantiationException ex) {
         java.util.logging.Logger.getLogger(BuyList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (IllegalAccessException ex) {
         java.util.logging.Logger.getLogger(BuyList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      } catch (javax.swing.UnsupportedLookAndFeelException ex) {
         java.util.logging.Logger.getLogger(BuyList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new BuyList().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JList<Food> Box;
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnDel;
   private javax.swing.JTextField TxtCount;
   private javax.swing.JTextField TxtName;
   private javax.swing.JTextField TxtPrice;
   private javax.swing.JTextField TxtSum;
   private javax.swing.JScrollPane jScrollPane1;
   // End of variables declaration//GEN-END:variables
}
