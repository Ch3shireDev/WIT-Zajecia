
import javax.swing.DefaultListModel;


public class BaseControl extends javax.swing.JFrame
{
   private DefaultListModel<RowItem> LbModel=new DefaultListModel<>();

   public BaseControl()
   {
      initComponents();
      LbList.setModel(LbModel);
      //LbModel.addElement(new RowItem("Ala ma kota",123.45));
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      jScrollPane1 = new javax.swing.JScrollPane();
      LbList = new javax.swing.JList<>();
      BtnDelete = new javax.swing.JButton();
      EdText = new javax.swing.JTextField();
      BtnAdd = new javax.swing.JButton();
      EdValue = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      jScrollPane1.setViewportView(LbList);

      BtnDelete.setText("Usuń");

      BtnAdd.setText("Dodaj");

      EdValue.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
      EdValue.setText("10");

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 419, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(EdText)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(EdValue, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(BtnAdd, javax.swing.GroupLayout.Alignment.TRAILING)
               .addComponent(BtnDelete, javax.swing.GroupLayout.Alignment.TRAILING))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(BtnDelete)
                  .addGap(0, 0, Short.MAX_VALUE))
               .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 246, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(EdText, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(BtnAdd)
               .addComponent(EdValue, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   /**
    * @param args the command line arguments
    */
   public static void main(String args[])
   {
      /* Set the Nimbus look and feel */
      //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
      /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
       */
      try
      {
         for(javax.swing.UIManager.LookAndFeelInfo info:javax.swing.UIManager.getInstalledLookAndFeels())
            if("Nimbus".equals(info.getName()))
            {
               javax.swing.UIManager.setLookAndFeel(info.getClassName());
               break;
            }
      }
      catch(ClassNotFoundException ex)
      {
         java.util.logging.Logger.getLogger(BaseControl.class.getName()).log(java.util.logging.Level.SEVERE,null,ex);
      }
      catch(InstantiationException ex)
      {
         java.util.logging.Logger.getLogger(BaseControl.class.getName()).log(java.util.logging.Level.SEVERE,null,ex);
      }
      catch(IllegalAccessException ex)
      {
         java.util.logging.Logger.getLogger(BaseControl.class.getName()).log(java.util.logging.Level.SEVERE,null,ex);
      }
      catch(javax.swing.UnsupportedLookAndFeelException ex)
      {
         java.util.logging.Logger.getLogger(BaseControl.class.getName()).log(java.util.logging.Level.SEVERE,null,ex);
      }
      //</editor-fold>
      //</editor-fold>
      //</editor-fold>
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new BaseControl().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnAdd;
   private javax.swing.JButton BtnDelete;
   private javax.swing.JTextField EdText;
   private javax.swing.JTextField EdValue;
   private javax.swing.JList<RowItem> LbList;
   private javax.swing.JScrollPane jScrollPane1;
   // End of variables declaration//GEN-END:variables
}

class RowItem
{
   private String Text;
   private double Value;

   public RowItem(String Text,double Value)
   {
      this.Text=Text;
      this.Value=Value;
   }

   public String getText() { return Text; }
   public void setText(String Text) { this.Text=Text; }

   public double getValue() { return Value; }
   public void setValue(double Value) { this.Value=Value; }

   @Override public String toString() { return String.format("%s: %.2f",Text,Value); }
}