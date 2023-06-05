public class AnimalMain extends javax.swing.JFrame {

   public AnimalMain() {
      initComponents();
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents() {

      btnLeftFly = new javax.swing.JButton();
      btnLeftDragonfly = new javax.swing.JButton();
      btnLeftHorse = new javax.swing.JButton();
      btnLeftCat = new javax.swing.JButton();
      btnRightFly = new javax.swing.JButton();
      btnRightDragonfly = new javax.swing.JButton();
      btnRightHorse = new javax.swing.JButton();
      btnRightCat = new javax.swing.JButton();
      txtLeftField = new javax.swing.JTextField();
      txtRightField = new javax.swing.JTextField();
      txtAnimalName = new javax.swing.JTextField();
      jScrollPane1 = new javax.swing.JScrollPane();
      txtInfo = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      btnLeftFly.setText("Fly");
      btnLeftFly.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            btnLeftFlyMouseClicked(evt);
         }
      });

      btnLeftDragonfly.setLabel("DragonFly");
      btnLeftDragonfly.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            btnLeftDragonflyMouseClicked(evt);
         }
      });

      btnLeftHorse.setLabel("Horse");
      btnLeftHorse.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            btnLeftHorseMouseClicked(evt);
         }
      });

      btnLeftCat.setLabel("Cat");
      btnLeftCat.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnLeftCatActionPerformed(evt);
         }
      });

      btnRightFly.setText("Fly");
      btnRightFly.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            btnRightFlyMouseClicked(evt);
         }
      });

      btnRightDragonfly.setLabel("DragonFly");
      btnRightDragonfly.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            btnRightDragonflyMouseClicked(evt);
         }
      });

      btnRightHorse.setLabel("Horse");
      btnRightHorse.addMouseListener(new java.awt.event.MouseAdapter() {
         public void mouseClicked(java.awt.event.MouseEvent evt) {
            btnRightHorseMouseClicked(evt);
         }
      });

      btnRightCat.setLabel("Cat");
      btnRightCat.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnRightCatActionPerformed(evt);
         }
      });

      txtRightField.setName(""); // NOI18N

      txtAnimalName.setText("name");

      txtInfo.setColumns(20);
      txtInfo.setRows(5);
      jScrollPane1.setViewportView(txtInfo);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(txtLeftField, javax.swing.GroupLayout.PREFERRED_SIZE, 187, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 120, Short.MAX_VALUE)
                  .addComponent(txtRightField, javax.swing.GroupLayout.PREFERRED_SIZE, 187, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(btnLeftCat, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnLeftDragonfly, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnLeftHorse, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnLeftFly, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(jScrollPane1)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(btnRightFly, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnRightDragonfly, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnRightHorse, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnRightCat, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))))
            .addContainerGap())
         .addGroup(layout.createSequentialGroup()
            .addGap(220, 220, 220)
            .addComponent(txtAnimalName, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addComponent(txtAnimalName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGap(11, 11, 11)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(btnRightFly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnRightDragonfly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnRightHorse)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnRightCat))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(btnLeftFly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnLeftDragonfly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnLeftHorse)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                  .addComponent(btnLeftCat))
               .addComponent(jScrollPane1))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(txtLeftField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(txtRightField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void ComapareAnimal()
   {
      if((LeftObject==null)||(RightObject==null))
      {
         txtInfo.setText("Przynajmniej jeden obiekt jest pusty");
      }
      else
      {
         String str="";
         boolean Fc=LeftObject.getClass().equals(RightObject.getClass());
         boolean Fn=LeftObject.getName().equals(RightObject.getName());
         str+=Fc?"Ten sam gatunek":"Inny gatunek";
         str+=Fn?"To same imie":"Różne imiona";
         str+=(Fc&&Fn)?"To samo zwierze":"Inne zwierze";
         txtInfo.setText(str);
      }
   }
   
   private void btnLeftFlyMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnLeftFlyMouseClicked
      LeftObject=new Fly(txtAnimalName.getText());
      txtLeftField.setText(LeftObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnLeftFlyMouseClicked

   private void btnRightFlyMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnRightFlyMouseClicked
      RightObject=new Fly(txtAnimalName.getText());
      txtRightField.setText(RightObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnRightFlyMouseClicked

   private void btnLeftDragonflyMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnLeftDragonflyMouseClicked
      LeftObject=new Dragonfly(txtAnimalName.getText());
      txtLeftField.setText(LeftObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnLeftDragonflyMouseClicked

   private void btnRightDragonflyMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnRightDragonflyMouseClicked
      RightObject=new Dragonfly(txtAnimalName.getText());
      txtRightField.setText(RightObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnRightDragonflyMouseClicked

   private void btnLeftHorseMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnLeftHorseMouseClicked
      LeftObject=new Horse(txtAnimalName.getText());
      txtLeftField.setText(LeftObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnLeftHorseMouseClicked

   private void btnRightHorseMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnRightHorseMouseClicked
      RightObject=new Horse(txtAnimalName.getText());
      txtRightField.setText(RightObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnRightHorseMouseClicked

   private void btnLeftCatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLeftCatActionPerformed
      LeftObject=new Cat(txtAnimalName.getText());
      txtLeftField.setText(LeftObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnLeftCatActionPerformed

   private void btnRightCatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRightCatActionPerformed
      RightObject=new Cat(txtAnimalName.getText());
      txtRightField.setText(RightObject.toString());
      ComapareAnimal();
   }//GEN-LAST:event_btnRightCatActionPerformed

   public static void main(String args[]) {
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new AnimalMain().setVisible(true);
         }
      });
   }

   private Animal LeftObject = null ,RightObject = null;
   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnLeftCat;
   private javax.swing.JButton btnLeftDragonfly;
   private javax.swing.JButton btnLeftFly;
   private javax.swing.JButton btnLeftHorse;
   private javax.swing.JButton btnRightCat;
   private javax.swing.JButton btnRightDragonfly;
   private javax.swing.JButton btnRightFly;
   private javax.swing.JButton btnRightHorse;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JTextField txtAnimalName;
   private javax.swing.JTextArea txtInfo;
   private javax.swing.JTextField txtLeftField;
   private javax.swing.JTextField txtRightField;
   // End of variables declaration//GEN-END:variables
}

class Animal
{
   private final String name;
   public String getName() { return name; }
   public Animal(String name)
   {
      this.name=name;
   }
   public String WhoAmI()
   {
      return "Animal";
   }
   @Override public String toString()
   {
      return WhoAmI()+" "+getName();
   }
}

class Insect extends Animal
{
   public Insect(String name)
   {
      super(name);
   }
   @Override public String WhoAmI()
   {
      return super.WhoAmI()+":Insect";
   }
}

class Fly extends Insect
{
   public Fly(String name)
   {
      super(name);
   }
   @Override public String WhoAmI()
   {
      return super.WhoAmI()+":Fly";
   }
}

class Dragonfly extends Insect
{
   public Dragonfly(String name)
   {
      super(name);
   }
   @Override public String WhoAmI()
   {
      return super.WhoAmI()+":Dragonfly";
   }
}

class Mammal extends Animal
{
   public Mammal(String name)
   {
      super(name);
   }
   @Override public String WhoAmI()
   {
      return super.WhoAmI()+":Mammal";
   }
}

class Horse extends Mammal
{
   public Horse(String name)
   {
      super(name);
   }
   @Override public String WhoAmI()
   {
      return super.WhoAmI()+":Horse";
   }
}

class Cat extends Mammal
{
   public Cat(String name)
   {
      super(name);
   }
   @Override public String WhoAmI()
   {
      return super.WhoAmI()+":Cat";
   }
}