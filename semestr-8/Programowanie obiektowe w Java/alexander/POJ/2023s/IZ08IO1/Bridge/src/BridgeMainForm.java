
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

public class BridgeMainForm extends javax.swing.JFrame
{
    private DefaultComboBoxModel<String> modelShapes=new DefaultComboBoxModel<>();
    private DefaultListModel<String> modelShapeList=new DefaultListModel<>();
    private ArrayList<ShapeBase> shapes=new ArrayList<>();
    private BridgeShapeListBase xmlBridge,listBridge,drawBridge;
    public BridgeMainForm()
    {
        initComponents();
        CbShapes.setModel(modelShapes);
        LbShapeList.setModel(modelShapeList);
        for(String key:ShapeFactory.keys) modelShapes.addElement(key);
        CbShapes.setSelectedIndex(0);
        xmlBridge=new BridgeShapeListToXML(TaXML);
        listBridge=new BridgeShapeListToListbox(LbShapeList);
        BridgeShapeListToDrawPanel drawBridge=new BridgeShapeListToDrawPanel((DrawPanel)PnImage);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        CbShapes = new javax.swing.JComboBox<>();
        TfParameters = new javax.swing.JTextField();
        LbShapeListScroll = new javax.swing.JScrollPane();
        LbShapeList = new javax.swing.JList<>();
        BtnAdd = new javax.swing.JButton();
        TaXMLScroll = new javax.swing.JScrollPane();
        TaXML = new javax.swing.JTextArea();
        PnImage = new DrawPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        CbShapes.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "shapes" }));

        TfParameters.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
        TfParameters.setText("100 100 90");

        LbShapeList.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
        LbShapeList.setModel(new javax.swing.AbstractListModel<String>() {
            String[] strings = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            public int getSize() { return strings.length; }
            public String getElementAt(int i) { return strings[i]; }
        });
        LbShapeListScroll.setViewportView(LbShapeList);

        BtnAdd.setText("Add");
        BtnAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnAddActionPerformed(evt);
            }
        });

        TaXML.setColumns(20);
        TaXML.setFont(new java.awt.Font("Lucida Console", 0, 12)); // NOI18N
        TaXML.setRows(5);
        TaXMLScroll.setViewportView(TaXML);

        PnImage.addComponentListener(new java.awt.event.ComponentAdapter() {
            public void componentResized(java.awt.event.ComponentEvent evt) {
                PnImageComponentResized(evt);
            }
        });

        javax.swing.GroupLayout PnImageLayout = new javax.swing.GroupLayout(PnImage);
        PnImage.setLayout(PnImageLayout);
        PnImageLayout.setHorizontalGroup(
            PnImageLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        PnImageLayout.setVerticalGroup(
            PnImageLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(LbShapeListScroll)
                    .addComponent(TfParameters, javax.swing.GroupLayout.DEFAULT_SIZE, 180, Short.MAX_VALUE)
                    .addComponent(CbShapes, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(BtnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TaXMLScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 445, Short.MAX_VALUE)
                    .addComponent(PnImage, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(PnImage, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TaXMLScroll, javax.swing.GroupLayout.PREFERRED_SIZE, 114, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(CbShapes, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TfParameters, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(BtnAdd)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(LbShapeListScroll, javax.swing.GroupLayout.DEFAULT_SIZE, 338, Short.MAX_VALUE)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnAddActionPerformed
        String key=CbShapes.getSelectedItem().toString();
        String parameters=TfParameters.getText().trim();
        ShapeBase shape=ShapeFactory.make(key, parameters);
        shapes.add(shape);
        xmlBridge.Proceed(shapes);
        listBridge.Proceed(shapes);
        drawBridge.Proceed(shapes);
    }//GEN-LAST:event_BtnAddActionPerformed

    private void PnImageComponentResized(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_PnImageComponentResized
        if(drawBridge!=null) drawBridge.Proceed(shapes);
    }//GEN-LAST:event_PnImageComponentResized

    public static void main(String args[])
    {
        java.awt.EventQueue.invokeLater(() -> new BridgeMainForm().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton BtnAdd;
    private javax.swing.JComboBox<String> CbShapes;
    private javax.swing.JList<String> LbShapeList;
    private javax.swing.JScrollPane LbShapeListScroll;
    private javax.swing.JPanel PnImage;
    private javax.swing.JTextArea TaXML;
    private javax.swing.JScrollPane TaXMLScroll;
    private javax.swing.JTextField TfParameters;
    // End of variables declaration//GEN-END:variables
}
