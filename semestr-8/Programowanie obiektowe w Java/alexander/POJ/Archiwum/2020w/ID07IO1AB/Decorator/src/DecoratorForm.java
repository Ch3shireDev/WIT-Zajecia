
import javax.swing.BoxLayout;
import javax.swing.JCheckBox;

public class DecoratorForm extends javax.swing.JFrame
{
   public DecoratorForm()
   {
      initComponents();
      Car car=new Toyota();
      car=new AirCondition(car);
      car=new TintedWindow(car);
      LcbDecorators.setLayout(new BoxLayout(LcbDecorators,BoxLayout.Y_AXIS));
      LcbDecorators.add(new JCheckBox("Aaaaa"));
      LcbDecorators.add(new JCheckBox("Bbbbb"));
      LcbDecorators.add(new JCheckBox("Ccccc"));
      LcbDecorators.add(new JCheckBox("Ddddd"));
      LcbDecorators.add(new JCheckBox("Eeeee"));
      LcbDecorators.add(new JCheckBox("Fffff"));
      LcbDecorators.add(new JCheckBox("Ggggg"));
      LcbDecorators.add(new JCheckBox("Hhhhh"));
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      jScrollPane1 = new javax.swing.JScrollPane();
      jTextArea1 = new javax.swing.JTextArea();
      LcbDecoratorsScroll = new javax.swing.JScrollPane();
      LcbDecorators = new javax.swing.JPanel();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      jTextArea1.setColumns(20);
      jTextArea1.setRows(5);
      jScrollPane1.setViewportView(jTextArea1);

      javax.swing.GroupLayout LcbDecoratorsLayout = new javax.swing.GroupLayout(LcbDecorators);
      LcbDecorators.setLayout(LcbDecoratorsLayout);
      LcbDecoratorsLayout.setHorizontalGroup(
         LcbDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 137, Short.MAX_VALUE)
      );
      LcbDecoratorsLayout.setVerticalGroup(
         LcbDecoratorsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGap(0, 100, Short.MAX_VALUE)
      );

      LcbDecoratorsScroll.setViewportView(LcbDecorators);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(jScrollPane1)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(LcbDecoratorsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 158, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 222, Short.MAX_VALUE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LcbDecoratorsScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 92, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 180, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new DecoratorForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JPanel LcbDecorators;
   private javax.swing.JScrollPane LcbDecoratorsScroll;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JTextArea jTextArea1;
   // End of variables declaration//GEN-END:variables
}
