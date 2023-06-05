
import java.util.ArrayList;
import javax.swing.BoxLayout;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JCheckBox;

public class DecoratorForm extends javax.swing.JFrame
{
   private DefaultComboBoxModel<String> kindmodel=new DefaultComboBoxModel<>();
   private ArrayList<JCheckBox> decorators=new ArrayList<JCheckBox>();
   public DecoratorForm()
   {
      initComponents();
      cbCarKind.setModel(kindmodel);
      for(String kind : Car.keys) kindmodel.addElement(kind);
      cbCarKind.setSelectedIndex(0);
      pnCarDecorators.setLayout(new BoxLayout(pnCarDecorators,BoxLayout.Y_AXIS));
      for(String kind : CarDecorator.keys)
      {
         JCheckBox cb = new JCheckBox();
         cb.setText(kind);
         pnCarDecorators.add(cb);
         decorators.add(cb);
      }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      cbCarKind = new javax.swing.JComboBox();
      pnCarDecorators = new javax.swing.JPanel();
      btnAdd = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      txtLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      cbCarKind.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

      javax.swing.GroupLayout pnCarDecoratorsLayout = new javax.swing.GroupLayout(pnCarDecorators);
      pnCarDecorators.setLayout(pnCarDecoratorsLayout);
      pnCarDecoratorsLayout.setHorizontalGroup(
         pnCarDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );
      pnCarDecoratorsLayout.setVerticalGroup(
         pnCarDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );

      btnAdd.setText("Add");
      btnAdd.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnAddActionPerformed(evt);
         }
      });

      txtLog.setColumns(20);
      txtLog.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
      txtLog.setRows(5);
      jScrollPane1.setViewportView(txtLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(cbCarKind, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(pnCarDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(btnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 665, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 296, Short.MAX_VALUE)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(cbCarKind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(pnCarDecorators, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnAdd)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void btnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAddActionPerformed
      Car car=Car.make(cbCarKind.getSelectedItem().toString());
      for(JCheckBox cb : decorators)
      {
         if(cb.isSelected()) car=CarDecorator.make(cb.getText(),car);
      }
      txtLog.append(car.toString()+System.lineSeparator());
   }//GEN-LAST:event_btnAddActionPerformed

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(()->new DecoratorForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnAdd;
   private javax.swing.JComboBox cbCarKind;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JPanel pnCarDecorators;
   private javax.swing.JTextArea txtLog;
   // End of variables declaration//GEN-END:variables
}
