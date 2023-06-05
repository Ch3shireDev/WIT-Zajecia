
import javax.swing.DefaultComboBoxModel;

public class BasicControlForm extends javax.swing.JFrame 
{
    private final DefaultComboBoxModel<String> kindmodel=new DefaultComboBoxModel<>();
    public BasicControlForm() 
    {
        initComponents();
        CbKinds.setModel(kindmodel);
        //for(int i=0;i<AnimalFabric.kinds().length;++i)  kindmodel.addElement(AnimalFabric.kinds()[i]);
        //for(int i=0;i<AnimalFabric.kinds().size();++i)  kindmodel.addElement(AnimalFabric.kinds().get(i));
        for(String kind:AnimalFabric.kinds()) kindmodel.addElement(kind);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbKinds = new javax.swing.JComboBox<>();
        EdName = new javax.swing.JTextField();
        BtnShow = new javax.swing.JButton();
        EdLogScroll = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        EdName.setText("Fellow");

        BtnShow.setText("Show");
        BtnShow.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnShowActionPerformed(evt);
            }
        });

        EdLog.setColumns(20);
        EdLog.setFont(new java.awt.Font("Monospaced", 0, 14)); // NOI18N
        EdLog.setRows(5);
        EdLogScroll.setViewportView(EdLog);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(EdLogScroll)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, 95, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnShow)
                        .addGap(0, 261, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(BtnShow)
                    .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EdLogScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 364, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnShowActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnShowActionPerformed
        Animal animal=AnimalFabric.make(CbKinds.getSelectedItem().toString(), EdName.getText());
        EdLog.append(animal + System.lineSeparator());
    }//GEN-LAST:event_BtnShowActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new BasicControlForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnShow;
    private javax.swing.JComboBox<String> CbKinds;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JScrollPane EdLogScroll;
    private javax.swing.JTextField EdName;
    // End of variables declaration//GEN-END:variables
}
