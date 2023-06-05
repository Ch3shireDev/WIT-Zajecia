public class IterableForm extends javax.swing.JFrame
{

   public IterableForm()
   {
      initComponents();
      for(Student str : IterableFunction.Arr(new Student("Piotr","Kowalski",7),new Student("Adam","Sikorski",6),new Student("Jan","Kowalski",5)))
      {
         EdLog.append(str+System.lineSeparator());
      }
      EdLog.append(System.lineSeparator());
      for(Student str : IterableFunction.Arr(new Student.IndexComparator(),new Student("Piotr","Kowalski",7),new Student("Adam","Sikorski",6),new Student("Jan","Kowalski",5)))
      {
         EdLog.append(str+System.lineSeparator());
      }
   }

   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      EdLogScroll = new javax.swing.JScrollPane();
      EdLog = new javax.swing.JTextArea();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

      EdLog.setColumns(20);
      EdLog.setRows(5);
      EdLogScroll.setViewportView(EdLog);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 380, Short.MAX_VALUE)
            .addContainerGap())
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 278, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   public static void main(String args[])
   {
      java.awt.EventQueue.invokeLater(() -> new IterableForm().setVisible(true));
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JTextArea EdLog;
   private javax.swing.JScrollPane EdLogScroll;
   // End of variables declaration//GEN-END:variables
}
