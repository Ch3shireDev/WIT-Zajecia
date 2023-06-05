import Animals.Animal;
import Animals.AnimalFactory;
import javax.swing.DefaultComboBoxModel;

public class BasicControlForm extends javax.swing.JFrame {

    private final DefaultComboBoxModel<String> kindmodel=new DefaultComboBoxModel<>();
    private final DefaultComboBoxModel<Animal> animalmodel=new DefaultComboBoxModel<>();
    public BasicControlForm() 
    {
        initComponents();
        CbKinds.setModel(kindmodel);
        for(String kind:AnimalFactory.keys())  kindmodel.addElement(kind);
        CbAnimals.setModel(animalmodel);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();
        BtnStart = new javax.swing.JButton();
        CbKinds = new javax.swing.JComboBox<>();
        EdName = new javax.swing.JTextField();
        CbAnimals = new javax.swing.JComboBox<>();
        BtnMake = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        EdLog.setColumns(20);
        EdLog.setFont(new java.awt.Font("Lucida Console", 0, 14)); // NOI18N
        EdLog.setRows(5);
        EdLogScroll.setViewportView(EdLog);

        BtnStart.setText("Start");
        BtnStart.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnStartActionPerformed(evt);
            }
        });

        CbKinds.setMaximumRowCount(9);

        EdName.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        EdName.setText("Fellow");

        BtnMake.setText("Make and Store");
        BtnMake.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnMakeActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 552, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(BtnStart))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, 111, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnMake)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(CbAnimals, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CbAnimals, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BtnMake))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 165, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(BtnStart)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnStartActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnStartActionPerformed
        //EdLog.append("Ala ma kota " + System.lineSeparator());
        //EdLog.append(CbKinds.getSelectedItem() + System.lineSeparator());
        //EdLog.append(EdName.getText() + System.lineSeparator());
        EdLog.append(CbAnimals.getSelectedItem() + System.lineSeparator());
    }//GEN-LAST:event_BtnStartActionPerformed

    private void BtnMakeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnMakeActionPerformed
        String kind=CbKinds.getSelectedItem().toString();
        String name=EdName.getText();
        Animal animal=AnimalFactory.make(kind,name);
        animalmodel.addElement(animal);
        EdLog.append(animal + System.lineSeparator());
    }//GEN-LAST:event_BtnMakeActionPerformed

    public static void main(String args[]) 
    {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new BasicControlForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnMake;
    private javax.swing.JButton BtnStart;
    private javax.swing.JComboBox<Animal> CbAnimals;
    private javax.swing.JComboBox<String> CbKinds;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    private javax.swing.JTextField EdName;
    // End of variables declaration//GEN-END:variables
}
