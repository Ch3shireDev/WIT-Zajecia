
import java.util.ArrayList;
import java.util.HashSet;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class Hierarchy extends javax.swing.JFrame
{
   private final Animal[] tb=new Animal[]
   {
      new Fly("Bzz"),
      new Horse("Fart"),
      new Dog("Ax"),
      new Dragonfly("Lotka"),
      new Dog("Haru"),
      new Fly("Zzzz"),
      new Dragonfly("Df"),
      new Horse("Arrow"),
   };
   private final ArrayList<Animal> al=new ArrayList<>();
   private final HashSet<Animal> hs=new HashSet<>();
   private final SmartListModel<Animal> LbModel=new SmartListModel<>();
   private final DefaultComboBoxModel<Animal> CbModel=new DefaultComboBoxModel<>();

   public Hierarchy()
   {
      initComponents();
      LbAnimals.setModel(LbModel);
      CbAnimals.setModel(CbModel);

      //for(int i=0;i<tb.length;++i) al.add(tb[i]);
      for(Animal i:tb) al.add(i);

      //for(int i=0;i<al.size();++i) al.add(al.get(i));
      for(Animal i:al) hs.add(i);

      //for(Animal i:hs) LbModel.addElement(i);
      LbModel.addAll(hs);

      //for(int i=0;i<LbModel.getSize();++i) CbModel.addElement(LbModel.getElementAt(i));
      for(Animal i:LbModel) CbModel.addElement(i);
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      LbAnimalsScroll = new javax.swing.JScrollPane();
      LbAnimals = new javax.swing.JList<>();
      CbAnimals = new javax.swing.JComboBox<>();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      LbAnimalsScroll.setViewportView(LbAnimals);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(CbAnimals, 0, 314, Short.MAX_VALUE)
               .addComponent(LbAnimalsScroll))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(LbAnimalsScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 168, Short.MAX_VALUE)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(CbAnimals, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new Hierarchy().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JComboBox<Animal> CbAnimals;
   private javax.swing.JList<Animal> LbAnimals;
   private javax.swing.JScrollPane LbAnimalsScroll;
   // End of variables declaration//GEN-END:variables
}
