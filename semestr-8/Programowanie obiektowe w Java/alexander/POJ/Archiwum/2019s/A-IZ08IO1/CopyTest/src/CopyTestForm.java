
import java.util.ArrayList;
import java.util.Arrays;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class CopyTestForm extends javax.swing.JFrame
{
   private final String[] Ar=new String[] { "Koń","Pies","Kot","Krowa" };
   private final ArrayList<String> Al=new ArrayList<>();
   private final DefaultListModel<String> Lm=new DefaultListModel<>();
   private final DefaultComboBoxModel<String> Cm=new DefaultComboBoxModel<>();

   public CopyTestForm()
   {
      initComponents();
      LbAnimal.setModel(Lm);
      CbAnimal.setModel(Cm);
      //for(int i=0;i<Ar.length;++i) Al.add(Ar[i]);
      //Arrays.asList(Ar).forEach((s) -> Al.add(s));
      //for(String s:Ar) Al.add(s);
      Al.addAll(Arrays.asList(Ar));

      for(int i=0;i<Al.size();++i) Lm.addElement(Al.get(i));
      Al.forEach((s) -> Lm.addElement(s));
      for(String s:Al) Lm.addElement(s);


   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      LbAnimalScroll = new javax.swing.JScrollPane();
      LbAnimal = new javax.swing.JList<>();
      CbAnimal = new javax.swing.JComboBox<>();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      LbAnimalScroll.setViewportView(LbAnimal);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LbAnimalScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 154, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(CbAnimal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap(202, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(CbAnimal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 0, Short.MAX_VALUE))
               .addComponent(LbAnimalScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 278, Short.MAX_VALUE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new CopyTestForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JComboBox<String> CbAnimal;
   private javax.swing.JList<String> LbAnimal;
   private javax.swing.JScrollPane LbAnimalScroll;
   // End of variables declaration//GEN-END:variables
}
