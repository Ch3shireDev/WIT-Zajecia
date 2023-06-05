public class AnimalsMain extends javax.swing.JFrame {

   public AnimalsMain() {
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
      txtName = new javax.swing.JTextField();
      scrollInfo = new javax.swing.JScrollPane();
      txtInfo = new javax.swing.JTextArea();
      txtLeftAnimal = new javax.swing.JTextField();
      txtRightAnimal = new javax.swing.JTextField();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setMinimumSize(new java.awt.Dimension(400, 250));

      btnLeftFly.setText("Fly");
      btnLeftFly.setName(""); // NOI18N
      btnLeftFly.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnLeftFlyActionPerformed(evt);
         }
      });

      btnLeftDragonfly.setText("Dragonfly");
      btnLeftDragonfly.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnLeftDragonflyActionPerformed(evt);
         }
      });

      btnLeftHorse.setText("Horse");
      btnLeftHorse.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnLeftHorseActionPerformed(evt);
         }
      });

      btnLeftCat.setText("Cat");
      btnLeftCat.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnLeftCatActionPerformed(evt);
         }
      });

      btnRightFly.setText("Fly");
      btnRightFly.setName(""); // NOI18N
      btnRightFly.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnRightFlyActionPerformed(evt);
         }
      });

      btnRightDragonfly.setText("Dragonfly");
      btnRightDragonfly.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnRightDragonflyActionPerformed(evt);
         }
      });

      btnRightHorse.setText("Horse");
      btnRightHorse.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnRightHorseActionPerformed(evt);
         }
      });

      btnRightCat.setText("Cat");
      btnRightCat.addActionListener(new java.awt.event.ActionListener() {
         public void actionPerformed(java.awt.event.ActionEvent evt) {
            btnRightCatActionPerformed(evt);
         }
      });

      txtName.setText("pet");

      txtInfo.setColumns(20);
      txtInfo.setRows(5);
      scrollInfo.setViewportView(txtInfo);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createSequentialGroup()
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(btnLeftCat, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnLeftFly, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnLeftDragonfly, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnLeftHorse, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE))
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(scrollInfo)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                     .addComponent(btnRightFly, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnRightDragonfly, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnRightHorse, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addComponent(btnRightCat, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)))
               .addGroup(layout.createSequentialGroup()
                  .addGap(0, 0, Short.MAX_VALUE)
                  .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(0, 0, Short.MAX_VALUE))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(txtLeftAnimal, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 20, Short.MAX_VALUE)
                  .addComponent(txtRightAnimal, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)))
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGap(10, 10, 10)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addGroup(layout.createSequentialGroup()
                  .addComponent(btnRightFly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnRightDragonfly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnRightHorse)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnRightCat))
               .addGroup(layout.createSequentialGroup()
                  .addComponent(btnLeftFly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnLeftDragonfly)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnLeftHorse)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(btnLeftCat))
               .addComponent(scrollInfo))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(txtLeftAnimal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
               .addComponent(txtRightAnimal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   private void Compare()
   {
      String txt="";
      if((LeftAnimal!=null)&&(RightAnimal!=null))
      {
         boolean fc=LeftAnimal.getClass().equals(RightAnimal.getClass());
         boolean fn=LeftAnimal.getName().equals(RightAnimal.getName());
         txt+=fc?"Identyczna klasa\n":"Rożne klasy\n";
         txt+=fn?"Identyczne imiona\n":"Rożne imiona\n";
         txt+=(fc&&fn)?"To samo zwierzątko\n":"inne zwierzątka\n";
      }
      else txt="Przynajmniej jednego brakuje";
      txtInfo.setText(txt);
   }
   
   private void SetLeft(Animal a)
   {
      LeftAnimal = a;
      txtLeftAnimal.setText(a.WhoAmI());
      Compare();
   }
   
   private void SetRight(Animal a)
   {
      RightAnimal = a;
      txtRightAnimal.setText(a.WhoAmI());
      Compare();
   }
   
   private void btnLeftFlyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLeftFlyActionPerformed
      SetLeft(new Fly(txtName.getText()));
   }//GEN-LAST:event_btnLeftFlyActionPerformed

   private void btnLeftDragonflyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLeftDragonflyActionPerformed
      SetLeft(new Dragonfly(txtName.getText()));
   }//GEN-LAST:event_btnLeftDragonflyActionPerformed

   private void btnLeftHorseActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLeftHorseActionPerformed
      SetLeft(new Horse(txtName.getText()));
   }//GEN-LAST:event_btnLeftHorseActionPerformed

   private void btnLeftCatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLeftCatActionPerformed
      SetLeft(new Cat(txtName.getText()));
   }//GEN-LAST:event_btnLeftCatActionPerformed

   private void btnRightFlyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRightFlyActionPerformed
      SetRight(new Fly(txtName.getText()));
   }//GEN-LAST:event_btnRightFlyActionPerformed

   private void btnRightDragonflyActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRightDragonflyActionPerformed
      SetRight(new Dragonfly(txtName.getText()));
   }//GEN-LAST:event_btnRightDragonflyActionPerformed

   private void btnRightHorseActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRightHorseActionPerformed
      SetRight(new Horse(txtName.getText()));
   }//GEN-LAST:event_btnRightHorseActionPerformed

   private void btnRightCatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRightCatActionPerformed
      SetRight(new Cat(txtName.getText()));
   }//GEN-LAST:event_btnRightCatActionPerformed

   public static void main(String args[]) {
      java.awt.EventQueue.invokeLater(new Runnable() {
         public void run() {
            new AnimalsMain().setVisible(true);
         }
      });
   }

   Animal LeftAnimal = null, RightAnimal = null;
   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JButton btnLeftCat;
   private javax.swing.JButton btnLeftDragonfly;
   private javax.swing.JButton btnLeftFly;
   private javax.swing.JButton btnLeftHorse;
   private javax.swing.JButton btnRightCat;
   private javax.swing.JButton btnRightDragonfly;
   private javax.swing.JButton btnRightFly;
   private javax.swing.JButton btnRightHorse;
   private javax.swing.JScrollPane scrollInfo;
   private javax.swing.JTextArea txtInfo;
   private javax.swing.JTextField txtLeftAnimal;
   private javax.swing.JTextField txtName;
   private javax.swing.JTextField txtRightAnimal;
   // End of variables declaration//GEN-END:variables
}

class AnimalBase
{
   private final String name;
   public String getName() { return name; }
   public AnimalBase(String name)
   {
      this.name=name;
   }
   public String path()
   {
      return "";
   }
   public String WhoAmI()
   {
      return path()+" "+name;
   }
}

class Animal extends AnimalBase
{
   public Animal(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return "Animal";
   }   
}

class Insect extends Animal
{
   public Insect(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return super.path()+":Insect";
   }   
}

class Mammal extends Animal
{
   public Mammal(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return super.path()+":Mammal";
   }   
}

class Fly extends Insect
{
   public Fly(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return super.path()+":Fly";
   }   
}

class Dragonfly extends Insect
{
   public Dragonfly(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return super.path()+":Dragonfly";
   }   
}

class Horse extends Mammal
{
   public Horse(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return super.path()+":Horse";
   }   
}

class Cat extends Mammal
{
   public Cat(String name) 
   {
      super(name);
   }
   @Override public String path()
   {
      return super.path()+":Cat";
   }   
}
