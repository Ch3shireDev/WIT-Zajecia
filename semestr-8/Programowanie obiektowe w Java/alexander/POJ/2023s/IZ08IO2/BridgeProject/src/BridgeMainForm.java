
import java.util.ArrayList;
import java.util.List;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class BridgeMainForm extends javax.swing.JFrame
{
    private DefaultComboBoxModel<String> modelShapeKinds=new DefaultComboBoxModel<>();
    private DefaultListModel<String> modelShapeList=new DefaultListModel<>();
    private List<ShapeBase> shapes=new ArrayList<>();
    private BridgeShapes bridgeToXml,bridgeToList,bridgeToImage;
    
    public BridgeMainForm()
    {
        initComponents();
        CbShapeKinds.setModel(modelShapeKinds);
        for(String key:ShapeFactory.keys) modelShapeKinds.addElement(key);
        CbShapeKinds.setSelectedIndex(0);
        LbShapeList.setModel(modelShapeList);
        bridgeToXml=new BridgeShapesToXml(TaXML);
        bridgeToList=new BridgeShapesToList(LbShapeList);
        bridgeToImage=new BridgeShapesToImage((JDrawPanel)PnDraw);        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbShapeKinds = new javax.swing.JComboBox<>();
        TfParameters = new javax.swing.JTextField();
        BtnAdd = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        LbShapeList = new javax.swing.JList<>();
        PnDraw = new JDrawPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        TaXML = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        CbShapeKinds.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Shape Kinds" }));

        TfParameters.setText("100 100 90");

        BtnAdd.setText("Add");
        BtnAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddActionPerformed(evt);
            }
        });

        LbShapeList.setModel(new javax.swing.AbstractListModel<String>() {
            String[] strings = { "Shape List" };
            public int getSize() { return strings.length; }
            public String getElementAt(int i) { return strings[i]; }
        });
        jScrollPane1.setViewportView(LbShapeList);

        PnDraw.addComponentListener(new java.awt.event.ComponentAdapter() {
            public void componentResized(java.awt.event.ComponentEvent evt) {
                PnDrawComponentResized(evt);
            }
        });

        javax.swing.GroupLayout PnDrawLayout = new javax.swing.GroupLayout(PnDraw);
        PnDraw.setLayout(PnDrawLayout);
        PnDrawLayout.setHorizontalGroup(
            PnDrawLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        PnDrawLayout.setVerticalGroup(
            PnDrawLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 213, Short.MAX_VALUE)
        );

        TaXML.setColumns(20);
        TaXML.setRows(5);
        jScrollPane2.setViewportView(TaXML);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addComponent(jScrollPane1)
                    .addComponent(BtnAdd, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(CbShapeKinds, javax.swing.GroupLayout.Alignment.LEADING, 0, 165, Short.MAX_VALUE)
                    .addComponent(TfParameters, javax.swing.GroupLayout.Alignment.LEADING))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(PnDraw, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 554, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(PnDraw, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 132, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbShapeKinds, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TfParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnAdd)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane1)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
        String key=CbShapeKinds.getSelectedItem().toString();
        String text=TfParameters.getText().trim();
        ShapeBase shape=ShapeFactory.make(key, text);
        shapes.add(shape);
        bridgeToXml.proceed(shapes);
        bridgeToList.proceed(shapes);
        bridgeToImage.proceed(shapes);
    }//GEN-LAST:event_BtnAddActionPerformed

    private void PnDrawComponentResized(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_PnDrawComponentResized
        bridgeToImage.proceed(shapes);
    }//GEN-LAST:event_PnDrawComponentResized

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new BridgeMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<String> CbShapeKinds;
    private javax.swing.JList<String> LbShapeList;
    private javax.swing.JPanel PnDraw;
    private javax.swing.JTextArea TaXML;
    private javax.swing.JTextField TfParameters;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    // End of variables declaration//GEN-END:variables
}
