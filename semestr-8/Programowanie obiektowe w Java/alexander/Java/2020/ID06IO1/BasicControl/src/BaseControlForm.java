
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;

public class BaseControlForm extends javax.swing.JFrame {

    private final DefaultComboBoxModel<String> kindmodel=new DefaultComboBoxModel<>();
    private final DefaultComboBoxModel<Animal> animalmodel=new DefaultComboBoxModel<>();
    public BaseControlForm() {
        initComponents();
        //for(int i=0;i<AnimalFabric.keys().size();++i) kindmodel.addElement(AnimalFabric.keys().get(i));
        //for(int i=0;i<AnimalFabric.keys().length;++i) kindmodel.addElement(AnimalFabric.keys()[i]);
        for(String kind:AnimalFabric.keys()) kindmodel.addElement(kind);
        //kindmodel.addAll(AnimalFabric.keys());
        CbKinds.setModel(kindmodel);
        CbAnimals.setModel(animalmodel);
        //ArrayList<String> tb=new ArrayList<String>(){ { add("ala"); add("ma"); add("kota"); } };
        //ArrayList<String> lst=new ArrayList<>();
        //lst.addAll(tb);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbKinds = new javax.swing.JComboBox<>();
        EdName = new javax.swing.JTextField();
        BtnAdd = new javax.swing.JButton();
        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();
        CbAnimals = new javax.swing.JComboBox<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        EdName.setText("Fellow");

        BtnAdd.setText("Add");
        BtnAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddActionPerformed(evt);
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
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(EdLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnAdd)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 288, Short.MAX_VALUE)
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
                    .addComponent(BtnAdd)
                    .addComponent(CbAnimals, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 240, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
        //EdLog.append("Ala ma kota" + System.lineSeparator());       
        //EdLog.append(CbKinds.getSelectedItem() + System.lineSeparator());
        //EdLog.append(EdName.getText()+ System.lineSeparator());
        Animal animal=AnimalFabric.make(CbKinds.getSelectedItem().toString(),EdName.getText());
        EdLog.append(animal+ System.lineSeparator());
    }//GEN-LAST:event_BtnAddActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new BaseControlForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<Animal> CbAnimals;
    private javax.swing.JComboBox<String> CbKinds;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    private javax.swing.JTextField EdName;
    // End of variables declaration//GEN-END:variables
}
