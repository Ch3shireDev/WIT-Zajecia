import javax.swing.DefaultComboBoxModel;

public class BasicControlForm extends javax.swing.JFrame 
{
    private final DefaultComboBoxModel<String> kindsmodel=new DefaultComboBoxModel<>();
    public BasicControlForm() 
    {
        initComponents();
        for (String kind:AnimalFabric.kinds()) kindsmodel.addElement(kind);
        CbKinds.setModel(kindsmodel);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbKinds = new javax.swing.JComboBox<>();
        EdName = new javax.swing.JTextField();
        Btnsho = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        EdLog = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        CbKinds.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        EdName.setText("Feelow");

        Btnsho.setText("Show");
        Btnsho.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnshoActionPerformed(evt);
            }
        });

        EdLog.setColumns(20);
        EdLog.setRows(5);
        jScrollPane1.setViewportView(EdLog);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jScrollPane1)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(Btnsho)
                        .addGap(0, 182, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(Btnsho)
                    .addComponent(CbKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(EdName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 233, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnshoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnshoActionPerformed
        
        EdLog.append(CbKinds.getSelectedItem().toString() + System.lineSeparator());
        EdLog.append(EdName.getText() + System.lineSeparator());
    }//GEN-LAST:event_BtnshoActionPerformed

    public static void main(String args[]) 
    {
        java.awt.EventQueue.invokeLater
        (
            new Runnable()
            {
                @Override
                public void run() 
                {
                    new BasicControlForm().setVisible(true);
                }
            }
        );
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Btnsho;
    private javax.swing.JComboBox<String> CbKinds;
    private javax.swing.JTextArea EdLog;
    private javax.swing.JTextField EdName;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}
