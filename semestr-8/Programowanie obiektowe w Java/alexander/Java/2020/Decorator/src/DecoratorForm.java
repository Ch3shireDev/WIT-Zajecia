
import java.util.ArrayList;
import javax.swing.BoxLayout;
import javax.swing.JCheckBox;
import javax.swing.JComboBox;

public class DecoratorForm extends javax.swing.JFrame 
{
   private final ArrayList<JCheckBox> decorators=new ArrayList<>();
   public DecoratorForm() 
   {
      initComponents();
      for(String kind: CarFabric.keys()) CarKinds.addItem(kind); // wypelniamy combobox
      DecoratorList.setLayout(new BoxLayout(DecoratorList,BoxLayout.Y_AXIS)); // sposób ukladania
      for(String kind: CarDecoratorFabric.keys()) // dla kaædego dekoratora
      {
         JCheckBox cb = new JCheckBox(); // tworzenie checkboxa
         cb.setText(kind); // nadanie tekst
         decorators.add(cb); // dodanie do wewnétrznej list,  dla iterowania po nich
         DecoratorList.add(cb); // dodajemy do panelu
      }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      CarKinds = new javax.swing.JComboBox();
      DecoratorList = new javax.swing.JPanel();
      BtnMake = new javax.swing.JButton();
      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      javax.swing.GroupLayout DecoratorListLayout = new javax.swing.GroupLayout(DecoratorList);
      DecoratorList.setLayout(DecoratorListLayout);
      DecoratorListLayout.setHorizontalGroup(
         DecoratorListLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 0, Short.MAX_VALUE)
      );
      DecoratorListLayout.setVerticalGroup(
         DecoratorListLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 223, Short.MAX_VALUE)
      );

      BtnMake.setText("Make");
      BtnMake.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            BtnMakeActionPerformed(evt);
         }
      });

      EdLog.setColumns(20);
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(DecoratorList, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(CarKinds, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(BtnMake, javax.swing.GroupLayout.DEFAULT_SIZE, 142, Short.MAX_VALUE))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 660, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(EdLogScroll)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CarKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(DecoratorList, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(BtnMake)))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void BtnMakeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMakeActionPerformed
      Car car=CarFabric.make(CarKinds.getSelectedItem().toString()); // utworzenie samochodu wg marki
      for(JCheckBox cb: decorators) // dla kaædego checkboxa (dekoratora)
      {
         if(cb.isSelected()) // jeæli zaznaczono
         {
            car=CarDecoratorFabric.make(cb.getText(),car); // nakøadamy dekorator
         }
      }
      String str=String.format("%.0f\t%s",car.price(),car.info()); // tworzenie informacji do wyßwietlenia
      EdLog.append(str+System.lineSeparator()); // Wyßwietlamy informacje
   }//GEN-LAST:event_BtnMakeActionPerformed

   public static void main(String args[]) 
   {
      java.awt.EventQueue.invokeLater(() -> new DecoratorForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton BtnMake;
   private javax.swing.JComboBox CarKinds;
   private javax.swing.JPanel DecoratorList;
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   // End of variables declaration//GEN-END:variables
}
